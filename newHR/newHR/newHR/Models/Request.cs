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
    
    public partial class Request
    {
        public int Id { get; set; }
        public Nullable<int> requestType { get; set; }
        public Nullable<System.DateTime> dateFrom { get; set; }
        public Nullable<System.DateTime> dateTo { get; set; }
        public Nullable<double> daysNum { get; set; }
        public Nullable<System.TimeSpan> timeFrom { get; set; }
        public Nullable<System.TimeSpan> timeTo { get; set; }
        public Nullable<double> overtime { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<int> employeeId { get; set; }
        public Nullable<int> userEmp { get; set; }
        public Nullable<int> statusEmp { get; set; }
        public Nullable<System.DateTime> dateEmp { get; set; }
        public Nullable<int> userMgr { get; set; }
        public Nullable<int> statusMgr { get; set; }
        public Nullable<System.DateTime> dateMgr { get; set; }
        public Nullable<int> userHR { get; set; }
        public Nullable<int> statusHR { get; set; }
        public Nullable<System.DateTime> dateHR { get; set; }
    }
}
