Public Class FrmListBPB
#Region "Declaration"
    Dim bpbNo As String
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim supplier As String
#End Region

#Region "Function"
    Sub ClearData()
        txtBPBNo.Clear()
        txtSupplier.Clear()
    End Sub
    Sub CheckPermissions()
        Dim rolepoC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = rolepoC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then btnAdd.Enabled = True
        If roleModel.IsUpdate = True Then btnView.Enabled = True
        If roleModel.IsDelete = True Then btnView.Enabled = True
    End Sub

    Sub PropertiesGrid()
        Try
            dgv.Columns(0).HeaderText = "BPB HeaderID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "BPBNo"


            dgv.Columns(2).HeaderText = "BPB Date"
            dgv.Columns(2).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(3).HeaderText = "In Factory Date"
            dgv.Columns(3).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(3).Width = 160

            dgv.Columns(4).HeaderText = "Do.No"


            dgv.Columns(5).HeaderText = "Doc.Type Customs"
            dgv.Columns(5).Width = 160

            dgv.Columns(6).HeaderText = "Doc.No Customs"
            dgv.Columns(6).Width = 160

            dgv.Columns(7).HeaderText = "Doc.Registration Date"
            dgv.Columns(7).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(7).Width = 160
            dgv.Columns(8).HeaderText = "PO Header ID"
            dgv.Columns(8).Visible = False

            dgv.Columns(9).HeaderText = "PO No"
            dgv.Columns(9).Width = 160

            dgv.Columns(10).HeaderText = "Supplier ID"
            dgv.Columns(10).Visible = False

            dgv.Columns(11).HeaderText = "Supplier Code"
            dgv.Columns(11).Visible = False

            dgv.Columns(12).HeaderText = "Supplier Name"
            dgv.Columns(12).Width = 160

            dgv.Columns(13).HeaderText = "Status"


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ListData()
        Try
            If chkBPBDate.Checked = True Then
                bpbNo = txtBPBNo.Text
            Else
                bpbNo = ""
            End If

            If chkBPBDate.Checked = True Then
                dateFrom = dtpDateFrom.Value
                dateTo = dtpDateTo.Value
            End If

            If chkSupplier.Checked = True Then
                supplier = txtSupplier.Text
            Else
                supplier = ""
            End If
            Dim bpbBFC As ClsBPB = New ClsBPB
            dgv.DataSource = bpbBFC.RetrieveListBPB(Trim(bpbNo), dateFrom, dateTo, Trim(supplier))
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception

        End Try

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

    Sub PreCreateDisplay()
        Try
            ClearData()
            ListData()
            CheckPermissions()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Button"


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmBPB = New FrmBPB
            frm.condition = "Update"
            FrmPurchaseOrder.poHeaderID = GetID()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub FrmListBPB_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ListData()
    End Sub
    Private Sub FrmListBPB_Load(sender As Object, e As EventArgs) Handles Me.Load
        PreCreateDisplay()
        ' Text = title

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As FrmBPB = New FrmBPB
            frm.condition = "Create"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub



#End Region

End Class