Public Class ändraAktivitet
    Private Sub ändraAktivitet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboAktivitet_Leave(sender As Object, e As EventArgs) Handles cboAktivitet.Leave
        chbMataDistans.Checked = hamtaData("SELECT harDistans FROM aktiviteter where aktivitet = " & cboAktivitet.Text).ToString
    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        Me.Close()
    End Sub
End Class