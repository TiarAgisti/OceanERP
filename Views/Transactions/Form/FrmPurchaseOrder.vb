﻿Imports System.ComponentModel

Public Class FrmPurchaseOrder
#Region "Declaration"
    Public Shared poHeaderID As Long = 0
    Public condition As String

    Dim intBarisRawMatrial As Integer
    Dim intPostRawMatrial As Integer
    Dim intBarisRemarks As Integer
    Dim intPostRemarks As Integer

    Dim customerCode As String = ""
    Dim supplierCode As String = ""
    Dim statusPO As Integer
#End Region

#Region "ComboBox"
    Sub ComboBoxSupplier()
        Dim vendorSupp As ClsVendor = New ClsVendor
        Dim status As String = "S"
        vendorSupp.ComboBoxVendor(cmbSupplier, status)
    End Sub

    Sub ComboBoxCustomer()
        Dim vendorCust As ClsVendor = New ClsVendor
        Dim status As String = "C"
        vendorCust.ComboBoxVendor(cmbCustomer, status)
    End Sub
    Sub ComboBoxRawMaterial()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        rawBFC.ComboBoxRawMaterial(cmbRawCode)
    End Sub

    Sub ComboBoxUnit()
        Dim unitRaw As ClsUnit = New ClsUnit
        unitRaw.ComboBoxUnit(cmbUnit)
    End Sub
    Sub ComboBoxTermOfPayment()
        Dim topBFC As ClsTermOfPayment = New ClsTermOfPayment
        topBFC.ComboBoxTOP(cmbTOP)
    End Sub
#End Region

#Region "Grid Detail"
    Sub GridDetailRawMatrial()
        With dgvrawmatrial
            .Columns.Add(0, "[Raw Material ID]")
            .Columns(0).Visible = False

            .Columns.Add(1, "Raw Material")

            .Columns.Add(2, "Unit ID")
            .Columns(2).Visible = False

            .Columns.Add(2, "Unit")
            .Columns.Add(3, "Quantity")
            .Columns.Add(4, "Unit Price")

        End With
    End Sub
    Sub GridDetailRemark()
        With dgvRemarks
            .Columns.Add(0, "Remarks")
            .Columns(0).Width = 250
        End With
    End Sub
#End Region

#Region "Clear Data"
    Sub ClearHeader()
        txtPONo.Text = AutoGenerated
        txtShipViaMethode.Clear()
        cmbSupplier.Text = ""
        txtCPSup.Clear()
        txtAddressSup.Clear()
        txtPhoneSup.Clear()
        txtFaxSup.Clear()
        txtEmailSup.Clear()
        cmbCustomer.Text = ""
        txtCPCust.Clear()
        txtAdressCust.Clear()
        txtPhoneCust.Clear()
        txtFaxCust.Clear()
        txtEmailCust.Clear()
        cmbTOP.Text = ""

        txtUnitPrice.Clear()
        txtQty.Text = 0
        txtTotal.Text = 0
        txtSubtotal.Text = 0
        txtDiscount.Text = 0
        txtVAT.Text = 0
        txtOtherCost.Text = 0
        txtSH.Text = 0
        txtGrandTotal.Text = 0
    End Sub

    Sub ClearRawMatrial()
        cmbRawCode.Text = ""
        txtRawMaterialName.Clear()
        cmbUnit.Text = ""
    End Sub
    Sub ClearRemarks()
        txtRemarks.Clear()
    End Sub


#End Region

#Region "Validation Number"
    Private Sub txtPhoneSup_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneSup.TextChanged
        CheckNumber(txtPhoneSup)
    End Sub

    Private Sub txtPhoneCust_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneCust.TextChanged
        CheckNumber(txtPhoneCust)
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        CheckNumber(txtQty)
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        CheckNumber(txtUnitPrice)
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        CheckNumber(txtDiscount)
    End Sub

    Private Sub txtVAT_TextChanged(sender As Object, e As EventArgs) Handles txtVAT.TextChanged
        CheckNumber(txtVAT)
    End Sub

    Private Sub txtOtherCost_TextChanged(sender As Object, e As EventArgs) Handles txtOtherCost.TextChanged
        CheckNumber(txtOtherCost)
    End Sub

    Private Sub txtSH_TextChanged(sender As Object, e As EventArgs) Handles txtSH.TextChanged
        CheckNumber(txtSH)
    End Sub

