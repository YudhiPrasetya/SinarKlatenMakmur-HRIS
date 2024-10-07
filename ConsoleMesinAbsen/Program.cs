// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SKM.Shared.Dtos;
using System.Net.Http.Json;
using System.Net;
using Newtonsoft.Json;
using System.Text;

namespace ConsoleMesinAbsen {
	class Program {
		public static List<MesinAbsenDTO> mesinAbsens { get; set; }

		static void Main(string[] args) {
			mesinAbsens = GetMesinAbsens();
			foreach(var mesin in mesinAbsens) {
				//MesinAbsenThread mesinAbsenThread = new();
				//bool connected = mesinAbsenThread.ConnectToDevice(mesin.DeviceIP, mesin.Port);
				//if (!connected) {
				//	Console.WriteLine($"Mesin Absen dengan IP: {mesin.DeviceIP} Port: {mesin.Port} gagal terhubung!");
				//}
				//Console.WriteLine($"Mesin Absen dengan IP: {mesin.DeviceIP} Port: {mesin.Port} berhasil terhubung");
				//ThreadPool.QueueUserWorkItem(mesinAbsenThread.ThreadPollCallBack);
				zkemkeeper.CZKEM sdk = new();
				bool connected = sdk.Connect_Net(mesin.DeviceIP, mesin.Port);
				if(connected) {
					sdk.EnableDevice(1, true);
					Console.WriteLine($"Mesin Absen dgn IP: {mesin.DeviceIP}, Port: {mesin.Port} berhasil terhubung");
					Task.Delay(100);

					if (sdk.RegEvent(1, 1)) {
						Task task = Task.Run(() => {
							sdk.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(sdk_OnAttTransactionEx);
						});
					}
				}
				else {
					Console.WriteLine($"Mesin Absen dgn IP: {mesin.DeviceIP}, Port: {mesin.Port} gagal terhubung!");

				}
				Console.ReadKey();
         }

			static async void sdk_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
            //mesinAbsen3.EnableDevice(1, false);
            try {
               string nik = sEnrollNumber.ToString();
               int year = DateTime.Now.Year;
               int month = DateTime.Now.Month;
               int day = DateTime.Now.Day;
               string strDate = year.ToString() + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (day < 10 ? "0" + day.ToString() : day.ToString());

               HttpResponseMessage response = new HttpResponseMessage();
               //string result = "";
               JadwalKerjaKaryawan jadwalKaryawan = new JadwalKerjaKaryawan();
               JadwalKerjaSecurity jadwalSecurity = new JadwalKerjaSecurity();
               Kehadiran kehadiran = new Kehadiran();
               HttpClient httpClient = new HttpClient();

               response = await httpClient.GetAsync($"{BaseUrl.ServerBaseUrl}/JadwalKerjaKaryawan/NIKAndDate/{nik}/{strDate}");
               var result = await response.Content.ReadAsStringAsync();
               Console.WriteLine($"result.IsNull-> {string.IsNullOrEmpty(result)}");
               jadwalKaryawan = JsonConvert.DeserializeObject<JadwalKerjaKaryawan>(result);
               Console.WriteLine($" jadwalKaryawan3->NIK: {jadwalKaryawan.NIK}, Nama: {jadwalKaryawan.NamaKaryawan}, Grup: {jadwalKaryawan.GroupName}");
               if (jadwalKaryawan != null) {
                  kehadiran.GrupKerja = jadwalKaryawan.GroupName;
                  kehadiran.NIK = jadwalKaryawan.NIK;
                  kehadiran.Nama = jadwalKaryawan.NamaKaryawan;
                  kehadiran.Tanggal = DateTime.Now.Date;
                  kehadiran.JadwalMasuk = jadwalKaryawan.JamMasuk;
                  kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
                  kehadiran.JadwalPulang = jadwalKaryawan.JamPulang;
               }
               else {
                  response = await httpClient.GetAsync($"{BaseUrl.ServerBaseUrl}/JadwalKerjaSecurity/NIKAndDate/{nik}/{strDate}");
                  result = await response.Content.ReadAsStringAsync();
                  jadwalSecurity = JsonConvert.DeserializeObject<JadwalKerjaSecurity>(result);
                  if (jadwalSecurity != null) {
                     kehadiran.GrupKerja = jadwalKaryawan.GroupName;
                     kehadiran.NIK = jadwalKaryawan.NIK;
                     kehadiran.Nama = jadwalKaryawan.NamaKaryawan;
                     kehadiran.Tanggal = DateTime.Now.Date;
                     kehadiran.JadwalMasuk = jadwalKaryawan.JamMasuk;
                     kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
                     kehadiran.JadwalPulang = jadwalKaryawan.JamPulang;
                  }
               }
               string message = await AddAbsen(kehadiran);
               Console.WriteLine(message);
            }
            catch (HttpRequestException ex) {
               Console.WriteLine($"HttpRequestException from mesinAbsen3 -> {ex.Message}");
            }


         }
         //Console.ReadKey();

