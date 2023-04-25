using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TkDownload
{
    public partial class Form1 : Form
    {
        string[] urls = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string u = this.urlTextBox.Text;
            if(u == null || u.Length == 0 || u.Trim().Length == 0)
            {
                return;
            }
            urls = u.Split("\n");
            this.logBox.Text += urls.Length;
            foreach (string url in urls)
            {
                this.logBox.Text += url + "\n";
            }
            request();

        }
        private void request()
        {
                    var webRequest = (System.Net.HttpWebRequest)WebRequest.CreateHttp("http://www.deeprd.com");
                    var response = webRequest.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
             StreamReader reader = new StreamReader(dataStream);

             string responseFromServer = reader.ReadToEnd();

             reader.Close(); response.Dispose();
                    //this.logBox.Text += i + "\n";
                    MessageBox.Show(responseFromServer);
                    Thread.Sleep(5);
                
            
        }
    }
}
