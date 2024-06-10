using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_lis_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbskqten.Items.Add(" Trà Hồng Ly");
        } 
            private void btnt_Click(object sender, EventArgs e)
        {
            lbskqten.Items.Add(txt1.Text);
            txt1.Text = string.Empty;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            if (lbskqten.SelectedIndex < 0) return;
            lbskqten.Items[lbskqten.SelectedIndex] = txt1.Text;
        }

        private void btns_Click(object sender, EventArgs e)
        {
            lbskqten.Items.RemoveAt(lbskqten.SelectedIndex);
        }
    }
}
