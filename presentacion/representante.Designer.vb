<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class representante
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
        Dim SecciónLabel As System.Windows.Forms.Label
        Dim PNombreLabel As System.Windows.Forms.Label
        Dim SNombreLabel As System.Windows.Forms.Label
        Dim PApellidoLabel As System.Windows.Forms.Label
        Dim SApellidoLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(representante))
        Me.fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtCedulaRepresentante = New System.Windows.Forms.TextBox()
        Me.txtDirreccion = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        CI_RLabel = New System.Windows.Forms.Label()
        SecciónLabel = New System.Windows.Forms.Label()
        PNombreLabel = New System.Windows.Forms.Label()
        SNombreLabel = New System.Windows.Forms.Label()
        PApellidoLabel = New System.Windows.Forms.Label()
        SApellidoLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CI_RLabel
        '
        CI_RLabel.AutoSize = True
        CI_RLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        CI_RLabel.Location = New System.Drawing.Point(19, 104)
        CI_RLabel.Name = "CI_RLabel"
        CI_RLabel.Size = New System.Drawing.Size(123, 17)
        CI_RLabel.TabIndex = 70
        CI_RLabel.Text = "CI Representante:"
        '
        'SecciónLabel
        '
        SecciónLabel.AutoSize = True
        SecciónLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SecciónLabel.Location = New System.Drawing.Point(372, 196)
        SecciónLabel.Name = "SecciónLabel"
        SecciónLabel.Size = New System.Drawing.Size(67, 17)
        SecciónLabel.TabIndex = 75
        SecciónLabel.Text = "Direción:"
        '
        'PNombreLabel
        '
        PNombreLabel.AutoSize = True
        PNombreLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        PNombreLabel.Location = New System.Drawing.Point(20, 146)
        PNombreLabel.Name = "PNombreLabel"
        PNombreLabel.Size = New System.Drawing.Size(111, 17)
        PNombreLabel.TabIndex = 77
        PNombreLabel.Text = "Primer nombre:"
        '
        'SNombreLabel
        '
        SNombreLabel.AutoSize = True
        SNombreLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SNombreLabel.Location = New System.Drawing.Point(19, 189)
        SNombreLabel.Name = "SNombreLabel"
        SNombreLabel.Size = New System.Drawing.Size(124, 17)
        SNombreLabel.TabIndex = 79
        SNombreLabel.Text = "Segundo nombre:"
        '
        'PApellidoLabel
        '
        PApellidoLabel.AutoSize = True
        PApellidoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        PApellidoLabel.Location = New System.Drawing.Point(19, 236)
        PApellidoLabel.Name = "PApellidoLabel"
        PApellidoLabel.Size = New System.Drawing.Size(113, 17)
        PApellidoLabel.TabIndex = 81
        PApellidoLabel.Text = "Primer apellido:"
        '
        'SApellidoLabel
        '
        SApellidoLabel.AutoSize = True
        SApellidoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SApellidoLabel.Location = New System.Drawing.Point(20, 282)
        SApellidoLabel.Name = "SApellidoLabel"
        SApellidoLabel.Size = New System.Drawing.Size(126, 17)
        SApellidoLabel.TabIndex = 83
        SApellidoLabel.Text = "Segundo apellido:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        EdadLabel.Location = New System.Drawing.Point(371, 103)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(141, 17)
        EdadLabel.TabIndex = 85
        EdadLabel.Text = "Fecha de nacimiento"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        SexoLabel.Location = New System.Drawing.Point(372, 145)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(43, 17)
        SexoLabel.TabIndex = 86
        SexoLabel.Text = "Sexo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Rockwell", 10.25!)
        Label1.Location = New System.Drawing.Point(371, 258)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 17)
        Label1.TabIndex = 94
        Label1.Text = "Teléfono:"
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.Location = New System.Drawing.Point(518, 100)
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Size = New System.Drawing.Size(166, 20)
        Me.fechaNacimiento.TabIndex = 92
        '
        'cmbSexo
        '
        Me.cmbSexo.BackColor = System.Drawing.Color.White
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(445, 148)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(240, 21)
        Me.cmbSexo.TabIndex = 91
        '
        'btnAnadir
        '
        Me.btnAnadir.BackColor = System.Drawing.Color.White
        Me.btnAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnAnadir.Location = New System.Drawing.Point(411, 360)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(93, 37)
        Me.btnAnadir.TabIndex = 89
        Me.btnAnadir.Text = "Agregar"
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnModificar.Location = New System.Drawing.Point(510, 360)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 37)
        Me.btnModificar.TabIndex = 88
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnBorrar.Location = New System.Drawing.Point(609, 360)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(93, 37)
        Me.btnBorrar.TabIndex = 87
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtCedulaRepresentante
        '
        Me.txtCedulaRepresentante.Location = New System.Drawing.Point(198, 103)
        Me.txtCedulaRepresentante.Name = "txtCedulaRepresentante"
        Me.txtCedulaRepresentante.Size = New System.Drawing.Size(166, 20)
        Me.txtCedulaRepresentante.TabIndex = 71
        '
        'txtDirreccion
        '
        Me.txtDirreccion.Location = New System.Drawing.Point(445, 196)
        Me.txtDirreccion.Name = "txtDirreccion"
        Me.txtDirreccion.Size = New System.Drawing.Size(239, 20)
        Me.txtDirreccion.TabIndex = 76
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(198, 146)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtPrimerNombre.TabIndex = 78
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(198, 189)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtSegundoNombre.TabIndex = 80
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(198, 235)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(166, 20)
        Me.txtPrimerApellido.TabIndex = 82
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(198, 279)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(166, 20)
        Me.txtSegundoApellido.TabIndex = 84
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(36, 360)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 37)
        Me.btnVolver.TabIndex = 96
        Me.btnVolver.Text = "Menú"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(445, 255)
        Me.txtTelefono.Mask = "0000-0000000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(239, 20)
        Me.txtTelefono.TabIndex = 97
        '
        'ShapeContainer1
        '
        '
        'RectangleShape1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 33)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "U.E.P ""San Ignacio de Loyola"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(534, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 14)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Sistema de control de inscripciones"
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnReporte.Location = New System.Drawing.Point(145, 360)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(161, 37)
        Me.btnReporte.TabIndex = 103
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'representante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 431)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.fechaNacimiento)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(CI_RLabel)
        Me.Controls.Add(Me.txtCedulaRepresentante)
        Me.Controls.Add(SecciónLabel)
        Me.Controls.Add(Me.txtDirreccion)
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
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "representante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Representante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtCedulaRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents txtDirreccion As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
End Class
