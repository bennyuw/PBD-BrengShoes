Imports System.Data.SqlClient
Module KoneksiSQL
    Public Conn As SqlConnection
    Public CMD As SqlCommand
    Public DS As DataSet
    Public DA As SqlDataAdapter
    Public RD As SqlDataReader
    Dim LokasiData As String

    Public Sub Koneksi()
        LokasiData = "data source = DESKTOP-S4FC3MP; initial catalog = UAS_PBD; integrated security = true"
        Conn = New SqlConnection(LokasiData)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
