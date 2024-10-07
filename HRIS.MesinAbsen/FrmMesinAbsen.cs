using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
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

namespace HRIS.MesinAbsen {
	public partial class FrmMesinAbsen : Form {
		public zkemkeeper.CZKEM mesinAbsen1 = new();
		public zkemkeeper.CZKEM mesinAbsen2 = new();
		public zkemkeeper.CZKEM mesinAbsen3 = new();
		public zkemkeeper.CZKEM mesinAbsen4 = new();

		public List<MesinAbsenDTO> mesinAbsenDTOs = new();
		public List<JadwalKerjaKaryawanDTO> jadwalKerjaKaryawanDTOs = new();
		public List<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs = new();
		public Button newButton;

		public FrmMesinAbsen() {
			InitializeComponent();
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

		private async void FrmMesinAbsen_Load(object sender, EventArgs e) {
			//HttpClient httpClient = new();
			//var response = await httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/MesinAbsens");
			mesinAbsenDTOs = await GetMesinAbsensAsync();
			if (mesinAbsenDTOs != null) {
				//mesinAbsenDTOs = await response.Content.ReadFromJsonAsync<List<MesinAbsenDTO>>();
				//mesinAbsenDTOs = await response.Content.ReadFromJsonAsync<List<MesinAbsenDTO>>();
				txtNamaMesin1.Text = mesinAbsenDTOs[0].DeviceDesc;
				txtIPAddress1.Text = mesinAbsenDTOs[0].DeviceIP;
				txtPort1.Text = mesinAbsenDTOs[0].Port.ToString();

				txtNamaMesin2.Text = mesinAbsenDTOs[1].DeviceDesc;
				txtIPAddress2.Text = mesinAbsenDTOs[1].DeviceIP;
				txtPort2.Text = mesinAbsenDTOs[1].Port.ToString();

				txtNamaMesin3.Text = mesinAbsenDTOs[2].DeviceDesc;
				txtIPAddress3.Text = mesinAbsenDTOs[2].DeviceIP;
				txtPort3.Text = mesinAbsenDTOs[2].Port.ToString();

				txtNamaMesin4.Text = mesinAbsenDTOs[3].DeviceDesc;
				txtIPAddress4.Text = mesinAbsenDTOs[3].DeviceIP;
				txtPort4.Text = mesinAbsenDTOs[3].Port.ToString();

			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void btnConnect1_Click(object sender, EventArgs e) {
			btnConnect1.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			bool connected;
			if (btnConnect1.Text == "Connect") {
				connected = mesinAbsen1.Connect_Net(txtIPAddress1.Text, int.Parse(txtPort1.Text));
				if (connected) {
					lbStatus1.Text = "Connected";
					mesinAbsen1.EnableDevice(1, true);
					if (mesinAbsen1.RegEvent(1, 65535)) {
						mesinAbsen1.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen1_OnFinger);
						mesinAbsen1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen1_OnVerfify);
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
					}
					btnConnect1.Text = "Disconnect";
				}
				else {
					lsvMessage1.Items.Add("Connected Failed!");
					btnConnect1.Text = "Connect";
					lbStatus1.Text = "Not Connected";
				}

			}
			else {
				mesinAbsen1.Disconnect();
				mesinAbsen1.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen1_OnFinger);
				mesinAbsen1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen1_OnVerfify);
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

				btnConnect1.Text = "Connect";
				lbStatus1.Text = "Not Connected";
				connected = false;
			}

			btnConnect1.Enabled = true;
			this.Cursor = Cursors.Default;
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

		private void mesinAbsen1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			//throw new NotImplementedException();

			mesinAbsen1.EnableDevice(1, true);
			string nik = sEnrollNumber.ToString();

			lsvMessage1.Items.Add($"NIK: {nik} berhasil Absen");
		}

