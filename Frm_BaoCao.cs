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
    public partial class Frm_BaoCao : Form
    {
        public Frm_BaoCao()
        {
            InitializeComponent();
        }

        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_rpCTDH rp_CTDH = new Frm_rpCTDH();
            rp_CTDH.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_rpGT rp_gt = new Frm_rpGT();
            rp_gt.Show();
        }

        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            Frm_rpTenSP rp_tsp = new Frm_rpTenSP();
            rp_tsp.Show();
        }
    }
}
