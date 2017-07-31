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

    Dim customerCode As String = ""
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
        colorBFC.ComboBoxColorYarn(cmbColorYarn)
    End Sub

    Sub ComboBoxBank()
        Dim bankBFC As ClsBank = New ClsBank
        bankBFC.ComboBoxBank(cmbBankCode)
    End Sub

    Sub ComboBoxTermOfPayment()
        Dim topBFC As ClsTermOfPayment = New ClsTermOfPayment
        topBFC.ComboBoxTOP(cmbTOP)
    End Sub

    Sub ComboBoxTermPrice()
        Dim termPriceBFC As ClsTermOfPrice = New ClsTermOfPrice
        termPriceBFC.ComboBoxTermPrice(cmbTermPrice)
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
            .Columns.Add(4, "% Usage")
            .Columns.Add(5, "Qty Usage")

            .Columns.Add(6, "Color Yarn ID")
            .Columns(6).Visible = False

            .Columns.Add(7, "Color Yarn")

            .Columns.Add(8, "Brand Yarn ID")
            .Columns(8).Visible = False

            .Columns.Add(9, "Brand Yarn")
            .Columns.Add(10, "Loss")
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
            .Item(1, intBarisYarn).Value = cmbYarn.Text
            .Item(2, intBarisYarn).Value = txtSuppYarn.Text
            .Item(3, intBarisYarn).Value = txtPriceYarn.Text
            .Item(4, intBarisYarn).Value = txtPercentUsage.Text
            .Item(5, intBarisYarn).Value = txtQtyUsage.Text
            .Item(6, intBarisYarn).Value = cmbColorYarn.SelectedValue
            .Item(7, intBarisYarn).Value = cmbColorYarn.Text
            .Item(8, intBarisYarn).Value = cmbMerk.SelectedValue
            .Item(9, intBarisYarn).Value = cmbMerk.Text
            .Item(10, intBarisYarn).Value = txtLoss.Text
        End With
        intBarisYarn = intBarisYarn + 1
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
    Sub DeleteGridDetailFabric()
        DeleteGrid(dgvFabric, intBarisFabric)
    End Sub
    Sub DeleteGridDetailColor()
        DeleteGrid(dgvColor, intBarisColor)
    End Sub
    Sub DeleteGridDetailYarn()
        DeleteGrid(dgvYarn, intBarisYarn)
    End Sub
    Sub DeleteGridDetailRemarks()
        DeleteGrid(dgvRemarks, intBarisRemarks)
    End Sub
#End Region

