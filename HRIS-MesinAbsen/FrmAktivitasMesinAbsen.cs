using SKM.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS_MesinAbsen.Services;
using HRIS_MesinAbsen.Contracts;
using static System.Formats.Asn1.AsnWriter;
using System.Net;
using System.Net.Http.Headers;
using SKM.Shared.Helpers;
using Microsoft.VisualBasic.Devices;
using HRIS.Contracts;
using HRIS.Services;
using System.Windows.Forms.VisualStyles;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace HRIS_MesinAbsen {
	public partial class FrmAktivitasMesinAbsen : Form {
		public FrmAktivitasMesinAbsen() {
			InitializeComponent();
			this.tokenService = tokenService;
		}
		public zkemkeeper.CZKEM newDevice;
		public ITokenService tokenService;
		public System.Timers.Timer rtTimer;
		//private int idxMachine = 0;

		private List<MesinAbsenDTO> mesins { get; set; } = new();
		public List<JadwalKerjaKaryawanDTO> ListJadwalKaryawan { get; set; } = new();
		public List<JadwalKerjaSecurityDTO> ListJadwalSecurity { get; set; } = new();

		private void lstMesinAbsen_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private async void FrmAktivitasMesinAbsen_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			mesins = await GetMesinAbsensAsync();
			//ListGaji = await GetDataGajiAsync();
			ListJadwalKaryawan = await GetDataJadwalKaryawanAsync();
			ListJadwalSecurity = await GetDataJadwalSecurityAsync();

			for (int z = 0; z <= mesins.Count - 1; z++) {
				lstMesinAbsen.Items.Add(new ListViewItem(new[] {
					mesins[z].DeviceID.ToString(),
					mesins[z].DeviceNo.ToString(),
					mesins[z].DeviceDesc,
					mesins[z].DeviceIP.ToString(),
					mesins[z].Port.ToString(),
					"Not Connected"
				}));
			}
			Cursor = Cursors.Default;

		}

		public async Task<List<MesinAbsenDTO>> GetMesinAbsensAsync() {
			int tries = 0;
			int numOfRetries = 5;
			while (tries <= numOfRetries) {

				try {
					//var token = await tokenService.GetToken();
					//if (token != null) {
					HttpClient client = new HttpClient();
					//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
					var response = await client.GetAsync($"{BaseUrl.LocalBaseUrl}/MesinAbsens");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<MesinAbsenDTO>>();
					}
					return null;
					//}
				}
				catch {
					tries++;
				}
			}
			throw new RetryException($"Error after {tries}");

		}

		//public static async Task<List<GajiDanTunjanganDTO>> GetDataGajiAsync() {
		//	int tries = 0;
		//	int numOfRetries = 5;
		//	while (tries <= numOfRetries) {
		//		try {
		//			HttpClient client = new HttpClient();
		//			using (var result = await client.GetAsync($"{BaseUrl.LocalBaseUrl}/Gaji")) {
		//	List<GajiDanTunjanganDTO> content = await result.Content.ReadFromJsonAsync<List<GajiDanTunjanganDTO>>();
		//				return content;
		//			}
		//		}
		//		catch {
		//			tries++;
		//		}
		//	}
		//	throw new RetryException($"Error after {tries}");

		//}

		public async Task<List<JadwalKerjaKaryawanDTO>> GetDataJadwalKaryawanAsync() {
			int tries = 0;
			int numOfRetries = 5;
			while (tries <= numOfRetries) {
				try {
					//var token = await tokenService.GetToken();
					//MessageBox.Show(token.Token);
					//if (token != null) {
					HttpClient client = new HttpClient();
					//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
					var response = await client.GetAsync($"{BaseUrl.LocalBaseUrl}/JadwalKerjaKaryawan");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaKaryawanDTO>>();
					}
					return null;
					//}
				}
				catch {
					tries++;
				}
			}
			throw new RetryException($"Error after {tries}");

		}

		public async Task<List<JadwalKerjaSecurityDTO>> GetDataJadwalSecurityAsync() {
			int tries = 0;
			int numOfRetries = 5;
			while (tries <= numOfRetries) {
				try {
					//var token = await tokenService.GetToken();
					//if (token != null) {
					HttpClient client = new HttpClient();
					//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
					var response = await client.GetAsync($"{BaseUrl.LocalBaseUrl}/JadwalKerjaSecurity");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();
					}
					return null;
					//}
				}
				catch {
					tries++;
				}
			}
			throw new RetryException($"Error after {tries}");

		}

		//    private async void AddPayroll(KehadiranDTO kehadiranDTO) {
		//	if (kehadiranDTO.JamPulang.Value.Subtract(kehadiranDTO.JamMasuk.Value).TotalMinutes >= 480) {
		//		GajiDanTunjanganDTO gaji = ListGaji.Where(g => g.NIK == kehadiranDTO.NIK).FirstOrDefault();
		//		decimal upahHarian = Math.Round((decimal)gaji.Upah / 21, 2);
		//		PayrollDTO payroll = new() {
		//			NIK = kehadiranDTO.NIK,
		//			IdEmployee = gaji.EmployeeId.Value,
		//			EmployeeName = gaji.NamaKaryawan,
		//			GroupName = gaji.GrupKerja,
		//			DepartmentName = gaji.DepartmentName,
		//			Upah = gaji.Upah.Value,
		//			TotalMasuk = 1,
		//			TotalLembur = 0,
		//			Bulan = DateTime.Today.Month,
		//			Tahun = DateTime.Today.Year,
		//			Gaji = upahHarian,
		//			CreatedBy = 1,
		//			UpdatedBy = 1,
		//			UpdatedAt = DateTime.Today,
		//			CreatedAt = DateTime.Today,
		//		};

		//		HttpClient client1 = new() {
		//			BaseAddress = new Uri($"{BaseUrl.ServerBaseUrl}")
		//		};
		//		HttpResponseMessage response1 = await Task.Run(() => client1.PostAsJsonAsync<PayrollDTO>("Payroll", payroll).Result);
		//	}

		//	//HttpClient httpClient = new HttpClient();
		//	//string nik = kehadiranDTO.NIK;
		//	//var response = await httpClient.GetAsync($"{BaseUrl.ServerBaseUrl}/Kehadiran/NIK/{nik}");
		//	//if (response.IsSuccessStatusCode) {
		//	//	if (response.StatusCode == System.Net.HttpStatusCode.OK) {
		//	//		AbsenMasukDTO amDTO = await response.Content.ReadFromJsonAsync<AbsenMasukDTO>();

		//	//	}
		//	//}



		//	//Invoke(new MethodInvoker(delegate () {
		//	//	listBox1.Items.Add("Karyawan dengan NIK: " + enrollNumber + " berhasil absen pulang");
		//	//}));
		//}

		private void btnConnectAll_Click(object sender, EventArgs e) {
			this.Cursor = Cursors.WaitCursor;
			btnConnectAll.Enabled = false;
			//int iWorkCount = lstMesinAbsen.Items.Count;

			//WorkThread[] Device = new WorkThread[iWorkCount];
			//for(int i = 0; i < iWorkCount; i++) {
			//	Device[i] = new WorkThread(lstMesinAbsen.Items[i].SubItems[3].Text, int.Parse(lstMesinAbsen.Items[i].SubItems[4].Text));
			//	ThreadPool.QueueUserWorkItem(Device[i].ThreadPoolCallBack);
			//}

			for (int x = 0; x <= lstMesinAbsen.Items.Count - 1; x++) {
				lstMesinAbsen.Items[x].SubItems[5].Text = "Connecting...";
				newDevice = new zkemkeeper.CZKEM();
				rtTimer = new() {
					Enabled = true
				};

				bool blConnected = newDevice.Connect_Net(lstMesinAbsen.Items[x].SubItems[3].Text, int.Parse(lstMesinAbsen.Items[x].SubItems[4].Text));

				if (blConnected == true) {
					lstMesinAbsen.Items[x].SubItems[5].Text = "Connected";
					newDevice.EnableDevice(1, true);
					if (newDevice.RegEvent(1, 65535)) {
						newDevice.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(newDevice_OnFinger);
						newDevice.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(newDevice_OnVerfify);
						newDevice.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(newDevice_OnAttTransactionEx);

					}
				}
				else {
					lstMesinAbsen.Items[x].SubItems[5].Text = "Not Connected";
				}
			}

			btnConnectAll.Enabled = true;
			this.Cursor = Cursors.Default;
		}

		private void newDevice_OnFinger() {
			Console.WriteLine("Real Time Event has been triggered...");
		}
		private void newDevice_OnVerfify(int intUserID) {
			Console.WriteLine("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				Console.WriteLine("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				Console.WriteLine("Verified failed...");
			}
		}

		private async void newDevice_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {

			string nik = sEnrollNumber.ToString();
			JadwalKerjaKaryawanDTO jadwalKaryawan;
			JadwalKerjaSecurityDTO jadwalSecurity;
			DateTime? tglSekarang = DateTime.Now.Date;
			TimeSpan? jamSekarang = DateTime.Now.TimeOfDay;

			var karyawan = ListJadwalKaryawan.SingleOrDefault(j => j.NIK == nik && j.Tgl.Value.Date == tglSekarang);
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
				//Program program = new();
				AddAbsen(newAbsen);
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

		private void rtTimer_Tick(object sender, EventArgs e) {
			if (newDevice.ReadRTLog(1)) {
				while (newDevice.GetRTLog(1)) {
					;
				}
			}
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

		private async void AbsenPulang(KehadiranDTO absenPulang) {
			HttpClient client = new();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			var content = new StringContent(JsonConvert.SerializeObject(absenPulang), UTF8Encoding.UTF8, "application/json");
			var response = await client.PostAsJsonAsync($"{BaseUrl.LocalBaseUrl}/Kehadiran/AbsenPulang", content);
			if (response.IsSuccessStatusCode) {
				var kehadiran = await response.Content.ReadAsStringAsync();
				Invoke(new MethodInvoker(delegate () {
					listBox1.Items.Add("Karyawan dengan NIK: " + absenPulang.NIK + " berhasil absen pulang");
				}));
				//if (response.StatusCode == System.Net.HttpStatusCode.OK) {
				//var kehadiran = await response.Content.ReadFromJsonAsync<KehadiranDTO>();
				//var jamPulang = DateTime.Now.TimeOfDay;
				//kehadiran.JamPulang = jamPulang;
				//var response1 = await client.PutAsJsonAsync($"{BaseUrl.LocalBaseUrl}/Kehadiran/AbsenPulang", kehadiran);
				//if (response1.IsSuccessStatusCode) {
				//	if(response1.StatusCode == HttpStatusCode.OK) {
				//		var pulang = await response1.Content.ReadFromJsonAsync<KehadiranDTO>();
				//		AddPayroll(pulang);
				//	}
				//}
				//}
			}
			//var response = await client.PostAsJsonAsync($"{BaseUrl.ServerBaseUrl}/AbsenPulang", absenPulang);
			//if (response.IsSuccessStatusCode) {
			//	if (response.StatusCode == System.Net.HttpStatusCode.OK) {
			//		var ap = await response.Content.ReadFromJsonAsync<AbsenPulangDTO>();
			//		AddPayroll(ap);
			//		//Add Payroll
			//		//if (hadir.JamPulang.Value.Subtract(hadir.JamMasuk.Value).TotalMinutes >= 480) {
			//		//	AddPayroll(hadir.NIK);
			//		//}
			//	}
			//	//else if (response1.StatusCode == System.Net.HttpStatusCode.NoContent) {
			//	//	Invoke(new MethodInvoker(delegate () {
			//	//		listBox1.Items.Add("Karyawan dengan NIK: " + hadir.NIK + " gagal absen, karena belum absen masuk");
			//	//	}));
			//	//}
			//}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e) {

		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e) {
			FrmLogin frmLogin = new();
			frmLogin.Show();
		}
	}

	class WorkThread {
		string sIP = "0.0.0.0";
		int iPort = 4370;
		int iMachineNumber = 1;
		int iThreadID = 0;
		int iLastTry = 0;
		int iDelay = 2;

		private static int iCounter = 0;
		private static int iConnectedCount = 0;

		public zkemkeeper.CZKEM sdk = new();
		public string strMessage = "";
		public FrmAktivitasMesinAbsen frm = new();

		public WorkThread(string swIP, int iwPort) {
			sIP = swIP;
			iPort = iwPort;
			iThreadID = ++iCounter;
		}

		public void ThreadPoolCallBack(Object? oThreadContext) {
			//this.ConnectToDevice()
			//    int iCurrentTime = 0;
			//    iLastTry = GetTimeInMinute();
			//    while (true) {
			//       iCurrentTime = GetTimeInMinute();
			//       //sleep until the minute ticks
			//       while (iLastTry == iCurrentTime) {
			//          Thread.Sleep(30);
			//          iCurrentTime = GetTimeInMinute();
			//       }
			//       iLastTry = iCurrentTime;
			//       iDelay--;
			//       if (iDelay == 1) {
			//          this.WakeUp();
			////this.ConnectToDevice();
			//       }
			//    }
			this.WakeUp();
		}

		public void WakeUp() {
			bool bResult = sdk.Connect_Net(sIP, iPort);

			if (!bResult) {
				strMessage = $"Connecting {sIP} Failed...Current Time: {DateTime.Now.ToLongTimeString}";
			}
			iConnectedCount++;
			strMessage = $"Device IP: {sIP} ThreadID: {iThreadID.ToString()} Successfull connected at: {DateTime.Now.ToLongTimeString}";
			//frm.listBox1.Items.Add(strMessage);
			Console.WriteLine(strMessage);
			if (sdk.RegEvent(1, 65535)) {
				sdk.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(newDevice_OnFinger);
				sdk.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(newDevice_OnVerfify);
				sdk.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(newDevice_OnAttTransactionEx);
			}
		}

		//public void ConnectToDevice() {

		//      bool bResult = sdk.Connect_Net(sIP, iPort);

		//if (!bResult) {
		//	strMessage =  $"Connecting {sIP} Failed...Current Time: {DateTime.Now.ToLongTimeString}";
		//      }
		//iConnectedCount++;
		//strMessage = $"Device IP: {sIP} ThreadID: {iThreadID.ToString()} Successfull connected at: {DateTime.Now.ToLongTimeString}";
		//frm.listBox1.Items.Add(strMessage);

		//      if (sdk.RegEvent(1, 65535)) {
		//         sdk.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(newDevice_OnFinger);
		//         sdk.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(newDevice_OnVerfify);
		//         sdk.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(newDevice_OnAttTransactionEx);
		//      }
		//}

		private void newDevice_OnFinger() {
			//Invoke(new MethodInvoker(delegate () {
			//   listBox1.Items.Add("Real Time Event has been triggered...");
			//}));
			strMessage = "Real Time Event has been triggered...";
			//frm.listBox1.Items.Add(strMessage);
			Console.WriteLine(strMessage);
		}

		private void newDevice_OnVerfify(int intUserID) {
			//Invoke(new MethodInvoker(delegate () {
			//   listBox1.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			//   if (intUserID != -1) {
			//      listBox1.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			//   }
			//   else {
			//      listBox1.Items.Add("Verified failed...");
			//   }
			//}));
			if (intUserID != -1) {
				strMessage = $"Verified OK, the UserID is {intUserID}";
			}
			strMessage = "Verified failed...";
			//frm.listBox1.Items.Add(strMessage);
			Console.WriteLine(strMessage);
		}

		private async void newDevice_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			string nik = sEnrollNumber.ToString();
			JadwalKerjaKaryawanDTO jadwalKaryawan;
			JadwalKerjaSecurityDTO jadwalSecurity;
			DateTime? tglSekarang = DateTime.Now.Date;
			TimeSpan? jamSekarang = DateTime.Now.TimeOfDay;

			var karyawan = frm.ListJadwalKaryawan.SingleOrDefault(j => j.NIK == nik && j.Tgl.Value.Date == tglSekarang);
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
				AddAbsen(newAbsen);
			}
		}



		private int GetTimeInMinute()//return the time in mimutes
		{
			return ((DateTime.Now.Hour * 24) + DateTime.Now.Minute);
		}

		public async void AddAbsen(KehadiranDTO newHadir) {
			HttpClient client = new();
			HttpResponseMessage response = await client.PostAsJsonAsync($"{BaseUrl.LocalBaseUrl}/Kehadiran/Absen", newHadir);
			var hdr = await response.Content.ReadFromJsonAsync<KehadiranDTO>();

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

	class RetryException : Exception {
		public RetryException(string? message) : base(message) { }
	}

}
