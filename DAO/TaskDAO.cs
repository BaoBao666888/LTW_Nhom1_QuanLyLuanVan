using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class TaskDAO
    {

        public static DataTable GetData()
        {
            string sqlStr = string.Format("select * from Task");
            return DbConnection.Load(sqlStr);
        }

        public static DTO.Task getDataByMaTask(string MaTask)
        {   
            string sqlStr = string.Format($"select * from Task where Task.MaTask = '{MaTask}'");
            DataTable dt = DbConnection.Load(sqlStr);
            return new DTO.Task(MaTask, dt.Rows[0]["MaDT"].ToString(), dt.Rows[0]["TenTask"].ToString(), dt.Rows[0]["MoTa"].ToString(), int.Parse(dt.Rows[0]["TyLeHoanThanh"].ToString()), DateTime.Parse(dt.Rows[0]["Deadline"].ToString()));   
        }
    }
}
