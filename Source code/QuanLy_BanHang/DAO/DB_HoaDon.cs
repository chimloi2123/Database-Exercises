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
    public class DB_HoaDon
    {
        public static List<DTO_HoaDon> getDSHoaDon()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<DTO_HoaDon>($"select * from HOADON").ToList();
                return output;
            }
        }
    }
}
