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
    public partial class Frm_rpTenSP : Form
    {
        public Frm_rpTenSP()
        {
            InitializeComponent();
        }

        private void Frm_rpTenSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19CT112_01_01DataSet1.SanPham1' table. You can move, or remove it, as needed.
            

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.sanPham1TableAdapter.Fill(this._19CT112_01_01DataSet1.SanPham1);
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
