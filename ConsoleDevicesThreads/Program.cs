using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ConsoleDevicesThreads {
	class Program {
		public static List<MesinAbsenDTO> mesinAbsens { get; set; }
		public static List<JadwalKerjaKaryawanDTO> ListJadwalKaryawan { get; set; } = new();
		public static List<JadwalKerjaSecurityDTO> ListJadwalSecurity { get; set; } = new();
		static void Main(string[] args) {
			mesinAbsens = GetMesinAbsens();
			int intWorkCount = mesinAbsens.Count;
			WorkThread[] Device = new WorkThread[intWorkCount];
			bool blSetMaxThread = ThreadPool.SetMaxThreads(intWorkCount, 500);
			if(!blSetMaxThread) {
				Console.WriteLine("Setting max threads of the threadpool failed!");
			}
			for(int i=0; i < intWorkCount; i++) {
				Device[i] = new WorkThread(mesinAbsens[i].DeviceIP, mesinAbsens[i].Port);
				ThreadPool.QueueUserWorkItem(Device[i].ThreadPoolCallBack);
			}

			Console.WriteLine("Pls Wait for a moment......Current Time:" + DateTime.Now.ToLongTimeString());

			Console.ReadKey();
		}

		static List<MesinAbsenDTO> GetMesinAbsens() {
			try {
				var response = GetMesinAbsenAsync().GetAwaiter().GetResult();
				return response;
			}
			catch (InvalidOperationException e) {
				Console.WriteLine($"Error Message: {e.Message}");
				throw;
			}
		}
		static async Task<List<MesinAbsenDTO>> GetMesinAbsenAsync() {
			int tries = 0;
			int numOfRetries = 5;
			while(tries <= numOfRetries) {
				try {
					using var client = new HttpClient();
					const string uri = "https://localhost:7023/MesinAbsens";
					HttpResponseMessage response = await client.GetAsync(uri);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == HttpStatusCode.NoContent) {
							return (List<MesinAbsenDTO>)Enumerable.Empty<MesinAbsenDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<MesinAbsenDTO>>();
					}
					else {
						var message = await response.Content.ReadAsStringAsync();
						throw new Exception($"Http status code: {response.StatusCode} message: {message}");
					}
				}
				catch {
					tries++;
				}
			}
			throw new RetryException($"Error after {tries}");

		}

		public async Task AddAbsen(KehadiranDTO newHadir) {
			HttpClient client = new();
			HttpResponseMessage response = await client.PostAsJsonAsync($"{BaseUrl.LocalBaseUrl}/Kehadiran/Absen", newHadir);
			var hdr = await response.Content.ReadFromJsonAsync<KehadiranDTO>();
			string strMessage;
			if (response.IsSuccessStatusCode) {
				strMessage = $"Karyawan: {hdr?.Nama}({hdr?.NIK}) berhasil absen";
			}
			else {
				strMessage = $"Karyawan: {newHadir.Nama} {newHadir.NIK} gagal absen!";
			}
			//frm.listBox1.Items.Add(strMessage);
			Console.WriteLine(strMessage);
		}

	}

	class WorkThread {
		string strIP = "0.0.0.0";
		int? intPort = 4370;
		int intMachineNumber = 1;
		int intThreadID = 0;
		int intLastTry = 0;
		int intDelay = 2;
		private static int intCounter = 0;
		private static int intConnectedCount = 0;

		public zkemkeeper.CZKEM sdk = new();

      public WorkThread(string swIP, int? iwPort)
      {
         strIP = swIP;
			intPort = iwPort;
			intThreadID = ++intCounter;
      }

		public void ThreadPoolCallBack(Object? objThreadContext) {
			int intCurrentTime = 0;
			intLastTry = GetTimeInMinute();
			while (true) {
				intCurrentTime = GetTimeInMinute();
				while (intLastTry == intCurrentTime) {
					Thread.Sleep(30);
					intCurrentTime = GetTimeInMinute();
				}
				intLastTry = intCurrentTime;
				intDelay--;
				if (intDelay == 1) {
					this.WakeUp();
				}
			}

			//this.WakeUp();
		}

		public void WakeUp() {
			bool blResult = sdk.Connect_Net(strIP, Convert.ToInt32(intPort));
			//int idwErrorCode = 0;
			if(!blResult) {
				//sdk.GetLastError(ref idwErrorCode);
				Console.WriteLine("Connecting " + strIP + " Failed...Current Time: " + DateTime.Now.ToLongTimeString());
				//return;
			}
			intConnectedCount++;
			Console.WriteLine("IP: " + strIP + " ThreadID: " + intThreadID.ToString() + " ConnectedCount: " + intConnectedCount.ToString() + " ConnectedTime: " + DateTime.Now.ToLongTimeString());
			Console.WriteLine("Successfully Connect: " + strIP);
			sdk.EnableDevice(intMachineNumber, true);

			if (sdk.RegEvent(intMachineNumber, 65535)) {
				sdk.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(sdk_OnFinger);
				sdk.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(sdk_OnVerfify);
				sdk.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(sdk_OnAttTransactionEx);
				sdk.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(sdk_OnFingerFeature);
				sdk.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(sdk_OnEnrollFingerEx);
				this.sdk.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(sdk_OnDeleteTemplate);
				this.sdk.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(sdk_OnNewUser);
				this.sdk.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(sdk_OnHIDNum);
				this.sdk.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(sdk_OnAlarm);
				this.sdk.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(sdk_OnDoor);
				this.sdk.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(sdk_OnWriteCard);
				this.sdk.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(sdk_OnEmptyCard);
			}

		}

		private void sdk_OnEnrollFingerEx(string sEnrollNumber, int iFingerIndex, int iActionResult, int iTemplateLength) {
			if (iActionResult == 0) {
				Console.WriteLine("RTEvent OnEnrollFigerEx Has been Triggered....");
				Console.WriteLine(".....UserID: " + sEnrollNumber + " Index: " + iFingerIndex.ToString() + " tmpLen: " + iTemplateLength.ToString());
			}
			else {
				Console.WriteLine("RTEvent OnEnrollFigerEx Has been Triggered Error,actionResult=" + iActionResult.ToString());
			}
		}

		private void sdk_OnDeleteTemplate(int iEnrollNumber, int iFingerIndex) {
			Console.WriteLine("RTEvent OnDeleteTemplate Has been Triggered...");
			Console.WriteLine("...UserID=" + iEnrollNumber.ToString() + " FingerIndex=" + iFingerIndex.ToString());
		}

		private void sdk_OnNewUser(int iEnrollNumber) {
			Console.WriteLine("RTEvent OnNewUser Has been Triggered...");
			Console.WriteLine("...NewUserID=" + iEnrollNumber.ToString());
		}

		private void sdk_OnHIDNum(int iCardNumber) {
			Console.WriteLine("RTEvent OnHIDNum Has been Triggered...");
			Console.WriteLine("...Cardnumber=" + iCardNumber.ToString());
		}

		private void sdk_OnAlarm(int iAlarmType, int iEnrollNumber, int iVerified) {
			Console.WriteLine("RTEvnet OnAlarm Has been Triggered...");
			Console.WriteLine("...AlarmType=" + iAlarmType.ToString());
			Console.WriteLine("...EnrollNumber=" + iEnrollNumber.ToString());
			Console.WriteLine("...Verified=" + iVerified.ToString());
		}

		private void sdk_OnDoor(int iEventType) {
			Console.WriteLine("RTEvent Ondoor Has been Triggered...");
			Console.WriteLine("...EventType=" + iEventType.ToString());
		}

		private void sdk_OnWriteCard(int iEnrollNumber, int iActionResult, int iLength) {
			Console.WriteLine("RTEvent OnWriteCard Has been Triggered...");
			if (iActionResult == 0) {
				Console.WriteLine("...Write Mifare Card OK");
				Console.WriteLine("...EnrollNumber=" + iEnrollNumber.ToString());
				Console.WriteLine("...TmpLength=" + iLength.ToString());
			}
			else {
				Console.WriteLine("...Write Failed");
			}
		}

		private void sdk_OnEmptyCard(int iActionResult) {
			Console.WriteLine("RTEvent OnEmptyCard Has been Triggered...");
			if (iActionResult == 0) {
				Console.WriteLine("...Empty Mifare Card OK");
			}
			else {
				Console.WriteLine("...Empty Failed");
			}
		}

		private int GetTimeInMinute() {
			return((DateTime.Now.Hour*24)+DateTime.Now.Minute);
		}

		private void sdk_OnFingerFeature(int iScore) {
			//throw new NotImplementedException();
			if (iScore < 0) {
				Console.WriteLine("The quality of your fingerprint is poor");
			}
			else {
				Console.WriteLine("RTEvent OnFingerFeature Has been Triggered...Score:　" + iScore.ToString());
			}
		}

		private void sdk_OnFinger() {
			Console.WriteLine("Real Time Event has been triggered...");
		}
		private void sdk_OnVerfify(int intUserID) {
			Console.WriteLine("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				Console.WriteLine("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				Console.WriteLine("Verified failed...");
			}
		}

		private async void sdk_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			sdk.EnableDevice(intMachineNumber, true);

			string nik = sEnrollNumber.ToString();
			JadwalKerjaKaryawanDTO jadwalKaryawan;
			JadwalKerjaSecurityDTO jadwalSecurity;
			DateTime? tglSekarang = DateTime.Now.Date;
			TimeSpan? jamSekarang = DateTime.Now.TimeOfDay;

			var karyawan = Program.ListJadwalKaryawan.SingleOrDefault(j => j.NIK == nik && j.Tgl.Value.Date == tglSekarang);
			if (karyawan != null) {
				KehadiranDTO newAbsen = new() {
					GrupKerja = karyawan.GroupName,
					NIK = karyawan.NIK,
					Nama = karyawan.NamaKaryawan,
					Tanggal = tglSekarang,
					JadwalMasuk = karyawan.JamMasuk,
					JamMasuk = jamSekarang.Value,
					JadwalPulang = karyawan.JamPulang
				};
				Program program = new();
				await program.AddAbsen(newAbsen);
			}
			//string nik = sEnrollNumber.ToString();

			//TimeSpan? jamSekarang = DateTime.Now.TimeOfDay;
			//HttpClient client = new();
			//var response = await client.GetAsync($"https://localhost:7023/JadwalKerjaKaryawan/NIK/{nik}");
			//Console.WriteLine(response.IsSuccessStatusCode);
			//if (response.IsSuccessStatusCode) {
			//	if (response.StatusCode == System.Net.HttpStatusCode.OK) {
			//		JadwalKerjaKaryawanDTO? jadwal = await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
			//		AbsenMasukDTO newHadir = new() {
			//			Id = 0,
			//			NIK = sEnrollNumber.ToString(),
			//			Tanggal = DateTime.Now,
			//		};
			//		if (jamSekarang.Value <= jadwal.JamMasuk.Value || (jamSekarang.Value > jadwal.JamMasuk.Value && jamSekarang.Value <= jadwal.JamPulang.Value)) {
			//			newHadir.JamMasuk = jamSekarang.Value;
			//			newHadir.JadwalMasuk = jadwal.JamMasuk.Value;
			//			AddAbsenMasuk(newHadir);
			//		}

			//		if (jamSekarang.Value >= jadwal.JamPulang.Value) {
			//			//newHadir.JamPulang = jamSekarang.Value;
			//			//newHadir.JadwalPulang = jadwal.JamPulang;
			//			AddAbsenPulang(newHadir);

			//		}
			//	}
			//}
			//sdk.EnableDevice(intMachineNumber, true);
		}

		private async void AddAbsenPulang(AbsenMasukDTO hadir) {
			//HttpClient client1 = new() {
			//	BaseAddress = new Uri("https://localhost:7023/")
			//};
			HttpClient client1 = new();
			var response1 = await client1.PutAsJsonAsync<AbsenMasukDTO>("https://localhost:7023/Kehadiran", hadir);
			if (response1.IsSuccessStatusCode) {
				if (response1.StatusCode == System.Net.HttpStatusCode.OK) {
					//Add Payroll
					//if (hadir.JamPulang.Value.Subtract(hadir.JamMasuk.Value).TotalMinutes > 480) {
					//	AddPayroll(hadir.NIK);
					//}
				}
				else if (response1.StatusCode == System.Net.HttpStatusCode.NoContent) {
					Console.WriteLine("Karyawan dengan NIK: " + hadir.NIK + " gagal absen, karena belum absen masuk");
				}
			}
		}

		private async void AddAbsenMasuk(AbsenMasukDTO newHadir) {
			HttpClient client = new();
			HttpResponseMessage response = await client.PostAsJsonAsync<AbsenMasukDTO>("https://localhost:7023/Kehadiran", newHadir);

			if (response.IsSuccessStatusCode) {
				if (response.StatusCode == System.Net.HttpStatusCode.OK) {
					Console.WriteLine("Karyawan dengan NIK: " + newHadir.NIK + " berhasil absen masuk");
				}
			}
		}

		private async void AddPayroll(string enrollNumber) {
			string nik = enrollNumber;
			HttpClient client = new();
			var response = await client.GetAsync($"https://localhost:7023/Gaji/NIK/{nik}");
			GajiDanTunjanganDTO gaji = await response.Content.ReadFromJsonAsync<GajiDanTunjanganDTO>();
			decimal upahHarian = Math.Round((decimal)gaji.Upah / 25, 2);
			PayrollDTO payroll = new() {
				NIK = gaji.NIK,
				IdEmployee = gaji.EmployeeId.Value,
				EmployeeName = gaji.NamaKaryawan,
				GroupName = gaji.GrupKerja,
				DepartmentName = gaji.DepartmentName,
				Upah = gaji.Upah,
				TotalMasuk = 1,
				TotalLembur = 0,
				Bulan = DateTime.Today.Month,
				Tahun = DateTime.Today.Year,
				Gaji = upahHarian,
				CreatedBy = 1,
				UpdatedBy = 1,
				UpdatedAt = DateTime.Today,
				CreatedAt = DateTime.Today,
			};

			HttpClient client1 = new();
			var response1 = await client1.PostAsJsonAsync<PayrollDTO>("Payroll", payroll);
			if (response1.IsSuccessStatusCode) {
				if(response1.StatusCode != System.Net.HttpStatusCode.OK) {
					Console.WriteLine("Karyawan dengan NIK: " + enrollNumber + " berhasil absen masuk");
				}
			}
		}



	}

	class RetryException: Exception {
        public RetryException(string? message): base(message)
        {}
   }
}