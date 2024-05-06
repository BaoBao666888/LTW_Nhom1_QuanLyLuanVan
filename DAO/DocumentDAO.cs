using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Quan_Li_Luan_Van.DAO
{
    public class DocumentDAO
    {
        public static void UpdateFile(Document doc)
        {
            try
            {
                DbConnection.conn.Open();
                SqlCommand cmd = new SqlCommand("Update Document set MoTa = @MoTa, ThoiGianUp = @ThoiGianUp, Data = @Data, Extension = @Extension where MaTask = @MaTask", DbConnection.conn);
                cmd.Parameters.Add("@MaTask", SqlDbType.VarChar).Value = doc.MaTask;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = doc.MoTa;
                cmd.Parameters.Add("@ThoiGianUp", SqlDbType.DateTime).Value = doc.ThoiGianUp.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = doc.Data;
                cmd.Parameters.Add("@Extension", SqlDbType.Char).Value = doc.Extension;
                cmd.ExecuteNonQuery();
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
                DbConnection.conn.Open();
                string sqlStr = string.Format($"select * from Document where MaTask = '{doc.MaTask}'");
                SqlCommand cmd = new SqlCommand(sqlStr, DbConnection.conn);
                var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    var name = "file";
                    var data = (byte[])reader["data"];
                    var extension = reader["Extension"].ToString();
                    var newFile = name.Replace(extension, DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")) + extension;
                    File.WriteAllBytes(newFile, data);  
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
                    DbConnection.conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Document(IDFile, MaTask, MoTa, ThoiGianUp, Data, Extension) values (@IDFile, @MaTask, @MoTa, @ThoiGianUp, @Data, @Extension)", DbConnection.conn);
                    cmd.Parameters.Add("@IDFile", SqlDbType.VarChar).Value = doc.IdFile;
                    cmd.Parameters.Add("@MaTask", SqlDbType.VarChar).Value = doc.MaTask;
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = doc.MoTa;
                    cmd.Parameters.Add("@ThoiGianUp", SqlDbType.DateTime).Value = doc.ThoiGianUp.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = doc.Data;
                    cmd.Parameters.Add("@Extension", SqlDbType.Char).Value = doc.Extension;
                    cmd.ExecuteNonQuery();
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

        public static DataTable GetDataTable()
        {
            string sqlStr = string.Format("select IDFile, MaTask, MoTa, ThoiGianUp, Extension from Document");
            return DbConnection.Load(sqlStr);
        }

        public static Document GetObjectByMaTask(string MaTask)
        {
            string sqlStr = string.Format($"select IDFile, MaTask, MoTa, ThoiGianUp, Extension from Document where MaTask = '{MaTask}'");
            DataTable dt = DbConnection.Load(sqlStr);
            Document doc = new Document();
            if(dt.Rows.Count > 0)
            {
                doc.IdFile = dt.Rows[0]["IDFile"].ToString();
                doc.MaTask = dt.Rows[0]["MaTask"].ToString();
                doc.MoTa = dt.Rows[0]["MoTa"].ToString();
                doc.ThoiGianUp = DateTime.Parse(dt.Rows[0]["ThoiGianUp"].ToString());
                doc.Extension = dt.Rows[0]["Extension"].ToString();
            }

            return doc;
            
        }

        public static void DeleteFile(Document doc)
        {

        }

    }
}
