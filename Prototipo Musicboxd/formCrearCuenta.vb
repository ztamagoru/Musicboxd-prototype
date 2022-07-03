Public Class formCrearCuenta
    Private Sub buttonIniciarSesion_Click(sender As Object, e As EventArgs) Handles buttonIniciarSesión.Click
        formIniciarSesion.Show()
        Me.Hide()

        textboxNombre.Text = String.Empty
        textboxUsuario.Text = String.Empty
        textboxContrasena.Text = String.Empty
        textboxCorreo.Text = String.Empty
    End Sub

    Private Sub buttonCrearCuenta_Click(sender As Object, e As EventArgs) Handles buttonCrearCuenta.Click
        If textboxNombre.Text = String.Empty Or
                textboxUsuario.Text = String.Empty Or
                textboxContrasena.Text = String.Empty Or
                textboxCorreo.Text = String.Empty Then
            MessageBox.Show("Campos sin rellenar.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf textboxContrasena.TextLength < 8 Then
            MessageBox.Show("Contraseña débil. Mínimo 8 caracteres." + Environment.NewLine + "Por favor, vuelva a ingresar.",
                            "Error",
                            MessageBoxButtons.OK)
        ElseIf comprobarMail(textboxCorreo.Text.Trim) = False Then
            MessageBox.Show("Mail inválido." + Environment.NewLine + "Por favor, vuelva a ingresar. 1",
                            "Error",
                            MessageBoxButtons.OK)
        ElseIf sacarDominio(textboxCorreo.Text.Trim) <> "gmail" And sacarDominio(textboxCorreo.Text.Trim) <> "outlook" And
            sacarDominio(textboxCorreo.Text.Trim) <> "yahoo" And sacarDominio(textboxCorreo.Text.Trim) <> "hotmail" And
            sacarDominio(textboxCorreo.Text.Trim) <> "live" And sacarDominio(textboxCorreo.Text.Trim) <> "gmx" And
            sacarDominio(textboxCorreo.Text.Trim) <> "zoho" And sacarDominio(textboxCorreo.Text.Trim) <> "tutanota" Then
            MessageBox.Show("Mail inválido." + Environment.NewLine + "Por favor, vuelva a ingresar. 2",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            Me.Hide()
            formIniciarSesion.Show()

            MessageBox.Show("Cuenta creada con éxito.",
                            "Aviso",
                            MessageBoxButtons.OK)

            formPantallaInicio.labelUsuario.Text = textboxUsuario.Text.Trim
            formPantallaReview.labelUsuario.Text = textboxUsuario.Text.Trim
        End If
    End Sub

    Function comprobarMail(mail As String) As Boolean
        Dim resultado As Boolean
        Dim x As String
        Dim y, p, arr, ca, cp As Integer

        resultado = True
        ca = 0
        cp = 0

        For i = 1 To Len(mail)
            x = GetChar(mail, i)
            y = Asc(x)

            If y = 64 Then
                arr = i
                ca = ca + 1
            End If

            If y = 46 Then
                p = i
                cp = cp + 1
            End If
        Next

        If arr < 2 Or ca <> 1 Then
            resultado = False
        End If

        If resultado = True Then
            If p + 1 < arr Or cp <> 1 Or (Len(mail) - 3) < p Then
                resultado = False
            End If
        End If

        Return resultado
    End Function

    Function sacarDominio(mail As String) As String
        Dim dominio, x As String
        Dim t As Boolean
        Dim y As Integer

        dominio = ""
        t = False

        For i = 1 To Len(mail)
            x = GetChar(mail, i)
            y = Asc(x)

            If y = 64 Then
                For z = i + 1 To Len(mail)
                    x = GetChar(mail, z)
                    y = Asc(x)

                    If y <> 46 Then
                        dominio = dominio + x
                    Else
                        t = True
                        Exit For
                    End If
                Next
            End If

            If t = True Then
                Exit For
            End If
        Next

        Return dominio
    End Function

    Private Sub formCrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pictureSettings.Image = Imagenes.ajustar_tuerquita(pictureSettings.Image)
    End Sub

    Private Sub pictureSettings_Click(sender As Object, e As EventArgs) Handles pictureSettings.Click
        formConfiguración.Show()
    End Sub

    Private Sub textboxUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxUsuario.KeyPress
        If InStr(1, Chr(8) & "qwertyuiopasdfghjklñzxcvbnm1234567890.¡!<>-_¿?", e.KeyChar) = 0 Then
            e.KeyChar = ""
            MessageBox.Show("Caracter inválido.",
                            "Aviso",
                            MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub textboxContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxContrasena.KeyPress
        If InStr(1, Chr(32), e.KeyChar) = 1 Then
            e.KeyChar = ""
            MessageBox.Show("Caracter inválido." + Environment.NewLine +
                            "No se permite el uso de espacios",
                            "Aviso",
                            MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub textboxCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxCorreo.KeyPress
        If InStr(1, Chr(32), e.KeyChar) = 1 Then
            e.KeyChar = ""
            MessageBox.Show("Caracter inválido." + Environment.NewLine +
                            "No se permite el uso de espacios",
                            "Aviso",
                            MessageBoxButtons.OK)
        End If
    End Sub
End Class