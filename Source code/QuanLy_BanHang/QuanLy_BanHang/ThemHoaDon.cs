using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLy_BanHang
{
    public partial class ThemHoaDon : Form
    {
        List<DTO_SanPham> lstSanPham;
        public ThemHoaDon()
        {
            InitializeComponent();
            ThemHD_load();
        }
        private void ThemHD_load()
        {   lstSanPham= SanPham.getDSSanPham();
            dsSanPham.DataSource = lstSanPham;
        }

        private void txbMaHV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statistics_Button_Click(object sender, EventArgs e)
        {

        }

        private void invoice_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
