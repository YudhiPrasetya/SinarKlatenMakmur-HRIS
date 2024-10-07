namespace HRIS.AktivitasAbsensi {
	partial class frmDashboard {
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
         this.components = new System.ComponentModel.Container();
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.listMesinAbsen = new System.Windows.Forms.ListView();
         this.clmNamaMesin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.clmNoMesin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.clmIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.clmPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.koneksikanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.putuskanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.downloadLogKehadiranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStrip2 = new System.Windows.Forms.ToolStrip();
         this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
         this.button1 = new System.Windows.Forms.Button();
         this.panel2.SuspendLayout();
         this.contextMenuStrip1.SuspendLayout();
         this.toolStrip2.SuspendLayout();
         this.SuspendLayout();
         // 
         // imageList1
         // 
         this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
         this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         // 
         // panel1
         // 
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(80, 40);
         this.panel1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.panel2.Controls.Add(this.listMesinAbsen);
         this.panel2.Controls.Add(this.toolStrip2);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(581, 150);
         this.panel2.TabIndex = 1;
         // 
         // listMesinAbsen
         // 
         this.listMesinAbsen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNamaMesin,
            this.clmNoMesin,
            this.clmStatus,
            this.clmIPAddress,
            this.clmPort});
         this.listMesinAbsen.ContextMenuStrip = this.contextMenuStrip1;
         this.listMesinAbsen.Dock = System.Windows.Forms.DockStyle.Top;
         this.listMesinAbsen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.listMesinAbsen.FullRowSelect = true;
         this.listMesinAbsen.GridLines = true;
         this.listMesinAbsen.HideSelection = false;
         this.listMesinAbsen.Location = new System.Drawing.Point(0, 25);
         this.listMesinAbsen.Name = "listMesinAbsen";
         this.listMesinAbsen.Size = new System.Drawing.Size(581, 125);
         this.listMesinAbsen.TabIndex = 1;
         this.listMesinAbsen.UseCompatibleStateImageBehavior = false;
         this.listMesinAbsen.View = System.Windows.Forms.View.Details;
         this.listMesinAbsen.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listMesinAbsen_ItemSelectionChanged);
         this.listMesinAbsen.SelectedIndexChanged += new System.EventHandler(this.listMesinAbsen_SelectedIndexChanged);
         this.listMesinAbsen.Click += new System.EventHandler(this.listMesinAbsen_Click);
         this.listMesinAbsen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listMesinAbsen_MouseClick);
         // 
         // clmNamaMesin
         // 
         this.clmNamaMesin.Text = "Nama Mesin";
         this.clmNamaMesin.Width = 200;
         // 
         // clmNoMesin
         // 
         this.clmNoMesin.Text = "No.Mesin";
         this.clmNoMesin.Width = 75;
         // 
         // clmStatus
         // 
         this.clmStatus.Text = "Status";
         this.clmStatus.Width = 100;
         // 
         // clmIPAddress
         // 
         this.clmIPAddress.Text = "Alamat IP";
         this.clmIPAddress.Width = 125;
         // 
         // clmPort
         // 
         this.clmPort.Text = "Port";
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koneksikanToolStripMenuItem,
            this.putuskanToolStripMenuItem,
            this.toolStripSeparator2,
            this.downloadLogKehadiranToolStripMenuItem});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(208, 76);
         this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
         // 
         // koneksikanToolStripMenuItem
         // 
         this.koneksikanToolStripMenuItem.Enabled = false;
         this.koneksikanToolStripMenuItem.Name = "koneksikanToolStripMenuItem";
         this.koneksikanToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
         this.koneksikanToolStripMenuItem.Text = "Koneksikan";
         this.koneksikanToolStripMenuItem.Click += new System.EventHandler(this.koneksikanToolStripMenuItem_Click);
         // 
         // putuskanToolStripMenuItem
         // 
         this.putuskanToolStripMenuItem.Enabled = false;
         this.putuskanToolStripMenuItem.Name = "putuskanToolStripMenuItem";
         this.putuskanToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
         this.putuskanToolStripMenuItem.Text = "Putuskan";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
         // 
         // downloadLogKehadiranToolStripMenuItem
         // 
         this.downloadLogKehadiranToolStripMenuItem.Enabled = false;
         this.downloadLogKehadiranToolStripMenuItem.Name = "downloadLogKehadiranToolStripMenuItem";
         this.downloadLogKehadiranToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
         this.downloadLogKehadiranToolStripMenuItem.Text = "Download Log Kehadiran";
         this.downloadLogKehadiranToolStripMenuItem.Click += new System.EventHandler(this.downloadLogKehadiranToolStripMenuItem_Click);
         // 
         // toolStrip2
         // 
         this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
         this.toolStrip2.Location = new System.Drawing.Point(0, 0);
         this.toolStrip2.Name = "toolStrip2";
         this.toolStrip2.Size = new System.Drawing.Size(581, 25);
         this.toolStrip2.TabIndex = 0;
         this.toolStrip2.Text = "toolStrip2";
         // 
         // toolStripLabel1
         // 
         this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.toolStripLabel1.Name = "toolStripLabel1";
         this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
         this.toolStripLabel1.Text = "Data Mesin";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(12, 171);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(94, 23);
         this.button1.TabIndex = 2;
         this.button1.Text = "Tes RealTime";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Visible = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // frmDashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(581, 391);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.panel2);
         this.Name = "frmDashboard";
         this.Text = ".:Dashboard:.";
         this.Load += new System.EventHandler(this.frmDashboard_Load);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.contextMenuStrip1.ResumeLayout(false);
         this.toolStrip2.ResumeLayout(false);
         this.toolStrip2.PerformLayout();
         this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem downloadLogKehadiranToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem koneksikanToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem putuskanToolStripMenuItem;
      private System.Windows.Forms.ListView listMesinAbsen;
      private System.Windows.Forms.ColumnHeader clmNamaMesin;
      private System.Windows.Forms.ColumnHeader clmNoMesin;
      private System.Windows.Forms.ColumnHeader clmStatus;
      private System.Windows.Forms.ColumnHeader clmIPAddress;
      private System.Windows.Forms.ColumnHeader clmPort;
      private System.Windows.Forms.Button button1;
   }
}