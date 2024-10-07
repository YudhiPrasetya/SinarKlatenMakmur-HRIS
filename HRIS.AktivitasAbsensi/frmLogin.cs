using HRIS.AktivitasAbsensi.Models;
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

namespace HRIS.AktivitasAbsensi {
	public partial class frmLogin : Form {
		//#if DEBUG
		//      public const string baseUrl = "https://localhost:7023";
		//#else
		//		public const string baseUrl = "http://192.168.90.10:9023";
		//#endif
		public const string localServer = "https://localhost:7023";
      public const string remoteServer = "http://192.168.2.121:9023";
      public frmLogin() {
			InitializeComponent();
		}

		private async void btnLogin_Click(object sender, EventArgs e) {
			string UserName = txtUserName.Text;
			string Password = txtPassword.Text;

			UserLoginDTO userLoginDTO = new UserLoginDTO() {
				UserName = UserName,
				Password = Password
			};

			try {
				Cursor = Cursors.WaitCursor;

				var content = JsonConvert.SerializeObject(userLoginDTO);
				var buffer = System.Text.Encoding.UTF8.GetBytes(content);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
				HttpClient client = new HttpClient();
				HttpResponseMessage response = await client.PostAsync($"{remoteServer}/Auth", byteContent);
				if (response.StatusCode == System.Net.HttpStatusCode.OK) {
					var result = await response.Content.ReadAsStringAsync();
					TokenDTO tokenDTO = JsonConvert.DeserializeObject<TokenDTO>(result);
					Settings.Default.AuthToken = tokenDTO.Token;
					Settings.Default.TokenExpire = tokenDTO.ExpiresIn;
					

					frmMainMenu fMainMenu = new frmMainMenu(UserName);
					frmDashboard fDashboard = new frmDashboard();
					fDashboard.MdiParent = fMainMenu;
					//fDashboard.Visible = false;
					this.Hide();
					
					fMainMenu.Show();
					fDashboard.Dock = DockStyle.Fill;
					fDashboard.Show();
					fDashboard.WindowState = FormWindowState.Maximized;
					Cursor = Cursors.Default;
				}
				else {
					Cursor = Cursors.WaitCursor;
					string msg = await response.Content.ReadAsStringAsync();
					MessageBox.Show(msg, "Peringatan!");
					Cursor = Cursors.Default;
				}
			}
			catch (Exception) {

				throw;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

      private void frmLogin_Load(object sender, EventArgs e) {

      }
   }
}
