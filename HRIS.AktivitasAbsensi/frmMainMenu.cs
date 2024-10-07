using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRIS.AktivitasAbsensi.Models;

namespace HRIS.AktivitasAbsensi {

	public partial class frmMainMenu : Form {
		private string userName;

		public frmMainMenu(string _userName) {
			InitializeComponent();
			this.userName = _userName;
		}

		private void frmMainMenu_Load(object sender, EventArgs e) {
			this.Tgl.Text = DateTime.Now.ToString("dd-MM-yyyy");
			this.UserName.Text = $"User: {userName}";
		}

		private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e) {
			this.Dispose();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

		}
	}
}
