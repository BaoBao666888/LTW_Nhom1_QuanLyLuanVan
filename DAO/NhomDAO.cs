using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class NhomDAO
    {
        public static void Them(Nhom nhom)
        {
            string sqlStr = string.Format("insert into Nhom(TenNhom) values ('N{0}')", nhom.TenNhom);
            DbConnection.Load(sqlStr);
        }

    }
}
