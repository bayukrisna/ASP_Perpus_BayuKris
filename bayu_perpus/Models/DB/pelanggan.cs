//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bayu_perpus.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class pelanggan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pelanggan()
        {
            this.laporans = new HashSet<laporan>();
        }
    
        public int id_pelanggan { get; set; }
        public string no_id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_tlp1 { get; set; }
        public string no_tlp2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<laporan> laporans { get; set; }
    }
}
