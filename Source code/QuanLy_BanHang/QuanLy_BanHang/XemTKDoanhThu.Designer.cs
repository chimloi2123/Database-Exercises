
namespace QuanLy_BanHang
{
    partial class XemTKDoanhThu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_invoice = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.invoice_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Schedule = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsSanPham = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_invoice);
            this.panel2.Controls.Add(this.exit_button);
            this.panel2.Controls.Add(this.invoice_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 34);
            this.panel2.TabIndex = 9;
            // 
            // add_invoice
            // 
            this.add_invoice.AutoEllipsis = true;
            this.add_invoice.BackColor = System.Drawing.Color.DarkCyan;
            this.add_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_invoice.Location = new System.Drawing.Point(401, 0);
            this.add_invoice.Margin = new System.Windows.Forms.Padding(4);
            this.add_invoice.Name = "add_invoice";
            this.add_invoice.Size = new System.Drawing.Size(265, 34);
            this.add_invoice.TabIndex = 10;
            this.add_invoice.Text = "Thêm Hóa Đơn";
            this.add_invoice.UseVisualStyleBackColor = false;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.DarkCyan;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(775, 1);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(115, 34);
            this.exit_button.TabIndex = 9;
            this.exit_button.Text = "Thoát";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // invoice_Button
            // 
            this.invoice_Button.AutoEllipsis = true;
            this.invoice_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.invoice_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_Button.Location = new System.Drawing.Point(93, 1);
            this.invoice_Button.Margin = new System.Windows.Forms.Padding(4);
            this.invoice_Button.Name = "invoice_Button";
            this.invoice_Button.Size = new System.Drawing.Size(265, 34);
            this.invoice_Button.TabIndex = 4;
            this.invoice_Button.Text = "Danh Sách Hóa Đơn";
            this.invoice_Button.UseVisualStyleBackColor = false;
            this.invoice_Button.Click += new System.EventHandler(this.invoice_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLy_BanHang.Properties.Resources.add_bill;
            this.pictureBox1.Location = new System.Drawing.Point(489, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            this.Schedule.Image = global::QuanLy_BanHang.Properties.Resources.invoice;
            this.Schedule.Location = new System.Drawing.Point(173, 4);
            this.Schedule.Margin = new System.Windows.Forms.Padding(4);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(69, 70);
            this.Schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Schedule.TabIndex = 0;
            this.Schedule.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Schedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 114);
            this.panel1.TabIndex = 64;
            // 
            // dsSanPham
            // 
            this.dsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSanPham.Location = new System.Drawing.Point(44, 154);
            this.dsSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dsSanPham.Name = "dsSanPham";
            this.dsSanPham.RowHeadersWidth = 51;
            this.dsSanPham.Size = new System.Drawing.Size(593, 308);
            this.dsSanPham.TabIndex = 66;
            this.dsSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsSanPham_CellContentClick);
            // 
            // XemTKDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(921, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dsSanPham);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XemTKDoanhThu";
            this.Text = "XemTKDoanhThu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_invoice;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button invoice_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Schedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dsSanPham;
    }
}