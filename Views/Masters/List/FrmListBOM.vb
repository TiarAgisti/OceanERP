Public Class FrmListBOM
#Region "Declaration"
    Dim fabricName As String
    Dim styleName As String
    Dim colorName As String
    Dim status As String
#End Region

#Region "Function"
    Public Sub ClearData()
        fabricName = ""
        styleName = ""
        colorName = ""
        status = ""
        txtFabric.Clear()
        txtStyle.Clear()
        txtColor.Clear()
        cmbStatus.Text = ""
        ckFabric.Checked = False
        ckStyle.Checked = False
        ckColor.Checked = False
        ckStatus.Checked = False
    End Sub

    Public Sub PopulateStatus()
        Dim bomBFC As ClsBOM = New ClsBOM
        bomBFC.ComboBoxStatus(cmbStatus)
    End Sub

    Public Sub PropertiesGrid()
        dgv.Columns(0).HeaderText = "BOMHeaderID"
        dgv.Columns(0).Visible = False

        dgv.Columns(1).HeaderText = "BOM Code"
        dgv.Columns(2).HeaderText = "Fabric"
        dgv.Columns(3).HeaderText = "Composition"
        dgv.Columns(4).HeaderText = "Specification"
        dgv.Columns(5).HeaderText = "Vendor"
        dgv.Columns(6).HeaderText = "Style"
        dgv.Columns(7).HeaderText = "Color"
        dgv.Columns(8).HeaderText = "Status"

        dgv.Columns(9).HeaderText = "FabricID"
        dgv.Columns(9).Visible = False

        dgv.Columns(10).HeaderText = "BuyerID"
        dgv.Columns(10).Visible = False

        dgv.Columns(11).HeaderText = "StyleID"
        dgv.Columns(11).Visible = False

        dgv.Columns(12).HeaderText = "ColorID"
        dgv.Columns(12).Visible = False

        dgv.Columns(13).HeaderText = "StatusBOM"
        dgv.Columns(13).Visible = False
    End Sub

    Public Sub ListData()
        If ckFabric.Checked = True Then
            fabricName = txtFabric.Text
        ElseIf ckFabric.Checked = False Then
            fabricName = ""
        End If

        If ckStyle.Checked = True Then
            styleName = txtStyle.Text
        ElseIf ckStyle.Checked = False Then
            styleName = ""
        End If

        If ckColor.Checked = True Then
            colorName = txtColor.Text
        ElseIf ckColor.Checked = False Then
            colorName = ""
        End If

        If ckStatus.Checked = True Then
            status = cmbStatus.Text
        ElseIf ckStatus.Checked = False Then
            status = ""
        End If


        Dim bomBFC As ClsBOM = New ClsBOM
        Try
            dgv.DataSource = bomBFC.RetrieveListBOM(Trim(fabricName), Trim(styleName), Trim(colorName), Trim(status))
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then btnAdd.Enabled = True
        If roleModel.IsUpdate = True Then btnView.Enabled = True
        If roleModel.IsDelete = True Then btnView.Enabled = True
    End Sub

    Public Sub PreDisplayList()
        ClearData()
        ListData()
        PopulateStatus()
    End Sub

    Function GetID() As Long
        Dim row As Integer
        Dim headerID As Long
        If dgv.Rows.Count > 1 Then
            row = dgv.CurrentRow.Index
            headerID = dgv.Item(0, row).Value
        Else
            Throw New Exception("No data available")
        End If
        Return headerID
    End Function
#End Region

#Region "Button"
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If ckFabric.Checked = True Then
            If txtFabric.Text = "" Then
                MsgBoxWarning("Fabric can't empty")
                Exit Sub
            End If
        End If

        If ckStyle.Checked = True Then
            If txtStyle.Text = "" Then
                MsgBoxWarning("Style can't empty")
                Exit Sub
            End If
        End If

        If ckColor.Checked = True Then
            If txtColor.Text = "" Then
                MsgBoxWarning("Color can't empty")
                Exit Sub
            End If
        End If

        If ckStatus.Checked = True Then
            If cmbStatus.Text = "" Then
                MsgBoxWarning("Status must choise")
                Exit Sub
            End If
        End If

        Try
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As FrmBillOfMaterial = New FrmBillOfMaterial
            frm.conditionBOM = "Create"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmBillOfMaterial = New FrmBillOfMaterial
            frm.conditionBOM = "Update"
            FrmBillOfMaterial.bomHeaderID = GetID()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ClearData()
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
#End Region

#Region "Other"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        CheckPermissions()
        PreDisplayList()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub cmbStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbStatus.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub FrmListBOM_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region
End Class