using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class DangKiDAO
    {
        //kiểm tra sinh viên đã đăng kí đề tài chưa
        public static int KiemTraSinhVienDangki(string MSSV)
        {
            string sqlStr = string.Format($"select * from DangKi where MSSV = '{MSSV}' and (TrangThai = N'Đã duyệt' or TrangThai = N'Chờ duyệt')");
            return DbConnection.Load(sqlStr).Rows.Count;

        }

        //lấy thông tin sinh viên đăng kí theo MSGV
        public static DataTable ThongTinDangKiTheoMSGV(string MSGV)
        {
            string sqlStr = string.Format($"select * from DangKi inner join SinhVien on Sinhvien.MSSV = DangKi.MSSV inner join DeTai on DeTai.MaDT = DangKi.MaDT where MSGV ='{MSGV}'");
            return DbConnection.Load(sqlStr);
        }

        //lấy thông tin sinh viên đăng kí 
        public static DataTable ThongTinDangKi()
        {
            string sqlStr = string.Format("select * from DangKi inner join SinhVien on Sinhvien.MSSV = DangKi.MSSV");
            return DbConnection.Load(sqlStr);
        }

        //Giảng viên từ chối đăng kí đề tài
        public static void TuChoiDeTai(string MaDT, string lyDoTuChoi)
        {
            string sqlStr = string.Format($"update DangKiDeTai set TrangThai = N'Từ chối', LyDoTuChoi = N'{lyDoTuChoi}' where MaDT = '{MaDT}'");
            
        }

        //Giảng viên duyệt đề tài
        public static void DuyetDeTai(string MaDT)
        {
            string sqlStr = string.Format($"update DangKi set TrangThai = N'Đã duyệt' where MaDT = '{MaDT}'");
            DbConnection.Load(sqlStr);
        }


        //Kiểm tra số lượng đăng kí
        public static int SoLuongDangKi(string MaDT)
        {
            string sqlStr = string.Format($"select * from DangKi where MaDT = '{MaDT}' and (TrangThai = N'Đã duyệt' or TrangThai = N'Chờ duyệt')");
            return DbConnection.Load(sqlStr).Rows.Count;
       }

        //kiểm tra đề tài được đăng kí hay chưa
        public static DataTable KiemTraDangKi(string MaDT)
        {
            string sqlStr = string.Format($"select * from DangKi where MaDT = '{MaDT}'");
            return DbConnection.Load(sqlStr);
        }

        //thêm
        public static void DangKiDeTai(DangKi dangKi)
        {
            string sqlStr = string.Format("INSERT INTO DangKi(MSSV, MaDT, ThoiGianYeuCau, TrangThai) VALUES ('{0}', '{1}', '{2}', N'{3}')", dangKi.MSSV, dangKi.MaDT, dangKi.ThoiGianYeuCau.ToString("yyyy-MM-dd HH:mm:ss"), dangKi.TrangThai);
            DbConnection.ThucThi(sqlStr);
        }
    }
}
