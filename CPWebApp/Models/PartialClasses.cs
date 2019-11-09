using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CPWebApp.Models
{
    [MetadataType(typeof(PARTICIPANTESMetadata))]
    public partial class PARTICIPANTES
    {
    }
    
    [MetadataType(typeof(PESSOASMetadata))]
    [DisplayColumn("nome")]
    public partial class PESSOAS
    {
    }

    [MetadataType(typeof(PROJETOSMetadata))]
    [DisplayColumn("titulo")]
    public partial class PROJETOS
    {
    }

    [MetadataType(typeof(RECURSOSMetadata))]
    public partial class RECURSOS
    {
    }

    [MetadataType(typeof(SISTEMASMetadata))]
    [DisplayColumn("nome")]
    public partial class SISTEMAS
    {
    }

    [MetadataType(typeof(SOLICITACOESMetadata))]
    [DisplayColumn("id")]
    public partial class SOLICITACOES
    {
    }

    [MetadataType(typeof(TIPO_PARTICIPANTEMetadata))]
    [DisplayColumn("titulo")]
    public partial class TIPO_PARTICIPANTE
    {
    }

    [MetadataType(typeof(TIPO_RECURSOMetadata))]
    [DisplayColumn("titulo")]
    public partial class TIPO_RECURSO
    {
    }
}