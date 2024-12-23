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
    public partial class Frm_QLNhanVien : Form
    {
        public Frm_QLNhanVien()
        {
            InitializeComponent();
        }

        private void Frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            KetNoi();
            string s = "Select *From NhanVien";
            SqlCommand cmd = new SqlCommand(s, cnn);
            da.SelectCommand = cmd;
            da.Fill(dt);
            BindingSource bin = new BindingSource();
            bin.DataSource = dt;
            DataView.DataSource = bin;
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
                cnn.ConnectionString = @"Data Source=AN-NGUYEN\SQLEXPRESS;Initial Catalog=19CT112_01_01;Integrated Security=True";
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
            txtMaNV.DataBindings.Add("Text", dt, "MaNV");
            txtTenNV.DataBindings.Add("Text", dt, "TenNV");
            txtGioiTinh.DataBindings.Add("Text", dt, "GioiTinh");
            txtSDT.DataBindings.Add("Text", dt, "SDT");
            txtDiaChi.DataBindings.Add("Text", dt, "DiaChi");
            txtNgaySinh.DataBindings.Add("Text", dt, "NgaySinh");
            txtLuong.DataBindings.Add("Text", dt, "Luong");
        }

        public Frm_Dashboard frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click_1(object sender, EventArgs e)
        {
            DongTap();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Scon;
            Scon = "UPDATE NhanVien set MaNV=@MaNV, TenNV=@TenNV, GioiTinh= @GioiTinh, SDT= @SDT , DiaChi= @DiaChi, NgaySinh=@NgaySinh, Luong=@Luong)";
            SqlCommand cmd1 = new SqlCommand(Scon, cnn);
            cmd1.Parameters.Add("@MaNV", SqlDbType.Int).Value = int.Parse(txtMaNV.Text);
            cmd1.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = txtTenNV.Text;
            cmd1.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = txtGioiTinh.Text;
            cmd1.Parameters.Add("@SDT", SqlDbType.Int).Value = int.Parse(txtSDT.Text);
            cmd1.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = txtDiaChi.Text;
            cmd1.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinh.Text;
            cmd1.Parameters.Add("@Luong", SqlDbType.Int).Value = txtLuong.Text;
            int count = cmd1.ExecuteNonQuery();
            MessageBox.Show("Sua thanh cong!");
            dt.Clear();
            da.Fill(dt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].RemoveAt(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Scon;
            Scon = "INSERT into NhanVien values (@MaNv,@TenNV,@GioiTinh,@SDT,@DiaChi,@NgaySinh)";
            SqlCommand cmd1 = new SqlCommand(Scon, cnn);
            cmd1.Parameters.Add("@MaNV", SqlDbType.Int).Value = int.Parse(txtMaNV.Text);
            cmd1.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = txtTenNV.Text;
            cmd1.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = txtGioiTinh.Text;
            cmd1.Parameters.Add("@SDT", SqlDbType.Int).Value = int.Parse(txtSDT.Text);
            cmd1.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = txtDiaChi.Text;
            cmd1.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinh.Text;
            cmd1.Parameters.Add("@Luong", SqlDbType.Int).Value = txtLuong.Text;
            int count = cmd1.ExecuteNonQuery();
            MessageBox.Show("Them thanh cong!");
            dt.Clear();
            da.Fill(dt);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV.Text = Convert.ToString(DataView.CurrentRow.Cells["MaNV"].Value);
                txtTenNV.Text = Convert.ToString(DataView.CurrentRow.Cells["TenNV"].Value);
                txtGioiTinh.Text = Convert.ToString(DataView.CurrentRow.Cells["GioiTinh"].Value);
                txtSDT.Text = Convert.ToString(DataView.CurrentRow.Cells["SDT"].Value);
                txtDiaChi.Text = Convert.ToString(DataView.CurrentRow.Cells["DiaChi"].Value);
                txtNgaySinh.Text = Convert.ToString(DataView.CurrentRow.Cells["NgaySinh"].Value);
                txtLuong.Text = Convert.ToString(DataView.CurrentRow.Cells["Luong"].Value);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position ++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position --;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int vitricuoi = this.BindingContext[dt].Count - 1;
            this.BindingContext[dt].Position = vitricuoi;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = 0;
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            { 
            float a, b;
            a = float.Parse(txtLuong.Text);
            b = float.Parse(textBox1.Text);
                float Luong = a*b;
                textBox2.Text = Luong.ToString()+" VNĐ";
            }
            else
                MessageBox.Show("Vui Long Nhap So Ngay Cong");
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
