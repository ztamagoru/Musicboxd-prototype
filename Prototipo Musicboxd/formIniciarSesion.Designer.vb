<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formIniciarSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formIniciarSesion))
        Me.textboxContrasena = New System.Windows.Forms.TextBox()
        Me.buttonRegistrarse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonIniciarSesion = New System.Windows.Forms.Button()
        Me.textboxUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pictureSettings = New System.Windows.Forms.PictureBox()
        Me.pictureLogo = New System.Windows.Forms.PictureBox()
        Me.pictureFondo1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureFondo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textboxContrasena
        '
        Me.textboxContrasena.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.textboxContrasena.Location = New System.Drawing.Point(350, 353)
        Me.textboxContrasena.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxContrasena.Name = "textboxContrasena"
        Me.textboxContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textboxContrasena.Size = New System.Drawing.Size(193, 31)
        Me.textboxContrasena.TabIndex = 14
        '
        'buttonRegistrarse
        '
        Me.buttonRegistrarse.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRegistrarse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.buttonRegistrarse.Location = New System.Drawing.Point(421, 483)
        Me.buttonRegistrarse.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRegistrarse.Name = "buttonRegistrarse"
        Me.buttonRegistrarse.Size = New System.Drawing.Size(86, 31)
        Me.buttonRegistrarse.TabIndex = 17
        Me.buttonRegistrarse.Text = "Registrarse"
        Me.buttonRegistrarse.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(252, 356)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(282, 490)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "No tienes una cuenta?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(280, 314)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Usuario"
        '
        'buttonIniciarSesion
        '
        Me.buttonIniciarSesion.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.buttonIniciarSesion.Location = New System.Drawing.Point(350, 404)
        Me.buttonIniciarSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonIniciarSesion.Name = "buttonIniciarSesion"
        Me.buttonIniciarSesion.Size = New System.Drawing.Size(96, 32)
        Me.buttonIniciarSesion.TabIndex = 15
        Me.buttonIniciarSesion.Text = "Iniciar sesión"
        Me.buttonIniciarSesion.UseVisualStyleBackColor = True
        '
        'textboxUsuario
        '
        Me.textboxUsuario.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.textboxUsuario.Location = New System.Drawing.Point(350, 312)
        Me.textboxUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxUsuario.Name = "textboxUsuario"
        Me.textboxUsuario.Size = New System.Drawing.Size(193, 31)
        Me.textboxUsuario.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Una nueva manera de descubrir música"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(322, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Musicboxd"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(478, 551)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(321, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Prototipo Musicboxd 01/07/2022 - María Zdanovitch"
        '
        'pictureSettings
        '
        Me.pictureSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureSettings.Image = Global.Prototipo_Musicboxd.My.Resources.Resources.d579d5d1226c79750dbc44c16c9d2672
        Me.pictureSettings.Location = New System.Drawing.Point(0, 0)
        Me.pictureSettings.Name = "pictureSettings"
        Me.pictureSettings.Size = New System.Drawing.Size(38, 37)
        Me.pictureSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureSettings.TabIndex = 22
        Me.pictureSettings.TabStop = False
        '
        'pictureLogo
        '
        Me.pictureLogo.Image = Global.Prototipo_Musicboxd.My.Resources.Resources.logo_musicboxd
        Me.pictureLogo.Location = New System.Drawing.Point(268, 56)
        Me.pictureLogo.Name = "pictureLogo"
        Me.pictureLogo.Size = New System.Drawing.Size(260, 189)
        Me.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureLogo.TabIndex = 18
        Me.pictureLogo.TabStop = False
        '
        'pictureFondo1
        '
        Me.pictureFondo1.Image = Global.Prototipo_Musicboxd.My.Resources.Resources.Untitled_1
        Me.pictureFondo1.Location = New System.Drawing.Point(-247, 413)
        Me.pictureFondo1.Name = "pictureFondo1"
        Me.pictureFondo1.Size = New System.Drawing.Size(592, 238)
        Me.pictureFondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureFondo1.TabIndex = 19
        Me.pictureFondo1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prototipo_Musicboxd.My.Resources.Resources.Untitled_2
        Me.PictureBox1.Location = New System.Drawing.Point(487, -92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(592, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'formIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 571)
        Me.Controls.Add(Me.pictureSettings)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textboxContrasena)
        Me.Controls.Add(Me.buttonRegistrarse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonIniciarSesion)
        Me.Controls.Add(Me.textboxUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pictureLogo)
        Me.Controls.Add(Me.pictureFondo1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formIniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.pictureSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureFondo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxContrasena As TextBox
    Friend WithEvents buttonRegistrarse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonIniciarSesion As Button
    Friend WithEvents textboxUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pictureLogo As PictureBox
    Friend WithEvents pictureFondo1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pictureSettings As PictureBox
End Class