		private void mesinAbsen1_OnVerfify(int intUserID) {
			//throw new NotImplementedException();
			lsvMessage1.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				lsvMessage1.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				lsvMessage1.Items.Add("Verified failed...");
			}
		}

		private void mesinAbsen1_OnFinger() {
			//throw new NotImplementedException();
			lsvMessage1.Items.Add("Real Time Event has been triggered...");
		}

		private void btnConnect2_Click(object sender, EventArgs e) {
			btnConnect2.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			bool connected;
			if (btnConnect2.Text == "Connect") {
				connected = mesinAbsen2.Connect_Net(txtIPAddress2.Text, int.Parse(txtPort2.Text));
				if (connected) {
					mesinAbsen2.EnableDevice(1, true);
					lbStatus2.Text = "Connected";
					if (mesinAbsen2.RegEvent(1, 65535)) {
						mesinAbsen2.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen2_OnFinger);
						mesinAbsen2.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen2_OnVerfify);
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
					}
					btnConnect2.Text = "Disconnect";
				}
				else {
					lsvMessage2.Items.Add("Connected Failed!");
					btnConnect2.Text = "Connect";
					lbStatus2.Text = "Not Connected";
				}

			}
			else {
				mesinAbsen2.Disconnect();
				mesinAbsen2.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen2_OnFinger);
				mesinAbsen2.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen2_OnVerfify);
				mesinAbsen2.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen2_OnAttTransactionEx);
				mesinAbsen2.OnFingerFeature -= new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen2_OnFingerFeature);
				mesinAbsen2.OnEnrollFingerEx -= new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen2_OnEnrollFingerEx);
				this.mesinAbsen2.OnDeleteTemplate -= new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen2_OnDeleteTemplate);
				this.mesinAbsen2.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen2_OnNewUser);
				this.mesinAbsen2.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen2_OnHIDNum);
				this.mesinAbsen2.OnAlarm -= new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen2_OnAlarm);
				this.mesinAbsen2.OnDoor -= new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen2_OnDoor);
				this.mesinAbsen2.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen2_OnWriteCard);
				this.mesinAbsen2.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen2_OnEmptyCard);

				btnConnect2.Text = "Connect";
				lbStatus2.Text = "Not Connected";
				connected = false;
			}

			btnConnect2.Enabled = true;
			this.Cursor = Cursors.Default;
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

		private void mesinAbsen2_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			//throw new NotImplementedException();

			mesinAbsen2.EnableDevice(1, true);
			string nik = sEnrollNumber.ToString();

			lsvMessage2.Items.Add($"NIK: {nik} berhasil Absen");
		}

		private void mesinAbsen2_OnVerfify(int intUserID) {
			//throw new NotImplementedException();
			lsvMessage2.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				lsvMessage2.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				lsvMessage2.Items.Add("Verified failed...");
			}
		}

		private void mesinAbsen2_OnFinger() {
			//throw new NotImplementedException();
			lsvMessage2.Items.Add("Real Time Event has been triggered...");
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

		private void mesinAbsen3_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			//throw new NotImplementedException();

			mesinAbsen3.EnableDevice(1, true);
			string nik = sEnrollNumber.ToString();

			lsvMessage3.Items.Add($"NIK: {nik} berhasil Absen");
		}

		private void mesinAbsen3_OnVerfify(int intUserID) {
			//throw new NotImplementedException();
			lsvMessage3.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				lsvMessage3.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				lsvMessage3.Items.Add("Verified failed...");
			}
		}

		private void mesinAbsen3_OnFinger() {
			//throw new NotImplementedException();
			lsvMessage3.Items.Add("Real Time Event has been triggered...");
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

		private void mesinAbsen4_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
			//throw new NotImplementedException();

			mesinAbsen4.EnableDevice(1, true);
			string nik = sEnrollNumber.ToString();

			lsvMessage4.Items.Add($"NIK: {nik} berhasil Absen");
		}

		private void mesinAbsen4_OnVerfify(int intUserID) {
			//throw new NotImplementedException();
			lsvMessage4.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
			if (intUserID != -1) {
				lsvMessage4.Items.Add("Verified OK, the UserID is " + intUserID.ToString());
			}
			else {
				lsvMessage4.Items.Add("Verified failed...");
			}
		}

		private void mesinAbsen4_OnFinger() {
			//throw new NotImplementedException();
			lsvMessage4.Items.Add("Real Time Event has been triggered...");
		}

		private void btnConnect3_Click(object sender, EventArgs e) {
			btnConnect3.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			bool connected;
			if (btnConnect3.Text == "Connect") {
				connected = mesinAbsen3.Connect_Net(txtIPAddress3.Text, int.Parse(txtPort3.Text));
				if (connected) {
					mesinAbsen3.EnableDevice(1, true);
					lbStatus3.Text = "Connected";
					if (mesinAbsen3.RegEvent(1, 65535)) {
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
					}
					btnConnect3.Text = "Disconnect";
				}
				else {
					lsvMessage3.Items.Add("Connected Failed!");
					btnConnect3.Text = "Connect";
					lbStatus3.Text = "Not Connected";
				}

			}
			else {
				mesinAbsen3.Disconnect();
				mesinAbsen3.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen3_OnFinger);
				mesinAbsen3.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen3_OnVerfify);
				mesinAbsen3.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen3_OnAttTransactionEx);
				mesinAbsen3.OnFingerFeature -= new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen3_OnFingerFeature);
				mesinAbsen3.OnEnrollFingerEx -= new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen3_OnEnrollFingerEx);
				this.mesinAbsen3.OnDeleteTemplate -= new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen3_OnDeleteTemplate);
				this.mesinAbsen3.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen3_OnNewUser);
				this.mesinAbsen3.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen3_OnHIDNum);
				this.mesinAbsen3.OnAlarm -= new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen3_OnAlarm);
				this.mesinAbsen3.OnDoor -= new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen3_OnDoor);
				this.mesinAbsen3.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen3_OnWriteCard);
				this.mesinAbsen3.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen3_OnEmptyCard);

				btnConnect3.Text = "Connect";
				lbStatus3.Text = "Not Connected";
				connected = false;
			}
			btnConnect3.Enabled = true;
			this.Cursor = Cursors.Default;
		}

		private void btnConnect4_Click(object sender, EventArgs e) {
			btnConnect4.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			bool connected;
			if (btnConnect4.Text == "Connect") {
				connected = mesinAbsen4.Connect_Net(txtIPAddress4.Text, int.Parse(txtPort4.Text));
				if (connected) {
					mesinAbsen4.EnableDevice(1, true);
					lbStatus4.Text = "Connected";
					if (mesinAbsen4.RegEvent(1, 65535)) {
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
					}
					btnConnect4.Text = "Disconnect";
				}
				else {
					lsvMessage4.Items.Add("Connected Failed!");
					btnConnect4.Text = "Connect";
					lbStatus4.Text = "Not Connected";
				}

			}
			else {
				mesinAbsen4.Disconnect();
				mesinAbsen4.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(mesinAbsen4_OnFinger);
				mesinAbsen4.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(mesinAbsen4_OnVerfify);
				mesinAbsen4.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen4_OnAttTransactionEx);
				mesinAbsen4.OnFingerFeature -= new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(mesinAbsen4_OnFingerFeature);
				mesinAbsen4.OnEnrollFingerEx -= new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(mesinAbsen4_OnEnrollFingerEx);
				this.mesinAbsen4.OnDeleteTemplate -= new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(mesinAbsen4_OnDeleteTemplate);
				this.mesinAbsen4.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(mesinAbsen4_OnNewUser);
				this.mesinAbsen4.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(mesinAbsen4_OnHIDNum);
				this.mesinAbsen4.OnAlarm -= new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(mesinAbsen4_OnAlarm);
				this.mesinAbsen4.OnDoor -= new zkemkeeper._IZKEMEvents_OnDoorEventHandler(mesinAbsen4_OnDoor);
				this.mesinAbsen4.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(mesinAbsen4_OnWriteCard);
				this.mesinAbsen4.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(mesinAbsen4_OnEmptyCard);

				btnConnect4.Text = "Connect";
				lbStatus4.Text = "Not Connected";
				connected = false;
			}

			btnConnect4.Enabled = true;
			this.Cursor = Cursors.Default;
		}
	}

	class RetryException : Exception {
		public RetryException(string? message) : base(message) { }
	}

}
