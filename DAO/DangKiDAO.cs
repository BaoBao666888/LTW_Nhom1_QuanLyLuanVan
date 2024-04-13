using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class DangKiDAO
    {

        public static void Them(DangKi dangKi)
        {
            string sqlStr = string.Format("INSERT INTO DangKi(MaNhom, MaDT, ThoiGianYeuCau, TrangThaiDK) VALUES ('{0}', '{1}', '{2}', N'{3}')", dangKi.MaNhom, dangKi.MaDT, dangKi.ThoiGianYeuCau, dangKi.TrangThaiDK);
            DbConnection.ThucThi(sqlStr);
        }
    }
}
