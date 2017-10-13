﻿Imports System.ComponentModel

Public Class FrmPurchaseOrder

#Region "Declaration"
    Public Shared poHeaderID As Long = 0
    Public condition As String

    Dim intBarisRawMatrial As Integer
    Dim intPostRawMatrial As Integer
    Dim intBarisRemarks As Integer
    Dim intPostRemarks As Integer
    Dim hasil As Integer
    Dim customerCode As String = ""

    Dim supplierCode As String = ""
    Dim rawmatrialCode As String = ""
    Dim statusPO As Integer
#End Region

#Region "ComboBox"
    Sub ComboBoxPI()
        Dim piBFC As ClsPI = New ClsPI
        piBFC.ComboBoxPI(cmbPINO)
    End Sub
    Sub ComboBoxSupplier()
        Dim suppBFC As ClsVendor = New ClsVendor
        Dim status As String = "S"
        suppBFC.ComboBoxVendor(cmbSupplier, status)
    End Sub

    Sub ComboBoxRawMaterial()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        rawBFC.ComboBoxRawMaterial(cmbYarnCode)
    End Sub
    Sub ComboBoxYarn(cmb As ComboBox, headerID As Long)
        Dim poBFC As ClsPO = New ClsPO

        Try
            poBFC.ComboBoxYarn(cmbYarnCode, headerID)
        Catch ex As Exception
            Throw ex
        Finally
            poBFC = Nothing
        End Try
    End Sub
    Sub ComboBoxShipViaMethod()
        Dim svmBFC As ClsShipViaMethod = New ClsShipViaMethod
        svmBFC.ComboBoxShipViaMethod(cmbSVM)
    End Sub

    Sub ComboBoxUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        unitBFC.ComboBoxUnit(cmbUnit)
    End Sub
    Sub ComboBoxCurrency()
        Dim CurrBFC As ClsCurrency = New ClsCurrency
        CurrBFC.ComboBoxCurrency(cmbCurrency)
    End Sub
    Sub ComboBoxTermOfPayment()
        Dim topBFC As ClsTermOfPayment = New ClsTermOfPayment
        topBFC.ComboBoxTOP(cmbTOP)
    End Sub
#End Region

#Region "Grid Detail"
    Sub GridDetailRawMatrial()
        With dgvrawmatrial
            .Columns.Add(0, "Yarn ID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Yarn")

            .Columns.Add(2, "Unit ID")
            .Columns(2).Visible = False

            .Columns.Add(3, "Unit")
            .Columns.Add(4, "Unit Price")
            .Columns.Add(5, "Quantity")
            .Columns.Add(6, "Total")

            .Columns.Add(7, "PI Header ID")
            .Columns(7).Visible = False

            .Columns.Add(8, "PI NO")

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
        cmbCurrency.Text = ""
        cmbSupplier.Text = ""
        cmbSVM.Text = ""
        txtCPSup.Clear()
        txtAddressSup.Clear()
        txtPhoneSup.Clear()
        txtFaxSup.Clear()
        txtEmailSup.Clear()
        cmbTOP.Text = ""
        txtUnitPrice.Text = 0
        txtQty.Text = 0
        txtTotal.Text = 0
        txtSubtotal.Text = 0
        txtDiscount.Text = 0
        txtVAT.Text = 0
        txtOtherCost.Text = 0
        txtSH.Text = 0
        txtGrandTotal.Text = 0
        'txtShipViaMethode.Focus()

    End Sub

    Sub ClearYarn()
        cmbYarnCode.Text = ""
        cmbUnit.Text = ""
        txtUnitPrice.Clear()
        txtQty.Clear()
        txtTotal.Clear()
        cmbPINO.Text = ""
    End Sub
    Sub ClearRemarks()
        txtRemarks.Clear()
    End Sub


#End Region

#Region "Validation Number"
    Private Sub txtPhoneSup_TextChanged(sender As Object, e As EventArgs)
        CheckNumber(txtPhoneSup)
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        CheckNumber(txtQty)
        CalculateTotal()
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        CheckNumber(txtUnitPrice)
        CalculateTotal()
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        CheckNumber(txtDiscount)
        CalculateDiscount()
    End Sub

    Private Sub txtVAT_TextChanged(sender As Object, e As EventArgs) Handles txtVAT.TextChanged
        CheckNumber(txtVAT)
    End Sub

    Private Sub txtOtherCost_TextChanged(sender As Object, e As EventArgs) Handles txtOtherCost.TextChanged
        CheckNumber(txtOtherCost)
        CalculateOtherCost()
    End Sub

    Private Sub txtSH_TextChanged(sender As Object, e As EventArgs) Handles txtSH.TextChanged
        CheckNumber(txtSH)
        CalculateSH()
    End Sub

#End Region

