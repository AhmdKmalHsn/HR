//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newHR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transfer
    {
        public int Id { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> FileNumber { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public string DeptFrom { get; set; }
        public string DeptTo { get; set; }
        public string IsCanceled { get; set; }
        public Nullable<bool> IsPromotion { get; set; }
        public string JobFrom { get; set; }
        public string JobTo { get; set; }
    }
}
