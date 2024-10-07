namespace HRIS_MesinAbsen {
	partial class FrmAktivitasMesinAbsen {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			lstMesinAbsen = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			btnConnectAll = new Button();
			listBox1 = new ListBox();
			menuStrip1 = new MenuStrip();
			settingToolStripMenuItem = new ToolStripMenuItem();
			loginToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// lstMesinAbsen
			// 
			lstMesinAbsen.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
			lstMesinAbsen.Cursor = Cursors.Hand;
			lstMesinAbsen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lstMesinAbsen.GridLines = true;
			lstMesinAbsen.Location = new Point(12, 27);
			lstMesinAbsen.MultiSelect = false;
			lstMesinAbsen.Name = "lstMesinAbsen";
			lstMesinAbsen.Size = new Size(716, 171);
			lstMesinAbsen.TabIndex = 0;
			lstMesinAbsen.UseCompatibleStateImageBehavior = false;
			lstMesinAbsen.View = View.Details;
			lstMesinAbsen.SelectedIndexChanged += lstMesinAbsen_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Id";
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "No.Mesin";
			columnHeader6.Width = 100;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Nama Mesin";
			columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "IP Address";
			columnHeader3.Width = 175;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Port";
			columnHeader5.Width = 75;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Status";
			columnHeader4.Width = 150;
			// 
			// btnConnectAll
			// 
			btnConnectAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnConnectAll.Location = new Point(12, 204);
			btnConnectAll.Name = "btnConnectAll";
			btnConnectAll.Size = new Size(716, 34);
			btnConnectAll.TabIndex = 1;
			btnConnectAll.Text = "Connect All";
			btnConnectAll.UseVisualStyleBackColor = true;
			btnConnectAll.Click += btnConnectAll_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(12, 244);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(716, 184);
			listBox1.TabIndex = 2;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(743, 24);
			menuStrip1.TabIndex = 3;
			menuStrip1.Text = "menuStrip1";
			// 
			// settingToolStripMenuItem
			// 
			settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
			settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			settingToolStripMenuItem.Size = new Size(56, 20);
			settingToolStripMenuItem.Text = "Setting";
			// 
			// loginToolStripMenuItem
			// 
			loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			loginToolStripMenuItem.Size = new Size(104, 22);
			loginToolStripMenuItem.Text = "Login";
			loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
			// 
			// FrmAktivitasMesinAbsen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(743, 445);
			Controls.Add(listBox1);
			Controls.Add(btnConnectAll);
			Controls.Add(lstMesinAbsen);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "FrmAktivitasMesinAbsen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Aktivitas Mesin Absensi";
			Load += FrmAktivitasMesinAbsen_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		#endregion

		private ListView lstMesinAbsen;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private Button btnConnectAll;
		public ListBox listBox1;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem settingToolStripMenuItem;
		private ToolStripMenuItem loginToolStripMenuItem;
	}
}