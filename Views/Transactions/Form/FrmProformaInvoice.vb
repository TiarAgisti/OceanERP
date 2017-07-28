Public Class FrmProformaInvoice

#Region "Declaration"
    Public Shared piHeaderID As Long = 0
    Public condition As String

    Dim intBarisFabric As Integer
    Dim intPostFabric As Integer

    Dim intBarisColor As Integer
    Dim intPostColor As Integer

    Dim intBarisYarn As Integer
    Dim intPostYarn As Integer

    Dim intBarisRemarks As Integer
    Dim intPostRemarks As Integer
#End Region

#Region "ComboBox"
    Sub ComboBoxBuyer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim status As String = "C"
        vendorBFC.ComboBoxVendor(cmbBuyer, status)
    End Sub
    Sub ComboBoxStyle()
        Dim styleBFC As ClsStyle = New ClsStyle
        styleBFC.ComboBoxStyle(cmbStyle)
    End Sub
    Sub ComboBoxSeason()
        Dim seasonBFC As ClsSeason = New ClsSeason
        seasonBFC.ComboBoxSeason(cmbSeason)
    End Sub
    Sub ComboBoxPort()
        Dim destiBFC As ClsDestination = New ClsDestination
        Dim status As String = "S"
        destiBFC.ComboBoxDestination(cmbPort, status)
    End Sub
    Sub ComboBoxCustomer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim status As String = "C"
        vendorBFC.ComboBoxVendor(cmbTo, status)
    End Sub
    Sub ComboBoxMarketing()
        Dim salesBFC As ClsGroupSales = New ClsGroupSales
        salesBFC.ComboBoxSales(cmbFM)
    End Sub
    Sub ComboBoxFabric()
        Dim fabricBFC As ClsFabric = New ClsFabric
        fabricBFC.ComboBoxFabric(cmbFabric)
    End Sub
    Sub ComboBoxRawMaterial()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        rawBFC.ComboBoxRawMaterial(cmbRawFabric)
    End Sub
    Sub ComboBoxUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        unitBFC.ComboBoxUnit(cmbUnitFabric)
    End Sub
    Sub ComboBoxColor()
        Dim colorBFC As ClsColor = New ClsColor
        colorBFC.ComboBoxColor(cmbColor)
    End Sub
    Sub ComboBoxYarn()
        Dim yarnBFC As ClsYarn = New ClsYarn
        yarnBFC.ComboBoxYarn(cmbYarn)
    End Sub
    Sub ComboBoxBrandYarn()
        Dim brandYarn As ClsBrandYarn = New ClsBrandYarn
        brandYarn.ComboBoxBrandYarn(cmbMerk)
    End Sub
    Sub ComboBoxColorYarn()
        Dim colorBFC As ClsColor = New ClsColor
        colorBFC.ComboBoxColor(cmbColorYarn)
    End Sub
    Sub ComboBoxBank()
        Dim bankBFC As ClsBank = New ClsBank
        bankBFC.ComboBoxBank(cmbBankCode)
    End Sub
#End Region

