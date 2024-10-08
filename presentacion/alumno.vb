Imports entidad
Imports datos

Public Class alumno
    Dim fpdf As New Fpdf


    Dim fa As New Falumno
    Dim ea As New Ealumno
    Public dt As New DataTable
    Public anadir As Boolean
    Dim EXEerror As Boolean

    Private Sub inscribir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbSexo.Items.Add("Masculino")
        Me.cmbSexo.Items.Add("Femenino")
        Me.cmbSexo.Items.Add("")
    End Sub

    Private Sub txtCedulaAlumno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaAlumno.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCedulaAlumno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedulaAlumno.Leave
        If Me.txtCedulaAlumno.Text.ToString <> "" Then
            dt = fa.consultarRegistro("CIAlumno", Me.txtCedulaAlumno.Text.ToString, "CAlumno", True)
            If dt.Rows.Count > 0 Then
                ea._cedulaAlumno = dt(0)("CIAlumno").ToString
                ea._cedulaRepresentante = dt(0)("CIRepresentante").ToString
                ea._nombre = dt(0)("Nombre").ToString
                ea._nombreS = dt(0)("SNombre").ToString
                ea._apellido = dt(0)("Apellido").ToString
                ea._apellidoS = dt(0)("SApellido").ToString
                ea._sexo = dt(0)("Sexo").ToString
                ea._fechaNacimiento = dt(0)("FechaNacimiento").ToString

                Me.txtCedulaAlumno.Text = ea._cedulaAlumno
                Me.txtCedulaRepresentante.Text = ea._cedulaRepresentante
                Me.txtPrimerNombre.Text = ea._nombre
                Me.txtSegundoNombre.Text = ea._nombreS
                Me.txtPrimerApellido.Text = ea._apellido
                Me.txtSegundoApellido.Text = ea._apellidoS
                Me.cmbSexo.SelectedItem = ea._sexo
                Me.fechaNacimiento.Text = ea._fechaNacimiento

                anadir = False
                Me.btnAnadir.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True
            Else
                anadir = True
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnBorrar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtCedulaAlumno.Text <> "" And Me.txtCedulaRepresentante.Text <> "" And Me.txtPrimerNombre.Text <> "" And Me.txtPrimerApellido.Text <> "" And Me.cmbSexo.Text <> "" Then

            If (Me.txtCedulaAlumno.TextLength >= 4) And (Me.txtCedulaAlumno.TextLength <= 10) Then
                If (Me.txtCedulaRepresentante.TextLength >= 4) And (Me.txtCedulaRepresentante.TextLength <= 10) Then
                    If (Me.txtPrimerNombre.TextLength >= 3) And (Me.txtPrimerNombre.TextLength <= 20) Then
                        If (Me.txtSegundoNombre.TextLength >= 3) And (Me.txtSegundoNombre.TextLength <= 20) Then
                            If (Me.txtPrimerApellido.TextLength >= 3) And (Me.txtPrimerApellido.TextLength <= 20) Then
                                If (Me.txtSegundoApellido.TextLength >= 3) And (Me.txtSegundoApellido.TextLength <= 20) Then
                                    ea._cedulaAlumno = Me.txtCedulaAlumno.Text
                                    ea._cedulaRepresentante = Me.txtCedulaRepresentante.Text
                                    ea._nombre = Me.txtPrimerNombre.Text
                                    ea._nombreS = Me.txtSegundoNombre.Text
                                    ea._apellido = Me.txtPrimerApellido.Text
                                    ea._apellidoS = Me.txtSegundoApellido.Text
                                    ea._sexo = Me.cmbSexo.Text
                                    ea._fechaNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString



                                    EXEerror = fa.agregar(ea._cedulaAlumno, ea._nombre, ea._nombreS, ea._apellido, ea._apellidoS, ea._sexo, ea._cedulaRepresentante, ea._fechaNacimiento)
                                    If Not EXEerror Then
                                        MsgBox("El alumno se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                                        limpiarControles(True)
                                    End If
                                Else
                                    MsgBox("El segundo apellido no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                                End If
                            Else
                                MsgBox("El primer apellido no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                            End If
                        Else
                            MsgBox("El segundo nombre no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                        End If
                    Else
                        MsgBox("El primer nombre no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                    End If
                Else
                    MsgBox("La cédula del representante no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("La cédula del alumno no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
            End If

        Else
            MsgBox("Tiene que llenar todos los campos para añadir un alumnno", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub


    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        Dim vacio As String = ""
        ea._cedulaAlumno = vacio
        ea._cedulaRepresentante = vacio
        ea._nombre = vacio
        ea._nombreS = vacio
        ea._apellido = vacio
        ea._apellidoS = vacio
        ea._sexo = vacio
        ea._fechaNacimiento = Date.Today.ToString

        Me.txtCedulaAlumno.Text = ea._cedulaAlumno
        Me.txtCedulaRepresentante.Text = ea._cedulaRepresentante
        Me.txtPrimerNombre.Text = ea._nombre
        Me.txtSegundoNombre.Text = ea._nombreS
        Me.txtPrimerApellido.Text = ea._apellido
        Me.txtSegundoApellido.Text = ea._apellidoS
        Me.cmbSexo.SelectedItem = ea._sexo
        Me.fechaNacimiento.Text = ea._fechaNacimiento

        Me.btnAnadir.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnBorrar.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.txtCedulaAlumno.Text <> "" And Me.txtCedulaRepresentante.Text <> "" And Me.txtPrimerNombre.Text <> "" And Me.txtPrimerApellido.Text <> "" And Me.cmbSexo.Text <> "" Then


            If (Me.txtCedulaAlumno.TextLength >= 4) And (Me.txtCedulaAlumno.TextLength <= 10) Then
                If (Me.txtCedulaRepresentante.TextLength >= 4) And (Me.txtCedulaRepresentante.TextLength <= 10) Then
                    If (Me.txtPrimerNombre.TextLength >= 3) And (Me.txtPrimerNombre.TextLength <= 20) Then
                        If (Me.txtSegundoNombre.TextLength >= 3) And (Me.txtSegundoNombre.TextLength <= 20) Then
                            If (Me.txtPrimerApellido.TextLength >= 3) And (Me.txtPrimerApellido.TextLength <= 20) Then
                                If (Me.txtSegundoApellido.TextLength >= 3) And (Me.txtSegundoApellido.TextLength <= 20) Then
                                    ea._cedulaAlumno = Me.txtCedulaAlumno.Text
                                    ea._cedulaRepresentante = Me.txtCedulaRepresentante.Text
                                    ea._nombre = Me.txtPrimerNombre.Text
                                    ea._nombreS = Me.txtSegundoNombre.Text
                                    ea._apellido = Me.txtPrimerApellido.Text
                                    ea._apellidoS = Me.txtSegundoApellido.Text
                                    ea._sexo = Me.cmbSexo.Text
                                    ea._fechaNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString


                                    EXEerror = fa.modificar(ea._cedulaAlumno, ea._nombre, ea._nombreS, ea._apellido, ea._apellidoS, ea._sexo, ea._cedulaRepresentante, ea._fechaNacimiento)
                                    If Not EXEerror Then
                                        MsgBox("El alumno se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                                        limpiarControles(True)

                                    End If
                                Else
                                    MsgBox("El segundo apellido no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                                End If
                            Else
                                MsgBox("El primer apellido no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                            End If
                        Else
                            MsgBox("El segundo nombre no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                        End If
                    Else
                        MsgBox("El primer nombre no puede ser menor que 3 caracteres ni mayor que 20 caracteres", MsgBoxStyle.Information, "Error")
                    End If
                Else
                    MsgBox("La cédula del representante no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("La cédula del alumno no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
            End If

        Else
            MsgBox("Tiene que llenar todos los campos para modificar un alumno", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este alumno?", MsgBoxStyle.OkCancel, "Eliminar alumno")

        If eliminar = 1 Then
            If Me.txtCedulaAlumno.Text.ToString <> "" Then
                If (Me.txtCedulaAlumno.TextLength >= 4) And (Me.txtCedulaAlumno.TextLength <= 10) Then
                    ea._cedulaAlumno = Me.txtCedulaAlumno.Text

                    Try

                        EXEerror = fa.eliminar(ea._cedulaAlumno)
                        If Not EXEerror Then
                            MsgBox("Se ha eliminado correctamente el alumno.", MsgBoxStyle.OkOnly, "Eliminación correcta")
                        End If


                    Catch ex As Exception
                        MsgBox(ex.Message)
                        EXEerror = True
                    End Try

                    If Not EXEerror Then
                        limpiarControles(True)
                    End If
                Else
                    MsgBox("La cédula del alumno no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("Es necesario elegir la cédula del alumno para eliminar sus datos", MsgBoxStyle.Information, "No eligió la cédula")
            End If
        End If
    End Sub

    Private Sub txtCedulaRepresentante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaRepresentante.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCedulaRepresentante_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedulaRepresentante.Leave
        If Me.txtCedulaRepresentante.Text.ToString <> "" Then
            dt = fa.consultarRegistro("CIRepresentante", Me.txtCedulaRepresentante.Text.ToString, "CRepresentante", True)
            If dt.Rows.Count > 0 Then
                Me.btnAnadir.Enabled = anadir
                Me.btnModificar.Enabled = Not anadir
                Me.btnBorrar.Enabled = Not anadir
            Else
                MsgBox("La cédula del representante ingresada no existe, ingrese una cédula correcta", MsgBoxStyle.Information, "El representante no existe")
                Me.btnAnadir.Enabled = False
                Me.btnModificar.Enabled = False
                Me.btnBorrar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtPrimerApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtSegundoApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtSegundoNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoNombre.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtPrimerNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerNombre.KeyPress
        soloLetras(e)
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        fpdf.iniciarPdf("Alumno", "Todos")
        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub
End Class