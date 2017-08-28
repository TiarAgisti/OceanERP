﻿Public Class FrmListPurchaseOrder
#Region "Declaration"
    Dim poNo As String
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim supplier As String
    Dim customer As String
#End Region
#Region "Function"
    Sub ClearData()
        txtPONo.Clear()
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
            dgv.Columns(0).HeaderText = "PO HeaderID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "PO Date"
            dgv.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(2).HeaderText = "PO No"
            dgv.Columns(3).HeaderText = "Customer Code"
            dgv.Columns(3).Visible = False
            dgv.Columns(4).HeaderText = "Customer Name"
            dgv.Columns(5).HeaderText = "Supplier Code"
            dgv.Columns(5).Visible = False
            dgv.Columns(6).HeaderText = "Supplier Name"
            dgv.Columns(7).HeaderText = "ShipViaMethod"
            dgv.Columns(8).HeaderText = "ShippingDate"
            dgv.Columns(8).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(9).HeaderText = "Term Of Payment"
            dgv.Columns(10).HeaderText = "Expected Receipt Date"
            dgv.Columns(10).DefaultCellStyle.Format = "dd-MMM-yyyy"
            dgv.Columns(11).HeaderText = "Customer ID"
            dgv.Columns(12).HeaderText = "Supplier ID"
            dgv.Columns(13).HeaderText = "Term Of Payment ID"
            dgv.Columns(13).Visible = False
            dgv.Columns(14).HeaderText = "Status"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ListData()
        If chkPONo.Checked = True Then
            poNo = txtPONo.Text
        Else
            poNo = ""
        End If

        If chkPIDate.Checked = True Then
            dateFrom = dtpDateFrom.Value
            dateTo = dtpDateTo.Value
        End If

        If chkSupplier.Checked = True Then
            supplier = txtSupplier.Text
        Else
            supplier = ""
        End If



        Dim poBFC As ClsPO = New ClsPO
        dgv.DataSource = poBFC.RetrieveListPurchaseOrder(poNo, dateFrom, dateTo, customer, supplier)
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
            Dim frm As FrmPurchaseOrder = New FrmPurchaseOrder
            frm.condition = "Create"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmPurchaseOrder = New FrmPurchaseOrder
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

    Private Sub FrmListPurchaseOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        PreCreateDisplay()
        Text = title
    End Sub

    Private Sub FrmListPurchaseOrder_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ListData()
    End Sub


#End Region

End Class