using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class DocumentDAO
    {
        public static void UpdateFile(Document doc)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var file = db.Documents.FirstOrDefault(x => x.IDFile == doc.IDFile);
                    if (file == null)
                    {
                        file.MoTa = doc.MoTa;
                        file.Task = doc.Task;
                        file.Data = doc.Data;
                        file.Extension = doc.Extension;
                        file.ThoiGianUp = doc.ThoiGianUp;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }
        }

        public static void ReadFile(Document doc)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var file = (from d in db.Documents
                                where d.MaTask == doc.MaTask
                                select d).SingleOrDefault();
                    var newFile = file.IDFile.Replace(file.Extension, DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")) + file.Extension;
                    File.WriteAllBytes(newFile, doc.Data);
                    Process.Start(newFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }
        }

        public static void SaveFile(Document doc)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    db.Documents.Add(doc);
                    db.SaveChanges();
                    MessageBox.Show("Lưu thành công");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public static Document GetObjectByMaTask(string MaTask)
        {
                using (var db = new QLLuanVanContext())
                {
                    var doc = db.Documents.Where(x => x.MaTask == MaTask).FirstOrDefault();
                    return doc;
                }
        }
    }
}
