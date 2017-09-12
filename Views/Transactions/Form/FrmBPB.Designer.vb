<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBPB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBPB))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbPONo = New System.Windows.Forms.ComboBox()
        Me.btnRawAddList = New System.Windows.Forms.Button()
        Me.dtDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDocType = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDONO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtInFactory = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtBPBDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBPBNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabProductName = New System.Windows.Forms.TabPage()
        Me.cmbPI = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.txtQtyPO = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnRawDelList = New System.Windows.Forms.Button()
        Me.btnAddListBPB = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtQuantityPackaging = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtQtyReceived = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbRawCode = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabProductName.SuspendLayout()
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
        Me.Label3.Size = New System.Drawing.Size(843, 63)
        Me.Label3.TabIndex = 25
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbPONo)
        Me.Panel1.Controls.Add(Me.btnRawAddList)
        Me.Panel1.Controls.Add(Me.dtDocDate)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtDocNo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtDocType)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtDONO)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSupplier)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtInFactory)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtBPBDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBPBNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 150)
        Me.Panel1.TabIndex = 26
        '
        'cmbPONo
        '
        Me.cmbPONo.FormattingEnabled = True
        Me.cmbPONo.Location = New System.Drawing.Point(443, 97)
        Me.cmbPONo.Name = "cmbPONo"
        Me.cmbPONo.Size = New System.Drawing.Size(188, 21)
        Me.cmbPONo.TabIndex = 115
        '
        'btnRawAddList
        '
        Me.btnRawAddList.Location = New System.Drawing.Point(637, 123)
        Me.btnRawAddList.Name = "btnRawAddList"
        Me.btnRawAddList.Size = New System.Drawing.Size(93, 23)
        Me.btnRawAddList.TabIndex = 114
        Me.btnRawAddList.Text = "Show List"
        Me.btnRawAddList.UseVisualStyleBackColor = True
        '
        'dtDocDate
        '
        Me.dtDocDate.Location = New System.Drawing.Point(443, 71)
        Me.dtDocDate.Name = "dtDocDate"
        Me.dtDocDate.Size = New System.Drawing.Size(188, 20)
        Me.dtDocDate.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(322, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Doc.Registration Date"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(443, 45)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(188, 20)
        Me.txtDocNo.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Doc.No Customs"
        '
        'txtDocType
        '
        Me.txtDocType.Location = New System.Drawing.Point(443, 15)
        Me.txtDocType.Name = "txtDocType"
        Me.txtDocType.Size = New System.Drawing.Size(188, 20)
        Me.txtDocType.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Doc.Type Customs"
        '
        'txtDONO
        '
        Me.txtDONO.Location = New System.Drawing.Point(128, 92)
        Me.txtDONO.Name = "txtDONO"
        Me.txtDONO.Size = New System.Drawing.Size(188, 20)
        Me.txtDONO.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "DO.No"
        '
        'txtSupplier
        '
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Location = New System.Drawing.Point(443, 124)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(188, 20)
        Me.txtSupplier.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Supplier Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "In Factory Date"
        '
        'dtInFactory
        '
        Me.dtInFactory.Location = New System.Drawing.Point(128, 65)
        Me.dtInFactory.Name = "dtInFactory"
        Me.dtInFactory.Size = New System.Drawing.Size(188, 20)
        Me.dtInFactory.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PO.No"
        '
        'dtBPBDate
        '
        Me.dtBPBDate.Enabled = False
        Me.dtBPBDate.Location = New System.Drawing.Point(128, 39)
        Me.dtBPBDate.Name = "dtBPBDate"
        Me.dtBPBDate.Size = New System.Drawing.Size(188, 20)
        Me.dtBPBDate.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "BPB Date"
        '
        'txtBPBNo
        '
        Me.txtBPBNo.Enabled = False
        Me.txtBPBNo.Location = New System.Drawing.Point(128, 13)
        Me.txtBPBNo.Name = "txtBPBNo"
        Me.txtBPBNo.Size = New System.Drawing.Size(188, 20)
        Me.txtBPBNo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BPB.No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(843, 374)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabProductName)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(837, 326)
        Me.TabControl1.TabIndex = 0
        '
        'TabProductName
        '
        Me.TabProductName.Controls.Add(Me.cmbPI)
        Me.TabProductName.Controls.Add(Me.Label11)
        Me.TabProductName.Controls.Add(Me.cmbUnit)
        Me.TabProductName.Controls.Add(Me.txtQtyPO)
        Me.TabProductName.Controls.Add(Me.Panel3)
        Me.TabProductName.Controls.Add(Me.Label31)
        Me.TabProductName.Controls.Add(Me.btnRawDelList)
        Me.TabProductName.Controls.Add(Me.btnAddListBPB)
        Me.TabProductName.Controls.Add(Me.dgv)
        Me.TabProductName.Controls.Add(Me.txtQuantityPackaging)
        Me.TabProductName.Controls.Add(Me.Label16)
        Me.TabProductName.Controls.Add(Me.txtQtyReceived)
        Me.TabProductName.Controls.Add(Me.Label15)
        Me.TabProductName.Controls.Add(Me.Label14)
        Me.TabProductName.Controls.Add(Me.cmbRawCode)
        Me.TabProductName.Controls.Add(Me.Label20)
        Me.TabProductName.Location = New System.Drawing.Point(4, 22)
        Me.TabProductName.Name = "TabProductName"
        Me.TabProductName.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductName.Size = New System.Drawing.Size(829, 300)
        Me.TabProductName.TabIndex = 0
        Me.TabProductName.Text = "Produk Name"
        Me.TabProductName.UseVisualStyleBackColor = True
        '
        'cmbPI
        '
        Me.cmbPI.Enabled = False
        Me.cmbPI.FormattingEnabled = True
        Me.cmbPI.Location = New System.Drawing.Point(121, 12)
        Me.cmbPI.Name = "cmbPI"
        Me.cmbPI.Size = New System.Drawing.Size(188, 21)
        Me.cmbPI.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "PI No"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(421, 62)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(188, 21)
        Me.cmbUnit.TabIndex = 138
        '
        'txtQtyPO
        '
        Me.txtQtyPO.Enabled = False
        Me.txtQtyPO.Location = New System.Drawing.Point(121, 62)
        Me.txtQtyPO.MaxLength = 50
        Me.txtQtyPO.Name = "txtQtyPO"
        Me.txtQtyPO.Size = New System.Drawing.Size(188, 20)
        Me.txtQtyPO.TabIndex = 137
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnApprove)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnVoid)
        Me.Panel3.Location = New System.Drawing.Point(6, 262)
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
        Me.Label31.Location = New System.Drawing.Point(315, 69)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 13)
        Me.Label31.TabIndex = 134
        Me.Label31.Text = "Unit Packaging"
        '
        'btnRawDelList
        '
        Me.btnRawDelList.Location = New System.Drawing.Point(727, 64)
        Me.btnRawDelList.Name = "btnRawDelList"
        Me.btnRawDelList.Size = New System.Drawing.Size(95, 23)
        Me.btnRawDelList.TabIndex = 114
        Me.btnRawDelList.Text = "Delete From List"
        Me.btnRawDelList.UseVisualStyleBackColor = True
        '
        'btnAddListBPB
        '
        Me.btnAddListBPB.Location = New System.Drawing.Point(626, 64)
        Me.btnAddListBPB.Name = "btnAddListBPB"
        Me.btnAddListBPB.Size = New System.Drawing.Size(95, 23)
        Me.btnAddListBPB.TabIndex = 113
        Me.btnAddListBPB.Text = "Add To List"
        Me.btnAddListBPB.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv.Location = New System.Drawing.Point(10, 89)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(812, 155)
        Me.dgv.TabIndex = 112
        '
        'txtQuantityPackaging
        '
        Me.txtQuantityPackaging.Location = New System.Drawing.Point(421, 36)
        Me.txtQuantityPackaging.MaxLength = 50
        Me.txtQuantityPackaging.Name = "txtQuantityPackaging"
        Me.txtQuantityPackaging.Size = New System.Drawing.Size(188, 20)
        Me.txtQuantityPackaging.TabIndex = 110
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(315, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Quantity Packaging"
        '
        'txtQtyReceived
        '
        Me.txtQtyReceived.Location = New System.Drawing.Point(421, 12)
        Me.txtQtyReceived.MaxLength = 50
        Me.txtQtyReceived.Name = "txtQtyReceived"
        Me.txtQtyReceived.Size = New System.Drawing.Size(188, 20)
        Me.txtQtyReceived.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(315, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Quantity Received"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Quantity PO"
        '
        'cmbRawCode
        '
        Me.cmbRawCode.FormattingEnabled = True
        Me.cmbRawCode.Location = New System.Drawing.Point(121, 36)
        Me.cmbRawCode.Name = "cmbRawCode"
        Me.cmbRawCode.Size = New System.Drawing.Size(188, 21)
        Me.cmbRawCode.TabIndex = 102
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Raw Material Name"
        '
        'FrmBPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 584)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBPB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "26"
        Me.Text = "FrmBPB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabProductName.ResumeLayout(False)
        Me.TabProductName.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dtBPBDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBPBNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtInFactory As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtDocDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDocType As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDONO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRawAddList As Button
    Friend WithEvents cmbPONo As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabProductName As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtSH As TextBox
    Friend WithEvents txtOtherCost As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents btnRawDelList As Button
    Friend WithEvents btnAddListBPB As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtQuantityPackaging As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtQtyReceived As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbRawCode As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtQtyPO As TextBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents cmbPI As ComboBox
    Friend WithEvents Label11 As Label
End Class
