﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVanDAO : DAO
    {
        public void Them(string maDeTai, string tenDeTai, string theLoai, string moTa, string congNghe, string yeuCau, int soLuongSV, int soLuongMax, string tenGV)
        {
            LuanVan luanVan = new LuanVan(maDeTai, tenDeTai, theLoai, moTa, congNghe, yeuCau, soLuongSV, soLuongMax, tenGV);
            string sqlStr = string.Format("INSERT INTO LuanVan(MaDeTai, TenDeTai, TheLoai, MoTa, CongNghe, YeuCau, SoLuongSV, SoLuongMaxSV, tenGV) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", luanVan.MadeTai, luanVan.TenDeTai, luanVan.TheLoai, luanVan.MoTa, luanVan.CongNghe, luanVan.YeuCau, luanVan.SoLuongSV, luanVan.SoLuongMax, luanVan.TenGV);
            base.Them(sqlStr);
        }
    }
}
