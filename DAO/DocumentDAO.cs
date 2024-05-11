using System;
using System.Data;
using System.Diagnostics;
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
                using (var db = new QLLuanVanEntities())
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
                using (var db = new QLLuanVanEntities())
                {
                    var file = (from d in db.Documents
                                where d.MaTask == doc.MaTask
                                select d).SingleOrDefault();
                    var newFile = file.IDFile.Replace(file.Extension, DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")) + file.Extension;
                    Process.Start(newFile);
                }
                //DbConnection.conn.Open();
                //string sqlStr = string.Format($"select * from Document where MaTask = '{doc.MaTask}'");
                //SqlCommand cmd = new SqlCommand(sqlStr, DbConnection.conn);
                //var reader = cmd.ExecuteReader();
                //if(reader.Read())
                //{
                //    var name = "file";
                //    var data = (byte[])reader["data"];
                //    var extension = reader["Extension"].ToString();
                //    var newFile = name.Replace(extension, DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")) + extension;
                //    File.WriteAllBytes(newFile, data);  
                //    Process.Start(newFile);
                //}
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
                using (var db = new QLLuanVanEntities())
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

            //try
            //{
            //    DbConnection.conn.Open();
            //    SqlCommand cmd = new SqlCommand("Insert into Document(IDFile, MaTask, MoTa, ThoiGianUp, Data, Extension) values (@IDFile, @MaTask, @MoTa, @ThoiGianUp, @Data, @Extension)", DbConnection.conn);
            //    cmd.Parameters.Add("@IDFile", SqlDbType.VarChar).Value = doc.IdFile;
            //    cmd.Parameters.Add("@MaTask", SqlDbType.VarChar).Value = doc.MaTask;
            //    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = doc.MoTa;
            //    cmd.Parameters.Add("@ThoiGianUp", SqlDbType.DateTime).Value = doc.ThoiGianUp.ToString("yyyy-MM-dd HH:mm:ss");
            //    cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = doc.Data;
            //    cmd.Parameters.Add("@Extension", SqlDbType.Char).Value = doc.Extension;
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    DbConnection.conn.Close();
            //}
        }


        public static Document GetObjectByMaTask(string MaTask)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    var doc = (from d in db.Documents
                               where d.MaTask == MaTask
                               select d).SingleOrDefault();
                    return doc;
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