#End Region

#Region "Add Grid Detail"
    Sub AddGridDetailRawMatrial()
        With dgvrawmatrial
            .Rows.Add()
            .Item(0, intBarisRawMatrial).Value = cmbRawCode.SelectedValue
            .Item(1, intBarisRawMatrial).Value = cmbRawCode.Text
            .Item(2, intBarisRawMatrial).Value = txtRawMaterialName.Text
            .Item(3, intBarisRawMatrial).Value = cmbUnit.SelectedValue
            .Item(4, intBarisRawMatrial).Value = cmbUnit.Text
            .Item(5, intBarisRawMatrial).Value = txtUnitPrice.Text
            .Item(6, intBarisRawMatrial).Value = txtQty.Text
            .Item(7, intBarisRawMatrial).Value = txtTotal.Text

        End With
        intBarisRawMatrial = intBarisRawMatrial + 1
    End Sub
    Sub AddGridDetailRemarks()
        With dgvRemarks
            .Rows.Add()
            .Item(0, intBarisRemarks).Value = txtRemarks.Text
        End With
        intBarisRemarks = intBarisRemarks + 1
    End Sub
#End Region

#Region "Delete Grid"
    Sub DeleteGridDetailRawMatrial()
        DeleteGrid(dgvrawmatrial, intBarisRawMatrial)
    End Sub
    Sub DeleteGridDetailRemarks()
        DeleteGrid(dgvRemarks, intBarisRemarks)
    End Sub
#End Region

#Region "Check Empty"
    Function CheckEmptyHeader() As Boolean
        Dim check As Boolean = True
        If cmbCustomer.SelectedValue = 0 Then
            MsgBoxWarning("Customer not valid")
            cmbCustomer.Focus()
        ElseIf String.IsNullOrEmpty(Trim(txtShipViaMethode.Text)) Then
            MsgBoxWarning("Ship Via Methode can't empty")
            txtShipViaMethode.Focus()
        ElseIf cmbSupplier.SelectedValue = 0 Then
            MsgBoxWarning("Supplier not valid")
            cmbSupplier.Focus()

        ElseIf cmbTOP.SelectedValue = 0 Then
            MsgBoxWarning("Term Of Payment not valid")

        ElseIf dgvrawmatrial.Rows.Count - 1 = 0 Then
            MsgBoxWarning("Detail can't empty")
            cmbRawCode.Focus()
        ElseIf dgvRemarks.Rows.Count - 1 = 0 Then
            MsgBoxWarning("Remarks can't empty")
            txtRemarks.Focus()
        Else
            check = False
        End If
        Return check
    End Function
    Function CheckEmptyRawMatrial() As Boolean
        Dim check As Boolean = True
        If cmbRawCode.SelectedValue = 0 Then
            MsgBoxWarning("Raw Matrial not valid")
            cmbRawCode.Focus()
        ElseIf txtUnitPrice.Text = "" Then
            MsgBoxWarning("Unit Price Cant Empty")
            txtUnitPrice.Focus()
        ElseIf txtQty.Text = "" Then
            MsgBoxWarning("Qty Price Cant Empty")
            txtQty.Focus()
        ElseIf cmbUnit.SelectedValue = 0 Then
            MsgBoxWarning("Unit For raw Matrial not valid")
            cmbUnit.Focus()
        Else
            check = False
        End If
        Return check
    End Function
    Function CheckEmptyRemarks() As Boolean
        Dim check As Boolean = True
        If Trim(txtRemarks.Text) = String.Empty Then
            MsgBoxWarning("Remarks cant empty")
            txtRemarks.Focus()
        Else
            check = False
        End If
        Return check
    End Function
#End Region

