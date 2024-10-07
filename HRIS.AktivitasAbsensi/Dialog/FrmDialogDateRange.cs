using HRIS.AktivitasAbsensi.Classes;
using HRIS.AktivitasAbsensi.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.AktivitasAbsensi.Dialog {
	public partial class FrmDialogDateRange : Form {
		public FingerPrintDevice fd { get; set; }
		public string IPAddress { get; set; }
		public int Port { get; set; }
		public int noMesin { get; set; }
      public const string localServer = "https://localhost:7023";
      //public const string remoteServer = "http://192.168.90.10:9023";
      public const string remoteServer = "http://192.168.90.2.121:9023";

      public FrmDialogDateRange() {
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

         //string msg = await fd.GetLog(IPAddress, Port, noMesin, dtStartDate.Value, dtEndDate.Value);

         //fd = new FingerPrintDevice("192.168.94.94", 4370, 3);
         //string msg = await fd.GetLogTest(dtStartDate.Value, dtEndDate.Value);

         //string msg = await TestGetLog(dtStartDate.Value, dtEndDate.Value);

         string msg;
         FingerPrintDevice fpd = new FingerPrintDevice(IPAddress, Port, noMesin);
         fpd.ConnectNet();
         if (fpd.Connected) {
            msg = await fpd.GetLog(IPAddress, Port, noMesin, dtStartDate.Value, dtEndDate.Value);
         }
         else {
            msg = "Koneksi ke mesin absen " + IPAddress + " gagal!";
         }

         Cursor.Current = Cursors.Default;
         MessageBox.Show(msg, "Konfirmasi");


      }

		private async Task<string> TestGetLog(DateTime startDate, DateTime endDate) {
         string token = Settings.Default.AuthToken;
         HttpClient client = new HttpClient();
         client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
         string sDate = startDate.ToString("yyyy-MM-dd");
         string eDate = endDate.ToString("yyyy-MM-dd");
         var response = await client.GetAsync($"{remoteServer}/MesinAbsens/Log/{sDate}/{eDate}");
         if (response.IsSuccessStatusCode) {
            return "Donwload log mesin absen berhasil.";
         }
         else {
            return "Donwload log mesin absen gagal!!";
         }
         
      }

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
