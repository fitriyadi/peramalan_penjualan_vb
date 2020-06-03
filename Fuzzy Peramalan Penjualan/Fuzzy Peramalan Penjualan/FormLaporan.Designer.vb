<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.tb_hasil_cetak_lagiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_peramalan_penjualanDataSet = New Fuzzy_Peramalan_Penjualan.db_peramalan_penjualanDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnBaru = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbTahun = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.cbIDBarang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.tb_hasil_cetak_lagiTableAdapter = New Fuzzy_Peramalan_Penjualan.db_peramalan_penjualanDataSetTableAdapters.tb_hasil_cetak_lagiTableAdapter()
        CType(Me.tb_hasil_cetak_lagiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_peramalan_penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_hasil_cetak_lagiBindingSource
        '
        Me.tb_hasil_cetak_lagiBindingSource.DataMember = "tb_hasil_cetak_lagi"
        Me.tb_hasil_cetak_lagiBindingSource.DataSource = Me.db_peramalan_penjualanDataSet
        '
        'db_peramalan_penjualanDataSet
        '
        Me.db_peramalan_penjualanDataSet.DataSetName = "db_peramalan_penjualanDataSet"
        Me.db_peramalan_penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_hasil_cetak_lagiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Fuzzy_Peramalan_Penjualan.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 45)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(794, 384)
        Me.ReportViewer1.TabIndex = 40
        '
        'btnBaru
        '
        Me.btnBaru.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBaru.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBaru.Location = New System.Drawing.Point(386, 11)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 28)
        Me.btnBaru.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBaru.TabIndex = 0
        Me.btnBaru.Text = "View"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(13, 13)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 41
        Me.LabelX2.Text = "Filter Tahun"
        '
        'cbTahun
        '
        Me.cbTahun.DisplayMember = "Text"
        Me.cbTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTahun.FormattingEnabled = True
        Me.cbTahun.ItemHeight = 14
        Me.cbTahun.Location = New System.Drawing.Point(94, 14)
        Me.cbTahun.Name = "cbTahun"
        Me.cbTahun.Size = New System.Drawing.Size(72, 20)
        Me.cbTahun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTahun.TabIndex = 42
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(711, 8)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 28)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 43
        Me.ButtonX1.Text = "Cetak"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.cbIDBarang)
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.cbTahun)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.btnBaru)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(794, 45)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 39
        '
        'cbIDBarang
        '
        Me.cbIDBarang.DisplayMember = "Text"
        Me.cbIDBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbIDBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIDBarang.FormattingEnabled = True
        Me.cbIDBarang.ItemHeight = 14
        Me.cbIDBarang.Location = New System.Drawing.Point(255, 16)
        Me.cbIDBarang.Name = "cbIDBarang"
        Me.cbIDBarang.Size = New System.Drawing.Size(125, 20)
        Me.cbIDBarang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbIDBarang.TabIndex = 45
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(178, 13)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 44
        Me.LabelX3.Text = "Filter Kategori"
        '
        'tb_hasil_cetak_lagiTableAdapter
        '
        Me.tb_hasil_cetak_lagiTableAdapter.ClearBeforeFill = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 429)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.PanelEx2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Laporan"
        CType(Me.tb_hasil_cetak_lagiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_peramalan_penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnBaru As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTahun As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cbIDBarang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tb_hasil_cetak_lagiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_peramalan_penjualanDataSet As Fuzzy_Peramalan_Penjualan.db_peramalan_penjualanDataSet
    Friend WithEvents tb_hasil_cetak_lagiTableAdapter As Fuzzy_Peramalan_Penjualan.db_peramalan_penjualanDataSetTableAdapters.tb_hasil_cetak_lagiTableAdapter
End Class
