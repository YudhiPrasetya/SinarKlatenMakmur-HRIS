using HRIS.AktivitasAbsensi.Classes;
using HRIS.AktivitasAbsensi.Dialog;
using HRIS.AktivitasAbsensi.Models;
using HRIS.AktivitasAbsensi.Properties;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zkemkeeper;

namespace HRIS.AktivitasAbsensi {
	public partial class frmDashboard : Form {
		public List<MesinAbsenDTO> mesinAbsenDTOs = new List<MesinAbsenDTO>();
		
		//public Dictionary<string, CZKEM> mesinAbsen = new Dictionary<string, CZKEM>();
		//public zkemkeeper.CZKEM mesinAbsen = new CZKEM();
		//public FingerPrintDevice mesinAbsen;
		public bool isConnected = false;
		private ListViewItem itemSelected;
		private int intSelectedItemIndex = -1;
		private FrmDialogDateRange frmDialogDateRange;

      public const string localServer = "https://localhost:7023";
      public const string remoteServer = "http://192.168.2.121:9023";


      //#if DEBUG
      //		public const string baseUrl = "https://localhost:7023";
      //#else
      //		public const string baseUrl = "http://192.168.2.121:9023";
      //#endif
      public frmDashboard() {
			InitializeComponent();
		}

		private async void frmDashboard_Load(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			frmDialogDateRange = new FrmDialogDateRange();

			var result = await GetMesinAbsensAsync();
			mesinAbsenDTOs = JsonConvert.DeserializeObject<List<MesinAbsenDTO>>(result);

			for(int i = 0; i <= mesinAbsenDTOs.Count-1; i++) {
				string[] item = {
					mesinAbsenDTOs[i].DeviceDesc, mesinAbsenDTOs[i].DeviceNo.ToString(),
					(mesinAbsenDTOs[i].Connected == false ? "Terputus" : "Terkoneksi"), mesinAbsenDTOs[i].DeviceIP, mesinAbsenDTOs[i].Port.ToString()
				};
				ListViewItem listViewItem = new ListViewItem(item);
				listMesinAbsen.Items.Add(listViewItem);
				//mesinAbsen.Add($"msnAbsen{i + 1}", new CZKEM());
			}
			Cursor = Cursors.Default;
			//foreach(KeyValuePair<string, CZKEM> mAbsen in mesinAbsen) {
			//	//Console.WriteLine($"Key: {mAbsen.Key}, Value: {mAbsen.Value}");
			//}

		}

