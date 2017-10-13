﻿Imports System.ComponentModel
Public Class FrmBonOrder

#Region "Declaration"
    Public conBon As String
    Public Shared bonOrderID As Long = 0
    Dim intBaris As Integer
    Dim intPost As Integer
    Dim intBarisRaw As Integer
    Dim intPostRaw As Integer
    Dim custCode As String = ""
    Dim statusBOn As Int16
    Dim msgError As String = "Error Bon Order : "

#End Region

#Region "ComboBox"
    Sub ComboBoxRawMaterial()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        rawBFC.ComboBoxRawMaterial(cmbRawCode)
    End Sub

    Sub ComboBoxUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        unitBFC.ComboBoxUnit(cmbUnit)
    End Sub
    Sub ComboBoxPI()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            piBFC.ComboBoxPI(cmbPINo)
            cmbPINo.Enabled = True
            piBFC = Nothing
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub ComboBoxPIView(cmb As ComboBox, bonOrderID As Long)
        Dim bonBFC As ClsBonOrder = New ClsBonOrder
        Try
            bonBFC.ComboBoxPIView(cmbPINo, bonOrderID)
            cmbPINo.Enabled = True
            bonBFC = Nothing
        Catch ex As Exception
            bonBFC = Nothing
            Throw ex
        End Try
    End Sub
#End Region

#Region "Grid Detail"
    Sub GridMaterial()
        With dgvrawmatrial
            .Columns.Add(0, "Raw Material ID")
            .Columns(0).Visible = False

            .Columns.Add(1, "Raw Material Name")
            .Columns(1).Width = 250

            .Columns.Add(2, "Unit ID")
            .Columns(2).Visible = False

            .Columns.Add(3, "Unit")
            .Columns(3).Width = 150
            .Columns.Add(4, "Quantity")
            .Columns(4).Width = 150
        End With
    End Sub
    Sub GridDetail()
        Try
            With dgv
                .Columns.Add(0, "Fabric Details / Item No")
                .Columns(0).Width = 200
                .Columns(0).ReadOnly = True

                .Columns.Add(1, "Width x Weight")
                .Columns(1).Width = 150
                .Columns(1).ReadOnly = True

                .Columns.Add(2, "Color")
                .Columns(2).ReadOnly = True

                .Columns.Add(3, "Labs Dips No")
                .Columns(3).Width = 150
                .Columns(3).ReadOnly = True

                .Columns.Add(4, "Bruto")
                .Columns(4).ReadOnly = False

                .Columns.Add(5, "Netto")
                .Columns(5).ReadOnly = False

                .Columns.Add(6, "FabricID")
                .Columns(6).Visible = False

                .Columns.Add(7, "ColorID")
                .Columns(7).Visible = False

                .Columns.Add(8, "StyleID")
                .Columns(8).Visible = False
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Check StockMaterial"
    Sub RetrieveQtyStock()
        Dim stkBFC As ClsStock = New ClsStock
        Dim bpbModel As StockModel = New StockModel
        Try

            Dim rawmatrialID As String = cmbRawCode.SelectedValue
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
#End Region

#Region "Clear Data"
    Sub ClearAll()
        txtCode.Text = AutoGenerated
        txtNoPO.Clear()
        txtCustomer.Clear()
        txtBrand.Clear()
        txtStyle.Clear()
        dtpDateIssues.Focus()
        dgv.Columns.Clear()
        txtTotBruto.Text = 0
        txtTotNetto.Text = 0
        intBaris = 0
        intPost = 0
        custCode = ""
    End Sub
    Sub ClearRawMatrial()
        cmbRawCode.Text = ""
        cmbUnit.Text = ""
        txtQty.Clear()
        txtStockAV.Clear()
    End Sub
#End Region

