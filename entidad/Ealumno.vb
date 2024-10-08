Public Class Ealumno
    Private cedulaAlumno, nombre, nombreS, apellido, apellidoS, sexo, cedulaRepresentante, fechaNacimiento As String

    Public Property _cedulaAlumno As String
        Get
            Return cedulaAlumno
        End Get
        Set(ByVal value As String)
            cedulaAlumno = value
        End Set
    End Property
    Public Property _cedulaRepresentante As String
        Get
            Return cedulaRepresentante
        End Get
        Set(ByVal value As String)
            cedulaRepresentante = value
        End Set
    End Property
    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property _nombreS As String
        Get
            Return nombreS
        End Get
        Set(ByVal value As String)
            nombreS = value
        End Set
    End Property
    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property
    Public Property _apellidoS As String
        Get
            Return apellidoS
        End Get
        Set(ByVal value As String)
            apellidoS = value
        End Set
    End Property
    Public Property _sexo As String
        Get
            Return sexo
        End Get
        Set(ByVal value As String)
            sexo = value
        End Set
    End Property
    Public Property _fechaNacimiento As String
        Get
            Return fechaNacimiento
        End Get
        Set(ByVal value As String)
            fechaNacimiento = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
