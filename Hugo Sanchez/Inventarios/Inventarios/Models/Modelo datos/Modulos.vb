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

Partial Public Class Modulos
    Public Property GUIDModulo As System.Guid
    Public Property Nombre As String
    Public Property Activo As Boolean
    Public Property GUIDUsuarioAlta As System.Guid
    Public Property FechaAlta As Date
    Public Property GUIDUsuarioCambio As System.Guid
    Public Property FechaCambio As Date

    Public Overridable Property Permisos As ICollection(Of Permisos) = New HashSet(Of Permisos)

End Class
