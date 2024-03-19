using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVan
    {
        private string id;
        private string deTai;
        private char trangThai;
        private string moTa;
        private DateTime deadline;

        public LuanVan(string id, string deTai, char trangThai, string moTa, DateTime deadline)
        {
            this.id = id;
            this.deTai = deTai;
            this.trangThai = trangThai;
            this.moTa = moTa;
            this.deadline = deadline;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DeTai
        {
            get { return deTai; }
            set { deTai = value; }
        }
        public char TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

    }
}
