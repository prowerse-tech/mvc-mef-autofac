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
    
    public partial class TitleSystemMapping
    {
        public int TitleSystemMappingId { get; set; }
        public string SystemReferenceValue { get; set; }
        public int AdminTitleId { get; set; }
        public int SystemReferenceId { get; set; }
        public int CreatedByUserId { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        public virtual SystemReference SystemReference { get; set; }
        public virtual Title Title { get; set; }
    }
}
