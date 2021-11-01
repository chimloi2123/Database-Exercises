
namespace QuanLy_BanHang
{
    partial class XemDSHoaDon
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
            this.button3 = new System.Windows.Forms.Button();
            this.dsHoaDon = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Schedule = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SUM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbGioiTinh = new System.Windows.Forms.TextBox();
            this.txbMaHV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statistics_view_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(301, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thêm Hóa Đơn";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dsHoaDon
            // 
            this.dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHoaDon.Location = new System.Drawing.Point(33, 126);
            this.dsHoaDon.Name = "dsHoaDon";
            this.dsHoaDon.Size = new System.Drawing.Size(409, 250);
            this.dsHoaDon.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 51;
            this.button1.Text = "Lưu Chỉnh Sửa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkCyan;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(635, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 28);
            this.exit.TabIndex = 9;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statistics_view_Button);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 28);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Schedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 93);
            this.panel1.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLy_BanHang.Properties.Resources.add_bill;
            this.pictureBox1.Location = new System.Drawing.Point(367, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            this.Schedule.Image = global::QuanLy_BanHang.Properties.Resources.statistics;
            this.Schedule.Location = new System.Drawing.Point(130, 3);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(52, 57);
            this.Schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Schedule.TabIndex = 0;
            this.Schedule.TabStop = false;
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(343, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 26);
            this.button4.TabIndex = 55;
            this.button4.Text = "Xóa HD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SUM
            // 
            this.SUM.AutoSize = true;
            this.SUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUM.Location = new System.Drawing.Point(606, 241);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(102, 37);
            this.SUM.TabIndex = 63;
            this.SUM.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "TỔNG TIỀN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Location = new System.Drawing.Point(604, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // txbGioiTinh
            // 
            this.txbGioiTinh.Location = new System.Drawing.Point(604, 180);
            this.txbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txbGioiTinh.Name = "txbGioiTinh";
            this.txbGioiTinh.Size = new System.Drawing.Size(87, 20);
            this.txbGioiTinh.TabIndex = 60;
            // 
            // txbMaHV
            // 
            this.txbMaHV.Location = new System.Drawing.Point(604, 152);
            this.txbMaHV.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaHV.Name = "txbMaHV";
            this.txbMaHV.Size = new System.Drawing.Size(87, 20);
            this.txbMaHV.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mã đơn hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(520, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Thêm Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statistics_view_Button
            // 
            this.statistics_view_Button.AutoEllipsis = true;
            this.statistics_view_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.statistics_view_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_view_Button.Location = new System.Drawing.Point(68, 0);
            this.statistics_view_Button.Name = "statistics_view_Button";
            this.statistics_view_Button.Size = new System.Drawing.Size(199, 28);
            this.statistics_view_Button.TabIndex = 11;
            this.statistics_view_Button.Text = "Thống Kê Doanh Thu";
            this.statistics_view_Button.UseVisualStyleBackColor = false;
            this.statistics_view_Button.Click += new System.EventHandler(this.statistics_view_Button_Click);
            // 
            // XemDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SUM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txbGioiTinh);
            this.Controls.Add(this.txbMaHV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dsHoaDon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "XemDSHoaDon";
            this.Text = "XemDSHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dsHoaDon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        //private System.Windows.Forms.Button Statistics_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Schedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label SUM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txbGioiTinh;
        private System.Windows.Forms.TextBox txbMaHV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statistics_view_Button;
    }
}