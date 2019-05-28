<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.TTipe = New System.Windows.Forms.TextBox()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TKode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.THargaBeli = New System.Windows.Forms.TextBox()
        Me.TStok = New System.Windows.Forms.TextBox()
        Me.cmdKembali = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.THargaJual = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(532, 65)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Data Barang"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV
        '
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(19, 298)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(496, 180)
        Me.DGV.TabIndex = 67
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(274, 260)
        Me.cmdHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(104, 30)
        Me.cmdHapus.TabIndex = 65
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(139, 260)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(101, 30)
        Me.cmdEdit.TabIndex = 64
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(16, 260)
        Me.cmdSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(96, 30)
        Me.cmdSimpan.TabIndex = 63
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'TTipe
        '
        Me.TTipe.Location = New System.Drawing.Point(120, 135)
        Me.TTipe.Margin = New System.Windows.Forms.Padding(4)
        Me.TTipe.Name = "TTipe"
        Me.TTipe.Size = New System.Drawing.Size(177, 23)
        Me.TTipe.TabIndex = 61
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(120, 104)
        Me.TNama.Margin = New System.Windows.Forms.Padding(4)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(342, 23)
        Me.TNama.TabIndex = 60
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(120, 73)
        Me.TKode.Margin = New System.Windows.Forms.Padding(4)
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(132, 23)
        Me.TKode.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(19, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "TIPE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(19, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "NAMA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(19, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "KODE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(19, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "HARGA BELI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(19, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "STOK"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'THargaBeli
        '
        Me.THargaBeli.Location = New System.Drawing.Point(120, 166)
        Me.THargaBeli.Margin = New System.Windows.Forms.Padding(4)
        Me.THargaBeli.Name = "THargaBeli"
        Me.THargaBeli.Size = New System.Drawing.Size(132, 23)
        Me.THargaBeli.TabIndex = 61
        '
        'TStok
        '
        Me.TStok.Location = New System.Drawing.Point(120, 228)
        Me.TStok.Margin = New System.Windows.Forms.Padding(4)
        Me.TStok.Name = "TStok"
        Me.TStok.Size = New System.Drawing.Size(132, 23)
        Me.TStok.TabIndex = 61
        '
        'cmdKembali
        '
        Me.cmdKembali.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKembali.Location = New System.Drawing.Point(411, 260)
        Me.cmdKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdKembali.Name = "cmdKembali"
        Me.cmdKembali.Size = New System.Drawing.Size(103, 30)
        Me.cmdKembali.TabIndex = 66
        Me.cmdKembali.Text = "Kembali"
        Me.cmdKembali.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(19, 489)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 27)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "PENCARIAN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCari
        '
        Me.tbCari.Location = New System.Drawing.Point(147, 489)
        Me.tbCari.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(367, 23)
        Me.tbCari.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(19, 197)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 23)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "HARGA JUAL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'THargaJual
        '
        Me.THargaJual.Location = New System.Drawing.Point(120, 197)
        Me.THargaJual.Margin = New System.Windows.Forms.Padding(4)
        Me.THargaJual.Name = "THargaJual"
        Me.THargaJual.Size = New System.Drawing.Size(132, 23)
        Me.THargaJual.TabIndex = 61
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 527)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.cmdKembali)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.TStok)
        Me.Controls.Add(Me.THargaJual)
        Me.Controls.Add(Me.THargaBeli)
        Me.Controls.Add(Me.TTipe)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.TKode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBarang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents TTipe As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TKode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents THargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents TStok As System.Windows.Forms.TextBox
    Friend WithEvents cmdKembali As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents THargaJual As System.Windows.Forms.TextBox
End Class
