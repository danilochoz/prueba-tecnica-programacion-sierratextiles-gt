Imports DevExpress.Xpo

Public Class Programa
    Inherits Entity

#Region "Fields"
#End Region

#Region "Properties"
    <Key(True)>
    Public Property ProgramaID() As Integer
        Get
            Return Me.GetPropertyValue(NameOf(ProgramaID))
        End Get
        Set(ByVal value As Integer)
            Me.SetPropertyValue(NameOf(ProgramaID), value)
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Me.GetPropertyValue(NameOf(Descripcion))
        End Get
        Set(ByVal value As String)
            Me.SetPropertyValue(NameOf(Descripcion), value)
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
#End Region

End Class
