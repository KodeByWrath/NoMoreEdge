using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoMoreEdgeSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        string path = @"C:\Program Files (x86)\Microsoft\Edge\Application\NoMoreEdge.exe";
        static string fileName = "NoMoreEdge.exe";
        static string edgeaName = "msedge.exe";
        static string targetPath = @"C:\PROGRA~2\Microsoft\Edge\Application";
        static string destFile = System.IO.Path.Combine(targetPath, fileName);
        static string edgepath = System.IO.Path.Combine(targetPath, edgeaName);
        static string newedge = System.IO.Path.Combine(targetPath, "msedge_backup.exe");
        static string engine = "google";
        private void btn_install_Click(object sender, EventArgs e)
        {
            NoMoreEdgeSetupForm.installApp(path,edgepath,newedge,destFile,engine);
        }

        public void btn_uninstall_Click(object sender, EventArgs e)
        {
            NoMoreEdgeSetupForm.uninstallApp(path,newedge);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            NoMoreEdgeSetupForm.exitSetup();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            NoMoreEdgeSetupForm.updateApp(path,engine);
        }

        private void google_CheckedChanged(object sender, EventArgs e)
        {
            engine = google.Name;
        }

        private void duckduckgo_CheckedChanged(object sender, EventArgs e)
        {
            engine = duckduckgo.Name;
        }

        private void ask_CheckedChanged(object sender, EventArgs e)
        {
            engine = ask.Name;
        }

        private void brave_CheckedChanged(object sender, EventArgs e)
        {
            engine = brave.Name;
        }

        private void ecosia_CheckedChanged(object sender, EventArgs e)
        {
            engine = ecosia.Name;
        }

        private void yahoo_CheckedChanged(object sender, EventArgs e)
        {
            engine = yahoo.Name;
        }

        private void sogou_CheckedChanged(object sender, EventArgs e)
        {
            engine = sogou.Name;
        }

        private void yandex_CheckedChanged(object sender, EventArgs e)
        {
            engine = yandex.Name;
        }

        private void btn_github_Click(object sender, EventArgs e)
        {
            ProcessStartInfo launcher = new ProcessStartInfo("https://github.com/HarshalKudale/NoMoreEdge")
            {
                UseShellExecute = true
            };
            Process.Start(launcher);
        }

    }
}
