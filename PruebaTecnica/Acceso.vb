Imports DevExpress.Xpo

Public Class Acceso
    Inherits Entity

#Region "Fields"
#End Region

#Region "Properties"
    <Key(True)>
    Public Property AccesoID() As Integer
        Get
            Return Me.GetPropertyValue(NameOf(AccesoID))
        End Get
        Set(ByVal value As Integer)
            Me.SetPropertyValue(NameOf(AccesoID), value)
        End Set
    End Property

    Public Property Usuario() As Personal
        Get
            Return Me.GetPropertyValue(NameOf(Usuario))
        End Get
        Set(ByVal value As Personal)
            Me.SetPropertyValue(NameOf(Usuario), value)
        End Set
    End Property

    Public Property Programa() As Programa
        Get
            Return Me.GetPropertyValue(NameOf(Programa))
        End Get
        Set(ByVal value As Programa)
            Me.SetPropertyValue(NameOf(Programa), value)
        End Set
    End Property

    Public Property Insertar() As Boolean
        Get
            Return Me.GetPropertyValue(NameOf(Insertar))
        End Get
        Set(ByVal value As Boolean)
            Me.SetPropertyValue(NameOf(Insertar), value)
        End Set
    End Property

    Public Property Editar() As Boolean
        Get
            Return Me.GetPropertyValue(NameOf(Editar))
        End Get
        Set(ByVal value As Boolean)
            Me.SetPropertyValue(NameOf(Editar), value)
        End Set
    End Property

    Public Property Borrar() As Boolean
        Get
            Return Me.GetPropertyValue(NameOf(Borrar))
        End Get
        Set(ByVal value As Boolean)
            Me.SetPropertyValue(NameOf(Borrar), value)
        End Set
    End Property

    Public Property Buscar() As Boolean
        Get
            Return Me.GetPropertyValue(NameOf(Buscar))
        End Get
        Set(ByVal value As Boolean)
            Me.SetPropertyValue(NameOf(Buscar), value)
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
#End Region

End Class
