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
    
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> IsCreated { get; set; }
        public Nullable<int> IsUpdated { get; set; }
        public string FullName { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> MaritalStatus { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Image { get; set; }
        public Nullable<int> Home_Id { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Home Home { get; set; }
        public virtual Role Role { get; set; }
    }
}
