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
    
    public partial class EstimateEdition
    {
        public int EST_EditionID { get; set; }
        public Nullable<int> EST_PUBID { get; set; }
        public string Edition { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Total_Size { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Total_Cost { get; set; }
        public Nullable<decimal> Agency_Discount { get; set; }
        public Nullable<decimal> Total_NetCost { get; set; }
    
        public virtual EstimatePublication EstimatePublication { get; set; }
    }
}
