using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            MessageBox.Show("" + urls.Length);

        }
    }
}
