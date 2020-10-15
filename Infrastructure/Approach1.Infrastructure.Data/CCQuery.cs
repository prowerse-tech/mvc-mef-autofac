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
    
    public partial class CCQuery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CCQuery()
        {
            this.QACCQueries = new HashSet<QACCQuery>();
        }
    
        public int CCQueryID { get; set; }
        public System.DateTime QueryDate { get; set; }
        public int OrderId { get; set; }
        public int CCQuestionId { get; set; }
        public string Action { get; set; }
        public int UserId { get; set; }
        public string RecordingFilename { get; set; }
    
        public virtual CCQuestion CCQuestion { get; set; }
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QACCQuery> QACCQueries { get; set; }
    }
}
