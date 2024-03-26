using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class LuanVan
    {
        private string maDeTai;
        private string tenDeTai;
        private string theLoai;
        private string moTa;
        private string congNghe;
        private string yeuCau;
        private int soLuongSV;
        private int soLuongMax;
    
        public LuanVan(string maDeTai, string tenDeTai, string theLoai, string moTa, string congNghe, string yeuCau, int soLuongSV, int soLuongMax)
        {
            this.maDeTai = maDeTai;
            this.tenDeTai = tenDeTai;
            this.theLoai = theLoai;
            this.moTa = moTa;
            this.congNghe = congNghe;
            this.yeuCau = yeuCau;
            this.soLuongSV = soLuongSV;
            this.soLuongMax = soLuongMax;
        }

        public string MadeTai { get { return maDeTai; } }
        public string TenDeTai { get { return tenDeTai; } }
        public string TheLoai { get { return theLoai; } }
        public string MoTa { get {  return moTa; } }
        public string CongNghe { get {  return congNghe; } }
        public string YeuCau { get {  return yeuCau; } }
        public int SoLuongSV { get {  return soLuongSV; } }
        public int SoLuongMax { get {  return soLuongMax; } }

    }
}
