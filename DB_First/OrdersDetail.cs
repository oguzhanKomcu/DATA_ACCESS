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
    
    public partial class OrdersDetail
    {
        public int OrdersDetailsId { get; set; }
        public int OrdersId { get; set; }
        public Nullable<int> TiresId { get; set; }
        public Nullable<int> RimsId { get; set; }
        public Nullable<double> TiresUnitPrice { get; set; }
        public Nullable<double> RimsUnitPrice { get; set; }
        public Nullable<int> TireQuantity { get; set; }
        public Nullable<int> RimsQuantity { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<int> Total_Fee { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Rim Rim { get; set; }
        public virtual Tire Tire { get; set; }
    }
}
