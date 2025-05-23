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
    
    public partial class Delay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delay()
        {
            this.DelayFromToes = new HashSet<DelayFromTo>();
        }
    
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public int Shift_Id { get; set; }
        public string ShiftName { get; set; }
        public string Warning_From { get; set; }
        public string Warning_To { get; set; }
        public string Allowed_Delay { get; set; }
        public Nullable<int> IsCreated { get; set; }
        public Nullable<int> IsUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DelayFromTo> DelayFromToes { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
