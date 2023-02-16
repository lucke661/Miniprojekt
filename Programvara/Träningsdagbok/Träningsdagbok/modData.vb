Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates

Module modData
    Public con As New OleDb.OleDbConnection
    Public dsdagbok As New DataSet
    Public dadagbok As OleDbDataAdapter
    Public dsaktiviteter As New DataSet
    Public daaktiviteter As OleDbDataAdapter
    Public sqldagbok As String
    Public sqlaktiviteter As String


    Public Sub dbConnect()
        ' Kombinera sökvägar, databasens namn mm till en dbSource
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Träningsdagbok.accdb"
        Dim dbPath As String = "C:\Users\LucasNordqvist\source\repos\Miniprojekt\Programvara"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName


        ' Sätt i hop kopplingssträngen mha variablerna ovan
        con.ConnectionString = dbProvider & dbSource

        ' Öppna databasen
        con.Open()

        ' Välj data att visa
        sqldagbok = "SELECT id, name, datum, tid, distans, beskrivning, rpe FROM dagbok"
        sqlaktiviteter = "SELECT aktivitet, harTid, harDistans FROM aktiviteter"

    End Sub
    Public Function hamtaData(sql As String) As DataTable
        ' Skapa en Datatable för returen
        Dim dt As New DataTable

        ' Skapa ett kommandoobjekt för att läsa databasen
        Dim cmd As New OleDbCommand(sql, con)

        ' Skapa en dataadapter för att exekvera kommandot
        Dim da As New OleDbDataAdapter(cmd)

        ' Fyll returobjektet
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt

    End Function
End Module
