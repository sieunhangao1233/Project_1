//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Đồ_Án_1.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIET_HDN
    {
        public string HoaDonNhapID { get; set; }
        public string nguyenlieuID { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<int> DonGia { get; set; }
    
        public virtual HoaDonNhap HoaDonNhap { get; set; }
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
    }
}
