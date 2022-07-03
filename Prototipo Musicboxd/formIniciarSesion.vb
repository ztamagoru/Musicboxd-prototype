Public Class formIniciarSesion
    Private Sub buttonIniciarSesion_Click(sender As Object, e As EventArgs) Handles buttonIniciarSesion.Click
        If textboxUsuario.Text = String.Empty Or textboxContrasena.Text = String.Empty Then
            MessageBox.Show("Campos sin rellenar.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf textboxUsuario.Text <> formCrearCuenta.textboxUsuario.Text And
                textboxContrasena.Text <> formCrearCuenta.textboxContrasena.Text Then
            MessageBox.Show("Cuenta inexistente. Por favor, cree una cuenta.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf textboxUsuario.Text = formCrearCuenta.textboxUsuario.Text And
            textboxContrasena.Text <> formCrearCuenta.textboxContrasena.Text Then
            MessageBox.Show("Contraseña incorrecta. Vuelva a intentarlo.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf textboxUsuario.Text = formCrearCuenta.textboxUsuario.Text And
            textboxContrasena.Text = formCrearCuenta.textboxContrasena.Text Then
            formPantallaInicio.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub buttonRegistrarse_Click(sender As Object, e As EventArgs) Handles buttonRegistrarse.Click
        formCrearCuenta.Show()
        Me.Hide()
    End Sub

    Private Sub formIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pictureSettings.Image = Imagenes.ajustar_tuerquita(pictureSettings.Image)

        añadirComentarios()
    End Sub

    Private Sub añadirComentarios()
        Dim mensaje As String = "putifarrix7: " + Environment.NewLine + "Linda letra e canção!" + Environment.NewLine
        Dim lista As ListViewItem = New ListViewItem(mensaje)
        formPantallaReview.listAlbum1.Items.Add(lista)

        mensaje = "tomiomi: " + Environment.NewLine + "I’ve been a Beyoncé fan for 8+ years and I’m glad she has music for everyone’s taste and I love this new song" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum1.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "Slxt4Dxja: " + Environment.NewLine + "Esta canción es una Joyita" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum2.Items.Add(lista)

        mensaje = "zenful: " + Environment.NewLine + "THIS DUO WAS JUST WHAT WE NEEDED THIS SUMMER" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum2.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "MegaLag: " + Environment.NewLine + "What a talent" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum3.Items.Add(lista)

        mensaje = "Hushy: " + Environment.NewLine + "the worst feeling isn't being alone, its being forgotten by someone you could never forget." + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum3.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "shawnftyo: " + Environment.NewLine + "HARRY TE AMO CON TODO MI CORAZÓN" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum4.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "She: " + Environment.NewLine + "Que música perfeita Omg" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum5.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "devtimi: " + Environment.NewLine + "I remember this on MTV back in the day." + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum6.Items.Add(lista)

        mensaje = "OctiMostri: " + Environment.NewLine + "Fun fact: Neither the singer for Jamiroquai or the set is moving, nor are you, you’re in a coma and you need to wake up, we miss you" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum6.Items.Add(lista)

        mensaje = "くく: " + Environment.NewLine + "本当この音楽とPVかっこよくて大好き" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum6.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "NicoleL: " + Environment.NewLine + "Naomi and Bridget are such amazing singers" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum7.Items.Add(lista)

        mensaje = "NetflixNerd99: " + Environment.NewLine + "Yo la re vivia con esta cancion" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum7.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "Loreon: " + Environment.NewLine + "A moment of silence, for those who searched ""what about me""" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum8.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "Elycius: " + Environment.NewLine + "This would be a couple's perfect ""1St dance"" song at their wedding." + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum9.Items.Add(lista)

        mensaje = "andypuki: " + Environment.NewLine + "Goosebumps and shaking hearing this. Hits me every time." + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum9.Items.Add(lista)

        mensaje = "ReLin: " + Environment.NewLine + "Bine de tot regina muzicii pop o adevărată artistă" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum9.Items.Add(lista)

        '/////////////////////////////////////////////////////////////

        mensaje = "SalameUntable: " + Environment.NewLine + "2022 y aún pienso que estos Rap eran lo mejor de lo mejor" + Environment.NewLine
        lista = New ListViewItem(mensaje)
        formPantallaReview.listAlbum10.Items.Add(lista)
    End Sub

    Private Sub pictureSettings_Click(sender As Object, e As EventArgs) Handles pictureSettings.Click
        formConfiguración.Show()
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
End Class
