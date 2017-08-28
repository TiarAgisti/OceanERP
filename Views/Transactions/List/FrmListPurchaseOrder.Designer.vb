<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListPurchaseOrder))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkSupplier = New System.Windows.Forms.CheckBox()
        Me.chkPIDate = New System.Windows.Forms.CheckBox()
        Me.chkPONo = New System.Windows.Forms.CheckBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
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
        Me.Label3.Size = New System.Drawing.Size(872, 46)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "List Purchase Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 133)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.Location = New System.Drawing.Point(5, 111)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(64, 17)
        Me.chkSupplier.TabIndex = 48
        Me.chkSupplier.Text = "Supplier"
        Me.chkSupplier.UseVisualStyleBackColor = True
        '
        'chkPIDate
        '
        Me.chkPIDate.AutoSize = True
        Me.chkPIDate.Location = New System.Drawing.Point(5, 84)
        Me.chkPIDate.Name = "chkPIDate"
        Me.chkPIDate.Size = New System.Drawing.Size(67, 17)
        Me.chkPIDate.TabIndex = 47
        Me.chkPIDate.Text = "PO Date"
        Me.chkPIDate.UseVisualStyleBackColor = True
        '
        'chkPONo
        '
        Me.chkPONo.AutoSize = True
        Me.chkPONo.Location = New System.Drawing.Point(5, 59)
        Me.chkPONo.Name = "chkPONo"
        Me.chkPONo.Size = New System.Drawing.Size(55, 17)
        Me.chkPONo.TabIndex = 46
        Me.chkPONo.Text = "PONo"
        Me.chkPONo.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(81, 133)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 45
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(81, 107)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(265, 20)
        Me.txtSupplier.TabIndex = 43
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Location = New System.Drawing.Point(315, 81)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateTo.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "TO"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Location = New System.Drawing.Point(81, 81)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateFrom.TabIndex = 40
        '
        'txtPONo
        '
        Me.txtPONo.Location = New System.Drawing.Point(81, 55)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(265, 20)
        Me.txtPONo.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Location = New System.Drawing.Point(5, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 33)
        Me.Panel1.TabIndex = 51
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(7, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(250, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 36
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Enabled = False
        Me.btnView.Location = New System.Drawing.Point(88, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 34
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(169, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 35
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(5, 201)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(867, 116)
        Me.dgv.TabIndex = 52
        '
        'FrmListPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 319)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkSupplier)
        Me.Controls.Add(Me.chkPIDate)
        Me.Controls.Add(Me.chkPONo)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.txtPONo)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmListPurchaseOrder"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents chkSupplier As CheckBox
    Friend WithEvents chkPIDate As CheckBox
    Friend WithEvents chkPONo As CheckBox
    Friend WithEvents btnFind As Button
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents txtPONo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgv As DataGridView
End Class
