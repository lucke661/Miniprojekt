Imports System.ComponentModel

Public Class frmNyArtist
    Private dataAdapder As SQLite.SQLiteDataAdapter
    Private dbrow As DataRow
    Private ds As New DataSet
    Public artistid As Integer = -1
    Private Sub btnAngra_Click(sender As Object, e As EventArgs) Handles btnAngra.Click
        'Svara att vi avbryter
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click

        'Skapa dataadaptern och tilldela data via dataaskopplingen i modData
        dataAdapder = New SQLite.SQLiteDataAdapter("select * from Artists", cnChinook)

        'Commandbuilder gör att vi slipper skriva insert/update-kod
        Dim commandbuilder As New SQLite.SQLiteCommandBuilder(dataAdapder)

        'Fyll raden med data från formuläret
        dbrow.Item("Name") = txtArtist.Text

        'Uppdatera tabellen
        dataAdapder.Update(ds, "Artister")

        'Meddela att allt är ok
        DialogResult = DialogResult.OK

        'Stänga formuläret
        Me.Close()
    End Sub

    Private Sub frmNyArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblArtistid.Text = artistid

        'Rensa datasettet
        ds.Clear()

        'Hämta data från databasen om artistid <> -1
        If artistid <> -1 Then
            'Skapa dataadaptern och tilldela data via dataaskopplingen i modData
            dataAdapder = New SQLite.SQLiteDataAdapter("select * from Artists where artistid=" & artistid, cnChinook)
            'Fyll datasettet från dataadaptern
            dataAdapder.Fill(ds, "Artister")
            'Läs in till en datarow
            dbrow = ds.Tables("Artister").Rows(0)
            txtArtist.Text = dbrow.Item("name")
            btnSpara.Enabled = True
            btnRadera.Visible = True
        Else
            'Skapa dataadaptern och tilldela data via dataaskopplingen i modData
            dataAdapder = New SQLite.SQLiteDataAdapter("select * from Artists", cnChinook)
            'Fyll datasettet från dataadaptern
            dataAdapder.Fill(ds, "Artister")
            'Läs in till en datarow
            dbrow = ds.Tables("Artister").NewRow
            'Lägg till raden till datasettet
            ds.Tables("Artister").Rows.Add(dbrow)

            txtArtist.Text = ""
            btnSpara.Enabled = False
            btnRadera.Visible = False
        End If

    End Sub

    Private Sub txtArtist_TextChanged(sender As Object, e As EventArgs) Handles txtArtist.TextChanged
        'Aktivera spara knappen om texten inte är tom
        If txtArtist.Text <> "" Then
            btnSpara.Enabled = True
        Else
            btnSpara.Enabled = False
        End If
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click
        'Skapa en commandbuilder
        Dim commandbuilder As New SQLite.SQLiteCommandBuilder(dataAdapder)

        'Radera aktuell post och uppdatera dataadaptern
        ds.Tables("Artister").Rows(0).Delete()
        dataAdapder.Update(ds, "Artister")

        'Returnera OK!
        DialogResult = DialogResult.OK

    End Sub

    Private Sub frmNyArtist_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Antag att nästa gång formuläret öppnas är det för att lägga till ny
        artistid = -1
    End Sub
End Class