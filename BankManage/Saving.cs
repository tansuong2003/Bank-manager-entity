//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Saving
    {
        public string STK { get; set; }
        public string MaSo { get; set; }
        public Nullable<int> Money { get; set; }
        public string KyHan { get; set; }
        public string PhuongThucDaoHan { get; set; }
        public Nullable<System.DateTime> NgayGui { get; set; }
        public Nullable<System.DateTime> NgayDaoHan { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}