#Region "Check Empty"
    Function CheckEmptyHeader() As Boolean
        If cmbBuyer.SelectedValue = 0 Then
            MsgBoxWarning("Buyer not valid")
            cmbBuyer.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(txtRefPO.Text) Then
            MsgBoxWarning("Ref PO can't empty")
            txtRefPO.Focus()
            Return False
        ElseIf cmbStyle.SelectedValue = 0 Then
            MsgBoxWarning("Style not valid")
            cmbStyle.Focus()
            Return False
        ElseIf cmbSeason.SelectedValue = 0 Then
            MsgBoxWarning("Season not valid")
            cmbSeason.Focus()
            Return False
        ElseIf cmbTOP.SelectedValue = 0 Then
            MsgBoxWarning("Term Of Payment not valid")
            cmbTOP.Focus()
            Return False
        ElseIf cmbTermPrice.SelectedValue = 0 Then
            MsgBoxWarning("Term Of Price not valid")
            cmbTermPrice.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(txtContract.Text) Then
            MsgBoxWarning("Contract No can't empty")
            txtContract.Focus()
            Return False
        ElseIf cmbTo.SelectedValue = 0 Then
            MsgBoxWarning("Customer not valid")
            cmbTo.Focus()
            Return False
        ElseIf cmbFM.SelectedValue = 0 Then
            MsgBoxWarning("FM not valid")
            cmbFM.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(txtDelPlace.Text) Then
            MsgBoxWarning("Delivery Place can't empty")
            txtDelPlace.Focus()
            Return False
        ElseIf dgvFabric.Rows.Count - 1 = 0 Then
            MsgBoxWarning("Detail can't empty")
            cmbFabric.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function CheckEmptyFabric() As Boolean
        If cmbFabric.SelectedValue = 0 Then
            MsgBoxWarning("Fabric not valid")
            cmbFabric.Focus()
            Return False
        ElseIf cmbFabricStyle.SelectedValue = 0 Then
            MsgBoxWarning("Style For Fabric not valid")
            cmbFabricStyle.Focus()
            Return False
        ElseIf cmbRawFabric.SelectedValue = 0 Then
            MsgBoxWarning("Raw Material For Fabric not valid")
            cmbRawFabric.Focus()
            Return False
        ElseIf cmbTypeGreige.Text = "" Then
            MsgBoxWarning("Type Greige Cant Empty")
            cmbTypeGreige.Focus()
            Return False
        ElseIf cmbUnitFabric.SelectedValue = 0 Then
            MsgBoxWarning("Unit For Fabric not valid")
            cmbUnitFabric.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function CheckEmptyColor() As Boolean
        If cmbColor.SelectedValue = 0 Then
            MsgBoxWarning("Color not valid")
            cmbColor.Focus()
            Return False
        ElseIf txtColQtyOrder.Text = String.Empty Or txtColQtyOrder.Text = 0 Then
            MsgBoxWarning("Qty Order cant empty or 0")
            txtColQtyOrder.Focus()
            Return False
        ElseIf txtColPrice.Text = String.Empty Or txtColPrice.Text = 0 Then
            MsgBoxWarning("Price cant empty or 0")
            txtColPrice.Focus()
            Return False
        ElseIf txtColQtySample.Text = String.Empty Or txtColQtySample.Text = 0 Then
            MsgBoxWarning("Qty Sample cant empty or 0")
            txtColQtySample.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function CheckEmptyYarn() As Boolean
        If cmbYarn.SelectedValue = 0 Then
            MsgBoxWarning("Yarn not valid")
            cmbYarn.Focus()
            Return False
        ElseIf txtPriceYarn.Text = String.Empty Or txtPriceYarn.Text = 0 Then
            MsgBoxWarning("Price Yarn cant empty or 0")
            txtPriceYarn.Focus()
            Return False
        ElseIf txtQtyUsage.Text = String.Empty Or txtQtyUsage.Text = 0 Then
            MsgBoxWarning("Qty Usage cant empty or 0")
            txtQtyUsage.Focus()
            Return False
        ElseIf cmbColorYarn.SelectedValue = 0 Then
            MsgBoxWarning("Color Yarn not valid")
            cmbColorYarn.Focus()
            Return False
        ElseIf cmbMerk.SelectedValue = 0 Then
            MsgBoxWarning("Merk not valid")
            cmbMerk.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function CheckEmptyBank() As Boolean
        If cmbBankCode.SelectedValue = 0 Then
            MsgBoxWarning("Bank not valid")
            cmbBankCode.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function CheckEmptyRemarks() As Boolean
        If txtRemarks.Text = String.Empty Then
            MsgBoxWarning("Remarks cant empty")
            txtRemarks.Focus()
            Return False
        Else
            Return True
        End If
    End Function
#End Region

