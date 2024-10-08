Imports datos

Public Class Frepresentante
    Inherits Fgeneral


    Public Function agregar(ByVal cedulaRepresentante As String, ByVal nombre As String, ByVal nombreS As String, ByVal apellido As String, ByVal apellidoS As String, ByVal sexo As String, ByVal fechaNacimiento As String, ByVal telefono As String, ByVal dirreccion As String) As Boolean
        Dim yaExiste = existe("CIRepresentante", "CRepresentante", cedulaRepresentante)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO CRepresentante (CIRepresentante, Nombre, SNombre, Apellido, SApellido, Sexo, FechaNacimiento, Telefono, Dirreccion)"
            sql += "VALUES ('" & cedulaRepresentante & "','" & nombre & "','" & nombreS & "','" & apellido & "','" & apellidoS & "','" & sexo & "','" & fechaNacimiento & "','" & telefono & "','" & dirreccion & "');"
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
            MsgBox("La cédula del representante ingresada ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal cedulaRepresentante As String, ByVal nombre As String, ByVal nombreS As String, ByVal apellido As String, ByVal apellidoS As String, ByVal sexo As String, ByVal fechaNacimiento As String, ByVal telefono As String, ByVal dirreccion As String) As Boolean


        Dim yaExiste = existe("CIRepresentante", "CRepresentante", cedulaRepresentante)

        If yaExiste Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE CRepresentante "
            sql += "SET Nombre='" & nombre & "', "
            sql += "SNombre='" & nombreS & "', "
            sql += "Apellido='" & apellido & "', "
            sql += "SApellido='" & apellidoS & "', "
            sql += "Sexo='" & sexo & "', "
            sql += "FechaNacimiento='" & fechaNacimiento & "', "
            sql += "Telefono='" & telefono & "', "
            sql += "Dirreccion='" & dirreccion & "' "
            sql += "WHERE CIRepresentante='" & cedulaRepresentante & "';"
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
            MsgBox("La cédula del representante ingresada no existe", MsgBoxStyle.Information, "El representante no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal cedulaRepresentante As String) As Boolean
        Dim yaExiste = existe("CIRepresentante", "CRepresentante", cedulaRepresentante)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM CRepresentante WHERE CIRepresentante='" & cedulaRepresentante & "'"
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
            MsgBox("La cédula de representante ingresada ingresado no existe", MsgBoxStyle.Information, "El representante no existe")
            EXEerror = True
        End If
        Return EXEerror

    End Function
End Class
