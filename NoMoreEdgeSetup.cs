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
    static class NoMoreEdgeSetupForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>        
        [STAThread]

        public static void installApp(string path,string edgepath,string newedge,string destFile,string engine ) 
        {

                try
                {
                    using (var client = new WebClient())
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        client.DownloadFile("https://github.com/HarshalKudale/NoMoreEdge/releases/download/1.0.1.0/NoMoreEdge.exe", destFile);
                    }
                    File.Copy(edgepath, newedge, true);

                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                    Console.WriteLine(iox.Message);
                }

                Microsoft.Win32.RegistryKey rkey;
                string apppath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\NoMoreEdge.exe " + engine;
                rkey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
                rkey.SetValue("Debugger", apppath);
                rkey.Close();
                MessageBox.Show("Installed NoMoreEdge - https://github.com/HarshalKudale/NoMoreEdge");
        }
        public static void updateApp(string path,string engine) 
        {
            if (File.Exists(path))
            {
                try
                {
                    Microsoft.Win32.RegistryKey rkey;
                    string apppath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\NoMoreEdge.exe " + engine;
                    rkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe",true);
                    rkey.SetValue("Debugger", apppath);
                    rkey.Close();
                    MessageBox.Show("Search Engine updated");
                }
                catch(Exception ex)
                {
                    throw new ArgumentException("Could not find registry key: " + ex);
                }
            }
            else
            {
                MessageBox.Show("NoMoreEdge is not installed");
            }
            
        }
        public static void exitSetup() 
        {
            Application.Exit();
        }
        public static void uninstallApp(string path, string newedge) 
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                File.Delete(newedge);
                Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
                MessageBox.Show("Uninstalled NoMoreEdge");
            }
            else 
            {
                MessageBox.Show("NoMoreEdge is not installed");
            }

        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }

}