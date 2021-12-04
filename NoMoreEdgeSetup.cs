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
        //copy
        public static void installApp(string path,string edgepath,string newedge,string destFile,string engine )
        {
            Microsoft.Win32.RegistryKey bkey;
            bkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\Shell\\Associations\\UrlAssociations\\http\\UserChoice");
            string browser = bkey.GetValue("ProgId").ToString();
            bkey.Close();
            if (browser == "MSEdgeHTM" || browser == "MSEdgeBHTM" || browser == "MSEdgeDHTM")
            {
                MessageBox.Show("Your default browser is edge - I will only change search engine and add duckduckgo bangs.");
            }

            try
                {
                    using (var client = new WebClient())
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        client.DownloadFile("https://github.com/HarshalKudale/NoMoreEdge/releases/download/1.5.0.3/NoMoreEdge.exe", destFile);
                    }
                    File.Copy(edgepath, newedge, true);
                    File.Copy(edgepath.Replace("Edge","Edge Beta"), newedge.Replace("Edge", "Edge Beta"), true);
                    File.Copy(edgepath.Replace("Edge","Edge Dev"), newedge.Replace("Edge", "Edge Dev"), true);
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
            if (File.Exists(path) || Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe", true)!=null)
        {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (File.Exists(newedge))
                {
                    File.Delete(newedge);
                }
                Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
                MessageBox.Show("Uninstalled NoMoreEdge");
                if (File.Exists(newedge.Replace("Edge", "Edge Beta")))
                {
                    File.Delete(newedge.Replace("Edge", "Edge Beta"));
                }
                if (File.Exists(newedge.Replace("Edge", "Edge Dev")))
                {
                    File.Delete(newedge.Replace("Edge", "Edge Dev"));
                }

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