Imports System.Data.OleDb
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        dadagbok = New OleDbDataAdapter(sqldagbok, con)
        dadagbok.Fill(dsdagbok, "dagbok")

    End Sub
    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim listItem As ListViewItem


        For i = 0 To dsdagbok.Tables("dagbok").Rows.Count - 1
            listItem = lsvAnteckning.Items.Add(dsdagbok.Tables("dagbok").Rows(i)("name"))
            listItem.SubItems.Add(dsdagbok.Tables("dagbok").Rows(i)("id"))
        Next



    End Sub
    Private Sub lsvAnteckning_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvAnteckning.SelectedIndexChanged
        'Rot nod (artist) visa alla album
        showDataGrid("SELECT id, name, beskrivning, tid, distans, rpe, datum FROM dagbok where id = " & lsvAnteckning.FocusedItem.SubItems(1).Text)
        'Förhindra att man kan lägga till låt

    End Sub
    Private Sub showDataGrid(sql As String)
        ' Rensa befintlig data
        grdDetalj.DataSource = Nothing

        ' Hämta ny data
        grdDetalj.DataSource = hamtaData(sql)

        ' Autojustera för innehållet (och inte för rubrikerna)
        grdDetalj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

        ' Dölj id-kolumnen
        grdDetalj.Columns(0).Visible = False
    End Sub

    Private Sub btnNyAktivitet_Click(sender As Object, e As EventArgs) Handles btnNyAktivitet.Click
        con.Close()
        NyAktivitet.Show()

    End Sub

    Private Sub btnNyAnteckning_Click(sender As Object, e As EventArgs) Handles btnNyAnteckning.Click
        NyAnteckning.Show()
    End Sub

    Private Sub btnÄndraAktivitet_Click(sender As Object, e As EventArgs) Handles btnÄndraAktivitet.Click
        ändraAktivitet.Show()
    End Sub

    Private Sub btnÄndraAnteckning_Click(sender As Object, e As EventArgs) Handles btnÄndraAnteckning.Click
        ändraAnteckning.Show()
    End Sub
End Class