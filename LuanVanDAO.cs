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

        public void Them(string id, string deTai, char trangThai, string moTa, DateTime deadline)
        {
            LuanVan luanVan = new LuanVan(id, deTai, trangThai, moTa, deadline);
            string sqlStr = string.Format("INSERT INTO luanVan(Id, DeTai, TrangThai, MoTa, Deadline) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", luanVan.Id, luanVan.DeTai, luanVan.TrangThai, luanVan.MoTa, luanVan.Deadline);
            dbConnection.ThucThi(sqlStr);
        }


    }
}
