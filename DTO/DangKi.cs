using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class DangKi
    {
        private string mSSV;
        private string maDT;
        private DateTime thoiGianYeuCau;
        private string trangThai;
        private string lyDoTuChoi;

        public DangKi() { }
        
        public DangKi(string mSSV, string maDT, DateTime thoiGianYeuCau, string trangThai, string lyDoTuChoi)
        {
            this.mSSV = mSSV;
            this.maDT = maDT;
            this.thoiGianYeuCau = thoiGianYeuCau;
            this.trangThai = trangThai;
            this.lyDoTuChoi = lyDoTuChoi;
        }

        public string MSSV { get =>  this.mSSV;  set => this.mSSV = value; }

        public string MaDT { get => this.maDT; set => this.maDT = value; }

        public DateTime ThoiGianYeuCau { get => this.thoiGianYeuCau; set => this.thoiGianYeuCau = value; }

        public string TrangThai { get => this.trangThai; set => this.trangThai = value; }
        public string LyDoTuChoi { get => this.lyDoTuChoi; set => this.lyDoTuChoi = value; }
    }
}
