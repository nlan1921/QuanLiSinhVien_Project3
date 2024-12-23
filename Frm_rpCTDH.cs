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
    public partial class Frm_rpCTDH : Form
    {
        public Frm_rpCTDH()
        {
            InitializeComponent();
        }

        private void Frm_repCTDH_Load(object sender, EventArgs e)
        {

        }
        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19CT112_01_01DataSet1.sp_CTDH' table. You can move, or remove it, as needed.
            this.sp_CTDHTableAdapter.Fill(this._19CT112_01_01DataSet.sp_CTDH);

            this.reportViewer1.RefreshReport();
        }
    }
}
