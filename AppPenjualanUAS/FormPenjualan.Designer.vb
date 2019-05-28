<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.lbBarang = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbKembali = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.tbIDPelanggan = New System.Windows.Forms.TextBox()
        Me.tbTotalBesar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbNMPelanggan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTanggal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.total_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbBarang
        '
        Me.lbBarang.FormattingEnabled = True
        Me.lbBarang.ItemHeight = 17
        Me.lbBarang.Location = New System.Drawing.Point(892, 259)
        Me.lbBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.lbBarang.Name = "lbBarang"
        Me.lbBarang.Size = New System.Drawing.Size(368, 310)
        Me.lbBarang.TabIndex = 148
        '
        'tbKembali
        '
        Me.tbKembali.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbKembali.Location = New System.Drawing.Point(1070, 669)
        Me.tbKembali.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbKembali.Name = "tbKembali"
        Me.tbKembali.Size = New System.Drawing.Size(190, 23)
        Me.tbKembali.TabIndex = 145
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(892, 665)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 30)
        Me.Label11.TabIndex = 146
        Me.Label11.Text = "Kembali"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbBayar
        '
        Me.tbBayar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbBayar.Location = New System.Drawing.Point(1070, 631)
        Me.tbBayar.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(190, 23)
        Me.tbBayar.TabIndex = 143
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(892, 627)
        Me.Label10.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 30)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Bayar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTotal
        '
        Me.tbTotal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbTotal.Location = New System.Drawing.Point(1070, 595)
        Me.tbTotal.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(190, 23)
        Me.tbTotal.TabIndex = 141
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(892, 591)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 30)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btBatal
        '
        Me.btBatal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBatal.Location = New System.Drawing.Point(401, 597)
        Me.btBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(180, 76)
        Me.btBatal.TabIndex = 139
        Me.btBatal.Text = "BATAL"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Location = New System.Drawing.Point(170, 598)
        Me.btSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(180, 76)
        Me.btSimpan.TabIndex = 138
        Me.btSimpan.Text = "SIMPAN"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'tbIDPelanggan
        '
        Me.tbIDPelanggan.BackColor = System.Drawing.SystemColors.Menu
        Me.tbIDPelanggan.Location = New System.Drawing.Point(279, 76)
        Me.tbIDPelanggan.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbIDPelanggan.Name = "tbIDPelanggan"
        Me.tbIDPelanggan.Size = New System.Drawing.Size(80, 23)
        Me.tbIDPelanggan.TabIndex = 133
        '
        'tbTotalBesar
        '
        Me.tbTotalBesar.BackColor = System.Drawing.SystemColors.MenuText
        Me.tbTotalBesar.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalBesar.ForeColor = System.Drawing.SystemColors.Window
        Me.tbTotalBesar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbTotalBesar.Location = New System.Drawing.Point(839, 17)
        Me.tbTotalBesar.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTotalBesar.Name = "tbTotalBesar"
        Me.tbTotalBesar.Size = New System.Drawing.Size(407, 86)
        Me.tbTotalBesar.TabIndex = 113
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.tbIDPelanggan)
        Me.Panel1.Controls.Add(Me.tbTotalBesar)
        Me.Panel1.Controls.Add(Me.tbNMPelanggan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbTanggal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbNT)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 115)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1336, 124)
        Me.Panel1.TabIndex = 137
        '
        'tbNMPelanggan
        '
        Me.tbNMPelanggan.BackColor = System.Drawing.SystemColors.Window
        Me.tbNMPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNMPelanggan.Location = New System.Drawing.Point(368, 76)
        Me.tbNMPelanggan.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbNMPelanggan.Name = "tbNMPelanggan"
        Me.tbNMPelanggan.Size = New System.Drawing.Size(398, 23)
        Me.tbNMPelanggan.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(84, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Pelanggan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTanggal
        '
        Me.tbTanggal.BackColor = System.Drawing.SystemColors.Menu
        Me.tbTanggal.Location = New System.Drawing.Point(279, 47)
        Me.tbTanggal.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbTanggal.Name = "tbTanggal"
        Me.tbTanggal.Size = New System.Drawing.Size(211, 23)
        Me.tbTanggal.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(84, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbNT
        '
        Me.tbNT.BackColor = System.Drawing.SystemColors.Window
        Me.tbNT.Location = New System.Drawing.Point(279, 17)
        Me.tbNT.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tbNT.Name = "tbNT"
        Me.tbNT.Size = New System.Drawing.Size(211, 23)
        Me.tbNT.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(84, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "No Transaksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btKembali
        '
        Me.btKembali.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKembali.Location = New System.Drawing.Point(629, 597)
        Me.btKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(180, 76)
        Me.btKembali.TabIndex = 140
        Me.btKembali.Text = "KEMBALI"
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'total_harga
        '
        Me.total_harga.HeaderText = "Total Harga"
        Me.total_harga.Name = "total_harga"
        Me.total_harga.Width = 150
        '
        'jumlah_barang
        '
        Me.jumlah_barang.HeaderText = "Jumlah"
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Width = 130
        '
        'harga_jual
        '
        Me.harga_jual.HeaderText = "Harga Jual"
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Width = 130
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Width = 200
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Width = 130
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_barang, Me.nama_barang, Me.harga_jual, Me.jumlah_barang, Me.total_harga})
        Me.DGV.Location = New System.Drawing.Point(100, 259)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(781, 310)
        Me.DGV.TabIndex = 147
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1362, 711)
        Me.Controls.Add(Me.lbBarang)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.tbKembali)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbBayar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btKembali)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbBarang As System.Windows.Forms.ListBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tbKembali As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents tbIDPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalBesar As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbNMPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbTanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btKembali As System.Windows.Forms.Button
    Friend WithEvents total_harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