#Region "Grid Detail"
    Sub GridDetailFabric()
        With dgvFabric
            .Columns.Add(0, "FabricID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Fabric")
            .Columns.Add(2, "Spec Fabric")

            .Columns.Add(3, "StyleID")
            .Columns(3).Visible = False

            .Columns.Add(4, "Style")

            .Columns.Add(5, "Raw Mat ID")
            .Columns(5).Visible = False

            .Columns.Add(6, "Raw Material")
            .Columns.Add(7, "Type Greige")
            .Columns.Add(8, "Width Min")
            .Columns.Add(9, "Width Max")

            .Columns.Add(10, "Unit ID")
            .Columns(10).Visible = False

            .Columns.Add(11, "Unit")
            .Columns.Add(12, "Weight Min")
            .Columns.Add(13, "Weight Max")
            .Columns.Add(14, "DN Yardage")
            .Columns.Add(15, "Weight Yard")
            .Columns.Add(16, "Before Wash")
            .Columns.Add(17, "After Wash")
            .Columns.Add(18, "Nett Weight")
            .Columns.Add(19, "Srinkage L")
            .Columns.Add(20, "Srinkage W")
            .Columns.Add(21, "G / SM")
            .Columns.Add(22, "Price Greige")
            .Columns.Add(23, "Purch Size")
            .Columns.Add(24, "Storage Size")
            .Columns.Add(25, "PP Sample")
            .Columns.Add(26, "Qty Cuttable")
            .Columns.Add(27, "Qty Weight")
        End With
    End Sub
    Sub GridDetailColor()
        With dgvColor
            .Columns.Add(0, "Color ID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Color Code")
            .Columns.Add(2, "Color")
            .Columns.Add(3, "Color Type")
            .Columns.Add(4, "Lab Color No.")
            .Columns.Add(5, "Qty Order")

            .Columns.Add(6, "Purch Size ID")
            .Columns(6).Visible = False

            .Columns.Add(7, "Purch Size")
            .Columns.Add(8, "Price")
            .Columns.Add(9, "Qty Sample")
            .Columns.Add(10, "Del Date")
            .Columns.Add(11, "Note")
        End With
    End Sub
    Sub GridDetailYarn()
        With dgvYarn
            .Columns.Add(0, "Yarn ID")
            .Columns(0).Visible = False
            .Columns.Add(1, "Yarn Name")
            .Columns.Add(2, "Supplier Yarn")
            .Columns.Add(3, "Price Yarn")
            .Columns.Add(4, "Supplier Yarn")
            .Columns.Add(5, "Price Yarn")
            .Columns.Add(6, "% Usage")
            .Columns.Add(7, "Qty Usage")
            .Columns.Add(8, "Color Yarn ID")
            .Columns(8).Visible = False
            .Columns.Add(9, "Color Yarn")
            .Columns.Add(10, "Brand Yarn ID")
            .Columns(10).Visible = False
            .Columns.Add(11, "Brand Yarn")
            .Columns.Add(12, "Loss")
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
        txtPINo.Text = AutoGenerated
        txtRefPO.Clear()
        txtContract.Clear()
        txtAddress.Clear()
        txtTlp.Clear()
        txtFax.Clear()
        txtAttention.Clear()
        txtDelPlace.Clear()
    End Sub
    Sub ClearFabric()
        txtSpec.Clear()
        txtWidthMin.Clear()
        txtWidthMax.Clear()
        txtWeightMin.Clear()
        txtWeightMax.Clear()
        txtDNYardage.Clear()
        txtWeightYard.Clear()
        txtBeforeWash.Clear()
        txtAfterWash.Clear()
        txtNetWeight.Clear()
        txtSrinkageL.Clear()
        txtSrinkageW.Clear()
        txtGSM.Clear()
        txtPriceGreige.Clear()
        txtPurchSize.Clear()
        txtStorageSize.Clear()
        txtPPSample.Clear()
        txtQtyCutt.Clear()
        txtQtyWeight.Clear()
    End Sub

    Sub ClearColorFabric()
        txtColor.Clear()
        txtColorType.Clear()
        txtLabColNo.Clear()
        txtColQtyOrder.Clear()
        txtColPrice.Clear()
        txtColQtySample.Clear()
        txtColNotes.Clear()
    End Sub

    Sub ClearYarn()
        txtSuppYarn.Clear()
        txtPriceYarn.Clear()
        txtPercentUsage.Clear()
        txtQtyUsage.Clear()
        txtLoss.Clear()
    End Sub

    Sub ClearBankDetail()
        txtBank.Clear()
        txtAccName.Clear()
        txtAccNumber.Clear()
        txtSwiftCode.Clear()
    End Sub

    Sub ClearRemarks()
        txtRemarks.Clear()
    End Sub
#End Region

