Public Class NyAnteckning
    Private Sub NyAnteckning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAktivitet.DataSource = hamtaData("select * from aktiviteter order by aktivitet")
        cboAktivitet.DisplayMember = "aktivitet"
        cboAktivitet.ValueMember = "id"
    End Sub
    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        Dim dbRow As DataRow

        dbRow = dsdagbok.Tables("dagbok").NewRow
        dbRow.Item("name") = cboAktivitet.Text
        dbRow.Item("id") = cboAktivitet.SelectedValue
        dbRow.Item("beskrivning") = txtInfo.Text
        dbRow.Item("tid") = txtTid.Text
        dbRow.Item("distans") = Val(txtDistans.Text)
        dbRow.Item("rpe") = txtGrad.Text

        dsdagbok.Tables("dagbok").Rows.Add(dbRow)
        dadagbok.Update(dsdagbok, "dagbok")
        Me.Close()
    End Sub
    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        Me.Close()
    End Sub


End Class