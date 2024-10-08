Public Class Einscripcion
    Private cedulaAlumno, IDInscripcion, fechaInscripcion, seccion, grado, periodoEscolar As String

    Public Property _cedulaAlumno As String
        Get
            Return cedulaAlumno
        End Get
        Set(ByVal value As String)
            cedulaAlumno = value
        End Set
    End Property
    Public Property _IDInscripcion As String
        Get
            Return IDInscripcion
        End Get
        Set(ByVal value As String)
            IDInscripcion = value
        End Set
    End Property
    Public Property _fechaInscripcion As String
        Get
            Return fechaInscripcion
        End Get
        Set(ByVal value As String)
            fechaInscripcion = value
        End Set
    End Property
    Public Property _seccion As String
        Get
            Return seccion
        End Get
        Set(ByVal value As String)
            seccion = value
        End Set
    End Property
    Public Property _grado As String
        Get
            Return grado
        End Get
        Set(ByVal value As String)
            grado = value
        End Set
    End Property
    Public Property _periodoEscolar As String
        Get
            Return periodoEscolar
        End Get
        Set(ByVal value As String)
            periodoEscolar = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
