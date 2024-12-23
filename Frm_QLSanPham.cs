using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_QLSanPham : Form
    {
        public Frm_QLSanPham()
        {
            InitializeComponent();
        }

        private void Frm_QLSanPham_Load(object sender, EventArgs e)
        {
            KetNoi();
            string s = "Select *From SanPham1";
            SqlCommand cmd = new SqlCommand(s, cnn);
            da.SelectCommand = cmd;
            da.Fill(dt);
            BindingSource bin = new BindingSource();
            bin.DataSource = dt;
            DataView.DataSource = bin;
            BuocCacDieuKhien();
        }

        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommandBuilder cmb;
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection();
        private void KetNoi()
        {
            try
            {
                cnn.ConnectionString = @"Data Source=an-nguyen\sqlexpress;Initial Catalog=19CT112_01_01;Integrated Security=True";
                cnn.Open();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Lỗi Ket Noi!");
            }
        }

        private void BuocCacDieuKhien()
        {
            DataView.DataSource = dt;
            txtMasp.DataBindings.Add("Text", dt, "Masp");
            txtTensp.DataBindings.Add("Text", dt, "Tensp");
            txtLoaiHang.DataBindings.Add("Text", dt, "LoaiHang");
            txtSoLuong.DataBindings.Add("Text", dt, "SoLuong");
            txtDonGia.DataBindings.Add("Text", dt, "DonGia");
            txtGhiChu.DataBindings.Add("Text", dt, "GhiChu");
        }       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DongTap();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Scon;
            Scon = "insert into SanPham1(Masp,Tensp,LoaiHang,SoLuong,DonGia,GhiChu)";
            Scon += "values(@Masp,@Tensp,@LoaiHang,@SoLuong,@DonGia,@GhiChu)";
            SqlCommand cmd1 = new SqlCommand(Scon, cnn);
            cmd1.Parameters.Add("@Masp", SqlDbType.Int).Value = int.Parse(txtMasp.Text);
            cmd1.Parameters.Add("@Tensp", SqlDbType.NVarChar,50).Value = txtTensp.Text;
            cmd1.Parameters.Add("@LoaiHang", SqlDbType.NVarChar,50).Value = txtLoaiHang.Text;
            cmd1.Parameters.Add("@SoLuong", SqlDbType.Int).Value = int.Parse(txtSoLuong.Text);
            cmd1.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = decimal.Parse(txtDonGia.Text);
            cmd1.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;
            cmd1.ExecuteNonQuery();
            dt.Clear();
            da.Fill(dt);
            
        }

        private void DataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMasp.Text = Convert.ToString(DataView.CurrentRow.Cells["Masp"].Value);
                txtTensp.Text = Convert.ToString(DataView.CurrentRow.Cells["Tensp"].Value);
                txtLoaiHang.Text = Convert.ToString(DataView.CurrentRow.Cells["LoaiHang"].Value);
                txtSoLuong.Text = Convert.ToString(DataView.CurrentRow.Cells["SoLuong"].Value);
                txtDonGia.Text = Convert.ToString(DataView.CurrentRow.Cells["DonGia"].Value);
                txtGhiChu.Text = Convert.ToString(DataView.CurrentRow.Cells["GhiChu"].Value);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = dt.GetChanges();
            if (tbl == null)
            {
                MessageBox.Show("Du lieu chua thay doi");
            }
            else
            {
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Co " + tbl.Rows.Count + "dong da duoc cap nhat");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].RemoveAt(0);
            }

        private void button4_Click_1(object sender, EventArgs e)
        {
                string Scon;
                Scon = "UPDATE SanPham1 set Masp=@Masp, Tensp=@Tensp,LoaiHang= @LoaiHang, SoLuong= @SoLuong ,DonGia= @DonGia, GhiChu=@GhiChu where Masp = @Masp)";
            SqlCommand cmd1 = new SqlCommand(Scon, cnn);
            cmd1.Parameters.Add("@Masp", SqlDbType.Int).Value = int.Parse(txtMasp.Text);
            cmd1.Parameters.Add("@Tensp", SqlDbType.NVarChar, 50).Value = txtTensp.Text;
            cmd1.Parameters.Add("@LoaiHang", SqlDbType.NVarChar, 50).Value = txtLoaiHang.Text;
            cmd1.Parameters.Add("@SoLuong", SqlDbType.Int).Value = int.Parse(txtSoLuong.Text);
            cmd1.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = decimal.Parse(txtDonGia.Text);
            cmd1.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;
            cmd1.ExecuteNonQuery();
            dt.Clear();
            da.Fill(dt);
            MessageBox.Show("Sua thanh cong!");
        }

        private void btnxem_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = 0;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position --;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position ++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
                int vitricuoi = this.BindingContext[dt].Count - 1;
                this.BindingContext[dt].Position = vitricuoi;
        }
    }
}
