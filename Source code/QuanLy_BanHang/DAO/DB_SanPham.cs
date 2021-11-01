using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using Dapper;
namespace DAO
{
    public class DB_SanPham
    {
        public static List<DTO_SanPham> getDSSanPham()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_SanPham>($"select * from SANPHAM").ToList();
                return output;
            }
        }

    }
}