		public async Task<string> GetMesinAbsensAsync() {
			int tries = 0;
			int numOfRetries = 2;
			while (tries <= numOfRetries) {

				try {
					DateTime tokenExpire = Settings.Default.TokenExpire;
					if(tokenExpire < DateTime.Now) {

					}
					string token = Settings.Default.AuthToken;
					HttpClient client = new HttpClient();
					client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
					var response = await client.GetAsync($"{remoteServer}/MesinAbsens");
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

		private void listMesinAbsen_SelectedIndexChanged(object sender, EventArgs e) {
		}

		private void listMesinAbsen_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
		}

		private void listMesinAbsen_Click(object sender, EventArgs e) {
			//int intIndex = listMesinAbsen.FocusedItem.Index;
			//string strStatusKoneksi = listMesinAbsen.Items[intIndex].SubItems[2].Text;
			//btnDisconnect.Enabled = strStatusKoneksi == "Terkoneksi";
			
		}

		private void btnConnect_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor; 
			foreach(ListViewItem item in listMesinAbsen.Items) {
				//Console.WriteLine($"IP: {item.SubItems[3].Text}, Port: {item.SubItems[4].Text}");

				//foreach (KeyValuePair<string, CZKEM> mAbsen in mesinAbsen) {
				//	//Console.WriteLine($"Key: {mAbsen.Key}, Value: {mAbsen.Value}");
				//	bool isConnected = mAbsen.Value.Connect_Net(item.SubItems[3].Text.ToString(), int.Parse(item.SubItems[4].Text));
				//	if(isConnected) {
				//		mAbsen.Value.OnAttTransactionEx += new _IZKEMEvents_OnAttTransactionExEventHandler(mAbsen.Key + "_OnAttTransactionEx");
				//		item.SubItems[2].Text = "Terkoneksi";
				//	}
				//}
				//isConnected = mesinAbsen.Connect_Net(item.SubItems[3].Text.ToString(), int.Parse(item.SubItems[4].Text));
				//if(isConnected ) {
				//	mesinAbsen.OnAttTransactionEx += new _IZKEMEvents_OnAttTransactionExEventHandler(mesinAbsen_OnAttTransactionEx);
				//	item.SubItems[2].Text = "Terkoneksi";
				//}

				FingerPrintDevice mesinAbsen = new FingerPrintDevice(item.SubItems[3].Text.ToString(), int.Parse(item.SubItems[4].Text),1);
				mesinAbsen.ConnectNet();
				if (mesinAbsen.Connected) {
					item.SubItems[2].Text = "Terkoneksi";
				}
				else {
					item.SubItems[2].Text = "Terputus";
				}

			}
			Cursor = Cursors.Default;
		}

		private void listMesinAbsen_MouseClick(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Right) {
				intSelectedItemIndex = listMesinAbsen.FocusedItem.Index;
				//MessageBox.Show(intIndex.ToString());
				if(intSelectedItemIndex >= 0) {
					itemSelected = listMesinAbsen.FocusedItem;
					downloadLogKehadiranToolStripMenuItem.Enabled = true;
					putuskanToolStripMenuItem.Enabled = true;
					koneksikanToolStripMenuItem.Enabled = true;
				}
				else {
					itemSelected = null;
					downloadLogKehadiranToolStripMenuItem.Enabled = false;
					putuskanToolStripMenuItem.Enabled = false;
					koneksikanToolStripMenuItem.Enabled = false;
				}

			}
		}

		private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e) {
			intSelectedItemIndex = -1;
			downloadLogKehadiranToolStripMenuItem.Enabled = false;
			putuskanToolStripMenuItem.Enabled = false;
			koneksikanToolStripMenuItem.Enabled=false;
		}

		private void koneksikanToolStripMenuItem_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
         FingerPrintDevice mesinAbsen = new FingerPrintDevice(itemSelected.SubItems[3].Text.ToString(), int.Parse(itemSelected.SubItems[4].Text), int.Parse(itemSelected.SubItems[1].Text));
			mesinAbsen.ConnectNet();
			if (mesinAbsen.Connected) {
				itemSelected.SubItems[2].Text = "Terkoneksi";
			}
			else {
				itemSelected.SubItems[2].Text = "Terputus";
			}
			Cursor = Cursors.Default;
			//await mesinAbsen.SaveAddAbsenRTTest();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

      }

		private void downloadLogKehadiranToolStripMenuItem_Click(object sender, EventArgs e) {
			//Cursor = Cursors.WaitCursor;
			//mesinAbsen.GetLog(int.Parse(itemSelected.SubItems[1].Text), DateTime.Now, DateTime.Now);
			//Cursor = Cursors.Default;
			frmDialogDateRange.IPAddress = itemSelected.SubItems[3].Text;
			frmDialogDateRange.Port = int.Parse(itemSelected.SubItems[4].Text);
			//frmDialogDateRange.fd = mesinAbsen;
			frmDialogDateRange.noMesin = int.Parse(itemSelected.SubItems[1].Text);
			frmDialogDateRange.ShowDialog(this);
		}

      private async void button1_Click(object sender, EventArgs e) {
         Cursor = Cursors.WaitCursor;

			FingerPrintDevice mesinAbsen = new FingerPrintDevice("192.168.94.94", 4370, 3);
			await mesinAbsen.RealTimeTest("192.168.94.94", 4370, 3);
         Cursor = Cursors.Default;
      }

      //private void mesinAbsen_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode) {
      //	Console.WriteLine($"NIK: {sEnrollNumber}, Tanggal-Jam: {iDay / iMonth / iYear} {iHour}:{iMinute}:{iSecond}");
      //}
   }

   class RetryException : Exception {
		public RetryException(string message) : base(message) { }
	}
}
