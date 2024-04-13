using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class TaiKhoan
    {
        private string maTK;
        private string tenDangNhap;
        private string matKhau;
        private string vaiTro;
        private string trangThai;

        public TaiKhoan() { }

        public TaiKhoan(string maTK, string tenDangNhap, string matKhau, string vaiTro, string trangThai)
        {
            this.maTK = maTK;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.vaiTro = vaiTro;
            this.trangThai = trangThai;
        }

        public string MaTK { get => this.maTK; set => this.maTK = value; }
        public string TenDangNhap {  get => this.tenDangNhap; set => this.tenDangNhap = value; }

        public string MatKhau {  get => this.matKhau; set => this.matKhau = value; }
        public string VaiTro {  get => this.vaiTro; set => this.vaiTro = value; }
        public string TrangThai {  get => this.trangThai; set => this.trangThai = value; }

    }
}