#Region "Validation Number"
    Private Sub txtTlp_TextChanged(sender As Object, e As EventArgs) Handles txtTlp.TextChanged
        CheckNumber(txtTlp)
    End Sub

    Private Sub txtFax_TextChanged(sender As Object, e As EventArgs) Handles txtFax.TextChanged
        CheckNumber(txtFax)
    End Sub

    Private Sub txtWidthMin_TextChanged(sender As Object, e As EventArgs) Handles txtWidthMin.TextChanged
        CheckNumber(txtWidthMin)
    End Sub

    Private Sub txtWidthMax_TextChanged(sender As Object, e As EventArgs) Handles txtWidthMax.TextChanged
        CheckNumber(txtWidthMax)
    End Sub

    Private Sub txtWeightMin_TextChanged(sender As Object, e As EventArgs) Handles txtWeightMin.TextChanged
        CheckNumber(txtWeightMin)
    End Sub

    Private Sub txtWeightMax_TextChanged(sender As Object, e As EventArgs) Handles txtWeightMax.TextChanged
        CheckNumber(txtWeightMax)
    End Sub

    Private Sub txtDNYardage_TextChanged(sender As Object, e As EventArgs) Handles txtDNYardage.TextChanged
        CheckNumber(txtDNYardage)
    End Sub

    Private Sub txtWeightYard_TextChanged(sender As Object, e As EventArgs) Handles txtWeightYard.TextChanged
        CheckNumber(txtWeightYard)
    End Sub

    Private Sub txtBeforeWash_TextChanged(sender As Object, e As EventArgs) Handles txtBeforeWash.TextChanged
        CheckNumber(txtBeforeWash)
    End Sub

    Private Sub txtAfterWash_TextChanged(sender As Object, e As EventArgs) Handles txtAfterWash.TextChanged
        CheckNumber(txtAfterWash)
    End Sub

    Private Sub txtNetWeight_TextChanged(sender As Object, e As EventArgs) Handles txtNetWeight.TextChanged
        CheckNumber(txtNetWeight)
    End Sub

    Private Sub txtPriceGreige_TextChanged(sender As Object, e As EventArgs) Handles txtPriceGreige.TextChanged
        CheckNumber(txtPriceGreige)
    End Sub

    Private Sub txtQtyCutt_TextChanged(sender As Object, e As EventArgs) Handles txtQtyCutt.TextChanged
        CheckNumber(txtQtyCutt)
    End Sub

    Private Sub txtQtyWeight_TextChanged(sender As Object, e As EventArgs) Handles txtQtyWeight.TextChanged
        CheckNumber(txtQtyWeight)
    End Sub

    Private Sub txtColQtyOrder_TextChanged(sender As Object, e As EventArgs) Handles txtColQtyOrder.TextChanged
        CheckNumber(txtColQtyOrder)
    End Sub

    Private Sub txtColPrice_TextChanged(sender As Object, e As EventArgs) Handles txtColPrice.TextChanged
        CheckNumber(txtColPrice)
    End Sub

    Private Sub txtColQtySample_TextChanged(sender As Object, e As EventArgs) Handles txtColQtySample.TextChanged
        CheckNumber(txtColQtySample)
    End Sub

    Private Sub txtPriceYarn_TextChanged(sender As Object, e As EventArgs) Handles txtPriceYarn.TextChanged
        CheckNumber(txtPriceYarn)
    End Sub

    Private Sub txtPercentUsage_TextChanged(sender As Object, e As EventArgs) Handles txtPercentUsage.TextChanged
        CheckNumber(txtPercentUsage)
    End Sub

    Private Sub txtQtyUsage_TextChanged(sender As Object, e As EventArgs) Handles txtQtyUsage.TextChanged
        CheckNumber(txtQtyUsage)
    End Sub

    Private Sub txtLoss_TextChanged(sender As Object, e As EventArgs) Handles txtLoss.TextChanged
        CheckNumber(txtLoss)
    End Sub
#End Region

