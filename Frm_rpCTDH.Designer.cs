﻿namespace QuanLiSinhVien_Project3
{
    partial class Frm_rpCTDH
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.chiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cT1120101DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._19CT112_01_01DataSet1 = new QuanLiSinhVien_Project3._19CT112_01_01DataSet();
            this.spCTDHBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.spCTDHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spCTDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19CT112_01_01DataSet = new QuanLiSinhVien_Project3._19CT112_01_01DataSet();
            this.sp_CTDHTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.sp_CTDHTableAdapter();
            this.sp_CTDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT1120101DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp__CTHDTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.sp__CTHDTableAdapter();
            this.chiTietHDTableAdapter = new QuanLiSinhVien_Project3._19CT112_01_01DataSetTableAdapters.ChiTietHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chiTietHDBindingSource
            // 
            this.chiTietHDBindingSource.DataMember = "ChiTietHD";
            this.chiTietHDBindingSource.DataSource = this.cT1120101DataSet1BindingSource1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(12, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Số Hóa Đơn:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSoHD.Location = new System.Drawing.Point(111, 30);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(143, 26);
            this.txtSoHD.TabIndex = 2;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.Location = new System.Drawing.Point(297, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(117, 51);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Xuất Báo Cáo";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_CTDHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiSinhVien_Project3.rp_CTDH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(832, 442);
            this.reportViewer1.TabIndex = 4;
            // 
            // spCTHDBindingSource
            // 
            this.spCTHDBindingSource.DataMember = "sp_*CTHD";
            this.spCTHDBindingSource.DataSource = this.cT1120101DataSet1BindingSource;
            // 
            // chiTietHDBindingSource1
            // 
            this.chiTietHDBindingSource1.DataMember = "ChiTietHD";
            this.chiTietHDBindingSource1.DataSource = this.cT1120101DataSet1BindingSource;
            // 
            // cT1120101DataSet1BindingSource1
            // 
            this.cT1120101DataSet1BindingSource1.DataSource = this._19CT112_01_01DataSet1;
            this.cT1120101DataSet1BindingSource1.Position = 0;
            // 
            // _19CT112_01_01DataSet1
            // 
            this._19CT112_01_01DataSet1.DataSetName = "_19CT112_01_01DataSet";
            this._19CT112_01_01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCTDHBindingSource2
            // 
            this.spCTDHBindingSource2.DataMember = "sp_CTDH";
            this.spCTDHBindingSource2.DataSource = this._19CT112_01_01DataSet1;
            // 
            // spCTDHBindingSource1
            // 
            this.spCTDHBindingSource1.DataMember = "sp_CTDH";
            this.spCTDHBindingSource1.DataSource = this._19CT112_01_01DataSet1;
            // 
            // spCTDHBindingSource
            // 
            this.spCTDHBindingSource.DataMember = "sp_CTDH";
            this.spCTDHBindingSource.DataSource = this._19CT112_01_01DataSet;
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
            // sp_CTDHBindingSource
            // 
            this.sp_CTDHBindingSource.DataMember = "sp_CTDH";
            this.sp_CTDHBindingSource.DataSource = this._19CT112_01_01DataSet;
            // 
            // cT1120101DataSet1BindingSource
            // 
            this.cT1120101DataSet1BindingSource.DataSource = this._19CT112_01_01DataSet1;
            this.cT1120101DataSet1BindingSource.Position = 0;
            // 
            // sp__CTHDTableAdapter
            // 
            this.sp__CTHDTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietHDTableAdapter
            // 
            this.chiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_rpCTDH
            // 
            this.AcceptButton = this.buttonX1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 532);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.labelX1);
            this.Name = "Frm_rpCTDH";
            this.Text = "Frm_repCTDH";
            this.Load += new System.EventHandler(this.Frm_repCTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCTDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19CT112_01_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CTDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT1120101DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _19CT112_01_01DataSet _19CT112_01_01DataSet;
        private System.Windows.Forms.BindingSource spCTDHBindingSource;
        private _19CT112_01_01DataSetTableAdapters.sp_CTDHTableAdapter sp_CTDHTableAdapter;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtSoHD;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _19CT112_01_01DataSet _19CT112_01_01DataSet1;
        private System.Windows.Forms.BindingSource spCTDHBindingSource1;
        private System.Windows.Forms.BindingSource sp_CTDHBindingSource;
        private System.Windows.Forms.BindingSource spCTDHBindingSource2;
        private System.Windows.Forms.BindingSource spCTHDBindingSource;
        private System.Windows.Forms.BindingSource cT1120101DataSet1BindingSource;
        private _19CT112_01_01DataSetTableAdapters.sp__CTHDTableAdapter sp__CTHDTableAdapter;
        private System.Windows.Forms.BindingSource cT1120101DataSet1BindingSource1;
        private System.Windows.Forms.BindingSource chiTietHDBindingSource;
        private _19CT112_01_01DataSetTableAdapters.ChiTietHDTableAdapter chiTietHDTableAdapter;
        private System.Windows.Forms.BindingSource chiTietHDBindingSource1;
    }
}