#Region "Add Grid Detail"
    Public Sub SumSubTotalValue()
        Dim subtotalval As Double
        subtotalval = 0
        For i As Integer = 0 To dgvrawmatrial.Rows.Count - 1
            subtotalval = subtotalval + Val(dgvrawmatrial.Rows(i).Cells(6).Value)
            '-----------cell 6 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        txtSubtotal.Text = subtotalval
        txtVAT.Text = Val(txtSubtotal.Text) * 0.1
        txtGrandTotal.Text = Val(txtSubtotal.Text) + Val(txtVAT.Text)
    End Sub
    Sub CalculateDiscount()
        txtGrandTotal.Text = Val(txtSubtotal.Text) - Val(txtDiscount.Text) + Val(txtVAT.Text)
    End Sub
    Sub CalculateTotal()
        txtTotal.Text = Val(txtQty.Text) * Val(txtUnitPrice.Text)
    End Sub
    Sub CalculateOtherCost()
        txtGrandTotal.Text = Val(txtSubtotal.Text) - Val(txtDiscount.Text) + Val(txtVAT.Text) + Val(txtOtherCost.Text)
    End Sub
    Sub CalculateSH()
        txtGrandTotal.Text = Val(txtSubtotal.Text) - Val(txtDiscount.Text) + Val(txtVAT.Text) + Val(txtOtherCost.Text) + Val(txtSH.Text)
    End Sub
    Sub AddGridDetailYarn()
        With dgvrawmatrial
            .Rows.Add()
            .Item(0, intBarisRawMatrial).Value = cmbYarnCode.SelectedValue
            .Item(1, intBarisRawMatrial).Value = cmbYarnCode.Text
            .Item(2, intBarisRawMatrial).Value = cmbUnit.SelectedValue
            .Item(3, intBarisRawMatrial).Value = cmbUnit.Text
            .Item(4, intBarisRawMatrial).Value = txtUnitPrice.Text
            .Item(5, intBarisRawMatrial).Value = txtQty.Text
            .Item(6, intBarisRawMatrial).Value = txtTotal.Text
            .Item(7, intBarisRawMatrial).Value = cmbPINO.SelectedValue
            .Item(8, intBarisRawMatrial).Value = cmbPINO.Text
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
    Sub DeleteGridDetailYarn()
        DeleteGrid(dgvrawmatrial)
        intBarisRawMatrial = intBarisRawMatrial - 1
    End Sub

    Sub DeleteGridDetailRemarks()
        DeleteGrid(dgvRemarks)
        intBarisRemarks = intBarisRemarks - 1
    End Sub
#End Region

#Region "Check Empty"
    Function CheckEmptyHeader() As Boolean
        Dim check As Boolean = True
        If cmbCurrency.SelectedValue = 0 Then
            MsgBoxWarning("Currency Not Valid")
            cmbCurrency.Focus()
        ElseIf cmbSupplier.SelectedValue = 0 Then
            MsgBoxWarning("Supplier Not Valid")
            cmbSupplier.Focus()
        ElseIf cmbSVM.SelectedValue = 0 Then
            MsgBoxWarning("Ship Via Method Not Valid")
            cmbSVM.Focus()
        ElseIf cmbTOP.SelectedValue = 0 Then
            MsgBoxWarning("Term Of Payment Not Valid")
            cmbTOP.Focus()
        ElseIf dgvrawmatrial.Rows.Count - 1 = 0 Then
            MsgBoxWarning("Detail Can't Empty")
            cmbYarnCode.Focus()
        ElseIf dgvRemarks.Rows.Count - 1 = 0 Then
            MsgBoxWarning("Remarks Can't Empty")
            txtRemarks.Focus()
        Else
            check = False
        End If
        Return check
    End Function
    Function CheckEmptyYarn() As Boolean
        Dim check As Boolean = True
        If cmbYarnCode.SelectedValue = 0 Then
            MsgBoxWarning("Yarn Not Valid")
            cmbYarnCode.Focus()
        ElseIf txtUnitPrice.Text = "" Then
            MsgBoxWarning("Unit Price Can't Empty")
            txtUnitPrice.Focus()
        ElseIf txtQty.Text = "" Then
            MsgBoxWarning("Qty Price Can't Empty")
            txtQty.Focus()
        ElseIf cmbUnit.SelectedValue = 0 Then
            MsgBoxWarning("Unit For Raw Matrial Not Valid")
            cmbUnit.Focus()
        Else
            check = False
        End If
        Return check
    End Function
    Function CheckEmptyRemarks() As Boolean
        Dim check As Boolean = True
        If Trim(txtRemarks.Text) = String.Empty Then
            MsgBoxWarning("Remarks Can't Empty")
            txtRemarks.Focus()
        Else
            check = False
        End If
        Return check
    End Function
#End Region