         static async Task<string> AddAbsen(Kehadiran newHadir) {
            var content = new StringContent(JsonConvert.SerializeObject(newHadir), Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync($"{BaseUrl.ServerBaseUrl}/Kehadiran/Absen", content);
            var result = await response.Content.ReadAsStringAsync();
            var hadir = JsonConvert.DeserializeObject<Kehadiran>(result);
            if (hadir != null) {
               return $"NIK: {hadir.NIK}, Nama: {hadir.Nama}, Grup: {hadir.GrupKerja} berhasil absen masuk pada: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}";
				}
				else {
               return $"NIK: {newHadir.NIK}, Nama: {newHadir.Nama}, Grup: {newHadir.GrupKerja} berhasil absen pulang pada: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}";
            }

            //return "xxxx";
         }
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
			while (tries <= numOfRetries) {
				try {
					using var client = new HttpClient();
					const string uri = $"{BaseUrl.ServerBaseUrl}/MesinAbsens";
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
	}

	class MesinAbsenThread {
		private static int intConnectedCount = 0;
		zkemkeeper.CZKEM sdk = new();
		public bool ConnectToDevice(string IP, int Port) {
			bool connected = sdk.Connect_Net(IP, Port);
			if (connected) {
				sdk.EnableDevice(1, true);
			}
			return connected;
		}

		public void MesinAbsenTasks() {
			if(sdk.RegEvent(1, 65535)) {
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

		public void ThreadPollCallBack(Object? obj) {
			this.MesinAbsenTasks();
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
			return ((DateTime.Now.Hour * 24) + DateTime.Now.Minute);
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
			sdk.EnableDevice(1, true);
			string nik = sEnrollNumber.ToString();

			TimeSpan? jamSekarang = DateTime.Now.TimeOfDay;
			HttpClient client = new();


		}
	}

	class RetryException : Exception {
		public RetryException(string? message) : base(message) { }
	}

   class JadwalKerjaKaryawan {
      public int Id { get; set; }
      public string NIK { get; set; }
      public string NamaKaryawan { get; set; }
      public string GroupName { get; set; }
      //public DateTime? TglAwal { get; set; }
      //public DateTime? TglAkhir { get; set; }
      public DateTime? Tgl { get; set; }
      public string Shift { get; set; }
      public TimeSpan? JamMasuk { get; set; }
      public TimeSpan? JamPulang { get; set; }
      public string Keterangan { get; set; }
      public int CreatedBy { get; set; }
      public DateTime? CreatedAt { get; set; }
      public int UpdatedBy { get; set; }
      public DateTime? UpdatedAt { get; set; }
   }

   class JadwalKerjaSecurity {
      public int Id { get; set; }
      public string NIK { get; set; }
      public string Nama { get; set; }
      public DateTime Tgl { get; set; }
      public string Shift { get; set; }
      public string Inisial_Shift { get; set; }
      public TimeSpan? JadwalMasuk { get; set; }
      public TimeSpan? JadwalPulang { get; set; }
      public int? CreatedBy { get; set; }
      public DateTime? CreatedAt { get; set; }
      public int? UpdatedBy { get; set; }
      public DateTime? UpdatedAt { get; set; }
   }

   class Kehadiran {
      public int Id { get; set; }
      public string GrupKerja { get; set; }
      public DateTime? Tanggal { get; set; }
      public string NIK { get; set; }
      public string Nama { get; set; }
      public TimeSpan? JadwalMasuk { get; set; }
      public TimeSpan? JamMasuk { get; set; }
      public TimeSpan? JadwalPulang { get; set; }
      public TimeSpan? JamPulang { get; set; }
      public TimeSpan? Terlambat { get; set; }
      public string Keterangan { get; set; }
   }
}
