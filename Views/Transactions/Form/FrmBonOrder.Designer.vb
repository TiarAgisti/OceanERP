<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBonOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBonOrder))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpDateIssues = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoPO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPINo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.colFabric = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColorCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNetto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFabricID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabProductName = New System.Windows.Forms.TabPage()
        Me.txtStockAV = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnRawAddList = New System.Windows.Forms.Button()
        Me.dgvrawmatrial = New System.Windows.Forms.DataGridView()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbRawCode = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotNetto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotBruto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRawDelList = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabProductName.SuspendLayout()
        CType(Me.dgvrawmatrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(893, 43)
        Me.Label3.TabIndex = 24
        Me.Label3.Tag = "24"
        Me.Label3.Text = "Bon Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.dtpDateIssues)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtStyle)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtBrand)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCustomer)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNoPO)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbPINo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 96)
        Me.Panel1.TabIndex = 25
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(281, 63)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add To List"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        'txtStyle
        '
        Me.txtStyle.Enabled = False
        Me.txtStyle.Location = New System.Drawing.Point(687, 39)
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.Size = New System.Drawing.Size(196, 20)
        Me.txtStyle.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(614, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Style"
        '
        'txtBrand
        '
        Me.txtBrand.Enabled = False
        Me.txtBrand.Location = New System.Drawing.Point(687, 13)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(196, 20)
        Me.txtBrand.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(614, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Brand / Buyer"
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(369, 13)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(196, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Customer"
        '
        'txtNoPO
        '
        Me.txtNoPO.Enabled = False
        Me.txtNoPO.Location = New System.Drawing.Point(369, 39)
        Me.txtNoPO.Name = "txtNoPO"
        Me.txtNoPO.Size = New System.Drawing.Size(196, 20)
        Me.txtNoPO.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No .Reff PO"
        '
        'cmbPINo
        '
        Me.cmbPINo.FormattingEnabled = True
        Me.cmbPINo.Location = New System.Drawing.Point(79, 65)
        Me.cmbPINo.Name = "cmbPINo"
        Me.cmbPINo.Size = New System.Drawing.Size(196, 21)
        Me.cmbPINo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "PI No."
        '
        'txtCode
        '
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
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "No Bon Order"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFabric, Me.colWidth, Me.colColor, Me.colColorCode, Me.colBruto, Me.colNetto, Me.colFabricID, Me.colColorID})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.Location = New System.Drawing.Point(0, 139)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(893, 200)
        Me.dgv.TabIndex = 8
        '
        'colFabric
        '
        Me.colFabric.HeaderText = "Fabric Details / Item No"
        Me.colFabric.Name = "colFabric"
        Me.colFabric.ReadOnly = True
        Me.colFabric.Width = 200
        '
        'colWidth
        '
        Me.colWidth.HeaderText = "Width x Weight"
        Me.colWidth.Name = "colWidth"
        Me.colWidth.ReadOnly = True
        Me.colWidth.Width = 200
        '
        'colColor
        '
        Me.colColor.HeaderText = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.ReadOnly = True
        '
        'colColorCode
        '
        Me.colColorCode.HeaderText = "Labs Dips No"
        Me.colColorCode.Name = "colColorCode"
        Me.colColorCode.ReadOnly = True
        Me.colColorCode.Width = 150
        '
        'colBruto
        '
        Me.colBruto.HeaderText = "Bruto"
        Me.colBruto.MaxInputLength = 15
        Me.colBruto.Name = "colBruto"
        '
        'colNetto
        '
        Me.colNetto.HeaderText = "Netto"
        Me.colNetto.MaxInputLength = 15
        Me.colNetto.Name = "colNetto"
        '
        'colFabricID
        '
        Me.colFabricID.HeaderText = "Fabric ID"
        Me.colFabricID.Name = "colFabricID"
        Me.colFabricID.ReadOnly = True
        Me.colFabricID.Visible = False
        '
        'colColorID
        '
        Me.colColorID.HeaderText = "ColorID"
        Me.colColorID.Name = "colColorID"
        Me.colColorID.ReadOnly = True
        Me.colColorID.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnVoid)
        Me.Panel2.Controls.Add(Me.btnApprove)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 339)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(893, 314)
        Me.Panel2.TabIndex = 27
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabProductName)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(889, 227)
        Me.TabControl1.TabIndex = 19
        '
        'TabProductName
        '
        Me.TabProductName.Controls.Add(Me.btnRawDelList)
        Me.TabProductName.Controls.Add(Me.txtStockAV)
        Me.TabProductName.Controls.Add(Me.Label14)
        Me.TabProductName.Controls.Add(Me.cmbUnit)
        Me.TabProductName.Controls.Add(Me.Label31)
        Me.TabProductName.Controls.Add(Me.btnRawAddList)
        Me.TabProductName.Controls.Add(Me.dgvrawmatrial)
        Me.TabProductName.Controls.Add(Me.txtQty)
        Me.TabProductName.Controls.Add(Me.Label15)
        Me.TabProductName.Controls.Add(Me.cmbRawCode)
        Me.TabProductName.Controls.Add(Me.Label20)
        Me.TabProductName.Location = New System.Drawing.Point(4, 22)
        Me.TabProductName.Name = "TabProductName"
        Me.TabProductName.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductName.Size = New System.Drawing.Size(881, 201)
        Me.TabProductName.TabIndex = 0
        Me.TabProductName.Text = "Raw Material"
        Me.TabProductName.UseVisualStyleBackColor = True
        '
        'txtStockAV
        '
        Me.txtStockAV.Enabled = False
        Me.txtStockAV.Location = New System.Drawing.Point(113, 35)
        Me.txtStockAV.MaxLength = 50
        Me.txtStockAV.Name = "txtStockAV"
        Me.txtStockAV.Size = New System.Drawing.Size(188, 20)
        Me.txtStockAV.TabIndex = 136
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = " Available Stock"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(402, 7)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(188, 21)
        Me.cmbUnit.TabIndex = 135
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(317, 10)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 134
        Me.Label31.Text = "Unit"
        '
        'btnRawAddList
        '
        Me.btnRawAddList.Location = New System.Drawing.Point(350, 59)
        Me.btnRawAddList.Name = "btnRawAddList"
        Me.btnRawAddList.Size = New System.Drawing.Size(114, 23)
        Me.btnRawAddList.TabIndex = 113
        Me.btnRawAddList.Text = "Add To List"
        Me.btnRawAddList.UseVisualStyleBackColor = True
        '
        'dgvrawmatrial
        '
        Me.dgvrawmatrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrawmatrial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvrawmatrial.Location = New System.Drawing.Point(10, 88)
        Me.dgvrawmatrial.Name = "dgvrawmatrial"
        Me.dgvrawmatrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvrawmatrial.Size = New System.Drawing.Size(580, 107)
        Me.dgvrawmatrial.TabIndex = 112
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(402, 34)
        Me.txtQty.MaxLength = 50
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(188, 20)
        Me.txtQty.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(317, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Quantity"
        '
        'cmbRawCode
        '
        Me.cmbRawCode.FormattingEnabled = True
        Me.cmbRawCode.Location = New System.Drawing.Point(113, 8)
        Me.cmbRawCode.Name = "cmbRawCode"
        Me.cmbRawCode.Size = New System.Drawing.Size(188, 21)
        Me.cmbRawCode.TabIndex = 102
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Raw Material Name"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(307, 234)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(127, 234)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(56, 23)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Location = New System.Drawing.Point(245, 234)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(56, 23)
        Me.btnVoid.TabIndex = 15
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Enabled = False
        Me.btnApprove.Location = New System.Drawing.Point(183, 234)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(56, 23)
        Me.btnApprove.TabIndex = 14
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(65, 234)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(56, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(3, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtTotNetto)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtTotBruto)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(710, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 79)
        Me.Panel3.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(141, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "KGS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(141, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "KGS"
        '
        'txtTotNetto
        '
        Me.txtTotNetto.Enabled = False
        Me.txtTotNetto.Location = New System.Drawing.Point(63, 54)
        Me.txtTotNetto.Name = "txtTotNetto"
        Me.txtTotNetto.Size = New System.Drawing.Size(72, 20)
        Me.txtTotNetto.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "NETTO"
        '
        'txtTotBruto
        '
        Me.txtTotBruto.Enabled = False
        Me.txtTotBruto.Location = New System.Drawing.Point(63, 30)
        Me.txtTotBruto.Name = "txtTotBruto"
        Me.txtTotBruto.Size = New System.Drawing.Size(72, 20)
        Me.txtTotBruto.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "BRUTO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "TOTAL ORDER QTY"
        '
        'btnRawDelList
        '
        Me.btnRawDelList.Location = New System.Drawing.Point(470, 59)
        Me.btnRawDelList.Name = "btnRawDelList"
        Me.btnRawDelList.Size = New System.Drawing.Size(120, 23)
        Me.btnRawDelList.TabIndex = 138
        Me.btnRawDelList.Text = "Delete From List"
        Me.btnRawDelList.UseVisualStyleBackColor = True
        '
        'FrmBonOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(893, 653)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBonOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "24"
        Me.Text = "FrmBonOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabProductName.ResumeLayout(False)
        Me.TabProductName.PerformLayout()
        CType(Me.dgvrawmatrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtStyle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoPO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPINo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotNetto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotBruto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpDateIssues As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents colFabric As DataGridViewTextBoxColumn
    Friend WithEvents colWidth As DataGridViewTextBoxColumn
    Friend WithEvents colColor As DataGridViewTextBoxColumn
    Friend WithEvents colColorCode As DataGridViewTextBoxColumn
    Friend WithEvents colBruto As DataGridViewTextBoxColumn
    Friend WithEvents colNetto As DataGridViewTextBoxColumn
    Friend WithEvents colFabricID As DataGridViewTextBoxColumn
    Friend WithEvents colColorID As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabProductName As TabPage
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents btnRawAddList As Button
    Friend WithEvents dgvrawmatrial As DataGridView
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbRawCode As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtStockAV As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnRawDelList As Button
End Class
