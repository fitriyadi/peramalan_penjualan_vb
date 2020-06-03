<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btnCari = New DevComponents.DotNetBar.ButtonX()
        Me.cbFTahun = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbFBulan = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rbTahun = New System.Windows.Forms.RadioButton()
        Me.rbBulan = New System.Windows.Forms.RadioButton()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.btnBaru = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtJml = New DevComponents.Editors.IntegerInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtTipe = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNamaBarang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtHarga = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cbBulan = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbIDBarang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtIDJual = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbTahun = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.txtJml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataView
        '
        Me.dataView.AllowUserToAddRows = False
        Me.dataView.AllowUserToDeleteRows = False
        Me.dataView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataView.EnableHeadersVisualStyles = False
        Me.dataView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataView.Location = New System.Drawing.Point(-6, 254)
        Me.dataView.Name = "dataView"
        Me.dataView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataView.RowHeadersWidth = 10
        Me.dataView.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataView.Size = New System.Drawing.Size(660, 198)
        Me.dataView.TabIndex = 35
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Penjualan"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Bulan"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipe"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Jml. Satuan"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 48)
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btnCari)
        Me.PanelEx2.Controls.Add(Me.cbFTahun)
        Me.PanelEx2.Controls.Add(Me.cbFBulan)
        Me.PanelEx2.Controls.Add(Me.rbTahun)
        Me.PanelEx2.Controls.Add(Me.rbBulan)
        Me.PanelEx2.Controls.Add(Me.btnSimpan)
        Me.PanelEx2.Controls.Add(Me.btnBaru)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(-6, 209)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(660, 43)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 34
        '
        'btnCari
        '
        Me.btnCari.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCari.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCari.Location = New System.Drawing.Point(591, 9)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(61, 28)
        Me.btnCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCari.TabIndex = 47
        Me.btnCari.Text = "Cari"
        '
        'cbFTahun
        '
        Me.cbFTahun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFTahun.DisplayMember = "Text"
        Me.cbFTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFTahun.FormattingEnabled = True
        Me.cbFTahun.ItemHeight = 14
        Me.cbFTahun.Location = New System.Drawing.Point(509, 14)
        Me.cbFTahun.Name = "cbFTahun"
        Me.cbFTahun.Size = New System.Drawing.Size(76, 20)
        Me.cbFTahun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbFTahun.TabIndex = 46
        '
        'cbFBulan
        '
        Me.cbFBulan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFBulan.DisplayMember = "Text"
        Me.cbFBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFBulan.FormattingEnabled = True
        Me.cbFBulan.ItemHeight = 14
        Me.cbFBulan.Location = New System.Drawing.Point(325, 14)
        Me.cbFBulan.Name = "cbFBulan"
        Me.cbFBulan.Size = New System.Drawing.Size(91, 20)
        Me.cbFBulan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbFBulan.TabIndex = 41
        '
        'rbTahun
        '
        Me.rbTahun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTahun.AutoSize = True
        Me.rbTahun.Location = New System.Drawing.Point(423, 14)
        Me.rbTahun.Name = "rbTahun"
        Me.rbTahun.Size = New System.Drawing.Size(81, 17)
        Me.rbTahun.TabIndex = 3
        Me.rbTahun.Text = "Filter Tahun"
        Me.rbTahun.UseVisualStyleBackColor = True
        '
        'rbBulan
        '
        Me.rbBulan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbBulan.AutoSize = True
        Me.rbBulan.Checked = True
        Me.rbBulan.Location = New System.Drawing.Point(242, 14)
        Me.rbBulan.Name = "rbBulan"
        Me.rbBulan.Size = New System.Drawing.Size(77, 17)
        Me.rbBulan.TabIndex = 2
        Me.rbBulan.TabStop = True
        Me.rbBulan.Text = "Filter Bulan"
        Me.rbBulan.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Location = New System.Drawing.Point(20, 9)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 28)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        '
        'btnBaru
        '
        Me.btnBaru.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBaru.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBaru.Location = New System.Drawing.Point(101, 9)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 28)
        Me.btnBaru.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBaru.TabIndex = 0
        Me.btnBaru.Text = "Baru"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(14, 116)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(99, 23)
        Me.LabelX5.TabIndex = 33
        Me.LabelX5.Text = "Jml. Satuan"
        '
        'txtJml
        '
        '
        '
        '
        Me.txtJml.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtJml.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJml.ButtonCalculator.Tooltip = ""
        Me.txtJml.ButtonClear.Tooltip = ""
        Me.txtJml.ButtonCustom.Tooltip = ""
        Me.txtJml.ButtonCustom2.Tooltip = ""
        Me.txtJml.ButtonDropDown.Tooltip = ""
        Me.txtJml.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtJml.ButtonFreeText.Tooltip = ""
        Me.txtJml.Location = New System.Drawing.Point(131, 119)
        Me.txtJml.MinValue = 0
        Me.txtJml.Name = "txtJml"
        Me.txtJml.ShowUpDown = True
        Me.txtJml.Size = New System.Drawing.Size(53, 20)
        Me.txtJml.TabIndex = 32
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(14, 92)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(129, 23)
        Me.LabelX4.TabIndex = 30
        Me.LabelX4.Text = "Harga Barang"
        '
        'txtTipe
        '
        '
        '
        '
        Me.txtTipe.Border.Class = "TextBoxBorder"
        Me.txtTipe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTipe.ButtonCustom.Tooltip = ""
        Me.txtTipe.ButtonCustom2.Tooltip = ""
        Me.txtTipe.DisabledBackColor = System.Drawing.Color.Black
        Me.txtTipe.Location = New System.Drawing.Point(131, 66)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.PreventEnterBeep = True
        Me.txtTipe.ReadOnly = True
        Me.txtTipe.Size = New System.Drawing.Size(150, 20)
        Me.txtTipe.TabIndex = 29
        '
        'txtNamaBarang
        '
        '
        '
        '
        Me.txtNamaBarang.Border.Class = "TextBoxBorder"
        Me.txtNamaBarang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNamaBarang.ButtonCustom.Tooltip = ""
        Me.txtNamaBarang.ButtonCustom2.Tooltip = ""
        Me.txtNamaBarang.DisabledBackColor = System.Drawing.Color.Black
        Me.txtNamaBarang.Location = New System.Drawing.Point(131, 40)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.PreventEnterBeep = True
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(358, 20)
        Me.txtNamaBarang.TabIndex = 28
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(14, 66)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(129, 23)
        Me.LabelX3.TabIndex = 27
        Me.LabelX3.Text = "Kategori Barang"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(14, 40)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 26
        Me.LabelX2.Text = "Nama Barang"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(14, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 25
        Me.LabelX1.Text = "ID Barang"
        '
        'txtHarga
        '
        '
        '
        '
        Me.txtHarga.Border.Class = "TextBoxBorder"
        Me.txtHarga.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHarga.ButtonCustom.Tooltip = ""
        Me.txtHarga.ButtonCustom2.Tooltip = ""
        Me.txtHarga.DisabledBackColor = System.Drawing.Color.Black
        Me.txtHarga.Location = New System.Drawing.Point(131, 92)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.PreventEnterBeep = True
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(150, 20)
        Me.txtHarga.TabIndex = 36
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(14, 144)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(99, 23)
        Me.LabelX6.TabIndex = 39
        Me.LabelX6.Text = "Bulan"
        '
        'cbBulan
        '
        Me.cbBulan.DisplayMember = "Text"
        Me.cbBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBulan.FormattingEnabled = True
        Me.cbBulan.ItemHeight = 14
        Me.cbBulan.Location = New System.Drawing.Point(131, 146)
        Me.cbBulan.Name = "cbBulan"
        Me.cbBulan.Size = New System.Drawing.Size(121, 20)
        Me.cbBulan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbBulan.TabIndex = 40
        '
        'cbIDBarang
        '
        Me.cbIDBarang.DisplayMember = "Text"
        Me.cbIDBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbIDBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIDBarang.FormattingEnabled = True
        Me.cbIDBarang.ItemHeight = 14
        Me.cbIDBarang.Location = New System.Drawing.Point(131, 14)
        Me.cbIDBarang.Name = "cbIDBarang"
        Me.cbIDBarang.Size = New System.Drawing.Size(121, 20)
        Me.cbIDBarang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbIDBarang.TabIndex = 41
        '
        'txtIDJual
        '
        '
        '
        '
        Me.txtIDJual.Border.Class = "TextBoxBorder"
        Me.txtIDJual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIDJual.ButtonCustom.Tooltip = ""
        Me.txtIDJual.ButtonCustom2.Tooltip = ""
        Me.txtIDJual.DisabledBackColor = System.Drawing.Color.Black
        Me.txtIDJual.Location = New System.Drawing.Point(363, 66)
        Me.txtIDJual.Name = "txtIDJual"
        Me.txtIDJual.PreventEnterBeep = True
        Me.txtIDJual.ReadOnly = True
        Me.txtIDJual.Size = New System.Drawing.Size(126, 20)
        Me.txtIDJual.TabIndex = 43
        Me.txtIDJual.Visible = False
        '
        'cbTahun
        '
        Me.cbTahun.DisplayMember = "Text"
        Me.cbTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTahun.FormattingEnabled = True
        Me.cbTahun.ItemHeight = 14
        Me.cbTahun.Location = New System.Drawing.Point(131, 172)
        Me.cbTahun.Name = "cbTahun"
        Me.cbTahun.Size = New System.Drawing.Size(121, 20)
        Me.cbTahun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTahun.TabIndex = 45
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(14, 170)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(99, 23)
        Me.LabelX7.TabIndex = 44
        Me.LabelX7.Text = "Tahun"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 452)
        Me.Controls.Add(Me.cbTahun)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.txtIDJual)
        Me.Controls.Add(Me.cbIDBarang)
        Me.Controls.Add(Me.cbBulan)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.dataView)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.txtJml)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtTipe)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Penjualan"
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.txtJml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBaru As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtJml As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Public WithEvents txtTipe As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents txtNamaBarang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Public WithEvents txtHarga As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbBulan As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbIDBarang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txtIDJual As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbTahun As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbFTahun As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbFBulan As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rbTahun As System.Windows.Forms.RadioButton
    Friend WithEvents rbBulan As System.Windows.Forms.RadioButton
    Friend WithEvents btnCari As DevComponents.DotNetBar.ButtonX
End Class
