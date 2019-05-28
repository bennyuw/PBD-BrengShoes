Imports System.Data.SqlClient
Public Class FormLaporanPenjualan

    Private Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

    Private Sub FormLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPenjualan.Penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.DataSetPenjualan.Penjualan)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class