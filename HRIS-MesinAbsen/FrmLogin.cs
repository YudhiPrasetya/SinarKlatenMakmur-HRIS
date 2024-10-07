using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Contracts;
using HRIS.Models;
using HRIS.Services;
using Microsoft.AspNetCore.Components;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace HRIS_MesinAbsen {
	public partial class FrmLogin : Form {
		public ITokenService tokenService;
		public IAuthenticationHttpClientService authenticationHttpClientService;
		public UserLoginDTO userLoginDTO;

		public FrmLogin() {
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e) {

		}

		private async void button1_Click(object sender, EventArgs e) {
			string userName = txtUserName.Text;
			string password = txtPassword.Text;

			//ApiOperations ops = new();
			//User user = ops.AuthenticateUser(userName, password);
			//if (user == null) {
			//	MessageBox.Show("Invalid username or password");
			//	return;
			//}
			//Globals.LoggedInUser = user;
			//MessageBox.Show($"Token: {user.access_token}");

			UserLoginDTO userLoginDTO = new() {
				UserName = userName,
				Password = password
			};

			try {
				HttpClient client = new();
				var response = await client.PostAsJsonAsync($"{BaseUrl.ServerBaseUrl}/Auth", userLoginDTO);
				//Console.WriteLine(response.Content.ReadFromJsonAsync());
				//var result = await authenticationHttpClientService.LoginUser(userLoginDTO);
				//if(result != null) {
				//	MessageBox.Show($"Token: {result.Token}");
				//}
				if (response.IsSuccessStatusCode) {
					FrmAktivitasMesinAbsen frmAktivitasMesinAbsen = new();
					frmAktivitasMesinAbsen.Show();
					this.Hide();
					//this.Close();
				}
			}
			catch (System.Exception ex) {
				throw ex;
			}

		}
	}
}
