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
        List<DTO_CTHoaDon> lstCTHoaDon;
        DTO_HoaDon HDChon;
        public XemDSHoaDon()
        {
            InitializeComponent();
            XemDSHoaDon_Load();
        }
        public void XemDSHoaDon_Load()
        {
            lstHoaDon = HoaDon.getDSHoaDon();
            dsHoaDon.DataSource = lstHoaDon;
            //lstCTHoaDon = CTHoaDon.GetDSCTHoaDon();
            

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

        private void dsHoaDon_SelectionChanged(object sender, EventArgs e)
        {   
            HDChon = lstHoaDon[dsHoaDon.CurrentCell.RowIndex];
            dsCT_HoaDon.DataSource = CTHoaDon.GetDSCTHoaDon(HDChon.MaHD);
            SUM.Text = HDChon.TONGTIEN+" vnd";
        }

        private void dsHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XemDSHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void dsCT_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SUM_Click(object sender, EventArgs e)
        {

        }
    }
}
