Imports entidad
Imports datos


Public Class inscripciones
    Dim fpdf As New Fpdf

    Dim fi As New Finscripcion
    Dim ei As New Einscripcion
    Public dt As New DataTable
    Dim EXEerror As Boolean
    Public anadir As Boolean = True


    Private Sub inscripciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbIDInscripcion, "IdInscripcion", "CInscripcion")
    End Sub

    Private Sub cmbIDInscripcion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIDInscripcion.Leave
        If Me.cmbIDInscripcion.Text.ToString <> "" Then
            dt = fi.consultarRegistro("IdInscripcion", Me.cmbIDInscripcion.Text.ToString, "CInscripcion", False)
            If dt.Rows.Count > 0 Then
                ei._cedulaAlumno = dt(0)("CIAlumno").ToString
                ei._fechaInscripcion = dt(0)("Fecha").ToString
                ei._grado = dt(0)("Grado").ToString
                ei._seccion = dt(0)("Seccion").ToString
                ei._periodoEscolar = dt(0)("PeriodoEscolar").ToString

                Me.txtCedulaAlumno.Text = ei._cedulaAlumno
                Me.fecha.Text = ei._fechaInscripcion
                Me.txtGrado.Text = ei._grado
                Me.txtSeccion.Text = ei._seccion
                Me.txtPeriodoEscolar.Text = ei._periodoEscolar

                Me.btnAnadir.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True
                MsgBox("La id de la inscripción ingresada existe, puede modificar/eliminar sus datos", MsgBoxStyle.Information, "La inscripción existe")

                anadir = False
            Else
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnBorrar.Enabled = False
                MsgBox("La id de la inscripción ingresada no existe, puede añadir sus datos", MsgBoxStyle.Information, "La inscripción no existe")

                anadir = True
            End If
        End If
    End Sub


    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        Dim vacio As String = ""
        ei._cedulaAlumno = vacio
        ei._fechaInscripcion = Date.Today.ToString
        ei._grado = vacio
        ei._seccion = vacio
        ei._periodoEscolar = vacio

        Me.txtCedulaAlumno.Text = ei._cedulaAlumno
        Me.fecha.Text = ei._fechaInscripcion
        Me.txtGrado.Text = ei._grado
        Me.txtSeccion.Text = ei._seccion
        Me.txtPeriodoEscolar.Text = ei._periodoEscolar

        Me.btnAnadir.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnBorrar.Enabled = False
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtCedulaAlumno.Text <> "" And Me.txtGrado.Text <> "" And Me.txtSeccion.Text <> "" And Me.txtPeriodoEscolar.Text <> "" Then
            If (Me.txtCedulaAlumno.TextLength >= 4) And (Me.txtCedulaAlumno.TextLength <= 10) Then


                ei._cedulaAlumno = Me.txtCedulaAlumno.Text
                ei._fechaInscripcion = Me.fecha.Value.Day.ToString + "/" + Me.fecha.Value.Month.ToString + "/" + Me.fecha.Value.Year.ToString
                ei._grado = Me.txtGrado.Text
                ei._seccion = Me.txtSeccion.Text
                ei._periodoEscolar = Me.txtPeriodoEscolar.Text



                EXEerror = fi.agregar(ei._cedulaAlumno, ei._fechaInscripcion, ei._grado, ei._seccion, ei._periodoEscolar)
                If Not EXEerror Then
                    MsgBox("La inscripción se ha realizado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                    limpiarControles(True)
                    llenarCmb(Me.cmbIDInscripcion, "IdInscripcion", "CInscripcion")
                End If
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True



            Else
                MsgBox("El la cédula del alumno no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
            End If


        Else
            MsgBox("Tiene que llenar todos los campos para realizar una inscripción", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub



    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbIDInscripcion.Text <> "" And Me.txtCedulaAlumno.Text <> "" And Me.txtGrado.Text <> "" And Me.txtSeccion.Text <> "" And Me.txtPeriodoEscolar.Text <> "" Then
            If (Me.txtCedulaAlumno.TextLength >= 4) And (Me.txtCedulaAlumno.TextLength <= 10) Then

                ei._IDInscripcion = Me.cmbIDInscripcion.Text
                ei._cedulaAlumno = Me.txtCedulaAlumno.Text
                ei._fechaInscripcion = Me.fecha.Value.Day.ToString + "/" + Me.fecha.Value.Month.ToString + "/" + Me.fecha.Value.Year.ToString
                ei._grado = Me.txtGrado.Text
                ei._seccion = Me.txtSeccion.Text
                ei._periodoEscolar = Me.txtPeriodoEscolar.Text



                EXEerror = fi.modificar(ei._IDInscripcion, ei._cedulaAlumno, ei._fechaInscripcion, ei._grado, ei._seccion, ei._periodoEscolar)
                If Not EXEerror Then
                    MsgBox("La inscripción se ha modificado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                    limpiarControles(True)
                End If
                Me.btnAnadir.Enabled = True
                Me.btnModificar.Enabled = True
                Me.btnBorrar.Enabled = True



            Else
                MsgBox("El la cédula del alumno no puede ser menor que 4 caracteres ni mayor que 10 caracteres", MsgBoxStyle.Information, "Error")
            End If


        Else
            MsgBox("Tiene que llenar todos los campos para realizar una inscripción", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub




    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar esta inscripcion?", MsgBoxStyle.OkCancel, "Eliminar inscripcion")

        If eliminar = 1 Then
            If Me.cmbIDInscripcion.Text.ToString <> "" Then
                ei._IDInscripcion = Me.cmbIDInscripcion.Text

                Try

                    EXEerror = fi.eliminar(ei._IDInscripcion)
                    If Not EXEerror Then
                        MsgBox("Se ha eliminado correctamente la inscripcion.", MsgBoxStyle.OkOnly, "Eliminación correcta")
                        llenarCmb(Me.cmbIDInscripcion, "IdInscripcion", "CInscripcion")
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
                MsgBox("Es necesario elegir el número de id de la inscripción para eliminar sus datos", MsgBoxStyle.Information, "No eligió la id")
            End If
            
        End If
    End Sub

    Private Sub txtCedulaAlumno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaAlumno.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCedulaAlumno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedulaAlumno.Leave
        If Me.txtCedulaAlumno.Text.ToString <> "" Then
            dt = fi.consultarRegistro("CIAlumno", Me.txtCedulaAlumno.Text.ToString, "CAlumno", True)
            If dt.Rows.Count > 0 Then
                

                dt = fi.consultarRegistro("CIAlumno", Me.txtCedulaAlumno.Text.ToString, "CInscripcion", True)
                If dt.Rows.Count > 0 Then
                    ei._cedulaAlumno = dt(0)("IdInscripcion").ToString
                    ei._cedulaAlumno = dt(0)("CIAlumno").ToString
                    ei._fechaInscripcion = dt(0)("Fecha").ToString
                    ei._grado = dt(0)("Grado").ToString
                    ei._seccion = dt(0)("Seccion").ToString
                    ei._periodoEscolar = dt(0)("PeriodoEscolar").ToString

                    Me.txtCedulaAlumno.Text = ei._cedulaAlumno
                    Me.fecha.Text = ei._fechaInscripcion
                    Me.txtGrado.Text = ei._grado
                    Me.txtSeccion.Text = ei._seccion
                    Me.txtPeriodoEscolar.Text = ei._periodoEscolar

                    Me.btnAnadir.Enabled = True
                    Me.btnModificar.Enabled = True
                    Me.btnBorrar.Enabled = True
                    MsgBox("La cédula del alumno ingresada existe, puede modificar/eliminar sus datos", MsgBoxStyle.Information, "El alumno existe")

                    anadir = False
                Else
                    Me.btnAnadir.Enabled = True
                    Me.btnModificar.Enabled = False
                    Me.btnBorrar.Enabled = False
                    MsgBox("La cédula del alumno ingresada no existe, puede añadir sus datos", MsgBoxStyle.Information, "El alumno no existe")

                    anadir = True
                End If
            Else
                MsgBox("La cedula del alumno ingresada no existe, ingrese otra", MsgBoxStyle.Exclamation, "La cédula no existe")
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        fpdf.iniciarPdf("Inscripciones", "Todos")
        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub
End Class