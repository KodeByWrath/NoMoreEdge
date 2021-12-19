using System;
using System.Diagnostics;

/*
* Copyright ©2021 Harshal Kudale
* SPDX-License-Identifier: MIT
* License-Filename: LICENSE
*/

namespace NoMoreEdge
{
    static class NoMoreEdge
    {
        public static void RunProcess(string filename, string arguments,bool shell, bool re_output)
        {
            Process p = new Process
            {
                StartInfo = { UseShellExecute = shell, RedirectStandardOutput = re_output, FileName = filename, Arguments = arguments}
            };
            p.Start();
        }
        static string DotSlash(string url)
        {
            url = url.Replace("%3A", ":");
            url = url.Replace("%2F", "/");
            return url;
        }
        [STAThread]
        static string defEngine(string engine)
        {
            string engineurl = "";
            switch (engine)
            {
                case "Google":
                    engineurl = "https://www.google.com/search?q=";
                    break;
                case "Duckduckgo":
                    engineurl = "https://duckduckgo.com/?q=";
                    break;
                case "Ecosia":
                    engineurl = "https://www.ecosia.org/search?q=";
                    break;
                case "Sogou":
                    engineurl = "https://www.sogou.com/web?query=";
                    break;
                case "Yahoo":
                    engineurl = "https://search.yahoo.com/search?p=";
                    break;
                case "Yandex":
                    engineurl = "https://yandex.com/search/?text=";
                    break;
                case "Ask":
                    engineurl = "https://www.ask.com/web?q=";
                    break;
                case "Brave":
                    engineurl = "https://search.brave.com/search?q=";
                    break;
                case "Bing":
                    engineurl = "https://www.bing.com/search?q=";
                    break;
                default:
                    engineurl = engine;
                    break;
            }
            return engineurl;
        }
        private static string DecodeUrlString(string url)
        {
            string newUrl;
            while ((newUrl = Uri.UnescapeDataString(url)) != url)
                url = newUrl;
            return newUrl;
        }
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                string[] settings = args[0].Split('-');
                //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=https%3A%2F%2Fwww.bing.com%2Fsearch%3Fq%3D%2521reddit%2Bwebsite%26filters%3Dufn%253a%2522Reddit%2522%2Bsid%253a%252220757754-e543-a49f-c338-3463e22655c3%2522%26form%3DWSBEDG%26qs%3DMB%26cvid%3Daafc035c9d924cd493477b7f4854107d%26pq%3Dreddit%26cc%3DIN%26setlang%3Den-US%26nclid%3DA7CDEE0718C7A2E6219EAA07F2209F3B%26ts%3D1637862572948%26nclidts%3D1637862572%26tsms%3D948%26wsso%3DModerate";
                //string url = "microsoft-edge://https://www.google.com";
                //string url = "microsoft-edge:?upn=abc%40gmail.com&cid=8208f3b1a83e496b&source=Windows.Widgets&timestamp=1637894205027&url=https%3A%2F%2Fwww.msn.com%2Fen-in%2Fmoney%2Fnews%2Fblack-friday-sale-here-are-the-top-deals-on-iphones-oneplus-and-other-phones-you-can-t-miss%2Far-AAR82bF%3Focid%3Dwinp2octtaskbar";
                //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=http%3A%2F%2Fwww.amazon.in%2F";
                //string url = "microsoft-edge:?launchContext1=Microsoft.Windows.Search_cw5n1h2txyewy&url=https%3A%2F%2Fwww.bing.com%2FWS%2Fredirect%2F%3Fq%3Damazon.in%26url%3DaHR0cHM6Ly93d3cuYW1hem9uLmluL2luZGlhL3M%2Faz1pbmRpYQ%3D%3D%26form%3DWSBSTK%26cvid%3D862ffe62e8aa4be1b7b103c5ac4d5d08%26rtk%3DRShhlsdPnBoyLzMkHlFi3uiMwVjRyHBlh%252FV1sy1YmaiOwrtpcAVI%252FIXH0ospojDn";
                //string url = "microsoft-edge:https://www.bing.com/images/search?q=walker+bay+south+africa+whales&filters=IsConversation:%22True%22+BTWLKey:%22WalkerBaySouthAfrica%22+BTWLType:%22Trivia%22&trivia=1&qft=+filterui:photo-photo&FORM=EMSDS0";
                //string url = "microsoft-edge:?upn=harshalkudale56ms%40outlook.com&cid=8208f3b1a83e496b&source=Windows.Widgets&timestamp=1638555634754&url=https%3A%2F%2Fwww.bing.com%2Fsearch%3Fform%3DU627SB%26pc%3DU627%26cc%3DIN%26setLang%3Den-US%26q%3D%2521youtube%2Bsong";


                if (args.Length > 1 && args[args.Length - 1].Contains("microsoft-edge"))
                {
                    string url = args[args.Length - 1];
                    string engine = "Google";

                    if (args.Length == 4 && settings[0].Length > 2)
                    {
                        engine = settings[0];
                    }

                    url = url.Substring(url.IndexOf("http"), url.Length - url.IndexOf("http"));

                    if (url.Contains("https%3A%2F%2Fwww.bing.com%2Fsearch%3Fq%3D") && !url.Contains("redirect"))
                        url = url.Substring(url.IndexOf("http"), url.IndexOf("%26"));

                    if (url.Contains("https%3A%2F%2Fwww.bing.com%2Fsearch%3Fform%3D"))
                    {
                        url = url.Substring(url.IndexOf("26q%3D") + 6, url.Length - (url.IndexOf("26q%3D") + 6));
                        url = "https://www.bing.com/search?q=" + url;
                    }

                    if (url.Contains("%2521") && settings[2].Equals("true"))
                    {
                        engine = "Duckduckgo";
                    }

                    if (url.Contains("redirect"))
                    {
                        url = DotSlash(url);
                    }
                    else
                    {
                        url = DecodeUrlString(url);
                    }

                    url = url.Replace("https://www.bing.com/search?q=", defEngine(engine));

                    Uri uri = new(url.ToString());
                    RunProcess(uri.ToString(), "", true, false);
                }
                else if (settings[1] == "true")
                {
                    string edgepath = "\"C:\\Program Files (x86)\\Microsoft\\NoMoreEdge\\Edge\\msedge.exe\"";
                    string argument = "";
                    for (int i = 2; i < args.Length; i++)
                    {
                        argument = argument + args[i] + " ";
                    }

                    RunProcess(edgepath, argument, false, true);

                }
            }
        }
    }
}
