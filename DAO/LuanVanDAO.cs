﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.GUI;

namespace Quan_Li_Luan_Van.DAO
{
    public class LuanVanDAO
    {
        // lấy tất cả task theo mã đt
        public static DataTable GetListTask(string MaDT)
        {
            string sqlStr = string.Format($"select * from DeTai inner join Task on DeTai.MaDT = Task.MaDT inner join DanhGia on DanhGia.MaTask = Task.MaTask where DeTai.MaDT ='{MaDT}'");
            return DbConnection.Load(sqlStr);
        }

        public static DataTable GetDataByMSSV(string MSSV)
        {
            string sqlStr = string.Format($"select * from DeTai inner join DangKi on DangKi.MaDT = DeTai.MaDT where DangKi.MSSV = '{MSSV}' and DangKi.TrangThai = N'Đã duyệt'");
            return DbConnection.Load(sqlStr);
        }

        public static LuanVan GetLuanVanBYMaDT(string MaDT)
        {
            string sqlStr = string.Format($"select * from DeTai where MaDT = '{MaDT}'");
            DataTable dt = DbConnection.Load(sqlStr);
            return new LuanVan(dt.Rows[0]["MaDT"].ToString(), dt.Rows[0]["TenDeTai"].ToString(), dt.Rows[0]["TheLoai"].ToString(), dt.Rows[0]["MoTa"].ToString(), dt.Rows[0]["CongNghe"].ToString(), dt.Rows[0]["YeuCau"].ToString(), dt.Rows[0]["ChucNang"].ToString(), dt.Rows[0]["MSGV"].ToString(), int.Parse(dt.Rows[0]["SoLuongSV"].ToString()));
        }
        public static DataTable GetDataByMaDT(string MaDT)
        {
            string sqlStr = string.Format($"select * from DeTai where MaDT like '%{MaDT}%'");
            return DbConnection.Load(sqlStr);
        }

        //Danh sach luan van theo ma giao vien
        public static DataTable GetDataByMSGV(string MSGV)
        {
            string sqlStr = string.Format($"select * from DeTai where MSGV like '%{MSGV}%'");
            return DbConnection.Load( sqlStr );
        }

        //Danh sach luan van
        public static DataTable GetData()
        {
            string sqlStr = string.Format("select * from DeTai");
            return DbConnection.Load(sqlStr);
        }

        //Them
        public static void Them(LuanVan luanVan)
        {
            string sqlStr = string.Format("INSERT INTO DeTai(MaDT, TenDeTai, TheLoai, MoTa, CongNghe, YeuCau, ChucNang, MSGV, SoLuongSV) VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}','{7}', '{8}')", luanVan.MadeTai, luanVan.TenDeTai, luanVan.TheLoai, luanVan.MoTa, luanVan.CongNghe, luanVan.YeuCau, luanVan.ChucNang, luanVan.MSGV, luanVan.SoLuongSV);
            DbConnection.ThucThi(sqlStr);
        }

        // Sua

        public static void Sua(LuanVan luanVan)
        {
            string sqlStr = string.Format($"UPDATE DeTai set TenDeTai = N'{luanVan.TenDeTai}', TheLoai = N'{luanVan.TheLoai}', MoTa = N'{luanVan.MoTa}', CongNghe = N'{luanVan.CongNghe}', YeuCau = N'{luanVan.YeuCau}', ChucNang = N'{luanVan.ChucNang}', MSGV = N'{luanVan.MSGV}', SoLuongSV = N'{luanVan.SoLuongSV}'");
            DbConnection.ThucThi(sqlStr);
        }

        //Xoa

        public static void Xoa(string maDeTai)
        {
            string sqlStr = string.Format($"DELETE FROM DeTai WHERE MaDT = '{maDeTai}'");
            DbConnection.ThucThi(sqlStr);
        }

        //TimKiem

        public static DataTable TimKiem(string input)
        {
            string sqlStr = string.Format($"select * from DeTai where MSGV like '%{input}%' or MaDT like N'%{input}%' or TenDeTai like N'%{input}%' or  TheLoai like N'%{input}%' or YeuCau like N'%{input}%'");
            return DbConnection.Load(sqlStr);
        }

        public static DataTable TimKiem(string MSGV, string input)
        {
            string sqlStr = string.Format($"select * from DeTai where MSGV = '{MSGV}' and (MaDT like N'%{input}%' or TenDeTai like N'%{input}%' or  TheLoai like N'%{input}%' or YeuCau like N'%{input}%')");
            return DbConnection.Load(sqlStr);
        }
    }
}
