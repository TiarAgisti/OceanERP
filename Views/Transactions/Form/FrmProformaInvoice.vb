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
    Dim statusPI As Integer
#End Region

#Region "ComboBox"
    Sub ComboBoxBuyer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim status As String = "C"
        Try
            vendorBFC.ComboBoxVendor(cmbBuyer, status)
            vendorBFC = Nothing
        Catch ex As Exception
            vendorBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxStyle()
        Dim styleBFC As ClsStyle = New ClsStyle
        Try
            styleBFC.ComboBoxStyle(cmbStyle)
            styleBFC.ComboBoxStyle(cmbFabricStyle)

            styleBFC = Nothing
        Catch ex As Exception
            styleBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxSeason()
        Dim seasonBFC As ClsSeason = New ClsSeason
        Try
            seasonBFC.ComboBoxSeason(cmbSeason)
            seasonBFC = Nothing
        Catch ex As Exception
            seasonBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxPort()
        Dim destiBFC As ClsDestination = New ClsDestination
        Dim status As String = "S"
        Try
            destiBFC.ComboBoxDestination(cmbPort, status)
            destiBFC = Nothing
        Catch ex As Exception
            destiBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxCustomer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim status As String = "C"
        Try
            vendorBFC.ComboBoxVendor(cmbTo, status)
            vendorBFC = Nothing
        Catch ex As Exception
            vendorBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxMarketing()
        Dim salesBFC As ClsGroupSales = New ClsGroupSales
        Try
            salesBFC.ComboBoxSales(cmbFM)
            salesBFC = Nothing
        Catch ex As Exception
            salesBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxFabric()
        Dim fabricBFC As ClsFabric = New ClsFabric
        Try
            fabricBFC.ComboBoxFabric(cmbFabric)
            fabricBFC = Nothing
        Catch ex As Exception
            fabricBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxRawMaterial()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Try
            rawBFC.ComboBoxRawMaterial(cmbRawFabric)
            rawBFC = Nothing
        Catch ex As Exception
            rawBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        Try
            unitBFC.ComboBoxUnit(cmbUnitFabric)
            unitBFC.ComboBoxUnit(cmbColPurchSize)

            unitBFC = Nothing
        Catch ex As Exception
            unitBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxColor()
        Dim colorBFC As ClsColor = New ClsColor
        Try
            colorBFC.ComboBoxColor(cmbColor)
            colorBFC = Nothing
        Catch ex As Exception
            colorBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxYarn()
        Dim yarnBFC As ClsYarn = New ClsYarn
        Try
            yarnBFC.ComboBoxYarn(cmbYarn)
            yarnBFC = Nothing
        Catch ex As Exception
            yarnBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxBrandYarn()
        Dim brandYarn As ClsBrandYarn = New ClsBrandYarn
        Try
            brandYarn.ComboBoxBrandYarn(cmbMerk)
            brandYarn = Nothing
        Catch ex As Exception
            brandYarn = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxColorYarn()
        Dim colorBFC As ClsColor = New ClsColor
        Try
            colorBFC.ComboBoxColorYarn(cmbColorYarn)
            colorBFC = Nothing
        Catch ex As Exception
            colorBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxBank()
        Dim bankAccountBFC As ClsBankAccount = New ClsBankAccount
        Try
            bankAccountBFC.ComboBoxBankAccount(cmbBankCode)
            bankAccountBFC = Nothing
        Catch ex As Exception
            bankAccountBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxTermOfPayment()
        Dim topBFC As ClsTermOfPayment = New ClsTermOfPayment
        Try
            topBFC.ComboBoxTOP(cmbTOP)
            topBFC = Nothing
        Catch ex As Exception
            topBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxTermPrice()
        Dim termPriceBFC As ClsTermOfPrice = New ClsTermOfPrice
        Try
            termPriceBFC.ComboBoxTermPrice(cmbTermPrice)
            termPriceBFC = Nothing
        Catch ex As Exception
            termPriceBFC = Nothing
            Throw ex
        End Try
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
            .Columns.Add(18, "Net Weight")
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
            .Columns(10).DefaultCellStyle.Format = "dd-MMM-yyyy"

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
        txtWidthMin.Text = 0
        txtWidthMax.Text = 0
        txtWeightMin.Text = 0
        txtWeightMax.Text = 0
        txtDNYardage.Text = 0
        txtWeightYard.Text = 0
        txtBeforeWash.Text = 0
        txtAfterWash.Text = 0
        txtNetWeight.Text = 0
        txtSrinkageL.Clear()
        txtSrinkageW.Clear()
        txtGSM.Clear()
        txtPriceGreige.Text = 0
        txtPurchSize.Clear()
        txtStorageSize.Text = 0
        txtPPSample.Clear()
        txtQtyCutt.Text = 0
        txtQtyWeight.Text = 0
    End Sub

    Sub ClearColorFabric()
        txtColor.Clear()
        txtColorType.Clear()
        txtLabColNo.Clear()
        txtColQtyOrder.Text = 0
        txtColPrice.Text = 0
        txtColQtySample.Text = 0
        txtColNotes.Clear()
    End Sub

    Sub ClearYarn()
        txtSuppYarn.Clear()
        txtPriceYarn.Text = 0
        txtPercentUsage.Text = 0
        txtQtyUsage.Text = 0
        txtLoss.Text = 0
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
        DeleteGrid(dgvFabric)
        intBarisFabric = intBarisFabric - 1
    End Sub
    Sub DeleteGridDetailColor()
        DeleteGrid(dgvColor)
        intBarisColor = intBarisColor - 1
    End Sub
    Sub DeleteGridDetailYarn()
        DeleteGrid(dgvYarn)
        intBarisYarn = intBarisYarn - 1
    End Sub
    Sub DeleteGridDetailRemarks()
        DeleteGrid(dgvRemarks)
        intBarisRemarks = intBarisRemarks - 1
    End Sub
