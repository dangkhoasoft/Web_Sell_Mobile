//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Ban_Dien_Thoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_NhaSanXuat
    {
        public tb_NhaSanXuat()
        {
            this.tb_DienThoai = new HashSet<tb_DienThoai>();
        }
    
        public int MaNSX { get; set; }
        public string TenNSX { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> DienThoai { get; set; }
    
        public virtual ICollection<tb_DienThoai> tb_DienThoai { get; set; }
    }
}
