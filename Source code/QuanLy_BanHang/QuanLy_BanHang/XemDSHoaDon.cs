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
    public partial class XemDSHoaDon : Form
    {
        List<DTO_HoaDon> lstHoaDon;
        public XemDSHoaDon()
        {
            InitializeComponent();
            XemDSHoaDon_Load();
        }
        public void XemDSHoaDon_Load()
        {
            lstHoaDon = HoaDon.getDSHoaDon();
            dsHoaDon.DataSource = lstHoaDon;

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void Statistics_Button(object sender, EventArgs e)
        //{

        //}

        private void add_invoice_Button_Click(object sender, EventArgs e)
        {

        }

        private void statistics_view_Button_Click(object sender, EventArgs e)
        {

        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
