using System;
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
                using(var db = new QLLuanVanEntities())
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

            //string sqlStr = string.Format($"select * from SinhVien where MaTK = '{maTK}'");
            //DataTable dt = DbConnection.Load(sqlStr);
            //SinhVien sv = new SinhVien(dt.Rows[0]["MSSV"].ToString(), dt.Rows[0]["HoTen"].ToString(), dt.Rows[0]["Lop"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["MaTK"].ToString());
            //return sv;
        }
    }
}
