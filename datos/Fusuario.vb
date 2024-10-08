Imports entidad

Public Class Fusuario
    Inherits Fgeneral


    Public Function validarUsuario(ByVal dts As Eusuario) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM CUsuario WHERE Nombre='" & dts._nombreUsuario & "' AND Clave='" & dts._contrasena & "';"
        cmd.CommandText = Sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function agregar(ByVal usuario As String, ByVal clave As String, ByVal admin As String) As Boolean
        Dim yaExiste = existe("Nombre", "CUsuario", usuario)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO CUsuario (Nombre, Clave, Admin)"
            sql += "VALUES ('" & usuario & "','" & clave & "','" & admin & "');"
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
            MsgBox("El nombre de usuario ingresado ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
            EXEerror = True
        End If
        Return EXEerror
    End Function

    Public Function modificar(ByVal usuario As String, ByVal clave As String, ByVal admin As String) As Boolean


        Dim yaExiste = existe("Nombre", "CUsuario", usuario)

        If yaExiste Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE CUsuario "
            sql += "SET Nombre='" & usuario & "', "
            sql += "SET Admin='" & admin & "', "
            sql += "Clave='" & clave & "' "
            sql += "WHERE Nombre='" & usuario & "';"
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
            MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Information, "El usaurio no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal usuario As String) As Boolean
        Dim yaExiste = existe("Nombre", "CUsuario", usuario)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM CUsuario WHERE Nombre='" & usuario & "'"
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
            MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Information, "El usuario no existe")
            EXEerror = True
        End If
        Return EXEerror

    End Function
End Class
