namespace KeyboardStatusTrayApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Aplicacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarIndicadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CapsLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.NumLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.ScrollLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Aplicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aplicacion
            // 
            this.Aplicacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarIndicadoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Aplicacion.Name = "Aplicación";
            this.Aplicacion.Size = new System.Drawing.Size(153, 70);
            this.Aplicacion.Opening += new System.ComponentModel.CancelEventHandler(this.Aplicacion_Opening);
            // 
            // mostrarIndicadoresToolStripMenuItem
            // 
            this.mostrarIndicadoresToolStripMenuItem.Name = "mostrarIndicadoresToolStripMenuItem";
            this.mostrarIndicadoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarIndicadoresToolStripMenuItem.Text = "Show balloons";
            this.mostrarIndicadoresToolStripMenuItem.Click += new System.EventHandler(this.mostrarIndicadoresToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Close";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "capsOFF.bmp");
            this.imageList1.Images.SetKeyName(1, "capsON.bmp");
            this.imageList1.Images.SetKeyName(2, "numOFF.bmp");
            this.imageList1.Images.SetKeyName(3, "numON.bmp");
            this.imageList1.Images.SetKeyName(4, "scrollOFF.bmp");
            this.imageList1.Images.SetKeyName(5, "scrollON.bmp");
            // 
            // CapsLock
            // 
            this.CapsLock.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CapsLock.ContextMenuStrip = this.Aplicacion;
            this.CapsLock.Text = "CAPS LOCK";
            this.CapsLock.DoubleClick += new System.EventHandler(this.CapsLock_DoubleClick);
            // 
            // NumLock
            // 
            this.NumLock.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NumLock.ContextMenuStrip = this.Aplicacion;
            this.NumLock.Text = "NUM LOCK";
            this.NumLock.DoubleClick += new System.EventHandler(this.NumLock_DoubleClick);
            // 
            // ScrollLock
            // 
            this.ScrollLock.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ScrollLock.ContextMenuStrip = this.Aplicacion;
            this.ScrollLock.Text = "SCROLL LOCK";
            this.ScrollLock.DoubleClick += new System.EventHandler(this.ScrollLock_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 65);
            this.Name = "Form1";
            this.Text = "Keyboard Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Aplicacion.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip Aplicacion;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.NotifyIcon CapsLock;
		private System.Windows.Forms.NotifyIcon NumLock;
		private System.Windows.Forms.NotifyIcon ScrollLock;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem mostrarIndicadoresToolStripMenuItem;
	}
}

