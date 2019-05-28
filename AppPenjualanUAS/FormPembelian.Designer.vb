<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelian))
        Me.lbBarang = New System.Windows.Forms.ListBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_beli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTanggal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbID_Supplier = New System.Windows.Forms.TextBox()
        Me.tbNM_Supplier = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbBarang
        '
        Me.lbBarang.FormattingEnabled = True
        Me.lbBarang.ItemHeight = 17
        Me.lbBarang.Location = New System.Drawing.Point(849, 260)
        Me.lbBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.lbBarang.Name = "lbBarang"
        Me.lbBarang.Size = New System.Drawing.Size(399, 310)
        Me.lbBarang.TabIndex = 143
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_barang, Me.nama_barang, Me.harga_beli, Me.jumlah_barang, Me.total_harga})
        Me.DGV.Location = New System.Drawing.Point(119, 260)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(704, 310)
        Me.DGV.TabIndex = 142
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Width = 200
        '
        'harga_beli
        '
        Me.harga_beli.HeaderText = "Harga"
        Me.harga_beli.Name = "harga_beli"
        Me.harga_beli.Width = 130
        '
        'jumlah_barang
        '
        Me.jumlah_barang.HeaderText = "Jumlah"
        Me.jumlah_barang.Name = "jumlah_barang"
        '
        'total_harga
        '
        Me.total_harga.HeaderText = "Total"
        Me.total_harga.Name = "total_harga"
        Me.total_harga.Width = 130
        '
        'btKembali
        '
        Me.btKembali.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKembali.Location = New System.Drawing.Point(864, 587)
        Me.btKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(180, 75)
        Me.btKembali.TabIndex = 141
        Me.btKembali.Text = "KEMBALI"
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBatal.Location = New System.Drawing.Point(596, 587)
        Me.btBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(180, 75)
        Me.btBatal.TabIndex = 140
        Me.btBatal.Text = "BATAL"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btSimpan.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Location = New System.Drawing.Point(323, 587)
        Me.btSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(180, 75)
        Me.btSimpan.TabIndex = 139
        Me.btSimpan.Text = "SIMPAN"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(103, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 23)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "No Transaksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbNT
        '
        Me.tbNT.BackColor = System.Drawing.SystemColors.Window
        Me.tbNT.Location = New System.Drawing.Point(286, 14)
        Me.tbNT.Margin = New System.Windows.Forms.Padding(9)
        Me.tbNT.Name = "tbNT"
        Me.tbNT.Size = New System.Drawing.Size(280, 23)
        Me.tbNT.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(103, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTanggal
        '
        Me.tbTanggal.BackColor = System.Drawing.SystemColors.Menu
        Me.tbTanggal.Location = New System.Drawing.Point(286, 44)
        Me.tbTanggal.Margin = New System.Windows.Forms.Padding(9)
        Me.tbTanggal.Name = "tbTanggal"
        Me.tbTanggal.Size = New System.Drawing.Size(280, 23)
        Me.tbTanggal.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(103, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 23)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Supplier"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbID_Supplier
        '
        Me.tbID_Supplier.BackColor = System.Drawing.SystemColors.Menu
        Me.tbID_Supplier.Location = New System.Drawing.Point(286, 74)
        Me.tbID_Supplier.Margin = New System.Windows.Forms.Padding(9)
        Me.tbID_Supplier.Name = "tbID_Supplier"
        Me.tbID_Supplier.Size = New System.Drawing.Size(107, 23)
        Me.tbID_Supplier.TabIndex = 108
        '
        'tbNM_Supplier
        '
        Me.tbNM_Supplier.BackColor = System.Drawing.SystemColors.Window
        Me.tbNM_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNM_Supplier.Location = New System.Drawing.Point(401, 74)
        Me.tbNM_Supplier.Margin = New System.Windows.Forms.Padding(9)
        Me.tbNM_Supplier.Name = "tbNM_Supplier"
        Me.tbNM_Supplier.Size = New System.Drawing.Size(370, 23)
        Me.tbNM_Supplier.TabIndex = 110
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.tbNM_Supplier)
        Me.Panel1.Controls.Add(Me.tbID_Supplier)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbTanggal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbNT)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 116)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1769, 118)
        Me.Panel1.TabIndex = 138
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1354, 672)
        Me.Controls.Add(Me.lbBarang)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbBarang As System.Windows.Forms.ListBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents btKembali As System.Windows.Forms.Button
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbID_Supplier As System.Windows.Forms.TextBox
    Friend WithEvents tbNM_Supplier As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents kode_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_beli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_harga As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
