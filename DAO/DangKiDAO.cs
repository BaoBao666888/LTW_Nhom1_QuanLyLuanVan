using Quan_Li_Luan_Van.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class DangKiDAO
    {
        //kiểm tra sinh viên đã đăng kí đề tài chưa
        public static bool SVChuaDangKi(string MSSV)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var count = (from s in db.DangKis
                                 where s.MSSV == MSSV
                                 select s).Count();
                    return count == 0 ;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //lấy thông tin sinh viên đăng kí theo MSGV
        public static List<DangKi> ThongTinDangKiTheoMSGV(string MSGV)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var dt = (from s in db.DangKis
                                 join d in db.DeTais
                                 on s.DeTai.MaDT equals d.MaDT
                                 where d.MSGV == MSGV
                                 && s.TrangThai == "Chờ duyệt"
                                 select s).ToList();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Giảng viên từ chối đăng kí đề tài
        public static void TuChoiDeTai(string MaDT, string lyDoTuChoi)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var deTai = db.DangKis.FirstOrDefault(x => x.MaDT == MaDT);
                    if (deTai != null)
                    {
                        deTai.TrangThai = "Từ chối";
                        deTai.LyDoTuChoi = lyDoTuChoi;
                        db.SaveChanges();
                        MessageBox.Show("Đã từ chối đăng kí này");
                    }
                    else
                    {
                        MessageBox.Show("Fail! Vui lòng kiếm tra lại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Giảng viên duyệt đề tài
        public static void DuyetDeTai(string MaDT)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var deTai = db.DangKis.FirstOrDefault(x => x.MaDT == MaDT);
                    if (deTai != null)
                    {
                        deTai.TrangThai = "Đã duyệt";
                        db.SaveChanges();
                        MessageBox.Show("Duyệt thành công");
                    }
                    else
                    {
                        MessageBox.Show("Fail! Vui lòng kiếm tra lại");
                    }    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //kiểm tra đề tài được đăng kí còn số lượng đki ko?
        public static bool ConDangKi(string MaDT, int soLuongToiDa)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var count = (from s in db.DangKis
                                 where s.MaDT == MaDT
                                 select s).Count();
                    return count < soLuongToiDa;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //lấy thông tin đề tài theo mã sinh viên đã đăng kí thành công
        public static DeTai GetDeTaiByMSSV(string MSSV)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var deTai = (from s in db.DangKis
                                 join d in db.DeTais
                                 on s.MaDT equals d.MaDT
                                 where s.MSSV == MSSV
                                 && s.TrangThai == "Đã duyệt"
                                 select d
                                 ).SingleOrDefault();
                    return deTai;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Đăng kí đề tài
        public static void DangKiDeTai(DangKi dangKi)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    db.DangKis.Add(dangKi);
                    db.SaveChanges();
                }
                MessageBox.Show("Đăng kí thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
