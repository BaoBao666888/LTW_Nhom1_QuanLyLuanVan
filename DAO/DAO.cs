using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Li_Luan_Van.DTO;

namespace Quan_Li_Luan_Van.DAO
{
    public class DAOclass
    {
        public static DataTable Load(string sqlStr)
        {
            return DbConnection.Load(sqlStr);
        }

        public static void ThucThi(string sqlStr)
        {
            DbConnection.ThucThi(sqlStr);
        }
    }
}
