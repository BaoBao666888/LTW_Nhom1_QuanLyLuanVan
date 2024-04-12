using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class DangKi
    {
        private int maNhom;
        private string maDT;
        private DateTime thoiGianYeuCau;
        private string trangThaiDK;
        private string lyDoTuChoi;

        public DangKi() { }

        public DangKi(int maNhom, string maDT, DateTime thoiGianYeuCau, string trangThaiDK, string lyDoTuChoi)
        {
            this.maNhom = maNhom;
            this.maDT = maDT;
            this.thoiGianYeuCau = thoiGianYeuCau;
            this.trangThaiDK = trangThaiDK;
            this.lyDoTuChoi = lyDoTuChoi;
        }

        public int MaNhom { get =>  maNhom; set => maNhom = value; }

        public string MaDT { get => maDT; set => maDT = value; }

        public DateTime ThoiGianYeuCau {  get => thoiGianYeuCau; set => thoiGianYeuCau= value; }

        public string TrangThaiDK { get => trangThaiDK; set => trangThaiDK = value; }

        public string LyDoTuChoi {  get => lyDoTuChoi; set  => lyDoTuChoi = value;}
    }
}
