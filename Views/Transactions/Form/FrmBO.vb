Imports System.ComponentModel
Public Class FrmBO

#Region "Declaration"
    Public conBon As String
    Public Shared boID As Long = 0
    Dim intBarisfabric As Integer
    Dim intPostfabric As Integer
    Dim intBarisColor As Integer
    Dim intPostRawColor As Integer
    Dim intBarisYarn As Integer
    Dim intPostRawYArn As Integer
    Dim statusBOn As Int16
    Dim msgError As String = "Error Bon Order : "
#End Region

#Region "ComboBox"
    Sub RetrieveValuelbs()
        Dim dataTable As DataTable = New DataTable
        Dim orderBFC As ClsOrderLooses = New ClsOrderLooses
        Dim loosesModel As OrderLoosesModel = New OrderLoosesModel

        Try
            Dim range = cmbRange.Text
            Dim obj As Integer = cmbcategoryFabric.SelectedValue
            If obj > 0 Then
                loosesModel = orderBFC.RetrieveValueLBS(obj, range)
                With loosesModel
                    txtLoses.Text = .ValueLosses
                End With
            Else
                MsgBoxError("Value  not valid")
            End If
            loosesModel = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub RetrieveValuekg()
        Dim dataTable As DataTable = New DataTable
        Dim orderBFC As ClsOrderLooses = New ClsOrderLooses
        Dim loosesModel As OrderLoosesModel = New OrderLoosesModel

        Try
            Dim range = cmbRange.Text
            Dim obj As Integer = cmbcategoryFabric.SelectedValue
            If obj > 0 Then
                loosesModel = orderBFC.RetrieveValueKG(obj, range)
                With loosesModel
                    txtLoses.Text = .ValueLosses
                End With
            Else
                MsgBoxError("Value  not valid")
            End If
            loosesModel = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub RetrieveFabric()
        Dim fabricBFC As ClsFabric = New ClsFabric
        Dim fabricModel As FabricModel = New FabricModel

        Dim obj As Integer = cmbFabric.SelectedValue
        If obj > 0 Then
            fabricModel = fabricBFC.RetrieveByID(obj)
            With fabricModel
                txtWidth.Text = .Width
                txtWeight.Text = .Weight

            End With
        Else
            MsgBoxError("Fabric not valid")
        End If
    End Sub
    Sub RetrieveColor()
        Dim colorBFC As ClsColor = New ClsColor
        Dim colorcModel As ColorModel = New ColorModel

        Dim obj As Integer = cmbColor.SelectedValue
        If obj > 0 Then
            colorcModel = colorBFC.RetrieveByID(obj)
            With colorcModel
                txtLabDipsNo.Text = .ColorCode
            End With
        Else
            MsgBoxError("Color not valid")
        End If
    End Sub

    Sub ComboBoxLooses1()
        Dim orderloosBFC As ClsOrderLooses = New ClsOrderLooses
        orderloosBFC.ComboBoxLooses1(cmbRange)
    End Sub
    Sub ComboBoxLooses2()
        Dim orderloosBFC As ClsOrderLooses = New ClsOrderLooses
        orderloosBFC.ComboBoxLooses2(cmbRange)
    End Sub
    Sub ComboBoxCustomer()
        Dim custBFC As ClsVendor = New ClsVendor
        Dim status As String = "C"
        custBFC.ComboBoxVendor(cmbCustomer, status)
    End Sub

    Sub ComboBoxUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        unitBFC.ComboBoxUnit(cmbUnit)
    End Sub
    Sub ComboBoxFabric1()
        Dim fabricBFC As ClsFabric = New ClsFabric

        Try
            fabricBFC.ComboBoxFabric(cmbFabric)
            fabricBFC = Nothing
        Catch ex As Exception
            fabricBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub ComboBoxFabric(cmb As ComboBox, headerID As Long)
        Dim fabricBFC As ClsFabric = New ClsFabric

        Try
            fabricBFC.ComboBoxFabric2(cmbFabric, headerID)
            fabricBFC = Nothing
        Catch ex As Exception
            fabricBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub ComboBoxColor(cmb As ComboBox, headerID As Long)
        Dim colorBFC As ClsColor = New ClsColor
        Try
            colorBFC.ComboBoxColorYarn(cmbColor, headerID)
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
    Sub ComboBoxStyleName()
        Dim styleBFC As ClsStyle = New ClsStyle
        Try
            styleBFC.ComboBoxStyle(cmbStyleName)
            styleBFC = Nothing
        Catch ex As Exception
            styleBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub ComboBoxBrand()
        Dim brFC As ClsBrand = New ClsBrand
        Try
            brFC.ComboBoxBrand(cmbBrand)
            brFC = Nothing
        Catch ex As Exception
            brFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub ComboBoxCategory()
        Dim catBFC As ClsCategoryFabric = New ClsCategoryFabric
        catBFC.ComboBoxCategory(cmbcategoryFabric)
    End Sub
