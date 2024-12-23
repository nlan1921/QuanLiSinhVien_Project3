using DevComponents.DotNetBar;
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
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            
            timedate.Start();
            
        }

        private void timedate_Tick(object sender, EventArgs e)
        {
            lb_thoigian.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }
        #region Kiem Tra Tab
        bool trangThai=false;
        private String tentabmo;
        private bool Kiemtramotab(string name)
        {
            for (int i = 0; i < tabcontrol_center.Tabs.Count; i++)
            {
                if (tabcontrol_center.Tabs[i].Text == name)
                {
                    tabcontrol_center.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void DongTab()
        {
            foreach (TabItem item in tabcontrol_center.Tabs)
            {
                if (item.IsSelected == true)
                {
                    tabcontrol_center.Tabs.Remove(item);
                    return;
                }
            }
        }
        #endregion

        private void pn_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabcontrol_center_Click(object sender, EventArgs e)
        {

        }
        public Frm_Dashboard frm;
        public delegate void _dongTap();
        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản lý Sản Phẩm";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "QLSanPham";

                Frm_QLSanPham frm_QLSanPham = new Frm_QLSanPham() { 
                DongTap =new Frm_QLSanPham._dongTap(DongTab),
                frm=this,
                TopLevel=false,
                Dock=DockStyle.Fill,
            };
                t.AttachedControl.Controls.Add(frm_QLSanPham);
                frm_QLSanPham.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnQuanLyDienSV_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản lý Nhân Viên";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_QLNhanVien";

                Frm_QLNhanVien Frm_QLNV = new Frm_QLNhanVien()
                {
                    DongTap = new Frm_QLNhanVien._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(Frm_QLNV);
                Frm_QLNV.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void lb_thoigian_Click(object sender, EventArgs e)
        {

        }

        private void btnLichhoc_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Hóa Đơn Bán Hàng";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_Calendar";

                Frm_HoaDon frm_Calender=new Frm_HoaDon()
                {
                   DongTap = new Frm_HoaDon._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frm_Calender);
                frm_Calender.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Hóa Đơn Bán Hàng";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_Hoá Đơn";

                Frm_HoaDon frmHD = new Frm_HoaDon()
                {
                    DongTap = new Frm_HoaDon._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmHD);
                frmHD.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Report";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_BaoCao";

                Frm_BaoCao frm_Report = new Frm_BaoCao()
                {
                    DongTap = new Frm_BaoCao._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frm_Report);
                frm_Report.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Frm_HoTro";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Form Hỗ Trợ";

                Frm_HoTro frm_HT = new Frm_HoTro()
                {
                    DongTap = new Frm_HoTro._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frm_HT);
                frm_HT.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void pn_leftcon1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Frm_NCC";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Form Nhà Cung Cấp";

                Frm_NCC frm_ncc = new Frm_NCC()
                {
                    DongTap = new Frm_NCC._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frm_ncc);
                frm_ncc.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }
    }
}
