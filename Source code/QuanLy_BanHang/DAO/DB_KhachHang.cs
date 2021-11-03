using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data;
namespace DAO
{
    public class DB_KhachHang
    {
        public static List<DTO_KhachHang> getDSKhachHangTheoMa(string maKH)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_KhachHang>($"select * from khachhang where makh='{maKH}'").ToList();
                return output;

            }

        }
    }
}
