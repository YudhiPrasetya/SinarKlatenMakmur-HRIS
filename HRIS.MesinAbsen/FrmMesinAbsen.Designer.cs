namespace HRIS.MesinAbsen {
	partial class FrmMesinAbsen {
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
			groupBox1 = new GroupBox();
			btnBersihkan1 = new Button();
			lsvMessage1 = new ListBox();
			btnConnect1 = new Button();
			txtPort1 = new TextBox();
			txtIPAddress1 = new TextBox();
			txtNamaMesin1 = new TextBox();
			lbStatus1 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btnBersihkan2 = new Button();
			lsvMessage2 = new ListBox();
			btnConnect2 = new Button();
			txtPort2 = new TextBox();
			txtIPAddress2 = new TextBox();
			txtNamaMesin2 = new TextBox();
			lbStatus2 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			groupBox3 = new GroupBox();
			btnBersihkan4 = new Button();
			lsvMessage4 = new ListBox();
			btnConnect4 = new Button();
			txtPort4 = new TextBox();
			txtIPAddress4 = new TextBox();
			txtNamaMesin4 = new TextBox();
			lbStatus4 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			groupBox4 = new GroupBox();
			btnBersihkan3 = new Button();
			lsvMessage3 = new ListBox();
			btnConnect3 = new Button();
			txtPort3 = new TextBox();
			txtIPAddress3 = new TextBox();
			txtNamaMesin3 = new TextBox();
			lbStatus3 = new Label();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnBersihkan1);
			groupBox1.Controls.Add(lsvMessage1);
			groupBox1.Controls.Add(btnConnect1);
			groupBox1.Controls.Add(txtPort1);
			groupBox1.Controls.Add(txtIPAddress1);
			groupBox1.Controls.Add(txtNamaMesin1);
			groupBox1.Controls.Add(lbStatus1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(400, 296);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Mesin Absen 1";
			// 
			// btnBersihkan1
			// 
			btnBersihkan1.Location = new Point(295, 265);
			btnBersihkan1.Name = "btnBersihkan1";
			btnBersihkan1.Size = new Size(99, 25);
			btnBersihkan1.TabIndex = 9;
			btnBersihkan1.Text = "Bersihkan";
			btnBersihkan1.UseVisualStyleBackColor = true;
			// 
			// lsvMessage1
			// 
			lsvMessage1.FormattingEnabled = true;
			lsvMessage1.ItemHeight = 14;
			lsvMessage1.Location = new Point(6, 90);
			lsvMessage1.Name = "lsvMessage1";
			lsvMessage1.Size = new Size(388, 172);
			lsvMessage1.TabIndex = 8;
			// 
			// btnConnect1
			// 
			btnConnect1.Location = new Point(295, 31);
			btnConnect1.Name = "btnConnect1";
			btnConnect1.Size = new Size(99, 39);
			btnConnect1.TabIndex = 7;
			btnConnect1.Text = "Connect";
			btnConnect1.UseVisualStyleBackColor = true;
			btnConnect1.Click += btnConnect1_Click;
			// 
			// txtPort1
			// 
			txtPort1.Location = new Point(238, 48);
			txtPort1.Name = "txtPort1";
			txtPort1.Size = new Size(53, 22);
			txtPort1.TabIndex = 6;
			// 
			// txtIPAddress1
			// 
			txtIPAddress1.Location = new Point(116, 48);
			txtIPAddress1.Name = "txtIPAddress1";
			txtIPAddress1.Size = new Size(115, 22);
			txtIPAddress1.TabIndex = 5;
			// 
			// txtNamaMesin1
			// 
			txtNamaMesin1.Location = new Point(6, 48);
			txtNamaMesin1.Name = "txtNamaMesin1";
			txtNamaMesin1.Size = new Size(100, 22);
			txtNamaMesin1.TabIndex = 4;
			txtNamaMesin1.TextChanged += textBox1_TextChanged;
			// 
			// lbStatus1
			// 
			lbStatus1.ForeColor = Color.Red;
			lbStatus1.Location = new Point(6, 73);
			lbStatus1.Name = "lbStatus1";
			lbStatus1.Size = new Size(359, 14);
			lbStatus1.TabIndex = 3;
			lbStatus1.Text = "Not Connected";
			lbStatus1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(238, 31);
			label3.Name = "label3";
			label3.Size = new Size(33, 14);
			label3.TabIndex = 2;
			label3.Text = "Port";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(116, 31);
			label2.Name = "label2";
			label2.Size = new Size(82, 14);
			label2.TabIndex = 1;
			label2.Text = "IP Addresss";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 31);
			label1.Name = "label1";
			label1.Size = new Size(83, 14);
			label1.TabIndex = 0;
			label1.Text = "Nama Mesin";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnBersihkan2);
			groupBox2.Controls.Add(lsvMessage2);
			groupBox2.Controls.Add(btnConnect2);
			groupBox2.Controls.Add(txtPort2);
			groupBox2.Controls.Add(txtIPAddress2);
			groupBox2.Controls.Add(txtNamaMesin2);
			groupBox2.Controls.Add(lbStatus2);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label7);
			groupBox2.Location = new Point(459, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(405, 296);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Mesin Absen 2";
			// 
			// btnBersihkan2
			// 
			btnBersihkan2.Location = new Point(290, 265);
			btnBersihkan2.Name = "btnBersihkan2";
			btnBersihkan2.Size = new Size(99, 25);
			btnBersihkan2.TabIndex = 10;
			btnBersihkan2.Text = "Bersihkan";
			btnBersihkan2.UseVisualStyleBackColor = true;
			// 
			// lsvMessage2
			// 
			lsvMessage2.FormattingEnabled = true;
			lsvMessage2.ItemHeight = 14;
			lsvMessage2.Location = new Point(6, 90);
			lsvMessage2.Name = "lsvMessage2";
			lsvMessage2.Size = new Size(383, 172);
			lsvMessage2.TabIndex = 8;
			// 
			// btnConnect2
			// 
			btnConnect2.Location = new Point(295, 31);
			btnConnect2.Name = "btnConnect2";
			btnConnect2.Size = new Size(94, 39);
			btnConnect2.TabIndex = 7;
			btnConnect2.Text = "Connect";
			btnConnect2.UseVisualStyleBackColor = true;
			btnConnect2.Click += btnConnect2_Click;
			// 
			// txtPort2
			// 
			txtPort2.Location = new Point(238, 48);
			txtPort2.Name = "txtPort2";
			txtPort2.Size = new Size(53, 22);
			txtPort2.TabIndex = 6;
			// 
			// txtIPAddress2
			// 
			txtIPAddress2.Location = new Point(116, 48);
			txtIPAddress2.Name = "txtIPAddress2";
			txtIPAddress2.Size = new Size(115, 22);
			txtIPAddress2.TabIndex = 5;
			// 
			// txtNamaMesin2
			// 
			txtNamaMesin2.Location = new Point(6, 48);
			txtNamaMesin2.Name = "txtNamaMesin2";
			txtNamaMesin2.Size = new Size(100, 22);
			txtNamaMesin2.TabIndex = 4;
			// 
			// lbStatus2
			// 
			lbStatus2.ForeColor = Color.Red;
			lbStatus2.Location = new Point(6, 73);
			lbStatus2.Name = "lbStatus2";
			lbStatus2.Size = new Size(359, 14);
			lbStatus2.TabIndex = 3;
			lbStatus2.Text = "Not Connected";
			lbStatus2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(238, 31);
			label5.Name = "label5";
			label5.Size = new Size(33, 14);
			label5.TabIndex = 2;
			label5.Text = "Port";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(116, 31);
			label6.Name = "label6";
			label6.Size = new Size(82, 14);
			label6.TabIndex = 1;
			label6.Text = "IP Addresss";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 31);
			label7.Name = "label7";
			label7.Size = new Size(83, 14);
			label7.TabIndex = 0;
			label7.Text = "Nama Mesin";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btnBersihkan4);
			groupBox3.Controls.Add(lsvMessage4);
			groupBox3.Controls.Add(btnConnect4);
			groupBox3.Controls.Add(txtPort4);
			groupBox3.Controls.Add(txtIPAddress4);
			groupBox3.Controls.Add(txtNamaMesin4);
			groupBox3.Controls.Add(lbStatus4);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(label10);
			groupBox3.Controls.Add(label11);
			groupBox3.Location = new Point(459, 314);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(405, 311);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Mesin Absen 4";
			// 
			// btnBersihkan4
			// 
			btnBersihkan4.Location = new Point(290, 280);
			btnBersihkan4.Name = "btnBersihkan4";
			btnBersihkan4.Size = new Size(99, 25);
			btnBersihkan4.TabIndex = 10;
			btnBersihkan4.Text = "Bersihkan";
			btnBersihkan4.UseVisualStyleBackColor = true;
			// 
			// lsvMessage4
			// 
			lsvMessage4.FormattingEnabled = true;
			lsvMessage4.ItemHeight = 14;
			lsvMessage4.Location = new Point(6, 90);
			lsvMessage4.Name = "lsvMessage4";
			lsvMessage4.Size = new Size(383, 186);
			lsvMessage4.TabIndex = 8;
			// 
			// btnConnect4
			// 
			btnConnect4.Location = new Point(295, 31);
			btnConnect4.Name = "btnConnect4";
			btnConnect4.Size = new Size(94, 39);
			btnConnect4.TabIndex = 7;
			btnConnect4.Text = "Connect";
			btnConnect4.UseVisualStyleBackColor = true;
			btnConnect4.Click += btnConnect4_Click;
			// 
			// txtPort4
			// 
			txtPort4.Location = new Point(238, 48);
			txtPort4.Name = "txtPort4";
			txtPort4.Size = new Size(53, 22);
			txtPort4.TabIndex = 6;
			// 
			// txtIPAddress4
			// 
			txtIPAddress4.Location = new Point(116, 48);
			txtIPAddress4.Name = "txtIPAddress4";
			txtIPAddress4.Size = new Size(115, 22);
			txtIPAddress4.TabIndex = 5;
			// 
			// txtNamaMesin4
			// 
			txtNamaMesin4.Location = new Point(6, 48);
			txtNamaMesin4.Name = "txtNamaMesin4";
			txtNamaMesin4.Size = new Size(100, 22);
			txtNamaMesin4.TabIndex = 4;
			// 
			// lbStatus4
			// 
			lbStatus4.ForeColor = Color.Red;
			lbStatus4.Location = new Point(6, 73);
			lbStatus4.Name = "lbStatus4";
			lbStatus4.Size = new Size(359, 14);
			lbStatus4.TabIndex = 3;
			lbStatus4.Text = "Not Connected";
			lbStatus4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(238, 31);
			label9.Name = "label9";
			label9.Size = new Size(33, 14);
			label9.TabIndex = 2;
			label9.Text = "Port";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(116, 31);
			label10.Name = "label10";
			label10.Size = new Size(82, 14);
			label10.TabIndex = 1;
			label10.Text = "IP Addresss";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(6, 31);
			label11.Name = "label11";
			label11.Size = new Size(83, 14);
			label11.TabIndex = 0;
			label11.Text = "Nama Mesin";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(btnBersihkan3);
			groupBox4.Controls.Add(lsvMessage3);
			groupBox4.Controls.Add(btnConnect3);
			groupBox4.Controls.Add(txtPort3);
			groupBox4.Controls.Add(txtIPAddress3);
			groupBox4.Controls.Add(txtNamaMesin3);
			groupBox4.Controls.Add(lbStatus3);
			groupBox4.Controls.Add(label13);
			groupBox4.Controls.Add(label14);
			groupBox4.Controls.Add(label15);
			groupBox4.Location = new Point(12, 314);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(400, 311);
			groupBox4.TabIndex = 2;
			groupBox4.TabStop = false;
			groupBox4.Text = "Mesin Absen 3";
			// 
			// btnBersihkan3
			// 
			btnBersihkan3.Location = new Point(295, 280);
			btnBersihkan3.Name = "btnBersihkan3";
			btnBersihkan3.Size = new Size(99, 25);
			btnBersihkan3.TabIndex = 10;
			btnBersihkan3.Text = "Bersihkan";
			btnBersihkan3.UseVisualStyleBackColor = true;
			// 
			// lsvMessage3
			// 
			lsvMessage3.FormattingEnabled = true;
			lsvMessage3.ItemHeight = 14;
			lsvMessage3.Location = new Point(6, 90);
			lsvMessage3.Name = "lsvMessage3";
			lsvMessage3.Size = new Size(388, 186);
			lsvMessage3.TabIndex = 8;
			// 
			// btnConnect3
			// 
			btnConnect3.Location = new Point(295, 31);
			btnConnect3.Name = "btnConnect3";
			btnConnect3.Size = new Size(99, 39);
			btnConnect3.TabIndex = 7;
			btnConnect3.Text = "Connect";
			btnConnect3.UseVisualStyleBackColor = true;
			btnConnect3.Click += btnConnect3_Click;
			// 
			// txtPort3
			// 
			txtPort3.Location = new Point(238, 48);
			txtPort3.Name = "txtPort3";
			txtPort3.Size = new Size(53, 22);
			txtPort3.TabIndex = 6;
			// 
			// txtIPAddress3
			// 
			txtIPAddress3.Location = new Point(116, 48);
			txtIPAddress3.Name = "txtIPAddress3";
			txtIPAddress3.Size = new Size(115, 22);
			txtIPAddress3.TabIndex = 5;
			// 
			// txtNamaMesin3
			// 
			txtNamaMesin3.Location = new Point(6, 48);
			txtNamaMesin3.Name = "txtNamaMesin3";
			txtNamaMesin3.Size = new Size(100, 22);
			txtNamaMesin3.TabIndex = 4;
			// 
			// lbStatus3
			// 
			lbStatus3.ForeColor = Color.Red;
			lbStatus3.Location = new Point(6, 73);
			lbStatus3.Name = "lbStatus3";
			lbStatus3.Size = new Size(359, 14);
			lbStatus3.TabIndex = 3;
			lbStatus3.Text = "Not Connected";
			lbStatus3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(238, 31);
			label13.Name = "label13";
			label13.Size = new Size(33, 14);
			label13.TabIndex = 2;
			label13.Text = "Port";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(116, 31);
			label14.Name = "label14";
			label14.Size = new Size(82, 14);
			label14.TabIndex = 1;
			label14.Text = "IP Addresss";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(6, 31);
			label15.Name = "label15";
			label15.Size = new Size(83, 14);
			label15.TabIndex = 0;
			label15.Text = "Nama Mesin";
			// 
			// FrmMesinAbsen
			// 
			AutoScaleDimensions = new SizeF(8F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(881, 637);
			Controls.Add(groupBox3);
			Controls.Add(groupBox4);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
			MaximizeBox = false;
			Name = "FrmMesinAbsen";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Aktivitas Mesin Absen";
			Load += FrmMesinAbsen_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox txtNamaMesin1;
		private Label lbStatus1;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox txtPort1;
		private TextBox txtIPAddress1;
		private ListBox lsvMessage1;
		private Button btnConnect1;
		private GroupBox groupBox2;
		private ListBox lsvMessage2;
		private Button btnConnect2;
		private TextBox txtPort2;
		private TextBox txtIPAddress2;
		private TextBox txtNamaMesin2;
		private Label lbStatus2;
		private Label label5;
		private Label label6;
		private Label label7;
		private GroupBox groupBox3;
		private ListBox lsvMessage4;
		private Button btnConnect4;
		private TextBox txtPort4;
		private TextBox txtIPAddress4;
		private TextBox txtNamaMesin4;
		private Label lbStatus4;
		private Label label9;
		private Label label10;
		private Label label11;
		private GroupBox groupBox4;
		private ListBox lsvMessage3;
		private Button btnConnect3;
		private TextBox txtPort3;
		private TextBox txtIPAddress3;
		private TextBox txtNamaMesin3;
		private Label lbStatus3;
		private Label label13;
		private Label label14;
		private Label label15;
		private Button btnBersihkan1;
		private Button btnBersihkan2;
		private Button btnBersihkan4;
		private Button btnBersihkan3;
	}
}