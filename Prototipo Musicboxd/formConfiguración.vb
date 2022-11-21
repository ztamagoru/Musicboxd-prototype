Imports System.Linq

Public Class formConfiguración
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