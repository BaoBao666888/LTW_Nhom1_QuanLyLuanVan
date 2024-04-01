using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van
{
    public class GiangVien : Person
    {
        private string mSGV;

        public GiangVien(string mSGV, string hoTen, string email, string soDienThoai, string maTK) : base(hoTen, email, soDienThoai, maTK)
        {
            this.mSGV = mSGV;
        }

        public string MSGV { get => this.mSGV; set => this.mSGV = value; }
    }

}
