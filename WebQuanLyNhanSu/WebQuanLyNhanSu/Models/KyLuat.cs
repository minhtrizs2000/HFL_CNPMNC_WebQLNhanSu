//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KyLuat
    {
        public int IDKL { get; set; }
        public Nullable<int> IDLoaiKL { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> IDNV { get; set; }
    
        public virtual LoaiKyLuat LoaiKyLuat { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}