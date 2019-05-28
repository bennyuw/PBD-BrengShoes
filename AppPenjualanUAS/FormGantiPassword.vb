Imports System.Data.SqlClient
Public Class FormGantiPassword
    Dim Conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim CMD As SqlCommand
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "data source=DESKTOP-2DMFIQ6;initial catalog=UAS_PBD_TEST_1;integrated security =true"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub KondisiAwal()
        Koneksi()
        USER.Text = ""
        PASSBAR.Text = ""
        PASSLAM.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If USER.Text = "" Or PASSLAM.Text = "" Or PASSBAR.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua Data Terisi")
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan mengganti password?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim ubah As String = "update admin set PasswordAdmin='" & PASSBAR.Text & "' where KodeAdmin='" & USER.Text & "'"
                CMD = New SqlCommand(ubah, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Password Berhasil Dirubah", MsgBoxStyle.Information, "Information")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub FormGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PASSBAR.MaxLength = 6
        PASSLAM.PasswordChar = "*"
        PASSBAR.PasswordChar = "*"
    End Sub
End Class