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
        Me.txtShipViaMethode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtEmailCust = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.txtFaxCust = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCPCust = New System.Windows.Forms.TextBox()
        Me.txtPhoneCust = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAdressCust = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
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
        Me.btnRawDelList = New System.Windows.Forms.Button()
        Me.btnRawAddList = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dgvrawmatrial = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbRawCode = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabRemark = New System.Windows.Forms.TabPage()
        Me.dgvRemarks = New System.Windows.Forms.DataGridView()
        Me.btnRemDelList = New System.Windows.Forms.Button()
        Me.btnRemAddList = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabProductName.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvrawmatrial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Size = New System.Drawing.Size(880, 43)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Purchase Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.txtShipViaMethode)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(880, 76)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'dtERD
        '
        Me.dtERD.Location = New System.Drawing.Point(688, 40)
        Me.dtERD.Name = "dtERD"
        Me.dtERD.Size = New System.Drawing.Size(188, 20)
        Me.dtERD.TabIndex = 33
        '
        'dtSD
        '
        Me.dtSD.Location = New System.Drawing.Point(373, 42)
        Me.dtSD.Name = "dtSD"
        Me.dtSD.Size = New System.Drawing.Size(188, 20)
        Me.dtSD.TabIndex = 32
        '
        'cmbTOP
        '
        Me.cmbTOP.FormattingEnabled = True
        Me.cmbTOP.Location = New System.Drawing.Point(688, 13)
        Me.cmbTOP.Name = "cmbTOP"
        Me.cmbTOP.Size = New System.Drawing.Size(188, 21)
        Me.cmbTOP.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(567, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Expected Receipt Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(567, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Term Of Payment"
        '
        'dtPODate
        '
        Me.dtPODate.Location = New System.Drawing.Point(70, 42)
        Me.dtPODate.Name = "dtPODate"
        Me.dtPODate.Size = New System.Drawing.Size(188, 20)
        Me.dtPODate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PO Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Shipping Date"
        '
        'txtPONo
        '
        Me.txtPONo.Enabled = False
        Me.txtPONo.Location = New System.Drawing.Point(70, 15)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(188, 20)
        Me.txtPONo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PO No"
        '
        'txtShipViaMethode
        '
        Me.txtShipViaMethode.Location = New System.Drawing.Point(373, 16)
        Me.txtShipViaMethode.Name = "txtShipViaMethode"
        Me.txtShipViaMethode.Size = New System.Drawing.Size(188, 20)
        Me.txtShipViaMethode.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Ship Via/Method"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(880, 233)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendor :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Panel2)
        Me.GroupBox4.Location = New System.Drawing.Point(432, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(442, 227)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ship To :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtEmailCust)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cmbCustomer)
        Me.Panel2.Controls.Add(Me.txtFaxCust)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txtCPCust)
        Me.Panel2.Controls.Add(Me.txtPhoneCust)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtAdressCust)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 207)
        Me.Panel2.TabIndex = 35
        '
        'txtEmailCust
        '
        Me.txtEmailCust.Enabled = False
        Me.txtEmailCust.Location = New System.Drawing.Point(103, 181)
        Me.txtEmailCust.Name = "txtEmailCust"
        Me.txtEmailCust.Size = New System.Drawing.Size(188, 20)
        Me.txtEmailCust.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Customer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Email"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(103, 10)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(188, 21)
        Me.cmbCustomer.TabIndex = 35
        '
        'txtFaxCust
        '
        Me.txtFaxCust.Enabled = False
        Me.txtFaxCust.Location = New System.Drawing.Point(103, 155)
        Me.txtFaxCust.Name = "txtFaxCust"
        Me.txtFaxCust.Size = New System.Drawing.Size(188, 20)
        Me.txtFaxCust.TabIndex = 44
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(17, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Contact Person"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Fax"
        '
        'txtCPCust
        '
        Me.txtCPCust.Enabled = False
        Me.txtCPCust.Location = New System.Drawing.Point(103, 37)
        Me.txtCPCust.Name = "txtCPCust"
        Me.txtCPCust.Size = New System.Drawing.Size(188, 20)
        Me.txtCPCust.TabIndex = 38
        '
        'txtPhoneCust
        '
        Me.txtPhoneCust.Enabled = False
        Me.txtPhoneCust.Location = New System.Drawing.Point(103, 132)
        Me.txtPhoneCust.Name = "txtPhoneCust"
        Me.txtPhoneCust.Size = New System.Drawing.Size(188, 20)
        Me.txtPhoneCust.TabIndex = 42
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Adress"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Phone"
        '
        'txtAdressCust
        '
        Me.txtAdressCust.Enabled = False
        Me.txtAdressCust.Location = New System.Drawing.Point(103, 63)
        Me.txtAdressCust.Multiline = True
        Me.txtAdressCust.Name = "txtAdressCust"
        Me.txtAdressCust.Size = New System.Drawing.Size(188, 63)
        Me.txtAdressCust.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtEmailSup)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtFaxSup)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtPhoneSup)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAddressSup)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCPSup)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbSupplier)
        Me.Panel1.Location = New System.Drawing.Point(9, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 204)
        Me.Panel1.TabIndex = 0
        '
        'txtEmailSup
        '
        Me.txtEmailSup.Enabled = False
        Me.txtEmailSup.Location = New System.Drawing.Point(89, 178)
        Me.txtEmailSup.Name = "txtEmailSup"
        Me.txtEmailSup.Size = New System.Drawing.Size(188, 20)
        Me.txtEmailSup.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Email"
        '
        'txtFaxSup
        '
        Me.txtFaxSup.Enabled = False
        Me.txtFaxSup.Location = New System.Drawing.Point(89, 152)
        Me.txtFaxSup.Name = "txtFaxSup"
        Me.txtFaxSup.Size = New System.Drawing.Size(188, 20)
        Me.txtFaxSup.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Fax"
        '
        'txtPhoneSup
        '
        Me.txtPhoneSup.Enabled = False
        Me.txtPhoneSup.Location = New System.Drawing.Point(89, 128)
        Me.txtPhoneSup.Name = "txtPhoneSup"
        Me.txtPhoneSup.Size = New System.Drawing.Size(188, 20)
        Me.txtPhoneSup.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Phone"
        '
        'txtAddressSup
        '
        Me.txtAddressSup.Enabled = False
        Me.txtAddressSup.Location = New System.Drawing.Point(89, 60)
        Me.txtAddressSup.Multiline = True
        Me.txtAddressSup.Name = "txtAddressSup"
        Me.txtAddressSup.Size = New System.Drawing.Size(188, 63)
        Me.txtAddressSup.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Adress"
        '
        'txtCPSup
        '
        Me.txtCPSup.Enabled = False
        Me.txtCPSup.Location = New System.Drawing.Point(89, 34)
        Me.txtCPSup.Name = "txtCPSup"
        Me.txtCPSup.Size = New System.Drawing.Size(188, 20)
        Me.txtCPSup.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Contact Person"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Supplier"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(89, 7)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(188, 21)
        Me.cmbSupplier.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 353)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(882, 355)
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
        Me.TabControl1.Size = New System.Drawing.Size(876, 339)
        Me.TabControl1.TabIndex = 0
        '
        'TabProductName
        '
        Me.TabProductName.Controls.Add(Me.cmbCurrency)
        Me.TabProductName.Controls.Add(Me.Label21)
        Me.TabProductName.Controls.Add(Me.Panel3)
        Me.TabProductName.Controls.Add(Me.cmbUnit)
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
        Me.TabProductName.Controls.Add(Me.btnRawDelList)
        Me.TabProductName.Controls.Add(Me.btnRawAddList)
        Me.TabProductName.Controls.Add(Me.Label25)
        Me.TabProductName.Controls.Add(Me.dgvrawmatrial)
        Me.TabProductName.Controls.Add(Me.txtTotal)
        Me.TabProductName.Controls.Add(Me.txtSubtotal)
        Me.TabProductName.Controls.Add(Me.Label16)
        Me.TabProductName.Controls.Add(Me.txtQty)
        Me.TabProductName.Controls.Add(Me.Label26)
        Me.TabProductName.Controls.Add(Me.Label15)
        Me.TabProductName.Controls.Add(Me.txtUnitPrice)
        Me.TabProductName.Controls.Add(Me.Label14)
        Me.TabProductName.Controls.Add(Me.cmbRawCode)
        Me.TabProductName.Controls.Add(Me.Label20)
        Me.TabProductName.Location = New System.Drawing.Point(4, 22)
        Me.TabProductName.Name = "TabProductName"
        Me.TabProductName.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductName.Size = New System.Drawing.Size(868, 313)
        Me.TabProductName.TabIndex = 0
        Me.TabProductName.Text = "Produk Name"
        Me.TabProductName.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(303, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 138
        Me.Label21.Text = "Currency"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnApprove)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnVoid)
        Me.Panel3.Location = New System.Drawing.Point(10, 170)
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
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(110, 32)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(188, 21)
        Me.cmbUnit.TabIndex = 135
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 134
        Me.Label31.Text = "Unit"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(564, 282)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 13)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "Grand Total"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(667, 282)
        Me.txtGrandTotal.MaxLength = 50
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(188, 20)
        Me.txtGrandTotal.TabIndex = 125
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(564, 261)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 124
        Me.Label29.Text = "S && H"
        '
        'txtSH
        '
        Me.txtSH.Location = New System.Drawing.Point(667, 258)
        Me.txtSH.MaxLength = 50
        Me.txtSH.Name = "txtSH"
        Me.txtSH.Size = New System.Drawing.Size(188, 20)
        Me.txtSH.TabIndex = 123
        '
        'txtOtherCost
        '
        Me.txtOtherCost.Location = New System.Drawing.Point(667, 235)
        Me.txtOtherCost.MaxLength = 50
        Me.txtOtherCost.Name = "txtOtherCost"
        Me.txtOtherCost.Size = New System.Drawing.Size(188, 20)
        Me.txtOtherCost.TabIndex = 121
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(564, 238)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 13)
        Me.Label27.TabIndex = 122
        Me.Label27.Text = "Other Cost"
        '
        'txtVAT
        '
        Me.txtVAT.Enabled = False
        Me.txtVAT.Location = New System.Drawing.Point(667, 212)
        Me.txtVAT.MaxLength = 50
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(188, 20)
        Me.txtVAT.TabIndex = 119
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(564, 215)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 13)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "VAT (10% Rate)"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(667, 190)
        Me.txtDiscount.MaxLength = 50
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(188, 20)
        Me.txtDiscount.TabIndex = 117
        '
        'btnRawDelList
        '
        Me.btnRawDelList.Location = New System.Drawing.Point(693, 57)
        Me.btnRawDelList.Name = "btnRawDelList"
        Me.btnRawDelList.Size = New System.Drawing.Size(120, 23)
        Me.btnRawDelList.TabIndex = 114
        Me.btnRawDelList.Text = "Delete From List"
        Me.btnRawDelList.UseVisualStyleBackColor = True
        '
        'btnRawAddList
        '
        Me.btnRawAddList.Location = New System.Drawing.Point(573, 57)
        Me.btnRawAddList.Name = "btnRawAddList"
        Me.btnRawAddList.Size = New System.Drawing.Size(114, 23)
        Me.btnRawAddList.TabIndex = 113
        Me.btnRawAddList.Text = "Add To List"
        Me.btnRawAddList.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(564, 190)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 118
        Me.Label25.Text = "Discount"
        '
        'dgvrawmatrial
        '
        Me.dgvrawmatrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrawmatrial.Location = New System.Drawing.Point(10, 85)
        Me.dgvrawmatrial.Name = "dgvrawmatrial"
        Me.dgvrawmatrial.Size = New System.Drawing.Size(845, 79)
        Me.dgvrawmatrial.TabIndex = 112
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(625, 31)
        Me.txtTotal.MaxLength = 50
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(188, 20)
        Me.txtTotal.TabIndex = 110
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(667, 167)
        Me.txtSubtotal.MaxLength = 50
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(188, 20)
        Me.txtSubtotal.TabIndex = 115
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(570, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Total"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(625, 5)
        Me.txtQty.MaxLength = 50
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(188, 20)
        Me.txtQty.TabIndex = 108
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(564, 167)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 116
        Me.Label26.Text = "Subtotal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(567, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Quantity"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(362, 7)
        Me.txtUnitPrice.MaxLength = 50
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(188, 20)
        Me.txtUnitPrice.TabIndex = 106
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(304, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Unit Price"
        '
        'cmbRawCode
        '
        Me.cmbRawCode.FormattingEnabled = True
        Me.cmbRawCode.Location = New System.Drawing.Point(110, 6)
        Me.cmbRawCode.Name = "cmbRawCode"
        Me.cmbRawCode.Size = New System.Drawing.Size(188, 21)
        Me.cmbRawCode.TabIndex = 102
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Raw Material Code"
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
        Me.TabRemark.Size = New System.Drawing.Size(868, 313)
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
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(362, 32)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(188, 21)
        Me.cmbCurrency.TabIndex = 139
        '
        'FrmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 700)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "22"
        Me.Text = "FrmPurchaseOrder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabProductName.ResumeLayout(False)
        Me.TabProductName.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvrawmatrial, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents txtCPSup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddressSup As TextBox
    Friend WithEvents txtEmailSup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFaxSup As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhoneSup As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtShipViaMethode As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbTOP As ComboBox
    Friend WithEvents dtERD As DateTimePicker
    Friend WithEvents dtSD As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabProductName As TabPage
    Friend WithEvents TabRemark As TabPage
    Friend WithEvents cmbRawCode As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnRemDelList As Button
    Friend WithEvents btnRemAddList As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvrawmatrial As DataGridView
    Friend WithEvents btnRawDelList As Button
    Friend WithEvents btnRawAddList As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtEmailCust As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents txtFaxCust As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCPCust As TextBox
    Friend WithEvents txtPhoneCust As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtAdressCust As TextBox
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
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbCurrency As ComboBox
End Class