#Region "Check Empty"
    Function CheckEmptyHeader() As Boolean
        Dim check As Boolean = True
        If cmbPINo.SelectedValue = 0 Then
            MsgBoxWarning("PINo not valid")
            cmbPINo.Focus()
        ElseIf Trim(txtNoPO.Text) = "" Then
            MsgBoxWarning("PO No can't empty,please check your proforma invoice")
            txtNoPO.Focus()
        ElseIf Trim(txtCustomer.Text) = "" Then
            MsgBoxWarning("Customer can't empty,please check your proforma invoice")
            txtCustomer.Focus()
        ElseIf Trim(txtBrand.Text) = "" Then
            MsgBoxWarning("Brand can't empty,please check your proforma invoice")
            txtBrand.Focus()
        ElseIf Trim(txtStyle.Text) = "" Then
            MsgBoxWarning("Style can't empty,please check your proforma invoice")
            txtBrand.Focus()
        ElseIf dgv.Rows.Count - 1 = 0 Then
            MsgBoxError("Detail can't empty")
            btnAdd.Focus()
        ElseIf txtTotBruto.Text = 0 And txtTotNetto.Text = 0 Then
            MsgBoxError("Bruto Or Netto can't 0")
            btnAdd.Focus()
        Else
            check = False
        End If
        Return check
    End Function
    Function CheckEmptyRawMatrial() As Boolean
        Dim check As Boolean = True
        If cmbRawCode.SelectedValue = 0 Then
            MsgBoxWarning("Raw Matrial Not Valid")
            cmbRawCode.Focus()
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
    Function CheckEmptyDetail() As Boolean
        Dim check As Boolean = True
        For i As Integer = 0 To dgv.Rows.Count - 2
            If dgv.Rows(i).Cells(0).Value = "" Then
                MsgBoxError("Transaction not yet completed")
                Exit For
            ElseIf dgv.Rows(i).Cells(4).Value = 0 Then
                MsgBoxError("Bruto can't 0")
                Exit For
            ElseIf dgv.Rows(i).Cells(5).Value = 0 Then
                MsgBoxError("Netto can't 0")
                Exit For
            Else
                check = False
            End If
        Next
        Return check
    End Function
#End Region

