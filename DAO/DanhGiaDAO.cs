using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class DanhGiaDAO
    {
        public static void DanhGia(DanhGia danhGia)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    db.DanhGias.Add(danhGia);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DanhGia GetObj(string maTask)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var danhGia = db.DanhGias.FirstOrDefault(x => x.MaTask == maTask);
                    return danhGia;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
