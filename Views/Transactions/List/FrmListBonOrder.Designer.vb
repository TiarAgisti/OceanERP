<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListBonOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListBonOrder))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckNoBon = New System.Windows.Forms.CheckBox()
        Me.txtNoBon = New System.Windows.Forms.TextBox()
        Me.ckDateIssues = New System.Windows.Forms.CheckBox()
        Me.dtpIssues = New System.Windows.Forms.DateTimePicker()
        Me.txtPINo = New System.Windows.Forms.TextBox()
        Me.ckPINo = New System.Windows.Forms.CheckBox()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.ckCust = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(780, 43)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "List Bon Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFind)
        Me.Panel1.Controls.Add(Me.txtCust)
        Me.Panel1.Controls.Add(Me.ckCust)
        Me.Panel1.Controls.Add(Me.txtPINo)
        Me.Panel1.Controls.Add(Me.ckPINo)
        Me.Panel1.Controls.Add(Me.dtpIssues)
        Me.Panel1.Controls.Add(Me.ckDateIssues)
        Me.Panel1.Controls.Add(Me.txtNoBon)
        Me.Panel1.Controls.Add(Me.ckNoBon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 152)
        Me.Panel1.TabIndex = 26
        '
        'ckNoBon
        '
        Me.ckNoBon.AutoSize = True
        Me.ckNoBon.Location = New System.Drawing.Point(10, 15)
        Me.ckNoBon.Name = "ckNoBon"
        Me.ckNoBon.Size = New System.Drawing.Size(91, 17)
        Me.ckNoBon.TabIndex = 0
        Me.ckNoBon.Text = "No Bon Order"
        Me.ckNoBon.UseVisualStyleBackColor = True
        '
        'txtNoBon
        '
        Me.txtNoBon.Location = New System.Drawing.Point(107, 13)
        Me.txtNoBon.Name = "txtNoBon"
        Me.txtNoBon.Size = New System.Drawing.Size(188, 20)
        Me.txtNoBon.TabIndex = 1
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
        'dtpIssues
        '
        Me.dtpIssues.Location = New System.Drawing.Point(107, 39)
        Me.dtpIssues.Name = "dtpIssues"
        Me.dtpIssues.Size = New System.Drawing.Size(188, 20)
        Me.dtpIssues.TabIndex = 3
        '
        'txtPINo
        '
        Me.txtPINo.Location = New System.Drawing.Point(107, 65)
        Me.txtPINo.Name = "txtPINo"
        Me.txtPINo.Size = New System.Drawing.Size(188, 20)
        Me.txtPINo.TabIndex = 5
        '
        'ckPINo
        '
        Me.ckPINo.AutoSize = True
        Me.ckPINo.Location = New System.Drawing.Point(10, 67)
        Me.ckPINo.Name = "ckPINo"
        Me.ckPINo.Size = New System.Drawing.Size(53, 17)
        Me.ckPINo.TabIndex = 4
        Me.ckPINo.Text = "PI No"
        Me.ckPINo.UseVisualStyleBackColor = True
        '
        'txtCust
        '
        Me.txtCust.Location = New System.Drawing.Point(107, 91)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(188, 20)
        Me.txtCust.TabIndex = 7
        '
        'ckCust
        '
        Me.ckCust.AutoSize = True
        Me.ckCust.Location = New System.Drawing.Point(10, 93)
        Me.ckCust.Name = "ckCust"
        Me.ckCust.Size = New System.Drawing.Size(70, 17)
        Me.ckCust.TabIndex = 6
        Me.ckCust.Text = "Customer"
        Me.ckCust.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(188, 117)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 62
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(107, 117)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 61
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 35)
        Me.Panel2.TabIndex = 53
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
        Me.btnRefresh.Location = New System.Drawing.Point(172, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 35
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
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
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(253, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 36
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(780, 251)
        Me.DataGridView1.TabIndex = 54
        '
        'FrmListBonOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 481)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListBonOrder"
        Me.Text = "FrmListBonOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCust As TextBox
    Friend WithEvents ckCust As CheckBox
    Friend WithEvents txtPINo As TextBox
    Friend WithEvents ckPINo As CheckBox
    Friend WithEvents dtpIssues As DateTimePicker
    Friend WithEvents ckDateIssues As CheckBox
    Friend WithEvents txtNoBon As TextBox
    Friend WithEvents ckNoBon As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
