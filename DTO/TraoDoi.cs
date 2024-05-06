using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class TraoDoi
    {
        private string mssv;
        private string chuDe;
        private string thongTin;
        private DateTime thoiGian;
        private string msgv;
        public TraoDoi() { }
        public TraoDoi(string mssv, string chuDe, string thongTin, DateTime thoiGian, string msgv)
        {
            this.mssv = mssv;
            this.chuDe = chuDe;
            this.thongTin = thongTin;
            this.thoiGian = thoiGian;
            this.msgv = msgv;
        }

        public string MSSV { get => this.mssv; set => this.mssv = value; }
        public string ChuDe { get => this.chuDe; set => this.chuDe = value;}
        public string ThongTin { get => this.thongTin; set => this.thongTin = value;}
        public DateTime ThoiGian { get => this.thoiGian; set => this.thoiGian = value;}
        public string MSGV { get => this.msgv; set => this.msgv = value; }
    }
}
