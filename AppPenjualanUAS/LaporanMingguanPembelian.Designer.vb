<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMingguanPembelian
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
        Me.btKembali = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRMingguanPembelian1 = New AppPenjualanUAS.CRMingguanPembelian()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cbTahun = New System.Windows.Forms.ComboBox()
        Me.cbBulan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btKembali
        '
        Me.btKembali.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKembali.Location = New System.Drawing.Point(682, 620)
        Me.btKembali.Margin = New System.Windows.Forms.Padding(5)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(186, 54)
        Me.btKembali.TabIndex = 144
        Me.btKembali.Text = "KEMBALI"
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CRMingguanPembelian1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1320, 583)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(139, 631)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(122, 48)
        Me.btnOK.TabIndex = 149
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cbTahun
        '
        Me.cbTahun.FormattingEnabled = True
        Me.cbTahun.Location = New System.Drawing.Point(12, 658)
        Me.cbTahun.Name = "cbTahun"
        Me.cbTahun.Size = New System.Drawing.Size(121, 21)
        Me.cbTahun.TabIndex = 148
        '
        'cbBulan
        '
        Me.cbBulan.FormattingEnabled = True
        Me.cbBulan.Location = New System.Drawing.Point(12, 631)
        Me.cbBulan.Name = "cbBulan"
        Me.cbBulan.Size = New System.Drawing.Size(121, 21)
        Me.cbBulan.TabIndex = 147
        '
        'LaporanMingguanPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 701)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cbTahun)
        Me.Controls.Add(Me.cbBulan)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "LaporanMingguanPembelian"
        Me.Text = "LaporanMingguanPembelian"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRMingguanPembelian1 As AppPenjualanUAS.CRMingguanPembelian
    Friend WithEvents btKembali As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents cbBulan As System.Windows.Forms.ComboBox
End Class
