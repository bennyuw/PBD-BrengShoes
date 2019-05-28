Imports System.Data.SqlClient
Public Class FormLogin
    Dim hak As String

    Sub KondisiAwal()
        Koneksi()
        user.Text = ""
        pass.Text = ""
        cbakses.SelectedItem = ""
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles user.KeyPress
        If e.KeyChar = Chr(13) Then pass.Focus()
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pass.KeyPress
        If e.KeyChar = Chr(13) Then login.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        If user.Text = "" Or pass.Text = "" Then
            MessageBox.Show("data login belum lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New SqlCommand("select * from Akses where Username='" & user.Text & "' and Password='" & pass.Text & "' and Hak_Akses='" & cbakses.SelectedItem & "' ", Conn)
            RD = CMD.ExecuteReader()
            RD.Read()
            Call KondisiAwal()
            If RD.HasRows Then
                If cbakses.SelectedItem = "Admin" Then
                    FormMenuUtama.Show()
                    Me.Hide()
                Else
                    FormMenuUtama.MasterToolStripMenuItem.Enabled = False
                    FormMenuUtama.BantuanToolStripMenuItem.Enabled = False
                    FormMenuUtama.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Kode Admin atau Password salah")
            End If
        End If
    End Sub

    Private Sub tbexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbexit.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        user.Focus()
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.MaxLength = 6
        pass.PasswordChar = "*"
    End Sub

End Class