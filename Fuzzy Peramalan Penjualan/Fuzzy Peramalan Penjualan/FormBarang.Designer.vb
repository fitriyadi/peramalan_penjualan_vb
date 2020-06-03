<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtIDBarang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtHarga = New DevComponents.Editors.DoubleInput()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.btnBaru = New DevComponents.DotNetBar.ButtonX()
        Me.dataView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTambah = New DevComponents.DotNetBar.ButtonX()
        Me.cbIDBarang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.txtHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(25, 64)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(129, 23)
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "Kategori Barang"
        '
        'txtIDBarang
        '
        Me.txtIDBarang.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIDBarang.Border.Class = "TextBoxBorder"
        Me.txtIDBarang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIDBarang.ButtonCustom.Tooltip = ""
        Me.txtIDBarang.ButtonCustom2.Tooltip = ""
        Me.txtIDBarang.DisabledBackColor = System.Drawing.Color.Black
        Me.txtIDBarang.ForeColor = System.Drawing.Color.Black
        Me.txtIDBarang.Location = New System.Drawing.Point(142, 12)
        Me.txtIDBarang.Name = "txtIDBarang"
        Me.txtIDBarang.PreventEnterBeep = True
        Me.txtIDBarang.ReadOnly = True
        Me.txtIDBarang.Size = New System.Drawing.Size(87, 20)
        Me.txtIDBarang.TabIndex = 10
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(25, 38)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Nama Barang"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(25, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "ID Barang"
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNama.Border.Class = "TextBoxBorder"
        Me.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNama.ButtonCustom.Tooltip = ""
        Me.txtNama.ButtonCustom2.Tooltip = ""
        Me.txtNama.DisabledBackColor = System.Drawing.Color.Black
        Me.txtNama.ForeColor = System.Drawing.Color.Black
        Me.txtNama.Location = New System.Drawing.Point(142, 38)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PreventEnterBeep = True
        Me.txtNama.Size = New System.Drawing.Size(358, 20)
        Me.txtNama.TabIndex = 16
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(25, 90)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(129, 23)
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "Harga Barang"
        '
        'txtHarga
        '
        '
        '
        '
        Me.txtHarga.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtHarga.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHarga.ButtonCalculator.Tooltip = ""
        Me.txtHarga.ButtonClear.Tooltip = ""
        Me.txtHarga.ButtonCustom.Tooltip = ""
        Me.txtHarga.ButtonCustom2.Tooltip = ""
        Me.txtHarga.ButtonDropDown.Tooltip = ""
        Me.txtHarga.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtHarga.ButtonFreeText.Tooltip = ""
        Me.txtHarga.Increment = 1.0R
        Me.txtHarga.Location = New System.Drawing.Point(142, 90)
        Me.txtHarga.MinValue = 0.0R
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ShowUpDown = True
        Me.txtHarga.Size = New System.Drawing.Size(87, 20)
        Me.txtHarga.TabIndex = 19
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btnSimpan)
        Me.PanelEx2.Controls.Add(Me.btnBaru)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(2, 146)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(632, 43)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 22
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Location = New System.Drawing.Point(23, 7)
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
        Me.btnBaru.Location = New System.Drawing.Point(104, 7)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 28)
        Me.btnBaru.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBaru.TabIndex = 0
        Me.btnBaru.Text = "Baru"
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
        Me.dataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataView.EnableHeadersVisualStyles = False
        Me.dataView.GridColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.dataView.Location = New System.Drawing.Point(2, 187)
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
        Me.dataView.Size = New System.Drawing.Size(629, 240)
        Me.dataView.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipe"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
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
        'btnTambah
        '
        Me.btnTambah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTambah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnTambah.Location = New System.Drawing.Point(298, 64)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(25, 20)
        Me.btnTambah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTambah.TabIndex = 24
        Me.btnTambah.Text = "+"
        '
        'cbIDBarang
        '
        Me.cbIDBarang.DisplayMember = "Text"
        Me.cbIDBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbIDBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIDBarang.FormattingEnabled = True
        Me.cbIDBarang.ItemHeight = 14
        Me.cbIDBarang.Location = New System.Drawing.Point(142, 64)
        Me.cbIDBarang.Name = "cbIDBarang"
        Me.cbIDBarang.Size = New System.Drawing.Size(150, 20)
        Me.cbIDBarang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbIDBarang.TabIndex = 41
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 426)
        Me.Controls.Add(Me.cbIDBarang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dataView)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtIDBarang)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Barang"
        CType(Me.txtHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Public WithEvents txtIDBarang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Public WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtHarga As DevComponents.Editors.DoubleInput
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBaru As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dataView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTambah As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbIDBarang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
