<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtilities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtilities))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDept = New System.Windows.Forms.TabPage()
        Me.dgvDept = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCariDept = New System.Windows.Forms.TextBox()
        Me.cmbCariDept = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnExitDept = New System.Windows.Forms.Button()
        Me.btnAddDept = New System.Windows.Forms.Button()
        Me.btnCancelDept = New System.Windows.Forms.Button()
        Me.btnSaveDept = New System.Windows.Forms.Button()
        Me.btnDeleteDept = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNameDept = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodeDept = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabBrand = New System.Windows.Forms.TabPage()
        Me.dgvBrand = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariBrand = New System.Windows.Forms.TextBox()
        Me.cmbCariBrand = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExitBrand = New System.Windows.Forms.Button()
        Me.btnAddBrand = New System.Windows.Forms.Button()
        Me.btnCancelBrand = New System.Windows.Forms.Button()
        Me.btnSaveBrand = New System.Windows.Forms.Button()
        Me.btnDeleteBrand = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNameBrand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodeBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabDept.SuspendLayout()
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabBrand.SuspendLayout()
        CType(Me.dgvBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDept)
        Me.TabControl1.Controls.Add(Me.tabBrand)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 484)
        Me.TabControl1.TabIndex = 0
        '
        'tabDept
        '
        Me.tabDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabDept.Controls.Add(Me.dgvDept)
        Me.tabDept.Controls.Add(Me.GroupBox2)
        Me.tabDept.Controls.Add(Me.Panel4)
        Me.tabDept.Controls.Add(Me.Panel3)
        Me.tabDept.Location = New System.Drawing.Point(4, 22)
        Me.tabDept.Name = "tabDept"
        Me.tabDept.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDept.Size = New System.Drawing.Size(640, 458)
        Me.tabDept.TabIndex = 0
        Me.tabDept.Text = "Department"
        Me.tabDept.UseVisualStyleBackColor = True
        '
        'dgvDept
        '
        Me.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDept.Location = New System.Drawing.Point(3, 178)
        Me.dgvDept.Name = "dgvDept"
        Me.dgvDept.Size = New System.Drawing.Size(632, 275)
        Me.dgvDept.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCariDept)
        Me.GroupBox2.Controls.Add(Me.cmbCariDept)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 56)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'txtCariDept
        '
        Me.txtCariDept.Location = New System.Drawing.Point(234, 19)
        Me.txtCariDept.Name = "txtCariDept"
        Me.txtCariDept.Size = New System.Drawing.Size(395, 20)
        Me.txtCariDept.TabIndex = 9
        '
        'cmbCariDept
        '
        Me.cmbCariDept.FormattingEnabled = True
        Me.cmbCariDept.Items.AddRange(New Object() {"Department Code", "Name"})
        Me.cmbCariDept.Location = New System.Drawing.Point(5, 19)
        Me.cmbCariDept.Name = "cmbCariDept"
        Me.cmbCariDept.Size = New System.Drawing.Size(223, 21)
        Me.cmbCariDept.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnExitDept)
        Me.Panel4.Controls.Add(Me.btnAddDept)
        Me.Panel4.Controls.Add(Me.btnCancelDept)
        Me.Panel4.Controls.Add(Me.btnSaveDept)
        Me.Panel4.Controls.Add(Me.btnDeleteDept)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 79)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(632, 43)
        Me.Panel4.TabIndex = 14
        '
        'btnExitDept
        '
        Me.btnExitDept.Location = New System.Drawing.Point(328, 5)
        Me.btnExitDept.Name = "btnExitDept"
        Me.btnExitDept.Size = New System.Drawing.Size(75, 23)
        Me.btnExitDept.TabIndex = 7
        Me.btnExitDept.Text = "Exit"
        Me.btnExitDept.UseVisualStyleBackColor = True
        '
        'btnAddDept
        '
        Me.btnAddDept.Enabled = False
        Me.btnAddDept.Location = New System.Drawing.Point(4, 5)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDept.TabIndex = 3
        Me.btnAddDept.Text = "Add"
        Me.btnAddDept.UseVisualStyleBackColor = True
        '
        'btnCancelDept
        '
        Me.btnCancelDept.Location = New System.Drawing.Point(247, 5)
        Me.btnCancelDept.Name = "btnCancelDept"
        Me.btnCancelDept.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelDept.TabIndex = 6
        Me.btnCancelDept.Text = "Cancel"
        Me.btnCancelDept.UseVisualStyleBackColor = True
        '
        'btnSaveDept
        '
        Me.btnSaveDept.Enabled = False
        Me.btnSaveDept.Location = New System.Drawing.Point(85, 5)
        Me.btnSaveDept.Name = "btnSaveDept"
        Me.btnSaveDept.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveDept.TabIndex = 4
        Me.btnSaveDept.Text = "Save"
        Me.btnSaveDept.UseVisualStyleBackColor = True
        '
        'btnDeleteDept
        '
        Me.btnDeleteDept.Enabled = False
        Me.btnDeleteDept.Location = New System.Drawing.Point(166, 5)
        Me.btnDeleteDept.Name = "btnDeleteDept"
        Me.btnDeleteDept.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteDept.TabIndex = 5
        Me.btnDeleteDept.Text = "Delete"
        Me.btnDeleteDept.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtNameDept)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCodeDept)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(632, 76)
        Me.Panel3.TabIndex = 13
        '
        'txtNameDept
        '
        Me.txtNameDept.Location = New System.Drawing.Point(101, 38)
        Me.txtNameDept.MaxLength = 50
        Me.txtNameDept.Name = "txtNameDept"
        Me.txtNameDept.Size = New System.Drawing.Size(309, 20)
        Me.txtNameDept.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name"
        '
        'txtCodeDept
        '
        Me.txtCodeDept.Enabled = False
        Me.txtCodeDept.Location = New System.Drawing.Point(101, 12)
        Me.txtCodeDept.Name = "txtCodeDept"
        Me.txtCodeDept.Size = New System.Drawing.Size(133, 20)
        Me.txtCodeDept.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Department Code"
        '
        'tabBrand
        '
        Me.tabBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabBrand.Controls.Add(Me.dgvBrand)
        Me.tabBrand.Controls.Add(Me.GroupBox1)
        Me.tabBrand.Controls.Add(Me.Panel2)
        Me.tabBrand.Controls.Add(Me.Panel1)
        Me.tabBrand.Location = New System.Drawing.Point(4, 22)
        Me.tabBrand.Name = "tabBrand"
        Me.tabBrand.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBrand.Size = New System.Drawing.Size(640, 458)
        Me.tabBrand.TabIndex = 1
        Me.tabBrand.Text = "Brand"
        Me.tabBrand.UseVisualStyleBackColor = True
        '
        'dgvBrand
        '
        Me.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBrand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBrand.Location = New System.Drawing.Point(3, 203)
        Me.dgvBrand.Name = "dgvBrand"
        Me.dgvBrand.Size = New System.Drawing.Size(632, 250)
        Me.dgvBrand.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariBrand)
        Me.GroupBox1.Controls.Add(Me.cmbCariBrand)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 56)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txtCariBrand
        '
        Me.txtCariBrand.Location = New System.Drawing.Point(234, 19)
        Me.txtCariBrand.Name = "txtCariBrand"
        Me.txtCariBrand.Size = New System.Drawing.Size(395, 20)
        Me.txtCariBrand.TabIndex = 25
        '
        'cmbCariBrand
        '
        Me.cmbCariBrand.FormattingEnabled = True
        Me.cmbCariBrand.Items.AddRange(New Object() {"Brand Code", "Name", "Description"})
        Me.cmbCariBrand.Location = New System.Drawing.Point(5, 19)
        Me.cmbCariBrand.Name = "cmbCariBrand"
        Me.cmbCariBrand.Size = New System.Drawing.Size(223, 21)
        Me.cmbCariBrand.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExitBrand)
        Me.Panel2.Controls.Add(Me.btnAddBrand)
        Me.Panel2.Controls.Add(Me.btnCancelBrand)
        Me.Panel2.Controls.Add(Me.btnSaveBrand)
        Me.Panel2.Controls.Add(Me.btnDeleteBrand)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(632, 43)
        Me.Panel2.TabIndex = 28
        '
        'btnExitBrand
        '
        Me.btnExitBrand.Location = New System.Drawing.Point(328, 5)
        Me.btnExitBrand.Name = "btnExitBrand"
        Me.btnExitBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnExitBrand.TabIndex = 23
        Me.btnExitBrand.Text = "Exit"
        Me.btnExitBrand.UseVisualStyleBackColor = True
        '
        'btnAddBrand
        '
        Me.btnAddBrand.Enabled = False
        Me.btnAddBrand.Location = New System.Drawing.Point(4, 5)
        Me.btnAddBrand.Name = "btnAddBrand"
        Me.btnAddBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBrand.TabIndex = 19
        Me.btnAddBrand.Text = "Add"
        Me.btnAddBrand.UseVisualStyleBackColor = True
        '
        'btnCancelBrand
        '
        Me.btnCancelBrand.Location = New System.Drawing.Point(247, 5)
        Me.btnCancelBrand.Name = "btnCancelBrand"
        Me.btnCancelBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelBrand.TabIndex = 22
        Me.btnCancelBrand.Text = "Cancel"
        Me.btnCancelBrand.UseVisualStyleBackColor = True
        '
        'btnSaveBrand
        '
        Me.btnSaveBrand.Enabled = False
        Me.btnSaveBrand.Location = New System.Drawing.Point(85, 5)
        Me.btnSaveBrand.Name = "btnSaveBrand"
        Me.btnSaveBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveBrand.TabIndex = 20
        Me.btnSaveBrand.Text = "Save"
        Me.btnSaveBrand.UseVisualStyleBackColor = True
        '
        'btnDeleteBrand
        '
        Me.btnDeleteBrand.Enabled = False
        Me.btnDeleteBrand.Location = New System.Drawing.Point(166, 5)
        Me.btnDeleteBrand.Name = "btnDeleteBrand"
        Me.btnDeleteBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteBrand.TabIndex = 21
        Me.btnDeleteBrand.Text = "Delete"
        Me.btnDeleteBrand.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDesc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNameBrand)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCodeBrand)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 101)
        Me.Panel1.TabIndex = 27
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(101, 64)
        Me.txtDesc.MaxLength = 150
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(309, 20)
        Me.txtDesc.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description"
        '
        'txtNameBrand
        '
        Me.txtNameBrand.Location = New System.Drawing.Point(101, 38)
        Me.txtNameBrand.MaxLength = 150
        Me.txtNameBrand.Name = "txtNameBrand"
        Me.txtNameBrand.Size = New System.Drawing.Size(309, 20)
        Me.txtNameBrand.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'txtCodeBrand
        '
        Me.txtCodeBrand.Enabled = False
        Me.txtCodeBrand.Location = New System.Drawing.Point(101, 12)
        Me.txtCodeBrand.Name = "txtCodeBrand"
        Me.txtCodeBrand.Size = New System.Drawing.Size(133, 20)
        Me.txtCodeBrand.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Brand Code"
        '
        'FrmUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 484)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUtilities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "8"
        Me.Text = "FrmUtilities"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDept.ResumeLayout(False)
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabBrand.ResumeLayout(False)
        CType(Me.dgvBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDept As TabPage
    Friend WithEvents tabBrand As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNameDept As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodeDept As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnExitDept As Button
    Friend WithEvents btnAddDept As Button
    Friend WithEvents btnCancelDept As Button
    Friend WithEvents btnSaveDept As Button
    Friend WithEvents btnDeleteDept As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCariDept As TextBox
    Friend WithEvents cmbCariDept As ComboBox
    Friend WithEvents dgvDept As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNameBrand As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodeBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExitBrand As Button
    Friend WithEvents btnAddBrand As Button
    Friend WithEvents btnCancelBrand As Button
    Friend WithEvents btnSaveBrand As Button
    Friend WithEvents btnDeleteBrand As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCariBrand As TextBox
    Friend WithEvents cmbCariBrand As ComboBox
    Friend WithEvents dgvBrand As DataGridView
End Class
