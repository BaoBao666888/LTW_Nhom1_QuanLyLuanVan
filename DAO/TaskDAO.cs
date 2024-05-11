using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class TaskDAO
    {
        public static List<Task> GetDataByMSSV(string MSSV, string filter)
        {

            try
            {
                using(var db = new QLLuanVanEntities())
                {
                    List<Task> newTask;
                    if (filter == "In progress")
                        newTask = (from t in db.Tasks
                                   join d in db.DangKis
                                   on t.MaDT equals d.MaDT
                                   where d.MSSV == MSSV
                                   && d.TrangThai == "Đã duyệt"
                                   && t.TyLeHoanThanh != 100
                                   && t.Deadline >= DateTime.Now
                                   select t).ToList();
                    else
                        if (filter == "Overdue")
                            newTask = (from t in db.Tasks
                                       join d in db.DangKis
                                       on t.MaDT equals d.MaDT
                                       where d.MSSV == MSSV
                                       && d.TrangThai == "Đã duyệt"
                                       && t.TyLeHoanThanh != 100
                                       && t.Deadline < DateTime.Now
                                       select t).ToList();
                        else
                            if (filter == "Completed")
                                newTask = (from t in db.Tasks
                                           join d in db.DangKis
                                           on t.MaDT equals d.MaDT
                                           where d.MSSV == MSSV
                                           && d.TrangThai == "Đã duyệt"
                                           && t.TyLeHoanThanh == 100
                                           select t).ToList();
                            else
                                newTask = (from t in db.Tasks
                                           join d in db.DangKis
                                           on t.MaDT equals d.MaDT
                                           where d.MSSV == MSSV
                                           && d.TrangThai == "Đã duyệt"
                                           select t).ToList();

                    return newTask;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static List<Task> GetDataByMSGV(string MSGV, string filter)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    List<Task> newTask;
                    if (filter == "In progress")
                        newTask = (from t in db.Tasks
                                   join d in db.DeTais
                                   on t.MaDT equals d.MaDT
                                   where d.MSGV == MSGV
                                   && t.TyLeHoanThanh != 100
                                   && t.Deadline >= DateTime.Now
                                   select t).ToList();
                    else
                        if (filter == "Overdue")
                        newTask = (from t in db.Tasks
                                   join d in db.DeTais
                                   on t.MaDT equals d.MaDT
                                   where d.MSGV == MSGV
                                   && t.TyLeHoanThanh != 100
                                   && t.Deadline < DateTime.Now
                                   select t).ToList();
                    else
                            if (filter == "Completed")
                        newTask = (from t in db.Tasks
                                   join d in db.DeTais
                                   on t.MaDT equals d.MaDT
                                   where d.MSGV == MSGV
                                   && t.TyLeHoanThanh == 100
                                   select t).ToList();
                    else
                        newTask = (from t in db.Tasks
                                   join d in db.DeTais
                                   on t.MaDT equals d.MaDT
                                   where d.MSGV == MSGV
                                   select t).ToList();

                    return newTask;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        public static void ThemTask(Task task)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateTask(Task task)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
                {
                    var newTask = db.Tasks.FirstOrDefault(x => x.MaTask == task.MaTask);

                    if (newTask != null)
                    {
                        newTask.TyLeHoanThanh = task.TyLeHoanThanh;
                        db.SaveChanges();
                        MessageBox.Show("Update task thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại, vui lòng kiểm tra lại!");
                    }    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
