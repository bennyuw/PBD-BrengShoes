<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPenjualan
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPenjualan = New AppPenjualanUAS.DataSetPenjualan()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PenjualanTableAdapter = New AppPenjualanUAS.DataSetPenjualanTableAdapters.PenjualanTableAdapter()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "Penjualan"
        Me.PenjualanBindingSource.DataSource = Me.DataSetPenjualan
        '
        'DataSetPenjualan
        '
        Me.DataSetPenjualan.DataSetName = "DataSetPenjualan"
        Me.DataSetPenjualan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btKembali
        '
        Me.btKembali.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKembali.Location = New System.Drawing.Point(385, 554)
        Me.btKembali.Margin = New System.Windows.Forms.Padding(5)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(225, 71)
        Me.btKembali.TabIndex = 142
        Me.btKembali.Text = "KEMBALI"
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetCoba"
        ReportDataSource1.Value = Me.PenjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppPenjualanUAS.ReportCoba.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(976, 532)
        Me.ReportViewer1.TabIndex = 143
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 635)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btKembali)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormLaporanPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanPenjualan"
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btKembali As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPenjualan As AppPenjualanUAS.DataSetPenjualan
    Friend WithEvents PenjualanTableAdapter As AppPenjualanUAS.DataSetPenjualanTableAdapters.PenjualanTableAdapter
End Class
