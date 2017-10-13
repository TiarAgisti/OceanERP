Public Class FrmListPI

#Region "Declaration"
    Dim piNo As String
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim customer As String
    Dim reffPO As String
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
            dgv.Columns(0).HeaderText = "BO ID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "Order.No"
            dgv.Columns(2).HeaderText = "Contract.No"
            dgv.Columns(3).HeaderText = "Date"
            dgv.Columns(3).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(4).HeaderText = "Del.Term"
            dgv.Columns(4).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(5).HeaderText = "Reff.PO"

            dgv.Columns(6).HeaderText = "Customer"
            dgv.Columns(6).Visible = False

            dgv.Columns(7).HeaderText = "Customer"
            dgv.Columns(7).Width = 150
            dgv.Columns(8).HeaderText = "Brand"
            dgv.Columns(9).HeaderText = "Style"
            dgv.Columns(9).Width = 150
            dgv.Columns(10).HeaderText = "Season"
            dgv.Columns(11).HeaderText = "Term Of Payment"
            dgv.Columns(11).Width = 150
            dgv.Columns(12).HeaderText = "Term Of Price"
            dgv.Columns(12).Width = 150

            dgv.Columns(13).HeaderText = "SeasonID"
            dgv.Columns(13).Visible = False

            dgv.Columns(14).HeaderText = "TermOfPaymentID"
            dgv.Columns(14).Visible = False

            dgv.Columns(15).HeaderText = "TermOfPriceID"
            dgv.Columns(15).Visible = False

            dgv.Columns(16).HeaderText = "Status"
            'dgv.Columns(18).Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ListData()
        If chkPINo.Checked = True Then
            piNo = txtPINo.Text
        ElseIf chkPINo.Checked = False Then
            piNo = ""
        End If

        If chkPIDate.Checked = True Then
            dateFrom = dtpDateFrom.Value
            dateTo = dtpDateTo.Value
        ElseIf chkPIDate.Checked = False Then
            dateFrom = "00:00:00"
            dateTo = "00:00:00"
        End If

        If chkCustomer.Checked = True Then
            customer = txtCustomer.Text
        ElseIf chkCustomer.Checked = False Then
            customer = ""
        End If

        If chkRefPO.Checked = True Then
            reffPO = txtRefPO.Text
        ElseIf chkRefPO.Checked = False Then
            reffPO = ""
        End If

        Dim piBFC As ClsPI = New ClsPI
        Try
            dgv.DataSource = piBFC.RetrieveListProformaInvoice(Trim(piNo), dateFrom, dateTo, Trim(customer), Trim(reffPO))
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            Throw ex
        Finally
            piBFC = Nothing
        End Try
    End Sub

    Function GetID() As Long
        Dim row As Integer
        Dim headerID As Long
        If dgv.Rows.Count > 1 Then
            row = dgv.CurrentRow.Index
            headerID = dgv.Item(0, row).Value
        Else
            Throw New Exception("Error List Proforma Invoice : No data available")
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
            MsgBoxError("Error List Proforma Invoice : " + ex.Message)
        End Try
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmPI = New FrmPI
            frm.conBon = "Update"
            FrmPI.boID = GetID()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError("Error List Proforma Invoice : " + ex.Message)
        End Try
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError("Error List Proforma Invoice : " + ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
#End Region

#Region "Other"
    Private Sub FrmListProformaInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PreCreateDisplay()
            Text = title
        Catch ex As Exception
            MsgBoxError("Error List Proforma Invoice : " + ex.Message)
        End Try
    End Sub

    Private Sub FrmListProformaInvoice_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError("Error List Proforma Invoice : " + ex.Message)
        End Try
    End Sub
#End Region

End Class