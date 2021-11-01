using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAO
{
    class DBConnect
    {
        public static string HamKetNoiCSDL(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public IDbConnection CreateConnection()
        {
            string strConString = HamKetNoiCSDL("QUANLYBANHANG");
            var conn = new SqlConnection(strConString);
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Timed Out");
                return new SqlConnection();
            }

            return new SqlConnection(strConString);
        }
    }
}
