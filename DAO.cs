using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class DAO
    {
        DbConnection dbConnection = new DbConnection();
        public DataTable Load(string sqlStr)
        {
            return dbConnection.Load(sqlStr);
        }

        public void Them(string sqlStr)
        {
            dbConnection.ThucThi(sqlStr);
        }
    }
}
