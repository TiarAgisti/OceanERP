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
        dgv.Columns(0).HeaderText = "PI HeaderID"
        dgv.Columns(0).Visible = False

        dgv.Columns(1).HeaderText = "PI Date"
        dgv.Columns(2).HeaderText = "PI No"

        dgv.Columns(3).HeaderText = "VendorCode"
        dgv.Columns(3).Visible = False

        dgv.Columns(4).HeaderText = "Customer"
        dgv.Columns(5).HeaderText = "Buyer"
        dgv.Columns(6).HeaderText = "Ref PO"
        dgv.Columns(7).HeaderText = "Style"
        dgv.Columns(8).HeaderText = "Season"
        dgv.Columns(9).HeaderText = "Term Of Payment"
        dgv.Columns(10).HeaderText = "Del Term"
        dgv.Columns(11).HeaderText = "Term Of Price"

        dgv.Columns(12).HeaderText = "VendorID"
        dgv.Columns(12).Visible = False

        dgv.Columns(13).HeaderText = "BuyerID"
        dgv.Columns(13).Visible = False

        dgv.Columns(14).HeaderText = "SeasonID"
        dgv.Columns(14).Visible = False

        dgv.Columns(15).HeaderText = "TermOfPaymentID"
        dgv.Columns(15).Visible = False

        dgv.Columns(16).HeaderText = "TermOfPriceID"
        dgv.Columns(16).Visible = False

        dgv.Columns(17).HeaderText = "Status"
        dgv.Columns(17).Visible = False
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

        Try
            Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
            dgv.DataSource = piBFC.RetrieveListProformaInvoice(piNo, dateFrom, dateTo, customer, refPO)
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub PreCreateDisplay()
        ClearData()
        ListData()
        CheckPermissions()
    End Sub
#End Region

#Region "Button"
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ListData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As FrmProformaInvoice = New FrmProformaInvoice
        frm.condition = "Create"
        frm.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ListData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub FrmListProformaInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
    End Sub

    Private Sub FrmListProformaInvoice_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ListData()
    End Sub

#End Region

#Region "Other"

#End Region
End Class