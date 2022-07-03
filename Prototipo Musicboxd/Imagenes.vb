Imports System.Drawing.Drawing2D

Public Class Imagenes

    Shared tuerquita As Bitmap
    Shared fotousuario As Bitmap

    Shared Function ajustar_tuerquita(imgOriginal As Bitmap) As Bitmap

        If tuerquita Is Nothing Then
            Dim y, x As Integer
            Dim red, green, blue As Byte

            Dim img = New Bitmap(imgOriginal)

            For x = 0 To img.Width - 1
                For y = 0 To img.Height - 1
                    red = img.GetPixel(x, y).R
                    green = img.GetPixel(x, y).G
                    blue = img.GetPixel(x, y).B

                    'If red > 200 And green > 200 And blue > 200 Then
                    '    img.SetPixel(x, y, Color.Transparent)
                    'End If

                    If red < 61 And blue < 61 And green < 61 Then
                        img.SetPixel(x, y, Color.LightSlateGray)
                    Else

                        img.SetPixel(x, y, Color.Transparent
                                     )
                    End If
                Next
            Next
            tuerquita = img
        End If

        Return tuerquita
    End Function

    Shared Function PFPredonda(pfp As Bitmap) As Bitmap
        If fotousuario Is Nothing Then
            Dim CroppedImage As New Bitmap(pfp.Width,
                                            pfp.Height)

            Using g = Graphics.FromImage(CroppedImage)
                Dim path As New GraphicsPath

                path.AddEllipse(0, 0,
                                CroppedImage.Width,
                                CroppedImage.Height)

                Dim reg As New Region(path)

                g.Clip = reg
                g.DrawImage(pfp, Point.Empty)
            End Using

            fotousuario = CroppedImage
        End If

        Return fotousuario
    End Function
End Class
