using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _9project1
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public string startUrl;
        public Action<string> PageDownloaded;
        public string StartUrl
        {
            set
            {
                startUrl = value;
                urls.Add(value, false);
            }
            get
            {
                return startUrl;
            }
        }
        public void Crawl()
        {

            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                        continue;
                    current = url;
                }

                if (current == null || count > 10)
                    break;
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                PageDownloaded(url);
                return html;
            }
            catch (Exception ex)
            {
                PageDownloaded(url + "      Error: " + ex.Message);
                return "";
            }
        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0)
                    continue;
                if (strRef.Contains(".html") && strRef.Contains(StartUrl))
                {
                    strRef = ToURL(strRef);
                    if (urls[strRef] == null)
                        urls[strRef] = false;
                }
            }
        }
        public string ToURL(string relativePath)
        {
            string absolutePath = "";
            if (relativePath.Contains("http"))
            {
                absolutePath = relativePath;
            }               
            else
            {
                Uri uri = new Uri(relativePath);
                absolutePath = uri.AbsoluteUri;
            }
            return absolutePath;
        }
    }
}
