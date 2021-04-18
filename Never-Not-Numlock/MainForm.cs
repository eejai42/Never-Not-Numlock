using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private const int C_MS = 1;
        private const int C_SECOND = 1000 * C_MS;
        private const string C_KEYNAME = "NeverNotNumlock";

        public bool IsClosed { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                this.MonitorNumlock();
            });
        }

        private void MonitorNumlock()
        {
            while (!this.IsClosed)
            {
                this.UpdateState();
                Thread.Sleep(250 * C_MS);
            }
        }

        private void UpdateState()
        {
            if (this.InvokeRequired) this.Invoke(new Action(this.UpdateState));
            else
            {
                if (Console.NumberLock) _numlockStatusLabel.Text = "I mean... why is it even a button?";
                else
                {
                    _numlockStatusLabel.Text = "WAIT - WHY IS THE NUMLOCK OFF???";
                    this.ShowNeverNotNumlock();
                }
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            NeverNotNumlock.WinApp.Properties.Settings.Default.Save();
            this.IsClosed = true;
            base.OnClosed(e);
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.ShowInTaskbar = this.WindowState != FormWindowState.Minimized;
            this.notifyIcon1.Visible = !this.ShowInTaskbar;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowNeverNotNumlock();
        }

        private void ShowNeverNotNumlock()
        {
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void _hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _runAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey(
                                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (_runAtStartup.Checked)
            {
                //Path to launch shortcut
                string startPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs)
                                   + @"\EffortlessAPI\Windows Tools\Never Not Numlock.appref-ms";

                rkApp.SetValue(C_KEYNAME, startPath);
            }
            else
            {
                rkApp.DeleteValue(C_KEYNAME);
            }
        }
    }
}
