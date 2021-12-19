using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;
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
        public static void RunProcess(string filename, string arguments)
        {
            Process p = new Process
            {
                StartInfo = { UseShellExecute = true, FileName = filename, Arguments = arguments, WindowStyle = ProcessWindowStyle.Hidden }
            };
            p.Start();
        }
        public static void IfeoRegistryRemove()
        {
            Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
        }
        public static void IfeoRegistryAdd(string settings) 
        {
            RegistryKey rkey;
            string IfeoPath = "C:\\Program Files (x86)\\Microsoft\\NoMoreEdge\\NoMoreEdge.exe " + settings;
            rkey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe");
            rkey.SetValue("UseFilter", 1, RegistryValueKind.DWord);
            rkey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe\\0");
            rkey.SetValue("Debugger", IfeoPath);
            rkey.SetValue("FilterFullPath", @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
            rkey.Close();
        }
        
        public static void installApp(string targetPath,string settings)
        {
            IfeoRegistryAdd(settings);
            string filename = "cmd.exe";
            string arguments = "/c mklink " + @"/J " + "\"" + @"C:\Program Files (x86)\Microsoft\NoMoreEdge\Edge" + "\" " + "\"" + @"C:\Program Files (x86)\Microsoft\Edge\Application" + "\"";
            try
                {
                    Directory.CreateDirectory(targetPath);
                    using (var client = new WebClient())
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        client.DownloadFile("https://github.com/HarshalKudale/NoMoreEdge/releases/download/1.7.1.0/NoMoreEdge.exe", Path.Combine(targetPath, "NoMoreEdge.exe"));
                    }               
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
                Console.WriteLine(iox.Message);
            }
            
            RunProcess(filename, arguments);
            MessageBox.Show("Installed NoMoreEdge - https://github.com/HarshalKudale/NoMoreEdge");

        }
        public static void updateApp(string targetPath,string engine) 
        {
            if (Directory.Exists(targetPath))
            {
                try
                {
                    IfeoRegistryRemove();
                    IfeoRegistryAdd(engine);
                    MessageBox.Show("Setting Updated");
                }
                catch(Exception ex)
                {
                    throw new ArgumentException("NoMoreEdge not found" + ex);
                }
            }
            else
            {
                MessageBox.Show("NoMoreEdge is not installed");
            }
            
        }
        public static void uninstallApp(string targetPath) 
        {
            if (Directory.Exists(targetPath))
            {
                try
                {
                    Directory.Delete(targetPath, true);
                }
                catch (IOException)
                {
                    Directory.Delete(targetPath, true);
                }
            }
            if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msedge.exe", true) != null)
            {
                IfeoRegistryRemove();
                MessageBox.Show("NoMoreEdge is Uninstalled");
            }
            else
                MessageBox.Show("NoMoreEdge is not installed");
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}