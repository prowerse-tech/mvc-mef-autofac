//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Approach1.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductCategoryAttribute
    {
        public int ProductCategoryAttributeId { get; set; }
        public int AttributeId { get; set; }
        public int ProductCategoryId { get; set; }
    
        public virtual Attribute Attribute { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
