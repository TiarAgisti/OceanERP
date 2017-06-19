<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPermission))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ckVoid = New System.Windows.Forms.CheckBox()
        Me.ckApprove = New System.Windows.Forms.CheckBox()
        Me.ckDelete = New System.Windows.Forms.CheckBox()
        Me.ckUpdate = New System.Windows.Forms.CheckBox()
        Me.CkCreate = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Permission"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 42)
        Me.Panel1.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(52, 12)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 20)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.ckVoid)
        Me.GroupBox1.Controls.Add(Me.ckApprove)
        Me.GroupBox1.Controls.Add(Me.ckDelete)
        Me.GroupBox1.Controls.Add(Me.ckUpdate)
        Me.GroupBox1.Controls.Add(Me.CkCreate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbMenu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 111)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(74, 85)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(53, 23)
        Me.btnDel.TabIndex = 12
        Me.btnDel.Text = "del"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 85)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(53, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ckVoid
        '
        Me.ckVoid.AutoSize = True
        Me.ckVoid.Location = New System.Drawing.Point(294, 41)
        Me.ckVoid.Name = "ckVoid"
        Me.ckVoid.Size = New System.Drawing.Size(47, 17)
        Me.ckVoid.TabIndex = 10
        Me.ckVoid.Text = "Void"
        Me.ckVoid.UseVisualStyleBackColor = True
        '
        'ckApprove
        '
        Me.ckApprove.AutoSize = True
        Me.ckApprove.Location = New System.Drawing.Point(195, 64)
        Me.ckApprove.Name = "ckApprove"
        Me.ckApprove.Size = New System.Drawing.Size(66, 17)
        Me.ckApprove.TabIndex = 9
        Me.ckApprove.Text = "Approve"
        Me.ckApprove.UseVisualStyleBackColor = True
        '
        'ckDelete
        '
        Me.ckDelete.AutoSize = True
        Me.ckDelete.Location = New System.Drawing.Point(195, 41)
        Me.ckDelete.Name = "ckDelete"
        Me.ckDelete.Size = New System.Drawing.Size(57, 17)
        Me.ckDelete.TabIndex = 8
        Me.ckDelete.Text = "Delete"
        Me.ckDelete.UseVisualStyleBackColor = True
        '
        'ckUpdate
        '
        Me.ckUpdate.AutoSize = True
        Me.ckUpdate.Location = New System.Drawing.Point(114, 64)
        Me.ckUpdate.Name = "ckUpdate"
        Me.ckUpdate.Size = New System.Drawing.Size(61, 17)
        Me.ckUpdate.TabIndex = 7
        Me.ckUpdate.Text = "Update"
        Me.ckUpdate.UseVisualStyleBackColor = True
        '
        'CkCreate
        '
        Me.CkCreate.AutoSize = True
        Me.CkCreate.Location = New System.Drawing.Point(114, 41)
        Me.CkCreate.Name = "CkCreate"
        Me.CkCreate.Size = New System.Drawing.Size(57, 17)
        Me.CkCreate.TabIndex = 5
        Me.CkCreate.Text = "Create"
        Me.CkCreate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Access Permission"
        '
        'cmbMenu
        '
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Location = New System.Drawing.Point(114, 14)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(227, 21)
        Me.cmbMenu.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Menu Description"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.Location = New System.Drawing.Point(0, 199)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(687, 179)
        Me.dgv.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 378)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 38)
        Me.Panel2.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(166, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(85, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 416)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPermission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPermission"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ckVoid As CheckBox
    Friend WithEvents ckApprove As CheckBox
    Friend WithEvents ckDelete As CheckBox
    Friend WithEvents ckUpdate As CheckBox
    Friend WithEvents CkCreate As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
