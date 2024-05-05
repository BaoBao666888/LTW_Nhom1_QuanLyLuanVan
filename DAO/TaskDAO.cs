using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class TaskDAO
    {
        public static DataTable GetDataByMSSV(string MSSV, string filter)
        {
            string sqlStr = null;
            if (filter == "In progress")
            {
                sqlStr = string.Format($"select * from Task inner join DangKi on DangKi.MaDT = Task.MaDT where DangKi.MSSV = '{MSSV}' and DangKi.TrangThai = N'Đã duyệt' and Task.TyLeHoanThanh != 100 and Task.Deadline >= GETDATE()");
            }
            else
                if (filter == "Overdue")
            {
                sqlStr = string.Format($"select * from Task inner join DangKi on DangKi.MaDT = Task.MaDT where DangKi.MSSV = '{MSSV}' and DangKi.TrangThai = N'Đã duyệt' and Task.Deadline < GETDATE()");
            }
            else
                if (filter == "Completed")
            {
                sqlStr = string.Format($"select * from Task inner join DangKi on DangKi.MaDT = Task.MaDT where DangKi.MSSV = '{MSSV}' and DangKi.TrangThai = N'Đã duyệt' and Task.TyLeHoanThanh = 100");
            }
            else
                sqlStr = string.Format($"select * from Task inner join DangKi on DangKi.MaDT = Task.MaDT where DangKi.MSSV = '{MSSV}' and DangKi.TrangThai = N'Đã duyệt'");
            return DbConnection.Load(sqlStr);
        }

        public static DataTable GetDataByMSGV(string MSGV, string filter)
        {
            string sqlStr = null;
            if (filter == "In progress")
            {
                sqlStr = string.Format($"select * from Task inner join DeTai on DeTai.MaDT = Task.MaDT where DeTai.MSGV = '{MSGV}' and Task.TyLeHoanThanh != 100 and Task.Deadline >= GETDATE()");
            }
            else
                if (filter == "Overdue")
            {
                sqlStr = string.Format($"select * from Task inner join DeTai on DeTai.MaDT = Task.MaDT where DeTai.MSGV = '{MSGV}' and Task.Deadline < GETDATE()");
            }
            else 
                if (filter == "Completed")
            {
                sqlStr = string.Format($"select * from Task inner join DeTai on DeTai.MaDT = Task.MaDT where DeTai.MSGV = '{MSGV}' and Task.TyLeHoanThanh = 100");
            }
            else
                sqlStr = string.Format($"select * from Task inner join DeTai on DeTai.MaDT = Task.MaDT where DeTai.MSGV = '{MSGV}'");
            return DbConnection.Load(sqlStr);
        }


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

        public static void ThemTask(DTO.Task task)
        {
            string sqlStr = string.Format($"insert into Task values ('{task.MaTask}', '{task.MaDT}', N'{task.TenTask}', N'{task.MoTa}', 0, '{task.Deadline.ToString("yyyy-MM-dd")}')");
            DbConnection.ThucThi(sqlStr);
        }
    }
}