#End Region

#Region "Check Empty"
    Function CheckEmptyHeader() As Boolean
        Dim check As Boolean = True
        If cmbBuyer.SelectedValue = 0 Then
            MsgBoxWarning("Buyer not valid")
            cmbBuyer.Focus()
        ElseIf String.IsNullOrEmpty(Trim(txtRefPO.Text)) Then
            MsgBoxWarning("Ref PO can't empty")
            txtRefPO.Focus()
        ElseIf cmbStyle.SelectedValue = 0 Then
            MsgBoxWarning("Style not valid")
            cmbStyle.Focus()
        ElseIf cmbSeason.SelectedValue = 0 Then
            MsgBoxWarning("Season not valid")
            cmbSeason.Focus()
        ElseIf cmbTOP.SelectedValue = 0 Then
            MsgBoxWarning("Term Of Payment not valid")
            cmbTOP.Focus()
        ElseIf cmbTermPrice.SelectedValue = 0 Then
            MsgBoxWarning("Term Of Price not valid")
            cmbTermPrice.Focus()
        ElseIf String.IsNullOrEmpty(Trim(txtContract.Text)) Then
            MsgBoxWarning("Contract No can't empty")
            txtContract.Focus()
        ElseIf cmbTo.SelectedValue = 0 Then
            MsgBoxWarning("Customer not valid")
            cmbTo.Focus()
        ElseIf cmbFM.SelectedValue = 0 Then
            MsgBoxWarning("FM not valid")
            cmbFM.Focus()
        ElseIf String.IsNullOrEmpty(Trim(txtDelPlace.Text)) Then
            MsgBoxWarning("Delivery Place can't empty")
            txtDelPlace.Focus()
        ElseIf dgvFabric.Rows.Count - 1 = 0 Then
            MsgBoxWarning("Detail can't empty")
            cmbFabric.Focus()
        Else
            check = False
        End If
        Return check
    End Function

    Function CheckEmptyFabric() As Boolean
        Dim check As Boolean = True
        If cmbFabric.SelectedValue = 0 Then
            MsgBoxWarning("Fabric not valid")
            cmbFabric.Focus()
        ElseIf cmbFabricStyle.SelectedValue = 0 Then
            MsgBoxWarning("Style For Fabric not valid")
            cmbFabricStyle.Focus()
        ElseIf cmbRawFabric.SelectedValue = 0 Then
            MsgBoxWarning("Raw Material For Fabric not valid")
            cmbRawFabric.Focus()
        ElseIf cmbTypeGreige.Text = "" Then
            MsgBoxWarning("Type Greige Cant Empty")
            cmbTypeGreige.Focus()
        ElseIf cmbUnitFabric.SelectedValue = 0 Then
            MsgBoxWarning("Unit For Fabric not valid")
            cmbUnitFabric.Focus()
        Else
            check = False
        End If
        Return check
    End Function

    Function CheckEmptyColor() As Boolean
        Dim check As Boolean = True
        If cmbColor.SelectedValue = 0 Then
            MsgBoxWarning("Color not valid")
            cmbColor.Focus()
        ElseIf Trim(txtColQtyOrder.Text) = String.Empty Then
            MsgBoxWarning("Qty Order can't empty")
            txtColQtyOrder.Focus()
        ElseIf Trim(txtColQtyOrder.Text) = 0 Then
            MsgBoxWarning("Qty Order cant empty or 0")
            txtColQtyOrder.Focus()
        ElseIf Trim(txtColPrice.Text) = String.Empty Then
            MsgBoxWarning("Price cant empty or 0")
            txtColPrice.Focus()
        ElseIf txtColPrice.Text = 0 Then
            MsgBoxWarning("Price cant empty or 0")
            txtColPrice.Focus()
        ElseIf Trim(txtColQtySample.Text) = String.Empty Then
            MsgBoxWarning("Qty Sample cant empty or 0")
            txtColQtySample.Focus()
        ElseIf txtColQtySample.Text = 0 Then
            MsgBoxWarning("Qty Sample cant empty or 0")
            txtColQtySample.Focus()
        Else
            check = False
        End If
        Return check
    End Function

    Function CheckEmptyYarn() As Boolean
        Dim check As Boolean = True
        If cmbYarn.SelectedValue = 0 Then
            MsgBoxWarning("Yarn not valid")
            cmbYarn.Focus()
        ElseIf Trim(txtPriceYarn.Text) = String.Empty Then
            MsgBoxWarning("Price Yarn cant empty or 0")
            txtPriceYarn.Focus()
        ElseIf txtPriceYarn.Text = 0 Then
            MsgBoxWarning("Price Yarn cant empty or 0")
            txtPriceYarn.Focus()
        ElseIf Trim(txtQtyUsage.Text) = String.Empty Then
            MsgBoxWarning("Qty Usage cant empty or 0")
            txtQtyUsage.Focus()
        ElseIf txtQtyUsage.Text = 0 Then
            MsgBoxWarning("Qty Usage cant empty or 0")
            txtQtyUsage.Focus()
        ElseIf cmbColorYarn.SelectedValue = 0 Then
            MsgBoxWarning("Color Yarn not valid")
            cmbColorYarn.Focus()
        ElseIf cmbMerk.SelectedValue = 0 Then
            MsgBoxWarning("Merk not valid")
            cmbMerk.Focus()
        Else
            check = False
        End If
        Return check
    End Function

    Function CheckEmptyBank() As Boolean
        Dim check As Boolean = True
        If cmbBankCode.SelectedValue = 0 Then
            MsgBoxWarning("Bank not valid")
            cmbBankCode.Focus()
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
    Function CheckFabricInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean
        Try
            status = piBFC.CheckFabricInList(dgvFabric, cmbFabric.SelectedValue)
            piBFC = Nothing
            Return status
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function CheckColorInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean
        Try
            status = piBFC.CheckColorInList(dgvColor, cmbColor.SelectedValue)
            piBFC = Nothing
            Return status
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function CheckYarnInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean
        Try
            status = piBFC.CheckYarnInList(dgvYarn, cmbYarn.SelectedValue)
            piBFC = Nothing
            Return status
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function CheckRemarksInList() As Boolean
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim status As Boolean = True
        Try
            status = piBFC.CheckRemarksInList(dgvRemarks, txtRemarks.Text)
            piBFC = Nothing
            Return status
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader(piID As Long, piCode As String) As PIHeaderModel
        Dim headerModel As PIHeaderModel = New PIHeaderModel
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        With headerModel
            Select Case condition
                Case "Create"
                    .PIHeaderID = piID
                    piHeaderID = .PIHeaderID
                    .PIDate = Format(dtPIDate.Value, "yyyy-MM-dd")
                    .PINo = piCode
                    txtPINo.Text = .PINo
                    .CustomerID = cmbTo.SelectedValue
                    .BuyerID = cmbBuyer.SelectedValue
                    .GroupSalesID = cmbFM.SelectedValue
                    .RefPO = txtRefPO.Text
                    .StyleID = cmbStyle.SelectedValue
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
                    .PIHeaderID = piID
                    .PIDate = Format(dtPIDate.Value, "yyyy-MM-dd")
                    .PINo = txtPINo.Text
                    .CustomerID = cmbTo.SelectedValue
                    .BuyerID = cmbBuyer.SelectedValue
                    .GroupSalesID = cmbFM.SelectedValue
                    .RefPO = txtRefPO.Text
                    .StyleID = cmbStyle.SelectedValue
                    .SeasonID = cmbSeason.SelectedValue
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .DelTerm = Format(dtDelTerm.Value, "yyyy-MM-dd")
                    .TermOfPriceID = cmbTermPrice.SelectedValue
                    .ContractNo = txtContract.Text
                    .DestinationID = cmbPort.SelectedValue
                    .DeliveryPlace = txtDelPlace.Text
                    .Status = 1
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Approved"
                    .PIHeaderID = piID
                    .PINo = txtPINo.Text
                    .Status = 2
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Void"
                    .PIHeaderID = piID
                    .PINo = txtPINo.Text
                    .Status = 0
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return headerModel
    End Function

    Function SetDetailFabric(piID As Long) As List(Of PIDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim listModel As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Try
            listModel = piBFC.SetDetailFabric(piID, dgvFabric)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailColor(piID As Long) As List(Of PIColorDetailModel)
        Dim listModel As List(Of PIColorDetailModel) = New List(Of PIColorDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            listModel = piBFC.SetDetailColor(piID, dgvColor)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailYarn(piID As Long) As List(Of PIYarnDetailModel)
        Dim listModel As List(Of PIYarnDetailModel) = New List(Of PIYarnDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            listModel = piBFC.SetDetailYarn(piID, dgvYarn)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDataBank(piID As Long) As PIBankDetailModel
        Dim myModel As PIBankDetailModel = New PIBankDetailModel
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            myModel.PIHeaderID = piID
            myModel.PIBankDetailID = piBFC.GetPIDetailBankID
            myModel.BankAccountID = cmbBankCode.SelectedValue
            piBFC = Nothing
            Return myModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailRemarks(piID As Long) As List(Of PIRemarksModel)
        Dim listModel As List(Of PIRemarksModel) = New List(Of PIRemarksModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            listModel = piBFC.SetDetailRemarks(piID, dgvRemarks)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
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
            If piBFC.InsertData(SetDataHeader(myPIID, myPINo), SetDetailFabric(myPIID), SetDetailColor(myPIID), SetDetailYarn(myPIID) _
                                , SetDetailRemarks(myPIID), SetDataBank(myPIID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxSaved()
                CheckPermissions()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
                'PreCreatedisplay()
            End If
            piBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            piBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub UpdateData()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Proforma Invoice,Where PINo = " + txtPINo.Text
        Try
            If piBFC.UpdateData(SetDataHeader(piHeaderID, txtPINo.Text), SetDetailFabric(piHeaderID), SetDetailColor(piHeaderID), SetDetailYarn(piHeaderID) _
                                , SetDetailRemarks(piHeaderID), SetDataBank(piHeaderID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxUpdated()
                CheckPermissions()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
            piBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            piBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ApprovedData()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Approved proforma invoice where PINO = " + txtPINo.Text
        condition = "Approved"
        Try
            If piBFC.UpdateStatusHeader(SetDataHeader(piHeaderID, txtPINo.Text), logBFC.SetLogHistoryTrans(logDesc)) Then
                MsgBoxApproved()
                PreCreatedisplay()
            End If
            piBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            piBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub VoidData()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Void proforma invoice where PINO = " + txtPINo.Text
        condition = "Void"
        Try
            If piBFC.UpdateStatusHeader(SetDataHeader(piHeaderID, txtPINo.Text), logBFC.SetLogHistoryTrans(logDesc)) Then
                MsgBoxVoid()
                PreCreatedisplay()
            End If
            piBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            piBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrintData()
        Dim piPrint As ClsPrintOut = New ClsPrintOut
        Try
            If piPrint.PrintOutProformaInvoice(txtPINo.Text) Then
                PreCreatedisplay()
            Else
                MsgBoxError("Failed to print")
            End If
            piPrint = Nothing
        Catch ex As Exception
            piPrint = Nothing
            Throw ex
        End Try
    End Sub

    Sub ClearVariable()
        intBarisFabric = 0
        intPostFabric = 0
        intBarisColor = 0
        intPostColor = 0
        intBarisYarn = 0
        intPostYarn = 0
        intBarisRemarks = 0
        intPostRemarks = 0
    End Sub
    Sub ClearDataGrid()
        dgvFabric.Columns.Clear()
        dgvColor.Columns.Clear()
        dgvYarn.Columns.Clear()
        dgvRemarks.Columns.Clear()
    End Sub

    Sub ClearAllData()
        ClearVariable()
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
        Try
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub RetrieveCustomer()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim vendorModel As VendorModel = New VendorModel
        Try
            Dim obj As Integer = cmbTo.SelectedValue
            If obj > 0 Then
                vendorModel = vendorBFC.RetrieveVendorByID(obj, "C")
                With vendorModel
                    customerCode = .VendorCode
                    txtTlp.Text = .Telephone
                    txtAttention.Text = .ContactPerson
                    txtAddress.Text = .Address
                    txtFax.Text = .Fax
                End With
            Else
                MsgBoxError("Customer not valid")
            End If
            vendorBFC = Nothing
            vendorModel = Nothing
        Catch ex As Exception
            vendorBFC = Nothing
            vendorModel = Nothing
            Throw ex
        End Try
    End Sub

    Sub RetrieveFabric()
        Dim fabricBFC As ClsFabric = New ClsFabric
        Dim fabricModel As FabricModel = New FabricModel
        Try
            Dim fabricID As Integer = cmbFabric.SelectedValue
            If fabricID > 0 Then
                fabricModel = fabricBFC.RetrieveByID(fabricID)
                With fabricModel
                    txtSpec.Text = fabricModel.Specification
                End With
            Else
                MsgBoxError("Fabric Not Valid")
            End If
            fabricBFC = Nothing
            fabricModel = Nothing
        Catch ex As Exception
            fabricBFC = Nothing
            fabricModel = Nothing
            Throw ex
        End Try
    End Sub

    Sub RetrieveColor()
        Dim colorBFC As ClsColor = New ClsColor
        Dim colorModel As ColorModel = New ColorModel
        Try
            Dim colorID As Integer = cmbColor.SelectedValue
            If colorID > 0 Then
                colorModel = colorBFC.RetrieveByID(colorID)
                With colorModel
                    txtColor.Text = .ColorName
                End With
            Else
                MsgBoxError("Color Code not valid")
            End If
            colorBFC = Nothing
            colorModel = Nothing
        Catch ex As Exception
            colorBFC = Nothing
            colorModel = Nothing
            Throw ex
        End Try
    End Sub

    Sub RetrieveYarn()
        Dim yarnBFC As ClsYarn = New ClsYarn
        Dim yarnModel As YarnModel = New YarnModel
        Try
            Dim yarnID As Integer = cmbYarn.SelectedValue
            If yarnID > 0 Then
                yarnModel = yarnBFC.RetrieveByID(yarnID)
                With yarnModel
                    txtSuppYarn.Text = yarnModel.VendorName
                End With
            Else
                MsgBoxError("Yarn not valid")
            End If
            yarnBFC = Nothing
            yarnModel = Nothing
        Catch ex As Exception
            yarnBFC = Nothing
            yarnModel = Nothing
            Throw ex
        End Try
    End Sub

    Sub RetrieveBankAccount()
        Dim bankAccountBFC As ClsBankAccount = New ClsBankAccount
        Dim bankAccountModel As BankAccountModel = New BankAccountModel
        Try
            Dim bankAccountID As Integer = cmbBankCode.SelectedValue
            If bankAccountID > 0 Then
                bankAccountModel = bankAccountBFC.RetrieveByID(bankAccountID)
                With bankAccountModel
                    txtBank.Text = .BankName
                    txtAccName.Text = .AccountName
                    txtAccNumber.Text = .AccountNumber
                    txtSwiftCode.Text = .SwiftCode
                End With
            End If
            bankAccountBFC = Nothing
            bankAccountModel = Nothing
        Catch ex As Exception
            bankAccountBFC = Nothing
            bankAccountModel = Nothing
            Throw ex
        End Try
    End Sub

    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        Try
            roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
            If roleModel.IsCreate = True Then btnSave.Enabled = True
            If roleModel.IsUpdate = True Then btnUpdate.Enabled = True
            If roleModel.IsApprove = True Then btnApprove.Enabled = True
            If roleModel.IsVoid = True Then btnVoid.Enabled = True

            roleBFC = Nothing
            roleModel = Nothing
        Catch ex As Exception
            roleBFC = Nothing
            roleModel = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareHeaderByID()
        ComboBoxALL()
        Dim headerModel As PIHeaderModel = New PIHeaderModel
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            headerModel = piBFC.RetrieveByID(piHeaderID)
            With headerModel
                txtPINo.Text = .PINo
                dtPIDate.Value = .PIDate
                cmbBuyer.SelectedValue = .BuyerID
                txtRefPO.Text = .RefPO
                cmbStyle.SelectedValue = .StyleID
                cmbSeason.SelectedValue = .SeasonID
                cmbTOP.SelectedValue = .TermOfPaymentID
                dtDelTerm.Value = .DelTerm
                cmbTermPrice.SelectedValue = .TermOfPriceID
                txtContract.Text = .ContractNo
                cmbPort.SelectedValue = .DestinationID
                cmbTo.SelectedValue = .CustomerID
                cmbFM.SelectedValue = .GroupSalesID
                txtDelPlace.Text = .DeliveryPlace
                statusPI = .Status
            End With
            headerModel = Nothing
            piBFC = Nothing
        Catch ex As Exception
            headerModel = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareFabricByHeaderID()
        Dim listFabric As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            GridDetailFabric()
            listFabric = piBFC.RetrieveFabricByHeaderID(piHeaderID)
            For Each detail In listFabric
                With dgvFabric
                    .Rows.Add()
                    .Item(0, intBarisFabric).Value = detail.FabricID
                    .Item(1, intBarisFabric).Value = detail.FabricName
                    .Item(2, intBarisFabric).Value = detail.Specification
                    .Item(3, intBarisFabric).Value = detail.StyleID
                    .Item(4, intBarisFabric).Value = detail.StyleName
                    .Item(5, intBarisFabric).Value = detail.RawMaterialID
                    .Item(6, intBarisFabric).Value = detail.RawMaterialName
                    .Item(7, intBarisFabric).Value = detail.TypeGreige
                    .Item(8, intBarisFabric).Value = detail.WidthMin
                    .Item(9, intBarisFabric).Value = detail.WidthMax
                    .Item(10, intBarisFabric).Value = detail.UnitID
                    .Item(11, intBarisFabric).Value = detail.UnitName
                    .Item(12, intBarisFabric).Value = detail.WeightMin
                    .Item(13, intBarisFabric).Value = detail.WeightMax
                    .Item(14, intBarisFabric).Value = detail.DNYardage
                    .Item(15, intBarisFabric).Value = detail.WeightYard
                    .Item(16, intBarisFabric).Value = detail.BeforeWash
                    .Item(17, intBarisFabric).Value = detail.AfterWash
                    .Item(18, intBarisFabric).Value = detail.NetWeight
                    .Item(19, intBarisFabric).Value = detail.SrinkageL
                    .Item(20, intBarisFabric).Value = detail.SrinkageW
                    .Item(21, intBarisFabric).Value = detail.GSM
                    .Item(22, intBarisFabric).Value = detail.PriceGreige
                    .Item(23, intBarisFabric).Value = detail.PurchSize
                    .Item(24, intBarisFabric).Value = detail.StorageSize
                    .Item(25, intBarisFabric).Value = detail.PPSample
                    .Item(26, intBarisFabric).Value = detail.QtyCuttable
                    .Item(27, intBarisFabric).Value = detail.QtyWeight
                End With
                intBarisFabric = intBarisFabric + 1
            Next
            listFabric = Nothing
            piBFC = Nothing
        Catch ex As Exception
            listFabric = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareColorByHeaderID()
        Dim listColor As List(Of PIColorDetailModel) = New List(Of PIColorDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            GridDetailColor()
            listColor = piBFC.RetrieveColorByHeaderID(piHeaderID)
            For Each detail In listColor
                With dgvColor
                    .Rows.Add()
                    .Item(0, intBarisColor).Value = detail.ColorID
                    .Item(1, intBarisColor).Value = detail.ColorCode
                    .Item(2, intBarisColor).Value = detail.ColorName
                    .Item(3, intBarisColor).Value = detail.ColorType
                    .Item(4, intBarisColor).Value = detail.ColorLabNumber
                    .Item(5, intBarisColor).Value = detail.QtyOrder
                    .Item(6, intBarisColor).Value = detail.PurchSizeID
                    .Item(7, intBarisColor).Value = detail.PurchSizeName
                    .Item(8, intBarisColor).Value = detail.Price
                    .Item(9, intBarisColor).Value = detail.QtySample
                    .Item(10, intBarisColor).Value = detail.DelDate
                    .Item(11, intBarisColor).Value = detail.Note
                End With
                intBarisColor = intBarisColor + 1
            Next
            listColor = Nothing
            piBFC = Nothing
        Catch ex As Exception
            listColor = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareYarnByHeaderID()
        Dim listYarn As List(Of PIYarnDetailModel) = New List(Of PIYarnDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            GridDetailYarn()
            listYarn = piBFC.RetrieveYarnByHeaderID(piHeaderID)
            For Each detail In listYarn
                With dgvYarn
                    .Rows.Add()
                    .Item(0, intBarisYarn).Value = detail.YarnID
                    .Item(1, intBarisYarn).Value = detail.YarnName
                    .Item(2, intBarisYarn).Value = detail.VendorName
                    .Item(3, intBarisYarn).Value = detail.PriceYarn
                    .Item(4, intBarisYarn).Value = detail.PercentageUsage
                    .Item(5, intBarisYarn).Value = detail.QtyUsage
                    .Item(6, intBarisYarn).Value = detail.ColorID
                    .Item(7, intBarisYarn).Value = detail.ColorName
                    .Item(8, intBarisYarn).Value = detail.BrandYarnID
                    .Item(9, intBarisYarn).Value = detail.BrandYarnName
                    .Item(10, intBarisYarn).Value = detail.Loss
                End With
                intBarisYarn = intBarisYarn + 1
            Next
            listYarn = Nothing
            piBFC = Nothing
        Catch ex As Exception
            listYarn = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareBankByHeaderID()
        Dim piBankAccountModel As PIBankDetailModel = New PIBankDetailModel
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            ComboBoxBank()
            piBankAccountModel = piBFC.RetrieveBankByHeaderID(piHeaderID)
            With piBankAccountModel
                cmbBankCode.SelectedValue = .BankAccountID
                txtBank.Text = .BankName
                txtAccName.Text = .AccountName
                txtAccNumber.Text = .AccountNumber
                txtSwiftCode.Text = .SwiftCode
            End With
            piBankAccountModel = Nothing
            piBFC = Nothing
        Catch ex As Exception
            piBankAccountModel = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareRemarksByHeaderID()
        Dim listRemarks As List(Of PIRemarksModel) = New List(Of PIRemarksModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            GridDetailRemark()
            listRemarks = piBFC.RetrieveRemarksByHeaderID(piHeaderID)
            For Each detail In listRemarks
                With dgvRemarks
                    .Rows.Add()
                    .Item(0, intBarisRemarks).Value = detail.Remarks
                End With
                intBarisRemarks = intBarisRemarks + 1
            Next
            listRemarks = Nothing
            piBFC = Nothing
        Catch ex As Exception
            listRemarks = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PreCreatedisplay()
        Try
            CheckPermissions()
            ClearDataGrid()
            ClearAllData()
            GridDetailALL()
            ComboBoxALL()
            cmbBuyer.Focus()
            btnApprove.Enabled = False
            btnVoid.Enabled = False
            btnPrint.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub PreUpdateDisplay()
        Try
            ClearAllData()
            ClearDataGrid()
            CheckPermissions()
            PrepareHeaderByID()
            PrepareFabricByHeaderID()
            PrepareColorByHeaderID()
            PrepareBankByHeaderID()
            PrepareYarnByHeaderID()
            PrepareRemarksByHeaderID()
            If statusPI = 0 Then btnPrint.Enabled = False Else btnPrint.Enabled = True
            If statusPI = 0 Or statusPI = 2 Then btnApprove.Enabled = False
            If statusPI = 0 Then btnVoid.Enabled = False
            btnSave.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FrmProformaInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case condition
                Case "Create"
                    PreCreatedisplay()
                Case "Update"
                    PreUpdateDisplay()
            End Select
            Text = title
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Button"
    Private Sub btnAddFabric_Click(sender As Object, e As EventArgs) Handles btnAddFabric.Click
        If CheckEmptyFabric() = False Then
            Try
                If CheckFabricInList() = True Then
                    AddGridDetailFabric()
                    ClearFabric()
                Else
                    MsgBoxError("Fabric Available in list")
                    ClearFabric()
                End If
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
        If CheckEmptyColor() = False Then
            Try
                If CheckColorInList() = True Then
                    AddGridDetailColor()
                    ClearColorFabric()
                Else
                    MsgBoxError("Color available in list")
                    ClearColorFabric()
                End If
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
        If CheckEmptyYarn() = False Then
            Try
                If CheckYarnInList() = True Then
                    AddGridDetailYarn()
                    ClearYarn()
                Else
                    MsgBoxError("Yarn available in list")
                End If
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmptyHeader() = False And CheckEmptyBank() = False Then
            If condition = "Create" Then
                Try
                    InsertData()
                Catch ex As Exception
                    MsgBoxError(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckEmptyHeader() = False And CheckEmptyBank() = False Then
            If condition = "Update" Then
                Try
                    UpdateData()
                Catch ex As Exception
                    MsgBoxError(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            PrintData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Try
            ApprovedData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Try
            VoidData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
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
    Private Sub cmbTo_Validated(sender As Object, e As EventArgs) Handles cmbTo.Validated
        Try
            RetrieveCustomer()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
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
    Private Sub cmbFabric_Validated(sender As Object, e As EventArgs) Handles cmbFabric.Validated
        RetrieveFabric()
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
        txtWeightMin.Focus()
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
    Private Sub cmbColor_Validated(sender As Object, e As EventArgs) Handles cmbColor.Validated
        RetrieveColor()
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
    Private Sub cmbYarn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYarn.SelectedIndexChanged
        txtPriceYarn.Focus()
    End Sub
    Private Sub cmbYarn_Validated(sender As Object, e As EventArgs) Handles cmbYarn.Validated
        RetrieveYarn()
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
        Try
            RetrieveBankAccount()
        Catch ex As Exception

        End Try
        txtRemarks.Focus()
    End Sub
    Private Sub cmbBankCode_Validated(sender As Object, e As EventArgs) Handles cmbBankCode.Validated

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

    Private Sub dgvYarn_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs)
        intPostYarn = e.Row.Index
    End Sub

    Private Sub dgvRemarks_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvRemarks.RowStateChanged
        intPostRemarks = e.Row.Index
    End Sub
#End Region
End Class