#Region "Check Available In List"
    Function CheckRawMatrialInList() As Boolean
        Dim poBFC As ClsPO = New ClsPO
        Dim status As Boolean
        status = poBFC.CheckRawMatrialInList(dgvrawmatrial, cmbRawCode.SelectedValue)
        Return status
    End Function



    Function CheckRemarksInList() As Boolean
        Dim poBFC As ClsPO = New ClsPO
        Dim status As Boolean = True
        status = poBFC.CheckRemarksInList(dgvRemarks, txtRemarks.Text)
        Return status
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader() As POHeaderModel
        Dim headerModel As POHeaderModel = New POHeaderModel
        Dim poBFC As ClsPO = New ClsPO
        With headerModel
            Select Case condition
                Case "Create"
                    .POHeaderID = poBFC.GetPOHeaderID
                    poHeaderID = .POHeaderID
                    .PODate = Format(dtPODate.Value, "yyyy-MM-dd")
                    .PONo = poBFC.GetPONo(supplierCode)
                    txtPONo.Text = .PONo
                    .CustomerID = cmbCustomer.SelectedValue
                    .SupplierID = cmbSupplier.SelectedValue
                    .ShipViaMethod = txtShipViaMethode.Text
                    .ShippingDate = Format(dtSD.Value, "yyyy-MM-dd")
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .ExpectedReceiptDate = Format(dtERD.Value, "yyyy-MM-dd")
                    .Subtotal = txtSubtotal.Text
                    .Discount = txtDiscount.Text
                    .VATRate = txtVAT.Text
                    .OtherCost = txtOtherCost.Text
                    .SH = txtSH.Text
                    .GrandTotal = txtGrandTotal.Text
                    .Status = 1
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .POHeaderID = poBFC.GetPOHeaderID
                    poHeaderID = .POHeaderID
                    .PODate = Format(dtPODate.Value, "yyyy-MM-dd")
                    .PONo = poBFC.GetPONo(supplierCode)
                    txtPONo.Text = .PONo
                    .CustomerID = cmbCustomer.SelectedValue
                    .SupplierID = cmbSupplier.SelectedValue
                    .ShipViaMethod = txtShipViaMethode.Text
                    .ShippingDate = Format(dtSD.Value, "yyyy-MM-dd")
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .ExpectedReceiptDate = Format(dtERD.Value, "yyyy-MM-dd")
                    .Subtotal = txtSubtotal.Text
                    .Discount = txtDiscount.Text
                    .VATRate = txtVAT.Text
                    .OtherCost = txtOtherCost.Text
                    .SH = txtSH.Text
                    .GrandTotal = txtGrandTotal.Text
                    .Status = 1
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Approved"
                    .POHeaderID = poHeaderID
                    .PONo = txtPONo.Text
                    .Status = 2
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Void"
                    .POHeaderID = poHeaderID
                    .PONo = txtPONo.Text
                    .Status = 0
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return headerModel
    End Function

    Function SetDetailRawMatrial(poID As Long) As List(Of PODetailModel)
        Dim poBFC As ClsPO = New ClsPO
        Dim listModel As List(Of PODetailModel) = New List(Of PODetailModel)
        listModel = poBFC.SetDetailRawMatrial(poID, dgvrawmatrial)
        Return listModel
    End Function
    Function SetDetailRemarks(poID As Long) As List(Of PORemarksModel)
        Dim listModel As List(Of PORemarksModel) = New List(Of PORemarksModel)
        Dim poBFC As ClsPO = New ClsPO
        listModel = poBFC.SetDetailRemarks(poID, dgvRemarks)
        Return listModel
    End Function
#End Region

