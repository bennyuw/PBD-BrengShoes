Public Class FormLaporanPembelian

    Private Sub FormLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPembelian.Pembelian' table. You can move, or remove it, as needed.
        Me.PembelianTableAdapter.Fill(Me.DataSetPembelian.Pembelian)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

End Class