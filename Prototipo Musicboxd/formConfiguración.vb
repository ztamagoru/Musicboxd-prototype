Imports System.Linq

Public Class formConfiguración
    Private Sub radioIngles_CheckedChanged(sender As Object, e As EventArgs) Handles radioIngles.CheckedChanged
        radioEspañol.Checked = True

        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub radioJapones_CheckedChanged(sender As Object, e As EventArgs) Handles radioJapones.CheckedChanged
        radioEspañol.Checked = True

        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub radioFrances_CheckedChanged(sender As Object, e As EventArgs) Handles radioFrances.CheckedChanged
        radioEspañol.Checked = True

        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub radioRuso_CheckedChanged(sender As Object, e As EventArgs) Handles radioRuso.CheckedChanged
        radioEspañol.Checked = True

        MessageBox.Show("Función en mantenimiento." + Environment.NewLine +
                       "Estamos trabajando para darte una mejor experiencia.",
                       "Aviso",
                       MessageBoxButtons.OK)
    End Sub

    Private Sub buttonGuardar_Click(sender As Object, e As EventArgs) Handles buttonGuardar.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        MessageBox.Show("Cerrando sesión.",
                        "Aviso",
                        MessageBoxButtons.OK)

        Threading.Thread.Sleep(3000)

        Me.Hide()

        If frmCollection.OfType(Of formPantallaInicio).Any Then
            formPantallaInicio.Hide()
        ElseIf frmCollection.OfType(Of formPantallaReview).Any Then
            formPantallaReview.Hide()
        End If

        formIniciarSesion.Show()
    End Sub

    Private Sub formConfiguración_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmCollection = System.Windows.Forms.Application.OpenForms

        If frmCollection.OfType(Of formPantallaInicio).Any Or frmCollection.OfType(Of formPantallaReview).Any Then
            Button2.Enabled() = True
        Else
            Button2.Enabled() = False
        End If
    End Sub
End Class