#Region "Add Grid Detail"
    Sub AddGridDetailFabric()
        With dgvFabric
            .Rows.Add()
            .Item(0, intBarisFabric).Value = cmbFabric.SelectedValue
            .Item(1, intBarisFabric).Value = cmbFabric.Text
            .Item(2, intBarisFabric).Value = txtSpec.Text
            .Item(3, intBarisFabric).Value = cmbStyle.SelectedValue
            .Item(4, intBarisFabric).Value = cmbStyle.Text
            .Item(5, intBarisFabric).Value = cmbRawFabric.SelectedValue
            .Item(6, intBarisFabric).Value = cmbRawFabric.Text
            .Item(7, intBarisFabric).Value = cmbTypeGreige.Text
            .Item(8, intBarisFabric).Value = txtWidthMin.Text
            .Item(9, intBarisFabric).Value = txtWidthMax.Text
            .Item(10, intBarisFabric).Value = cmbUnitFabric.SelectedValue
            .Item(11, intBarisFabric).Value = cmbUnitFabric.Text
            .Item(12, intBarisFabric).Value = txtWeightMin.Text
            .Item(13, intBarisFabric).Value = txtWeightMax.Text
            .Item(14, intBarisFabric).Value = txtDNYardage.Text
            .Item(15, intBarisFabric).Value = txtWeightYard.Text
            .Item(16, intBarisFabric).Value = txtBeforeWash.Text
            .Item(17, intBarisFabric).Value = txtAfterWash.Text
            .Item(18, intBarisFabric).Value = txtNetWeight.Text
            .Item(19, intBarisFabric).Value = txtSrinkageL.Text
            .Item(20, intBarisFabric).Value = txtSrinkageW.Text
            .Item(21, intBarisFabric).Value = txtGSM.Text
            .Item(22, intBarisFabric).Value = txtPriceGreige.Text
            .Item(23, intBarisFabric).Value = txtPurchSize.Text
            .Item(24, intBarisFabric).Value = txtStorageSize.Text
            .Item(25, intBarisFabric).Value = txtPPSample.Text
            .Item(26, intBarisFabric).Value = txtQtyCutt.Text
            .Item(27, intBarisFabric).Value = txtQtyWeight.Text
        End With
        intBarisFabric = intBarisFabric + 1
    End Sub

    Sub AddGridDetailColor()
        With dgvColor
            .Rows.Add()
            .Item(0, intBarisColor).Value = cmbColor.SelectedValue
            .Item(1, intBarisColor).Value = cmbColor.Text
            .Item(2, intBarisColor).Value = txtColor.Text
            .Item(3, intBarisColor).Value = txtColorType.Text
            .Item(4, intBarisColor).Value = txtLabColNo.Text
            .Item(5, intBarisColor).Value = txtColQtyOrder.Text
            .Item(6, intBarisColor).Value = cmbColPurchSize.SelectedValue
            .Item(7, intBarisColor).Value = cmbColPurchSize.Text
            .Item(8, intBarisColor).Value = txtColPrice.Text
            .Item(9, intBarisColor).Value = txtColQtySample.Text
            .Item(10, intBarisColor).Value = dtpColDelDate.Value
            .Item(11, intBarisColor).Value = txtColNotes.Text
        End With
        intBarisColor = intBarisColor + 1
    End Sub

    Sub AddGridDetailYarn()
        With dgvYarn
            .Rows.Add()
            .Item(0, intBarisYarn).Value = cmbYarn.SelectedValue

        End With
    End Sub
