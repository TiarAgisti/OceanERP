Imports System.ComponentModel
Public Class FrmPI

#Region "Declaration"
    Public conBon As String
    Public Shared boID As Long = 0
    Public Shared boHeaderID As Long = 0
    Dim intBarisfabric As Integer
    Dim intPostfabric As Integer
    Dim intBarisColor As Integer
    Dim intPostRawColor As Integer
    Dim intBarisYarn As Integer
    Dim intPostRawYArn As Integer
    Dim intBarisRemarks As Integer
    Dim intPostRemarks As Integer
    Dim status As Int16
    Dim msgError As String = "Error PI: "
#End Region

#Region "ComboBox"
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
    Sub ComboBoxFabric()
        Dim boBFC As ClsBO = New ClsBO
        Try
            boBFC.ComboBoxFabric1(cmbFabric, boID)
            boBFC = Nothing
        Catch ex As Exception
            boBFC = Nothing
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

    Sub ComboBoxColor(boID As Long, fabricID As Integer)

        Dim boBFC As ClsBO = New ClsBO
        Try
            boBFC.ComboBoxColor(cmbColor, boID, fabricID)
            boBFC = Nothing
        Catch ex As Exception
            boBFC = Nothing
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
    Sub ComboBoxYarn(boID As Long)
        Dim boBFC As ClsBO = New ClsBO
        Try
            boBFC.ComboBoxYarn(cmbYarn, boID)
            boBFC = Nothing
        Catch ex As Exception
            boBFC = Nothing
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

    Sub ComboBoxColorYarn()
        Dim colorBFC As ClsColor = New ClsColor
        Try
            colorBFC.ComboBoxColor(cmbColorYarn)
            colorBFC = Nothing
        Catch ex As Exception
            colorBFC = Nothing
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
    Sub ComboBoxCurrency()
        Dim CurrBFC As ClsCurrency = New ClsCurrency
        CurrBFC.ComboBoxCurrency(cmbCurrency)
    End Sub
    Sub RetrieveFabric()
        Dim fabricBFC As ClsFabric = New ClsFabric
        Dim fabricModel As FabricModel = New FabricModel

        Dim obj As Integer = cmbFabric.SelectedValue
        If obj > 0 Then
            fabricModel = fabricBFC.RetrieveByID(obj)
            With fabricModel
                txtSpec.Text = .Specification
            End With
        Else
            MsgBoxError("Supplier not valid")
        End If
    End Sub
    Sub RetrieveColor()
        Dim colorBFC As ClsColor = New ClsColor
        Dim colocModel As ColorModel = New ColorModel

        Dim obj As Integer = cmbColor.SelectedValue
        If obj > 0 Then
            colocModel = colorBFC.RetrieveByID(obj)
            With colocModel
                txtColor.Text = .ColorName
            End With
        Else
            MsgBoxError("Color not valid")
        End If
    End Sub
    Sub RetrieveQtyorderColor(boID As Long, fabricID As Integer, colorID As Integer)
        Dim dataTable As DataTable = New DataTable
        Dim boBFC As ClsBO = New ClsBO
        Dim bocolordetailModel As BOColorDetailModel = New BOColorDetailModel

        Try

            fabricID = cmbFabric.SelectedValue
            colorID = cmbColor.SelectedValue
            If colorID > 0 Then
                bocolordetailModel = boBFC.RetrieveDetailColorforPI(boID, fabricID, colorID)
                With bocolordetailModel
                    txtColQtyOrder.Text = .Netto

                End With
            Else
                MsgBoxError("Color not valid")
            End If
            bocolordetailModel = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub RetrieveYarn()
        Dim yarnBFC As ClsYarn = New ClsYarn
        Dim yarnModel As YarnModel = New YarnModel

        Dim obj As Integer = cmbYarn.SelectedValue
        If obj > 0 Then
            yarnModel = yarnBFC.RetrieveByID(obj)
            With yarnModel
                txtSuppYarn.Text = .VendorName
            End With
        Else
            MsgBoxError("Yarn not valid")
        End If
    End Sub
    Sub ComboBoxALL()
        Try
            ComboBoxBank()
            ComboBoxBrandYarn()
            ComboBoxColor(boID, cmbFabric.SelectedValue)
            ComboBoxRawMaterial()
            ComboBoxSeason()
            ComboBoxTermOfPayment()
            ComboBoxTermPrice()
            ComboBoxUnit()
            ComboBoxCurrency()
            ComboBoxPort()
            ComboBoxColorYarn()
            ComboBoxFabric()
            ComboBoxYarn(boID)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GridALL()
        GridDetailFabric()
        GridDetailColor()
        GridDetailYarn()
        GridDetailRemark()
    End Sub
