using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class TraoDoiDAO
    {
        public static void Them(TraoDoi traoDoi)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    db.TraoDois.Add(traoDoi);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<TraoDoi> GetDataTraoDoi()
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    var listTraoDoi = (from s in db.TraoDois
                                       select s).ToList();
                    return listTraoDoi; 
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }
    }
}
