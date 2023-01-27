Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()

    End Sub
    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim listItem As ListViewItem


        For i = 0 To dsdagbok.Tables("dagbok").Rows.Count - 1
            listItem = lsvAnteckning.Items.Add(dsdagbok.Tables("dagbok").Rows(i)("datum"))

        Next
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
        If NyAktivitet.ShowDialog() = DialogResult.OK Then
            'Ladda om trädvyn

        End If

    End Sub

    'Private Sub btnNyttAlbum_Click(sender As Object, e As EventArgs) Handles btnNyttAlbum.Click
    'If frmNyttAlbum.ShowDialog() = DialogResult.OK Then
    'Ladda om trädvyn
    '       reloadTree()
    'End If
    'End Sub

    'Private Sub btnNyLat_Click(sender As Object, e As EventArgs) Handles btnNyLat.Click
    'Den valda nodens tag har formatet "Albumid=XXX" dvs albumid-talet börjar i position 8
    'Dim albumID As Integer = tvwArtister.SelectedNode.Tag.ToString.Substring(8)
    '   frmNyLat.albumId = albumID
    'If frmNyLat.ShowDialog() = DialogResult.OK Then
    '       showDataGrid("select * from tracks where " & tvwArtister.SelectedNode.Tag)
    'End If
    'End Sub

    Private Sub btnRedigeraDagbok_Click(sender As Object, e As EventArgs) Handles btnRedigeraDagbok.Click
        'Noden innehåller uppgift om artistens id enligt
        'Artistid=XXX, dvs artistid börjar i position 9
        'Dim anteckningsId As Integer = tvwAnteckningar.SelectedNode.Tag.ToString.Substring(9)
        'NyAnteckning.anteckningsid = anteckningsId
        If NyAnteckning.ShowDialog() = DialogResult.OK Then
            'Ladda om trädvyn

        End If

    End Sub
End Class