#Region "Check Available In List"
    Function CheckYarnInList() As Boolean
        Dim poBFC As ClsPO = New ClsPO
        Dim status As Boolean
        status = poBFC.CheckYarnInList(dgvrawmatrial, cmbYarnCode.SelectedValue)
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
                    .POHeaderID = .POHeaderID
                    .CurrencyID = cmbCurrency.SelectedValue
                    .PODate = Format(dtPODate.Value, "yyyy-MM-dd")
                    .PONo = poBFC.GetPONo()
                    txtPONo.Text = .PONo
                    .SupplierID = cmbSupplier.SelectedValue
                    .ShipViaMethodID = cmbSVM.SelectedValue
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
                    .POHeaderID = poHeaderID
                    '.PIHeaderID = cmbPINO.SelectedValue
                    .CurrencyID = cmbCurrency.SelectedValue
                    .PODate = Format(dtPODate.Value, "yyyy-MM-dd")
                    txtPONo.Text = .PONo
                    .SupplierID = cmbSupplier.SelectedValue
                    .ShipViaMethodID = cmbSVM.SelectedValue
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
        Dim myPONo As String = poBFC.GetPONo()
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
            If poPrint.PrintOutPurchaseOrder(txtPONo.Text) Then
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
        ClearYarn()
        ClearRemarks()
    End Sub

    Sub GridDetailALL()
        GridDetailRawMatrial()

        GridDetailRemark()
    End Sub

    Sub ComboBoxALL()
        ComboBoxSupplier()
        ComboBoxUnit()
        ComboBoxCurrency()
        ComboBoxTermOfPayment()
        ComboBoxShipViaMethod()
        ComboBoxPI()
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
    Sub RetrieveQtyStock()
        Dim stkBFC As ClsStock = New ClsStock
        Dim bpbModel As StockModel = New StockModel
        Try

            Dim rawmatrialID As String = cmbYarnCode.SelectedValue
            If rawmatrialID > 0 Then
                bpbModel = stkBFC.RetrieveRawMaterialStock(rawmatrialID)
                With bpbModel
                    txtStockAV.Text = .QuantityStock
                End With
                Exit Sub
            Else
                MsgBoxError("Raw already available")
            End If
            bpbModel = Nothing
        Catch ex As Exception
            Throw ex
        End Try
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
        '  ComboBoxALL()
        Dim headerModel As POHeaderModel = New POHeaderModel
        Dim poC As ClsPO = New ClsPO
        ComboBoxALL()
        headerModel = poC.RetrieveByID(poHeaderID)
        With headerModel
            txtPONo.Text = .PONo
            dtPODate.Value = .PODate
            cmbCurrency.SelectedValue = .CurrencyID
            cmbSupplier.SelectedValue = .SupplierID
            cmbSVM.SelectedValue = .ShipViaMethodID
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
                    .Item(4, intBarisRawMatrial).Value = detail.UnitPrice
                    .Item(5, intBarisRawMatrial).Value = detail.Quantity
                    .Item(6, intBarisRawMatrial).Value = detail.Total
                    .Item(7, intBarisRawMatrial).Value = detail.PIHeaderID
                    .Item(8, intBarisRawMatrial).Value = detail.PINo

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
        'txtShipViaMethode.Focus()
        btnApprove.Enabled = False
        btnVoid.Enabled = False
        btnPrint.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Sub PreUpdateDisplay()
        Try
            ClearDataGrid()
            CheckPermissions()
            PrepareHeaderByID()
            PrepareRawMatrialByHeaderID()
            PrepareRemarksByHeaderID()
            RetrieveSupplier()
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
        If CheckEmptyHeader() = False Then
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmptyHeader() = False Then
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

    Private Sub dgvrawmatrial_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs)
        intPostRawMatrial = e.Row.Index
    End Sub
    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs)
        cmbPINO.Focus()
    End Sub

    Private Sub cmbRawCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYarnCode.SelectedIndexChanged
        Try
            RetrieveQtyStock()
            cmbUnit.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtUnitPrice.Focus()
    End Sub

    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDiscount.Focus()
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        If e.KeyChar = Chr(13) Then
            txtOtherCost.Focus()
        End If
    End Sub

    Private Sub txtOtherCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtherCost.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSH.Focus()
        End If
    End Sub
    Private Sub cmbCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
        cmbSupplier.Focus()
    End Sub

    Private Sub cmbSVM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSVM.SelectedIndexChanged
        dtSD.Focus()
    End Sub
    Private Sub btnYarnAddList_Click(sender As Object, e As EventArgs) Handles btnYarnAddList.Click
        If CheckEmptyYarn() = False Then
            Try
                If CheckYarnInList() = True Then
                    AddGridDetailYarn()
                    SumSubTotalValue()
                    ClearYarn()
                Else
                    MsgBoxError("Yarn available in list")
                    ClearYarn()
                End If
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnYarnDelList_Click(sender As Object, e As EventArgs) Handles btnYarnDelList.Click
        Try
            DeleteGridDetailYarn()
            SumSubTotalValue()
            CalculateTotal()
            CalculateDiscount()
            CalculateOtherCost()
            CalculateSH()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
        If dgvrawmatrial.Rows.Count - 1 = 0 Then
            txtSubtotal.Text = 0
            txtDiscount.Text = 0
            txtVAT.Text = 0
            txtOtherCost.Text = 0
            txtSH.Text = 0
            txtGrandTotal.Text = 0
        End If
    End Sub

    Private Sub cmbPINO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPINO.SelectedIndexChanged
        Try
            ComboBoxYarn(cmbYarnCode, cmbPINO.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Try
            RetrieveSupplier()
        Catch ex As Exception

        End Try
    End Sub

#End Region

End Class