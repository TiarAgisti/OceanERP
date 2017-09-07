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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cmbPONo = New System.Windows.Forms.ComboBox()
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
        Me.Label3.Size = New System.Drawing.Size(943, 63)
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
        Me.Panel1.Size = New System.Drawing.Size(943, 150)
        Me.Panel1.TabIndex = 26
        '
        'btnRawAddList
        '
        Me.btnRawAddList.Location = New System.Drawing.Point(638, 114)
        Me.btnRawAddList.Name = "btnRawAddList"
        Me.btnRawAddList.Size = New System.Drawing.Size(114, 23)
        Me.btnRawAddList.TabIndex = 114
        Me.btnRawAddList.Text = "Add List"
        Me.btnRawAddList.UseVisualStyleBackColor = True
        '
        'dtDocDate
        '
        Me.dtDocDate.Location = New System.Drawing.Point(426, 117)
        Me.dtDocDate.Name = "dtDocDate"
        Me.dtDocDate.Size = New System.Drawing.Size(188, 20)
        Me.dtDocDate.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(305, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Doc.Registration Date"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(426, 91)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(188, 20)
        Me.txtDocNo.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Doc.No Customs"
        '
        'txtDocType
        '
        Me.txtDocType.Location = New System.Drawing.Point(426, 65)
        Me.txtDocType.Name = "txtDocType"
        Me.txtDocType.Size = New System.Drawing.Size(188, 20)
        Me.txtDocType.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Doc.Type Customs"
        '
        'txtDONO
        '
        Me.txtDONO.Location = New System.Drawing.Point(426, 39)
        Me.txtDONO.Name = "txtDONO"
        Me.txtDONO.Size = New System.Drawing.Size(188, 20)
        Me.txtDONO.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "DO.No"
        '
        'txtSupplier
        '
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Location = New System.Drawing.Point(96, 91)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(188, 20)
        Me.txtSupplier.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Supplier Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "In Factory Date"
        '
        'dtInFactory
        '
        Me.dtInFactory.Location = New System.Drawing.Point(426, 12)
        Me.dtInFactory.Name = "dtInFactory"
        Me.dtInFactory.Size = New System.Drawing.Size(188, 20)
        Me.dtInFactory.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PO.No"
        '
        'dtBPBDate
        '
        Me.dtBPBDate.Enabled = False
        Me.dtBPBDate.Location = New System.Drawing.Point(96, 39)
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
        Me.txtBPBNo.Location = New System.Drawing.Point(96, 12)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.dgv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(943, 203)
        Me.Panel2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnApprove)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnVoid)
        Me.Panel3.Location = New System.Drawing.Point(5, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 32)
        Me.Panel3.TabIndex = 137
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
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(943, 138)
        Me.dgv.TabIndex = 113
        '
        'cmbPONo
        '
        Me.cmbPONo.FormattingEnabled = True
        Me.cmbPONo.Location = New System.Drawing.Point(96, 64)
        Me.cmbPONo.Name = "cmbPONo"
        Me.cmbPONo.Size = New System.Drawing.Size(188, 21)
        Me.cmbPONo.TabIndex = 115
        '
        'FrmBPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 420)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBPB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "26"
        Me.Text = "FrmBPB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRawAddList As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents cmbPONo As ComboBox
End Class