#End Region

#Region "Grid Detail"
    Sub GridDetailFabric()
        With dgvFabricDetail

            .Columns.Add(0, "Fabric ID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Fabric Details / Item No")
            .Columns(1).Width = 300

            .Columns.Add(2, "Widtht")
            .Columns(2).Width = 100
            .Columns(2).ReadOnly = True

            .Columns.Add(3, "Weight")
            .Columns(3).Width = 100
            .Columns(3).ReadOnly = True
        End With
    End Sub
    Sub GridDetailColor()
        Try
            With dgvdetailcolor
                .Columns.Add(0, "Fabric ID")
                .Columns(0).Width = 200
                .Columns(0).Visible = False

                .Columns.Add(1, "Fabric")
                .Columns(1).Width = 150
                .Columns(1).Visible = False

                .Columns.Add(2, "ColorID")
                .Columns(2).Visible = True

                .Columns.Add(3, "Colors")
                .Columns(3).ReadOnly = True

                .Columns.Add(4, "Labs Dips No")
                .Columns(4).Width = 150
                .Columns(4).ReadOnly = True

                .Columns.Add(5, "Bruto(KG)")
                .Columns(5).ReadOnly = False

                .Columns.Add(6, "Netto(KG)")
                .Columns(6).ReadOnly = False

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GridDetailYarn()
        Try
            With dgvyarnmatrial
                .Columns.Add(0, "Yarn ID")
                .Columns(0).Width = 200
                .Columns(0).Visible = False

                .Columns.Add(1, "Yarn Name")
                .Columns(1).Width = 150
                .Columns(1).Visible = True

                .Columns.Add(2, "UnitID")
                .Columns(2).Visible = False

                .Columns.Add(3, "Unit")
                .Columns(3).ReadOnly = True



            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Clear Data"
    Sub ClearAll()
        txtCode.Text = AutoGenerated
        txtReffPO.Clear()
        txtTotBruto.Clear()
        txtNetto.Clear()
        cmbCustomer.Text = ""
        cmbBrand.Text = ""
        cmbStyleName.Text = ""
        dtpDateIssues.Focus()
        dgvFabricDetail.Columns.Clear()
        dgvdetailcolor.Columns.Clear()
        dgvyarnmatrial.Columns.Clear()
        intBarisfabric = 0
        intPostfabric = 0
        intBarisColor = 0
        intPostRawColor = 0
        intBarisYarn = 0
        intPostRawYArn = 0

    End Sub
    Sub Clear()
        txtLoses.Clear()
        txtWeight.Clear()
        txtWidth.Clear()
        txtLabDipsNo.Clear()
        txtBrutto.Clear()
        txtNetto.Clear()
        txtTotBruto.Clear()
        txtTotNetto.Clear()
        cmbRange.Text = ""
        dgvFabricDetail.Columns.Clear()
        dgvdetailcolor.Columns.Clear()
        dgvyarnmatrial.Columns.Clear()
        intBarisfabric = 0
        intPostfabric = 0
        intBarisColor = 0
        intPostRawColor = 0
        intBarisYarn = 0
        intPostRawYArn = 0

    End Sub
#End Region

