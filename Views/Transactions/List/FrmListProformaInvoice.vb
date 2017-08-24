Public Class FrmListProformaInvoice
#Region "Declaration"
    Dim piNo As String
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim customer As String
    Dim refPO As String
#End Region

#Region "Function"
    Sub ClearData()
        txtPINo.Clear()
        txtCustomer.Clear()
        txtRefPO.Clear()
    End Sub
    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then btnAdd.Enabled = True
        If roleModel.IsUpdate = True Then btnView.Enabled = True
        If roleModel.IsDelete = True Then btnView.Enabled = True
    End Sub

    Sub PropertiesGrid()
        Try
            dgv.Columns(0).HeaderText = "PI HeaderID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "PI Date"
            dgv.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(2).HeaderText = "PI No"

            dgv.Columns(3).HeaderText = "Customer Code"
            dgv.Columns(3).Visible = False

            dgv.Columns(4).HeaderText = "Customer"
            dgv.Columns(5).HeaderText = "Buyer"
            dgv.Columns(6).HeaderText = "Ref PO"
            dgv.Columns(7).HeaderText = "Style"
            dgv.Columns(8).HeaderText = "Season"
            dgv.Columns(9).HeaderText = "Term Of Payment"

            dgv.Columns(10).HeaderText = "Del Term"
            dgv.Columns(10).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(11).HeaderText = "Term Of Price"

            dgv.Columns(12).HeaderText = "CustomerID"
            dgv.Columns(12).Visible = False

            dgv.Columns(13).HeaderText = "BuyerID"
            dgv.Columns(13).Visible = False

            dgv.Columns(14).HeaderText = "StyleID"
            dgv.Columns(14).Visible = False

            dgv.Columns(15).HeaderText = "SeasonID"
            dgv.Columns(15).Visible = False

            dgv.Columns(16).HeaderText = "TermOfPaymentID"
            dgv.Columns(16).Visible = False

            dgv.Columns(17).HeaderText = "TermOfPriceID"
            dgv.Columns(17).Visible = False

            dgv.Columns(18).HeaderText = "Status"
            'dgv.Columns(18).Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ListData()
        If chkPINo.Checked = True Then
            piNo = txtPINo.Text
        Else
            piNo = ""
        End If

        If chkPIDate.Checked = True Then
            dateFrom = dtpDateFrom.Value
            dateTo = dtpDateTo.Value
        End If

        If chkCustomer.Checked = True Then
            customer = txtCustomer.Text
        Else
            customer = ""
        End If

        If chkRefPO.Checked = True Then
            refPO = txtRefPO.Text
        Else
            refPO = ""
        End If

        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        dgv.DataSource = piBFC.RetrieveListProformaInvoice(piNo, dateFrom, dateTo, customer, refPO)
        dgv.ReadOnly = True
        PropertiesGrid()
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
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As FrmProformaInvoice = New FrmProformaInvoice
            frm.condition = "Create"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmProformaInvoice = New FrmProformaInvoice
            frm.condition = "Update"
            FrmProformaInvoice.piHeaderID = GetID()
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

    Private Sub FrmListProformaInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
        Text = title
    End Sub

    Private Sub FrmListProformaInvoice_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ListData()
    End Sub

#End Region

#Region "Other"

#End Region
End Class