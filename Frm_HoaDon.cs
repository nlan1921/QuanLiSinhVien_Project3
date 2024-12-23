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

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
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
        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void dtkpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {

        }

        private void btnFriday_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Calender_Load(object sender, EventArgs e)
        {
            KetNoi();
            string s = "Select *From HoaDon";
            SqlCommand cmd = new SqlCommand(s, cnn);
            da.SelectCommand = cmd;
            da.Fill(dt);
            BindingSource bin = new BindingSource();
            bin.DataSource = dt;
            DataView.DataSource = bin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
