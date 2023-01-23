Imports System.Data.SQLite

Public Class frmNyttAlbum
    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        'Skapa en dataadapter för koppling mot tabellen
        Dim dataAdapter As New SQLiteDataAdapter("Select * from albums", cnChinook)

        'Skapa en commandbuilder för enklare hantering av insert updates
        Dim commandBuilder As New SQLiteCommandBuilder(dataAdapter)
        Dim dbrow As DataRow
        Dim ds As New DataSet

        'Fyll adaptern
        dataAdapter.Fill(ds, "Album")

        'Skapa en ny rad
        dbrow = ds.Tables("Album").NewRow

        'Tilldela raden värden från formuläret
        dbrow.Item("title") = txtAlbum.Text
        dbrow.Item("artistid") = cboArtist.SelectedValue

        'Lägg till raden i datasettet
        ds.Tables("Album").Rows.Add(dbrow)

        'Uppdatera dataadaptern
        dataAdapter.Update(ds, "Album")

        'Skicka tillbaka OK
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmNyttAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Rensa textrutan
        txtAlbum.Text = ""

        'Fyll comboboxen
        cboArtist.DataSource = hamtaData("select * from Artists order by name")
        cboArtist.DisplayMember = "name"
        cboArtist.ValueMember = "artistid"

        'Disabla spara-knappen
        btnSpara.Enabled = False
    End Sub

    Private Sub txtAlbum_TextChanged(sender As Object, e As EventArgs) Handles txtAlbum.TextChanged
        'Aktivera spara knappen om texten inte är tom
        If txtAlbum.Text <> "" Then
            btnSpara.Enabled = False
        Else
            btnSpara.Enabled = True
        End If
    End Sub
End Class