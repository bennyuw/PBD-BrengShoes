<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.Keluar = New System.Windows.Forms.Button()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Barang = New System.Windows.Forms.ToolStripMenuItem()
        Me.Konsumen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Karyawan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Supplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanTunaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Keluar
        '
        Me.Keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Keluar.Image = CType(resources.GetObject("Keluar.Image"), System.Drawing.Image)
        Me.Keluar.Location = New System.Drawing.Point(76, 565)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(128, 54)
        Me.Keluar.TabIndex = 11
        Me.Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Barang, Me.Konsumen, Me.Karyawan, Me.Supplier, Me.ToolStripMenuItem1})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'Barang
        '
        Me.Barang.Name = "Barang"
        Me.Barang.Size = New System.Drawing.Size(180, 22)
        Me.Barang.Text = "Data Barang"
        '
        'Konsumen
        '
        Me.Konsumen.Name = "Konsumen"
        Me.Konsumen.Size = New System.Drawing.Size(180, 22)
        Me.Konsumen.Text = "Data Konsumen"
        '
        'Karyawan
        '
        Me.Karyawan.Name = "Karyawan"
        Me.Karyawan.Size = New System.Drawing.Size(180, 22)
        Me.Karyawan.Text = "Data Karyawan"
        '
        'Supplier
        '
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Size = New System.Drawing.Size(180, 22)
        Me.Supplier.Text = "Data Supplier"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Penjualan, Me.Pembelian})
        Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'Penjualan
        '
        Me.Penjualan.Name = "Penjualan"
        Me.Penjualan.Size = New System.Drawing.Size(195, 22)
        Me.Penjualan.Text = "Penjualan Barang"
        '
        'Pembelian
        '
        Me.Pembelian.Name = "Pembelian"
        Me.Pembelian.Size = New System.Drawing.Size(195, 22)
        Me.Pembelian.Text = "Pembelian Barang"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPenjualanTunaiToolStripMenuItem, Me.DataPembelianToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataPenjualanTunaiToolStripMenuItem
        '
        Me.DataPenjualanTunaiToolStripMenuItem.Name = "DataPenjualanTunaiToolStripMenuItem"
        Me.DataPenjualanTunaiToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.DataPenjualanTunaiToolStripMenuItem.Text = "Data Penjualan Barang"
        '
        'DataPembelianToolStripMenuItem
        '
        Me.DataPembelianToolStripMenuItem.Name = "DataPembelianToolStripMenuItem"
        Me.DataPembelianToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.DataPembelianToolStripMenuItem.Text = "Data Pembelian Barang"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem1})
        Me.BantuanToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'GantiPasswordToolStripMenuItem1
        '
        Me.GantiPasswordToolStripMenuItem1.Name = "GantiPasswordToolStripMenuItem1"
        Me.GantiPasswordToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.GantiPasswordToolStripMenuItem1.Text = "Ganti Password"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(810, 25)
        Me.MenuStrip2.TabIndex = 13
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.AppPenjualanUAS.My.Resources.Resources.menu_utama_revisi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(810, 650)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Keluar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama Aplikasi Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Konsumen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Barang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Karyawan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Supplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Penjualan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pembelian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenjualanTunaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip

End Class
