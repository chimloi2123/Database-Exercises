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
    public class DB_HoaDon
    {
        public static List<DTO_HoaDon> getDSHoaDon()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_HoaDon>($"select * from hoadon").ToList();
                return output;

            }
            
        }
        public static List<DTO_HoaDon> getDSHoaDonTheoMa(string maHD)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_HoaDon>($"select * from hoadon where mahd='{maHD}'").ToList();
                return output;

            }
        }
        public static void TaoHD(string maHD,string maKH, DateTime NgayLap)
        {
            string sqlNgayLap = NgayLap.ToString("yyyy-MM-ddTHH:mm:ss.fff");
           
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<bool>($"insert into HOADON([MAHD], [MAKH], [NGAYLAP]) values(N'{maHD}', N'{maKH}', CAST(N'{sqlNgayLap}' AS SmallDateTime   )   ) ");
                return;
            }

        }
    }
}
