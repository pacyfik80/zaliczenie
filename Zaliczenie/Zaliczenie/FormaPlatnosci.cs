//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zaliczenie
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormaPlatnosci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormaPlatnosci()
        {
            this.Platnosc = new HashSet<Platnosc>();
        }
    
        public long idFormaPlatnosci { get; set; }
        public string nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Platnosc> Platnosc { get; set; }
    }
}