#Region "Check Empty"
    Function CheckEmptyHeader() As Boolean
        Dim check As Boolean = True
        If cmbCustomer.SelectedValue = 0 Then
            MsgBoxWarning("Customer not valid")
            cmbCustomer.Focus()
        ElseIf cmbBrand.SelectedValue = 0 Then
            MsgBoxWarning("Brand not valid")
            cmbBrand.Focus()
        ElseIf cmbStyleName.SelectedValue = 0 Then
            MsgBoxWarning("Style not valid")
            cmbStyleName.Focus()
        ElseIf dgvFabricDetail.Rows.Count - 1 = 0 Then
            MsgBoxError("Detail Fabric can't empty")
            btnfabricAddList.Focus()
        ElseIf dgvdetailcolor.Rows.Count - 1 = 0 Then
            MsgBoxError("Detail Colors can't empty")
            btnColorAddList.Focus()
        ElseIf dgvyarnmatrial.Rows.Count - 1 = 0 Then
            MsgBoxError("Detail Yarn can't empty")
            btnYarnAddList.Focus()
        ElseIf txtTotBruto.Text = 0 And txtTotNetto.Text = 0 Then
            MsgBoxError("Bruto Or Netto can't 0")
            btnColorAddList.Focus()
        Else
            check = False
        End If
        Return check
    End Function
    'Function CheckEmptyRawMatrial() As Boolean
    '    Dim check As Boolean = True
    '    If cmbRawCode.SelectedValue = 0 Then
    '        MsgBoxWarning("Raw Matrial Not Valid")
    '        cmbRawCode.Focus()
    '    ElseIf txtQty.Text = "" Then
    '        MsgBoxWarning("Qty Price Can't Empty")
    '        txtQty.Focus()
    '    ElseIf cmbUnit.SelectedValue = 0 Then
    '        MsgBoxWarning("Unit For Raw Matrial Not Valid")
    '        cmbUnit.Focus()
    '    Else
    '        check = False
    '    End If
    '    Return check
    'End Function
    'Function CheckEmptyDetail() As Boolean
    '    Dim check As Boolean = True
    '    For i As Integer = 0 To dgv.Rows.Count - 2
    '        If dgv.Rows(i).Cells(0).Value = "" Then
    '            MsgBoxError("Transaction not yet completed")
    '            Exit For
    '        ElseIf dgv.Rows(i).Cells(4).Value = 0 Then
    '            MsgBoxError("Bruto can't 0")
    '            Exit For
    '        ElseIf dgv.Rows(i).Cells(5).Value = 0 Then
    '            MsgBoxError("Netto can't 0")
    '            Exit For
    '        Else
    '            check = False
    '        End If
    '    Next
    '    Return check
    'End Function
#End Region

