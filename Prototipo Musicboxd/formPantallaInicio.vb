Imports System.Drawing.Drawing2D

Public Class formPantallaInicio
    Private Sub formPantallaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picturePFP.Image = Imagenes.PFPredonda(picturePFP.Image)

        pictureSettings.Image = Imagenes.ajustar_tuerquita(pictureSettings.Image)
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

    Private Sub pictureSettings_Click(sender As Object, e As EventArgs) Handles pictureSettings.Click
        formConfiguración.Show()
    End Sub

    Private Sub pictureAlbum1_Click(sender As Object, e As EventArgs) Handles pictureAlbum1.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum1.Image
        formPantallaReview.labelNombreCancion.Text = "BREAK MY SOUL"
        formPantallaReview.labelArtista.Text = "Beyoncé"
        formPantallaReview.labelDescripcion.Text = "«BREAK MY SOUL» es una canción de la cantante y compositora estadounidense Beyoncé. Fue lanzado el 20 de junio de 2022 a través de Parkwood y Columbia, como el sencillo principal​ del próximo séptimo álbum de estudio de Beyoncé ""Renaissance"" (2022)."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/2KukL7UlQ8TdvpaA7bY3ZJ?si=948aa990a5714176")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/break-my-soul/1630005298?i=1630005854")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/KZCKcTPHeHN3NniX6")

        formPantallaReview.listAlbum1.Visible = True
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum1.Image
        formPantallaReview.labelNombreCancion.Text = "BREAK MY SOUL"
        formPantallaReview.labelArtista.Text = "Beyoncé"
        formPantallaReview.labelDescripcion.Text = "«BREAK MY SOUL» es una canción de la cantante y compositora estadounidense Beyoncé. Fue lanzado el 20 de junio de 2022 a través de Parkwood y Columbia, como el sencillo principal​ del próximo séptimo álbum de estudio de Beyoncé ""Renaissance"" (2022)."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/2KukL7UlQ8TdvpaA7bY3ZJ?si=948aa990a5714176")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/break-my-soul/1630005298?i=1630005854")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/KZCKcTPHeHN3NniX6")

        formPantallaReview.listAlbum1.Visible = True
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum2_Click(sender As Object, e As EventArgs) Handles pictureAlbum2.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum2.Image
        formPantallaReview.labelNombreCancion.Text = "I Like You (A Happier Song) (with Doja Cat)"
        formPantallaReview.labelArtista.Text = "Post Malone, Doja Cat"
        formPantallaReview.labelDescripcion.Text = "Un track con buen rollo y ritmo pegadizo, en el que Post Malone recluta por primera vez a la cantante y rapera Doja Cat para hablar desde la perspectiva de una posible relación amorosa entre una mujer y un hombre."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/0O6u0VJ46W86TxN9wgyqDj?si=57856048316b4573")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/i-like-you-a-happier-song-feat-doja-cat/1623192950?i=1623193283")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/3pNkwaJzYfKWTnvp6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = True
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum2.Image
        formPantallaReview.labelNombreCancion.Text = "I Like You (A Happier Song) (with Doja Cat)"
        formPantallaReview.labelArtista.Text = "Post Malone, Doja Cat"
        formPantallaReview.labelDescripcion.Text = "Un track con buen rollo y ritmo pegadizo, en el que Post Malone recluta por primera vez a la cantante y rapera Doja Cat para hablar desde la perspectiva de una posible relación amorosa entre una mujer y un hombre."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/0O6u0VJ46W86TxN9wgyqDj?si=57856048316b4573")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/i-like-you-a-happier-song-feat-doja-cat/1623192950?i=1623193283")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/3pNkwaJzYfKWTnvp6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = True
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum3_Click(sender As Object, e As EventArgs) Handles pictureAlbum3.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum3.Image
        formPantallaReview.labelNombreCancion.Text = "Glimpse of Us"
        formPantallaReview.labelArtista.Text = "Joji"
        formPantallaReview.labelDescripcion.Text = "Primera oferta musical de Joji como artista principal desde el lanzamiento de su segundo álbum de estudio, Nectar, en septiembre de 2020. En la pista, Joji compara su relación actual con la conexión que sintió con un amante pasado, incapaz de olvidar los sentimientos que tuvo. en su pasado mientras estaba con su pareja actual."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/6xGruZOHLs39ZbVccQTuPZ?si=79089e2efae440e0")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/glimpse-of-us/1625328890?i=1625328892")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/iRDuCRrS5k6Dgfas8")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = True
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum3.Image
        formPantallaReview.labelNombreCancion.Text = "Glimpse of Us"
        formPantallaReview.labelArtista.Text = "Joji"
        formPantallaReview.labelDescripcion.Text = "Primera oferta musical de Joji como artista principal desde el lanzamiento de su segundo álbum de estudio, Nectar, en septiembre de 2020. En la pista, Joji compara su relación actual con la conexión que sintió con un amante pasado, incapaz de olvidar los sentimientos que tuvo. en su pasado mientras estaba con su pareja actual."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/6xGruZOHLs39ZbVccQTuPZ?si=79089e2efae440e0")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/glimpse-of-us/1625328890?i=1625328892")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/iRDuCRrS5k6Dgfas8")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = True
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum4_Click(sender As Object, e As EventArgs) Handles pictureAlbum4.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum4.Image
        formPantallaReview.labelNombreCancion.Text = "As It Was"
        formPantallaReview.labelArtista.Text = "Harry Styles"
        formPantallaReview.labelDescripcion.Text = "El sencillo principal de su próximo tercer álbum Harry's House, ""As It Was"", muestra a Styles cantando con una voz un tanto triste sobre sus sentimientos agridulces de soledad y el pasado, enmascarándolo con sintetizadores y un sonido alegre que recuerda a la música de los años 80."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/4LRPiXqCikLlN15c3yImP7?si=36acc58b91834fe2")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/as-it-was/1615584999?i=1615585008")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/yAdtAemp9sjdKVsy6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = True
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum4.Image
        formPantallaReview.labelNombreCancion.Text = "As It Was"
        formPantallaReview.labelArtista.Text = "Harry Styles"
        formPantallaReview.labelDescripcion.Text = "El sencillo principal de su próximo tercer álbum Harry's House, ""As It Was"", muestra a Styles cantando con una voz un tanto triste sobre sus sentimientos agridulces de soledad y el pasado, enmascarándolo con sintetizadores y un sonido alegre que recuerda a la música de los años 80."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/4LRPiXqCikLlN15c3yImP7?si=36acc58b91834fe2")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/as-it-was/1615584999?i=1615585008")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/yAdtAemp9sjdKVsy6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = True
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum5_Click(sender As Object, e As EventArgs) Handles pictureAlbum5.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum5.Image
        formPantallaReview.labelNombreCancion.Text = "Left and Right (Feat. Jung Kook of BTS)"
        formPantallaReview.labelArtista.Text = "Charlie Puth, BTS, Jung Kook"
        formPantallaReview.labelDescripcion.Text = "Una canción pop alegre sobre el anhelo por el ex amor, marca el primer lanzamiento colaborativo oficial de Charlie Puth con Jung Kook de BTS."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/0mBP9X2gPCuapvpZ7TGDk3?si=534464da38c349d3")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/left-and-right/1630451412?i=1630451413")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/W1Cao6Kn9uPp6wuM6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = True
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum5.Image
        formPantallaReview.labelNombreCancion.Text = "Left and Right (Feat. Jung Kook of BTS)"
        formPantallaReview.labelArtista.Text = "Charlie Puth, BTS, Jung Kook"
        formPantallaReview.labelDescripcion.Text = "Una canción pop alegre sobre el anhelo por el ex amor, marca el primer lanzamiento colaborativo oficial de Charlie Puth con Jung Kook de BTS."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/0mBP9X2gPCuapvpZ7TGDk3?si=534464da38c349d3")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/left-and-right/1630451412?i=1630451413")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/W1Cao6Kn9uPp6wuM6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = True
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum6_Click(sender As Object, e As EventArgs) Handles pictureAlbum6.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum6.Image
        formPantallaReview.labelNombreCancion.Text = "Virtual Insanity (Remastered)"
        formPantallaReview.labelArtista.Text = "Jamiroquai"
        formPantallaReview.labelDescripcion.Text = "Canción del cantante británico Jay Kay, vocalista de la banda de funk Jamiroquai. Fue lanzado como el segundo sencillo de su tercer álbum de estudio, Travelling Without Moving (1996), el 19 de agosto de 1996."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/49TQfrsm60j5ZFKS59JOdU?si=16ac80e618014f24")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/virtual-insanity-remastered/786107608?i=786107630")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/KjUujVKUkBQHw9Cp8")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = True
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum6.Image
        formPantallaReview.labelNombreCancion.Text = "Virtual Insanity (Remastered)"
        formPantallaReview.labelArtista.Text = "Jamiroquai"
        formPantallaReview.labelDescripcion.Text = "Canción del cantante británico Jay Kay, vocalista de la banda de funk Jamiroquai. Fue lanzado como el segundo sencillo de su tercer álbum de estudio, Travelling Without Moving (1996), el 19 de agosto de 1996."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/49TQfrsm60j5ZFKS59JOdU?si=16ac80e618014f24")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/virtual-insanity-remastered/786107608?i=786107630")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/KjUujVKUkBQHw9Cp8")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = True
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum7_Click(sender As Object, e As EventArgs) Handles pictureAlbum7.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum7.Image
        formPantallaReview.labelNombreCancion.Text = "Living On a High Wire"
        formPantallaReview.labelArtista.Text = "Adam Hicks, Bridgit Mendler, Naomi Scott"
        formPantallaReview.labelDescripcion.Text = "Esta canción es la menos famosa de la película por ser parte de una escena eliminada. Todo el momento es una entrevista con esa banda ficticia."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/5twtkwNqXqaz7gp9zZ4Db4?si=b2832ec65caa4e50")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/livin-on-a-high-wire/1443906891?i=1443907082")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/3gZagk1en23YQWKi6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = True
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum7.Image
        formPantallaReview.labelNombreCancion.Text = "Living On a High Wire"
        formPantallaReview.labelArtista.Text = "Adam Hicks, Bridgit Mendler, Naomi Scott"
        formPantallaReview.labelDescripcion.Text = "Esta canción es la menos famosa de la película por ser parte de una escena eliminada. Todo el momento es una entrevista con esa banda ficticia."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/5twtkwNqXqaz7gp9zZ4Db4?si=b2832ec65caa4e50")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/livin-on-a-high-wire/1443906891?i=1443907082")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/3gZagk1en23YQWKi6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = True
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum8_Click(sender As Object, e As EventArgs) Handles pictureAlbum8.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum8.Image
        formPantallaReview.labelNombreCancion.Text = "Television / So Far So Good"
        formPantallaReview.labelArtista.Text = "Orange Rex County"
        formPantallaReview.labelDescripcion.Text = "Segunda pista del segundo álbum de Rex Orange County, ""Apricot Princess"". Cuenta con un ritmo fluctuante y voces crudas para permitir que el oyente se sumerja en el tempo de esta canción, lo que hace que las emociones poderosas se sientan casi palpables. Además, Alex describe el complicaciones infames de las relaciones y confesar sentimientos por aquellos de los que estás enamorado."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/5OUTFH5acycdnf8OVo21Gv?si=4e7a2450885e4ca0")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/television-so-far-so-good/1282018263?i=1282018585")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/hyceqnkh8J9Bk5m27")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = True
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum8.Image
        formPantallaReview.labelNombreCancion.Text = "Television / So Far So Good"
        formPantallaReview.labelArtista.Text = "Orange Rex County"
        formPantallaReview.labelDescripcion.Text = "Segunda pista del segundo álbum de Rex Orange County, ""Apricot Princess"". Cuenta con un ritmo fluctuante y voces crudas para permitir que el oyente se sumerja en el tempo de esta canción, lo que hace que las emociones poderosas se sientan casi palpables. Además, Alex describe el complicaciones infames de las relaciones y confesar sentimientos por aquellos de los que estás enamorado."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/5OUTFH5acycdnf8OVo21Gv?si=4e7a2450885e4ca0")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/television-so-far-so-good/1282018263?i=1282018585")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/hyceqnkh8J9Bk5m27")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = True
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum9_Click(sender As Object, e As EventArgs) Handles pictureAlbum9.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum9.Image
        formPantallaReview.labelNombreCancion.Text = "Bound To You"
        formPantallaReview.labelArtista.Text = "Christina Aguilera"
        formPantallaReview.labelDescripcion.Text = "Ella ha amado antes y tenía el corazón roto hasta la médula. Ella construyó estos muros que nunca dejó que nadie derribara, ¡hasta ahora! Su corazón ahora le pertenece a él y solo a él. Ella confía en él y cree en esta corta relación. Ella le ha dado todo; ella está atada a él."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/6FJbvdUSkr1tyXdVZ2UlBR?si=bd7adc19f6474aeb")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/bound-to-you/401685353?i=401685489")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/6fwLwab3uWpeb7hU6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = True
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum9.Image
        formPantallaReview.labelNombreCancion.Text = "Bound To You"
        formPantallaReview.labelArtista.Text = "Christina Aguilera"
        formPantallaReview.labelDescripcion.Text = "Ella ha amado antes y tenía el corazón roto hasta la médula. Ella construyó estos muros que nunca dejó que nadie derribara, ¡hasta ahora! Su corazón ahora le pertenece a él y solo a él. Ella confía en él y cree en esta corta relación. Ella le ha dado todo; ella está atada a él."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/6FJbvdUSkr1tyXdVZ2UlBR?si=bd7adc19f6474aeb")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/bound-to-you/401685353?i=401685489")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/6fwLwab3uWpeb7hU6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = True
        formPantallaReview.listAlbum10.Visible = False

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub pictureAlbum10_Click(sender As Object, e As EventArgs) Handles pictureAlbum10.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum10.Image
        formPantallaReview.labelNombreCancion.Text = "CREEPER VS ZOMBIE"
        formPantallaReview.labelArtista.Text = "ZarcortGame"
        formPantallaReview.labelDescripcion.Text = "Parte 2 del especial de 1 millón de suscriptores de ZarcortGame en su canal de Youtube."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/6pjBPIZz8jMyIF62xXcVA4?si=210ff3946d444ca0")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/creeper-vs-zombie/1493417195?i=1493417618")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/35Eeg3qWxKhDgdMV6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = True

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        formPantallaReview.pictureAlbum.Image = pictureAlbum10.Image
        formPantallaReview.labelNombreCancion.Text = "CREEPER VS ZOMBIE"
        formPantallaReview.labelArtista.Text = "ZarcortGame"
        formPantallaReview.labelDescripcion.Text = "Parte 2 del especial de 1 millón de suscriptores de ZarcortGame en su canal de Youtube."

        formPantallaReview.linkSpotify.Links.Clear()
        formPantallaReview.linkiTunes.Links.Clear()
        formPantallaReview.linkDeezer.Links.Clear()

        formPantallaReview.linkSpotify.Links.Add(0, 8, "https://open.spotify.com/track/6pjBPIZz8jMyIF62xXcVA4?si=210ff3946d444ca0")
        formPantallaReview.linkiTunes.Links.Add(0, 7, "https://music.apple.com/mx/album/creeper-vs-zombie/1493417195?i=1493417618")
        formPantallaReview.linkDeezer.Links.Add(0, 7, "https://deezer.page.link/35Eeg3qWxKhDgdMV6")

        formPantallaReview.listAlbum1.Visible = False
        formPantallaReview.listAlbum2.Visible = False
        formPantallaReview.listAlbum3.Visible = False
        formPantallaReview.listAlbum4.Visible = False
        formPantallaReview.listAlbum5.Visible = False
        formPantallaReview.listAlbum6.Visible = False
        formPantallaReview.listAlbum7.Visible = False
        formPantallaReview.listAlbum8.Visible = False
        formPantallaReview.listAlbum9.Visible = False
        formPantallaReview.listAlbum10.Visible = True

        Me.Hide()
        formPantallaReview.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub
End Class