Imports datos

Public Class Falumno
    Inherits Fgeneral


    Public Function agregar(ByVal cedulaAlumno As String, ByVal nombre As String, ByVal nombreS As String, ByVal apellido As String, ByVal apellidoS As String, ByVal sexo As String, ByVal cedulaRepresentante As String, ByVal fechaNacimiento As String) As Boolean
        Dim yaExiste = existe("CIAlumno", "CAlumno", cedulaAlumno)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO CAlumno (CIAlumno, Nombre, SNombre, Apellido, SApellido, Sexo, CIRepresentante, FechaNacimiento)"
            sql += "VALUES ('" & cedulaAlumno & "','" & nombre & "','" & nombreS & "','" & apellido & "','" & apellidoS & "','" & sexo & "','" & cedulaRepresentante & "','" & fechaNacimiento & "');"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
            desconectar()
        Else
            MsgBox("La cédula del alumno ingresada ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal cedulaAlumno As String, ByVal nombre As String, ByVal nombreS As String, ByVal apellido As String, ByVal apellidoS As String, ByVal sexo As String, ByVal cedulaRepresentante As String, ByVal fechaNacimiento As String) As Boolean


        Dim yaExiste = existe("CIAlumno", "CAlumno", cedulaAlumno)

        If yaExiste Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE CAlumno "
            sql += "SET Nombre='" & nombre & "', "
            sql += "SNombre='" & nombreS & "', "
            sql += "Apellido='" & apellido & "', "
            sql += "SApellido='" & apellidoS & "', "
            sql += "Sexo='" & sexo & "', "
            sql += "CIRepresentante='" & cedulaRepresentante & "', "
            sql += "FechaNacimiento='" & fechaNacimiento & "' "
            sql += "WHERE CIAlumno='" & cedulaAlumno & "';"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
            desconectar()
        Else
            MsgBox("La cédula del alumno ingresada  no existe", MsgBoxStyle.Information, "El alumno no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal cedulaAlumno As String) As Boolean
        Dim yaExiste = existe("CIAlumno", "CAlumno", cedulaAlumno)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM CAlumno WHERE CIAlumno='" & cedulaAlumno & "'"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.Message)
                EXEerror = True
            End Try
            desconectar()
        Else
            MsgBox("La cédula de alumno ingresada  ingresado no existe", MsgBoxStyle.Information, "El alumno no existe")
            EXEerror = True
        End If
        Return EXEerror

    End Function
End Class
