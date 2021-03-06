﻿Public Class FrmPlaning

#Region "Declaration"
    Dim poNo As String
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim supplier As String
    Dim customer As String
    Dim col_update As New DataGridViewButtonColumn
    Dim col_BPB As New DataGridViewButtonColumn


#End Region

#Region "Function"
    Sub ListColor(myOptions As String, myParam As String)
        Try
            Dim poBFC As ClsPO = New ClsPO
            With dgv
                .DataSource = poBFC.Retrievepo(myOptions, myParam)
            End With
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub PreCreateDisplay()
        Try
            ClearData()
            listdata()
            CheckPermissions()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub CheckPermissions()
        Dim rolepoC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = rolepoC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then btnAdd.Enabled = True
        If roleModel.IsUpdate = True Then btnView.Enabled = True
        If roleModel.IsDelete = True Then btnView.Enabled = True
    End Sub

    Sub ClearData()
        txtPONo.Clear()
        ' txtPINo.Clear()
        txtSupplierName.Clear()
        txtTOP.Clear()
        txtSVM.Clear()
    End Sub
    Sub PropertiesGrid()
        Try
            dgv.Columns(0).HeaderText = "PO HeaderID"
            dgv.Columns(0).Visible = False

            dgv.Columns(1).HeaderText = "Currency"
            dgv.Columns(1).Visible = False

            dgv.Columns(2).HeaderText = "Currency Code"
            dgv.Columns(2).Width = 140
            dgv.Columns(2).Visible = False

            dgv.Columns(3).HeaderText = "PO Date"
            dgv.Columns(3).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(4).HeaderText = "PO No"
            dgv.Columns(4).Width = 210

            dgv.Columns(5).HeaderText = "Customer Code"
            dgv.Columns(5).Visible = False

            dgv.Columns(6).HeaderText = "Customer Name"
            dgv.Columns(6).Width = 150

            dgv.Columns(7).HeaderText = "Supplier Code"
            dgv.Columns(7).Visible = False

            dgv.Columns(8).HeaderText = "Supplier Name"
            dgv.Columns(8).Width = 150

            dgv.Columns(9).HeaderText = "Ship Via Method Code"
            dgv.Columns(9).Visible = False

            dgv.Columns(10).HeaderText = "Ship Via Method"
            dgv.Columns(10).Width = 150

            dgv.Columns(11).HeaderText = "Shipping Date"
            dgv.Columns(11).Width = 150
            dgv.Columns(11).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(12).HeaderText = "Term Of Payment"
            dgv.Columns(12).Width = 150

            dgv.Columns(13).HeaderText = "Expected Receipt Date"
            dgv.Columns(13).Width = 150
            dgv.Columns(13).DefaultCellStyle.Format = "dd-MMM-yyyy"

            dgv.Columns(14).HeaderText = "Customer ID"
            dgv.Columns(14).Visible = False

            dgv.Columns(15).HeaderText = "Supplier ID"
            dgv.Columns(15).Visible = False

            dgv.Columns(16).HeaderText = "Shiv Via Method ID"
            dgv.Columns(16).Visible = False

            dgv.Columns(17).HeaderText = "Term Of Payment ID"
            dgv.Columns(17).Visible = False

            dgv.Columns(18).HeaderText = "Status"

            'dgv.Columns.Add(col_update)
            'col_update.HeaderText = "Update Receipt Date"
            'col_update.Text = "PO"
            'col_update.Name = "btn"
            'col_update.Width = 150
            'col_update.UseColumnTextForButtonValue = True


            'dgv.Columns.Add(col_BPB)
            'col_BPB.HeaderText = "Input BPB"
            'col_BPB.Text = "BPB"
            'col_BPB.Name = "btn"
            'col_BPB.Width = 150
            'col_BPB.UseColumnTextForButtonValue = True

        Catch ex As Exception
            Throw ex
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
    Sub listdata()
        Dim poBFC As ClsPO = New ClsPO
        dgv.DataSource = poBFC.RetrieveListPurchaseOrder(Trim(poNo), dateFrom, dateTo, customer, supplier)
        dgv.ReadOnly = True
        PropertiesGrid()
    End Sub
    Private Sub FrmRMPlaning_Load(sender As Object, e As EventArgs) Handles Me.Load
        PreCreateDisplay()
        Text = title
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        With dgv
            Dim row As Integer = .CurrentRow.Index
            If IsDBNull(Me.dgv.CurrentRow.Cells(0).Value) Then

            Else
                txtPONo.Text = .Item(4, row).Value
                txtPINo.Text = .Item(2, row).Value
                txtSupplierName.Text = .Item(8, row).Value
                txtSVM.Text = .Item(10, row).Value
                dtSD.Value = .Item(11, row).Value
                txtTOP.Text = .Item(12, row).Value
                dtERD.Value = .Item(13, row).Value
            End If
        End With
    End Sub
#End Region

#Region "Methode Update"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As FrmPurchaseOrder = New FrmPurchaseOrder
            frm.condition = "Update"
            FrmPurchaseOrder.poHeaderID = GetID()
            frm.dtPODate.Enabled = False
            frm.cmbSVM.Enabled = False
            frm.dtSD.Enabled = False
            frm.cmbTOP.Enabled = False
            frm.cmbCurrency.Enabled = False
            frm.cmbSupplier.Enabled = False
            frm.cmbPINO.Enabled = False
            frm.cmbYarnCode.Enabled = False
            frm.cmbUnit.Enabled = False
            frm.txtUnitPrice.Enabled = False
            frm.txtQty.Enabled = False
            frm.cmbUnit.Enabled = False
            frm.txtDiscount.Enabled = False
            frm.txtSH.Enabled = False
            frm.txtOtherCost.Enabled = False
            frm.btnYarnAddList.Enabled = False
            frm.btnYarnDelList.Enabled = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim frm As FrmBPB = New FrmBPB
            ' frm.condition = "Create"
            ' FrmBPB.poHeaderID = GetID()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            listdata()
            ClearData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If cmbCari.SelectedValue = 0 Then
            MsgBoxWarning("Please choice yourcCriteria !")
            cmbCari.Focus()
            txtCari.Clear()
        Else
            ListColor(cmbCari.Text, txtCari.Text)
        End If
    End Sub
#End Region

End Class