<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPembelian
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetPembelian = New AppPenjualanUAS.DataSetPembelian()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianTableAdapter = New AppPenjualanUAS.DataSetPembelianTableAdapters.PembelianTableAdapter()
        CType(Me.DataSetPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btKembali
        '
        Me.btKembali.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKembali.Location = New System.Drawing.Point(384, 512)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(225, 71)
        Me.btKembali.TabIndex = 143
        Me.btKembali.Text = "KEMBALI"
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource4.Name = "DataSetPembelian"
        ReportDataSource4.Value = Me.PembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppPenjualanUAS.ReportPembelian.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(965, 488)
        Me.ReportViewer1.TabIndex = 144
        '
        'DataSetPembelian
        '
        Me.DataSetPembelian.DataSetName = "DataSetPembelian"
        Me.DataSetPembelian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PembelianBindingSource
        '
        Me.PembelianBindingSource.DataMember = "Pembelian"
        Me.PembelianBindingSource.DataSource = Me.DataSetPembelian
        '
        'PembelianTableAdapter
        '
        Me.PembelianTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 595)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btKembali)
        Me.Name = "FormLaporanPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanPembelian"
        CType(Me.DataSetPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btKembali As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPembelian As AppPenjualanUAS.DataSetPembelian
    Friend WithEvents PembelianTableAdapter As AppPenjualanUAS.DataSetPembelianTableAdapters.PembelianTableAdapter
End Class
