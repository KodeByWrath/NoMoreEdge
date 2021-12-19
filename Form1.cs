using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NoMoreEdgeSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
        }
        public void UpdateStatus()
        {
            groupBox3.Enabled = false;
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe\\0", true);
            if (!Directory.Exists(targetPath) && Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe", true) == null)
            {
                Eng_btn.Visible = false;
                btn_install.Visible = true;
                btn_uninstall.Visible = false;
                EngineList.Text = "Google";
            }
            if (Directory.Exists(targetPath) && key != null)
            {
                Eng_btn.Visible = true;

                btn_install.Visible = false;
                btn_uninstall.Visible = true;
                string temp = key.GetValue("Debugger").ToString();
                temp = temp.Substring(59, temp.Length - 59);
                settings = temp.Split('-');
                if (settings[0].Length < 13)
                {
                    EngineList.Text = settings[0];
                    predefined.Checked = true;
                }
                else
                {
                    custom_engine.Text = settings[0];
                    custom.Checked = true;
                }
                if (settings[1] == "true")
                {
                    Edge_box.Checked = true;
                }
                if (settings[2] == "true")
                {
                    Bang_box.Checked = true;
                }
                
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        static string targetPath = @"C:\Program Files (x86)\Microsoft\NoMoreEdge";
        static string[] settings = {"Google","false","false" };
        string setting;
        
        private void btn_install_Click(object sender, EventArgs e)
        {
            getSettings();
            NoMoreEdgeSetupForm.installApp(targetPath,setting);
            UpdateStatus();
        }

        public void btn_uninstall_Click(object sender, EventArgs e)
        {
            NoMoreEdgeSetupForm.uninstallApp(targetPath);
            UpdateStatus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            NoMoreEdgeSetupForm.updateApp(targetPath,setting);
            UpdateStatus();
        }

        private void btn_github_Click(object sender, EventArgs e)
        {
            ProcessStartInfo launcher = new ProcessStartInfo("https://github.com/HarshalKudale/NoMoreEdge")
            {
                UseShellExecute = true
            };
            Process.Start(launcher);
        }
        private void Eng_btn_Click(object sender, EventArgs e)
        {
            getSettings();
            NoMoreEdgeSetupForm.updateApp(targetPath, setting);
        }

        private void EngineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings[0] = EngineList.Text;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getSettings() 
        {
            setting = "";
            for (int i = 0; i < 3; i++)
            {
                setting = setting + settings[i] + "-";
            }
        }

        private void Edge_box_CheckedChanged(object sender, EventArgs e)
        {
            if (Edge_box.Checked)
                settings[1] = "true";
            else
                settings[1] = "false";
        }

        private void Bang_box_CheckedChanged(object sender, EventArgs e)
        {
            if (Bang_box.Checked)
                settings[2] = "true";
            else
                settings[2] = "false";
        }


        private void predefined_CheckedChanged(object sender, EventArgs e)
        {
            if (predefined.Checked)
            { 
                settings[0] = EngineList.Text;
                custom_engine.Text = "";
                custom_engine.Enabled = false;
                EngineList.Enabled = true;
            }

        }

        private void custom_CheckedChanged(object sender, EventArgs e)
        {
            if (custom.Checked)
            {
                settings[0] = custom_engine.Text;
                EngineList.Text = "";
                EngineList.Enabled = false;
                custom_engine.Enabled = true;
            }
        }

        private void custom_engine_TextChanged(object sender, EventArgs e)
        {
            settings[0] = custom_engine.Text;
        }
    }
}
