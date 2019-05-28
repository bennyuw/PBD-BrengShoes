Imports System.Data.SqlClient

Public Class FormPenjualan

    Dim Conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim CMD As SqlCommand
    Dim reader As SqlDataReader
    Dim LokasiDB As String

    Sub Koneksi()
        LokasiDB = "data source=DESKTOP-S4FC3MP;initial catalog=UAS_PBD;integrated security =true"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub KondisiAwal()
        tbNT.Text = ""
        tbIDPelanggan.Text = ""
        tbNMPelanggan.Text = ""
    End Sub

    Sub hitungharga()
        Dim hitung As Integer
        For baris As Integer = 0 To DGV.RowCount - 1
            hitung = hitung + DGV.Rows(baris).Cells(4).Value
        Next
        tbTotal.Text = hitung
        tbTotalBesar.Text = hitung
    End Sub

    Sub kembali()
        Dim sisa As Integer
        sisa = tbBayar.Text - tbTotal.Text
        tbKembali.Text = sisa
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTanggal.Text = Today
        Call Koneksi()
        CMD = New SqlCommand("select Kode_Barang, Nama_Barang from Master_Barang", Conn)
        reader = CMD.ExecuteReader
        Do While reader.Read
            lbBarang.Items.Add(reader.Item(0) & Space(2) & reader.Item(1))
        Loop
    End Sub

    Private Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

    Private Sub tbNMPelanggan_TextChanged(sender As Object, e As EventArgs) Handles tbNMPelanggan.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select id_customer from master_customer where nama_customer='" & tbNMPelanggan.Text() & "'", Conn)
        reader = CMD.ExecuteReader
        If reader.Read Then
            tbIDPelanggan.Text() = reader(0)
        End If
    End Sub


    Private Sub btBatal_Click(sender As Object, e As EventArgs) Handles btBatal.Click
        tbNT.Text = ""
        tbNMPelanggan.Text = ""
        tbIDPelanggan.Text = ""
        tbTotalBesar.Text = ""
        tbTotal.Text = ""
    End Sub

    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim connectionString As String = "Data Source=DESKTOP-S4FC3MP;Initial Catalog=UAS_PBD;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)

            Dim cmdText As String = "INSERT INTO Penjualan (No_Transaksi, Tanggal, Nama_Customer, Kode_Barang, Nama_Barang, Harga_Jual, Jumlah_Barang, Total_Harga) VALUES (@No_Transaksi, @Tanggal, @Nama_Customer, @Kode_barang, @Nama_Barang, @Harga_Jual, @Jumlah_Barang, @Total_Harga)"
            Dim command As New SqlCommand(cmdText, connection)
            command.Parameters.Add(New SqlParameter("@No_Transaksi", SqlDbType.Char))
            command.Parameters.Add(New SqlParameter("@Tanggal", SqlDbType.Date))
            command.Parameters.Add(New SqlParameter("@Nama_Customer", SqlDbType.VarChar))
            command.Parameters.Add(New SqlParameter("@Kode_Barang", SqlDbType.VarChar))
            command.Parameters.Add(New SqlParameter("@Nama_Barang", SqlDbType.VarChar))
            command.Parameters.Add(New SqlParameter("@Harga_Jual", SqlDbType.Int))
            command.Parameters.Add(New SqlParameter("@Jumlah_Barang", SqlDbType.Int))
            command.Parameters.Add(New SqlParameter("@Total_harga", SqlDbType.Int))
            connection.Open()

            Dim transaction As SqlTransaction = connection.BeginTransaction()
            command.Transaction = transaction

            Try

                For i As Integer = 0 To DGV.Rows.Count - 2
                    command.Parameters("@No_Transaksi").Value = tbNT.Text
                    command.Parameters("@Tanggal").Value = tbTanggal.Text
                    command.Parameters("@Nama_Customer").Value = tbNMPelanggan.Text
                    command.Parameters("@Kode_Barang").Value = DGV.Rows(i).Cells(0).FormattedValue
                    command.Parameters("@Nama_Barang").Value = DGV.Rows(i).Cells(1).FormattedValue
                    command.Parameters("@Harga_Jual").Value = DGV.Rows(i).Cells(2).FormattedValue
                    command.Parameters("@Jumlah_Barang").Value = DGV.Rows(i).Cells(3).FormattedValue
                    command.Parameters("@Total_harga").Value = DGV.Rows(i).Cells(4).FormattedValue
                    command.ExecuteNonQuery()
                Next i

                transaction.Commit()
                MessageBox.Show("Data Berhasil Disimpan")
            Catch ex As Exception

                Try
                    transaction.Rollback()

                Catch rollBackEx As Exception
                    MessageBox.Show(rollBackEx.Message)
                End Try

            End Try

        End Using

    End Sub

    Private Sub lbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBarang.SelectedIndexChanged
        Dim baris As Integer = DGV.RowCount - 1
        DGV.Rows.Add(Microsoft.VisualBasic.Left(lbBarang.Text, 6))

        For barisatas As Integer = 0 To DGV.RowCount - 1
            For barisbawah As Integer = barisatas + 1 To DGV.RowCount - 1
                If DGV.Rows(barisbawah).Cells(0).Value = DGV.Rows(barisatas).Cells(0).Value Then
                    DGV.Rows(barisatas).Cells(3).Value = DGV.Rows(barisatas).Cells(3).Value + 1
                    DGV.Rows(barisatas).Cells(4).Value = DGV.Rows(barisatas).Cells(2).Value * DGV.Rows(barisatas).Cells(3).Value
                    DGV.Rows.RemoveAt(barisbawah)
                    Exit Sub
                End If
            Next
        Next

        Call Koneksi()
        CMD = New SqlCommand("select kode_barang, Nama_Barang, Harga_Jual from Master_Barang where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", Conn)
        reader = CMD.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            DGV.Rows(baris).Cells(1).Value = reader.Item("Nama_Barang")
            DGV.Rows(baris).Cells(2).Value = reader.Item("Harga_Jual")
            DGV.Rows(baris).Cells(3).Value = 1
            DGV.Rows(baris).Cells(4).Value = DGV.Rows(baris).Cells(2).Value * DGV.Rows(baris).Cells(3).Value
        End If

    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        For barisatas As Integer = 0 To DGV.RowCount - 1
            For barisbawah As Integer = barisatas + 1 To DGV.RowCount - 1
                DGV.Rows(barisatas).Cells(4).Value = DGV.Rows(barisatas).Cells(2).Value * DGV.Rows(barisatas).Cells(3).Value
            Next
        Next
        Call hitungharga()
    End Sub

    Private Sub tbBayar_TextChanged(sender As Object, e As EventArgs) Handles tbBayar.TextChanged
        kembali()
    End Sub

    Private Sub DGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellValueChanged, DGV.CellValueChanged

    End Sub
End Class