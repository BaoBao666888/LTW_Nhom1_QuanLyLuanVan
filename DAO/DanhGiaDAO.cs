using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class DanhGiaDAO
    {
        public static void DanhGia(DanhGia danhGia)
        {
            string sqlStr = string.Format($"insert into DanhGia(MaTask, NhanXet, Diem) values('{danhGia.MaTask}', N'{danhGia.NhanXet}', '{danhGia.Diem}')");
            DbConnection.ThucThi(sqlStr);
        }

        public static DanhGia GetObj(string maTask)
        {
            DanhGia obj = new DanhGia();
            string sqlStr = string.Format($"select * from DanhGia where MaTask = '{maTask}'");
            DataTable dt = DbConnection.Load(sqlStr);
            if(dt.Rows.Count > 0)
            {
                obj.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                obj.MaTask = dt.Rows[0]["MaTask"].ToString();
                obj.NhanXet = dt.Rows[0]["NhanXet"].ToString();
                obj.Diem = int.Parse(dt.Rows[0]["Diem"].ToString());
            }
            return obj;
        }
    }
}
