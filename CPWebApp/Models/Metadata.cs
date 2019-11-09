using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CPWebApp.Models
{
    public class PARTICIPANTESMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Pessoa")]
        public int pessoa { get; set; }

        [Display(Name = "Projeto")]
        public int projeto { get; set; }

        [Display(Name = "Tipo")]
        public int tipo { get; set; }
        
        [Display(Name = "Pessoa")]
        public virtual PESSOAS PESSOAS { get; set; }

        [Display(Name = "Projeto")]
        public virtual PROJETOS PROJETOS { get; set; }

        [Display(Name = "Tipo de Participante")]
        public virtual TIPO_PARTICIPANTE TIPO_PARTICIPANTE { get; set; }
    }

    public class PESSOASMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Gestor")]
        public Nullable<int> gestor { get; set; }

        [DisplayName("ID Externo")]
        public string id_externo { get; set; }

        [DisplayName("Gestor")]
        public virtual PESSOAS PESSOAS2 { get; set; }
    }

    public class PROJETOSMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Sistema")]
        public int sistema { get; set; }

        [Display(Name = "Responsável")]
        public int responsavel { get; set; }

        [Display(Name = "Avaliado por")]
        public Nullable<int> aprovador { get; set; }

        [Display(Name = "Avaliado em")]
        public Nullable<System.DateTime> aprovado_em { get; set; }

        [Display(Name = "Criado em")]
        public Nullable<System.DateTime> criado_em { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Display(Name = "Solicitação")]
        public Nullable<int> solicitacao { get; set; }

        [Display(Name = "Finalizado em")]
        public Nullable<System.DateTime> finalizado_em { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Responsável")]
        public virtual PESSOAS PESSOAS { get; set; }

        [Display(Name = "Avaliado por")]
        public virtual PESSOAS PESSOAS1 { get; set; }

        [Display(Name = "Sistema")]
        public virtual SISTEMAS SISTEMAS { get; set; }

        [Display(Name = "Solicitação")]
        public virtual SOLICITACOES SOLICITACOES { get; set; }
    }

    public class RECURSOSMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Pessoa")]
        public int pessoa { get; set; }

        [Display(Name = "Sistema")]
        public int sistema { get; set; }

        [Display(Name = "Tipo de Recurso")]
        public int tipo { get; set; }

        [Display(Name = "Pessoa")]
        public virtual PESSOAS PESSOAS { get; set; }

        [Display(Name = "Sistema")]
        public virtual SISTEMAS SISTEMAS { get; set; }

        [Display(Name = "Tipo de Recurso")]
        public virtual TIPO_RECURSO TIPO_RECURSO { get; set; }
    }

    public class SISTEMASMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }
    }

    public class SOLICITACOESMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Sistema")]
        public int sistema { get; set; }

        [Display(Name = "Solicitante")]
        public int solicitante { get; set; }

        [Display(Name = "Avaliada por")]
        public Nullable<int> aprovador { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Display(Name = "Criada em")]
        public Nullable<System.DateTime> criado_em { get; set; }

        [Display(Name = "Avaliada em")]
        public Nullable<System.DateTime> aprovado_em { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Solicitante")]
        public virtual PESSOAS PESSOAS { get; set; }

        [Display(Name = "Avaliada por")]
        public virtual PESSOAS PESSOAS1 { get; set; }

        [Display(Name = "Sistema")]
        public virtual SISTEMAS SISTEMAS { get; set; }
    }

    public class TIPO_PARTICIPANTEMetadata
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Insere documentos?")]
        public Nullable<bool> insere_documentos { get; set; }
    }

    public class TIPO_RECURSOMetadata
    {
        [Display(Name = "ID")]
        
        public int id { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Cria solicitação?")]
        public Nullable<bool> cria_solicitacao { get; set; }

        [Display(Name = "Cria projeto?")]
        public Nullable<bool> cria_projeto { get; set; }

        [Display(Name = "Aprova solicitação?")]
        public Nullable<bool> aprova_solicitacao { get; set; }

        [Display(Name = "Aprova projeto?")]
        public Nullable<bool> aprova_projeto { get; set; }

        [Display(Name = "É administrador?")]
        public Nullable<bool> administrador { get; set; }
    }
}