#Region "CekMaterialInlist"
    Function CheckRawMatrialInList() As Boolean
        Dim poBFC As ClsPO = New ClsPO
        Dim status As Boolean
        status = poBFC.CheckYarnInList(dgvrawmatrial, cmbRawCode.SelectedValue)
        Return status
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader(orderID As Long, orderCode As String) As BonOrderHeaderModel
        Dim headerModel As BonOrderHeaderModel = New BonOrderHeaderModel
        Try
            With headerModel
                Select Case conBon
                    Case "Create"
                        .BonOrderID = orderID
                        .BonOrderCode = orderCode
                        .PIHeaderID = cmbPINo.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .Status = 1
                        .CreatedBy = userID
                        .CreatedDate = DateTime.Now
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Update"
                        .BonOrderID = orderID
                        .BonOrderCode = orderCode
                        .PIHeaderID = cmbPINo.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .Status = 1
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Approve"
                        .BonOrderID = orderID
                        .BonOrderCode = orderCode
                        .PIHeaderID = cmbPINo.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
                        .Status = 2
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Void"
                        .BonOrderID = orderID
                        .BonOrderCode = orderCode
                        .PIHeaderID = cmbPINo.SelectedValue
                        .DateIssues = Format(dtpDateIssues.Value, "yyyy-MM-dd")
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
    Function SetDetail(orderID As Long) As List(Of BonOrderDetailModel)
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim listModel As List(Of BonOrderDetailModel) = New List(Of BonOrderDetailModel)
        Try
            listModel = bonOrderBFC.SetDetail(orderID, dgv)
            bonOrderBFC = Nothing
            Return listModel
        Catch ex As Exception
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Function
    Function SetDetailMaterial(orderID As Long) As List(Of BonOrderDetailMaterialModel)
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim listModel As List(Of BonOrderDetailMaterialModel) = New List(Of BonOrderDetailMaterialModel)
        Try
            listModel = bonOrderBFC.SetDetailMaterial(orderID, dgvrawmatrial)
            bonOrderBFC = Nothing
            Return listModel
        Catch ex As Exception
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Function
    Function SetDataPI(condPI As String) As PIHeaderModel
        Dim piModel As PIHeaderModel = New PIHeaderModel
        Try
            Select Case condPI
                Case "Approve"
                    piModel.PIHeaderID = cmbPINo.SelectedValue
                    piModel.Status = 3
                    piModel.UpdatedBy = userID
                    piModel.UpdatedDate = DateTime.Now
                Case "Void"
                    piModel.PIHeaderID = cmbPINo.SelectedValue
                    piModel.Status = 2
                    piModel.UpdatedBy = userID
                    piModel.UpdatedDate = DateTime.Now
            End Select
            Return piModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Function"

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
            'If roleModel.IsCreate = True And conBon = "Create " Then btnSave.Enabled = True
            'If roleModel.IsUpdate = True And conBon = "Update" Then btnUpdate.Enabled = True
            'If roleModel.IsApprove = True And conBon = "View" Then btnApprove.Enabled = True
            'If roleModel.IsVoid = True And conBon = "View" Then btnVoid.Enabled = True
            If roleModel.IsCreate = True Then btnSave.Enabled = True
            If roleModel.IsUpdate = True Then btnUpdate.Enabled = True
            If roleModel.IsApprove = True Then btnApprove.Enabled = True
            If roleModel.IsVoid = True Then btnVoid.Enabled = True
            If conBon = "Create" Then
                btnPrint.Enabled = False
                cmbPINo.Enabled = True
                btnAdd.Enabled = True
            ElseIf conBon = "Update" Then
                btnPrint.Enabled = True
                cmbPINo.Enabled = True
                btnAdd.Enabled = True
            ElseIf conBon = "View" Then
                cmbPINo.Enabled = False
                btnAdd.Enabled = False
                txtCode.Enabled = False
                dtpDateIssues.Enabled = False
                btnSave.Enabled = False
                btnUpdate.Enabled = False
                btnPrint.Enabled = True
            End If


            roleBFC = Nothing
            roleModel = Nothing
        Catch ex As Exception
            roleBFC = Nothing
            roleModel = Nothing
            Throw ex
        End Try
    End Sub
    Sub PrepareByHeaderIDView()
        Dim headerModel As BonOrderHeaderModel = New BonOrderHeaderModel
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Try
            ComboBoxPIView(cmbPINo, bonOrderID)
            headerModel = bonOrderBFC.RetrieveByID(bonOrderID)
            With headerModel
                txtCode.Text = .BonOrderCode
                cmbPINo.SelectedValue = .PIHeaderID
                txtNoPO.Text = .RefPO
                txtCustomer.Text = .CustomerName
                txtBrand.Text = .BuyerName
                txtStyle.Text = .StyleName
                statusBOn = .Status
            End With

            'cmbPINo.Enabled = False
            'btnAdd.Enabled = False

            headerModel = Nothing
            bonOrderBFC = Nothing
        Catch ex As Exception
            headerModel = Nothing
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub PrepareByHeaderID()
        Dim headerModel As BonOrderHeaderModel = New BonOrderHeaderModel
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Try
            ComboBoxPIView(cmbPINo, bonOrderID)
            headerModel = bonOrderBFC.RetrieveByID(bonOrderID)
            With headerModel
                txtCode.Text = .BonOrderCode
                cmbPINo.SelectedValue = .PIHeaderID
                txtNoPO.Text = .RefPO
                txtCustomer.Text = .CustomerName
                txtBrand.Text = .BuyerName
                txtStyle.Text = .StyleName
                statusBOn = .Status
            End With

            'cmbPINo.Enabled = False
            'btnAdd.Enabled = False

            headerModel = Nothing
            bonOrderBFC = Nothing
        Catch ex As Exception
            headerModel = Nothing
            bonOrderBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub PrepareDetailByHeaderID()
        Dim bonBFC As ClsBonOrder = New ClsBonOrder
        Dim listDetail As List(Of BonOrderDetailModel) = New List(Of BonOrderDetailModel)

        dgv.Columns.Clear()
        GridDetail()
        Try
            listDetail = bonBFC.RetrieveDetailByID(bonOrderID)
            For Each detail In listDetail
                With dgv
                    .Rows.Add()
                    .Item(0, intBaris).Value = detail.StyleName
                    .Item(1, intBaris).Value = detail.Weight + " x " + detail.Width
                    .Item(2, intBaris).Value = detail.ColorName
                    .Item(3, intBaris).Value = detail.LabsDipsNo
                    .Item(4, intBaris).Value = detail.Bruto
                    .Item(5, intBaris).Value = detail.Netto
                    .Item(6, intBaris).Value = detail.FabricID
                    .Item(7, intBaris).Value = detail.ColorID
                    .Item(8, intBaris).Value = detail.StyleID
                End With
                intBaris = intBaris + 1
            Next
            SumBruto()
            SumNetto()

            bonBFC = Nothing
            listDetail = Nothing
        Catch ex As Exception
            bonBFC = Nothing
            listDetail = Nothing
            Throw ex
        End Try
    End Sub

    Sub PreparePIByPIHeaderID()
        Dim piModel As PIHeaderModel = New PIHeaderModel
        Dim listDetail As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim piID As Long = cmbPINo.SelectedValue
        Try
            If piID = 0 Then
                ClearAll()
                GridDetail()
                Throw New Exception("No data available")
            End If

            ClearAll()
            piModel = piBFC.RetrieveByID(piID)
            With piModel
                txtCustomer.Text = piModel.CustomerName
                txtNoPO.Text = piModel.RefPO
                txtBrand.Text = piModel.BuyerName
                txtStyle.Text = piModel.StyleName
                custCode = piModel.CustomerCode
            End With

            GridDetail()
            listDetail = piBFC.RetrieveAllDetailByHeaderID(piID)
            For Each detail In listDetail
                With dgv
                    .Rows.Add()
                    .Item(0, intBaris).Value = detail.StyleName
                    .Item(1, intBaris).Value = detail.Weight + " x " + detail.Width
                    .Item(2, intBaris).Value = detail.ColDescription
                    .Item(3, intBaris).Value = detail.ColorCode
                    .Item(4, intBaris).Value = 0
                    .Item(5, intBaris).Value = 0
                    .Item(6, intBaris).Value = detail.FabricID
                    .Item(7, intBaris).Value = detail.ColorID
                    .Item(8, intBaris).Value = detail.StyleID
                End With
                intBaris = intBaris + 1
            Next
            SumBruto()
            SumNetto()
            listDetail = Nothing
            piBFC = Nothing
        Catch ex As Exception
            listDetail = Nothing
            piBFC = Nothing
            Throw ex
        End Try
    End Sub

    Sub SumBruto()
        Dim subTotal As Double
        subTotal = 0
        Try
            For i As Integer = 0 To dgv.Rows.Count - 2
                If Convert.ToString(dgv.Rows(i).Cells(4).Value) = "" And dgv.Rows(i).Cells(0).Value <> "" Then
                    dgv.Rows(i).Cells(4).Value = 1
                    subTotal = subTotal + 1
                    MsgBoxError("Error Bon Order : Must fill numeric")
                ElseIf Not IsNumeric(dgv.Rows(i).Cells(4).Value) And dgv.Rows(i).Cells(0).Value <> "" Then
                    dgv.Rows(i).Cells(4).Value = 1
                    subTotal = subTotal + 1
                    MsgBoxError("Error Bon Order : Must fill numeric")
                ElseIf Not IsNumeric(dgv.Rows(i).Cells(4).Value) And dgv.Rows(i).Cells(0).Value = "" Then
                    dgv.Rows.RemoveAt(i)
                    'dgv.Rows.Remove(dgv.CurrentRow)
                    intBaris = intBaris - 1
                    subTotal = subTotal + 0
                ElseIf dgv.Rows(i).Cells(0).Value = "" Then
                    dgv.Rows.RemoveAt(i)
                    'dgv.Rows.Remove(dgv.CurrentRow)
                    intBaris = intBaris - 1
                    subTotal = subTotal + 0
                Else
                    subTotal = subTotal + Val(dgv.Rows(i).Cells(4).Value)
                End If
            Next
            txtTotBruto.Text = subTotal
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub SumNetto()
        Dim subTotal As Double
        subTotal = 0
        Try
            For i As Integer = 0 To dgv.Rows.Count - 2
                If Convert.ToString(dgv.Rows(i).Cells(5).Value) = "" And dgv.Rows(i).Cells(0).Value <> "" Then
                    dgv.Rows(i).Cells(5).Value = 1
                    subTotal = subTotal + 1
                    MsgBoxError("Error Bon Order : Must fill numeric")
                ElseIf Not IsNumeric(dgv.Rows(i).Cells(5).Value) And dgv.Rows(i).Cells(0).Value <> "" Then
                    dgv.Rows(i).Cells(5).Value = 1
                    subTotal = subTotal + 1
                    MsgBoxError("Error Bon Order : Must fill numeric")
                ElseIf Not IsNumeric(dgv.Rows(i).Cells(5).Value) And dgv.Rows(i).Cells(0).Value = "" Then
                    dgv.Rows.RemoveAt(i)
                    'dgv.Rows.Remove(dgv.CurrentRow)
                    intBaris = intBaris - 1
                    subTotal = subTotal + 0
                ElseIf dgv.Rows(i).Cells(0).Value = "" Then
                    dgv.Rows.RemoveAt(i)
                    'dgv.Rows.Remove(dgv.CurrentRow)
                    intBaris = intBaris - 1
                    subTotal = subTotal + 0
                Else
                    subTotal = subTotal + Val(dgv.Rows(i).Cells(5).Value)
                End If
            Next
            txtTotNetto.Text = subTotal
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub AddGridDetailRawMatrial()
        With dgvrawmatrial
            .Rows.Add()
            .Item(0, intBarisRaw).Value = cmbRawCode.SelectedValue
            .Item(1, intBarisRaw).Value = cmbRawCode.Text
            .Item(2, intBarisRaw).Value = cmbUnit.SelectedValue
            .Item(3, intBarisRaw).Value = cmbUnit.Text
            .Item(4, intBarisRaw).Value = txtQty.Text
        End With
        intBarisRaw = intBarisRaw + 1
    End Sub
    Sub PreCreateDisplay()
        Try
            ClearAll()
            GridDetail()
            GridMaterial()
            ComboBoxRawMaterial()
            ComboBoxUnit()
            ComboBoxPI()
            CheckPermission()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PreViewDisplay()
        Try
            PrepareByHeaderIDView()
            PrepareDetailByHeaderID()
            CheckPermission()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PreUpdateDisplay()
        Try
            PrepareByHeaderID()
            PrepareDetailByHeaderID()
            CheckPermission()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub InsertData()
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim orderCode As String = bonOrderBFC.GetBonOrderCode(custCode)
        Dim orderID As Long = bonOrderBFC.GetBonOrderID
        Dim logDesc As String = "Create new Bon Order,BON Order is " + orderCode

        Try
            If bonOrderBFC.InsertData(SetDataHeader(orderID, orderCode), SetDetail(orderID), SetDetailMaterial(orderID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxSaved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False

            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub UpdateData()
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Bon Order,Where Bon Order Code = " + txtCode.Text
        Try
            If bonOrderBFC.UpdateData(SetDataHeader(bonOrderID, txtCode.Text), SetDetail(bonOrderID), SetDetailMaterial(bonOrderID), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxUpdated()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
            bonOrderBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            bonOrderBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub ApproveData()
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Approve Bon Order,Where Bon Order Code = " + txtCode.Text
        conBon = "Approve"
        Try
            If bonOrderBFC.UpdateStatus(SetDataHeader(bonOrderID, txtCode.Text), SetDataPI("Approve"), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxApproved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
            bonOrderBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            bonOrderBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub
    Sub VoidData()
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Void Bon Order,Where Bon Order Code = " + txtCode.Text
        conBon = "Void"
        Try
            If bonOrderBFC.UpdateStatus(SetDataHeader(bonOrderID, txtCode.Text), SetDataPI("Void"), logBFC.SetLogHistoryTrans(logDesc)) = True Then
                MsgBoxApproved()
                CheckPermission()
                btnPrint.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = False
            End If
            bonOrderBFC = Nothing
            logBFC = Nothing
        Catch ex As Exception
            bonOrderBFC = Nothing
            logBFC = Nothing
            Throw ex
        End Try
    End Sub

#End Region

#Region "Button"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            PreparePIByPIHeaderID()
        Catch ex As Exception
            MsgBoxError("Error Bon Order : " + ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmptyHeader() = False And CheckEmptyDetail() = False And CheckEmptyRawMatrial() = False Then
            Try
                InsertData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckEmptyHeader() = False And CheckEmptyDetail() = False Then
            Try
                UpdateData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If CheckEmptyHeader() = False And CheckEmptyDetail() = False Then
            Try
                ApproveData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        If CheckEmptyHeader() = False And CheckEmptyDetail() = False Then
            Try
                VoidData()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
#End Region

#Region "Raw State Change"
    Private Sub dgv_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgv.RowStateChanged
        intPost = e.Row.Index
    End Sub
#End Region

#Region "Other"
    Private Sub FrmBonOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case conBon
                Case "Create"
                    PreCreateDisplay()
                Case "Update"
                    PreUpdateDisplay()
                Case "View"
                    PreViewDisplay()
            End Select
        Catch ex As Exception
            MsgBoxError("Error Bon Order : " + ex.Message)
        End Try
    End Sub
    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        If e.ColumnIndex = 4 Then
            Try
                SumBruto()
            Catch ex As Exception
                MsgBoxError(msgError + "please delete column")
            End Try
        End If

        If e.ColumnIndex = 5 Then
            Try
                SumNetto()
            Catch ex As Exception
                MsgBoxError(msgError + "please delete column")
                'dgv.Rows(e.RowIndex).Cells(5).Value = 1
            End Try
        End If

    End Sub

    Private Sub dgv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgv.KeyPress
        If e.KeyChar = Chr(27) Then 'ESC
            dgv.Rows.Remove(dgv.CurrentRow)
            SumBruto()
            SumNetto()
        End If
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        Try
            If txtCustomer.Text <> "" Then
                If e.ColumnIndex = 4 Then
                    Try
                        SumBruto()
                    Catch ex As Exception
                        MsgBoxError(msgError + "please delete column")
                    End Try
                End If

                If e.ColumnIndex = 5 Then
                    Try
                        SumNetto()
                    Catch ex As Exception
                        MsgBoxError(msgError + "please delete column")
                        'dgv.Rows(e.RowIndex).Cells(5).Value = 1
                    End Try
                End If

            End If
        Catch ex As Exception
            MsgBoxError(msgError + ex.Message)
        End Try
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintData()
    End Sub

    Private Sub cmbRawCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRawCode.SelectedIndexChanged
        Try
            RetrieveQtyStock()
        Catch ex As Exception
        End Try
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
            DeleteGrid(dgvrawmatrial)
        Catch ex As Exception

        End Try
        intBarisRaw = intBarisRaw - 1
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        CheckNumber(txtQty)
    End Sub
#End Region

End Class