#Region "Function"
    Sub InsertData()
        Dim poBFC As ClsPO = New ClsPO
        Dim logpo As ClsLogHistory = New ClsLogHistory
        Dim myPONo As String = poBFC.GetPONo(supplierCode)
        Dim myPOID As Long = poBFC.GetPOHeaderID
        Dim logDesc As String = "Create new Purchase Order,PONo is " + myPONo

        Try
            If poBFC.InsertData(SetDataHeader, SetDetailRawMatrial(myPOID) _
                                , SetDetailRemarks(myPOID), logpo.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxSaved()
                CheckPermissions()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
                'PreCreatedisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateData()
        Dim poBFC As ClsPO = New ClsPO
        Dim logpo As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Purchase Order,Where PONo = " + txtPONo.Text
        Try
            If poBFC.UpdateData(SetDataHeader, SetDetailRawMatrial(poHeaderID) _
                                , SetDetailRemarks(poHeaderID), logpo.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxUpdated()
                CheckPermissions()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub ApprovedData()
        Dim poBFC As ClsPO = New ClsPO
        Dim logpo As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Approved Purchase Order where PONO = " + txtPONo.Text
        condition = "Approved"
        Try
            If poBFC.UpdateStatusHeader(SetDataHeader, logpo.SetLogHistoryTrans(logDesc)) Then
                MsgBoxApproved()
                PreCreatedisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub VoidData()
        Dim poBFC As ClsPO = New ClsPO
        Dim logpo As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Void Purchase Order where PONO = " + txtPONo.Text
        condition = "Void"
        Try
            If poBFC.UpdateStatusHeader(SetDataHeader, logpo.SetLogHistoryTrans(logDesc)) Then
                MsgBoxVoid()
                PreCreatedisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub PrintData()
        Try
            Dim poPrint As ClsPrintOut = New ClsPrintOut
            If poPrint.PrintOutProformaInvoice(txtPONo.Text) Then
                PreCreatedisplay()
            Else
                MsgBoxError("Failed to print")
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub ClearVariable()
        intBarisRawMatrial = 0
        intPostRawMatrial = 0
        intBarisRemarks = 0
        intPostRemarks = 0
    End Sub
    Sub ClearDataGrid()
        dgvrawmatrial.Columns.Clear()

        dgvRemarks.Columns.Clear()
    End Sub

    Sub ClearAllData()
        ClearVariable()
        ClearHeader()
        ClearRawMatrial()
        ClearRemarks()
    End Sub

    Sub GridDetailALL()
        GridDetailRawMatrial()

        GridDetailRemark()
    End Sub

    Sub ComboBoxALL()
        ComboBoxCustomer()
        ComboBoxRawMaterial()
        ComboBoxSupplier()
        ComboBoxUnit()
        ComboBoxTermOfPayment()
        ComboBoxUnit()

    End Sub


    Sub RetrieveSupplier()
        Dim vendorPoS As ClsVendor = New ClsVendor
        Dim vendorModel As VendorModel = New VendorModel
        Dim obj As Integer = cmbSupplier.SelectedValue
        If obj > 0 Then
            vendorModel = vendorPoS.RetrieveVendorByID(obj, "S")
            With vendorModel
                supplierCode = .VendorCode
                txtCPSup.Text = .ContactPerson
                txtAddressSup.Text = .Address
                txtPhoneSup.Text = .Telephone
                txtFaxSup.Text = .Fax
                txtEmailSup.Text = .EmailCP
            End With
        Else
            MsgBoxError("Supplier not valid")
        End If
    End Sub


    Sub RetrieveRawMatrial()
        Dim rawmatrialPo As ClsRawMaterial = New ClsRawMaterial
        Dim rawmatrialModel As RawMaterialModel = New RawMaterialModel
        Dim rawmatrialID As Integer = cmbRawCode.SelectedValue
        If rawmatrialID > 0 Then
            rawmatrialModel = rawmatrialPo.RetrieveByID(rawmatrialID)
            With rawmatrialModel
                txtRawMaterialName.Text = .RawMaterialName
            End With
        Else
            MsgBoxError("Raw Matrial Not Valid")
        End If
    End Sub
    Sub CheckPermissions()
        Try
            Dim rolepoC As ClsPermission = New ClsPermission
            Dim roleModel As RoleDModel = New RoleDModel
            roleModel = rolepoC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
            If roleModel.IsCreate = True Then btnSave.Enabled = True
            If roleModel.IsUpdate = True Then btnUpdate.Enabled = True
            If roleModel.IsApprove = True Then btnApprove.Enabled = True
            If roleModel.IsVoid = True Then btnVoid.Enabled = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub PrepareHeaderByID()
        ComboBoxALL()
        Dim headerModel As POHeaderModel = New POHeaderModel
        Dim poC As ClsPO = New ClsPO
        headerModel = poC.RetrieveByID(poHeaderID)
        With headerModel
            txtPONo.Text = .PONo
            dtPODate.Value = .PODate
            cmbCustomer.SelectedValue = .CustomerID
            cmbSupplier.SelectedValue = .SupplierID
            txtShipViaMethode.Text = .ShipViaMethod
            dtSD.Value = .ShippingDate
            cmbTOP.SelectedValue = .TermOfPaymentID
            dtERD.Value = .ExpectedReceiptDate
            txtSubtotal.Text = .Subtotal
            txtDiscount.Text = .Discount
            txtVAT.Text = .VATRate
            txtOtherCost.Text = .OtherCost
            txtSH.Text = .SH
            txtGrandTotal.Text = .GrandTotal
            statusPO = .Status
        End With
    End Sub

    Sub PrepareRawMatrialByHeaderID()
        Try
            GridDetailRawMatrial()
            Dim listRawMatrial As List(Of PODetailModel) = New List(Of PODetailModel)
            Dim poC As ClsPO = New ClsPO
            listRawMatrial = poC.RetrieveRawMaterialByHeaderID(poHeaderID)
            For Each detail In listRawMatrial
                With dgvrawmatrial
                    .Rows.Add()
                    .Item(0, intBarisRawMatrial).Value = detail.RawMaterialID
                    .Item(1, intBarisRawMatrial).Value = detail.RawMaterialName
                    .Item(2, intBarisRawMatrial).Value = detail.UnitID
                    .Item(3, intBarisRawMatrial).Value = detail.UnitName
                    .Item(4, intBarisRawMatrial).Value = detail.Quantity
                    .Item(5, intBarisRawMatrial).Value = detail.UnitPrice

                End With
                intBarisRawMatrial = intBarisRawMatrial + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PrepareRemarksByHeaderID()
        Try
            GridDetailRemark()
            Dim listRemarks As List(Of PORemarksModel) = New List(Of PORemarksModel)
            Dim poBFC As ClsPO = New ClsPO
            listRemarks = poBFC.RetrieveRemarksByHeaderID(poHeaderID)
            For Each detail In listRemarks
                With dgvRemarks
                    .Rows.Add()
                    .Item(0, intBarisRemarks).Value = detail.Remarks
                End With
                intBarisRemarks = intBarisRemarks + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub PreCreatedisplay()
        CheckPermissions()
        ClearDataGrid()
        ClearAllData()
        GridDetailALL()
        ComboBoxALL()
        txtShipViaMethode.Focus()
        txtShipViaMethode.Enabled = True
        btnApprove.Enabled = False
        btnVoid.Enabled = False
        btnPrint.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Sub PreUpdateDisplay()
        Try
            ClearAllData()
            ClearDataGrid()
            CheckPermissions()
            PrepareHeaderByID()
            PrepareRawMatrialByHeaderID()

            PrepareRemarksByHeaderID()
            If statusPO = 0 Then btnPrint.Enabled = False Else btnPrint.Enabled = True
            If statusPO = 0 Or statusPO = 2 Then btnApprove.Enabled = False
            If statusPO = 0 Then btnVoid.Enabled = False
            btnSave.Enabled = False
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub FrmPurchaseOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case condition
            Case "Create"
                PreCreatedisplay()
            Case "Update"
                PreUpdateDisplay()
        End Select
        Text = title
    End Sub
#End Region

#Region "Button"
    Private Sub btnRemAddList_Click(sender As Object, e As EventArgs) Handles btnRemAddList.Click
        If CheckEmptyRemarks() = False Then
            Try
                If CheckRemarksInList() = True Then
                    AddGridDetailRemarks()
                    ClearRemarks()
                Else
                    MsgBoxError("Remarks available in list")
                End If
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRemDelList_Click(sender As Object, e As EventArgs) Handles btnRemDelList.Click
        Try
            DeleteGridDetailRemarks()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckEmptyHeader() = False And CheckEmptyRawMatrial() = False Then
            If condition = "Update" Then
                UpdateData()
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        ApprovedData()
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        VoidData()
    End Sub

    Private Sub btnRawAddList_Click(sender As Object, e As EventArgs) Handles btnRawAddList.Click
        If CheckEmptyRawMatrial() = False Then
            Try
                If CheckRawMatrialInList() = True Then
                    AddGridDetailRawMatrial()
                    ClearRawMatrial()
                Else
                    MsgBoxError("Raw Matrial available in list")
                    ClearRawMatrial()
                End If
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRawDelList_Click(sender As Object, e As EventArgs) Handles btnRawDelList.Click
        Try
            DeleteGridDetailRawMatrial()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmptyHeader() = False And CheckEmptyRawMatrial() = False Then
            If condition = "Create" Then
                InsertData()
            End If
        End If
    End Sub
#End Region
#Region "Row State Change"
    Private Sub dgvRemarks_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvRemarks.RowStateChanged
        intPostRemarks = e.Row.Index
    End Sub

    Private Sub dgvrawmatrial_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvrawmatrial.RowStateChanged
        intPostRawMatrial = e.Row.Index
    End Sub



    Private Sub cmbSupplier_Validating(sender As Object, e As CancelEventArgs) Handles cmbSupplier.Validating
        Try
            RetrieveSupplier()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

End Class