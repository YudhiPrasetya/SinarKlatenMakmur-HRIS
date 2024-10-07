using HRIS.MesinAbsen2.Models;
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

namespace HRIS.MesinAbsen2 {
	public partial class FrmLogin : Form {
		public FrmLogin() {
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
				var content = JsonConvert.SerializeObject(userLoginDTO);
				var buffer = System.Text.Encoding.UTF8.GetBytes(content);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
				HttpClient client = new HttpClient();
				var response = await client.PostAsync($"{BaseUrl.ServerBaseUrl}/Auth", byteContent);
				if (response.IsSuccessStatusCode) {
					FrmMesinAbsen2 frmMesinAbsen2 = new FrmMesinAbsen2();
					frmMesinAbsen2.Show();
					this.Hide();
				}
			}
			catch (Exception) {

				throw;
			}
		}
	}
}
