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
    
    public partial class SOLICITACOES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOLICITACOES()
        {
            this.PROJETOS = new HashSet<PROJETOS>();
        }
    
        public int id { get; set; }
        public int sistema { get; set; }
        public int solicitante { get; set; }
        public Nullable<int> aprovador { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public System.DateTime criado_em { get; set; }
        public Nullable<System.DateTime> aprovado_em { get; set; }
        public string status { get; set; }
    
        public virtual PESSOAS PESSOAS { get; set; }
        public virtual PESSOAS PESSOAS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJETOS> PROJETOS { get; set; }
        public virtual SISTEMAS SISTEMAS { get; set; }
    }
}
