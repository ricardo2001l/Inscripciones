<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inscripciones
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
        Dim CI_RLabel As System.Windows.Forms.Label
        Dim PNombreLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim GradoLabel As System.Windows.Forms.Label
        Dim SecciónLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inscripciones))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtCedulaAlumno = New System.Windows.Forms.TextBox()
        Me.cmbIDInscripcion = New System.Windows.Forms.ComboBox()
        Me.txtSeccion = New System.Windows.Forms.MaskedTextBox()
        Me.txtGrado = New System.Windows.Forms.MaskedTextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtPeriodoEscolar = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        CI_RLabel = New System.Windows.Forms.Label()
        PNombreLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        GradoLabel = New System.Windows.Forms.Label()
        SecciónLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CI_RLabel
        '
        CI_RLabel.AutoSize = True
        CI_RLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        CI_RLabel.Location = New System.Drawing.Point(60, 99)
        CI_RLabel.Name = "CI_RLabel"
        CI_RLabel.Size = New System.Drawing.Size(101, 17)
        CI_RLabel.TabIndex = 98
        CI_RLabel.Text = "ID Inscripcion:"
        '
        'PNombreLabel
        '
        PNombreLabel.AutoSize = True
        PNombreLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        PNombreLabel.Location = New System.Drawing.Point(61, 137)
        PNombreLabel.Name = "PNombreLabel"
        PNombreLabel.Size = New System.Drawing.Size(81, 17)
        PNombreLabel.TabIndex = 102
        PNombreLabel.Text = "CI Alumno:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        FechaLabel.Location = New System.Drawing.Point(60, 175)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(140, 17)
        FechaLabel.TabIndex = 122
        FechaLabel.Text = "Fecha de Incripcion:"
        '
        'GradoLabel
        '
        GradoLabel.AutoSize = True
        GradoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        GradoLabel.Location = New System.Drawing.Point(61, 213)
        GradoLabel.Name = "GradoLabel"
        GradoLabel.Size = New System.Drawing.Size(53, 17)
        GradoLabel.TabIndex = 123
        GradoLabel.Text = "Grado:"
        '
        'SecciónLabel
        '
        SecciónLabel.AutoSize = True
        SecciónLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SecciónLabel.Location = New System.Drawing.Point(60, 250)
        SecciónLabel.Name = "SecciónLabel"
        SecciónLabel.Size = New System.Drawing.Size(61, 17)
        SecciónLabel.TabIndex = 124
        SecciónLabel.Text = "Sección:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Rockwell", 10.25!)
        Label1.Location = New System.Drawing.Point(60, 288)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(113, 17)
        Label1.TabIndex = 128
        Label1.Text = "Periodo escolar:"
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(44, 383)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 37)
        Me.btnVolver.TabIndex = 119
        Me.btnVolver.Text = "Menú"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnAnadir.Location = New System.Drawing.Point(312, 330)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(93, 37)
        Me.btnAnadir.TabIndex = 114
        Me.btnAnadir.Text = "Agregar"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnModificar.Location = New System.Drawing.Point(203, 383)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 37)
        Me.btnModificar.TabIndex = 113
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnBorrar.Location = New System.Drawing.Point(312, 383)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(93, 37)
        Me.btnBorrar.TabIndex = 112
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtCedulaAlumno
        '
        Me.txtCedulaAlumno.Location = New System.Drawing.Point(238, 134)
        Me.txtCedulaAlumno.Name = "txtCedulaAlumno"
        Me.txtCedulaAlumno.Size = New System.Drawing.Size(166, 20)
        Me.txtCedulaAlumno.TabIndex = 103
        '
        'cmbIDInscripcion
        '
        Me.cmbIDInscripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIDInscripcion.FormattingEnabled = True
        Me.cmbIDInscripcion.Location = New System.Drawing.Point(239, 95)
        Me.cmbIDInscripcion.Name = "cmbIDInscripcion"
        Me.cmbIDInscripcion.Size = New System.Drawing.Size(166, 21)
        Me.cmbIDInscripcion.TabIndex = 121
        '
        'txtSeccion
        '
        Me.txtSeccion.Location = New System.Drawing.Point(238, 247)
        Me.txtSeccion.Mask = "L"
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(166, 20)
        Me.txtSeccion.TabIndex = 127
        '
        'txtGrado
        '
        Me.txtGrado.Location = New System.Drawing.Point(238, 210)
        Me.txtGrado.Mask = "0"
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(166, 20)
        Me.txtGrado.TabIndex = 126
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(238, 172)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(166, 20)
        Me.fecha.TabIndex = 125
        Me.fecha.Value = New Date(2021, 4, 26, 16, 12, 0, 0)
        '
        'txtPeriodoEscolar
        '
        Me.txtPeriodoEscolar.Location = New System.Drawing.Point(238, 285)
        Me.txtPeriodoEscolar.Mask = "0000-0000"
        Me.txtPeriodoEscolar.Name = "txtPeriodoEscolar"
        Me.txtPeriodoEscolar.Size = New System.Drawing.Size(166, 20)
        Me.txtPeriodoEscolar.TabIndex = 129
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
        Me.Label2.Location = New System.Drawing.Point(46, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 33)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "U.E.P ""San Ignacio de Loyola"""
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnReporte.Location = New System.Drawing.Point(44, 330)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(93, 47)
        Me.btnReporte.TabIndex = 132
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'inscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(458, 446)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPeriodoEscolar)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.txtGrado)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(GradoLabel)
        Me.Controls.Add(SecciónLabel)
        Me.Controls.Add(Me.cmbIDInscripcion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(CI_RLabel)
        Me.Controls.Add(PNombreLabel)
        Me.Controls.Add(Me.txtCedulaAlumno)
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inscripciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar inscripciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtCedulaAlumno As System.Windows.Forms.TextBox
    Friend WithEvents cmbIDInscripcion As System.Windows.Forms.ComboBox
    Friend WithEvents txtSeccion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtGrado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPeriodoEscolar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
End Class
