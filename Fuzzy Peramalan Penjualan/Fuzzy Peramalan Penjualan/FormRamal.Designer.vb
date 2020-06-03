<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRamal
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.lbl_nmbarang = New System.Windows.Forms.Label()
        Me.lbl_nmrata = New System.Windows.Forms.Label()
        Me.tb_target = New System.Windows.Forms.TextBox()
        Me.cbTahun = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rbBulan = New System.Windows.Forms.RadioButton()
        Me.btnRamal = New DevComponents.DotNetBar.ButtonX()
        Me.cbIDBarang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblMAD = New DevComponents.DotNetBar.LabelX()
        Me.dataView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hasil_kesalahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelEx2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.lbl_nmbarang)
        Me.PanelEx2.Controls.Add(Me.lbl_nmrata)
        Me.PanelEx2.Controls.Add(Me.tb_target)
        Me.PanelEx2.Controls.Add(Me.cbTahun)
        Me.PanelEx2.Controls.Add(Me.rbBulan)
        Me.PanelEx2.Controls.Add(Me.btnRamal)
        Me.PanelEx2.Controls.Add(Me.cbIDBarang)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(835, 67)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 38
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(589, 29)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 28)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 50
        Me.ButtonX1.Text = "Simpan"
        '
        'lbl_nmbarang
        '
        Me.lbl_nmbarang.AutoSize = True
        Me.lbl_nmbarang.Location = New System.Drawing.Point(117, 11)
        Me.lbl_nmbarang.Name = "lbl_nmbarang"
        Me.lbl_nmbarang.Size = New System.Drawing.Size(72, 13)
        Me.lbl_nmbarang.TabIndex = 49
        Me.lbl_nmbarang.Text = "Nama Barang"
        '
        'lbl_nmrata
        '
        Me.lbl_nmrata.AutoSize = True
        Me.lbl_nmrata.Location = New System.Drawing.Point(404, 16)
        Me.lbl_nmrata.Name = "lbl_nmrata"
        Me.lbl_nmrata.Size = New System.Drawing.Size(92, 13)
        Me.lbl_nmrata.TabIndex = 48
        Me.lbl_nmrata.Text = "Masukkan Rerata"
        '
        'tb_target
        '
        Me.tb_target.Location = New System.Drawing.Point(404, 32)
        Me.tb_target.Name = "tb_target"
        Me.tb_target.Size = New System.Drawing.Size(79, 20)
        Me.tb_target.TabIndex = 47
        '
        'cbTahun
        '
        Me.cbTahun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTahun.DisplayMember = "Text"
        Me.cbTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTahun.FormattingEnabled = True
        Me.cbTahun.ItemHeight = 14
        Me.cbTahun.Location = New System.Drawing.Point(307, 32)
        Me.cbTahun.Name = "cbTahun"
        Me.cbTahun.Size = New System.Drawing.Size(91, 20)
        Me.cbTahun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTahun.TabIndex = 45
        '
        'rbBulan
        '
        Me.rbBulan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbBulan.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbBulan.AutoSize = True
        Me.rbBulan.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbBulan.Location = New System.Drawing.Point(307, 6)
        Me.rbBulan.Name = "rbBulan"
        Me.rbBulan.Size = New System.Drawing.Size(73, 23)
        Me.rbBulan.TabIndex = 44
        Me.rbBulan.Text = "Filter Tahun"
        Me.rbBulan.UseVisualStyleBackColor = False
        '
        'btnRamal
        '
        Me.btnRamal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRamal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRamal.Location = New System.Drawing.Point(508, 29)
        Me.btnRamal.Name = "btnRamal"
        Me.btnRamal.Size = New System.Drawing.Size(75, 28)
        Me.btnRamal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRamal.TabIndex = 41
        Me.btnRamal.Text = "Proses"
        '
        'cbIDBarang
        '
        Me.cbIDBarang.DisplayMember = "Text"
        Me.cbIDBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbIDBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIDBarang.FormattingEnabled = True
        Me.cbIDBarang.ItemHeight = 14
        Me.cbIDBarang.Location = New System.Drawing.Point(120, 32)
        Me.cbIDBarang.Name = "cbIDBarang"
        Me.cbIDBarang.Size = New System.Drawing.Size(181, 20)
        Me.cbIDBarang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbIDBarang.TabIndex = 40
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(39, 29)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 37
        Me.LabelX1.Text = "Filter Hasil"
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 67)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(835, 353)
        Me.TabControl1.TabIndex = 41
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.PanelEx1)
        Me.TabControlPanel1.Controls.Add(Me.dataView)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(835, 327)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lblMAD)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(604, 48)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(200, 75)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 41
        '
        'lblMAD
        '
        '
        '
        '
        Me.lblMAD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAD.Location = New System.Drawing.Point(20, 34)
        Me.lblMAD.Name = "lblMAD"
        Me.lblMAD.Size = New System.Drawing.Size(166, 23)
        Me.lblMAD.TabIndex = 1
        Me.lblMAD.Text = "MAD :"
        '
        'dataView
        '
        Me.dataView.AllowUserToAddRows = False
        Me.dataView.AllowUserToDeleteRows = False
        Me.dataView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.hasil_kesalahan})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataView.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataView.EnableHeadersVisualStyles = False
        Me.dataView.GridColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.dataView.Location = New System.Drawing.Point(1, 1)
        Me.dataView.Name = "dataView"
        Me.dataView.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataView.RowHeadersWidth = 10
        Me.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataView.Size = New System.Drawing.Size(833, 325)
        Me.dataView.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipe"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Hasil Peramalan"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'hasil_kesalahan
        '
        Me.hasil_kesalahan.HeaderText = "Hasil Kesalahan"
        Me.hasil_kesalahan.Name = "hasil_kesalahan"
        Me.hasil_kesalahan.ReadOnly = True
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Hasil Peramalan"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.Chart1)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(835, 327)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(1, 1)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(833, 325)
        Me.Chart1.SuppressExceptions = True
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Grafik"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.GlobalItem = False
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ButtonItem1"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.GlobalItem = False
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "ButtonItem2"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.GlobalItem = False
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "ButtonItem3"
        '
        'FormRamal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 420)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelEx2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "FormRamal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proses Permalan"
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cbIDBarang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dataView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRamal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTahun As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rbBulan As System.Windows.Forms.RadioButton
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblMAD As DevComponents.DotNetBar.LabelX
    Friend WithEvents tb_target As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nmrata As System.Windows.Forms.Label
    Friend WithEvents lbl_nmbarang As System.Windows.Forms.Label
    Friend WithEvents hasil_kesalahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
