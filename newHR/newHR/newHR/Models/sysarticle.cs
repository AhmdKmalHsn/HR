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
    
    public partial class sysarticle
    {
        public int artid { get; set; }
        public string creation_script { get; set; }
        public string del_cmd { get; set; }
        public string description { get; set; }
        public string dest_table { get; set; }
        public int filter { get; set; }
        public string filter_clause { get; set; }
        public string ins_cmd { get; set; }
        public string name { get; set; }
        public int objid { get; set; }
        public int pubid { get; set; }
        public byte pre_creation_cmd { get; set; }
        public byte status { get; set; }
        public int sync_objid { get; set; }
        public byte type { get; set; }
        public string upd_cmd { get; set; }
        public byte[] schema_option { get; set; }
        public string dest_owner { get; set; }
        public Nullable<int> ins_scripting_proc { get; set; }
        public Nullable<int> del_scripting_proc { get; set; }
        public Nullable<int> upd_scripting_proc { get; set; }
        public string custom_script { get; set; }
        public bool fire_triggers_on_snapshot { get; set; }
    }
}
