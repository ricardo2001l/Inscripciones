Imports entidad
Imports datos

Public Class representante
    Dim fpdf As New Fpdf

    Dim fr As New Frepresentante
    Dim er As New Erepresentante
    Public dt As New DataTable
    Dim EXEerror As Boolean
    Public anadir As Boolean
    Private Sub representante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbSexo.Items.Add("Masculino")
        Me.cmbSexo.Items.Add("Femenino")
        Me.cmbSexo.Items.Add("")
    End Sub

    Private Sub txtCedulaRepresentante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaRepresentante.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCedulaRepresentante_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedulaRepresentante.Leave
        If Me.txtCedulaRepresentante.Text.ToString <> "" Then
            dt = fr.consultarRegistro("CIRepresentante", Me.txtCedulaRepresentante.Text.ToString, "CRepresentante", True)
            If dt.Rows.Count > 0 Then
                er._cedulaRepresentante = dt(0)("CIRepresentante").ToString
                er._nombre = dt(0)("Nombre").ToString
                er._nombreS = dt(0)("SNombre").ToString
                er._apellido = dt(0)("Apellido").ToString
                er._apellidoS = dt(0)("SApellido").ToString
                er._sexo = dt(0)("Sexo").ToString
                er._fechaNacimiento = dt(0)("FechaNacimiento").ToString
                er._telefono = dt(0)("Telefono").ToString
                er._dirreccion = dt(0)("Dirreccion").ToString

                Me.txtCedulaRepresentante.Text = er._cedulaRepresentante
                Me.txtPrimerNombre.Text = er._nombre
                Me.txtSegundoNombre.Text = er._nombreS
                Me.txtPrimerApellido.Text = er._apellido
                Me.txtSegundoApellido.Text = er._apellidoS
                Me.cmbSexo.SelectedItem = er._sexo
                Me.fechaNacimiento.Text = er._fechaNacimiento
                Me.txtTelefono.Text = er._telefono
                Me.txtDirreccion.Text = er._dirreccion

                Me.btnAnadir.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True
                MsgBox("La cédula del representante ingresada existe, puede modificar/eliminar sus datos", MsgBoxStyle.Information, "El representante existe")

                anadir = False
            Else
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnBorrar.Enabled = False
                MsgBox("La cédula del representante ingresada no existe, puede añadir sus datos", MsgBoxStyle.Information, "El representante no existe")

                anadir = True
            End If
        End If
    End Sub


    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtCedulaRepresentante.Text <> "" And Me.txtPrimerNombre.Text <> "" And Me.txtPrimerApellido.Text <> "" And Me.cmbSexo.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtDirreccion.Text <> "" Then
            If (Me.txtCedulaRepresentante.TextLength >= 4) And (Me.txtCedulaRepresentante.TextLength <= 10) Then
                If (Me.txtPrimerNombre.TextLength >= 3) And (Me.txtPrimerNombre.TextLength <= 20) Then
                    If (Me.txtSegundoNombre.TextLength >= 3) And (Me.txtSegundoNombre.TextLength <= 20) Then
                        If (Me.txtPrimerApellido.TextLength >= 3) And (Me.txtPrimerApellido.TextLength <= 20) Then
                            If (Me.txtSegundoApellido.TextLength >= 3) And (Me.txtSegundoApellido.TextLength <= 20) Then
                                If (Me.txtDirreccion.TextLength >= 7) And (Me.txtDirreccion.TextLength <= 70) Then
                                    er._cedulaRepresentante = Me.txtCedulaRepresentante.Text
                                    er._nombre = Me.txtPrimerNombre.Text
                                    er._nombreS = Me.txtSegundoNombre.Text
                                    er._apellido = Me.txtPrimerApellido.Text
                                    er._apellidoS = Me.txtSegundoApellido.Text
                                    er._sexo = Me.cmbSexo.Text
                                    er._fechaNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString
                                    er._telefono = Me.txtTelefono.Text
                                    er._dirreccion = Me.txtDirreccion.Text

                                    EXEerror = fr.agregar(er._cedulaRepresentante, er._nombre, er._nombreS, er._apellido, er._apellidoS, er._sexo, er._fechaNacimiento, er._telefono, er._dirreccion)
                                    If Not EXEerror Then
                                        MsgBox("El representante se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                                        limpiarControles(True)
                                    End If
                                    Me.btnAnadir.Enabled = True
                                    Me.btnModificar.Enabled = True
                                    Me.btnBorrar.Enabled = True
                                Else
                                    MsgBox("La direccion no puede ser menor que 7 caracteres ni mayor que 70 caracteres", MsgBoxStyle.Information, "Error")
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
                MsgBox("El la cédula del representante no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
            End If

            
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un representante", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub

    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        Dim vacio As String = ""
        er._cedulaRepresentante = vacio
        er._nombre = vacio
        er._nombreS = vacio
        er._apellido = vacio
        er._apellidoS = vacio
        er._sexo = vacio
        er._fechaNacimiento = Date.Today.ToString
        er._telefono = vacio
        er._dirreccion = vacio

        Me.txtCedulaRepresentante.Text = er._cedulaRepresentante
        Me.txtPrimerNombre.Text = er._nombre
        Me.txtSegundoNombre.Text = er._nombreS
        Me.txtPrimerApellido.Text = er._apellido
        Me.txtSegundoApellido.Text = er._apellidoS
        Me.cmbSexo.SelectedItem = er._sexo
        Me.fechaNacimiento.Text = er._fechaNacimiento
        Me.txtTelefono.Text = er._telefono
        Me.txtDirreccion.Text = er._dirreccion

        Me.btnAnadir.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnBorrar.Enabled = False
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.txtCedulaRepresentante.Text <> "" And Me.txtPrimerNombre.Text <> "" And Me.txtPrimerApellido.Text <> "" And Me.cmbSexo.Text <> "" And Me.txtTelefono.Text <> "" And Me.txtDirreccion.Text <> "" Then
            If (Me.txtCedulaRepresentante.TextLength >= 4) And (Me.txtCedulaRepresentante.TextLength <= 10) Then
                If (Me.txtPrimerNombre.TextLength >= 3) And (Me.txtPrimerNombre.TextLength <= 20) Then
                    If (Me.txtSegundoNombre.TextLength >= 3) And (Me.txtSegundoNombre.TextLength <= 20) Then
                        If (Me.txtPrimerApellido.TextLength >= 3) And (Me.txtPrimerApellido.TextLength <= 20) Then
                            If (Me.txtSegundoApellido.TextLength >= 3) And (Me.txtSegundoApellido.TextLength <= 20) Then
                                If (Me.txtDirreccion.TextLength >= 7) And (Me.txtDirreccion.TextLength <= 70) Then
                                    er._cedulaRepresentante = Me.txtCedulaRepresentante.Text
                                    er._nombre = Me.txtPrimerNombre.Text
                                    er._nombreS = Me.txtSegundoNombre.Text
                                    er._apellido = Me.txtPrimerApellido.Text
                                    er._apellidoS = Me.txtSegundoApellido.Text
                                    er._sexo = Me.cmbSexo.Text
                                    er._fechaNacimiento = Me.fechaNacimiento.Value.Day.ToString + "/" + Me.fechaNacimiento.Value.Month.ToString + "/" + Me.fechaNacimiento.Value.Year.ToString
                                    er._telefono = Me.txtTelefono.Text
                                    er._dirreccion = Me.txtDirreccion.Text

                                    EXEerror = fr.modificar(er._cedulaRepresentante, er._nombre, er._nombreS, er._apellido, er._apellidoS, er._sexo, er._fechaNacimiento, er._telefono, er._dirreccion)
                                    If Not EXEerror Then
                                        MsgBox("El representante se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                                        limpiarControles(True)
                                    End If
                                    Me.btnAnadir.Enabled = True
                                    Me.btnModificar.Enabled = True
                                    Me.btnBorrar.Enabled = True
                                Else
                                    MsgBox("La dirreccion no puede ser menor que 7 caracteres ni mayor que 70 caracteres", MsgBoxStyle.Information, "Error")
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
            MsgBox("Tiene que llenar todos los campos para modificar un representante", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este representante?", MsgBoxStyle.OkCancel, "Eliminar representante")

        If eliminar = 1 Then
            If (Me.txtCedulaRepresentante.TextLength >= 4) And (Me.txtCedulaRepresentante.TextLength <= 10) Then
                If Me.txtCedulaRepresentante.Text.ToString <> "" Then
                    er._cedulaRepresentante = Me.txtCedulaRepresentante.Text

                    Try

                        EXEerror = fr.eliminar(er._cedulaRepresentante)
                        If Not EXEerror Then
                            MsgBox("Se ha eliminado correctamente el representante.", MsgBoxStyle.OkOnly, "Eliminación correcta")
                        End If


                    Catch ex As Exception
                        MsgBox(ex.Message)
                        EXEerror = True
                    End Try

                    If Not EXEerror Then
                        limpiarControles(True)
                    End If
                    Me.btnAnadir.Enabled = True
                    Me.btnModificar.Enabled = True
                    Me.btnBorrar.Enabled = True
                Else
                    MsgBox("Es necesario elegir la cédula del representante para eliminar sus datos", MsgBoxStyle.Information, "No eligió la cédula")
                End If
            Else
                MsgBox("La cédula del representante no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtPrimerNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerNombre.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtSegundoNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoNombre.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtPrimerApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtSegundoApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtDirreccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDirreccion.KeyPress
        soloNumerosLetrasComasYEspacios(e)
    End Sub

    Private Sub fechaNacimiento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fechaNacimiento.Leave
        Dim hoy As Date = Date.Today
        Dim nacimiento As Date = Me.fechaNacimiento.Value
        Dim hace18anos As Date = hoy.AddYears(-18)
        Dim esMayorEdad As Integer

        esMayorEdad = Date.Compare(nacimiento, hace18anos)
        If esMayorEdad = 1 Then
            MsgBox("El representante no puede ser menor de edad, ingrese una fecha de nacimiento válida.", MsgBoxStyle.Information, "Fecha de nacimiento no válida")
            Me.btnAnadir.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnBorrar.Enabled = False
        Else
            If anadir Then
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnBorrar.Enabled = False
            Else
                Me.btnAnadir.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True
            End If

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Fpdf.iniciarPdf("Representante", "Todos")
        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub
End Class