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

        public void Them(string maDeTai, string tenDeTai, string theLoai, string moTa, string congNghe, string yeuCau, int soLuongSV, int soLuongMax)
        {
            LuanVan luanVan = new LuanVan(maDeTai, tenDeTai, theLoai, moTa, congNghe, yeuCau, soLuongSV, soLuongMax);
            string sqlStr = string.Format("INSERT INTO LuanVan(MaDeTai, TenDeTai, TheLoai, MoTa, CongNghe, YeuCau, SoLuongSV, SoLuongMaxSV) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", luanVan.MadeTai, luanVan.TenDeTai, luanVan.TheLoai, luanVan.MoTa, luanVan.CongNghe, luanVan.YeuCau, luanVan.SoLuongSV, luanVan.SoLuongMax);
            dbConnection.ThucThi(sqlStr);
        }


    }
}