#End Region
    'Sub DeleteGridDetail()
    '    Me.dgv.Rows.RemoveAt(Me.dgv.CurrentCell.RowIndex)
    '    intBaris = intBaris - 1
    '    txtTotQty.Text = SumQty()
    '    txtGrandTotal.Text = SumAmount()
    'End Sub

    'Function SumAmount() As Decimal
    '    Dim totalAmount As Decimal
    '    totalAmount = 0
    '    For row As Integer = 0 To dgv.Rows.Count - 1
    '        totalAmount = totalAmount + dgv.Rows(row).Cells(14).Value
    '    Next
    '    Return totalAmount
    'End Function

    'Function SumQty() As Decimal
    '    Dim totalQty As Decimal
    '    totalQty = 0
    '    For row As Integer = 0 To dgv.Rows.Count - 1
    '        totalQty = totalQty + dgv.Rows(row).Cells(13).Value
    '    Next
    '    Return totalQty
    'End Function

    'Function RetrieveBuyer() As Boolean
    '    Dim vendorModel As VendorModel = New VendorModel
    '    Dim vendorBFC As ClsVendor = New ClsVendor
    '    Try
    '        vendorModel = vendorBFC.RetrieveBuyerName(txtBuyer.Text)
    '        If String.IsNullOrEmpty(vendorModel.VendorName) Then
    '            MsgBoxError("Buyer name not valid")
    '            txtBuyer.Clear()
    '            Return False
    '        Else
    '            buyerID = vendorModel.VendorID
    '            txtBuyer.Text = vendorModel.VendorName
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        Return False
    '        MsgBoxError(ex.Message)
    '    End Try
    'End Function

    'Function RetrieveCustomer() As Boolean
    '    Dim vendorModel As VendorModel = New VendorModel
    '    Dim vendorBFC As ClsVendor = New ClsVendor
    '    Try
    '        vendorModel = vendorBFC.RetrieveCustomerName(txtTo.Text)
    '        If String.IsNullOrEmpty(vendorModel.VendorName) Then
    '            MsgBoxError("Customer name not valid")
    '            txtTo.Clear()
    '            Return False
    '        Else
    '            customerID = vendorModel.VendorID

    '            txtTo.Text = vendorModel.VendorName
    '            txtAddress.Text = vendorModel.Address
    '            txtTlp.Text = vendorModel.Telephone
    '            txtFax.Text = vendorModel.Fax
    '            txtAttention.Text = vendorModel.ContactPerson
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        Return False
    '        MsgBoxError(ex.Message)
    '    End Try
    'End Function

    'Function RetrieveFabric() As Boolean
    '    Dim fabricModel As FabricModel = New FabricModel
    '    Dim fabricBFC As ClsFabric = New ClsFabric
    '    Try
    '        fabricModel = fabricBFC.RetrieveByName(txtFabric.Text)
    '        If String.IsNullOrEmpty(fabricModel.FabricCode) Then
    '            MsgBoxError("Fabric name not valid")
    '            txtFabric.Clear()
    '            Return False
    '        Else
    '            fabricID = fabricModel.FabricID
    '            txtFabric.Text = fabricModel.FabricName
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        Return False
    '        MsgBoxError(ex.Message)
    '    End Try
    'End Function
    'Function CheckEmpty() As Boolean
    '    If String.IsNullOrEmpty(txtBuyer.Text) Then
    '        MsgBoxWarning("Buyer can't empty")
    '        txtBuyer.Focus()
    '        Return False
    '    ElseIf String.IsNullOrEmpty(txtRefPO.Text) Then
    '        MsgBoxWarning("Ref PO can't empty")
    '        txtRefPO.Focus()
    '        Return False
    '    ElseIf String.IsNullOrEmpty(txtStyle.Text) Then
    '        MsgBoxWarning("Style can't empty")
    '        txtStyle.Focus()
    '        Return False
    '    ElseIf String.IsNullOrEmpty(txtContract.Text) Then
    '        MsgBoxWarning("Contract No can't empty")
    '        txtContract.Focus()
    '        Return False
    '    ElseIf String.IsNullOrEmpty(txtDelPlace.Text) Then
    '        MsgBoxWarning("Delivery Place can't empty")
    '        txtDelPlace.Focus()
    '        Return False
    '    ElseIf dgv.Rows.Count - 1 = 0 Then
    '        MsgBoxWarning("Detail can't empty")
    '        txtFabric.Focus()
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function
    'Function CheckEmptyDetail() As Boolean
    '    If txtQtyCutt.Text = "" Or txtQtyCutt.Text = 0 Then
    '        MsgBoxWarning("Qty Cuttable can't empty or 0")
    '        txtQtyCutt.Focus()
    '        Return False
    '    ElseIf txtQtyWeight.Text = "" Or txtQtyWeight.Text = 0 Then
    '        MsgBoxWarning("Qty Weight can't empty or 0")
    '        txtQtyWeight.Focus()
    '        Return False
    '    ElseIf txtPrice.Text = "" Or txtPrice.Text = 0 Then
    '        MsgBoxWarning("Unit Price can't empty or 0")
    '        txtPrice.Focus()
    '        Return False
    '    ElseIf txtQty.Text = "" Or txtQty.Text = 0 Then
    '        MsgBoxWarning("Qty can't empty or 0")
    '        txtQty.Focus()
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    'Function CheckDetail() As Boolean
    '    Dim cek As Integer
    '    Dim status As Boolean = True
    '    For cek = 0 To Me.dgv.Rows.Count - 1
    '        If Me.dgv.Rows(cek).Cells(0).Value = fabricID Then
    '            status = False
    '        End If
    '    Next
    '    Return status
    'End Function

    'Function GetPiHeaderID() As Long
    '    Dim piHeaderID As Long
    '    Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
    '    piHeaderID = piBFC.GeneratedAutoNumber
    '    Return piHeaderID
    'End Function

    'Function GetPINo() As String
    '    Dim piNo As String
    '    Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
    '    piNo = piBFC.GeneratedPINo(customerCode)
    '    Return piNo
    'End Function

    'Function SetHeaderModel() As PIHeaderModel
    '    Dim piHeaderModel As PIHeaderModel = New PIHeaderModel
    '    With piHeaderModel
    '        Select Case condition
    '            Case "Create"
    '                .PIHeaderID = GetPiHeaderID()
    '                .PIDate = Format(dtPIDate.Value, "yyyy-MM-dd")
    '                .PINo = GetPINo()
    '                txtPINo.Text = .PINo
    '                .VendorID = customerID
    '                .BuyerID = buyerID
    '                .GroupSalesID = cmbFM.SelectedValue
    '                .RefPO = txtRefPO.Text
    '                .Style = txtStyle.Text
    '                .SeasonID = cmbSeason.SelectedValue
    '                .TermOfPaymentID = cmbTOP.SelectedValue
    '                .DelTerm = Format(dtDelTerm.Value, "yyyy-MM-dd")
    '                .TermOfPriceID = cmbTermPrice.SelectedValue
    '                .ContractNo = txtContract.Text
    '                .DestinationID = cmbPort.SelectedValue
    '                .DeliveryPlace = txtDelPlace.Text
    '                .Status = 1
    '                .CreatedBy = userID
    '                .CreatedDate = DateTime.Now
    '                .UpdatedBy = userID
    '                .UpdatedDate = DateTime.Now
    '            Case "Update"

    '        End Select
    '    End With
    '    Return piHeaderModel
    'End Function

    'Function SetDetailsModel(piHeaderID As Long) As List(Of PIDetailModel)
    '    Dim listPIDetailModel As List(Of PIDetailModel) = New List(Of PIDetailModel)
    '    For detail = 0 To dgv.Rows.Count - 2
    '        Dim piDetailModel As PIDetailModel = New PIDetailModel
    '        piDetailModel.PIHeaderID = piHeaderID
    '        piDetailModel.FabricID = dgv.Rows(detail).Cells(0).Value
    '        piDetailModel.DateDetail = dgv.Rows(detail).Cells(2).Value
    '        piDetailModel.ColorID = dgv.Rows(detail).Cells(3).Value
    '        piDetailModel.PPSample = dgv.Rows(detail).Cells(5).Value
    '        piDetailModel.QtyCuttable = dgv.Rows(detail).Cells(6).Value
    '        piDetailModel.QtyWeight = dgv.Rows(detail).Cells(7).Value
    '        piDetailModel.Qty = dgv.Rows(detail).Cells(13).Value
    '        piDetailModel.UnitID = dgv.Rows(detail).Cells(8).Value
    '        piDetailModel.UnitPrice = dgv.Rows(detail).Cells(12).Value
    '        piDetailModel.CurrencyID = dgv.Rows(detail).Cells(10).Value
    '        listPIDetailModel.Add(piDetailModel)
    '    Next
    '    Return listPIDetailModel
    'End Function

    'Sub InsertData()
    '    Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
    '    Dim logBFC As ClsLogHistory = New ClsLogHistory
    '    Dim logDesc As String = "Create new Proforma Invoice,PINo is " + GetPINo()

    '    Try
    '        If piBFC.InsertData(SetHeaderModel, SetDetailsModel(GetPiHeaderID), logBFC.SetLogHistory(logDesc)) = True Then
    '            MsgBoxSaved()
    '        End If
    '    Catch ex As Exception
    '        MsgBoxError(ex.Message)
    '    End Try
    'End Sub
    'Sub PreCreateDisplay()
    '    dgv.Columns.Clear()
    '    ClearHeader()
    '    ClearDetail()
    '    GridDetail()
    '    ComboBoxSeason()
    '    ComboBoxTOP()
    '    ComboBoxTermOfPrice()
    '    ComboBoxUnit()
    '    ComboBoxSeaPort()
    '    ComboBoxColor()
    '    ComboBoxCurrency()
    '    ComboBoxGroupSales()
    '    txtBuyer.Focus()
    'End Sub

#Region "Button"

#End Region
End Class