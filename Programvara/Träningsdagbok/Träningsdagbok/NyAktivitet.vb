Imports System.Data.OleDb

Public Class NyAktivitet
    Private Sub NyAktivitet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        daaktiviteter = New OleDbDataAdapter(sqlaktiviteter, con)


    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(daaktiviteter)
        Dim dbRow As DataRow
        daaktiviteter.Fill(dsaktiviteter, "aktiviteter")

        dbRow = dsaktiviteter.Tables("aktiviteter").NewRow
        dbRow.Item("aktivitet") = txtAktivitet.Text
        dbRow.Item("harDistans") = chbMataDistans.Checked
        dbRow.Item("harTid") = chbMataTid.Checked

        dsaktiviteter.Tables("aktiviteter").Rows.Add(dbRow)
        daaktiviteter.Update(dsaktiviteter, "aktiviteter")
        Me.Close()
    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        Me.Close()
    End Sub
End Class