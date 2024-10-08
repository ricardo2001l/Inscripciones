Public Class Eusuario
    Private nombreUsuario, contrasena, admin As String

    Public Property _nombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property _contrasena As String
        Get
            Return contrasena
        End Get
        Set(ByVal value As String)
            contrasena = value
        End Set
    End Property
    Public Property _admin As String
        Get
            Return admin
        End Get
        Set(ByVal value As String)
            admin = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
