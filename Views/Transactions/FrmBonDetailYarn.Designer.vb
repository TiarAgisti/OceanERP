<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBonDetailYarn
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabProductName = New System.Windows.Forms.TabPage()
        Me.btnYarnDelList = New System.Windows.Forms.Button()
        Me.txtStockAV = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnYarnAddList = New System.Windows.Forms.Button()
        Me.dgvyarnmatrial = New System.Windows.Forms.DataGridView()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbYarn = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtfabric = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabProductName.SuspendLayout()
        CType(Me.dgvyarnmatrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabProductName)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 310)
        Me.TabControl1.TabIndex = 20
        '
        'TabProductName
        '
        Me.TabProductName.Controls.Add(Me.Label1)
        Me.TabProductName.Controls.Add(Me.txtfabric)
        Me.TabProductName.Controls.Add(Me.btnYarnDelList)
        Me.TabProductName.Controls.Add(Me.txtStockAV)
        Me.TabProductName.Controls.Add(Me.Label14)
        Me.TabProductName.Controls.Add(Me.cmbUnit)
        Me.TabProductName.Controls.Add(Me.Label31)
        Me.TabProductName.Controls.Add(Me.btnYarnAddList)
        Me.TabProductName.Controls.Add(Me.dgvyarnmatrial)
        Me.TabProductName.Controls.Add(Me.txtQty)
        Me.TabProductName.Controls.Add(Me.Label15)
        Me.TabProductName.Controls.Add(Me.cmbYarn)
        Me.TabProductName.Controls.Add(Me.Label20)
        Me.TabProductName.Location = New System.Drawing.Point(4, 22)
        Me.TabProductName.Name = "TabProductName"
        Me.TabProductName.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProductName.Size = New System.Drawing.Size(601, 284)
        Me.TabProductName.TabIndex = 0
        Me.TabProductName.Text = "Detail Yarn"
        Me.TabProductName.UseVisualStyleBackColor = True
        '
        'btnYarnDelList
        '
        Me.btnYarnDelList.Location = New System.Drawing.Point(470, 59)
        Me.btnYarnDelList.Name = "btnYarnDelList"
        Me.btnYarnDelList.Size = New System.Drawing.Size(120, 23)
        Me.btnYarnDelList.TabIndex = 138
        Me.btnYarnDelList.Text = "Delete From List"
        Me.btnYarnDelList.UseVisualStyleBackColor = True
        '
        'txtStockAV
        '
        Me.txtStockAV.Enabled = False
        Me.txtStockAV.Location = New System.Drawing.Point(113, 61)
        Me.txtStockAV.MaxLength = 50
        Me.txtStockAV.Name = "txtStockAV"
        Me.txtStockAV.Size = New System.Drawing.Size(188, 20)
        Me.txtStockAV.TabIndex = 136
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = " Available Stock"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(402, 7)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(188, 21)
        Me.cmbUnit.TabIndex = 135
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(317, 10)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 134
        Me.Label31.Text = "Unit"
        '
        'btnYarnAddList
        '
        Me.btnYarnAddList.Location = New System.Drawing.Point(350, 59)
        Me.btnYarnAddList.Name = "btnYarnAddList"
        Me.btnYarnAddList.Size = New System.Drawing.Size(114, 23)
        Me.btnYarnAddList.TabIndex = 113
        Me.btnYarnAddList.Text = "Add To List"
        Me.btnYarnAddList.UseVisualStyleBackColor = True
        '
        'dgvyarnmatrial
        '
        Me.dgvyarnmatrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvyarnmatrial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvyarnmatrial.Location = New System.Drawing.Point(10, 88)
        Me.dgvyarnmatrial.Name = "dgvyarnmatrial"
        Me.dgvyarnmatrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvyarnmatrial.Size = New System.Drawing.Size(580, 190)
        Me.dgvyarnmatrial.TabIndex = 112
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(402, 34)
        Me.txtQty.MaxLength = 50
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(188, 20)
        Me.txtQty.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(317, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Quantity"
        '
        'cmbYarn
        '
        Me.cmbYarn.FormattingEnabled = True
        Me.cmbYarn.Location = New System.Drawing.Point(113, 34)
        Me.cmbYarn.Name = "cmbYarn"
        Me.cmbYarn.Size = New System.Drawing.Size(188, 21)
        Me.cmbYarn.TabIndex = 102
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Yarn Name"
        '
        'txtfabric
        '
        Me.txtfabric.Enabled = False
        Me.txtfabric.Location = New System.Drawing.Point(113, 8)
        Me.txtfabric.MaxLength = 50
        Me.txtfabric.Name = "txtfabric"
        Me.txtfabric.Size = New System.Drawing.Size(188, 20)
        Me.txtfabric.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Fabric Details"
        '
        'FrmBonDetailYarn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 322)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmBonDetailYarn"
        Me.Text = "FrmBonDetailYarn"
        Me.TabControl1.ResumeLayout(False)
        Me.TabProductName.ResumeLayout(False)
        Me.TabProductName.PerformLayout()
        CType(Me.dgvyarnmatrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabProductName As TabPage
    Friend WithEvents btnYarnDelList As Button
    Friend WithEvents txtStockAV As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents btnYarnAddList As Button
    Friend WithEvents dgvyarnmatrial As DataGridView
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbYarn As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtfabric As TextBox
    Friend WithEvents Label1 As Label
End Class
