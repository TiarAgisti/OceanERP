<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchaseOrder))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbSVM = New System.Windows.Forms.ComboBox()
        Me.dtERD = New System.Windows.Forms.DateTimePicker()
        Me.dtSD = New System.Windows.Forms.DateTimePicker()
        Me.cmbTOP = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtPODate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPINO = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmailSup = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFaxSup = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneSup = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddressSup = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCPSup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabProductName = New System.Windows.Forms.TabPage()
        Me.dgvrawmatrial = New System.Windows.Forms.DataGridView()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSH = New System.Windows.Forms.TextBox()
        Me.txtOtherCost = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.btnYarnDelList = New System.Windows.Forms.Button()
        Me.btnYarnAddList = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbYarnCode = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabRemark = New System.Windows.Forms.TabPage()
        Me.dgvRemarks = New System.Windows.Forms.DataGridView()
        Me.btnRemDelList = New System.Windows.Forms.Button()
        Me.btnRemAddList = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtStockAV = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabProductName.SuspendLayout()
        CType(Me.dgvrawmatrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabRemark.SuspendLayout()
        CType(Me.dgvRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(896, 34)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Purchase Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCurrency)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cmbSVM)
        Me.GroupBox1.Controls.Add(Me.dtERD)
        Me.GroupBox1.Controls.Add(Me.dtSD)
        Me.GroupBox1.Controls.Add(Me.cmbTOP)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtPODate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 91)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(702, 38)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(188, 21)
        Me.cmbCurrency.TabIndex = 139
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(579, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 138
        Me.Label21.Text = "Currency"
        '
        'cmbSVM
        '
        Me.cmbSVM.FormattingEnabled = True
        Me.cmbSVM.Location = New System.Drawing.Point(98, 64)
        Me.cmbSVM.Name = "cmbSVM"
        Me.cmbSVM.Size = New System.Drawing.Size(188, 21)
        Me.cmbSVM.TabIndex = 34
        '
        'dtERD
        '
        Me.dtERD.Location = New System.Drawing.Point(704, 11)
        Me.dtERD.Name = "dtERD"
        Me.dtERD.Size = New System.Drawing.Size(186, 20)
        Me.dtERD.TabIndex = 33
        '
        'dtSD
        '
        Me.dtSD.Location = New System.Drawing.Point(382, 11)
        Me.dtSD.Name = "dtSD"
        Me.dtSD.Size = New System.Drawing.Size(188, 20)
        Me.dtSD.TabIndex = 32
        '
        'cmbTOP
        '
        Me.cmbTOP.FormattingEnabled = True
        Me.cmbTOP.Location = New System.Drawing.Point(382, 37)
        Me.cmbTOP.Name = "cmbTOP"
        Me.cmbTOP.Size = New System.Drawing.Size(188, 21)
        Me.cmbTOP.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(576, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Expected Receipt Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(292, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Term Of Payment"
        '
        'dtPODate
        '
        Me.dtPODate.Location = New System.Drawing.Point(98, 38)
        Me.dtPODate.Name = "dtPODate"
        Me.dtPODate.Size = New System.Drawing.Size(188, 20)
        Me.dtPODate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PO Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(292, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Shipping Date"
        '
        'txtPONo
        '
        Me.txtPONo.Enabled = False
        Me.txtPONo.Location = New System.Drawing.Point(98, 11)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(188, 20)
        Me.txtPONo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PO No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Ship Via/Method"
        '
        'cmbPINO
        '
        Me.cmbPINO.FormattingEnabled = True
        Me.cmbPINO.Location = New System.Drawing.Point(118, 7)
        Me.cmbPINO.Name = "cmbPINO"
        Me.cmbPINO.Size = New System.Drawing.Size(188, 21)
        Me.cmbPINO.TabIndex = 36
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(9, 7)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 13)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "PI No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEmailSup)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtFaxSup)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtPhoneSup)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtAddressSup)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCPSup)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbSupplier)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(877, 158)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendor :"
        '
        'txtEmailSup
        '
        Me.txtEmailSup.Enabled = False
        Me.txtEmailSup.Location = New System.Drawing.Point(382, 77)
        Me.txtEmailSup.Name = "txtEmailSup"
        Me.txtEmailSup.Size = New System.Drawing.Size(188, 20)
        Me.txtEmailSup.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Email"
        '
        'txtFaxSup
        '
        Me.txtFaxSup.Enabled = False
        Me.txtFaxSup.Location = New System.Drawing.Point(382, 54)
        Me.txtFaxSup.Name = "txtFaxSup"
        Me.txtFaxSup.Size = New System.Drawing.Size(188, 20)
        Me.txtFaxSup.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Fax"
        '
        'txtPhoneSup
        '
        Me.txtPhoneSup.Enabled = False
        Me.txtPhoneSup.Location = New System.Drawing.Point(382, 31)
        Me.txtPhoneSup.Name = "txtPhoneSup"
        Me.txtPhoneSup.Size = New System.Drawing.Size(188, 20)
        Me.txtPhoneSup.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Phone"
        '
        'txtAddressSup
        '
        Me.txtAddressSup.Enabled = False
        Me.txtAddressSup.Location = New System.Drawing.Point(98, 75)
        Me.txtAddressSup.Multiline = True
        Me.txtAddressSup.Name = "txtAddressSup"
        Me.txtAddressSup.Size = New System.Drawing.Size(188, 63)
        Me.txtAddressSup.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Adress"
        '
        'txtCPSup
        '
        Me.txtCPSup.Enabled = False
        Me.txtCPSup.Location = New System.Drawing.Point(98, 52)
        Me.txtCPSup.Name = "txtCPSup"
        Me.txtCPSup.Size = New System.Drawing.Size(188, 20)
        Me.txtCPSup.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Contact Person"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Supplier"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(98, 28)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(188, 21)
        Me.cmbSupplier.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(875, 346)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabProductName)
        Me.TabControl1.Controls.Add(Me.TabRemark)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(869, 326)
        Me.TabControl1.TabIndex = 0
        '
        'TabProductName
        '
        Me.TabProductName.Controls.Add(Me.txtStockAV)
        Me.TabProductName.Controls.Add(Me.Label17)
        Me.TabProductName.Controls.Add(Me.dgvrawmatrial)
        Me.TabProductName.Controls.Add(Me.cmbUnit)
        Me.TabProductName.Controls.Add(Me.Panel3)
        Me.TabProductName.Controls.Add(Me.cmbPINO)
        Me.TabProductName.Controls.Add(Me.Label32)
        Me.TabProductName.Controls.Add(Me.Label31)
        Me.TabProductName.Controls.Add(Me.Label30)
        Me.TabProductName.Controls.Add(Me.txtGrandTotal)
        Me.TabProductName.Controls.Add(Me.Label29)
        Me.TabProductName.Controls.Add(Me.txtSH)
        Me.TabProductName.Controls.Add(Me.txtOtherCost)
        Me.TabProductName.Controls.Add(Me.Label27)
        Me.TabProductName.Controls.Add(Me.txtVAT)
        Me.TabProductName.Controls.Add(Me.Label28)
        Me.TabProductName.Controls.Add(Me.txtDiscount)
        Me.TabProductName.Controls.Add(Me.btnYarnDelList)
        Me.TabProductName.Controls.Add(Me.btnYarnAddList)
        Me.TabProductName.Controls.Add(Me.Label25)
        Me.TabProductName.Controls.Add(Me.txtTotal)
        Me.TabProductName.Controls.Add(Me.txtSubtotal)
        Me.TabProductName.Controls.Add(Me.Label16)
        Me.TabProductName.Controls.Add(Me.txtQty)
        Me.TabProductName.Controls.Add(Me.Label26)
        Me.TabProductName.Controls.Add(Me.Label15)
        Me.TabProductName.Controls.Add(Me.txtUnitPrice)
        Me.TabProductName.Controls.Add(Me.Label14)
        Me.TabProductName.Controls.Add(Me.cmbYarnCode)
        Me.TabProductName.Controls.Add(Me.Label20)
        Me.TabProductName.Location = New System.Drawing.Point(4, 22)
        Me.TabProductName.Name = "TabProductName"
        Me.TabProductName.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductName.Size = New System.Drawing.Size(861, 300)
        Me.TabProductName.TabIndex = 0
        Me.TabProductName.Text = "Product Name / Description"
        Me.TabProductName.UseVisualStyleBackColor = True
        '
        'dgvrawmatrial
        '
        Me.dgvrawmatrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrawmatrial.Location = New System.Drawing.Point(12, 89)
        Me.dgvrawmatrial.Name = "dgvrawmatrial"
        Me.dgvrawmatrial.Size = New System.Drawing.Size(835, 79)
        Me.dgvrawmatrial.TabIndex = 138
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(370, 7)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(188, 21)
        Me.cmbUnit.TabIndex = 137
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnApprove)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnVoid)
        Me.Panel3.Location = New System.Drawing.Point(11, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 32)
        Me.Panel3.TabIndex = 136
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(410, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 130
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(5, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 127
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(86, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 128
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Enabled = False
        Me.btnApprove.Location = New System.Drawing.Point(248, 3)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 131
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(167, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 129
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Location = New System.Drawing.Point(329, 3)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 23)
        Me.btnVoid.TabIndex = 132
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(315, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 134
        Me.Label31.Text = "Unit"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(577, 277)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 13)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "Grand Total"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(677, 274)
        Me.txtGrandTotal.MaxLength = 50
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(170, 20)
        Me.txtGrandTotal.TabIndex = 125
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(577, 256)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 124
        Me.Label29.Text = "S && H"
        '
        'txtSH
        '
        Me.txtSH.Location = New System.Drawing.Point(677, 256)
        Me.txtSH.MaxLength = 50
        Me.txtSH.Name = "txtSH"
        Me.txtSH.Size = New System.Drawing.Size(170, 20)
        Me.txtSH.TabIndex = 123
        '
        'txtOtherCost
        '
        Me.txtOtherCost.Location = New System.Drawing.Point(677, 235)
        Me.txtOtherCost.MaxLength = 50
        Me.txtOtherCost.Name = "txtOtherCost"
        Me.txtOtherCost.Size = New System.Drawing.Size(170, 20)
        Me.txtOtherCost.TabIndex = 121
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(577, 235)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 13)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Other Cost"
        '
        'txtVAT
        '
        Me.txtVAT.Enabled = False
        Me.txtVAT.Location = New System.Drawing.Point(677, 215)
        Me.txtVAT.MaxLength = 50
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(170, 20)
        Me.txtVAT.TabIndex = 119
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(577, 215)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 13)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "VAT (10% Rate)"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(677, 194)
        Me.txtDiscount.MaxLength = 50
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(170, 20)
        Me.txtDiscount.TabIndex = 117
        '
        'btnYarnDelList
        '
        Me.btnYarnDelList.Location = New System.Drawing.Point(700, 60)
        Me.btnYarnDelList.Name = "btnYarnDelList"
        Me.btnYarnDelList.Size = New System.Drawing.Size(120, 23)
        Me.btnYarnDelList.TabIndex = 114
        Me.btnYarnDelList.Text = "Delete From List"
        Me.btnYarnDelList.UseVisualStyleBackColor = True
        '
        'btnYarnAddList
        '
        Me.btnYarnAddList.Location = New System.Drawing.Point(580, 60)
        Me.btnYarnAddList.Name = "btnYarnAddList"
        Me.btnYarnAddList.Size = New System.Drawing.Size(114, 23)
        Me.btnYarnAddList.TabIndex = 113
        Me.btnYarnAddList.Text = "Add To List"
        Me.btnYarnAddList.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(577, 197)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 118
        Me.Label25.Text = "Discount"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(632, 34)
        Me.txtTotal.MaxLength = 50
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(188, 20)
        Me.txtTotal.TabIndex = 110
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(677, 174)
        Me.txtSubtotal.MaxLength = 50
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(170, 20)
        Me.txtSubtotal.TabIndex = 115
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(577, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Total"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(632, 8)
        Me.txtQty.MaxLength = 50
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(188, 20)
        Me.txtQty.TabIndex = 108
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(577, 177)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 116
        Me.Label26.Text = "Subtotal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(574, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Quantity"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(370, 36)
        Me.txtUnitPrice.MaxLength = 50
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(188, 20)
        Me.txtUnitPrice.TabIndex = 106
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(312, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Unit Price"
        '
        'cmbYarnCode
        '
        Me.cmbYarnCode.FormattingEnabled = True
        Me.cmbYarnCode.Location = New System.Drawing.Point(118, 35)
        Me.cmbYarnCode.Name = "cmbYarnCode"
        Me.cmbYarnCode.Size = New System.Drawing.Size(188, 21)
        Me.cmbYarnCode.TabIndex = 102
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Yarn"
        '
        'TabRemark
        '
        Me.TabRemark.Controls.Add(Me.dgvRemarks)
        Me.TabRemark.Controls.Add(Me.btnRemDelList)
        Me.TabRemark.Controls.Add(Me.btnRemAddList)
        Me.TabRemark.Controls.Add(Me.txtRemarks)
        Me.TabRemark.Controls.Add(Me.Label67)
        Me.TabRemark.Location = New System.Drawing.Point(4, 22)
        Me.TabRemark.Name = "TabRemark"
        Me.TabRemark.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRemark.Size = New System.Drawing.Size(855, 300)
        Me.TabRemark.TabIndex = 1
        Me.TabRemark.Text = "Remarks"
        Me.TabRemark.UseVisualStyleBackColor = True
        '
        'dgvRemarks
        '
        Me.dgvRemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRemarks.Location = New System.Drawing.Point(8, 120)
        Me.dgvRemarks.Name = "dgvRemarks"
        Me.dgvRemarks.Size = New System.Drawing.Size(845, 97)
        Me.dgvRemarks.TabIndex = 113
        '
        'btnRemDelList
        '
        Me.btnRemDelList.Location = New System.Drawing.Point(168, 84)
        Me.btnRemDelList.Name = "btnRemDelList"
        Me.btnRemDelList.Size = New System.Drawing.Size(105, 23)
        Me.btnRemDelList.TabIndex = 111
        Me.btnRemDelList.Text = "Delete From List"
        Me.btnRemDelList.UseVisualStyleBackColor = True
        '
        'btnRemAddList
        '
        Me.btnRemAddList.Location = New System.Drawing.Point(58, 83)
        Me.btnRemAddList.Name = "btnRemAddList"
        Me.btnRemAddList.Size = New System.Drawing.Size(105, 23)
        Me.btnRemAddList.TabIndex = 110
        Me.btnRemAddList.Text = "Add To List"
        Me.btnRemAddList.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(58, 3)
        Me.txtRemarks.MaxLength = 300
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(353, 74)
        Me.txtRemarks.TabIndex = 109
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(6, 3)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(46, 13)
        Me.Label67.TabIndex = 112
        Me.Label67.Text = "Remaks"
        '
        'txtStockAV
        '
        Me.txtStockAV.Enabled = False
        Me.txtStockAV.Location = New System.Drawing.Point(118, 60)
        Me.txtStockAV.MaxLength = 50
        Me.txtStockAV.Name = "txtStockAV"
        Me.txtStockAV.Size = New System.Drawing.Size(188, 20)
        Me.txtStockAV.TabIndex = 139
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = " Available Stock"
        '
        'FrmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 642)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "22"
        Me.Text = "FrmPurchaseOrder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabProductName.ResumeLayout(False)
        Me.TabProductName.PerformLayout()
        CType(Me.dgvrawmatrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TabRemark.ResumeLayout(False)
        Me.TabRemark.PerformLayout()
        CType(Me.dgvRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtPODate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPONo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbTOP As ComboBox
    Friend WithEvents dtERD As DateTimePicker
    Friend WithEvents dtSD As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabProductName As TabPage
    Friend WithEvents TabRemark As TabPage
    Friend WithEvents cmbYarnCode As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnRemDelList As Button
    Friend WithEvents btnRemAddList As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnYarnDelList As Button
    Friend WithEvents btnYarnAddList As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents txtSH As TextBox
    Friend WithEvents txtOtherCost As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents dgvRemarks As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbSVM As ComboBox
    Friend WithEvents cmbPINO As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents txtEmailSup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFaxSup As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhoneSup As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddressSup As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCPSup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents dgvrawmatrial As DataGridView
    Friend WithEvents txtStockAV As TextBox
    Friend WithEvents Label17 As Label
End Class
