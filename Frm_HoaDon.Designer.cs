
namespace QuanLiSinhVien_Project3
{
    partial class Frm_HoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtkpDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 488);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dtkpDate);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 29);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLiSinhVien_Project3.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(54, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 29);
            this.panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            this.nmNotify.Location = new System.Drawing.Point(82, 6);
            this.nmNotify.Margin = new System.Windows.Forms.Padding(2);
            this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(94, 20);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNotify.Location = new System.Drawing.Point(9, 7);
            this.ckbNotify.Margin = new System.Windows.Forms.Padding(2);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(56, 19);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Notify";
            this.ckbNotify.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.LightCyan;
            this.btnToday.Location = new System.Drawing.Point(646, 0);
            this.btnToday.Margin = new System.Windows.Forms.Padding(2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(67, 29);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            // 
            // dtkpDate
            // 
            this.dtkpDate.CalendarMonthBackground = System.Drawing.Color.Aqua;
            this.dtkpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtkpDate.Location = new System.Drawing.Point(329, 3);
            this.dtkpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtkpDate.Name = "dtkpDate";
            this.dtkpDate.Size = new System.Drawing.Size(256, 23);
            this.dtkpDate.TabIndex = 0;
            this.dtkpDate.ValueChanged += new System.EventHandler(this.dtkpDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataView);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(2, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 435);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(9, 52);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(823, 376);
            this.DataView.TabIndex = 3;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(-9, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(895, 9);
            this.textBox1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AccessibleDescription = "v";
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnThursday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(2, -19);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(952, 62);
            this.panel4.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.Location = new System.Drawing.Point(763, 16);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrevious.Location = new System.Drawing.Point(2, 14);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(61, 46);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnSunday
            // 
            this.btnSunday.BackColor = System.Drawing.Color.LightBlue;
            this.btnSunday.Location = new System.Drawing.Point(671, 16);
            this.btnSunday.Margin = new System.Windows.Forms.Padding(2);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(74, 46);
            this.btnSunday.TabIndex = 1;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseVisualStyleBackColor = false;
            // 
            // btnSaturday
            // 
            this.btnSaturday.BackColor = System.Drawing.Color.Aqua;
            this.btnSaturday.Location = new System.Drawing.Point(574, 16);
            this.btnSaturday.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(79, 46);
            this.btnSaturday.TabIndex = 1;
            this.btnSaturday.Text = "Saturday";
            this.btnSaturday.UseVisualStyleBackColor = false;
            this.btnSaturday.Click += new System.EventHandler(this.btnSaturday_Click);
            // 
            // btnFriday
            // 
            this.btnFriday.BackColor = System.Drawing.Color.LightBlue;
            this.btnFriday.Location = new System.Drawing.Point(481, 16);
            this.btnFriday.Margin = new System.Windows.Forms.Padding(2);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(76, 46);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseVisualStyleBackColor = false;
            this.btnFriday.Click += new System.EventHandler(this.btnFriday_Click);
            // 
            // btnWednesday
            // 
            this.btnWednesday.BackColor = System.Drawing.Color.LightBlue;
            this.btnWednesday.Location = new System.Drawing.Point(278, 16);
            this.btnWednesday.Margin = new System.Windows.Forms.Padding(2);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(81, 46);
            this.btnWednesday.TabIndex = 3;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseVisualStyleBackColor = false;
            // 
            // btnTuesday
            // 
            this.btnTuesday.BackColor = System.Drawing.Color.Aqua;
            this.btnTuesday.Location = new System.Drawing.Point(177, 16);
            this.btnTuesday.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(81, 46);
            this.btnTuesday.TabIndex = 2;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseVisualStyleBackColor = false;
            // 
            // btnThursday
            // 
            this.btnThursday.BackColor = System.Drawing.Color.Aqua;
            this.btnThursday.Location = new System.Drawing.Point(376, 16);
            this.btnThursday.Margin = new System.Windows.Forms.Padding(2);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(86, 46);
            this.btnThursday.TabIndex = 1;
            this.btnThursday.Text = "Thursday";
            this.btnThursday.UseVisualStyleBackColor = false;
            // 
            // btnMonday
            // 
            this.btnMonday.BackColor = System.Drawing.Color.LightBlue;
            this.btnMonday.Location = new System.Drawing.Point(80, 15);
            this.btnMonday.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(80, 46);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseVisualStyleBackColor = false;
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Calender";
            this.Load += new System.EventHandler(this.Frm_Calender_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtkpDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnMonday;
    }
}