using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class LuanVan
    {
        private string maDeTai;
        private string tenDeTai;
        private string theLoai;
        private string moTa;
        private string congNghe;
        private string yeuCau;
        private string chucNang;
        private string mSGV;
    
        public LuanVan(string maDeTai, string tenDeTai, string theLoai, string moTa, string congNghe, string yeuCau, string chucNang, string MSGV)
        {
            this.maDeTai = maDeTai;
            this.tenDeTai = tenDeTai;
            this.theLoai = theLoai;
            this.moTa = moTa;
            this.congNghe = congNghe;
            this.yeuCau = yeuCau;
            this.chucNang = chucNang;
            this.mSGV = MSGV;
        }

        public string MadeTai { get => this.maDeTai; set => this.maDeTai = value; }
        public string TenDeTai { get => this.tenDeTai; set => this.tenDeTai = value; }
        public string TheLoai { get => this.theLoai; set => this.theLoai = value; }
        public string MoTa { get => this.moTa; set => this.moTa = value; }
        public string CongNghe { get => this.congNghe; set => this.congNghe = value; }
        public string YeuCau { get => this.yeuCau; set => this.yeuCau = value; }
        public string ChucNang { get => this.chucNang; set => this.chucNang = value; }
        public string MSGV { get => this.mSGV; set => this.mSGV = value; }
    }
}
