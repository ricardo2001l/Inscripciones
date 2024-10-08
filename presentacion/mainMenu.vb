Public Class mainMenu

    Private Sub btnAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumno.Click
        alumno.Show()
        Me.Close()
    End Sub

    Private Sub btnRepresentante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepresentante.Click
        representante.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        usuario.Show()
        Me.Close()
    End Sub


    Private Sub mainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If isAdmin = "True" Then
            Me.btnBaseDatos.Enabled = True
            Me.btnUsuario.Enabled = True
        ElseIf isAdmin = "False" Then
            Me.btnBaseDatos.Enabled = False
            Me.btnUsuario.Enabled = False
        End If
    End Sub

    Private Sub btnBaseDatos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaseDatos.Click
        BaseDatos.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        iniciarSesion.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inscripciones.Show()
        Me.Close()
    End Sub
End Class