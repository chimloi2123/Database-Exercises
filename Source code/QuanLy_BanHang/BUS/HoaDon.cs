using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDon
    {
        public static List<DTO_HoaDon> getDSHoaDon()
        {
            return DB_HoaDon.getDSHoaDon();
        }
    }
}
