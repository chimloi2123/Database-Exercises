using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace QuanLy_BanHang
{
    public partial class XemTKDoanhThu : Form
    {
        //List<DTO_HoaDon> lstHoaDon;
        //List<DTO_CTHoaDon> lstCTHoaDon;
        //List<DTO_SanPham> lstSanPham;
        //DTO_HoaDon HDChon;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=WATERFOUR\SQLEXPRESS01;Initial Catalog=QuanLyHoaDon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            connection = new SqlConnection(str);
            connection.Open();
            
            command = connection.CreateCommand();
            command.CommandText = "EXECUTE USP_selectHOADON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dsSanPham.DataSource = table;
          
        }
        //private void XemTKDoanhThu_Load(object sender, EventArgs e)
        //{

        //    //connection = new SqlConnection(str);
        //    //connection.Open();
        //    //loaddata();
        //}
        public XemTKDoanhThu()
        {   
            InitializeComponent();
            loaddata();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void invoice_Button_Click(object sender, EventArgs e)
        {
            var formDSHD = new XemDSHoaDon();
            formDSHD.Show();
        }

        private void dsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SUM_Click(object sender, EventArgs e)
        {

        }
    }
}
