﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class SinhVienDAO
    {
        public static SinhVien GetSVByMaTK(string maTK)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var sv = (from s in db.SinhViens
                              where s.MaTK == maTK
                              select s
                              ).SingleOrDefault();
                    return sv;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static List<SinhVien> DSThongTinSVDangKiThanhCong()
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var sv = (from d in db.DangKis
                              join s in db.SinhViens
                              on d.MSSV equals s.MSSV
                              where d.TrangThai == "Đã duyệt"
                              select s).ToList();

                    return sv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SinhVien ThongTinSVDangKiDeTai(string MaDT)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var sv = (from s in db.SinhViens
                              join d in db.DangKis
                              on s.MSSV equals d.MSSV
                              where d.MaDT == MaDT
                              select s).SingleOrDefault();
                              
                    return sv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
