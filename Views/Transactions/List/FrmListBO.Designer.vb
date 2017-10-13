<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListBO
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.ckCust = New System.Windows.Forms.CheckBox()
        Me.dtpIssues = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ckDateIssues = New System.Windows.Forms.CheckBox()
        Me.txtNoBon = New System.Windows.Forms.TextBox()
        Me.ckNoBon = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPI = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 201)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(805, 208)
        Me.dgv.TabIndex = 58
        '
        'btnView
        '
        Me.btnView.Enabled = False
        Me.btnView.Location = New System.Drawing.Point(91, 4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 34
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(188, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 62
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(107, 91)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 61
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtCust
        '
        Me.txtCust.Location = New System.Drawing.Point(107, 65)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(188, 20)
        Me.txtCust.TabIndex = 7
        '
        'ckCust
        '
        Me.ckCust.AutoSize = True
        Me.ckCust.Location = New System.Drawing.Point(10, 67)
        Me.ckCust.Name = "ckCust"
        Me.ckCust.Size = New System.Drawing.Size(70, 17)
        Me.ckCust.TabIndex = 6
        Me.ckCust.Text = "Customer"
        Me.ckCust.UseVisualStyleBackColor = True
        '
        'dtpIssues
        '
        Me.dtpIssues.Location = New System.Drawing.Point(107, 39)
        Me.dtpIssues.Name = "dtpIssues"
        Me.dtpIssues.Size = New System.Drawing.Size(188, 20)
        Me.dtpIssues.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(10, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(255, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 35
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'ckDateIssues
        '
        Me.ckDateIssues.AutoSize = True
        Me.ckDateIssues.Location = New System.Drawing.Point(10, 39)
        Me.ckDateIssues.Name = "ckDateIssues"
        Me.ckDateIssues.Size = New System.Drawing.Size(82, 17)
        Me.ckDateIssues.TabIndex = 2
        Me.ckDateIssues.Text = "Date Issues"
        Me.ckDateIssues.UseVisualStyleBackColor = True
        '
        'txtNoBon
        '
        Me.txtNoBon.Location = New System.Drawing.Point(107, 13)
        Me.txtNoBon.Name = "txtNoBon"
        Me.txtNoBon.Size = New System.Drawing.Size(188, 20)
        Me.txtNoBon.TabIndex = 1
        '
        'ckNoBon
        '
        Me.ckNoBon.AutoSize = True
        Me.ckNoBon.Location = New System.Drawing.Point(10, 15)
        Me.ckNoBon.Name = "ckNoBon"
        Me.ckNoBon.Size = New System.Drawing.Size(69, 17)
        Me.ckNoBon.TabIndex = 0
        Me.ckNoBon.Text = "No.Order"
        Me.ckNoBon.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(336, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 36
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnPI)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 35)
        Me.Panel2.TabIndex = 57
        '
        'btnPI
        '
        Me.btnPI.Location = New System.Drawing.Point(174, 4)
        Me.btnPI.Name = "btnPI"
        Me.btnPI.Size = New System.Drawing.Size(75, 23)
        Me.btnPI.TabIndex = 37
        Me.btnPI.Text = "Create PI"
        Me.btnPI.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFind)
        Me.Panel1.Controls.Add(Me.txtCust)
        Me.Panel1.Controls.Add(Me.ckCust)
        Me.Panel1.Controls.Add(Me.dtpIssues)
        Me.Panel1.Controls.Add(Me.ckDateIssues)
        Me.Panel1.Controls.Add(Me.txtNoBon)
        Me.Panel1.Controls.Add(Me.ckNoBon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 123)
        Me.Panel1.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(805, 43)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "List Bon Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmListBO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 409)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmListBO"
        Me.Tag = "24"
        Me.Text = "FrmListBO"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents txtCust As TextBox
    Friend WithEvents ckCust As CheckBox
    Friend WithEvents dtpIssues As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ckDateIssues As CheckBox
    Friend WithEvents txtNoBon As TextBox
    Friend WithEvents ckNoBon As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPI As Button
End Class