#End Region

#Region "Grid Detail"
    Sub GridDetailFabric()
        With dgvFabric
            .Columns.Add(0, "FabricID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Fabric")
            .Columns.Add(2, "Spec Fabric")


            .Columns.Add(3, "Raw Mat ID")
            .Columns(3).Visible = False

            .Columns.Add(4, "Raw Material")
            .Columns.Add(5, "Type Greige")
            .Columns.Add(6, "Width Min")
            .Columns.Add(7, "Width Max")

            .Columns.Add(8, "Unit ID")
            .Columns(8).Visible = False

            .Columns.Add(9, "Unit")
            .Columns.Add(10, "Weight Min")
            .Columns.Add(11, "Weight Max")
            .Columns.Add(12, "DN Yardage")
            .Columns.Add(13, "Weight Yard")
            .Columns.Add(14, "Before Wash")
            .Columns.Add(15, "After Wash")
            .Columns.Add(16, "Net Weight")
            .Columns.Add(17, "Srinkage L")
            .Columns.Add(18, "Srinkage W")
            .Columns.Add(19, "G / SM")
            .Columns.Add(20, "Price Greige")
            .Columns.Add(21, "Purch Size")
            .Columns.Add(22, "Storage Size")
            .Columns.Add(23, "PP Sample")
            .Columns.Add(24, "Qty Cuttable")
            .Columns.Add(25, "Qty Weight")
        End With
    End Sub
    Sub GridDetailColor()
        With dgvColor
            .Columns.Add(0, "Color ID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Color Code")
            .Columns.Add(2, "Color")
            .Columns.Add(3, "Color Type")
            .Columns.Add(4, "Qty Order")

            .Columns.Add(5, "Purch Size ID")
            .Columns(5).Visible = False

            .Columns.Add(6, "Purch Size")
            .Columns.Add(7, "Price")
            .Columns.Add(8, "Qty Sample")

            .Columns.Add(9, "Del Date")
            .Columns(9).DefaultCellStyle.Format = "dd-MMM-yyyy"

            .Columns.Add(10, "Note")
            .Columns.Add(11, "Fabric ID")
            .Columns(11).Visible = False
            .Columns.Add(12, "amount")
            .Columns(12).Visible = True
            .Columns.Add(13, "Currency")
            .Columns(13).Visible = False
            .Columns.Add(14, "Currency")
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
        txtAtention.Clear()
        txtDeliveryPlace.Clear()
        txtAddresDelvery.Clear()
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
        txtPPSample.Text = 0
        txtQtyCutt.Text = 0
        txtQtyWeight.Text = 0
    End Sub

    Sub ClearColorFabric()
        txtColor.Clear()
        txtColorType.Clear()
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
            .Item(0, intBarisfabric).Value = cmbFabric.SelectedValue
            .Item(1, intBarisfabric).Value = cmbFabric.Text
            .Item(2, intBarisfabric).Value = txtSpec.Text
            .Item(3, intBarisfabric).Value = cmbRawFabric.SelectedValue
            .Item(4, intBarisfabric).Value = cmbRawFabric.Text
            .Item(5, intBarisfabric).Value = cmbTypeGreige.Text
            .Item(6, intBarisfabric).Value = txtWidthMin.Text
            .Item(7, intBarisfabric).Value = txtWidthMax.Text
            .Item(8, intBarisfabric).Value = cmbUnitFabric.SelectedValue
            .Item(9, intBarisfabric).Value = cmbUnitFabric.Text
            .Item(10, intBarisfabric).Value = txtWeightMin.Text
            .Item(11, intBarisfabric).Value = txtWeightMax.Text
            .Item(12, intBarisfabric).Value = txtDNYardage.Text
            .Item(13, intBarisfabric).Value = txtWeightYard.Text
            .Item(14, intBarisfabric).Value = txtBeforeWash.Text
            .Item(15, intBarisfabric).Value = txtAfterWash.Text
            .Item(16, intBarisfabric).Value = txtNetWeight.Text
            .Item(17, intBarisfabric).Value = txtSrinkageL.Text
            .Item(18, intBarisfabric).Value = txtSrinkageW.Text
            .Item(19, intBarisfabric).Value = txtGSM.Text
            .Item(20, intBarisfabric).Value = txtPriceGreige.Text
            .Item(21, intBarisfabric).Value = txtPurchSize.Text
            .Item(22, intBarisfabric).Value = txtStorageSize.Text
            .Item(23, intBarisfabric).Value = txtPPSample.Text
            .Item(24, intBarisfabric).Value = txtQtyCutt.Text
            .Item(25, intBarisfabric).Value = txtQtyWeight.Text
        End With
        intBarisfabric = intBarisfabric + 1
    End Sub

    Sub AddGridDetailColor()
        With dgvColor
            .Rows.Add()
            .Item(0, intBarisColor).Value = cmbColor.SelectedValue
            .Item(1, intBarisColor).Value = cmbColor.Text
            .Item(2, intBarisColor).Value = txtColor.Text
            .Item(3, intBarisColor).Value = txtColorType.Text
            '  .Item(4, intBarisColor).Value = txtLabColNo.Text
            .Item(4, intBarisColor).Value = txtColQtyOrder.Text
            .Item(5, intBarisColor).Value = cmbColPurchSize.SelectedValue
            .Item(6, intBarisColor).Value = cmbColPurchSize.Text
            .Item(7, intBarisColor).Value = txtColPrice.Text
            .Item(8, intBarisColor).Value = txtColQtySample.Text
            .Item(9, intBarisColor).Value = dtpColDelDate.Value
            .Item(10, intBarisColor).Value = txtColNotes.Text
            .Item(11, intBarisColor).Value = cmbFabric.SelectedValue
            .Item(12, intBarisColor).Value = txtColPrice.Text * txtColQtyOrder.Text
            .Item(13, intBarisColor).Value = cmbCurrency.SelectedValue
            .Item(14, intBarisColor).Value = cmbCurrency.Text
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
        intBarisfabric = intBarisfabric - 1
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
        If cmbSeason.SelectedValue = 0 Then
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
        ElseIf String.IsNullOrEmpty(Trim(txtDeliveryPlace.Text)) Then
            MsgBoxWarning("Delivery Place can't empty")
            txtDeliveryPlace.Focus()
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

