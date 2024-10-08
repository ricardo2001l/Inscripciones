<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnRepresentante = New System.Windows.Forms.Button()
        Me.btnAlumno = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBaseDatos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Gadugi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Location = New System.Drawing.Point(12, 303)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(216, 42)
        Me.btnCerrarSesion.TabIndex = 68
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.Location = New System.Drawing.Point(382, 172)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(332, 40)
        Me.btnUsuario.TabIndex = 69
        Me.btnUsuario.Text = "Gestionar Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'btnRepresentante
        '
        Me.btnRepresentante.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnRepresentante.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon
        Me.btnRepresentante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRepresentante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRepresentante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepresentante.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepresentante.ForeColor = System.Drawing.Color.White
        Me.btnRepresentante.Location = New System.Drawing.Point(12, 67)
        Me.btnRepresentante.Name = "btnRepresentante"
        Me.btnRepresentante.Size = New System.Drawing.Size(332, 40)
        Me.btnRepresentante.TabIndex = 71
        Me.btnRepresentante.Text = "Registrar Representante"
        Me.btnRepresentante.UseVisualStyleBackColor = False
        '
        'btnAlumno
        '
        Me.btnAlumno.BackColor = System.Drawing.Color.Salmon
        Me.btnAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Salmon
        Me.btnAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumno.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumno.ForeColor = System.Drawing.Color.White
        Me.btnAlumno.Location = New System.Drawing.Point(12, 132)
        Me.btnAlumno.Name = "btnAlumno"
        Me.btnAlumno.Size = New System.Drawing.Size(332, 40)
        Me.btnAlumno.TabIndex = 72
        Me.btnAlumno.Text = "Registrar Alumno"
        Me.btnAlumno.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Gadugi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(561, 303)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(153, 42)
        Me.btnSalir.TabIndex = 73
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBaseDatos
        '
        Me.btnBaseDatos.BackColor = System.Drawing.Color.LightSalmon
        Me.btnBaseDatos.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon
        Me.btnBaseDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBaseDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaseDatos.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaseDatos.ForeColor = System.Drawing.Color.White
        Me.btnBaseDatos.Location = New System.Drawing.Point(382, 101)
        Me.btnBaseDatos.Name = "btnBaseDatos"
        Me.btnBaseDatos.Size = New System.Drawing.Size(332, 40)
        Me.btnBaseDatos.TabIndex = 74
        Me.btnBaseDatos.Text = "Base de Datos"
        Me.btnBaseDatos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(332, 40)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Generar Inscripción"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(735, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBaseDatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAlumno)
        Me.Controls.Add(Me.btnRepresentante)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents btnRepresentante As System.Windows.Forms.Button
    Friend WithEvents btnAlumno As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBaseDatos As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
