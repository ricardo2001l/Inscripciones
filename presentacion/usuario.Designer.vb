<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuario
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuario))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.radioAdmin = New System.Windows.Forms.RadioButton()
        Me.radioEncargado = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CI_RLabel = New System.Windows.Forms.Label()
        PNombreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CI_RLabel
        '
        CI_RLabel.AutoSize = True
        CI_RLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        CI_RLabel.Location = New System.Drawing.Point(55, 66)
        CI_RLabel.Name = "CI_RLabel"
        CI_RLabel.Size = New System.Drawing.Size(60, 17)
        CI_RLabel.TabIndex = 97
        CI_RLabel.Text = "Usuario:"
        '
        'PNombreLabel
        '
        PNombreLabel.AutoSize = True
        PNombreLabel.Font = New System.Drawing.Font("Rockwell", 10.25!)
        PNombreLabel.Location = New System.Drawing.Point(55, 105)
        PNombreLabel.Name = "PNombreLabel"
        PNombreLabel.Size = New System.Drawing.Size(50, 17)
        PNombreLabel.TabIndex = 99
        PNombreLabel.Text = "Clave:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Rockwell", 10.25!)
        Label1.Location = New System.Drawing.Point(55, 152)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(113, 17)
        Label1.TabIndex = 108
        Label1.Text = "Tipo de usuario:"
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(26, 267)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(93, 37)
        Me.btnVolver.TabIndex = 105
        Me.btnVolver.Text = "Menú"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnAnadir.Location = New System.Drawing.Point(355, 212)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(93, 37)
        Me.btnAnadir.TabIndex = 103
        Me.btnAnadir.Text = "Agregar"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnModificar.Location = New System.Drawing.Point(244, 267)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 37)
        Me.btnModificar.TabIndex = 102
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.btnBorrar.Location = New System.Drawing.Point(355, 267)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(93, 37)
        Me.btnBorrar.TabIndex = 101
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(121, 66)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(294, 20)
        Me.txtUsuario.TabIndex = 98
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(121, 105)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(294, 20)
        Me.txtClave.TabIndex = 100
        '
        'radioAdmin
        '
        Me.radioAdmin.AutoSize = True
        Me.radioAdmin.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAdmin.Location = New System.Drawing.Point(194, 152)
        Me.radioAdmin.Name = "radioAdmin"
        Me.radioAdmin.Size = New System.Drawing.Size(109, 20)
        Me.radioAdmin.TabIndex = 106
        Me.radioAdmin.TabStop = True
        Me.radioAdmin.Text = "Administrador"
        Me.radioAdmin.UseVisualStyleBackColor = True
        '
        'radioEncargado
        '
        Me.radioEncargado.AutoSize = True
        Me.radioEncargado.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioEncargado.Location = New System.Drawing.Point(325, 152)
        Me.radioEncargado.Name = "radioEncargado"
        Me.radioEncargado.Size = New System.Drawing.Size(90, 20)
        Me.radioEncargado.TabIndex = 107
        Me.radioEncargado.TabStop = True
        Me.radioEncargado.Text = "Encargado"
        Me.radioEncargado.UseVisualStyleBackColor = True
        '
        'RectangleShape1
        '
        '
        'ShapeContainer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 14)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Sistema de control de inscripciones"
        '
        'usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(487, 341)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.radioEncargado)
        Me.Controls.Add(Me.radioAdmin)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(CI_RLabel)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(PNombreLabel)
        Me.Controls.Add(Me.txtClave)
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents radioAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents radioEncargado As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
