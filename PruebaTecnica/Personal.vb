Imports DevExpress.Xpo

Public Class Personal
    Inherits Entity

#Region "Fields"
#End Region

#Region "Properties"
    <Key(True)>
    Public Property PersonalID() As Integer
        Get
            Return Me.GetPropertyValue(NameOf(PersonalID))
        End Get
        Set(ByVal value As Integer)
            Me.SetPropertyValue(NameOf(PersonalID), value)
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return Me.GetPropertyValue(NameOf(Usuario))
        End Get
        Set(ByVal value As String)
            Me.SetPropertyValue(NameOf(Usuario), value)
        End Set
    End Property

    Public Property Apellido1() As String
        Get
            Return Me.GetPropertyValue(NameOf(Apellido1))
        End Get
        Set(ByVal value As String)
            Me.SetPropertyValue(NameOf(Apellido1), value)
        End Set
    End Property

    Public Property Apellido2() As String
        Get
            Return Me.GetPropertyValue(NameOf(Apellido2))
        End Get
        Set(ByVal value As String)
            Me.SetPropertyValue(NameOf(Apellido2), value)
        End Set
    End Property

    Public Property Nombre1() As String
        Get
            Return Me.GetPropertyValue(NameOf(Nombre1))
        End Get
        Set(ByVal value As String)
            Me.SetPropertyValue(NameOf(Nombre1), value)
        End Set
    End Property

    Public Property Nombre2() As String
        Get
            Return Me.GetPropertyValue(NameOf(Nombre2))
        End Get
        Set(ByVal value As String)
            Me.SetPropertyValue(NameOf(Nombre2), value)
        End Set
    End Property

    Public Property Habilitado() As Boolean
        Get
            Return Me.GetPropertyValue(NameOf(Habilitado))
        End Get
        Set(ByVal value As Boolean)
            Me.SetPropertyValue(NameOf(Habilitado), value)
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
#End Region

End Class
