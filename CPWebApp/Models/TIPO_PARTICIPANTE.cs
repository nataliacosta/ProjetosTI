//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_PARTICIPANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_PARTICIPANTE()
        {
            this.PARTICIPANTES = new HashSet<PARTICIPANTES>();
        }
    
        public int id { get; set; }
        public string titulo { get; set; }
        public Nullable<bool> insere_documentos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTICIPANTES> PARTICIPANTES { get; set; }
    }
}
