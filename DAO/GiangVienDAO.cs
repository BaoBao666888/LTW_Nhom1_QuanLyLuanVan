using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quan_Li_Luan_Van.DAO
{
    public class GiangVienDAO
    {
        public static GiangVien GetGVByMaTK(string maTK)
        {
            try
            {
                using(var db = new QLLuanVanEntities())
                {
                    var gv = (from s in db.GiangViens
                              where s.MaTK == maTK
                              select s
                              ).SingleOrDefault();
                    return gv;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            //string sqlStr = string.Format($"select * from GiangVien where MaTK = '{maTK}'");
            //DataTable dt = DbConnection.Load(sqlStr);
            //GiangVien gv = new GiangVien(dt.Rows[0]["MSGV"].ToString(), dt.Rows[0]["HoTen"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["MaTK"].ToString());
            //return gv;
        }

        public static GiangVien GetGVByMSGV(string mSGV)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    var gv = (from s in db.GiangViens
                              where s.MSGV == mSGV
                              select s
                              ).SingleOrDefault();
                    return gv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            //string sqlStr = string.Format($"select * from GiangVien where MaTK = '{mSGV}'");
            //DataTable dt = DbConnection.Load(sqlStr);
            //GiangVien gv = new GiangVien(dt.Rows[0]["MSGV"].ToString(), dt.Rows[0]["HoTen"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["MaTK"].ToString());
            //return gv;
        }
    }
}
