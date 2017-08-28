<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListBOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListBOM))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.ckStatus = New System.Windows.Forms.CheckBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.ckColor = New System.Windows.Forms.CheckBox()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.ckStyle = New System.Windows.Forms.CheckBox()
        Me.txtFabric = New System.Windows.Forms.TextBox()
        Me.ckFabric = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(917, 46)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "List Bill OF Material"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFind)
        Me.Panel1.Controls.Add(Me.ckStatus)
        Me.Panel1.Controls.Add(Me.txtColor)
        Me.Panel1.Controls.Add(Me.ckColor)
        Me.Panel1.Controls.Add(Me.txtStyle)
        Me.Panel1.Controls.Add(Me.ckStyle)
        Me.Panel1.Controls.Add(Me.txtFabric)
        Me.Panel1.Controls.Add(Me.ckFabric)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 153)
        Me.Panel1.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(152, 122)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 40
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(71, 122)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 39
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'ckStatus
        '
        Me.ckStatus.AutoSize = True
        Me.ckStatus.Location = New System.Drawing.Point(10, 91)
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.Size = New System.Drawing.Size(56, 17)
        Me.ckStatus.TabIndex = 6
        Me.ckStatus.Text = "Status"
        Me.ckStatus.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(71, 62)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(198, 20)
        Me.txtColor.TabIndex = 5
        '
        'ckColor
        '
        Me.ckColor.AutoSize = True
        Me.ckColor.Location = New System.Drawing.Point(10, 65)
        Me.ckColor.Name = "ckColor"
        Me.ckColor.Size = New System.Drawing.Size(50, 17)
        Me.ckColor.TabIndex = 4
        Me.ckColor.Text = "Color"
        Me.ckColor.UseVisualStyleBackColor = True
        '
        'txtStyle
        '
        Me.txtStyle.Location = New System.Drawing.Point(71, 36)
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.Size = New System.Drawing.Size(198, 20)
        Me.txtStyle.TabIndex = 3
        '
        'ckStyle
        '
        Me.ckStyle.AutoSize = True
        Me.ckStyle.Location = New System.Drawing.Point(10, 39)
        Me.ckStyle.Name = "ckStyle"
        Me.ckStyle.Size = New System.Drawing.Size(49, 17)
        Me.ckStyle.TabIndex = 2
        Me.ckStyle.Text = "Style"
        Me.ckStyle.UseVisualStyleBackColor = True
        '
        'txtFabric
        '
        Me.txtFabric.Location = New System.Drawing.Point(71, 10)
        Me.txtFabric.Name = "txtFabric"
        Me.txtFabric.Size = New System.Drawing.Size(198, 20)
        Me.txtFabric.TabIndex = 1
        '
        'ckFabric
        '
        Me.ckFabric.AutoSize = True
        Me.ckFabric.Location = New System.Drawing.Point(10, 13)
        Me.ckFabric.Name = "ckFabric"
        Me.ckFabric.Size = New System.Drawing.Size(55, 17)
        Me.ckFabric.TabIndex = 0
        Me.ckFabric.Text = "Fabric"
        Me.ckFabric.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 35)
        Me.Panel2.TabIndex = 27
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(15, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(258, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Enabled = False
        Me.btnView.Location = New System.Drawing.Point(96, 6)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 29
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(177, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 234)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(917, 252)
        Me.dgv.TabIndex = 28
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(71, 89)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(198, 21)
        Me.cmbStatus.TabIndex = 41
        '
        'FrmListBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 486)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListBOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmListBOM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ckStatus As CheckBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents ckColor As CheckBox
    Friend WithEvents txtStyle As TextBox
    Friend WithEvents ckStyle As CheckBox
    Friend WithEvents txtFabric As TextBox
    Friend WithEvents ckFabric As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cmbStatus As ComboBox
End Class
