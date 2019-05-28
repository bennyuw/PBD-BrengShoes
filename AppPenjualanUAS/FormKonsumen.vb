Imports System.Data.SqlClient
Public Class FormKonsumen
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
        da = New SqlDataAdapter("Select * from Master_Customer", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Master_Customer")
        DGV.DataSource = (ds.Tables("Master_Customer"))
        DGV.ReadOnly = True
        TID.Text = ""
        TNama.Text = ""
        TAlamat.Text = ""
        TTelepon.Text = ""
    End Sub
    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If TID.Text = "" Or TNama.Text = "" Or TAlamat.Text = "" Or TTelepon.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into Master_Customer values ('" & TID.Text & "','" & TNama.Text & "','" & TAlamat.Text & "','" & TTelepon.Text & "')"
            CMD = New SqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If TID.Text = "" Or TNama.Text = "" Or TAlamat.Text = "" Or TTelepon.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "update Master_Customer set Nama_Customer='" & TNama.Text & "',Alamat_Customer='" & TAlamat.Text & "',Telp_Customer='" & TTelepon.Text & "' where ID_Customer='" & TID.Text & "'"
            CMD = New SqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        If TID.Text = "" Or TNama.Text = "" Or TAlamat.Text = "" Or TTelepon.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim hapus As String = "delete from Master_Customer where ID_Customer='" & TID.Text & "'"
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
        CMD = New SqlCommand("Select * from Master_Customer where ID_Customer='" & DGV.Item(0, i).Value & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            TNama.Focus()
        Else
            TID.Text = RD.Item("ID_Customer")
            TNama.Text = RD.Item("Nama_Customer")
            TAlamat.Text = RD.Item("Alamat_Customer")
            TTelepon.Text = RD.Item("Telp_Customer")
            TNama.Focus()
        End If
    End Sub

    Private Sub cmdKembali_Click(sender As Object, e As EventArgs) Handles cmdKembali.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select * from Master_Customer where Nama_Customer like '%" & tbCari.Text & "%'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("select * from Master_Customer where Nama_Customer like '%" & tbCari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds, "Master_Customer")
            DGV.DataSource = ds.Tables("Master_Customer")
            DGV.ReadOnly = True
        End If
    End Sub

End Class