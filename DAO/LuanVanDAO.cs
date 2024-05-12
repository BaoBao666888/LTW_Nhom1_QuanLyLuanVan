using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;
using Quan_Li_Luan_Van.GUI;

namespace Quan_Li_Luan_Van.DAO
{
    public class LuanVanDAO
    {
        // lấy tất cả task theo mã đt
        public static List<DanhGia> GetListTask(string MaDT)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                                join d in db.Tasks
                                on s.MaDT equals d.MaDT
                                join t in db.DanhGias
                                on d.MaTask equals t.MaTask
                                where s.MaDT == MaDT
                                select t
                                 ).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            //string sqlStr = string.Format($"select * from DeTai inner join Task on DeTai.MaDT = Task.MaDT inner join DanhGia on DanhGia.MaTask = Task.MaTask where DeTai.MaDT ='{MaDT}'");
            //return DbConnection.Load(sqlStr);
        }

        public static List<DeTai> GetListDeTaiByMSSV(string MSSV)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                                 join d in db.DangKis
                                 on s.MaDT equals d.MaDT
                                 where d.MSSV == MSSV
                                 && d.TrangThai == "Đã duyệt" 
                                 select s
                                 ).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DeTai GetDeTaiBYMaDT(string MaDT)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var lv = (from s in db.DeTais
                              where s.MaDT == MaDT
                              select s).SingleOrDefault();
                    return lv;
                }
            }
            catch(Exception e)
            {                
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<DeTai> GetListDeTaiByMaDT(string MaDT)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                              where s.MaDT == MaDT
                              select s).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Danh sach luan van theo ma giao vien
        public static List<DeTai> GetDSDeTaiByMSGV(string MSGV)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                                where s.MSGV == MSGV
                                select s
                                ).ToList();
                    return list;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Danh sach luan van
        public static List<DeTai> GetListDeTai()
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                                select s
                                ).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Them
        public static void Them(DeTai luanVan)
        {
            using(var Context = new QLLuanVanContext())
            {
                Context.DeTais.Add(luanVan);
                Context.SaveChanges();
            }
            MessageBox.Show("Them Thanh Cong");
        }


        //Xoa

        public static void Xoa(string maDeTai)
        {
            try
            {
                using (var Context = new QLLuanVanContext())
                {
                    var lv = (from s in Context.DeTais
                              where s.MaDT == maDeTai
                              select s).SingleOrDefault();

                    Context.DeTais.Remove(lv);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //TimKiem

        public static List<DeTai> TimKiem(string input)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                                where s.MSGV == input
                                || s.MaDT == input
                                || s.TenDeTai == input
                                || s.TheLoai == input
                                || s.YeuCau == input
                                select s
                                ).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static List<DeTai> TimKiem(string MSGV, string input)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var list = (from s in db.DeTais
                                where s.MSGV ==MSGV
                                && (s.MaDT == input
                                || s.TenDeTai == input
                                || s.TheLoai == input
                                || s.YeuCau == input)
                                select s
                                ).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
