using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data;
using System.Windows.Forms;
namespace DAO
{
    public class DB_CTHoaDon
    {
        public static List<DTO_CTHoaDon> GetDSCTHoaDon(string maHD)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_CTHoaDon>($"SELECT CT_HOADON.*,SANPHAM.TENSP FROM CT_HOADON JOIN SANPHAM ON CT_HOADON.MASP=SANPHAM.MASP " +
                    $"WHERE MAHD='{maHD}'").ToList();
  
                return output;


            }

        }
        public static void TaoCTHoaDon(string maHD,string maSP, int soLuong, float giaBan,float giaGiam)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_CTHoaDon>($"INSERT INTO  CT_HOADON ([MAHD], [MASP], [SOLUONG], [GIABAN], [GIAGIAM]) VALUES(N'{maHD}', N'{maSP}', {soLuong}, {giaBan}, {giaGiam})");

                return;


            }

        }

    }
}
