using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivrEjector
{
    public partial class DonateForm1 : Form
    {
        public DonateForm1()
        {
            InitializeComponent();
            this.Text = "Developed by Shaun Cassidy - Donate if you like it!";
        }
        
        private void DonateForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 F1 = new Form1();
            if (F1.Visible == false)
            {
                F1.Show();
            }
            else
            {
                F1.Hide();
            }
        }
    }
}
