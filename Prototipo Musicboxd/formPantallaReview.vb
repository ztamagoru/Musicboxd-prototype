Imports System.Drawing.Drawing2D

Public Class formPantallaReview
    Private Sub formPantallaReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picturePFP.Image = Imagenes.PFPredonda(picturePFP.Image)

        pictureSettings.Image = Imagenes.ajustar_tuerquita(pictureSettings.Image)
    End Sub

    Private Sub pictureLogo_Click(sender As Object, e As EventArgs) Handles pictureLogo.Click
        Me.Hide()
        formPantallaInicio.Show()
    End Sub

    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs) Handles buttonBuscar.Click
        If textboxBuscador.Text = String.Empty Then
            MessageBox.Show("Campos sin rellenar.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub labelArtista_Click(sender As Object, e As EventArgs) Handles labelArtista.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub pictureAlbum_Click(sender As Object, e As EventArgs) Handles pictureAlbum.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub buttonAñadirReseña_Click(sender As Object, e As EventArgs) Handles buttonAñadirReseña.Click
        Dim review As String = textboxReseña.Text.Trim
        Dim usuario As String = labelUsuario.Text

        ' Esta parte me la enseñó Marquez, por eso la similitud a la hora de crear la reseña

        Dim mensaje As String = formCrearCuenta.textboxUsuario.Text.Trim + ": " + review
        Dim lista As ListViewItem = New ListViewItem(mensaje)

        If textboxReseña.Text = String.Empty Then
            MessageBox.Show("Campos sin rellenar.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            If listAlbum1.Visible() = True Then
                listAlbum1.Items.Add(lista)

            ElseIf listAlbum2.Visible() = True Then
                listAlbum2.Items.Add(lista)

            ElseIf listAlbum3.Visible() = True Then
                listAlbum3.Items.Add(lista)

            ElseIf listAlbum4.Visible() = True Then
                listAlbum4.Items.Add(lista)

            ElseIf listAlbum5.Visible() = True Then
                listAlbum5.Items.Add(lista)

            ElseIf listAlbum6.Visible() = True Then
                listAlbum6.Items.Add(lista)

            ElseIf listAlbum7.Visible() = True Then
                listAlbum7.Items.Add(lista)

            ElseIf listAlbum8.Visible() = True Then
                listAlbum8.Items.Add(lista)

            ElseIf listAlbum9.Visible() = True Then
                listAlbum9.Items.Add(lista)

            ElseIf listAlbum10.Visible = True Then
                listAlbum10.Items.Add(lista)
            End If
        End If
    End Sub

    Private Sub linkSpotify_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSpotify.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub linkiTunes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkiTunes.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub linkDeezer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDeezer.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub pictureSettings_Click(sender As Object, e As EventArgs) Handles pictureSettings.Click
        formConfiguración.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        formPantallaInicio.Show()
        Me.Hide()
    End Sub
End Class