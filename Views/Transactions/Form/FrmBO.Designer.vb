<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBO
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.cmbStyleName = New System.Windows.Forms.ComboBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.dtpDateIssues = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReffPO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabProductName = New System.Windows.Forms.TabPage()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnfabricDelList = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnfabricAddList = New System.Windows.Forms.Button()
        Me.dgvFabricDetail = New System.Windows.Forms.DataGridView()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.cmbFabric = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbcategoryFabric = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbRange = New System.Windows.Forms.ComboBox()
        Me.RadioKG = New System.Windows.Forms.RadioButton()
        Me.RadioLBS = New System.Windows.Forms.RadioButton()
        Me.txtLoses = New System.Windows.Forms.TextBox()
        Me.txtNetto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBrutto = New System.Windows.Forms.TextBox()
        Me.btnDelColorList = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnColorAddList = New System.Windows.Forms.Button()
        Me.dgvdetailcolor = New System.Windows.Forms.DataGridView()
        Me.txtLabDipsNo = New System.Windows.Forms.TextBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnYarnDelList = New System.Windows.Forms.Button()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnYarnAddList = New System.Windows.Forms.Button()
        Me.dgvyarnmatrial = New System.Windows.Forms.DataGridView()
        Me.cmbYarn = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotNetto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotBruto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabProductName.SuspendLayout()
        CType(Me.dgvFabricDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvdetailcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvyarnmatrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtDeliveryDate)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.cmbBrand)
        Me.Panel1.Controls.Add(Me.cmbStyleName)
        Me.Panel1.Controls.Add(Me.cmbCustomer)
        Me.Panel1.Controls.Add(Me.dtpDateIssues)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtReffPO)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 98)
        Me.Panel1.TabIndex = 27
        '
        'dtDeliveryDate
        '
        Me.dtDeliveryDate.Location = New System.Drawing.Point(79, 65)
        Me.dtDeliveryDate.Name = "dtDeliveryDate"
        Me.dtDeliveryDate.Size = New System.Drawing.Size(196, 20)
        Me.dtDeliveryDate.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Del Date"
        '
        'cmbBrand
        '
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(622, 13)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(196, 21)
        Me.cmbBrand.TabIndex = 28
        '
        'cmbStyleName
        '
        Me.cmbStyleName.FormattingEnabled = True
        Me.cmbStyleName.Location = New System.Drawing.Point(622, 38)
        Me.cmbStyleName.Name = "cmbStyleName"
        Me.cmbStyleName.Size = New System.Drawing.Size(196, 21)
        Me.cmbStyleName.TabIndex = 27
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(356, 39)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(196, 21)
        Me.cmbCustomer.TabIndex = 26
        '
        'dtpDateIssues
        '
        Me.dtpDateIssues.Location = New System.Drawing.Point(79, 39)
        Me.dtpDateIssues.Name = "dtpDateIssues"
        Me.dtpDateIssues.Size = New System.Drawing.Size(196, 20)
        Me.dtpDateIssues.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Date Issues"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(560, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Style"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(560, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Customer"
        '
        'txtReffPO
        '
        Me.txtReffPO.Location = New System.Drawing.Point(356, 13)
        Me.txtReffPO.Name = "txtReffPO"
        Me.txtReffPO.Size = New System.Drawing.Size(196, 20)
        Me.txtReffPO.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No .Reff PO"
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(79, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(196, 20)
        Me.txtCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "No.Order"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(887, 43)
        Me.Label3.TabIndex = 26
        Me.Label3.Tag = "24"
        Me.Label3.Text = "Bon Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabProductName)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(887, 256)
        Me.TabControl1.TabIndex = 28
        '
        'TabProductName
        '
        Me.TabProductName.Controls.Add(Me.txtWeight)
        Me.TabProductName.Controls.Add(Me.btnfabricDelList)
        Me.TabProductName.Controls.Add(Me.Label14)
        Me.TabProductName.Controls.Add(Me.Label31)
        Me.TabProductName.Controls.Add(Me.btnfabricAddList)
        Me.TabProductName.Controls.Add(Me.dgvFabricDetail)
        Me.TabProductName.Controls.Add(Me.txtWidth)
        Me.TabProductName.Controls.Add(Me.cmbFabric)
        Me.TabProductName.Controls.Add(Me.Label20)
        Me.TabProductName.Location = New System.Drawing.Point(4, 22)
        Me.TabProductName.Name = "TabProductName"
        Me.TabProductName.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductName.Size = New System.Drawing.Size(879, 230)
        Me.TabProductName.TabIndex = 0
        Me.TabProductName.Text = "Fabric Details/Item.No"
        Me.TabProductName.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Enabled = False
        Me.txtWeight.Location = New System.Drawing.Point(504, 31)
        Me.txtWeight.MaxLength = 50
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(188, 20)
        Me.txtWeight.TabIndex = 139
        '
        'btnfabricDelList
        '
        Me.btnfabricDelList.Location = New System.Drawing.Point(698, 31)
        Me.btnfabricDelList.Name = "btnfabricDelList"
        Me.btnfabricDelList.Size = New System.Drawing.Size(114, 23)
        Me.btnfabricDelList.TabIndex = 138
        Me.btnfabricDelList.Text = "Delete From List"
        Me.btnfabricDelList.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(450, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Width "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(450, 34)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 13)
        Me.Label31.TabIndex = 134
        Me.Label31.Text = "Weight"
        '
        'btnfabricAddList
        '
        Me.btnfabricAddList.Location = New System.Drawing.Point(698, 3)
        Me.btnfabricAddList.Name = "btnfabricAddList"
        Me.btnfabricAddList.Size = New System.Drawing.Size(114, 23)
        Me.btnfabricAddList.TabIndex = 113
        Me.btnfabricAddList.Text = "Add To List"
        Me.btnfabricAddList.UseVisualStyleBackColor = True
        '
        'dgvFabricDetail
        '
        Me.dgvFabricDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFabricDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFabricDetail.Location = New System.Drawing.Point(10, 77)
        Me.dgvFabricDetail.Name = "dgvFabricDetail"
        Me.dgvFabricDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFabricDetail.Size = New System.Drawing.Size(802, 147)
        Me.dgvFabricDetail.TabIndex = 112
        '
        'txtWidth
        '
        Me.txtWidth.Enabled = False
        Me.txtWidth.Location = New System.Drawing.Point(504, 8)
        Me.txtWidth.MaxLength = 50
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(188, 20)
        Me.txtWidth.TabIndex = 108
        '
        'cmbFabric
        '
        Me.cmbFabric.FormattingEnabled = True
        Me.cmbFabric.Location = New System.Drawing.Point(77, 8)
        Me.cmbFabric.Name = "cmbFabric"
        Me.cmbFabric.Size = New System.Drawing.Size(367, 21)
        Me.cmbFabric.TabIndex = 102
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Fabric Details"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbcategoryFabric)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cmbRange)
        Me.TabPage1.Controls.Add(Me.RadioKG)
        Me.TabPage1.Controls.Add(Me.RadioLBS)
        Me.TabPage1.Controls.Add(Me.txtLoses)
        Me.TabPage1.Controls.Add(Me.txtNetto)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtBrutto)
        Me.TabPage1.Controls.Add(Me.btnDelColorList)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnColorAddList)
        Me.TabPage1.Controls.Add(Me.dgvdetailcolor)
        Me.TabPage1.Controls.Add(Me.txtLabDipsNo)
        Me.TabPage1.Controls.Add(Me.cmbColor)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(879, 230)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Detail Color"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbcategoryFabric
        '
        Me.cmbcategoryFabric.FormattingEnabled = True
        Me.cmbcategoryFabric.Location = New System.Drawing.Point(446, 10)
        Me.cmbcategoryFabric.Name = "cmbcategoryFabric"
        Me.cmbcategoryFabric.Size = New System.Drawing.Size(189, 21)
        Me.cmbcategoryFabric.TabIndex = 157
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "FabricType"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(364, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Losses(%)"
        '
        'cmbRange
        '
        Me.cmbRange.FormattingEnabled = True
        Me.cmbRange.Location = New System.Drawing.Point(170, 66)
        Me.cmbRange.Name = "cmbRange"
        Me.cmbRange.Size = New System.Drawing.Size(188, 21)
        Me.cmbRange.TabIndex = 155
        '
        'RadioKG
        '
        Me.RadioKG.AutoSize = True
        Me.RadioKG.Location = New System.Drawing.Point(16, 88)
        Me.RadioKG.Name = "RadioKG"
        Me.RadioKG.Size = New System.Drawing.Size(143, 17)
        Me.RadioKG.TabIndex = 154
        Me.RadioKG.TabStop = True
        Me.RadioKG.Text = "Order Length Range(KG)"
        Me.RadioKG.UseVisualStyleBackColor = True
        '
        'RadioLBS
        '
        Me.RadioLBS.AutoSize = True
        Me.RadioLBS.Location = New System.Drawing.Point(16, 65)
        Me.RadioLBS.Name = "RadioLBS"
        Me.RadioLBS.Size = New System.Drawing.Size(148, 17)
        Me.RadioLBS.TabIndex = 153
        Me.RadioLBS.TabStop = True
        Me.RadioLBS.Text = "Order Length Range(LBS)"
        Me.RadioLBS.UseVisualStyleBackColor = True
        '
        'txtLoses
        '
        Me.txtLoses.Enabled = False
        Me.txtLoses.Location = New System.Drawing.Point(446, 40)
        Me.txtLoses.MaxLength = 50
        Me.txtLoses.Name = "txtLoses"
        Me.txtLoses.Size = New System.Drawing.Size(189, 20)
        Me.txtLoses.TabIndex = 152
        '
        'txtNetto
        '
        Me.txtNetto.Location = New System.Drawing.Point(682, 11)
        Me.txtNetto.MaxLength = 50
        Me.txtNetto.Name = "txtNetto"
        Me.txtNetto.Size = New System.Drawing.Size(188, 20)
        Me.txtNetto.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(642, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Netto"
        '
        'txtBrutto
        '
        Me.txtBrutto.Enabled = False
        Me.txtBrutto.Location = New System.Drawing.Point(683, 37)
        Me.txtBrutto.MaxLength = 50
        Me.txtBrutto.Name = "txtBrutto"
        Me.txtBrutto.Size = New System.Drawing.Size(188, 20)
        Me.txtBrutto.TabIndex = 148
        '
        'btnDelColorList
        '
        Me.btnDelColorList.Location = New System.Drawing.Point(779, 63)
        Me.btnDelColorList.Name = "btnDelColorList"
        Me.btnDelColorList.Size = New System.Drawing.Size(91, 23)
        Me.btnDelColorList.TabIndex = 147
        Me.btnDelColorList.Text = "Delete From List"
        Me.btnDelColorList.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Lab Dips No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(642, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "Brutto"
        '
        'btnColorAddList
        '
        Me.btnColorAddList.Location = New System.Drawing.Point(682, 63)
        Me.btnColorAddList.Name = "btnColorAddList"
        Me.btnColorAddList.Size = New System.Drawing.Size(91, 23)
        Me.btnColorAddList.TabIndex = 144
        Me.btnColorAddList.Text = "Add To List"
        Me.btnColorAddList.UseVisualStyleBackColor = True
        '
        'dgvdetailcolor
        '
        Me.dgvdetailcolor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailcolor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvdetailcolor.Location = New System.Drawing.Point(11, 111)
        Me.dgvdetailcolor.Name = "dgvdetailcolor"
        Me.dgvdetailcolor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdetailcolor.Size = New System.Drawing.Size(860, 116)
        Me.dgvdetailcolor.TabIndex = 143
        '
        'txtLabDipsNo
        '
        Me.txtLabDipsNo.Location = New System.Drawing.Point(170, 36)
        Me.txtLabDipsNo.MaxLength = 50
        Me.txtLabDipsNo.Name = "txtLabDipsNo"
        Me.txtLabDipsNo.Size = New System.Drawing.Size(188, 20)
        Me.txtLabDipsNo.TabIndex = 142
        '
        'cmbColor
        '
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(170, 6)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(188, 21)
        Me.cmbColor.TabIndex = 140
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Colors"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnYarnDelList)
        Me.TabPage2.Controls.Add(Me.cmbUnit)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.btnYarnAddList)
        Me.TabPage2.Controls.Add(Me.dgvyarnmatrial)
        Me.TabPage2.Controls.Add(Me.cmbYarn)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(879, 230)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Detail Yarn"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnYarnDelList
        '
        Me.btnYarnDelList.Location = New System.Drawing.Point(212, 60)
        Me.btnYarnDelList.Name = "btnYarnDelList"
        Me.btnYarnDelList.Size = New System.Drawing.Size(91, 23)
        Me.btnYarnDelList.TabIndex = 151
        Me.btnYarnDelList.Text = "Delete From List"
        Me.btnYarnDelList.UseVisualStyleBackColor = True
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(115, 33)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(188, 21)
        Me.cmbUnit.TabIndex = 148
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "Unit"
        '
        'btnYarnAddList
        '
        Me.btnYarnAddList.Location = New System.Drawing.Point(115, 60)
        Me.btnYarnAddList.Name = "btnYarnAddList"
        Me.btnYarnAddList.Size = New System.Drawing.Size(91, 23)
        Me.btnYarnAddList.TabIndex = 146
        Me.btnYarnAddList.Text = "Add To List"
        Me.btnYarnAddList.UseVisualStyleBackColor = True
        '
        'dgvyarnmatrial
        '
        Me.dgvyarnmatrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvyarnmatrial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvyarnmatrial.Location = New System.Drawing.Point(7, 87)
        Me.dgvyarnmatrial.Name = "dgvyarnmatrial"
        Me.dgvyarnmatrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvyarnmatrial.Size = New System.Drawing.Size(447, 137)
        Me.dgvyarnmatrial.TabIndex = 145
        '
        'cmbYarn
        '
        Me.cmbYarn.FormattingEnabled = True
        Me.cmbYarn.Location = New System.Drawing.Point(115, 6)
        Me.cmbYarn.Name = "cmbYarn"
        Me.cmbYarn.Size = New System.Drawing.Size(188, 21)
        Me.cmbYarn.TabIndex = 141
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 142
        Me.Label19.Text = "Yarn Name"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Controls.Add(Me.btnPrint)
        Me.Panel5.Controls.Add(Me.btnVoid)
        Me.Panel5.Controls.Add(Me.btnApprove)
        Me.Panel5.Controls.Add(Me.btnUpdate)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 397)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(887, 87)
        Me.Panel5.TabIndex = 75
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtTotNetto)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txtTotBruto)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Location = New System.Drawing.Point(698, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 79)
        Me.Panel3.TabIndex = 81
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(141, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "KGS"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(141, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "KGS"
        '
        'txtTotNetto
        '
        Me.txtTotNetto.Enabled = False
        Me.txtTotNetto.Location = New System.Drawing.Point(63, 54)
        Me.txtTotNetto.Name = "txtTotNetto"
        Me.txtTotNetto.Size = New System.Drawing.Size(72, 20)
        Me.txtTotNetto.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "NETTO"
        '
        'txtTotBruto
        '
        Me.txtTotBruto.Enabled = False
        Me.txtTotBruto.Location = New System.Drawing.Point(63, 30)
        Me.txtTotBruto.Name = "txtTotBruto"
        Me.txtTotBruto.Size = New System.Drawing.Size(72, 20)
        Me.txtTotBruto.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "BRUTO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "TOTAL ORDER QTY"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(416, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 78
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(173, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 77
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Location = New System.Drawing.Point(335, 11)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 23)
        Me.btnVoid.TabIndex = 80
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Enabled = False
        Me.btnApprove.Location = New System.Drawing.Point(254, 11)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 79
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(92, 11)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 76
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(11, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 75
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmBO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 485)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmBO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "24"
        Me.Text = "FrmBO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabProductName.ResumeLayout(False)
        Me.TabProductName.PerformLayout()
        CType(Me.dgvFabricDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvdetailcolor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvyarnmatrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpDateIssues As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReffPO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabProductName As TabPage
    Friend WithEvents btnfabricDelList As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents btnfabricAddList As Button
    Friend WithEvents dgvFabricDetail As DataGridView
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents cmbFabric As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBrutto As TextBox
    Friend WithEvents btnDelColorList As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnColorAddList As Button
    Friend WithEvents dgvdetailcolor As DataGridView
    Friend WithEvents txtLabDipsNo As TextBox
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNetto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLoses As TextBox
    Friend WithEvents cmbRange As ComboBox
    Friend WithEvents RadioKG As RadioButton
    Friend WithEvents RadioLBS As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnYarnDelList As Button
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnYarnAddList As Button
    Friend WithEvents dgvyarnmatrial As DataGridView
    Friend WithEvents cmbYarn As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents cmbStyleName As ComboBox
    Friend WithEvents cmbcategoryFabric As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTotNetto As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotBruto As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dtDeliveryDate As DateTimePicker
    Friend WithEvents Label23 As Label
End Class
