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
        static string urlmod(string url)
        {
            url = url.Replace("%3A", ":");
            url = url.Replace("%3D", "=");
            url = url.Replace("%2F", "/");
            url = url.Replace("%3F", "?");
            url = url.Replace("%25", "%");
            url = url.Replace("%26", "&");

            return url;
        }

        static UrlType urlType(string url)
        {
            if (url.Contains("Microsoft.Windows.Search") && !url.Contains("redirect") && url.Contains("bing"))
            {
                return UrlType.SearchWord;
            }

            if (url.Contains("Microsoft.Windows.Search"))
            {
                return UrlType.SearchUrl;
            }

            if (url.Contains("Windows.Widgets"))
            {
                return UrlType.Widget;
            }

            if (url.StartsWith("microsoft-edge:https") || url.StartsWith("microsoft-edge://https"))
            {
                return UrlType.Simple;
            }

            return UrlType.Unknown;
        }

        static string widgetsurl(string url)
        {
            url = url.Substring(url.IndexOf("https"), url.Length - url.IndexOf("https"));
            url = urlmod(url);
            Console.WriteLine(url);

            return url;
        }

        static string searchurl(string url)
        {
            Console.WriteLine(url);
            url = url.Substring(url.IndexOf("http"), url.Length - url.IndexOf("http"));
            url = urlmod(url);
            Console.WriteLine(url);

            return url;
        }

        static string simpleurl(string url)
        {
            int windex = url.IndexOf("https");
            url = url.Substring(windex, url.Length - windex);

            return url;
        }

        static string defEngine(string url, string engine)
        {
            switch (engine)
            {
                case "google":
                    url = "https://www.google.com/search?q=" + url;
                    break;
                case "duckduckgo":
                    url = "https://duckduckgo.com/?q=" + url;
                    break;
                case "baidu":
                    url = "https://www.baidu.com/s?wd=" + url;
                    break;
                case "ecosia":
                    url = "https://www.ecosia.org/search?q=" + url;
                    break;
                case "sogou":
                    url = "https://www.sogou.com/web?query=" + url;
                    break;
                case "yahoo":
                    url = "https://search.yahoo.com/search?p=" + url;
                    break;
                case "yandex":
                    url = "https://yandex.com/search/?text=" + url;
                    break;
                case "ask":
                    url = "https://www.ask.com/web?q=" + url;
                    break;
                default:
                    MessageBox.Show("wrong engine");
                    break;
            }

            return url;
        }

        static string windwossearch(string url, string engine)
        {
            url = url.Substring(url.IndexOf("https"), url.Length - url.IndexOf("https"));
            url = url.Substring(42, url.IndexOf("%26") - 42);
            url = url.Replace("%2B", "+");

            return defEngine(url, engine);
        }

        static void Main(string[] args)
        {
            //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=https%3A%2F%2Fwww.bing.com%2Fsearch%3Fq%3Dreddit%2Bwebsite%26filters%3Dufn%253a%2522Reddit%2522%2Bsid%253a%252220757754-e543-a49f-c338-3463e22655c3%2522%26form%3DWSBEDG%26qs%3DMB%26cvid%3Daafc035c9d924cd493477b7f4854107d%26pq%3Dreddit%26cc%3DIN%26setlang%3Den-US%26nclid%3DA7CDEE0718C7A2E6219EAA07F2209F3B%26ts%3D1637862572948%26nclidts%3D1637862572%26tsms%3D948%26wsso%3DModerate";
            //string url = "microsoft-edge://https://www.google.com";
            //string url = "microsoft-edge:?upn=abc%40gmail.com&cid=8208f3b1a83e496b&source=Windows.Widgets&timestamp=1637894205027&url=https%3A%2F%2Fwww.msn.com%2Fen-in%2Fmoney%2Fnews%2Fblack-friday-sale-here-are-the-top-deals-on-iphones-oneplus-and-other-phones-you-can-t-miss%2Far-AAR82bF%3Focid%3Dwinp2octtaskbar";
            //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=http%3A%2F%2Fwww.amazon.in%2F";
            //string url   = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=https%3A%2F%2Fwww.bing.com%2FWS%2Fredirect%2F%3Fq%3Damazon.in%26url%3DaHR0cHM6Ly93d3cuYW1hem9uLmluL2luZGlhL3M%2Faz1pbmRpYQ%3D%3D%26form%3DWSBSTK%26cvid%3D7d3f9448e5de4260b68819b9887a9558%26rtk%3DSpSsrrKyXsxfoGahqv98I%252Fi3xOUBG9SnOILgundIYa8%252F1q%252Ffzsod5efeoSd94FDq";
            //string url = "microsoft-edge:https://www.bing.com/images/search?q=walker+bay+south+africa+whales&filters=IsConversation:%22True%22+BTWLKey:%22WalkerBaySouthAfrica%22+BTWLType:%22Trivia%22&trivia=1&qft=+filterui:photo-photo&FORM=EMSDS0";

            if (args.Length < 3)
            {
                var p = new Process();
                p.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge_solo.exe";
                p.Start();
            }
            else
            {
                string url = args[args.Length - 1];
                string engine = "google";
                if (args.Length == 4)
                {
                    engine = args[0];
                }

                var urlType = urlType(url);
                switch (urltype)
                {
                    case UrlType.SearchWord:
                        url = windwossearch(url, engine);
                        break;
                    case UrlType.Widget:
                        url = widgetsurl(url);
                        break;
                    case UrlType.Simple:
                        url = simpleurl(url);
                        break;
                    case UrlType.SearchUrl:
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
