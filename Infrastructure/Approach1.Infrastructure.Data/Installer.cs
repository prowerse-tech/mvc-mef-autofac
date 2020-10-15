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
    
    public partial class Installer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Installer()
        {
            this.FitmentCentreProviderMappings = new HashSet<FitmentCentreProviderMapping>();
            this.ProviderSpecificChases = new HashSet<ProviderSpecificChase>();
            this.ProviderSpecificNetstars = new HashSet<ProviderSpecificNetstar>();
            this.ProviderSpecificOnAirs = new HashSet<ProviderSpecificOnAir>();
        }
    
        public int InstallerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public Nullable<int> CreatedByUserId_ { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FitmentCentreProviderMapping> FitmentCentreProviderMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecificChase> ProviderSpecificChases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecificNetstar> ProviderSpecificNetstars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecificOnAir> ProviderSpecificOnAirs { get; set; }
    }
}
