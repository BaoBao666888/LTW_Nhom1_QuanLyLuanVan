using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    internal class SinhVienDAO : DAO
    {
        DAO classDAO = new DAO();
        public DataTable Load()
        {
            string sqlStr = string.Format("Select *from SinhVien");
            return classDAO.Load(sqlStr);
        }
    }
}
