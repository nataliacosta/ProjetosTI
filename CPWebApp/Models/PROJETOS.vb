'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace CPWebApp

    Partial Public Class PROJETOS
        Public Property id As Integer
        Public Property sistema As Integer
        Public Property responsavel As Integer
        Public Property aprovador As Nullable(Of Integer)
        Public Property aprovado_em As Nullable(Of Date)
        Public Property criado_em As Date
        Public Property titulo As String
        Public Property descricao As String
        Public Property solicitacao As Nullable(Of Integer)
        Public Property finalizado_em As Nullable(Of Date)
        Public Property status As String
    
        Public Overridable Property PESSOAS As PESSOAS
        Public Overridable Property PESSOAS1 As PESSOAS
        Public Overridable Property SISTEMAS As SISTEMAS
        Public Overridable Property SOLICITACOES As SOLICITACOES
    
    End Class

End Namespace
