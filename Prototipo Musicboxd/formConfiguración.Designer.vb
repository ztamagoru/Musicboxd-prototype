<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formConfiguración
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formConfiguración))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radioEspañol = New System.Windows.Forms.RadioButton()
        Me.radioIngles = New System.Windows.Forms.RadioButton()
        Me.radioJapones = New System.Windows.Forms.RadioButton()
        Me.radioFrances = New System.Windows.Forms.RadioButton()
        Me.radioRuso = New System.Windows.Forms.RadioButton()
        Me.buttonGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 42)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Ajustes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(54, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Idioma"
        '
        'radioEspañol
        '
        Me.radioEspañol.AutoSize = True
        Me.radioEspañol.Checked = True
        Me.radioEspañol.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioEspañol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radioEspañol.Location = New System.Drawing.Point(96, 84)
        Me.radioEspañol.Name = "radioEspañol"
        Me.radioEspañol.Size = New System.Drawing.Size(95, 32)
        Me.radioEspañol.TabIndex = 27
        Me.radioEspañol.TabStop = True
        Me.radioEspañol.Text = "Español"
        Me.radioEspañol.UseVisualStyleBackColor = True
        '
        'radioIngles
        '
        Me.radioIngles.AutoSize = True
        Me.radioIngles.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioIngles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radioIngles.Location = New System.Drawing.Point(96, 116)
        Me.radioIngles.Name = "radioIngles"
        Me.radioIngles.Size = New System.Drawing.Size(89, 32)
        Me.radioIngles.TabIndex = 28
        Me.radioIngles.Text = "English"
        Me.radioIngles.UseVisualStyleBackColor = True
        '
        'radioJapones
        '
        Me.radioJapones.AutoSize = True
        Me.radioJapones.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioJapones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radioJapones.Location = New System.Drawing.Point(96, 148)
        Me.radioJapones.Name = "radioJapones"
        Me.radioJapones.Size = New System.Drawing.Size(90, 32)
        Me.radioJapones.TabIndex = 29
        Me.radioJapones.Text = "日本語"
        Me.radioJapones.UseVisualStyleBackColor = True
        '
        'radioFrances
        '
        Me.radioFrances.AutoSize = True
        Me.radioFrances.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFrances.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radioFrances.Location = New System.Drawing.Point(96, 178)
        Me.radioFrances.Name = "radioFrances"
        Me.radioFrances.Size = New System.Drawing.Size(99, 32)
        Me.radioFrances.TabIndex = 30
        Me.radioFrances.Text = "Français"
        Me.radioFrances.UseVisualStyleBackColor = True
        '
        'radioRuso
        '
        Me.radioRuso.AutoSize = True
        Me.radioRuso.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioRuso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.radioRuso.Location = New System.Drawing.Point(96, 209)
        Me.radioRuso.Name = "radioRuso"
        Me.radioRuso.Size = New System.Drawing.Size(99, 32)
        Me.radioRuso.TabIndex = 31
        Me.radioRuso.Text = "Русский"
        Me.radioRuso.UseVisualStyleBackColor = True
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.buttonGuardar.Location = New System.Drawing.Point(211, 261)
        Me.buttonGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(80, 32)
        Me.buttonGuardar.TabIndex = 34
        Me.buttonGuardar.Text = "Guardar"
        Me.buttonGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(126, 261)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 32)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Cerrar MB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(11, 261)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 32)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cerrar sesión"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'formConfiguración
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(302, 304)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.buttonGuardar)
        Me.Controls.Add(Me.radioRuso)
        Me.Controls.Add(Me.radioFrances)
        Me.Controls.Add(Me.radioJapones)
        Me.Controls.Add(Me.radioIngles)
        Me.Controls.Add(Me.radioEspañol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formConfiguración"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radioEspañol As RadioButton
    Friend WithEvents radioIngles As RadioButton
    Friend WithEvents radioJapones As RadioButton
    Friend WithEvents radioFrances As RadioButton
    Friend WithEvents radioRuso As RadioButton
    Friend WithEvents buttonGuardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
