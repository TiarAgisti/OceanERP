<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDestination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDestination))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCountry = New System.Windows.Forms.TabPage()
        Me.dgvCon = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCariCon = New System.Windows.Forms.TextBox()
        Me.cmbCariCon = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnExitCon = New System.Windows.Forms.Button()
        Me.btnAddCon = New System.Windows.Forms.Button()
        Me.btnCancelCon = New System.Windows.Forms.Button()
        Me.btnSaveCon = New System.Windows.Forms.Button()
        Me.btnDeleteCon = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtConName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabSeaPort = New System.Windows.Forms.TabPage()
        Me.dgvSea = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariSea = New System.Windows.Forms.TextBox()
        Me.cmbCariSea = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExitSea = New System.Windows.Forms.Button()
        Me.btnAddSea = New System.Windows.Forms.Button()
        Me.btnCancelSea = New System.Windows.Forms.Button()
        Me.btnSaveSea = New System.Windows.Forms.Button()
        Me.btnDeleteSea = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSeaName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSeaCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabCountry.SuspendLayout()
        CType(Me.dgvCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabSeaPort.SuspendLayout()
        CType(Me.dgvSea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCountry)
        Me.TabControl1.Controls.Add(Me.tabSeaPort)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1049, 496)
        Me.TabControl1.TabIndex = 0
        '
        'tabCountry
        '
        Me.tabCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabCountry.Controls.Add(Me.dgvCon)
        Me.tabCountry.Controls.Add(Me.GroupBox2)
        Me.tabCountry.Controls.Add(Me.Panel4)
        Me.tabCountry.Controls.Add(Me.Panel3)
        Me.tabCountry.Location = New System.Drawing.Point(4, 22)
        Me.tabCountry.Name = "tabCountry"
        Me.tabCountry.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCountry.Size = New System.Drawing.Size(1041, 470)
        Me.tabCountry.TabIndex = 0
        Me.tabCountry.Text = "Country"
        Me.tabCountry.UseVisualStyleBackColor = True
        '
        'dgvCon
        '
        Me.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCon.Location = New System.Drawing.Point(3, 178)
        Me.dgvCon.Name = "dgvCon"
        Me.dgvCon.Size = New System.Drawing.Size(1033, 287)
        Me.dgvCon.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCariCon)
        Me.GroupBox2.Controls.Add(Me.cmbCariCon)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1033, 56)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'txtCariCon
        '
        Me.txtCariCon.Location = New System.Drawing.Point(234, 19)
        Me.txtCariCon.Name = "txtCariCon"
        Me.txtCariCon.Size = New System.Drawing.Size(692, 20)
        Me.txtCariCon.TabIndex = 9
        '
        'cmbCariCon
        '
        Me.cmbCariCon.FormattingEnabled = True
        Me.cmbCariCon.Items.AddRange(New Object() {"Country Code", "Name"})
        Me.cmbCariCon.Location = New System.Drawing.Point(5, 19)
        Me.cmbCariCon.Name = "cmbCariCon"
        Me.cmbCariCon.Size = New System.Drawing.Size(223, 21)
        Me.cmbCariCon.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnExitCon)
        Me.Panel4.Controls.Add(Me.btnAddCon)
        Me.Panel4.Controls.Add(Me.btnCancelCon)
        Me.Panel4.Controls.Add(Me.btnSaveCon)
        Me.Panel4.Controls.Add(Me.btnDeleteCon)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 79)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1033, 43)
        Me.Panel4.TabIndex = 3
        '
        'btnExitCon
        '
        Me.btnExitCon.Location = New System.Drawing.Point(328, 5)
        Me.btnExitCon.Name = "btnExitCon"
        Me.btnExitCon.Size = New System.Drawing.Size(75, 23)
        Me.btnExitCon.TabIndex = 7
        Me.btnExitCon.Text = "Exit"
        Me.btnExitCon.UseVisualStyleBackColor = True
        '
        'btnAddCon
        '
        Me.btnAddCon.Enabled = False
        Me.btnAddCon.Location = New System.Drawing.Point(4, 5)
        Me.btnAddCon.Name = "btnAddCon"
        Me.btnAddCon.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCon.TabIndex = 3
        Me.btnAddCon.Text = "Add"
        Me.btnAddCon.UseVisualStyleBackColor = True
        '
        'btnCancelCon
        '
        Me.btnCancelCon.Location = New System.Drawing.Point(247, 5)
        Me.btnCancelCon.Name = "btnCancelCon"
        Me.btnCancelCon.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCon.TabIndex = 6
        Me.btnCancelCon.Text = "Cancel"
        Me.btnCancelCon.UseVisualStyleBackColor = True
        '
        'btnSaveCon
        '
        Me.btnSaveCon.Enabled = False
        Me.btnSaveCon.Location = New System.Drawing.Point(85, 5)
        Me.btnSaveCon.Name = "btnSaveCon"
        Me.btnSaveCon.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCon.TabIndex = 4
        Me.btnSaveCon.Text = "Save"
        Me.btnSaveCon.UseVisualStyleBackColor = True
        '
        'btnDeleteCon
        '
        Me.btnDeleteCon.Enabled = False
        Me.btnDeleteCon.Location = New System.Drawing.Point(166, 5)
        Me.btnDeleteCon.Name = "btnDeleteCon"
        Me.btnDeleteCon.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCon.TabIndex = 5
        Me.btnDeleteCon.Text = "Delete"
        Me.btnDeleteCon.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtConName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtConCode)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1033, 76)
        Me.Panel3.TabIndex = 2
        '
        'txtConName
        '
        Me.txtConName.Location = New System.Drawing.Point(99, 38)
        Me.txtConName.MaxLength = 50
        Me.txtConName.Name = "txtConName"
        Me.txtConName.Size = New System.Drawing.Size(308, 20)
        Me.txtConName.TabIndex = 2
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
        'txtConCode
        '
        Me.txtConCode.Enabled = False
        Me.txtConCode.Location = New System.Drawing.Point(101, 12)
        Me.txtConCode.Name = "txtConCode"
        Me.txtConCode.Size = New System.Drawing.Size(133, 20)
        Me.txtConCode.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Country Code"
        '
        'tabSeaPort
        '
        Me.tabSeaPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabSeaPort.Controls.Add(Me.dgvSea)
        Me.tabSeaPort.Controls.Add(Me.GroupBox1)
        Me.tabSeaPort.Controls.Add(Me.Panel2)
        Me.tabSeaPort.Controls.Add(Me.Panel1)
        Me.tabSeaPort.Location = New System.Drawing.Point(4, 22)
        Me.tabSeaPort.Name = "tabSeaPort"
        Me.tabSeaPort.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSeaPort.Size = New System.Drawing.Size(1041, 470)
        Me.tabSeaPort.TabIndex = 1
        Me.tabSeaPort.Text = "SeaPort"
        Me.tabSeaPort.UseVisualStyleBackColor = True
        '
        'dgvSea
        '
        Me.dgvSea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSea.Location = New System.Drawing.Point(3, 178)
        Me.dgvSea.Name = "dgvSea"
        Me.dgvSea.Size = New System.Drawing.Size(1033, 287)
        Me.dgvSea.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariSea)
        Me.GroupBox1.Controls.Add(Me.cmbCariSea)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1033, 56)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txtCariSea
        '
        Me.txtCariSea.Location = New System.Drawing.Point(234, 19)
        Me.txtCariSea.Name = "txtCariSea"
        Me.txtCariSea.Size = New System.Drawing.Size(692, 20)
        Me.txtCariSea.TabIndex = 14
        '
        'cmbCariSea
        '
        Me.cmbCariSea.FormattingEnabled = True
        Me.cmbCariSea.Items.AddRange(New Object() {"SeaPort Code", "Name"})
        Me.cmbCariSea.Location = New System.Drawing.Point(5, 19)
        Me.cmbCariSea.Name = "cmbCariSea"
        Me.cmbCariSea.Size = New System.Drawing.Size(223, 21)
        Me.cmbCariSea.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExitSea)
        Me.Panel2.Controls.Add(Me.btnAddSea)
        Me.Panel2.Controls.Add(Me.btnCancelSea)
        Me.Panel2.Controls.Add(Me.btnSaveSea)
        Me.Panel2.Controls.Add(Me.btnDeleteSea)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1033, 43)
        Me.Panel2.TabIndex = 4
        '
        'btnExitSea
        '
        Me.btnExitSea.Location = New System.Drawing.Point(328, 5)
        Me.btnExitSea.Name = "btnExitSea"
        Me.btnExitSea.Size = New System.Drawing.Size(75, 23)
        Me.btnExitSea.TabIndex = 7
        Me.btnExitSea.Text = "Exit"
        Me.btnExitSea.UseVisualStyleBackColor = True
        '
        'btnAddSea
        '
        Me.btnAddSea.Enabled = False
        Me.btnAddSea.Location = New System.Drawing.Point(4, 5)
        Me.btnAddSea.Name = "btnAddSea"
        Me.btnAddSea.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSea.TabIndex = 3
        Me.btnAddSea.Text = "Add"
        Me.btnAddSea.UseVisualStyleBackColor = True
        '
        'btnCancelSea
        '
        Me.btnCancelSea.Location = New System.Drawing.Point(247, 5)
        Me.btnCancelSea.Name = "btnCancelSea"
        Me.btnCancelSea.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelSea.TabIndex = 6
        Me.btnCancelSea.Text = "Cancel"
        Me.btnCancelSea.UseVisualStyleBackColor = True
        '
        'btnSaveSea
        '
        Me.btnSaveSea.Enabled = False
        Me.btnSaveSea.Location = New System.Drawing.Point(85, 5)
        Me.btnSaveSea.Name = "btnSaveSea"
        Me.btnSaveSea.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveSea.TabIndex = 4
        Me.btnSaveSea.Text = "Save"
        Me.btnSaveSea.UseVisualStyleBackColor = True
        '
        'btnDeleteSea
        '
        Me.btnDeleteSea.Enabled = False
        Me.btnDeleteSea.Location = New System.Drawing.Point(166, 5)
        Me.btnDeleteSea.Name = "btnDeleteSea"
        Me.btnDeleteSea.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteSea.TabIndex = 5
        Me.btnDeleteSea.Text = "Delete"
        Me.btnDeleteSea.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSeaName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSeaCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 76)
        Me.Panel1.TabIndex = 3
        '
        'txtSeaName
        '
        Me.txtSeaName.Location = New System.Drawing.Point(101, 38)
        Me.txtSeaName.MaxLength = 50
        Me.txtSeaName.Name = "txtSeaName"
        Me.txtSeaName.Size = New System.Drawing.Size(309, 20)
        Me.txtSeaName.TabIndex = 2
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
        'txtSeaCode
        '
        Me.txtSeaCode.Enabled = False
        Me.txtSeaCode.Location = New System.Drawing.Point(101, 12)
        Me.txtSeaCode.Name = "txtSeaCode"
        Me.txtSeaCode.Size = New System.Drawing.Size(133, 20)
        Me.txtSeaCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seaport Code"
        '
        'FrmDestination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 496)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDestination"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "3"
        Me.Text = "FrmDestination"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCountry.ResumeLayout(False)
        CType(Me.dgvCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabSeaPort.ResumeLayout(False)
        CType(Me.dgvSea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCountry As TabPage
    Friend WithEvents tabSeaPort As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtConName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnExitCon As Button
    Friend WithEvents btnAddCon As Button
    Friend WithEvents btnCancelCon As Button
    Friend WithEvents btnSaveCon As Button
    Friend WithEvents btnDeleteCon As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCariCon As TextBox
    Friend WithEvents cmbCariCon As ComboBox
    Friend WithEvents dgvCon As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExitSea As Button
    Friend WithEvents btnAddSea As Button
    Friend WithEvents btnCancelSea As Button
    Friend WithEvents btnSaveSea As Button
    Friend WithEvents btnDeleteSea As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSeaName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSeaCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCariSea As TextBox
    Friend WithEvents cmbCariSea As ComboBox
    Friend WithEvents dgvSea As DataGridView
End Class
