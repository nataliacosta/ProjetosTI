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
    
    public partial class PARTICIPANTES
    {
        public int pessoa { get; set; }
        public int projeto { get; set; }
        public int tipo { get; set; }
    
        public virtual PESSOAS PESSOAS { get; set; }
        public virtual TIPO_PARTICIPANTE TIPO_PARTICIPANTE { get; set; }
    }
}
