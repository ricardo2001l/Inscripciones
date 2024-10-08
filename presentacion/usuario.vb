Imports entidad
Imports datos


Public Class usuario
    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Public dt As New DataTable
    Dim EXEerror As Boolean
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        soloNumerosYletras(e)
    End Sub

    Private Sub txtUsuario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.Leave
        If Me.txtUsuario.Text <> "" Then
            dt = fu.consultarRegistro("Nombre", Me.txtUsuario.Text.ToString, "CUsuario", True)
            If dt.Rows.Count > 0 Then
                eu._admin = dt(0)("Admin").ToString

                If eu._admin = "admin" Then
                    Me.radioAdmin.Checked = True
                    Me.radioEncargado.Checked = False
                End If
                If eu._admin = "encargado" Then
                    Me.radioEncargado.Checked = True
                    Me.radioAdmin.Checked = False
                End If
                Me.btnAnadir.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True
            Else
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnBorrar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtUsuario.Text <> "" And Me.txtClave.Text <> "" Then
            If (Me.txtUsuario.TextLength >= 6) And (Me.txtUsuario.TextLength <= 25) Then
                If (Me.txtClave.TextLength >= 6) And (Me.txtClave.TextLength <= 30) Then
                    eu._nombreUsuario = Me.txtUsuario.Text
                    eu._contrasena = Me.txtClave.Text

                    If Me.radioAdmin.Checked Then
                        eu._admin = "admin"
                    End If

                    If Me.radioEncargado.Checked Then
                        eu._admin = "encargado"
                    End If


                    EXEerror = fu.agregar(eu._nombreUsuario, eu._contrasena, eu._admin)
                    If Not EXEerror Then
                        MsgBox("El usuario se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                        limpiarControles(True)
                    End If
                Else
                    MsgBox("La contraseña del usuario no puede ser menor a 6 caracteres ni mayor a 30", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El nombre de usuario no puede ser menor a 6 caracteres ni mayor a 25", MsgBoxStyle.Information, "Error")
            End If


        Else
            MsgBox("Tiene que llenar todos los campos para añadir un usuario", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        Dim vacio As String = ""
        eu._nombreUsuario = vacio
        eu._contrasena = vacio

        Me.txtUsuario.Text = eu._nombreUsuario
        Me.txtClave.Text = eu._contrasena

        Me.btnAnadir.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnBorrar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.txtUsuario.Text <> "" And Me.txtClave.Text <> "" Then
            If (Me.txtUsuario.TextLength >= 6) And (Me.txtUsuario.TextLength <= 25) Then
                If (Me.txtClave.TextLength >= 6) And (Me.txtClave.TextLength <= 30) Then
                    eu._nombreUsuario = Me.txtUsuario.Text
                    eu._contrasena = Me.txtClave.Text


                    If Me.radioAdmin.Checked Then
                        eu._admin = "admin"
                    End If

                    If Me.radioEncargado.Checked Then
                        eu._admin = "encargado"
                    End If

                    EXEerror = fu.modificar(eu._nombreUsuario, eu._contrasena, eu._admin)
                    If Not EXEerror Then
                        MsgBox("El usuario se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                        limpiarControles(True)
                    End If
                Else
                    MsgBox("La contraseña del usuario no puede ser menor a 6 caracteres ni mayor a 30", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El nombre de usuario no puede ser menor a 6 caracteres ni mayor a 25", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para modificar un usuario", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este usuario?", MsgBoxStyle.OkCancel, "Eliminar representante")

        If eliminar = 1 Then
            If Me.txtUsuario.Text.ToString <> "" Then
                eu._nombreUsuario = Me.txtUsuario.Text

                Try

                    EXEerror = fu.eliminar(eu._nombreUsuario)
                    If Not EXEerror Then
                        MsgBox("Se ha eliminado correctamente el usuario.", MsgBoxStyle.OkOnly, "Eliminación correcta")
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                    EXEerror = True
                End Try

                If Not EXEerror Then
                    limpiarControles(True)
                End If
            Else
                MsgBox("Es necesario elegir la cédula del usuario para eliminar sus datos", MsgBoxStyle.Information, "No eligió la cédula")
            End If
        End If
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub

End Class