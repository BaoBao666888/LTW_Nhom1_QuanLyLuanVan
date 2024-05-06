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

namespace Quan_Li_Luan_Van.DAO
{
    public class DocumentDAO
    {
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

        public static void DeleteFile(Document doc)
        {

        }

    }
}
