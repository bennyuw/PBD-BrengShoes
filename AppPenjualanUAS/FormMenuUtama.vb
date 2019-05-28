Public Class FormMenuUtama

    Private Sub Konsumen_Click(sender As Object, e As EventArgs) Handles Konsumen.Click
        Me.Close()
        FormKonsumen.Show()
    End Sub

    Private Sub Barang_Click(sender As Object, e As EventArgs) Handles Barang.Click
        Me.Close()
        FormBarang.Show()
    End Sub

    Private Sub Karyawan_Click(sender As Object, e As EventArgs) Handles Karyawan.Click
        Me.Close()
        FormKaryawan.Show()
    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        Me.Close()
        FormSupplier.Show()
    End Sub

    Private Sub LogoutItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem1.Click
        Me.Close()
        FormGantiPassword.Show()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Penjualan_Click(sender As Object, e As EventArgs) Handles Penjualan.Click
        Me.Hide()
        FormPenjualan.Show()
    End Sub

    Private Sub Pembelian_Click(sender As Object, e As EventArgs) Handles Pembelian.Click
        Me.Hide()
        FormPembelian.Show()
    End Sub

    Private Sub DataPenjualanTunaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenjualanTunaiToolStripMenuItem.Click
        Me.Hide()
        LaporanMingguanPenjualan.Show()
    End Sub

    Private Sub DataPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPembelianToolStripMenuItem.Click
        Me.Hide()
        LaporanMingguanPembelian.Show()
    End Sub

    Private Sub SistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub
End Class