#Region "Check Available In List"
    Function CheckFabricInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean
        status = piBFC.CheckFabricInList(dgvFabric, cmbFabric.SelectedValue)
        Return status
    End Function

    Function CheckColorInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean
        status = piBFC.CheckColorInList(dgvColor, cmbColor.SelectedValue)
        Return status
    End Function

    Function CheckYarnInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean
        status = piBFC.CheckYarnInList(dgvYarn, cmbYarn.SelectedValue)
        Return status
    End Function

    Function CheckRemarksInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean = True
        status = piBFC.CheckRemarksInList(dgvRemarks, txtRemarks.Text)
        Return status
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader() As PIHeaderModel
        Dim headerModel As PIHeaderModel = New PIHeaderModel
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        With headerModel
            Select Case condition
                Case "Create"
                    .PIHeaderID = piBFC.GetPiHeaderID
                    .PIDate = Format(dtPIDate.Value, "yyyy-MM-dd")
                    .PINo = piBFC.GetPINo(customerCode)
                    .VendorID = cmbTo.SelectedValue
                    .BuyerID = cmbBuyer.SelectedValue
                    .GroupSalesID = cmbFM.SelectedValue
                    .RefPO = txtRefPO.Text
                    .Style = cmbStyle.SelectedValue
                    .SeasonID = cmbSeason.SelectedValue
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .DelTerm = Format(dtDelTerm.Value, "yyyy-MM-dd")
                    .TermOfPriceID = cmbTermPrice.SelectedValue
                    .ContractNo = txtContract.Text
                    .DestinationID = cmbPort.SelectedValue
                    .DeliveryPlace = txtDelPlace.Text
                    .Status = 1
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .PIHeaderID = piHeaderID
                    .PIDate = Format(dtPIDate.Value, "yyyy-MM-dd")
                    .PINo = txtPINo.Text
                    .VendorID = cmbTo.SelectedValue
                    .BuyerID = cmbBuyer.SelectedValue
                    .GroupSalesID = cmbFM.SelectedValue
                    .RefPO = txtRefPO.Text
                    .Style = cmbStyle.SelectedValue
                    .SeasonID = cmbSeason.SelectedValue
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .DelTerm = Format(dtDelTerm.Value, "yyyy-MM-dd")
                    .TermOfPriceID = cmbTermPrice.SelectedValue
                    .ContractNo = txtContract.Text
                    .DestinationID = cmbPort.SelectedValue
                    .DeliveryPlace = txtDelPlace.Text
                    .Status = 1
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return headerModel
    End Function

    Function SetDetailFabric(piID As Long) As List(Of PIDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim listModel As List(Of PIDetailModel) = New List(Of PIDetailModel)
        listModel = piBFC.SetDetailFabric(piID, dgvFabric)
        Return listModel
    End Function

    Function SetDetailColor(piID As Long) As List(Of PIColorDetailModel)
        Dim listModel As List(Of PIColorDetailModel) = New List(Of PIColorDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        listModel = piBFC.SetDetailColor(piID, dgvColor)
        Return listModel
    End Function

    Function SetDetailYarn(piID As Long) As List(Of PIYarnDetailModel)
        Dim listModel As List(Of PIYarnDetailModel) = New List(Of PIYarnDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        listModel = piBFC.SetDetailYarn(piID, dgvYarn)
        Return listModel
    End Function

    Function SetDataBank(piID As Long) As PIBankDetailModel
        Dim myModel As PIBankDetailModel = New PIBankDetailModel
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        myModel.PIHeaderID = piID
        myModel.PIBankDetailID = piBFC.GetPIDetailBankID
        myModel.BankID = cmbBankCode.SelectedValue
        Return myModel
    End Function

    Function SetDetailRemarks(piID As Long) As List(Of PIRemarksModel)
        Dim listModel As List(Of PIRemarksModel) = New List(Of PIRemarksModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        listModel = piBFC.SetDetailRemarks(piID, dgvRemarks)
        Return listModel
    End Function
#End Region

#Region "Function"
    Sub InsertData()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim myPINo As String = piBFC.GetPINo(customerCode)
        Dim myPIID As Long = piBFC.GetPiHeaderID
        Dim logDesc As String = "Create new Proforma Invoice,PINo is " + myPINo

        Try
            If piBFC.InsertData(SetDataHeader, SetDetailFabric(myPIID), SetDetailColor(myPIID), SetDetailYarn(myPIID) _
                                , SetDetailRemarks(myPIID), SetDataBank(myPIID), logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxSaved()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateData()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Proforma Invoice,Where PINo = " + txtPINo.Text
        Try
            If piBFC.UpdateData(SetDataHeader, SetDetailFabric(piHeaderID), SetDetailColor(piHeaderID), SetDetailYarn(piHeaderID) _
                                , SetDetailRemarks(piHeaderID), SetDataBank(piHeaderID), logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxUpdated()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub ClearDataGrid()
        dgvFabric.Columns.Clear()
        dgvColor.Columns.Clear()
        dgvYarn.Columns.Clear()
        dgvRemarks.Columns.Clear()
    End Sub

    Sub ClearAllData()
        ClearHeader()
        ClearFabric()
        ClearColorFabric()
        ClearYarn()
        ClearBankDetail()
        ClearRemarks()
    End Sub

    Sub GridDetailALL()
        GridDetailFabric()
        GridDetailColor()
        GridDetailYarn()
        GridDetailRemark()
    End Sub

    Sub ComboBoxALL()
        ComboBoxBank()
        ComboBoxBrandYarn()
        ComboBoxBuyer()
        ComboBoxColor()
        ComboBoxColorYarn()
        ComboBoxCustomer()
        ComboBoxFabric()
        ComboBoxMarketing()
        ComboBoxPort()
        ComboBoxRawMaterial()
        ComboBoxSeason()
        ComboBoxStyle()
        ComboBoxTermOfPayment()
        ComboBoxTermPrice()
        ComboBoxUnit()
        ComboBoxYarn()
    End Sub

    Sub RetrieveCustomer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim vendorModel As VendorModel = New VendorModel
        Dim obj As Long = cmbTo.SelectedValue
        If obj > 0 Then
            vendorModel = vendorBFC.RetrieveVendorByID(obj, "C")
            With vendorModel
                txtTlp.Text = .Telephone
                txtAttention.Text = .ContactPerson
                txtAddress.Text = .Address
                txtFax.Text = .Fax
            End With
        Else
            MsgBoxError("Customer not valid")
        End If
    End Sub

    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then btnSave.Enabled = True
        If roleModel.IsUpdate = True Then btnUpdate.Enabled = True
        If roleModel.IsApprove = True Then btnApprove.Enabled = True
        If roleModel.IsVoid = True Then btnVoid.Enabled = True
    End Sub

    Sub PreCreatedisplay()
        CheckPermissions()
        ClearDataGrid()
        ClearAllData()
        GridDetailALL()
        ComboBoxALL()
        cmbBuyer.Focus()
    End Sub

    Private Sub FrmProformaInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreatedisplay()
    End Sub
#End Region

#Region "Button"
    Private Sub btnAddFabric_Click(sender As Object, e As EventArgs) Handles btnAddFabric.Click
        If CheckEmptyFabric() = True Then
            Try
                AddGridDetailFabric()
                ClearFabric()
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelFabirc_Click(sender As Object, e As EventArgs) Handles btnDelFabirc.Click
        Try
            DeleteGridDetailFabric()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnColAddList_Click(sender As Object, e As EventArgs) Handles btnColAddList.Click
        If CheckEmptyColor() = True Then
            Try
                AddGridDetailColor()
                ClearColorFabric()
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnColDelList_Click(sender As Object, e As EventArgs) Handles btnColDelList.Click
        Try
            DeleteGridDetailColor()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnAddYarnList_Click(sender As Object, e As EventArgs) Handles btnAddYarnList.Click
        If CheckEmptyYarn() = True Then
            Try
                AddGridDetailYarn()
                ClearYarn()
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelYarnList_Click(sender As Object, e As EventArgs) Handles btnDelYarnList.Click
        Try
            DeleteGridDetailYarn()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnRemAddList_Click(sender As Object, e As EventArgs) Handles btnRemAddList.Click
        If CheckEmptyRemarks() = True Then
            Try
                AddGridDetailRemarks()
                ClearRemarks()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

    End Sub
#End Region

#Region "KeyPress"
    Private Sub dtPIDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtPIDate.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbBuyer.Focus()
        End If
    End Sub

    Private Sub cmbBuyer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuyer.SelectedIndexChanged
        txtRefPO.Focus()
    End Sub

    Private Sub txtRefPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRefPO.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbStyle.Focus()
        End If
    End Sub

    Private Sub cmbStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStyle.SelectedIndexChanged
        cmbSeason.Focus()
    End Sub

    Private Sub cmbSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSeason.SelectedIndexChanged
        cmbTOP.Focus()
    End Sub

    Private Sub cmbTOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTOP.SelectedIndexChanged
        dtDelTerm.Focus()
    End Sub

    Private Sub cmbTermPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTermPrice.SelectedIndexChanged
        txtContract.Focus()
    End Sub

    Private Sub txtContract_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContract.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbPort.Focus()
        End If
    End Sub

    Private Sub cmbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPort.SelectedIndexChanged
        cmbTo.Focus()
    End Sub

    Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged
        cmbFM.Focus()
    End Sub

    Private Sub cmbFM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFM.SelectedIndexChanged
        txtDelPlace.Focus()
    End Sub

    Private Sub txtDelPlace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDelPlace.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbFabric.Focus()
        End If
    End Sub

    Private Sub cmbFabric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFabric.SelectedIndexChanged
        cmbRawFabric.Focus()
    End Sub

    Private Sub cmbRawFabric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRawFabric.SelectedIndexChanged
        cmbTypeGreige.Focus()
    End Sub

    Private Sub cmbTypeGreige_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeGreige.SelectedIndexChanged
        txtWidthMin.Focus()
    End Sub

    Private Sub txtWidthMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWidthMin.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWidthMax.Focus()
        End If
    End Sub

    Private Sub txtWidthMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWidthMax.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbUnitFabric.Focus()
        End If
    End Sub

    Private Sub cmbUnitFabric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitFabric.SelectedIndexChanged
        txtWeightMax.Focus()
    End Sub

    Private Sub txtWeightMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeightMin.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWeightMax.Focus()
        End If
    End Sub

    Private Sub txtWeightMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeightMax.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDNYardage.Focus()
        End If
    End Sub

    Private Sub txtDNYardage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNYardage.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWeightYard.Focus()
        End If
    End Sub

    Private Sub txtWeightYard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeightYard.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBeforeWash.Focus()
        End If
    End Sub

    Private Sub txtBeforeWash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBeforeWash.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAfterWash.Focus()
        End If
    End Sub

    Private Sub txtAfterWash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAfterWash.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNetWeight.Focus()
        End If
    End Sub

    Private Sub txtNetWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSrinkageL.Focus()
        End If
    End Sub

    Private Sub txtSrinkageL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSrinkageL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSrinkageW.Focus()
        End If
    End Sub

    Private Sub txtSrinkageW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSrinkageW.KeyPress
        If e.KeyChar = Chr(13) Then
            txtGSM.Focus()
        End If
    End Sub

    Private Sub txtGSM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGSM.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPriceGreige.Focus()
        End If
    End Sub

    Private Sub txtPriceGreige_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceGreige.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPurchSize.Focus()
        End If
    End Sub

    Private Sub txtPurchSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPurchSize.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStorageSize.Focus()
        End If
    End Sub

    Private Sub txtStorageSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStorageSize.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPPSample.Focus()
        End If
    End Sub

    Private Sub txtPPSample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPSample.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQtyCutt.Focus()
        End If
    End Sub

    Private Sub txtQtyCutt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtyCutt.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQtyWeight.Focus()
        End If
    End Sub

    Private Sub txtQtyWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtyWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAddFabric.Focus()
        End If
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged
        txtColorType.Focus()
    End Sub

    Private Sub txtColorType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColorType.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLabColNo.Focus()
        End If
    End Sub

    Private Sub txtLabColNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLabColNo.KeyPress
        If e.KeyChar = Chr(13) Then
            txtColQtyOrder.Focus()
        End If
    End Sub

    Private Sub txtColQtyOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColQtyOrder.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbColPurchSize.Focus()
        End If
    End Sub

    Private Sub cmbColPurchSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColPurchSize.SelectedIndexChanged
        txtColPrice.Focus()
    End Sub

    Private Sub txtColPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColPrice.KeyPress
        If e.KeyChar = Chr(13) Then
            txtColQtySample.Focus()
        End If
    End Sub

    Private Sub txtColQtySample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColQtySample.KeyPress
        If e.KeyChar = Chr(13) Then
            dtpColDelDate.Focus()
        End If
    End Sub

    Private Sub txtColNotes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColNotes.KeyPress
        If e.KeyChar = Chr(13) Then
            btnColAddList.Focus()
        End If
    End Sub

    Private Sub cmbYarn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbYarn.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPriceYarn.Focus()
        End If
    End Sub

    Private Sub txtPriceYarn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceYarn.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPercentUsage.Focus()
        End If
    End Sub

    Private Sub txtPercentUsage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercentUsage.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQtyUsage.Focus()
        End If
    End Sub

    Private Sub txtQtyUsage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtyUsage.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbColorYarn.Focus()
        End If
    End Sub

    Private Sub cmbYarn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYarn.SelectedIndexChanged
        cmbColorYarn.Focus()
    End Sub

    Private Sub cmbColorYarn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColorYarn.SelectedIndexChanged
        cmbMerk.Focus()
    End Sub

    Private Sub cmbMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMerk.SelectedIndexChanged
        txtLoss.Focus()
    End Sub

    Private Sub txtLoss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoss.KeyPress
        If e.KeyChar = Chr(13) Then
            btnAddYarnList.Focus()
        End If
    End Sub

    Private Sub cmbBankCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBankCode.SelectedIndexChanged
        txtRemarks.Focus()
    End Sub

    Private Sub txtRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks.KeyPress
        If e.KeyChar = Chr(13) Then
            btnRemAddList.Focus()
        End If
    End Sub
#End Region

#Region "Row State Change"
    Private Sub dgvFabric_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvFabric.RowStateChanged
        intPostFabric = e.Row.Index
    End Sub

    Private Sub dgvColor_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvColor.RowStateChanged
        intPostColor = e.Row.Index
    End Sub

    Private Sub dgvYarn_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvYarn.RowStateChanged
        intPostYarn = e.Row.Index
    End Sub

    Private Sub dgvRemarks_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvRemarks.RowStateChanged
        intPostRemarks = e.Row.Index
    End Sub
#End Region
End Class