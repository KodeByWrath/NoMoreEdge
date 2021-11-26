using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;
/*
 * Copyright © 2017–2021 Harshal Kudale
 * SPDX-License-Identifier: MIT
 * License-Filename: LICENSE
 */

namespace NoMoreEdge
{
    static class NoMoreEdge
    {

        [STAThread]
        static string urlType(string url)
        {
            string urltype = "";
            if (url.Contains("Microsoft.Windows.Search") && url.Length > 116)
            {
                urltype = "searchword";
            }
            else if (url.Contains("Microsoft.Windows.Search") && url.Length < 116) 
            {
                urltype = "searchurl";
            }
            else if (url.Contains("Windows.Widgets"))
            {
                urltype = "widget";
            }
            else if (url.Length < 50)
            {
                urltype = "simple";
            }
            return urltype;
        }
        static string widgetsurl(string url)
        {

            url = url.Substring(url.IndexOf("https"), url.Length - url.IndexOf("https"));
            url = url.Replace("%3A", ":");
            url = url.Replace("%3D", "=");
            url = url.Replace("%2F", "/");
            url = url.Replace("%3", "?");
            Console.WriteLine(url);
            return url;
        }
        static string searchurl(string url)
        {
            Console.WriteLine(url);
            url = url.Substring(url.IndexOf("http"), url.Length - url.IndexOf("http"));
            url = url.Replace("%3A", ":");
            url = url.Replace("%3D", "=");
            url = url.Replace("%2F", "/");
            url = url.Replace("%3", "?");
            Console.WriteLine(url);
            return url;
        }
        static string simpleurl(string url)
        {
            int windex = url.IndexOf("www");
            url = url.Substring(windex, url.Length - windex);


            return url;
        }
        static string windwossearch(string url)
        {
            url = url.Substring(url.IndexOf("https"), url.Length - url.IndexOf("https"));
            url = url.Substring(42, url.IndexOf("%26") - 42);
            url = url.Replace("%2B", "+");
            url = "https://www.google.com/search?q=" + url;
            return url;

        }
        static void Main(string[] args)
        {
            //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=https%3A%2F%2Fwww.bing.com%2Fsearch%3Fq%3Dreddit%2Bwebsite%26filters%3Dufn%253a%2522Reddit%2522%2Bsid%253a%252220757754-e543-a49f-c338-3463e22655c3%2522%26form%3DWSBEDG%26qs%3DMB%26cvid%3Daafc035c9d924cd493477b7f4854107d%26pq%3Dreddit%26cc%3DIN%26setlang%3Den-US%26nclid%3DA7CDEE0718C7A2E6219EAA07F2209F3B%26ts%3D1637862572948%26nclidts%3D1637862572%26tsms%3D948%26wsso%3DModerate";
            //string url = "microsoft-edge://https://www.google.com";
            //string url = "microsoft-edge:?upn=abc%40gmail.com&cid=8208f3b1a83e496b&source=Windows.Widgets&timestamp=1637894205027&url=https%3A%2F%2Fwww.msn.com%2Fen-in%2Fmoney%2Fnews%2Fblack-friday-sale-here-are-the-top-deals-on-iphones-oneplus-and-other-phones-you-can-t-miss%2Far-AAR82bF%3Focid%3Dwinp2octtaskbar";
            //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=http%3A%2F%2Fwww.amazon.in%2F";
            //string url = "microsoft-edge:?upn=abc%40gmail.com&cid=8208f3b1a83e496b&source=Windows.Widgets&timestamp=1637941810457&url=https%3A%2F%2Fgo.microsoft.com%2Ffwlink%2F%3Flinkid%3D2163242";


            if (args.Length < 2)
            {
                var p = new Process();
                p.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge_solo.exe";
                p.Start();
            }
            else
            {
                string url = args[args.Length - 1];
                string urltype = urlType(url);
                switch (urltype)
                {
                    case "searchword":
                        url = windwossearch(url);
                        break;
                    case "widget":
                        url = widgetsurl(url);
                        break;
                    case "simple":
                        url = simpleurl(url);
                        break;
                    case "searchurl":
                        url = searchurl(url);
                        break;
                    default:
                        MessageBox.Show("Wrong URL");
                        break;
                }
                ProcessStartInfo launcher = new ProcessStartInfo(url)
                {
                    UseShellExecute = true
                };
                Process.Start(launcher);
            }

        }
    }
}
