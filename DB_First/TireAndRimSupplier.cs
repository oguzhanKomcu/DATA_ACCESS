//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class TireAndRimSupplier
    {
        public int TireAndRimSuppliersId { get; set; }
        public Nullable<int> SuppliersId { get; set; }
        public Nullable<int> TiresId { get; set; }
        public Nullable<int> RimsId { get; set; }
    
        public virtual Rim Rim { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Tire Tire { get; set; }
    }
}
