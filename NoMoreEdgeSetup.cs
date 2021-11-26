using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
/*
 * Copyright © 2017–2021 Harshal Kudale
 * SPDX-License-Identifier: MIT
 * License-Filename: LICENSE
 */


namespace NoMoreEdgeSetup
{
    static class NoMoreEdgeSetup
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = @"C:\Program Files (x86)\Microsoft\Edge\Application\NoMoreEdge.exe";
            string fileName = "NoMoreEdge.exe";
            string edgeaName = "msedge.exe";
            string targetPath = @"C:\PROGRA~2\Microsoft\Edge\Application";
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            string edgepath = System.IO.Path.Combine(targetPath, edgeaName);
            string newedge = System.IO.Path.Combine(targetPath, "msedge_solo.exe");
            if (!File.Exists(path))
            {


                try
                {
                    using (var client = new WebClient())
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        client.DownloadFile("https://github.com/HarshalKudale/NoMoreEdge/raw/master/Executables/NoMoreEdge.exe", destFile);
                    }
                    File.Copy(edgepath,newedge,true);

                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }

                Microsoft.Win32.RegistryKey rkey;
                rkey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
                rkey.SetValue("Debugger", "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\NoMoreEdge.exe");
                rkey.Close();
                MessageBox.Show("Installed NoMoreEdge");
                ProcessStartInfo launcher = new ProcessStartInfo("https://github.com/HarshalKudale/NoMoreEdge")
                {
                    UseShellExecute = true
                };
                Process.Start(launcher);
            }
            else 
            {
                File.Delete(path);
                File.Delete(newedge);
                Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
                MessageBox.Show("Uninstalled NoMoreEdge");
            }


        }
    }

}
