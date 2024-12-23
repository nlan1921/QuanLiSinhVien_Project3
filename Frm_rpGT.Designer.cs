namespace QuanLiSinhVien_Project3
{
    partial class Frm_rpGT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.chiTietHDTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.ChiTietHDTableAdapter();
            this.spCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT1120101DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19CT112_01_01DataSet1 = new QuanLiSinhVien_Project3._19CT112_01_01DataSet();
            this.sp_CTDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19CT112_01_01DataSet = new QuanLiSinhVien_Project3._19CT112_01_01DataSet();
            this.sp_CTDHTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.sp_CTDHTableAdapter();
            this.spCTDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp__CTHDTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.sp__CTHDTableAdapter();
            this.spCTDHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.spCTDHBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cT1120101DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spCTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chiTietHDTableAdapter
            // 
            this.chiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // spCTHDBindingSource
            // 
            this.spCTHDBindingSource.DataMember = "sp_*CTHD";
            this.spCTHDBindingSource.DataSource = this.cT1120101DataSet1BindingSource;
            // 
            // cT1120101DataSet1BindingSource
            // 
            this.cT1120101DataSet1BindingSource.DataSource = this._19CT112_01_01DataSet1;
            this.cT1120101DataSet1BindingSource.Position = 0;
            // 
            // _19CT112_01_01DataSet1
            // 
            this._19CT112_01_01DataSet1.DataSetName = "_19CT112_01_01DataSet";
            this._19CT112_01_01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_CTDHBindingSource
            // 
            this.sp_CTDHBindingSource.DataMember = "sp_CTDH";
            this.sp_CTDHBindingSource.DataSource = this._19CT112_01_01DataSet;
            // 
            // _19CT112_01_01DataSet
            // 
            this._19CT112_01_01DataSet.DataSetName = "_19CT112_01_01DataSet";
            this._19CT112_01_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_CTDHTableAdapter
            // 
            this.sp_CTDHTableAdapter.ClearBeforeFill = true;
            // 
            // spCTDHBindingSource
            // 
            this.spCTDHBindingSource.DataMember = "sp_CTDH";
            this.spCTDHBindingSource.DataSource = this._19CT112_01_01DataSet;
            // 
            // sp__CTHDTableAdapter
            // 
            this.sp__CTHDTableAdapter.ClearBeforeFill = true;
            // 
            // spCTDHBindingSource1
            // 
            this.spCTDHBindingSource1.DataMember = "sp_CTDH";
            this.spCTDHBindingSource1.DataSource = this._19CT112_01_01DataSet1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.Location = new System.Drawing.Point(306, 7);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(117, 51);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Xuất Báo Cáo";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(21, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Giới Tính:";
            // 
            // spCTDHBindingSource2
            // 
            this.spCTDHBindingSource2.DataMember = "sp_CTDH";
            this.spCTDHBindingSource2.DataSource = this._19CT112_01_01DataSet1;
            // 
            // cT1120101DataSet1BindingSource1
            // 
            this.cT1120101DataSet1BindingSource1.DataSource = this._19CT112_01_01DataSet1;
            this.cT1120101DataSet1BindingSource1.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.nhanVienBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiSinhVien_Project3.rp_GT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(832, 442);
            this.reportViewer1.TabIndex = 8;
            // 
            // chiTietHDBindingSource
            // 
            this.chiTietHDBindingSource.DataMember = "ChiTietHD";
            this.chiTietHDBindingSource.DataSource = this.cT1120101DataSet1BindingSource1;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownColumns = "Nam , Nu";
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(103, 28);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 9;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this._19CT112_01_01DataSet;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this._19CT112_01_01DataSet1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_rpGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_rpGT";
            this.Text = "rp_GT";
            this.Load += new System.EventHandler(this.Frm_rpGT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spCTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _19CT112_01_01DataSetTableAdapters.ChiTietHDTableAdapter chiTietHDTableAdapter;
        private System.Windows.Forms.BindingSource spCTHDBindingSource;
        private System.Windows.Forms.BindingSource cT1120101DataSet1BindingSource;
        private _19CT112_01_01DataSet _19CT112_01_01DataSet1;
        private System.Windows.Forms.BindingSource sp_CTDHBindingSource;
        private _19CT112_01_01DataSet _19CT112_01_01DataSet;
        private _19CT112_01_01DataSetTableAdapters.sp_CTDHTableAdapter sp_CTDHTableAdapter;
        private System.Windows.Forms.BindingSource spCTDHBindingSource;
        private _19CT112_01_01DataSetTableAdapters.sp__CTHDTableAdapter sp__CTHDTableAdapter;
        private System.Windows.Forms.BindingSource spCTDHBindingSource1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.BindingSource spCTDHBindingSource2;
        private System.Windows.Forms.BindingSource cT1120101DataSet1BindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chiTietHDBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private _19CT112_01_01DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}