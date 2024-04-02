using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVanDAO : DAO
    {
        public void Them(string maDeTai, string tenDeTai, string theLoai, string moTa, string congNghe, string yeuCau, string chucNang, int soLuongSV, int soLuongMax, string mSGV)
        {
            LuanVan luanVan = new LuanVan(maDeTai, tenDeTai, theLoai, moTa, congNghe, yeuCau, chucNang, soLuongSV, soLuongMax, mSGV);
            string sqlStr = string.Format("INSERT INTO DeTai(MaDT, TenDeTai, TheLoai, MoTa, CongNghe, YeuCau, ChucNang, SoLuongSV, SoLuongSVToiDa, MSGV) VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', '{7}', '{8}', '{9}')", luanVan.MadeTai, luanVan.TenDeTai, luanVan.TheLoai, luanVan.MoTa, luanVan.CongNghe, luanVan.YeuCau, luanVan.ChucNang, luanVan.SoLuongSV, luanVan.SoLuongMax, luanVan.MSGV);
            base.ThucThi(sqlStr);
        }

        public void Xoa(string maDeTai)
        {
            string sqlStr = string.Format($"DELETE FROM DeTai WHERE MaDT = '{maDeTai}'");
            base.ThucThi(sqlStr);
        }
    }
}
