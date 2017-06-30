<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettingBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettingBank))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBank = New System.Windows.Forms.TabPage()
        Me.dgvBank = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariBank = New System.Windows.Forms.TextBox()
        Me.cmbCariBank = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExitBank = New System.Windows.Forms.Button()
        Me.btnCancelBank = New System.Windows.Forms.Button()
        Me.btnDeleteBank = New System.Windows.Forms.Button()
        Me.btnSaveBank = New System.Windows.Forms.Button()
        Me.btnAddBank = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSwiftCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBankCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabCurrency = New System.Windows.Forms.TabPage()
        Me.dgvCurr = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCariCurr = New System.Windows.Forms.TextBox()
        Me.cmbCariCurr = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnExitCurr = New System.Windows.Forms.Button()
        Me.btnAddCurr = New System.Windows.Forms.Button()
        Me.btnCancelCurr = New System.Windows.Forms.Button()
        Me.btnSaveCurr = New System.Windows.Forms.Button()
        Me.btnDeleteCurr = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCurrName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCurrCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabBank.SuspendLayout()
        CType(Me.dgvBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabCurrency.SuspendLayout()
        CType(Me.dgvCurr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBank)
        Me.TabControl1.Controls.Add(Me.tabCurrency)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(919, 541)
        Me.TabControl1.TabIndex = 0
        '
        'tabBank
        '
        Me.tabBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabBank.Controls.Add(Me.dgvBank)
        Me.tabBank.Controls.Add(Me.GroupBox1)
        Me.tabBank.Controls.Add(Me.Panel2)
        Me.tabBank.Controls.Add(Me.Panel1)
        Me.tabBank.Location = New System.Drawing.Point(4, 22)
        Me.tabBank.Name = "tabBank"
        Me.tabBank.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBank.Size = New System.Drawing.Size(911, 515)
        Me.tabBank.TabIndex = 0
        Me.tabBank.Text = "Bank"
        Me.tabBank.UseVisualStyleBackColor = True
        '
        'dgvBank
        '
        Me.dgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBank.Location = New System.Drawing.Point(3, 192)
        Me.dgvBank.Name = "dgvBank"
        Me.dgvBank.Size = New System.Drawing.Size(903, 318)
        Me.dgvBank.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariBank)
        Me.GroupBox1.Controls.Add(Me.cmbCariBank)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(903, 56)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txtCariBank
        '
        Me.txtCariBank.Location = New System.Drawing.Point(237, 19)
        Me.txtCariBank.Name = "txtCariBank"
        Me.txtCariBank.Size = New System.Drawing.Size(666, 20)
        Me.txtCariBank.TabIndex = 10
        '
        'cmbCariBank
        '
        Me.cmbCariBank.FormattingEnabled = True
        Me.cmbCariBank.Location = New System.Drawing.Point(8, 19)
        Me.cmbCariBank.Name = "cmbCariBank"
        Me.cmbCariBank.Size = New System.Drawing.Size(223, 21)
        Me.cmbCariBank.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExitBank)
        Me.Panel2.Controls.Add(Me.btnCancelBank)
        Me.Panel2.Controls.Add(Me.btnDeleteBank)
        Me.Panel2.Controls.Add(Me.btnSaveBank)
        Me.Panel2.Controls.Add(Me.btnAddBank)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 37)
        Me.Panel2.TabIndex = 16
        '
        'btnExitBank
        '
        Me.btnExitBank.Location = New System.Drawing.Point(331, 5)
        Me.btnExitBank.Name = "btnExitBank"
        Me.btnExitBank.Size = New System.Drawing.Size(75, 23)
        Me.btnExitBank.TabIndex = 8
        Me.btnExitBank.Text = "Exit"
        Me.btnExitBank.UseVisualStyleBackColor = True
        '
        'btnCancelBank
        '
        Me.btnCancelBank.Location = New System.Drawing.Point(250, 5)
        Me.btnCancelBank.Name = "btnCancelBank"
        Me.btnCancelBank.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelBank.TabIndex = 7
        Me.btnCancelBank.Text = "Cancel"
        Me.btnCancelBank.UseVisualStyleBackColor = True
        '
        'btnDeleteBank
        '
        Me.btnDeleteBank.Enabled = False
        Me.btnDeleteBank.Location = New System.Drawing.Point(169, 5)
        Me.btnDeleteBank.Name = "btnDeleteBank"
        Me.btnDeleteBank.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteBank.TabIndex = 6
        Me.btnDeleteBank.Text = "Delete"
        Me.btnDeleteBank.UseVisualStyleBackColor = True
        '
        'btnSaveBank
        '
        Me.btnSaveBank.Enabled = False
        Me.btnSaveBank.Location = New System.Drawing.Point(88, 5)
        Me.btnSaveBank.Name = "btnSaveBank"
        Me.btnSaveBank.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveBank.TabIndex = 5
        Me.btnSaveBank.Text = "Save"
        Me.btnSaveBank.UseVisualStyleBackColor = True
        '
        'btnAddBank
        '
        Me.btnAddBank.Enabled = False
        Me.btnAddBank.Location = New System.Drawing.Point(7, 5)
        Me.btnAddBank.Name = "btnAddBank"
        Me.btnAddBank.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBank.TabIndex = 4
        Me.btnAddBank.Text = "Add"
        Me.btnAddBank.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSwiftCode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtBankName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBankCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 96)
        Me.Panel1.TabIndex = 12
        '
        'txtSwiftCode
        '
        Me.txtSwiftCode.Location = New System.Drawing.Point(97, 65)
        Me.txtSwiftCode.MaxLength = 50
        Me.txtSwiftCode.Name = "txtSwiftCode"
        Me.txtSwiftCode.Size = New System.Drawing.Size(309, 20)
        Me.txtSwiftCode.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Swift Code"
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(97, 39)
        Me.txtBankName.MaxLength = 150
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(309, 20)
        Me.txtBankName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bank Name"
        '
        'txtBankCode
        '
        Me.txtBankCode.Enabled = False
        Me.txtBankCode.Location = New System.Drawing.Point(97, 13)
        Me.txtBankCode.Name = "txtBankCode"
        Me.txtBankCode.Size = New System.Drawing.Size(133, 20)
        Me.txtBankCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bank Code"
        '
        'tabCurrency
        '
        Me.tabCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabCurrency.Controls.Add(Me.dgvCurr)
        Me.tabCurrency.Controls.Add(Me.GroupBox2)
        Me.tabCurrency.Controls.Add(Me.Panel4)
        Me.tabCurrency.Controls.Add(Me.Panel3)
        Me.tabCurrency.Location = New System.Drawing.Point(4, 22)
        Me.tabCurrency.Name = "tabCurrency"
        Me.tabCurrency.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCurrency.Size = New System.Drawing.Size(911, 515)
        Me.tabCurrency.TabIndex = 1
        Me.tabCurrency.Text = "Currency"
        Me.tabCurrency.UseVisualStyleBackColor = True
        '
        'dgvCurr
        '
        Me.dgvCurr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCurr.Location = New System.Drawing.Point(3, 178)
        Me.dgvCurr.Name = "dgvCurr"
        Me.dgvCurr.Size = New System.Drawing.Size(903, 332)
        Me.dgvCurr.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCariCurr)
        Me.GroupBox2.Controls.Add(Me.cmbCariCurr)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(903, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'txtCariCurr
        '
        Me.txtCariCurr.Location = New System.Drawing.Point(234, 19)
        Me.txtCariCurr.Name = "txtCariCurr"
        Me.txtCariCurr.Size = New System.Drawing.Size(669, 20)
        Me.txtCariCurr.TabIndex = 14
        '
        'cmbCariCurr
        '
        Me.cmbCariCurr.FormattingEnabled = True
        Me.cmbCariCurr.Items.AddRange(New Object() {"Currency Code", "Name"})
        Me.cmbCariCurr.Location = New System.Drawing.Point(5, 19)
        Me.cmbCariCurr.Name = "cmbCariCurr"
        Me.cmbCariCurr.Size = New System.Drawing.Size(223, 21)
        Me.cmbCariCurr.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnExitCurr)
        Me.Panel4.Controls.Add(Me.btnAddCurr)
        Me.Panel4.Controls.Add(Me.btnCancelCurr)
        Me.Panel4.Controls.Add(Me.btnSaveCurr)
        Me.Panel4.Controls.Add(Me.btnDeleteCurr)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 79)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(903, 43)
        Me.Panel4.TabIndex = 2
        '
        'btnExitCurr
        '
        Me.btnExitCurr.Location = New System.Drawing.Point(328, 5)
        Me.btnExitCurr.Name = "btnExitCurr"
        Me.btnExitCurr.Size = New System.Drawing.Size(75, 23)
        Me.btnExitCurr.TabIndex = 12
        Me.btnExitCurr.Text = "Exit"
        Me.btnExitCurr.UseVisualStyleBackColor = True
        '
        'btnAddCurr
        '
        Me.btnAddCurr.Enabled = False
        Me.btnAddCurr.Location = New System.Drawing.Point(4, 5)
        Me.btnAddCurr.Name = "btnAddCurr"
        Me.btnAddCurr.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCurr.TabIndex = 8
        Me.btnAddCurr.Text = "Add"
        Me.btnAddCurr.UseVisualStyleBackColor = True
        '
        'btnCancelCurr
        '
        Me.btnCancelCurr.Location = New System.Drawing.Point(247, 5)
        Me.btnCancelCurr.Name = "btnCancelCurr"
        Me.btnCancelCurr.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCurr.TabIndex = 11
        Me.btnCancelCurr.Text = "Cancel"
        Me.btnCancelCurr.UseVisualStyleBackColor = True
        '
        'btnSaveCurr
        '
        Me.btnSaveCurr.Enabled = False
        Me.btnSaveCurr.Location = New System.Drawing.Point(85, 5)
        Me.btnSaveCurr.Name = "btnSaveCurr"
        Me.btnSaveCurr.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCurr.TabIndex = 9
        Me.btnSaveCurr.Text = "Save"
        Me.btnSaveCurr.UseVisualStyleBackColor = True
        '
        'btnDeleteCurr
        '
        Me.btnDeleteCurr.Enabled = False
        Me.btnDeleteCurr.Location = New System.Drawing.Point(166, 5)
        Me.btnDeleteCurr.Name = "btnDeleteCurr"
        Me.btnDeleteCurr.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCurr.TabIndex = 10
        Me.btnDeleteCurr.Text = "Delete"
        Me.btnDeleteCurr.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtCurrName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCurrCode)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(903, 76)
        Me.Panel3.TabIndex = 1
        '
        'txtCurrName
        '
        Me.txtCurrName.Location = New System.Drawing.Point(101, 38)
        Me.txtCurrName.MaxLength = 50
        Me.txtCurrName.Name = "txtCurrName"
        Me.txtCurrName.Size = New System.Drawing.Size(309, 20)
        Me.txtCurrName.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Name"
        '
        'txtCurrCode
        '
        Me.txtCurrCode.Enabled = False
        Me.txtCurrCode.Location = New System.Drawing.Point(101, 12)
        Me.txtCurrCode.Name = "txtCurrCode"
        Me.txtCurrCode.Size = New System.Drawing.Size(133, 20)
        Me.txtCurrCode.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Currency Code"
        '
        'FrmSettingBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 541)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSettingBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "4"
        Me.Text = "FrmSettingBank"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBank.ResumeLayout(False)
        CType(Me.dgvBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabCurrency.ResumeLayout(False)
        CType(Me.dgvCurr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBank As TabPage
    Friend WithEvents tabCurrency As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvBank As DataGridView
    Friend WithEvents txtCariBank As TextBox
    Friend WithEvents cmbCariBank As ComboBox
    Friend WithEvents btnExitBank As Button
    Friend WithEvents btnCancelBank As Button
    Friend WithEvents btnDeleteBank As Button
    Friend WithEvents btnSaveBank As Button
    Friend WithEvents btnAddBank As Button
    Friend WithEvents txtSwiftCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBankCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCurr As DataGridView
    Friend WithEvents txtCariCurr As TextBox
    Friend WithEvents cmbCariCurr As ComboBox
    Friend WithEvents btnExitCurr As Button
    Friend WithEvents btnAddCurr As Button
    Friend WithEvents btnCancelCurr As Button
    Friend WithEvents btnSaveCurr As Button
    Friend WithEvents btnDeleteCurr As Button
    Friend WithEvents txtCurrName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCurrCode As TextBox
    Friend WithEvents Label7 As Label
End Class
