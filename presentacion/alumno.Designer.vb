<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alumno
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CI_AlumnoLabel As System.Windows.Forms.Label
        Dim CI_RLabel As System.Windows.Forms.Label
        Dim PNombreLabel As System.Windows.Forms.Label
        Dim SNombreLabel As System.Windows.Forms.Label
        Dim PApellidoLabel As System.Windows.Forms.Label
        Dim SApellidoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alumno))
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtCedulaAlumno = New System.Windows.Forms.TextBox()
        Me.txtCedulaRepresentante = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        CI_AlumnoLabel = New System.Windows.Forms.Label()
        CI_RLabel = New System.Windows.Forms.Label()
        PNombreLabel = New System.Windows.Forms.Label()
        SNombreLabel = New System.Windows.Forms.Label()
        PApellidoLabel = New System.Windows.Forms.Label()
        SApellidoLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CI_AlumnoLabel
        '
        CI_AlumnoLabel.AutoSize = True
        CI_AlumnoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        CI_AlumnoLabel.Location = New System.Drawing.Point(30, 105)
        CI_AlumnoLabel.Name = "CI_AlumnoLabel"
        CI_AlumnoLabel.Size = New System.Drawing.Size(81, 17)
        CI_AlumnoLabel.TabIndex = 36
        CI_AlumnoLabel.Text = "CI Alumno:"
        '
        'CI_RLabel
        '
        CI_RLabel.AutoSize = True
        CI_RLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        CI_RLabel.Location = New System.Drawing.Point(388, 152)
        CI_RLabel.Name = "CI_RLabel"
        CI_RLabel.Size = New System.Drawing.Size(123, 17)
        CI_RLabel.TabIndex = 42
        CI_RLabel.Text = "CI Representante:"
        '
        'PNombreLabel
        '
        PNombreLabel.AutoSize = True
        PNombreLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        PNombreLabel.Location = New System.Drawing.Point(29, 149)
        PNombreLabel.Name = "PNombreLabel"
        PNombreLabel.Size = New System.Drawing.Size(111, 17)
        PNombreLabel.TabIndex = 49
        PNombreLabel.Text = "Primer nombre:"
        '
        'SNombreLabel
        '
        SNombreLabel.AutoSize = True
        SNombreLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SNombreLabel.Location = New System.Drawing.Point(29, 193)
        SNombreLabel.Name = "SNombreLabel"
        SNombreLabel.Size = New System.Drawing.Size(124, 17)
        SNombreLabel.TabIndex = 51
        SNombreLabel.Text = "Segundo nombre:"
        '
        'PApellidoLabel
        '
        PApellidoLabel.AutoSize = True
        PApellidoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        PApellidoLabel.Location = New System.Drawing.Point(30, 232)
        PApellidoLabel.Name = "PApellidoLabel"
        PApellidoLabel.Size = New System.Drawing.Size(113, 17)
        PApellidoLabel.TabIndex = 53
        PApellidoLabel.Text = "Primer apellido:"
        '
        'SApellidoLabel
        '
        SApellidoLabel.AutoSize = True
        SApellidoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SApellidoLabel.Location = New System.Drawing.Point(29, 274)
        SApellidoLabel.Name = "SApellidoLabel"
        SApellidoLabel.Size = New System.Drawing.Size(126, 17)
        SApellidoLabel.TabIndex = 55
        SApellidoLabel.Text = "Segundo apellido:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SexoLabel.Location = New System.Drawing.Point(388, 190)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(43, 17)
        SexoLabel.TabIndex = 59
        SexoLabel.Text = "Sexo:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        EdadLabel.Location = New System.Drawing.Point(388, 108)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(141, 17)
        EdadLabel.TabIndex = 57
        EdadLabel.Text = "Fecha de nacimiento"
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(537, 189)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(167, 21)
        Me.cmbSexo.TabIndex = 65
        '
        'btnAnadir
        '
        Me.btnAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnAnadir.Location = New System.Drawing.Point(400, 357)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(93, 37)
        Me.btnAnadir.TabIndex = 62
        Me.btnAnadir.Text = "Agregar"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnModificar.Location = New System.Drawing.Point(499, 357)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 37)
        Me.btnModificar.TabIndex = 61
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnBorrar.Location = New System.Drawing.Point(598, 357)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(93, 37)
        Me.btnBorrar.TabIndex = 60
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtCedulaAlumno
        '
        Me.txtCedulaAlumno.Location = New System.Drawing.Point(195, 105)
        Me.txtCedulaAlumno.Name = "txtCedulaAlumno"
        Me.txtCedulaAlumno.Size = New System.Drawing.Size(167, 20)
        Me.txtCedulaAlumno.TabIndex = 37
        '
        'txtCedulaRepresentante
        '
        Me.txtCedulaRepresentante.Location = New System.Drawing.Point(536, 149)
        Me.txtCedulaRepresentante.Name = "txtCedulaRepresentante"
        Me.txtCedulaRepresentante.Size = New System.Drawing.Size(167, 20)
        Me.txtCedulaRepresentante.TabIndex = 43
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(195, 146)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtPrimerNombre.TabIndex = 50
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(195, 187)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtSegundoNombre.TabIndex = 52
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(195, 229)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(167, 20)
        Me.txtPrimerApellido.TabIndex = 54
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(195, 271)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(167, 20)
        Me.txtSegundoApellido.TabIndex = 56
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.Location = New System.Drawing.Point(536, 105)
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Size = New System.Drawing.Size(167, 20)
        Me.fechaNacimiento.TabIndex = 66
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(37, 357)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 37)
        Me.btnVolver.TabIndex = 68
        Me.btnVolver.Text = "Menú"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'RectangleShape1
        '
        '
        'ShapeContainer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 33)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "U.E.P ""San Ignacio de Loyola"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(534, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 14)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Sistema de control de inscripciones"
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnReporte.Location = New System.Drawing.Point(145, 357)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(161, 37)
        Me.btnReporte.TabIndex = 102
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 431)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.fechaNacimiento)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(CI_AlumnoLabel)
        Me.Controls.Add(Me.txtCedulaAlumno)
        Me.Controls.Add(CI_RLabel)
        Me.Controls.Add(Me.txtCedulaRepresentante)
        Me.Controls.Add(PNombreLabel)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(SNombreLabel)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(PApellidoLabel)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(SApellidoLabel)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(SexoLabel)
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "alumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtCedulaAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents fechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
End Class
