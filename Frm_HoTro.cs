using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_HoTro : Form
    {
        public Frm_HoTro()
        {
            InitializeComponent();
        }

        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DongTap();
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }
    }
}
