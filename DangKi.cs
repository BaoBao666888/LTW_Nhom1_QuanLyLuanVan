//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Li_Luan_Van
{
    using System;
    using System.Collections.Generic;
    
    public partial class DangKi
    {
        public string MSSV { get; set; }
        public string MaDT { get; set; }
        public System.DateTime ThoiGianYeuCau { get; set; }
        public string TrangThai { get; set; }
        public string LyDoTuChoi { get; set; }
    
        public virtual DeTai DeTai { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
