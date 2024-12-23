using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_NCC : Form
    {
        public Frm_NCC()
        {
            InitializeComponent();
        }
        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_NCC_Load(object sender, EventArgs e)
        {
            KetNoi();
            Datquanhe("NCC", "SanPham1", "MaNCC", "MaNCC", "NCC_SanPham1");

            Buoccacdieukhien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();
        SqlConnection cnn = new SqlConnection();

        private void KetNoi()
        {
            try
            {
                cnn.ConnectionString = @"Data Source=AN-NGUYEN\SQLEXPRESS;Initial Catalog=19CT112_01_01;Integrated Security=True";
                cnn.Open();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Lỗi Ket Noi!");
            }
        }
        private void Buoccacdieukhien()
        {
            listBox1.DataSource = ds;
            listBox1.DisplayMember = "NCC.MaNCC";
            DataView.DataSource = ds;
            DataView.DataMember = "NCC.NCC_SanPham1";
            txtMaNCC.DataBindings.Add("Text", ds, "NCC.NCC_SanPham1.MaNCC");
            txtTenNCC.DataBindings.Add("Text", ds, "NCC.TenNCC");
            txtMasp.DataBindings.Add("Text", ds, "NCC.NCC_SanPham1.Masp");
            txtTenSP.DataBindings.Add("Text", ds, "NCC.NCC_SanPham1.Tensp");

        }
        private void Datquanhe(string bangchinh, string bangphu, string khoachinh, string khoaphu, string tenquanhe)
        {

            cmd = new SqlCommand("select * from " + bangchinh, cnn);
            da = new SqlDataAdapter(cmd);
            cmd2 = new SqlCommand("select * from " + bangphu, cnn);
            da2 = new SqlDataAdapter(cmd2);
            ds = new DataSet();
            da.Fill(ds, bangchinh);
            da2.Fill(ds, bangphu);
            DataColumn chinh = ds.Tables[bangchinh].Columns[khoachinh];
            DataColumn phu = ds.Tables[bangphu].Columns[khoaphu];
            DataRelation r = new DataRelation(tenquanhe, chinh, phu);
            ds.Relations.Add(r);

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