#Region "CekDetailInlist"
    Function CheckFabricInList() As Boolean
        Dim boBFC As ClsBO = New ClsBO
        Dim status As Boolean
        status = boBFC.CheckFabriclInList(dgvFabricDetail, cmbFabric.SelectedValue)
        Return status
    End Function

    Function CheckColorscInList() As Boolean
        Dim boBFC As ClsBO = New ClsBO
        Dim status As Boolean
        status = boBFC.CheckColorslInList(dgvdetailcolor, cmbColor.SelectedValue)
        Return status
    End Function
    Function CheckYarncInList() As Boolean
        Dim boBFC As ClsBO = New ClsBO
        Dim status As Boolean
        status = boBFC.CheckYarnlInList(dgvyarnmatrial, cmbYarn.SelectedValue)
        Return status
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader(boID As Long, noOrder As String) As BOHeaderModel
        Dim headerModel As BOHeaderModel = New BOHeaderModel
        Dim boBFC As ClsBO = New ClsBO
        Try
            With headerModel
                Select Case conBon
                    Case "Create"

                        .BOID = boBFC.GetBonOrderID
                        .BOID = boID
                        .NoOrder = boBFC.GetNoOrder
                        txtCode.Text = noOrder
                        .CustomerID = cmbCustomer.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .DeliveryDate = Format(dtDeliveryDate.Value, "yyyy-MM-dd")
                        .BrandID = cmbBrand.SelectedValue
                        .StyleID = cmbStyleName.SelectedValue
                        .ReffPO = txtReffPO.Text
                        .SumBrutto = txtTotBruto.Text
                        .SumNetto = txtTotNetto.Text
                        .Status = 1
                        .CreatedBy = userID
                        .CreatedDate = DateTime.Now
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Update"
                        .BOID = boID
                        .NoOrder = txtCode.Text
                        .CustomerID = cmbCustomer.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .DeliveryDate = Format(dtDeliveryDate.Value, "yyyy-MM-dd")
                        .BrandID = cmbBrand.SelectedValue
                        .StyleID = cmbStyleName.SelectedValue
                        .ReffPO = txtReffPO.Text
                        .SumBrutto = txtTotBruto.Text
                        .SumNetto = txtTotNetto.Text
                        .Status = 1
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Approve"
                        .BOID = boID
                        .NoOrder = txtCode.Text
                        .CustomerID = cmbCustomer.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .DeliveryDate = Format(dtDeliveryDate.Value, "yyyy-MM-dd")
                        .BrandID = cmbBrand.SelectedValue
                        .StyleID = cmbStyleName.SelectedValue
                        .ReffPO = txtReffPO.Text
                        .SumBrutto = txtTotBruto.Text
                        .SumNetto = txtTotNetto.Text
                        .Status = 2
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Void"
                        .BOID = boID
                        .NoOrder = txtCode.Text
                        .CustomerID = cmbCustomer.SelectedValue
                        .CustomerName = cmbCustomer.Text
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .DeliveryDate = Format(dtDeliveryDate.Value, "yyyy-MM-dd")
                        .BrandID = cmbBrand.SelectedValue
                        .Brand = cmbBrand.Text
                        .StyleID = cmbStyleName.SelectedValue
                        .ReffPO = txtReffPO.Text
                        .SumBrutto = txtTotBruto.Text
                        .SumNetto = txtTotNetto.Text
                        .Status = 0
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                End Select
            End With
            Return headerModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function SetDetailFabric(boID As Long) As List(Of BODetailModel)
        Dim bonOrderBFC As ClsBO = New ClsBO
        Dim listModel As List(Of BODetailModel) = New List(Of BODetailModel)
        Try
            listModel = bonOrderBFC.SetDetailFabric(boID, dgvFabricDetail)
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
            listModel = bonOrderBFC.SetDetailColor(boID, dgvdetailcolor)
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
            listModel = bonOrderBFC.SetDetailYarn(boID, dgvyarnmatrial)
            bonOrderBFC = Nothing
            Return listModel
        Catch ex As Exception
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Function

#End Region

#Region "Delete Grid"
    Sub DeleteGridDetailFabric()
        DeleteGrid(dgvFabricDetail)
        intBarisfabric = intBarisfabric - 1
    End Sub
    Sub DeleteGridDetailColor()
        DeleteGrid(dgvdetailcolor)
        intBarisColor = intBarisColor - 1
    End Sub
    Sub DeleteGridDetailYarn()
        DeleteGrid(dgvyarnmatrial)
        intBarisYarn = intBarisYarn - 1
    End Sub
#End Region

