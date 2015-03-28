using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DrivrEjector
{
    public partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnsString, int uReturnString, IntPtr hwndCallback);
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text="Drivr Ejectr! - GNU Utility" ;
            this.button1.Text = "Open Tray";
            this.button2.Text = "Close Tray";
            this.button3.Text = "Like It? Please Donate :)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);

            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string urlw = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=32LXGKCZNFZTQ";
            DonateToUs(urlw);

        }

        private void DonateToUs(string url)
        {
            Process.Start(url);   
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DonateForm1 d1 = new DonateForm1();
            this.Hide();
            d1.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
