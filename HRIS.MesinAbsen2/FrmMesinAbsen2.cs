using HRIS.MesinAbsen2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace HRIS.MesinAbsen2 {
	public partial class FrmMesinAbsen2 : Form {
		public zkemkeeper.CZKEMClass mesinAbsen1 = new zkemkeeper.CZKEMClass();
		public zkemkeeper.CZKEMClass mesinAbsen2 = new zkemkeeper.CZKEMClass();
		public zkemkeeper.CZKEMClass mesinAbsen3 = new zkemkeeper.CZKEMClass();
		public zkemkeeper.CZKEMClass mesinAbsen4 = new zkemkeeper.CZKEMClass();

		public int NomorMesin1 = 1;
		public int NomorMesin2 = 2;
		public int NomorMesin3 = 3;
		public int NomorMesin4 = 4;

		public bool isConnected1 = false;
		public bool isConnected2 = false;

		public List<MesinAbsen> listMesinAbsen = new List<MesinAbsen>();

		public FrmMesinAbsen2() {
			InitializeComponent();
		}

		private async void FrmMesinAbsen2_Load(object sender, EventArgs e) {
			var result = await GetMesinAbsensAsync();
			var mesins = JsonConvert.DeserializeObject<List<MesinAbsen>>(result);	

			txtMesin1.Text = mesins[0].DeviceDesc;
			txtIPAddress1.Text = mesins[0].DeviceIP;
			txtPort1.Text = mesins[0].Port.ToString();

			txtMesin2.Text = mesins[1].DeviceDesc;
			txtIPAddress2.Text = mesins[1].DeviceIP;
			txtPort2.Text = mesins[1].Port.ToString();

			//txtMesin3.Text = mesins[2].DeviceDesc;
			//txtIPAddress3.Text = mesins[2].DeviceIP;
			//txtPort3.Text = mesins[2].Port.ToString();

			//txtMesin4.Text = mesins[3].DeviceDesc;
			//txtIPAddress4.Text = mesins[3].DeviceIP;
			//txtPort4.Text = mesins[3].Port.ToString();


		}

		public async Task<string> GetMesinAbsensAsync() {
			int tries = 0;
			int numOfRetries = 2;
			while (tries <= numOfRetries) {

				try {
					HttpClient client = new HttpClient();
					var response = await client.GetAsync($"{BaseUrl.ServerBaseUrl}/MesinAbsens");
					var result = await response.Content.ReadAsStringAsync();

					return result;
					//if (response.IsSuccessStatusCode) {
					//	if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
					//		return default;
					//	}
					//	return await response.Content.ReadAsStringAsync();
					//}
					//return null;
					//}
				}
				catch {
					tries++;
				}
			}
			throw new RetryException($"Error after {tries}");

		}

		private void btnConnect1_Click(object sender, EventArgs e) {
			//bool connected;
			this.Cursor = Cursors.WaitCursor;
			btnConnect1.Enabled = false;

			if(btnConnect1.Text == "Connect") {
				isConnected1 = mesinAbsen1.Connect_Net(txtIPAddress1.Text, int.Parse(txtPort1.Text));
				if(isConnected1) {
					btnConnect1.Text = "DisConnect";
					NomorMesin1 = 1;
					if(mesinAbsen1.RegEvent(1, 65535)) {
						mesinAbsen1.EnableDevice(1, true);
						//mesinAbsen1.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen1_OnFinger);
						//mesinAbsen1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen1_OnVerfify);
						mesinAbsen1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen1_OnAttTransactionEx);
						mesinAbsen1.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen1_OnFingerFeature);
						mesinAbsen1.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen1_OnEnrollFingerEx);
						this.mesinAbsen1.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen1_OnDeleteTemplate);
						this.mesinAbsen1.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen1_OnNewUser);
						this.mesinAbsen1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen1_OnHIDNum);
						this.mesinAbsen1.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen1_OnAlarm);
						this.mesinAbsen1.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen1_OnDoor);
						this.mesinAbsen1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen1_OnWriteCard);
						this.mesinAbsen1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen1_OnEmptyCard);

						lbStatus1.Text = "Connected";

					}
				}
				
			}
			else {
				btnConnect1.Text = "Connect";
				mesinAbsen1.Disconnect();
				//mesinAbsen1.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen1_OnFinger);
				//mesinAbsen1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen1_OnVerfify);
				mesinAbsen1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen1_OnAttTransactionEx);
				mesinAbsen1.OnFingerFeature -= new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen1_OnFingerFeature);
				mesinAbsen1.OnEnrollFingerEx -= new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen1_OnEnrollFingerEx);
				this.mesinAbsen1.OnDeleteTemplate -= new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen1_OnDeleteTemplate);
				this.mesinAbsen1.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen1_OnNewUser);
				this.mesinAbsen1.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen1_OnHIDNum);
				this.mesinAbsen1.OnAlarm -= new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen1_OnAlarm);
				this.mesinAbsen1.OnDoor -= new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen1_OnDoor);
				this.mesinAbsen1.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen1_OnWriteCard);
				this.mesinAbsen1.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen1_OnEmptyCard);
				lbStatus1.Text = "Not Connected";
				isConnected1 = false;
			}
			this.Cursor = Cursors.Default;
			btnConnect1.Enabled = true;
		}

		private void mesinAbsen1_OnEmptyCard(int ActionResult) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnWriteCard(int EnrollNumber, int ActionResult, int Length) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnDoor(int EventType) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnAlarm(int AlarmType, int EnrollNumber, int Verified) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnHIDNum(int CardNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnNewUser(int EnrollNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnDeleteTemplate(int EnrollNumber, int FingerIndex) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnEnrollFingerEx(string EnrollNumber, int FingerIndex, int ActionResult, int TemplateLength) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen1_OnFingerFeature(int Score) {
			//throw new NotImplementedException();
		}

		private async void mesinAbsen1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			//throw new NotImplementedException();

			//mesinAbsen1.EnableDevice(1, true);
			string nik = sEnrollNumber.ToString();
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;
			string strDate = year.ToString() + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (day < 10 ? "0" + day.ToString() : day.ToString());

   //      Kehadiran kehadiran = new Kehadiran();

			//var jkkTask = SearchForJadwalKerjaKaryawan(nik, strDate);
			//var jksTask = SearchForJadwalKerjaSecurity(nik, strDate);

			//await Task.WhenAll(jkkTask, jksTask);

			//var jkkTaskResult = await jkkTask;
			//var jksTaskResult = await jksTask;

			//if(jkkTaskResult == null && jksTaskResult == null) {
   //         TextWriter txt = new StreamWriter($"C:\\MesinAbsenErrorLog\\NullReferenceError at MesinAbsen1-{DateTime.Now.Date.ToString("dd-MM-yyyy")}.txt", true);
   //         txt.WriteLine($"NIK: {nik} tidak ditemukan di jadwalkaryawan dan jadwalsecurity...{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}");
   //         txt.Close();
   //         txt.Dispose();
   //         Console.ForegroundColor = ConsoleColor.Red;

   //         Console.WriteLine($"Exception from mesinAbsen1 at {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} >>>> NIK: {nik} tidak ditemukan di JadwalKaryawan dan JadwalSecurity");
   //      }

			//if(jkkTaskResult != null && jksTaskResult == null) {
   //         kehadiran.GrupKerja = jkkTaskResult.GroupName;
   //         kehadiran.NIK = jkkTaskResult.NIK;
   //         kehadiran.Nama = jkkTaskResult.NamaKaryawan;
   //         kehadiran.Gender = jkkTaskResult.Gender;
   //         kehadiran.Tanggal = DateTime.Now.Date;
   //         kehadiran.JadwalMasuk = jkkTaskResult.JamMasuk;
   //         kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
   //         kehadiran.JadwalPulang = jkkTaskResult.JamPulang;
			//}
			//else if(jkkTaskResult == null && jksTaskResult != null) {
   //         kehadiran.GrupKerja = jksTaskResult.GrupKerja;
   //         kehadiran.NIK = jksTaskResult.NIK;
   //         kehadiran.Nama = jksTaskResult.Nama;
   //         kehadiran.Gender = jksTaskResult.Gender;
   //         kehadiran.Tanggal = DateTime.Now.Date;
   //         kehadiran.JadwalMasuk = jksTaskResult.JadwalMasuk;
   //         kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
   //         kehadiran.JadwalPulang = jksTaskResult.JadwalPulang;
   //      }
   //      string message = await AddAbsen(kehadiran);
         //lstMesin1.Items.Add(message);
			lstMesin1.Items.Add($"OnAttTransactionEx active at: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}");
		}

		private async Task<JadwalKerjaKaryawan> SearchForJadwalKerjaKaryawan(string nik, string strDate) {
			HttpClient httpClientJadwalKerjaKaryawan = new HttpClient();
			HttpResponseMessage httpResponseMessageJadwalKerjaKaryawan = new HttpResponseMessage();

			httpResponseMessageJadwalKerjaKaryawan = await httpClientJadwalKerjaKaryawan.GetAsync($"{BaseUrl.ServerBaseUrl}/JadwalKerjaKaryawan/NIKAndDate/{nik}/{strDate}");

			try {
            var rstJadwalKerjaKaryawan = await httpResponseMessageJadwalKerjaKaryawan.Content.ReadAsStringAsync();
            if (rstJadwalKerjaKaryawan is null) {
               return null;
            }
            JadwalKerjaKaryawan jadwalKerjaKaryawan = JsonConvert.DeserializeObject<JadwalKerjaKaryawan>(rstJadwalKerjaKaryawan);
            return jadwalKerjaKaryawan;
         }
			catch (Exception ex) {
				if (ex is NullReferenceException) return null;
			}
			return default;

      }

      private async Task<JadwalKerjaSecurity> SearchForJadwalKerjaSecurity(string nik, string strDate) {
         HttpClient httpClientJadwalKerjaSecurity = new HttpClient();
         HttpResponseMessage httpResponseMessageJadwalKerjaSecurity = new HttpResponseMessage();

         httpResponseMessageJadwalKerjaSecurity = await httpClientJadwalKerjaSecurity.GetAsync($"{BaseUrl.ServerBaseUrl}/JadwalKerjaSecurity/NIKAndDate/{nik}/{strDate}");

			try {
            var rstJadwalKerjaSecurity = await httpResponseMessageJadwalKerjaSecurity.Content.ReadAsStringAsync();
            if (rstJadwalKerjaSecurity is null) {
               return null;
            }
            JadwalKerjaSecurity jadwalKerjaSecurity = JsonConvert.DeserializeObject<JadwalKerjaSecurity>(rstJadwalKerjaSecurity);

            return jadwalKerjaSecurity;
         }
			catch (Exception ex) {
				if(ex is NullReferenceException) return null;
			}
			return default;
      }

  //    private void mesinAbsen1_OnVerfify(int intUserID) {
		//	//throw new NotImplementedException();
		//	lstMesin1.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
		//	if (intUserID != -1) {
		//		lstMesin1.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
		//	}
		//	else {
		//		lstMesin1.Items.Add("Verified failed...");
		//	}
		//}

		//private void mesinAbsen1_OnFinger() {
		//	//throw new NotImplementedException();
		//	lstMesin1.Items.Add("Real Time Event has been triggered...");
		//}

		private void btnConnect2_Click(object sender, EventArgs e) {
			//bool connected;
			this.Cursor = Cursors.WaitCursor;
			btnConnect2.Enabled = false;

			if (btnConnect2.Text == "Connect") {
				isConnected2 = mesinAbsen2.Connect_Net(txtIPAddress2.Text, int.Parse(txtPort2.Text));
				if (isConnected2) {
					btnConnect2.Text = "DisConnect";
					if (mesinAbsen2.RegEvent(1, 65535)) {
						mesinAbsen2.EnableDevice(1, true);
						//mesinAbsen2.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen2_OnFinger);
						//mesinAbsen2.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen2_OnVerfify);
						mesinAbsen2.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen2_OnAttTransactionEx);
						mesinAbsen2.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen2_OnFingerFeature);
						mesinAbsen2.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen2_OnEnrollFingerEx);
						this.mesinAbsen2.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen2_OnDeleteTemplate);
						this.mesinAbsen2.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen2_OnNewUser);
						this.mesinAbsen2.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen2_OnHIDNum);
						this.mesinAbsen2.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen2_OnAlarm);
						this.mesinAbsen2.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen2_OnDoor);
						this.mesinAbsen2.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen2_OnWriteCard);
						this.mesinAbsen2.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen2_OnEmptyCard);

						lbStatus2.Text = "Connected";

					}
				}

			}
			else {
				btnConnect2.Text = "Connect";
				mesinAbsen2.Disconnect();
				//mesinAbsen2.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen2_OnFinger);
				//mesinAbsen2.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen2_OnVerfify);
				mesinAbsen2.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen2_OnAttTransactionEx);
				mesinAbsen2.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen2_OnFingerFeature);
				mesinAbsen2.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen2_OnEnrollFingerEx);
				this.mesinAbsen2.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen2_OnDeleteTemplate);
				this.mesinAbsen2.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen2_OnNewUser);
				this.mesinAbsen2.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen2_OnHIDNum);
				this.mesinAbsen2.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen2_OnAlarm);
				this.mesinAbsen2.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen2_OnDoor);
				this.mesinAbsen2.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen2_OnWriteCard);
				this.mesinAbsen2.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen2_OnEmptyCard);
				lbStatus2.Text = "Not Connected";
				isConnected2 = false;
			}
			this.Cursor = Cursors.Default;
			btnConnect2.Enabled = true;
		}

		private void mesinAbsen2_OnEmptyCard(int ActionResult) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnWriteCard(int EnrollNumber, int ActionResult, int Length) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnDoor(int EventType) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnAlarm(int AlarmType, int EnrollNumber, int Verified) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnHIDNum(int CardNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnNewUser(int EnrollNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnDeleteTemplate(int EnrollNumber, int FingerIndex) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnEnrollFingerEx(string EnrollNumber, int FingerIndex, int ActionResult, int TemplateLength) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen2_OnFingerFeature(int Score) {
			//throw new NotImplementedException();
		}

		private async void mesinAbsen2_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			string nik = sEnrollNumber.ToString();
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;
			string strDate = year.ToString() + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (day < 10 ? "0" + day.ToString() : day.ToString());

         //Kehadiran kehadiran = new Kehadiran();

         //var jkkTask = SearchForJadwalKerjaKaryawan(nik, strDate);
         //var jksTask = SearchForJadwalKerjaSecurity(nik, strDate);

         //await Task.WhenAll(jkkTask, jksTask);

         //var jkkTaskResult = await jkkTask;
         //var jksTaskResult = await jksTask;

         //if (jkkTaskResult == null && jksTaskResult == null) {
         //   TextWriter txt = new StreamWriter($"C:\\MesinAbsenErrorLog\\NullReferenceError at MesinAbsen1-{DateTime.Now.Date.ToString("dd-MM-yyyy")}.txt", true);
         //   txt.WriteLine($"NIK: {nik} tidak ditemukan di jadwalkaryawan dan jadwalsecurity...{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}");
         //   txt.Close();
         //   txt.Dispose();
         //   Console.ForegroundColor = ConsoleColor.Red;

         //   Console.WriteLine($"Exception from mesinAbsen1 at {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} >>>> NIK: {nik} tidak ditemukan di JadwalKaryawan dan JadwalSecurity");
         //}

         //if (jkkTaskResult != null && jksTaskResult == null) {
         //   kehadiran.GrupKerja = jkkTaskResult.GroupName;
         //   kehadiran.NIK = jkkTaskResult.NIK;
         //   kehadiran.Nama = jkkTaskResult.NamaKaryawan;
         //   kehadiran.Gender = jkkTaskResult.Gender;
         //   kehadiran.Tanggal = DateTime.Now.Date;
         //   kehadiran.JadwalMasuk = jkkTaskResult.JamMasuk;
         //   kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
         //   kehadiran.JadwalPulang = jkkTaskResult.JamPulang;
         //}
         //else if (jkkTaskResult == null && jksTaskResult != null) {
         //   kehadiran.GrupKerja = jksTaskResult.GrupKerja;
         //   kehadiran.NIK = jksTaskResult.NIK;
         //   kehadiran.Nama = jksTaskResult.Nama;
         //   kehadiran.Gender = jksTaskResult.Gender;
         //   kehadiran.Tanggal = DateTime.Now.Date;
         //   kehadiran.JadwalMasuk = jksTaskResult.JadwalMasuk;
         //   kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
         //   kehadiran.JadwalPulang = jksTaskResult.JadwalPulang;
         //}
         //string message = await AddAbsen(kehadiran);

         lstMesin2.Items.Add($"OnAttTransactionEx active at: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}");
			//lstMesin2.Items.Add(message);
      }

		//private void mesinAbsen2_OnVerfify(int intUserID) {
		//	//throw new NotImplementedException();
		//	lstMesin2.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
		//	if (intUserID != -1) {
		//		lstMesin2.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
		//	}
		//	else {
		//		lstMesin2.Items.Add("Verified failed...");
		//	}
		//}

		//private void mesinAbsen2_OnFinger() {
		//	//throw new NotImplementedException();
		//	lstMesin2.Items.Add("Real Time Event has been triggered...");
		//}

		private void btnConnect3_Click(object sender, EventArgs e) {
			bool connected;
			this.Cursor = Cursors.WaitCursor;
			btnConnect3.Enabled = false;

			if (btnConnect3.Text == "Connect") {
				connected = mesinAbsen3.Connect_Net(txtIPAddress3.Text, int.Parse(txtPort3.Text));
				if (connected) {
					btnConnect3.Text = "DisConnect";
					if (mesinAbsen3.RegEvent(1, 65535)) {
						mesinAbsen3.EnableDevice(1, true);
						mesinAbsen3.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen3_OnFinger);
						mesinAbsen3.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen3_OnVerfify);
						mesinAbsen3.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen3_OnAttTransactionEx);
						mesinAbsen3.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen3_OnFingerFeature);
						mesinAbsen3.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen3_OnEnrollFingerEx);
						this.mesinAbsen3.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen3_OnDeleteTemplate);
						this.mesinAbsen3.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen3_OnNewUser);
						this.mesinAbsen3.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen3_OnHIDNum);
						this.mesinAbsen3.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen3_OnAlarm);
						this.mesinAbsen3.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen3_OnDoor);
						this.mesinAbsen3.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen3_OnWriteCard);
						this.mesinAbsen3.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen3_OnEmptyCard);

						lbStatus3.Text = "Connected";

					}
				}

			}
			else {
				btnConnect3.Text = "Connect";
				mesinAbsen3.Disconnect();
				mesinAbsen3.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen3_OnFinger);
				mesinAbsen3.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen3_OnVerfify);
				mesinAbsen3.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen3_OnAttTransactionEx);
				mesinAbsen3.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen3_OnFingerFeature);
				mesinAbsen3.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen3_OnEnrollFingerEx);
				this.mesinAbsen3.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen3_OnDeleteTemplate);
				this.mesinAbsen3.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen3_OnNewUser);
				this.mesinAbsen3.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen3_OnHIDNum);
				this.mesinAbsen3.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen3_OnAlarm);
				this.mesinAbsen3.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen3_OnDoor);
				this.mesinAbsen3.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen3_OnWriteCard);
				this.mesinAbsen3.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen3_OnEmptyCard);
				lbStatus3.Text = "Not Connected";
				connected = false;
			}
			this.Cursor = Cursors.Default;
			btnConnect3.Enabled = true;
		}

		private void mesinAbsen3_OnEmptyCard(int ActionResult) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnWriteCard(int EnrollNumber, int ActionResult, int Length) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnDoor(int EventType) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnAlarm(int AlarmType, int EnrollNumber, int Verified) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnHIDNum(int CardNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnNewUser(int EnrollNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnDeleteTemplate(int EnrollNumber, int FingerIndex) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnEnrollFingerEx(string EnrollNumber, int FingerIndex, int ActionResult, int TemplateLength) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen3_OnFingerFeature(int Score) {
			//throw new NotImplementedException();
		}

		private async void mesinAbsen3_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			string nik = sEnrollNumber.ToString();
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;
			string strDate = year.ToString() + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (day < 10 ? "0" + day.ToString() : day.ToString());

         Kehadiran kehadiran = new Kehadiran();

         var jkkTask = SearchForJadwalKerjaKaryawan(nik, strDate);
         var jksTask = SearchForJadwalKerjaSecurity(nik, strDate);

         await Task.WhenAll(jkkTask, jksTask);

         var jkkTaskResult = await jkkTask;
         var jksTaskResult = await jksTask;

         if (jkkTaskResult == null && jksTaskResult == null) {
            TextWriter txt = new StreamWriter($"C:\\MesinAbsenErrorLog\\NullReferenceError at MesinAbsen1-{DateTime.Now.Date.ToString("dd-MM-yyyy")}.txt", true);
            txt.WriteLine($"NIK: {nik} tidak ditemukan di jadwalkaryawan dan jadwalsecurity...{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}");
            txt.Close();
            txt.Dispose();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Exception from mesinAbsen1 at {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} >>>> NIK: {nik} tidak ditemukan di JadwalKaryawan dan JadwalSecurity");
         }

         if (jkkTaskResult != null && jksTaskResult == null) {
            kehadiran.GrupKerja = jkkTaskResult.GroupName;
            kehadiran.NIK = jkkTaskResult.NIK;
            kehadiran.Nama = jkkTaskResult.NamaKaryawan;
            kehadiran.Gender = jkkTaskResult.Gender;
            kehadiran.Tanggal = DateTime.Now.Date;
            kehadiran.JadwalMasuk = jkkTaskResult.JamMasuk;
            kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
            kehadiran.JadwalPulang = jkkTaskResult.JamPulang;
         }
         else if (jkkTaskResult == null && jksTaskResult != null) {
            kehadiran.GrupKerja = jksTaskResult.GrupKerja;
            kehadiran.NIK = jksTaskResult.NIK;
            kehadiran.Nama = jksTaskResult.Nama;
            kehadiran.Gender = jksTaskResult.Gender;
            kehadiran.Tanggal = DateTime.Now.Date;
            kehadiran.JadwalMasuk = jksTaskResult.JadwalMasuk;
            kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
            kehadiran.JadwalPulang = jksTaskResult.JadwalPulang;
         }
         string message = await AddAbsen(kehadiran);
         lstMesin3.Items.Add(message);
      }

		private void mesinAbsen3_OnVerfify(int intUserID) {
			//throw new NotImplementedException();
			lstMesin3.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				lstMesin3.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				lstMesin3.Items.Add("Verified failed...");
			}
		}

		private void mesinAbsen3_OnFinger() {
			//throw new NotImplementedException();
			lstMesin3.Items.Add("Real Time Event has been triggered...");
		}

		private void btnConnect4_Click(object sender, EventArgs e) {
			bool connected;
			this.Cursor = Cursors.WaitCursor;
			btnConnect4.Enabled = false;

			if (btnConnect4.Text == "Connect") {
				connected = mesinAbsen4.Connect_Net(txtIPAddress4.Text, int.Parse(txtPort4.Text));
				if (connected) {
					btnConnect4.Text = "DisConnect";
					if (mesinAbsen4.RegEvent(1, 65535)) {
						mesinAbsen4.EnableDevice(1, true);
						mesinAbsen4.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen4_OnFinger);
						mesinAbsen4.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen4_OnVerfify);
						mesinAbsen4.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen4_OnAttTransactionEx);
						mesinAbsen4.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen4_OnFingerFeature);
						mesinAbsen4.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen4_OnEnrollFingerEx);
						this.mesinAbsen4.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen4_OnDeleteTemplate);
						this.mesinAbsen4.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen4_OnNewUser);
						this.mesinAbsen4.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen4_OnHIDNum);
						this.mesinAbsen4.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen4_OnAlarm);
						this.mesinAbsen4.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen4_OnDoor);
						this.mesinAbsen4.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen4_OnWriteCard);
						this.mesinAbsen4.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen4_OnEmptyCard);

						lbStatus4.Text = "Connected";

					}
				}

			}
			else {
				btnConnect4.Text = "Connect";
				mesinAbsen4.Disconnect();
				mesinAbsen4.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen4_OnFinger);
				mesinAbsen4.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen4_OnVerfify);
				mesinAbsen4.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen3_OnAttTransactionEx);
				mesinAbsen4.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen4_OnFingerFeature);
				mesinAbsen4.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen4_OnEnrollFingerEx);
				this.mesinAbsen4.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen4_OnDeleteTemplate);
				this.mesinAbsen4.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen4_OnNewUser);
				this.mesinAbsen4.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen4_OnHIDNum);
				this.mesinAbsen4.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen4_OnAlarm);
				this.mesinAbsen4.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen4_OnDoor);
				this.mesinAbsen4.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen4_OnWriteCard);
				this.mesinAbsen4.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen4_OnEmptyCard);
				lbStatus4.Text = "Not Connected";
				connected = false;
			}
			this.Cursor = Cursors.Default;
			btnConnect4.Enabled = true;
		}

		private void mesinAbsen4_OnEmptyCard(int ActionResult) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnWriteCard(int EnrollNumber, int ActionResult, int Length) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnDoor(int EventType) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnAlarm(int AlarmType, int EnrollNumber, int Verified) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnHIDNum(int CardNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnNewUser(int EnrollNumber) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnDeleteTemplate(int EnrollNumber, int FingerIndex) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnEnrollFingerEx(string EnrollNumber, int FingerIndex, int ActionResult, int TemplateLength) {
			//throw new NotImplementedException();
		}

		private void mesinAbsen4_OnFingerFeature(int Score) {
			//throw new NotImplementedException();
		}

		private async void mesinAbsen4_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			string nik = sEnrollNumber.ToString();
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;
			string strDate = year.ToString() + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (day < 10 ? "0" + day.ToString() : day.ToString());

         Kehadiran kehadiran = new Kehadiran();

         var jkkTask = SearchForJadwalKerjaKaryawan(nik, strDate);
         var jksTask = SearchForJadwalKerjaSecurity(nik, strDate);

         await Task.WhenAll(jkkTask, jksTask);

         var jkkTaskResult = await jkkTask;
         var jksTaskResult = await jksTask;

         if (jkkTaskResult == null && jksTaskResult == null) {
            TextWriter txt = new StreamWriter($"C:\\MesinAbsenErrorLog\\NullReferenceError at MesinAbsen1-{DateTime.Now.Date.ToString("dd-MM-yyyy")}.txt", true);
            txt.WriteLine($"NIK: {nik} tidak ditemukan di jadwalkaryawan dan jadwalsecurity...{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}");
            txt.Close();
            txt.Dispose();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Exception from mesinAbsen1 at {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} >>>> NIK: {nik} tidak ditemukan di JadwalKaryawan dan JadwalSecurity");
         }

         if (jkkTaskResult != null && jksTaskResult == null) {
            kehadiran.GrupKerja = jkkTaskResult.GroupName;
            kehadiran.NIK = jkkTaskResult.NIK;
            kehadiran.Nama = jkkTaskResult.NamaKaryawan;
            kehadiran.Gender = jkkTaskResult.Gender;
            kehadiran.Tanggal = DateTime.Now.Date;
            kehadiran.JadwalMasuk = jkkTaskResult.JamMasuk;
            kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
            kehadiran.JadwalPulang = jkkTaskResult.JamPulang;
         }
         else if (jkkTaskResult == null && jksTaskResult != null) {
            kehadiran.GrupKerja = jksTaskResult.GrupKerja;
            kehadiran.NIK = jksTaskResult.NIK;
            kehadiran.Nama = jksTaskResult.Nama;
            kehadiran.Gender = jksTaskResult.Gender;
            kehadiran.Tanggal = DateTime.Now.Date;
            kehadiran.JadwalMasuk = jksTaskResult.JadwalMasuk;
            kehadiran.JamMasuk = DateTime.Now.TimeOfDay;
            kehadiran.JadwalPulang = jksTaskResult.JadwalPulang;
         }
         string message = await AddAbsen(kehadiran);
         lstMesin4.Items.Add(message);

      }

      public async Task<string> AddAbsen(Kehadiran newHadir) {
			var content = new StringContent(JsonConvert.SerializeObject(newHadir), Encoding.UTF8, "application/json");

			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.PostAsync($"{BaseUrl.ServerBaseUrl}/Kehadiran/Absen", content);
			var result = await response.Content.ReadAsStringAsync();
			var hadir = JsonConvert.DeserializeObject<Kehadiran>(result);
			if(hadir != null && hadir.JamPulang == null) {
				return $"NIK: {hadir.NIK}, Nama: {hadir.Nama}, Grup: {hadir.GrupKerja} berhasil absen masuk pada: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}";
			}
			return $"NIK: {newHadir.NIK}, Nama: {newHadir.Nama}, Grup: {newHadir.GrupKerja} berhasil absen pulang pada: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}";
		}

		private void mesinAbsen4_OnVerfify(int intUserID) {
			//throw new NotImplementedException();
			lstMesin4.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				lstMesin4.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				lstMesin4.Items.Add("Verified failed...");
			}
		}

		private void mesinAbsen4_OnFinger() {
			//throw new NotImplementedException();
			lstMesin4.Items.Add("Real Time Event has been triggered...");
		}

		private void btnBersihkan1_Click(object sender, EventArgs e) {
			lstMesin1.Items.Clear();
		}

		private void btnBersihkan2_Click(object sender, EventArgs e) {
			lstMesin2.Items.Clear();
		}

		private void btnBersihkan3_Click(object sender, EventArgs e) {
			lstMesin3.Items.Clear();
		}

		private void btnBersihkan4_Click(object sender, EventArgs e) {
			lstMesin4.Items.Clear();
		}

		private void FrmMesinAbsen2_FormClosing(object sender, FormClosingEventArgs e) {
			mesinAbsen1.Disconnect();
			mesinAbsen2.Disconnect();
			mesinAbsen3.Disconnect();
			mesinAbsen4.Disconnect();
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

      private void MesinAbsen1Timer_Tick(object sender, EventArgs e) {
			if (mesinAbsen1.ReadRTLog(NomorMesin1)) {
				while(mesinAbsen1.GetRTLog(NomorMesin1)) {
					;
				}
			}
      }

      private void MesinAbsen2Timer_Tick(object sender, EventArgs e) {
         if (mesinAbsen2.ReadRTLog(NomorMesin2)) {
            while (mesinAbsen2.GetRTLog(NomorMesin2)) {
               ;
            }
         }
      }

      private void MesinAbsen3Timer_Tick(object sender, EventArgs e) {
         if (mesinAbsen3.ReadRTLog(NomorMesin3)) {
            while (mesinAbsen3.GetRTLog(NomorMesin3)) {
               ;
            }
         }
      }

      private void MesinAbsen4Timer_Tick(object sender, EventArgs e) {
         if (mesinAbsen4.ReadRTLog(NomorMesin4)) {
            while (mesinAbsen4.GetRTLog(NomorMesin4)) {
               ;
            }
         }
      }

		private void button1_Click(object sender, EventArgs e) {
			if (isConnected1 == false) {
				MessageBox.Show("Please, connect to the device first");
				return;
			}
			string sdwEnrollNumber = "";
			int idwTMachineNumber = 0;
			int idwEMachineNumber = 0;
			int idwVerifyMode = 0;
			int idwInOutMode = 0;
			int idwYear = 0;
			int idwMonth = 0;
			int idwDay = 0;
			int idwHour = 0;
			int idwMinute = 0;
			int idwSecond = 0;
			int idwWorkcode = 0;

			int idwErrorCode = 0;
			int iGLCount = 0;
			int iIndex = 0;

			Cursor = Cursors.WaitCursor;
			lstMesin1.Items.Clear();
			mesinAbsen1.EnableDevice(NomorMesin1, false);
			if (mesinAbsen1.ReadGeneralLogData(NomorMesin1)) {
				string file = @"C:\LogKehadiran.txt";
				string[] lines = { };
				while(mesinAbsen1.SSR_GetGeneralLogData(NomorMesin1, out sdwEnrollNumber, out idwVerifyMode, out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode)) {
					iGLCount++;
					lines.Append($"NIK: {sdwEnrollNumber}, Tanggal/Jam: {idwDay-idwMonth-idwYear} {idwHour}:{idwMinute}:{idwSecond}");
				}
				File.WriteAllLines(file, lines);
			}
		}
	}

	class RetryException : Exception {
		public RetryException(string message) : base(message) { }
	}

	class TaskExtensions {
		public static async Task<(T1, T2)> WhenAll<T1, T2>(Task<T1> task1, Task<T2> task2) {
			var allTasks = Task.WhenAll(task1, task2);
			try {
				await allTasks;
			}
			catch (Exception ex) {
				Console.WriteLine("Task Exception", ex);
				throw allTasks.Exception;
			}
			return (task1.Result, task2.Result);
		}
	}
}
