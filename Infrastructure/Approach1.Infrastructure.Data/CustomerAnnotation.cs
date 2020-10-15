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
    
    public partial class CustomerAnnotation
    {
        public int CustomerAnnotationId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public System.DateTime AnnotationDate { get; set; }
        public string Details { get; set; }
        public int AnnotationTypeId { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}