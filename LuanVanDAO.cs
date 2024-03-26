using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVanDAO
    {
        DbConnection dbConnection = new DbConnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("Select *from LuanVan");
            return dbConnection.Load(sqlStr);
        }

        public void Them(string id, string deTai, char trangThai, string moTa)
        {
            LuanVan luanVan = new LuanVan(id, deTai, trangThai, moTa);
            string sqlStr = string.Format("INSERT INTO luanVan(Id, DeTai, TrangThai, MoTa) VALUES ('{0}', '{1}', '{2}', '{3}')", luanVan.Id, luanVan.DeTai, luanVan.TrangThai, luanVan.MoTa);
            dbConnection.ThucThi(sqlStr);
        }


    }
}
