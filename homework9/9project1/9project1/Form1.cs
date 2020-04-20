using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _9project1
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            crawler.StartUrl = textBoxAdd.Text;
            listBox.Items.Clear();
            new Thread(crawler.Crawl).Start();
        }
        private void Crawler_PageDownloaded(string url)
        {
            if (listBox.InvokeRequired)
            {
                Action<string> action = AddUrl;
                Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }

        private void AddUrl(string url)
        {
            listBox.Items.Add(url);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }                       
}
   

