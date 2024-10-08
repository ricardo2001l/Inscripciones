Imports datos
Public Class Finscripcion
    Inherits Fgeneral

    Public Function agregar(ByVal CIAlumno As String, ByVal fecha As String, ByVal grado As String, ByVal seccion As String, ByVal periodoEscolar As String) As Boolean

        conectar()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "INSERT INTO CInscripcion (CIAlumno, Fecha, Grado, Seccion, PeriodoEscolar)"
        sql += "VALUES ('" & CIAlumno & "','" & fecha & "','" & grado & "','" & seccion & "','" & periodoEscolar & "');"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            EXEerror = False
        Catch ex As Exception
            MsgBox(ex.Message)
            EXEerror = True
        End Try
        desconectar()
        Return EXEerror
    End Function

    Public Function modificar(ByVal IDInscripcion As String, ByVal CIAlumno As String, ByVal fecha As String, ByVal grado As String, ByVal seccion As String, ByVal periodoEscolar As String) As Boolean


        Dim yaExiste = existe("IdInscripcion", "CInscripcion", IDInscripcion, False)

        If yaExiste Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE CInscripcion "
            sql += "SET CIAlumno='" & CIAlumno & "', "
            sql += "Fecha='" & fecha & "', "
            sql += "Grado='" & grado & "', "
            sql += "Seccion='" & seccion & "' "
            sql += "PeriodoEscolar='" & periodoEscolar & "' "
            sql += "WHERE IdInscripcion=" & IDInscripcion & ";"
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
            MsgBox("La id de inscipcion ingresada no existe", MsgBoxStyle.Information, "La isncripcion no existe")
            EXEerror = True
        End If
        Return EXEerror
    End Function
    Public Function eliminar(ByVal IDInscripcion As String) As Boolean
        Dim yaExiste = existe("IdInscripcion", "CInscripcion", IDInscripcion, False)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM CInscripcion WHERE IdInscripcion=" & IDInscripcion & ""
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
            MsgBox("La id de inscipcion ingresada no existe", MsgBoxStyle.Information, "La isncripcion no existe")
            EXEerror = True
        End If
        Return EXEerror

    End Function
End Class
