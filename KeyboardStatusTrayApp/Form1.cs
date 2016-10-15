using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Gma.UserActivityMonitor;


namespace KeyboardStatusTrayApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int OFF = 0;
		int ON = 1;

		int capsIcon = 0;
		int numIcon = 2;
		int scrollIcon = 4;

		int caps;
		int num;
		int scroll;

		bool changed;

		private int UpdateKey(Keys keyVal, NotifyIcon icono, int baseIcon, int previous, string nombre)
		{
			string valor;
			int result;
			if (Control.IsKeyLocked(keyVal))
			{
				valor = "ON";
				result = baseIcon + ON;
			}
			else 
			{
				valor = "OFF";
				result = baseIcon + OFF;
			}

			icono.Text = string.Format("{0} is {1}", nombre, valor);
			icono.Icon = Icon.FromHandle(((Bitmap)imageList1.Images[result]).GetHicon());
			if ((icono.Visible) && (result != previous))
			{
				changed = true;
			}
			icono.Visible = true;

			return result;
		}

		private bool _showBalloon;
		public bool ShowBalloon
		{ 
			get
			{
				return _showBalloon;
			}
			set
			{
				_showBalloon = value;

				Properties.Settings.Default.ShowBalloons = value;
				Properties.Settings.Default.Save();

				mostrarIndicadoresToolStripMenuItem.Checked = value;
			}
		}
		private void mostrarIndicadoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowBalloon = !ShowBalloon;
		}

		private void UpdateStatus()
		{
			try
			{
				changed = false;
				
				scroll = UpdateKey(Keys.Scroll, ScrollLock, scrollIcon, scroll, "SCROLL LOCK");
				caps = UpdateKey(Keys.CapsLock, CapsLock, capsIcon, caps, "CAPS LOCK");
				num = UpdateKey(Keys.NumLock, NumLock, numIcon, num, "NUM LOCK");

				if (changed)
				{
					if (ShowBalloon)
					{
						string textoMensaje = NumLock.Text + "\n" + CapsLock.Text + "\n" + ScrollLock.Text;
						NumLock.ShowBalloonTip(100, "Keyboard Status", textoMensaje, ToolTipIcon.None);
					}
				}
			}
			catch
			{
			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NumLock.Visible = false;
			ScrollLock.Visible = false;
			CapsLock.Visible = false;
			
			this.Close();

			Application.Exit();
		}

		public void GO()
		{
			ShowBalloon = Properties.Settings.Default.ShowBalloons;

			this.Visible = false;
			UpdateStatus();

			HookManager.KeyUp += HookManager_KeyUp;
			//HookManager.KeyDown += HookManager_KeyDown;
		}

		private void HookManager_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Capital:
				case Keys.NumLock:
				case Keys.Scroll:
					timer1.Enabled = true;
					break;
			}
		}

		/*
		private void HookManager_KeyDown(object sender, KeyEventArgs e)
		{
		}
		*/

		private void Form1_Load(object sender, EventArgs e)
		{
			GO();
		}

		private const int KEYEVENTF_EXTENDEDKEY = 0x1;
		private const int KEYEVENTF_KEYUP = 0x2;
		//Declaracion Api 
		[DllImport("user32")]
		private static extern void keybd_event(Keys bVk, int bScan, int dwFlags, int dwExtraInfo);

		private void PushKey(Keys keyVal)
		{
			keybd_event(keyVal, 0x45, KEYEVENTF_EXTENDEDKEY | 0, 0);
			keybd_event(keyVal, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
		}

		private void NumLock_DoubleClick(object sender, EventArgs e)
		{
			PushKey(Keys.NumLock);
		}

		private void CapsLock_DoubleClick(object sender, EventArgs e)
		{
			PushKey(Keys.CapsLock);
		}

		private void ScrollLock_DoubleClick(object sender, EventArgs e)
		{
			PushKey(Keys.Scroll);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			UpdateStatus();
		}

        private void Aplicacion_Opening(object sender, CancelEventArgs e)
        {

        }
	}
}