//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstimateCreator.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EstimateHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstimateHeader()
        {
            this.EstimatePublications = new HashSet<EstimatePublication>();
        }
    
        public int EST_ID { get; set; }
        public string EST_NO { get; set; }
        public Nullable<System.DateTime> EST_Date { get; set; }
        public string Campaign { get; set; }
        public string Agency { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<System.DateTime> PeriodFrom { get; set; }
        public Nullable<System.DateTime> PeriodTO { get; set; }
        public Nullable<int> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstimatePublication> EstimatePublications { get; set; }
    }
}