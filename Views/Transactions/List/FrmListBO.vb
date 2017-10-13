Public Class FrmListBO
#Region "Declaration"
    Dim noOrder As String
    Dim dateIssues As Date
    Dim customer As String
#End Region

#Region "Function"
    Sub ClearData()
        txtNoBon.Clear()
        txtCust.Clear()
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
            dgv.Columns(0).HeaderText = "BOID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "No Order/PI"
            dgv.Columns(1).Width = 175

            dgv.Columns(2).HeaderText = "Date Issues"
            dgv.Columns(2).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(2).Width = 100

            dgv.Columns(3).HeaderText = "Ref PO"
            dgv.Columns(3).Width = 180

            dgv.Columns(4).HeaderText = "Customer ID"
            dgv.Columns(4).Visible = False

            dgv.Columns(5).HeaderText = "Customer Name"
            dgv.Columns(5).Width = 275

            dgv.Columns(6).HeaderText = "BrandID"
            dgv.Columns(6).Visible = False

            dgv.Columns(7).HeaderText = "Brand"
            dgv.Columns(7).Width = 200

            dgv.Columns(8).HeaderText = "StyleID"
            dgv.Columns(8).Visible = False

            dgv.Columns(9).HeaderText = "Style"
            dgv.Columns(9).Width = 250

            dgv.Columns(10).HeaderText = "Status"
            dgv.Columns(10).Width = 250

            dgv.Columns(11).HeaderText = "StatusID"
            dgv.Columns(11).Width = 250
            dgv.Columns(11).Visible = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub ListData()
        Try
            If ckNoBon.Checked = True Then
                noOrder = txtNoBon.Text
            Else
                noOrder = ""
            End If

            If ckDateIssues.Checked = True Then
                dateIssues = dtpIssues.Value
            Else
                dateIssues = "1900-01-01"
            End If

            If ckCust.Checked = True Then
                customer = txtCust.Text
            Else
                customer = ""
            End If

            Dim boBFC As ClsBO = New ClsBO

            dgv.DataSource = boBFC.RetrieveListBon(Trim(noOrder), dateIssues, Trim(customer))
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
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
    Function GetStatus() As Int16
        Dim row As Integer
        Dim status As Int16
        If dgv.Rows.Count > 1 Then
            row = dgv.CurrentRow.Index
            status = dgv.Item(11, row).Value
        Else
            Throw New Exception("Error List Bon Order : No data available")
        End If
        Return status
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
            Dim frm As FrmBO = New FrmBO
            frm.conBon = "Create"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmBO = New FrmBO
            frm.conBon = "Update"
            FrmBO.boID = GetID()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As FrmBO = New FrmBO
            frm.conBon = "Update"
            FrmBO.boID = GetID()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub btnPI_Click(sender As Object, e As EventArgs) Handles btnPI.Click
        Try
            Dim frm As FrmPI = New FrmPI
            GetStatus()
            If GetStatus() <> "2" Then
                MsgBoxError("Can't Create PI, Bon Order Must Be Confirm ! ")
            Else
                frm.conBon = "Create PI"
                FrmPI.boID = GetID()
                frm.ShowDialog()
            End If

        Catch ex As Exception
            MsgBoxError("Error List Bon Order : " + ex.Message)
        End Try
    End Sub

#End Region
End Class