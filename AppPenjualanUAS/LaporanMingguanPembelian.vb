Public Class LaporanMingguanPembelian

    Private Sub LaporanMingguanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cbBulan.Items.Add("Januari")

        Me.cbBulan.Items.Add("Februari")

        Me.cbBulan.Items.Add("Maret")

        Me.cbBulan.Items.Add("April")

        Me.cbBulan.Items.Add("Mei")

        Me.cbBulan.Items.Add("Juni")

        Me.cbBulan.Items.Add("Juli")

        Me.cbBulan.Items.Add("Agustus")

        Me.cbBulan.Items.Add("September")

        Me.cbBulan.Items.Add("Oktober")

        Me.cbBulan.Items.Add("November")

        Me.cbBulan.Items.Add("Desember")

        Me.cbTahun.Items.Add("2017")

        Me.cbTahun.Items.Add("2018")

        Me.cbTahun.Items.Add("2019")

        Me.cbTahun.Items.Add("2020")

    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim int_bulan As Integer

        Try

            Select Case cbBulan.Text

                Case "Januari"

                    int_bulan = 1

                Case "Februari"

                    int_bulan = 2

                Case "Maret"

                    int_bulan = 3

                Case "April"

                    int_bulan = 4

                Case "Mei"

                    int_bulan = 5

                Case "Juni"

                    int_bulan = 6

                Case "Juli"

                    int_bulan = 7

                Case "Agustus"

                    int_bulan = 8

                Case "September"

                    int_bulan = 9

                Case "Oktober"

                    int_bulan = 10

                Case "November"

                    int_bulan = 11

                Case "Desember"

                    int_bulan = 12

            End Select

            If cbBulan.Text = "" Or cbTahun.Text = "" Then

                MessageBox.Show("Isikan dengan Lengkap")

            Else

                BulananPembelian.CrystalReportViewer1.SelectionFormula = "Month({Pembelian.Tanggal}) =" & Val(int_bulan) & " and Year({Pembelian.Tanggal}) =" & Val(cbTahun.Text)

                BulananPembelian.CrystalReportViewer1.RefreshReport()

                BulananPembelian.WindowState = FormWindowState.Maximized

                BulananPembelian.Show()

            End If

        Catch ex As Exception

            MessageBox.Show("Report Error", "Form Filter Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub
End Class