Imports System.Data.SqlClient
Public Class FormBarang
    Dim Conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim CMD As SqlCommand
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "data source=DESKTOP-S4FC3MP;initial catalog=UAS_PBD;integrated security =true"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub KondisiAwal()
        Koneksi()
        da = New SqlDataAdapter("Select * from Master_Barang", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Master_Barang")
        DGV.DataSource = (ds.Tables("Master_Barang"))
        DGV.ReadOnly = True
        TKode.Text = ""
        TNama.Text = ""
        TTipe.Text = ""
        THargaBeli.Text = ""
        THargaJual.Text = ""
        TStok.Text = ""
    End Sub
    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If TKode.Text = "" Or TNama.Text = "" Or TTipe.Text = "" Or THargaBeli.Text = "" Or THargaJual.Text = "" Or TStok.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into Master_Barang values ('" & TKode.Text & "','" & TNama.Text & "','" & TTipe.Text & "','" & THargaBeli.Text & "','" & THargaJual.Text & "','" & TStok.Text & "')"
            CMD = New SqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If TKode.Text = "" Or TNama.Text = "" Or TTipe.Text = "" Or THargaBeli.Text = "" Or THargaJual.Text = "" Or TStok.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "update Master_Barang set Nama_Barang='" & TNama.Text & "',Tipe_Barang='" & TTipe.Text & "', Harga_Beli='" & THargaBeli.Text & "', Harga_Jual='" & THargaJual.Text & "', Stok='" & TStok.Text & "' where Kode_Barang='" & TKode.Text & "'"
            CMD = New SqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        If TKode.Text = "" Or TNama.Text = "" Or TTipe.Text = "" Or THargaBeli.Text = "" Or THargaJual.Text = "" Or TStok.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim hapus As String = "delete from Master_Barang where Kode_Barang='" & TKode.Text & "'"
            CMD = New SqlCommand(hapus, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DGV.CurrentRow.Index
        CMD = New SqlCommand("Select * from Master_Barang where Kode_Barang='" & DGV.Item(0, i).Value & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            TNama.Focus()
        Else
            TKode.Text = RD.Item("Kode_Barang")
            TNama.Text = RD.Item("Nama_Barang")
            TTipe.Text = RD.Item("Tipe_Barang")
            THargaBeli.Text = RD.Item("Harga_Beli")
            THargaJual.Text = RD.Item("Harga_Jual")
            TStok.Text = RD.Item("Stok")
            TNama.Focus()
        End If
    End Sub

    Private Sub cmdKembali_Click(sender As Object, e As EventArgs) Handles cmdKembali.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select * from Master_Barang where Nama_Barang like '%" & tbCari.Text & "%'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("select * from Master_Barang where Nama_Barang like '%" & tbCari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds, "Master_Barang")
            DGV.DataSource = ds.Tables("Master_Barang")
            DGV.ReadOnly = True
        End If
    End Sub

End Class