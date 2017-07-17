<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProformaInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProformaInvoice))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnCarCust = New System.Windows.Forms.Button()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtContract = New System.Windows.Forms.TextBox()
        Me.cmbSeason = New System.Windows.Forms.ComboBox()
        Me.btnCarBuy = New System.Windows.Forms.Button()
        Me.txtDelPlace = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbFM = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAttention = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTlp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbTermPrice = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtDelTerm = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbTOP = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRefPO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuyer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtPIDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPINo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFabric = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCarFab = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbCurr = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtQtyWeight = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtQtyCutt = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPPSample = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtDateDetail = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotQty = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1048, 46)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Proforma Invoice"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.btnCarCust)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.txtContract)
        Me.Panel1.Controls.Add(Me.cmbSeason)
        Me.Panel1.Controls.Add(Me.btnCarBuy)
        Me.Panel1.Controls.Add(Me.txtDelPlace)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.cmbFM)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtAttention)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtFax)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtTlp)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbPort)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmbTermPrice)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtDelTerm)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbTOP)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtStyle)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtRefPO)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtBuyer)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtPIDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPINo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 228)
        Me.Panel1.TabIndex = 24
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(379, 121)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Address"
        '
        'btnCarCust
        '
        Me.btnCarCust.Location = New System.Drawing.Point(662, 93)
        Me.btnCarCust.Name = "btnCarCust"
        Me.btnCarCust.Size = New System.Drawing.Size(27, 20)
        Me.btnCarCust.TabIndex = 58
        Me.btnCarCust.Text = "..."
        Me.btnCarCust.UseVisualStyleBackColor = True
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(457, 93)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(199, 20)
        Me.txtTo.TabIndex = 12
        '
        'txtContract
        '
        Me.txtContract.Location = New System.Drawing.Point(457, 39)
        Me.txtContract.MaxLength = 50
        Me.txtContract.Name = "txtContract"
        Me.txtContract.Size = New System.Drawing.Size(232, 20)
        Me.txtContract.TabIndex = 10
        '
        'cmbSeason
        '
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Location = New System.Drawing.Point(106, 142)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(232, 21)
        Me.cmbSeason.TabIndex = 6
        '
        'btnCarBuy
        '
        Me.btnCarBuy.Location = New System.Drawing.Point(344, 65)
        Me.btnCarBuy.Name = "btnCarBuy"
        Me.btnCarBuy.Size = New System.Drawing.Size(27, 20)
        Me.btnCarBuy.TabIndex = 56
        Me.btnCarBuy.Text = "..."
        Me.btnCarBuy.UseVisualStyleBackColor = True
        '
        'txtDelPlace
        '
        Me.txtDelPlace.Location = New System.Drawing.Point(803, 121)
        Me.txtDelPlace.MaxLength = 255
        Me.txtDelPlace.Multiline = True
        Me.txtDelPlace.Name = "txtDelPlace"
        Me.txtDelPlace.Size = New System.Drawing.Size(232, 70)
        Me.txtDelPlace.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(722, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Delivery Place"
        '
        'cmbFM
        '
        Me.cmbFM.FormattingEnabled = True
        Me.cmbFM.Location = New System.Drawing.Point(803, 91)
        Me.cmbFM.Name = "cmbFM"
        Me.cmbFM.Size = New System.Drawing.Size(232, 21)
        Me.cmbFM.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(722, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "FM"
        '
        'txtAttention
        '
        Me.txtAttention.Enabled = False
        Me.txtAttention.Location = New System.Drawing.Point(803, 65)
        Me.txtAttention.Name = "txtAttention"
        Me.txtAttention.Size = New System.Drawing.Size(232, 20)
        Me.txtAttention.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(722, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Attention"
        '
        'txtFax
        '
        Me.txtFax.Enabled = False
        Me.txtFax.Location = New System.Drawing.Point(803, 39)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(232, 20)
        Me.txtFax.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(722, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Fax"
        '
        'txtTlp
        '
        Me.txtTlp.Enabled = False
        Me.txtTlp.Location = New System.Drawing.Point(803, 13)
        Me.txtTlp.Name = "txtTlp"
        Me.txtTlp.Size = New System.Drawing.Size(232, 20)
        Me.txtTlp.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(722, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Telp"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(457, 124)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(232, 70)
        Me.txtAddress.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(379, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "To"
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(457, 66)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(232, 21)
        Me.cmbPort.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(379, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Discharge Port"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(379, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Contract No"
        '
        'cmbTermPrice
        '
        Me.cmbTermPrice.FormattingEnabled = True
        Me.cmbTermPrice.Location = New System.Drawing.Point(457, 12)
        Me.cmbTermPrice.Name = "cmbTermPrice"
        Me.cmbTermPrice.Size = New System.Drawing.Size(232, 21)
        Me.cmbTermPrice.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(379, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Term Of Price"
        '
        'dtDelTerm
        '
        Me.dtDelTerm.Location = New System.Drawing.Point(106, 196)
        Me.dtDelTerm.Name = "dtDelTerm"
        Me.dtDelTerm.Size = New System.Drawing.Size(232, 20)
        Me.dtDelTerm.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Del Term"
        '
        'cmbTOP
        '
        Me.cmbTOP.FormattingEnabled = True
        Me.cmbTOP.Location = New System.Drawing.Point(106, 169)
        Me.cmbTOP.Name = "cmbTOP"
        Me.cmbTOP.Size = New System.Drawing.Size(232, 21)
        Me.cmbTOP.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Term Of Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Season"
        '
        'txtStyle
        '
        Me.txtStyle.Location = New System.Drawing.Point(106, 117)
        Me.txtStyle.MaxLength = 100
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.Size = New System.Drawing.Size(232, 20)
        Me.txtStyle.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Style"
        '
        'txtRefPO
        '
        Me.txtRefPO.Location = New System.Drawing.Point(106, 91)
        Me.txtRefPO.MaxLength = 50
        Me.txtRefPO.Name = "txtRefPO"
        Me.txtRefPO.Size = New System.Drawing.Size(232, 20)
        Me.txtRefPO.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Ref PO"
        '
        'txtBuyer
        '
        Me.txtBuyer.Location = New System.Drawing.Point(106, 65)
        Me.txtBuyer.Name = "txtBuyer"
        Me.txtBuyer.Size = New System.Drawing.Size(232, 20)
        Me.txtBuyer.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Buyer"
        '
        'dtPIDate
        '
        Me.dtPIDate.Location = New System.Drawing.Point(106, 39)
        Me.dtPIDate.Name = "dtPIDate"
        Me.dtPIDate.Size = New System.Drawing.Size(232, 20)
        Me.dtPIDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PI Date"
        '
        'txtPINo
        '
        Me.txtPINo.Enabled = False
        Me.txtPINo.Location = New System.Drawing.Point(106, 13)
        Me.txtPINo.Name = "txtPINo"
        Me.txtPINo.Size = New System.Drawing.Size(232, 20)
        Me.txtPINo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PI No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Fabric"
        '
        'txtFabric
        '
        Me.txtFabric.Location = New System.Drawing.Point(106, 15)
        Me.txtFabric.Name = "txtFabric"
        Me.txtFabric.Size = New System.Drawing.Size(232, 20)
        Me.txtFabric.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "Color"
        '
        'cmbColor
        '
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(106, 67)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(232, 21)
        Me.cmbColor.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnCarFab)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.txtQty)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.cmbCurr)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.cmbUnit)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.txtQtyWeight)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.txtQtyCutt)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.txtPPSample)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.dtDateDetail)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.cmbColor)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.txtFabric)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1048, 153)
        Me.Panel2.TabIndex = 25
        '
        'btnCarFab
        '
        Me.btnCarFab.Location = New System.Drawing.Point(344, 15)
        Me.btnCarFab.Name = "btnCarFab"
        Me.btnCarFab.Size = New System.Drawing.Size(27, 20)
        Me.btnCarFab.TabIndex = 59
        Me.btnCarFab.Text = "..."
        Me.btnCarFab.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(857, 120)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(48, 23)
        Me.btnDel.TabIndex = 30
        Me.btnDel.Text = "DEL"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(803, 120)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(48, 23)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(803, 94)
        Me.txtQty.MaxLength = 12
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(232, 20)
        Me.txtQty.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(745, 97)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(23, 13)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "Qty"
        '
        'cmbCurr
        '
        Me.cmbCurr.FormattingEnabled = True
        Me.cmbCurr.Location = New System.Drawing.Point(803, 41)
        Me.cmbCurr.Name = "cmbCurr"
        Me.cmbCurr.Size = New System.Drawing.Size(232, 21)
        Me.cmbCurr.TabIndex = 26
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(745, 44)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Currency"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(803, 14)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(232, 21)
        Me.cmbUnit.TabIndex = 25
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(745, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 13)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Unit"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(803, 68)
        Me.txtPrice.MaxLength = 12
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(232, 20)
        Me.txtPrice.TabIndex = 27
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(745, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Unit Price"
        '
        'txtQtyWeight
        '
        Me.txtQtyWeight.Location = New System.Drawing.Point(484, 69)
        Me.txtQtyWeight.MaxLength = 12
        Me.txtQtyWeight.Name = "txtQtyWeight"
        Me.txtQtyWeight.Size = New System.Drawing.Size(232, 20)
        Me.txtQtyWeight.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(389, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 13)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Qty Weight"
        '
        'txtQtyCutt
        '
        Me.txtQtyCutt.Location = New System.Drawing.Point(484, 43)
        Me.txtQtyCutt.MaxLength = 12
        Me.txtQtyCutt.Name = "txtQtyCutt"
        Me.txtQtyCutt.Size = New System.Drawing.Size(232, 20)
        Me.txtQtyCutt.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(389, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "Qty Cuttable"
        '
        'txtPPSample
        '
        Me.txtPPSample.Location = New System.Drawing.Point(484, 17)
        Me.txtPPSample.MaxLength = 50
        Me.txtPPSample.Name = "txtPPSample"
        Me.txtPPSample.Size = New System.Drawing.Size(232, 20)
        Me.txtPPSample.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(389, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "PP Sample"
        '
        'dtDateDetail
        '
        Me.dtDateDetail.Location = New System.Drawing.Point(106, 41)
        Me.dtDateDetail.Name = "dtDateDetail"
        Me.dtDateDetail.Size = New System.Drawing.Size(232, 20)
        Me.dtDateDetail.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Date Detail"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnPreview)
        Me.Panel3.Controls.Add(Me.txtGrandTotal)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.txtTotQty)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 427)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1048, 75)
        Me.Panel3.TabIndex = 26
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(803, 35)
        Me.txtGrandTotal.MaxLength = 12
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(232, 20)
        Me.txtGrandTotal.TabIndex = 72
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(722, 38)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 13)
        Me.Label31.TabIndex = 73
        Me.Label31.Text = "Grand Total"
        '
        'txtTotQty
        '
        Me.txtTotQty.Enabled = False
        Me.txtTotQty.Location = New System.Drawing.Point(803, 9)
        Me.txtTotQty.MaxLength = 12
        Me.txtTotQty.Name = "txtTotQty"
        Me.txtTotQty.Size = New System.Drawing.Size(232, 20)
        Me.txtTotQty.TabIndex = 70
        Me.txtTotQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(722, 12)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 13)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "Total Qty"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 45)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(92, 45)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(11, 45)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 502)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1048, 231)
        Me.dgv.TabIndex = 34
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(254, 45)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 74
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'FrmProformaInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 733)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProformaInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProformaInvoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPINo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtPIDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStyle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRefPO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBuyer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTOP As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbFM As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtAttention As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTlp As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbPort As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbTermPrice As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtDelTerm As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFabric As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPPSample As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents dtDateDetail As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtQtyWeight As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtQtyCutt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents cmbCurr As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtContract As TextBox
    Friend WithEvents cmbSeason As ComboBox
    Friend WithEvents btnCarBuy As Button
    Friend WithEvents txtDelPlace As TextBox
    Friend WithEvents btnCarFab As Button
    Friend WithEvents btnCarCust As Button
    Friend WithEvents txtTo As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtTotQty As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents btnPreview As Button
End Class
