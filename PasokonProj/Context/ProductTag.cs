//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasokonProj.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductTag
    {
        public int ID { get; set; }
        public Nullable<int> TagID { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Tag Tag { get; set; }
    }
}