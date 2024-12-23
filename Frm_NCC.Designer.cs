namespace QuanLiSinhVien_Project3
{
    partial class Frm_NCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataView.Location = new System.Drawing.Point(194, 166);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(681, 293);
            this.DataView.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(146, 138);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(126, 20);
            this.txtTenNCC.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(533, 4);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(126, 20);
            this.textBox7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Ngày Công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(146, 107);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(126, 20);
            this.txtMaNCC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Nhà Cung Cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 30);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::QuanLiSinhVien_Project3.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMasp);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.DataView);
            this.panel2.Controls.Add(this.txtTenNCC);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaNCC);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 474);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(435, 140);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(126, 20);
            this.txtTenSP.TabIndex = 13;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(435, 109);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(126, 20);
            this.txtMasp.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã Sản Phẩm";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 290);
            this.listBox1.TabIndex = 8;
            // 
            // Frm_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_NCC";
            this.Text = "Frm_NCC";
            this.Load += new System.EventHandler(this.Frm_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX DataView;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label7;
    }
}