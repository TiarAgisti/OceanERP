Public Class FrmListBonOrder
#Region "Declaration"
    Dim noBonOrder As String
    Dim dateIssues As Date
    Dim piNo As String
    Dim customer As String
#End Region

#Region "Function"
    Sub ClearData()
        txtNoBon.Clear()
        txtCust.Clear()
        txtPINo.Clear()
    End Sub
    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        Try
            roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
            If roleModel.IsCreate = True Then btnAdd.Enabled = True
            If roleModel.IsUpdate = True Then btnView.Enabled = True
            If roleModel.IsDelete = True Then btnView.Enabled = True
        Catch ex As Exception
            Throw ex
        Finally
            roleBFC = Nothing
            roleModel = Nothing
        End Try
    End Sub
    Sub PropertiesGrid()
        Try
            dgv.Columns(0).HeaderText = "BonOrderID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "No. Bon Order"

            dgv.Columns(2).HeaderText = "Date Issues"
            dgv.Columns(2).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(3).HeaderText = "PI No"
            dgv.Columns(4).HeaderText = "PO No"
            dgv.Columns(5).HeaderText = "Brand / Buyer"
            dgv.Columns(6).HeaderText = "Fabric"
            dgv.Columns(7).HeaderText = "Customer"
            dgv.Columns(8).HeaderText = "Status"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ListData()
        If ckNoBon.Checked = True Then
            noBonOrder = txtNoBon.Text
        ElseIf ckNoBon.Checked = False Then
            noBonOrder = ""
        End If

        If ckDateIssues.Checked = True Then
            dateIssues = dtpIssues.Value
        ElseIf ckDateIssues.Checked = False Then
            dateIssues = "1900-01-01"
        End If

        If ckPINo.Checked = True Then
            piNo = txtPINo.Text
        ElseIf ckPINo.Checked = False Then
            piNo = ""
        End If

        If ckCust.Checked = True Then
            customer = txtCust.Text
        ElseIf ckCust.Checked = False Then
            customer = ""
        End If

        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Try
            dgv.DataSource = bonOrderBFC.RetrieveListBonOrder(Trim(noBonOrder), dateIssues, Trim(piNo), Trim(customer))
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            Throw ex
        Finally
            bonOrderBFC = Nothing
        End Try
    End Sub
    Function GetID() As Long
        Dim row As Integer
        Dim headerID As Long
        If dgv.Rows.Count > 1 Then
            row = dgv.CurrentRow.Index
            headerID = dgv.Item(0, row).Value
        Else
            Throw New Exception("Error List Bon Order : No data available")
        End If
        Return headerID
    End Function

    Sub PreCreateDisplay()
        Try
            ClearData()
            ListData()
            CheckPermissions()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Button"
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As FrmBonOrder = New FrmBonOrder
            frm.conBon = "Create"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmBonOrder = New FrmBonOrder
            frm.conBon = "Update"
            FrmBonOrder.bonOrderID = GetID()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
#End Region

#Region "Other"
    Private Sub FrmListBonOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PreCreateDisplay()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub FrmListBonOrder_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

#End Region
End Class