#Region "Function"
    Sub PrepareByHeaderID()
        Dim headerModel As BOHeaderModel = New BOHeaderModel
        Dim boBFC As ClsBO = New ClsBO
        Try
            comboall()
            headerModel = boBFC.RetrieveByID(boID)
            With headerModel
                txtCode.Text = .NoOrder
                dtpDateIssues.Value = .DateIssues
                dtDeliveryDate.Value = .DeliveryDate
                cmbCustomer.SelectedValue = .CustomerID
                txtReffPO.Text = .ReffPO
                cmbBrand.SelectedValue = .BrandID
                cmbStyleName.SelectedValue = .StyleID
                txtTotBruto.Text = .SumBrutto
                txtTotNetto.Text = .SumNetto
                statusBOn = .Status
            End With
            headerModel = Nothing
            boBFC = Nothing
        Catch ex As Exception
            headerModel = Nothing
            boBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub PrintData()
        Try
            Dim bonPrint As ClsPrintOut = New ClsPrintOut
            If bonPrint.PrintOutBonOrder(txtCode.Text) Then
                PreCreateDisplay()
            Else
                MsgBoxError("Failed to print")
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
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
            'If conBon = "Create" Then
            '    btnPrint.Enabled = False
            '    cmbCustomer.Enabled = True

            'ElseIf conBon = "Update" Then
            '    btnPrint.Enabled = True
            '    cmbPINo.Enabled = True
            '    btnAdd.Enabled = True
            'ElseIf conBon = "View" Then
            '    cmbPINo.Enabled = False
            '    btnAdd.Enabled = False
            '    txtCode.Enabled = False
            '    dtpDateIssues.Enabled = False
            '    btnSave.Enabled = False
            '    btnUpdate.Enabled = False
            '    btnPrint.Enabled = True
            'End If


            roleBFC = Nothing
            roleModel = Nothing
        Catch ex As Exception
            roleBFC = Nothing
            roleModel = Nothing
            Throw ex
        End Try
    End Sub
    Sub PrepareDetailfabricByHeaderID()
        Dim boBFC As ClsBO = New ClsBO
        Dim listDetail As List(Of BODetailModel) = New List(Of BODetailModel)

        dgvFabricDetail.Columns.Clear()
        GridDetailFabric()
        Try
            listDetail = boBFC.RetrieveDetailFabricByID(boID)
            For Each detail In listDetail
                With dgvFabricDetail
                    .Rows.Add()
                    .Item(0, intBarisfabric).Value = detail.FabricID
                    .Item(1, intBarisfabric).Value = detail.FabricName
                    .Item(2, intBarisfabric).Value = detail.Width
                    .Item(2, intBarisfabric).Value = detail.Weight '+ " x " + detail.Width
                End With
                intBarisfabric = intBarisfabric + 1
            Next
            SumBruto()
            SumNetto()

            boBFC = Nothing
            listDetail = Nothing
        Catch ex As Exception
            boBFC = Nothing
            listDetail = Nothing
            Throw ex
        End Try
    End Sub

    Sub comboall()
        ComboBoxCategory()
        ComboBoxColor(cmbColor, cmbFabric.SelectedValue)
        ComboBoxCustomer()
        ComboBoxStyleName()
        ComboBoxUnit()
        ComboBoxBrand()
        ComboBoxYarn()
    End Sub
    Sub SumBruto()
        Dim subtotal As Double
        subtotal = 0
        For i As Integer = 0 To dgvdetailcolor.Rows.Count - 1
            subtotal = subtotal + Val(dgvdetailcolor.Rows(i).Cells(5).Value)
            '-----------cell 5 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        txtTotBruto.Text = subtotal
    End Sub

    Sub SumNetto()
        Dim subtotal As Double
        subtotal = 0
        For i As Integer = 0 To dgvdetailcolor.Rows.Count - 1
            subtotal = subtotal + Val(dgvdetailcolor.Rows(i).Cells(6).Value)
            '-----------cell 6 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        txtTotNetto.Text = subtotal
    End Sub
    Sub AddGridDetailFabric()
        With dgvFabricDetail
            .Rows.Add()
            .Item(0, intBarisfabric).Value = cmbFabric.SelectedValue
            .Item(1, intBarisfabric).Value = cmbFabric.Text
            .Item(2, intBarisfabric).Value = txtWidth.Text
            .Item(3, intBarisfabric).Value = txtWeight.Text
        End With
        intBarisfabric = intBarisfabric + 1
    End Sub
    Sub AddGridDetailColors()
        With dgvdetailcolor
            .Rows.Add()
            .Item(0, intBarisColor).Value = cmbFabric.SelectedValue
            .Item(1, intBarisColor).Value = cmbFabric.Text
            .Item(2, intBarisColor).Value = cmbColor.SelectedValue
            .Item(3, intBarisColor).Value = cmbColor.Text
            .Item(4, intBarisColor).Value = txtLabDipsNo.Text
            .Item(5, intBarisColor).Value = txtBrutto.Text
            .Item(6, intBarisColor).Value = txtNetto.Text

        End With
        intBarisColor = intBarisColor + 1
    End Sub
    Sub AddGridDetailYarn()
        With dgvyarnmatrial
            .Rows.Add()
            .Item(0, intBarisYarn).Value = cmbYarn.SelectedValue
            .Item(1, intBarisYarn).Value = cmbYarn.Text
            .Item(2, intBarisYarn).Value = cmbUnit.SelectedValue
            .Item(3, intBarisYarn).Value = cmbUnit.Text
        End With
        intBarisYarn = intBarisYarn + 1
    End Sub
    Sub PrepareFabricByHeaderID()
        Dim listFabric As List(Of BODetailModel) = New List(Of BODetailModel)
        Dim boBFC As ClsBO = New ClsBO
        Try
            GridDetailFabric()
            listFabric = boBFC.RetrieveDetailFabricByID(boID)
            For Each detail In listFabric
                With dgvFabricDetail
                    .Rows.Add()
                    .Item(0, intBarisfabric).Value = detail.FabricID
                    .Item(1, intBarisfabric).Value = detail.FabricName
                    .Item(2, intBarisfabric).Value = detail.Width
                    .Item(3, intBarisfabric).Value = detail.Weight
                    ' + " x " + detail.Weight
                End With
                intBarisfabric = intBarisfabric + 1
            Next
            listFabric = Nothing
            boBFC = Nothing
        Catch ex As Exception
            listFabric = Nothing
            boBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub PrepareColorByHeaderID()
        Dim listColor As List(Of BOColorDetailModel) = New List(Of BOColorDetailModel)
        Dim boBFC As ClsBO = New ClsBO
        Try
            GridDetailColor()
            listColor = boBFC.RetrieveDetailColorByID(boID)
            For Each detail In listColor
                With dgvdetailcolor
                    .Rows.Add()
                    .Item(0, intBarisColor).Value = detail.FabricID
                    .Item(1, intBarisColor).Value = detail.FabricName
                    .Item(2, intBarisColor).Value = detail.ColorID
                    .Item(3, intBarisColor).Value = detail.ColorName
                    .Item(4, intBarisColor).Value = detail.LabsDipsNo
                    .Item(5, intBarisColor).Value = detail.Brutto
                    .Item(6, intBarisColor).Value = detail.Netto

                End With
                intBarisColor = intBarisColor + 1
            Next
            listColor = Nothing
            boBFC = Nothing
        Catch ex As Exception
            listColor = Nothing
            boBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub PrepareYarnByHeaderID()
        Dim listyarn As List(Of BOYarnDetailModel) = New List(Of BOYarnDetailModel)
        Dim boBFC As ClsBO = New ClsBO
        Try
            GridDetailYarn()
            listyarn = boBFC.RetrieveDetailYarnByID(boID)
            For Each detail In listyarn
                With dgvyarnmatrial
                    .Rows.Add()
                    .Item(0, intBarisYarn).Value = detail.YarnID
                    .Item(1, intBarisYarn).Value = detail.YarnName
                    .Item(2, intBarisYarn).Value = detail.UnitID
                    .Item(3, intBarisYarn).Value = detail.UnitName

                End With
                intBarisYarn = intBarisYarn + 1
            Next
            listyarn = Nothing
            boBFC = Nothing
        Catch ex As Exception
            listyarn = Nothing
            boBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub PreCreateDisplay()
        Try
            ClearAll()
            GridDetailFabric()
            GridDetailColor()
            GridDetailYarn()
            comboall()
            CheckPermission()
            btnApprove.Enabled = False
            btnVoid.Enabled = False
            btnPrint.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PreViewDisplay()
        Try

            CheckPermission()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PreUpdateDisplay()
        Try
            PrepareByHeaderID()
            PrepareFabricByHeaderID()
            PrepareColorByHeaderID()
            PrepareYarnByHeaderID()
            CheckPermission()
            If statusBOn = 0 Then btnPrint.Enabled = False Else btnPrint.Enabled = True
            If statusBOn = 0 Or statusBOn = 2 Then btnApprove.Enabled = False
            If statusBOn = 0 Then btnVoid.Enabled = False
            btnSave.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub InsertData()
        Dim noOrderBFC As ClsBO = New ClsBO
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim noorder As String = noOrderBFC.GetNoOrder()
        Dim boID As Long = noOrderBFC.GetBonOrderID()
        Dim logDesc As String = "Create new Bon Order,BON Order is " + noorder

        Try
            If noOrderBFC.InsertData(SetDataHeader(boID, noorder), SetDetailFabric(boID), SetDetailColor(boID), SetDetailYarn(boID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxSaved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
                Clear()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub UpdateData()
        Dim noOrderBFC As ClsBO = New ClsBO
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Bon Order,Where Bon Order Code = " + txtCode.Text
        Try
            If noOrderBFC.UpdateData(SetDataHeader(boID, txtCode.Text), SetDetailFabric(boID), SetDetailColor(boID), SetDetailYarn(boID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxUpdated()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
                Clear()
            End If
            noOrderBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            noOrderBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub ApproveData()
        Dim noOrderBFC As ClsBO = New ClsBO
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Approve Bon Order,Where Bon Order Code = " + txtCode.Text
        conBon = "Approve"
        Try
            If noOrderBFC.UpdateStatus(SetDataHeader(boID, txtCode.Text), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxApproved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
            noOrderBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            noOrderBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub VoidData()
        Dim noOrderBFC As ClsBO = New ClsBO
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Void Bon Order,Where Bon Order Code = " + txtCode.Text
        conBon = "Void"
        Try
            If noOrderBFC.UpdateStatus(SetDataHeader(boID, txtCode.Text), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxApproved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
            noOrderBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            noOrderBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub
#End Region


#Region "Other"


    Private Sub FrmBO_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Select Case conBon
                Case "Create"
                    PreCreateDisplay()
                Case "Update"
                    PreUpdateDisplay()
            End Select
        Catch ex As Exception
            MsgBoxError("Error : " + ex.Message)
        End Try

    End Sub

    Private Sub cmbFabric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFabric.SelectedIndexChanged
        Try
            RetrieveFabric()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioLBS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioLBS.CheckedChanged
        Try
            ComboBoxLooses1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioKG_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKG.CheckedChanged
        Try
            ComboBoxLooses2()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNetto_TextChanged(sender As Object, e As EventArgs) Handles txtNetto.TextChanged
        Dim a As Double
        a = Val(txtLoses.Text) / 100 * Val(txtNetto.Text)
        txtBrutto.Text = Val(a) + Val(txtNetto.Text)
    End Sub

    Private Sub cmbcategoryFabric_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategoryFabric.SelectedIndexChanged
        If RadioLBS.Checked = True Then
            RetrieveValuelbs()
        ElseIf RadioKG.Checked = True Then
            RetrieveValuekg()
        End If
    End Sub
    Private Sub btnfabricAddList_Click(sender As Object, e As EventArgs) Handles btnfabricAddList.Click
        Try
            If CheckFabricInList() = True Then
                AddGridDetailFabric()
            Else
                MsgBoxError("Fabrics available in list")
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnfabricDelList_Click(sender As Object, e As EventArgs) Handles btnfabricDelList.Click
        Try
            DeleteGridDetailFabric()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnYarnDelList_Click(sender As Object, e As EventArgs) Handles btnYarnDelList.Click
        Try
            DeleteGridDetailYarn()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnDelColorList_Click(sender As Object, e As EventArgs) Handles btnDelColorList.Click
        Try
            DeleteGridDetailColor()
            SumBruto()
            SumNetto()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnColorAddList_Click(sender As Object, e As EventArgs) Handles btnColorAddList.Click
        Try

            AddGridDetailColors()
            SumBruto()
            SumNetto()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnYarnAddList_Click(sender As Object, e As EventArgs) Handles btnYarnAddList.Click
        Try

            AddGridDetailYarn()

        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmptyHeader() = False Then
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

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If CheckEmptyHeader() = False Then
            Try
                ApproveData()
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            PrintData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbCustomer_Validated(sender As Object, e As EventArgs) Handles cmbCustomer.Validated
        Try
            ComboBoxFabric(cmbFabric, cmbCustomer.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cmbFabric_Validated(sender As Object, e As EventArgs) Handles cmbFabric.Validated
        Try
            ComboBoxColor(cmbColor, cmbFabric.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged
        Try
            RetrieveColor()
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class