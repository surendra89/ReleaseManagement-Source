//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReleaseManagement.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLReleaseEntry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLReleaseEntry()
        {
            this.TBLReleaseEntryDetails = new HashSet<TBLReleaseEntryDetail>();
        }
    
        public int ReleaseID { get; set; }
        public int BuildNo { get; set; }
        public int EnvironmentID { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public int ReleaseBy { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual TBLEnvironmentMaster TBLEnvironmentMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLReleaseEntryDetail> TBLReleaseEntryDetails { get; set; }
        public virtual TBLReleaseMaster TBLReleaseMaster { get; set; }
    }
}
