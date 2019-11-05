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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("Projetos")]
    public partial class PROJETOS
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Sistema")]
        public int sistema { get; set; }

        [Display(Name = "Respons�vel")]
        public int responsavel { get; set; }

        [Display(Name = "Aprovado por")]
        public Nullable<int> aprovador { get; set; }

        [Display(Name = "Aprovado em")]
        public Nullable<System.DateTime> aprovado_em { get; set; }

        [Display(Name = "Criado em")]
        public System.DateTime criado_em { get; set; }

        [Display(Name = "T�tulo")]
        public string titulo { get; set; }

        [Display(Name = "Descri��o")]
        public string descricao { get; set; }

        [Display(Name = "Solicita��o")]
        public Nullable<int> solicitacao { get; set; }

        [Display(Name = "Finalizado em")]
        public Nullable<System.DateTime> finalizado_em { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }
    
        public virtual PESSOAS PESSOAS { get; set; }
        public virtual PESSOAS PESSOAS1 { get; set; }
        public virtual SISTEMAS SISTEMAS { get; set; }
        public virtual SOLICITACOES SOLICITACOES { get; set; }
    }
}