#Region "Function"
    Sub Sumamount()
        Dim subtotal As Double
        subtotal = 0
        For i As Integer = 0 To dgvColor.Rows.Count - 1
            subtotal = subtotal + Val(dgvColor.Rows(i).Cells(12).Value)
            '-----------cell 5 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        txtAmount.Text = subtotal
    End Sub
    Sub PrepareFabricByHeaderID()
        Try
            ComboBoxFabric()
        Catch ex As Exception
        End Try
    End Sub
    Sub PrepareColorByHeaderID()
        Try
            ComboBoxColor(boID, cmbFabric.SelectedValue)
            RetrieveQtyorderColor(boID, cmbFabric.SelectedValue, cmbColor.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub
    Sub PrepareYarnByHeaderID()
        Try
            ComboBoxYarn(boID)
            RetrieveYarn()
        Catch ex As Exception
        End Try
    End Sub
    Sub PrepareByHeaderID()
        Dim headerModel As BOHeaderModel = New BOHeaderModel
        Dim boBFC As ClsBO = New ClsBO
        Try

            headerModel = boBFC.RetrieveByID(boID)
            With headerModel
                txtPINo.Text = .NoOrder
                dtPIDate.Value = .DateIssues
                dtDelTerm.Value = .DeliveryDate
                txtBuyer.Text = .Brand
                txtRefPO.Text = .ReffPO
                txtStyle.Text = .StyleName
                txtContract.Text = .NoOrder
                txtTo.Text = .CustomerName
                txtTlp.Text = .Telephone
                txtFM.Text = .ContactPerson
                txtAddress.Text = .Address
                txtFax.Text = .fax

            End With



            headerModel = Nothing
            boBFC = Nothing
        Catch ex As Exception
            headerModel = Nothing
            boBFC = Nothing
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
    Sub CheckPermission()
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
    Sub InsertData()
        Dim piBFC As ClsPI = New ClsPI
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim myboID As String = boID
        Dim logDesc As String = "Create new Proforma Invoice,BOID is " + myboID

        Try
            If piBFC.InsertData(SetDataHeader1(myboID), SetDetailFabric1(myboID), SetDetailColor1(myboID), SetDetailYarn1(myboID) _
                                , SetDetailRemarks(myboID), SetDataBank(myboID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxSaved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
                ClearDataGrid()
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
        Dim piBFC As ClsPI = New ClsPI
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Proforma Invoice,Where No Order = " + txtPINo.Text
        Try
            If piBFC.UpdateData(SetDataHeader1(boID), SetDetailFabric1(boID), SetDetailColor1(boID), SetDetailYarn1(boID) _
                                , SetDetailRemarks(boID), SetDataBank(boID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxUpdated()
                CheckPermission()
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
        Dim piBFC As ClsPI = New ClsPI
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Approved proforma invoice where NoOrder = " + txtPINo.Text
        conBon = "Approved"
        Try
            If piBFC.UpdateStatusHeader(SetDataHeader1(boID), logBFC.SetLogHistoryTrans(logDesc)) Then
                MsgBoxApproved()
                PreCreateDisplay()
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
        Dim piBFC As ClsPI = New ClsPI
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Void proforma invoice where NoOrder = " + txtPINo.Text
        conBon = "Void"
        Try
            If piBFC.UpdateStatusHeader(SetDataHeader1(boID), logBFC.SetLogHistoryTrans(logDesc)) Then
                MsgBoxVoid()
                PreCreateDisplay()
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
            If piPrint.PrintOutProformaInvoice2(txtPINo.Text) Then
                PreCreateDisplay()
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
        intBarisfabric = 0
        intPostfabric = 0
        intBarisColor = 0
        intPostRawColor = 0
        intBarisYarn = 0
        intPostRawYArn = 0
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
    Sub NOActiveButton()
        btnApprove.Enabled = False
        btnVoid.Enabled = False
        btnPrint.Enabled = False
        btnUpdate.Enabled = False
    End Sub
    Sub PreCreateDisplay()
        Try
            ComboBoxALL()
            GridALL()
            PrepareByHeaderID()
            PrepareFabricByHeaderID()
            PrepareColorByHeaderID()
            PrepareYarnByHeaderID()
            CheckPermission()
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
            CheckPermission()
            PrepareHeaderByID1()
            PrepareFabricByHeaderID1()
            PrepareColorByHeaderID1()
            PrepareYarnByHeaderID1()
            PrepareBankByHeaderID1()
            PrepareRemarksByHeaderID1()
            CheckPermission()
            btnApprove.Enabled = True
            btnVoid.Enabled = True
            btnPrint.Enabled = True
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PrepareHeaderByID1()

        Dim headerModel As ProInvoiceHeaderModel = New ProInvoiceHeaderModel
        Dim piBFC As ClsPI = New ClsPI
        Try
            ComboBoxALL
            headerModel = piBFC.RetrieveByID(boID)
            With headerModel
                txtPINo.Text = .NoOrder
                dtPIDate.Value = .DatePI
                dtDelTerm.Value = .DelTerm
                txtBuyer.Text = .Brand
                txtRefPO.Text = .ReffPO
                txtStyle.Text = .StyleName
                txtContract.Text = .NoOrder
                txtTo.Text = .CustomerName
                txtTlp.Text = .Telephone
                txtFM.Text = .FM
                txtAddress.Text = .Address
                txtFax.Text = .Fax
                cmbSeason.SelectedValue = .SeasonID
                cmbTOP.SelectedValue = .TermOfPaymentID
                cmbTermPrice.SelectedValue = .TermOfPriceID
                txtContract.Text = .ContractNo
                cmbPort.SelectedValue = .DestinationID
                txtAtention.Text = .Atention
                txtDeliveryPlace.Text = .DeliveryPlace
                txtAmount.Text = .AmountTotal
                txtAddresDelvery.Text = .AddressDeliveryplace
            End With
            headerModel = Nothing
            piBFC = Nothing
        Catch ex As Exception
            headerModel = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareFabricByHeaderID1()
        Dim listFabric As List(Of ProInvoiceFabricDetailModel) = New List(Of ProInvoiceFabricDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            GridDetailFabric()
            listFabric = piBFC.RetrieveFabricByHeaderID(boID)
            For Each detail In listFabric
                With dgvFabric
                    .Rows.Add()
                    .Item(0, intBarisfabric).Value = detail.FabricID
                    .Item(1, intBarisfabric).Value = detail.FabricName
                    .Item(2, intBarisfabric).Value = detail.Specification
                    .Item(3, intBarisfabric).Value = detail.RawMaterialID
                    .Item(4, intBarisfabric).Value = detail.RawMaterialName
                    .Item(5, intBarisfabric).Value = detail.TypeGreige
                    .Item(6, intBarisfabric).Value = detail.WidthMin
                    .Item(7, intBarisfabric).Value = detail.WidthMax
                    .Item(8, intBarisfabric).Value = detail.UnitID
                    .Item(9, intBarisfabric).Value = detail.UnitName
                    .Item(10, intBarisfabric).Value = detail.WeightMin
                    .Item(11, intBarisfabric).Value = detail.WeightMax
                    .Item(12, intBarisfabric).Value = detail.DNYardage
                    .Item(13, intBarisfabric).Value = detail.WeightYard
                    .Item(14, intBarisfabric).Value = detail.BeforeWash
                    .Item(15, intBarisfabric).Value = detail.AfterWash
                    .Item(16, intBarisfabric).Value = detail.NetWeight
                    .Item(17, intBarisfabric).Value = detail.SrinkageL
                    .Item(18, intBarisfabric).Value = detail.SrinkageW
                    .Item(19, intBarisfabric).Value = detail.GSM
                    .Item(20, intBarisfabric).Value = detail.PriceGreige
                    .Item(21, intBarisfabric).Value = detail.PurchSize
                    .Item(22, intBarisfabric).Value = detail.StorageSize
                    .Item(23, intBarisfabric).Value = detail.PPSample
                    .Item(24, intBarisfabric).Value = detail.QtyCuttable
                    .Item(25, intBarisfabric).Value = detail.QtyWeight
                End With
                intBarisfabric = intBarisfabric + 1
            Next
            listFabric = Nothing
            piBFC = Nothing
        Catch ex As Exception
            listFabric = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareColorByHeaderID1()
        Dim listColor As List(Of ProInvoiceColorDetailModel) = New List(Of ProInvoiceColorDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            GridDetailColor()

            listColor = piBFC.RetrieveColorByHeaderID(boID)
            For Each detail In listColor
                With dgvColor
                    .Rows.Add()
                    .Item(0, intBarisColor).Value = detail.ColorID
                    .Item(1, intBarisColor).Value = detail.ColorLabNumber
                    .Item(2, intBarisColor).Value = detail.ColorName
                    .Item(3, intBarisColor).Value = detail.ColorType
                    .Item(4, intBarisColor).Value = detail.QtyOrder
                    .Item(5, intBarisColor).Value = detail.PurchSizeID
                    .Item(6, intBarisColor).Value = detail.PurchSizeName
                    .Item(7, intBarisColor).Value = detail.Price
                    .Item(8, intBarisColor).Value = detail.QtySample
                    .Item(9, intBarisColor).Value = detail.DelDate
                    .Item(10, intBarisColor).Value = detail.Note
                    .Item(11, intBarisColor).Value = detail.FabricID
                    .Item(12, intBarisColor).Value = detail.Price * detail.QtyOrder
                    .Item(13, intBarisColor).Value = detail.CurrencyID
                    .Item(14, intBarisColor).Value = detail.Currency

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

    Sub PrepareYarnByHeaderID1()
        Dim listYarn As List(Of ProInvoiceYarnDetailModel) = New List(Of ProInvoiceYarnDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            GridDetailYarn()
            listYarn = piBFC.RetrieveYarnByHeaderID(boID)
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

    Sub PrepareBankByHeaderID1()
        Dim piBankAccountModel As ProInvoiceBankDetailModel = New ProInvoiceBankDetailModel
        Dim piBFC As ClsPI = New ClsPI
        Try
            ComboBoxBank()
            piBankAccountModel = piBFC.RetrieveBankByHeaderID(boID)
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

    Sub PrepareRemarksByHeaderID1()
        Dim listRemarks As List(Of ProInvoiceRemarkDetailModel) = New List(Of ProInvoiceRemarkDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            GridDetailRemark()
            listRemarks = piBFC.RetrieveRemarksByHeaderID(boID)
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
#End Region

#Region "Check Available In List"
    Function CheckFabricInList() As Boolean
        Dim piBFC As ClsPI = New ClsPI
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
        Dim piBFC As ClsPI = New ClsPI
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
        Dim piBFC As ClsPI = New ClsPI
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
        Dim piBFC As ClsPI = New ClsPI
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

#Region "SETDATA"
    Function SetDataHeader1(boID As Long) As ProInvoiceHeaderModel
        Dim headerModel As ProInvoiceHeaderModel = New ProInvoiceHeaderModel
        Dim piBFC As ClsPI = New ClsPI
        With headerModel
            Select Case conBon
                Case "Create PI"
                    .BOID = boID
                    .SeasonID = cmbSeason.SelectedValue
                    .NoOrder = txtPINo.Text
                    .SeasonID = cmbSeason.SelectedValue
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .TermOfPriceID = cmbTermPrice.SelectedValue
                    .DestinationID = cmbPort.SelectedValue
                    .DeliveryPlace = txtDeliveryPlace.Text
                    .AddressDeliveryplace = txtAddresDelvery.Text
                    .Atention = txtAtention.Text
                    .AmountTotal = txtAmount.Text
                    .CurrID = cmbCurrency.SelectedValue
                    .Status = 1
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .BOID = boID
                    .NoOrder = txtPINo.Text
                    .SeasonID = cmbSeason.SelectedValue
                    .NoOrder = txtPINo.Text
                    .SeasonID = cmbSeason.SelectedValue
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .TermOfPriceID = cmbTermPrice.SelectedValue
                    .DestinationID = cmbPort.SelectedValue
                    .DeliveryPlace = txtDeliveryPlace.Text
                    .AddressDeliveryplace = txtAddresDelvery.Text
                    .Atention = txtAtention.Text
                    .AmountTotal = txtAmount.Text
                    .CurrID = cmbCurrency.SelectedValue
                    .Status = 1
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Approved"
                    .BOID = boID
                    .NoOrder = txtPINo.Text
                    .Status = 2
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Void"
                    .BOID = boID
                    .NoOrder = txtPINo.Text
                    .Status = 0
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return headerModel
    End Function

    Function SetDetailFabric1(boID As Long) As List(Of ProInvoiceFabricDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Dim listModel As List(Of ProInvoiceFabricDetailModel) = New List(Of ProInvoiceFabricDetailModel)
        Try
            listModel = piBFC.SetDetailFabric(boID, dgvFabric)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailColor1(boID As Long) As List(Of ProInvoiceColorDetailModel)
        Dim listModel As List(Of ProInvoiceColorDetailModel) = New List(Of ProInvoiceColorDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            listModel = piBFC.SetDetailColor(boID, dgvColor)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailYarn1(boID As Long) As List(Of ProInvoiceYarnDetailModel)
        Dim listModel As List(Of ProInvoiceYarnDetailModel) = New List(Of ProInvoiceYarnDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            listModel = piBFC.SetDetailYarn(boID, dgvYarn)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDataBank(ClsPI As Long) As ProInvoiceBankDetailModel
        Dim myModel As ProInvoiceBankDetailModel = New ProInvoiceBankDetailModel
        Dim piBFC As ClsPI = New ClsPI
        Try
            myModel.BOID = boID
            myModel.BankAccountID = cmbBankCode.SelectedValue
            piBFC = Nothing
            Return myModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailRemarks(boID As Long) As List(Of ProInvoiceRemarkDetailModel)
        Dim listModel As List(Of ProInvoiceRemarkDetailModel) = New List(Of ProInvoiceRemarkDetailModel)
        Dim piBFC As ClsPI = New ClsPI
        Try
            listModel = piBFC.SetDetailRemarks(boID, dgvRemarks)
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader(boID As Long, noOrder As String) As PIHeaderModel
        Dim headerModel As PIHeaderModel = New PIHeaderModel
        Dim boBFC As ClsBO = New ClsBO
        Try
            With headerModel
                Select Case conBon
                    Case "Create PI"
                        .PIHeaderID = boID
                        .SeasonID = cmbSeason.SelectedValue
                End Select
            End With
        Catch ex As Exception

        End Try
    End Function

    Function SetDetailFabric(boID As Long) As List(Of BODetailModel)
        Dim bonOrderBFC As ClsBO = New ClsBO
        Dim listModel As List(Of BODetailModel) = New List(Of BODetailModel)
        Try
            '      listModel = bonOrderBFC.SetDetailFabric(boID, dgvFabricDetail)
            bonOrderBFC = Nothing
            Return listModel
        Catch ex As Exception
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailColor(boID As Long) As List(Of BOColorDetailModel)
        Dim bonOrderBFC As ClsBO = New ClsBO
        Dim listModel As List(Of BOColorDetailModel) = New List(Of BOColorDetailModel)
        Try
            ' listModel = bonOrderBFC.SetDetailColor(boID, dgvdetailcolor)
            bonOrderBFC = Nothing
            Return listModel
        Catch ex As Exception
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Function

    Function SetDetailYarn(boID As Long) As List(Of BOYarnDetailModel)
        Dim bonOrderBFC As ClsBO = New ClsBO
        Dim listModel As List(Of BOYarnDetailModel) = New List(Of BOYarnDetailModel)
        Try
            '    listModel = bonOrderBFC.SetDetailYarn(boID, dgvyarnmatrial)
            bonOrderBFC = Nothing
            Return listModel
        Catch ex As Exception
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Function

    Private Sub FrmPI_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Select Case conBon
                Case "Create PI"
                    Sumamount()
                    PreCreateDisplay()
                Case "Update"
                    Sumamount()
                    PreUpdateDisplay()

            End Select
        Catch ex As Exception
            MsgBoxError("Error : " + ex.Message)
        End Try
    End Sub

    Private Sub cmbFabric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFabric.SelectedIndexChanged
        Try
            RetrieveFabric()
            ComboBoxColor(boID, cmbFabric.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged
        Try
            RetrieveColor()
            RetrieveQtyorderColor(boID, cmbFabric.SelectedValue, cmbColor.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cmbYarn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYarn.SelectedIndexChanged
        Try
            RetrieveYarn()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbBankCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBankCode.SelectedIndexChanged
        Try
            RetrieveBankAccount()
        Catch ex As Exception

        End Try

    End Sub

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

    Private Sub btnColAddList_Click(sender As Object, e As EventArgs) Handles btnColAddList.Click
        If CheckEmptyColor() = False Then
            Try
                If CheckColorInList() = True Then
                    AddGridDetailColor()
                    Sumamount()
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

    Private Sub btnDelYarnList_Click(sender As Object, e As EventArgs) Handles btnDelYarnList.Click
        Try
            DeleteGridDetailYarn()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnColDelList_Click(sender As Object, e As EventArgs) Handles btnColDelList.Click
        Try
            DeleteGridDetailColor()
            Sumamount()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnDelFabirc_Click(sender As Object, e As EventArgs) Handles btnDelFabirc.Click
        Try
            DeleteGridDetailFabric()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmptyHeader() = False And CheckEmptyBank() = False Then
            Try
                InsertData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckEmptyHeader() = False Then
            Try
                UpdateData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            PrintData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If CheckEmptyHeader() = False Then
            Try
                ApprovedData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        If CheckEmptyHeader() = False Then
            Try
                VoidData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub
#End Region

End Class