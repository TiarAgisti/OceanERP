Public Class FrmBonOrder
#Region "Declaration"
    Public conBon As String
    Public Shared bonOrderID As Long = 0
    Dim intBaris As Integer
    Dim intPost As Integer
    Dim custCode As String = ""
    Dim statusBOn As Int16
    Dim msgError As String = "Error Bon Order : "
#End Region

#Region "ComboBox"
    Sub ComboBoxPI()
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            piBFC.ComboBoxPI(cmbPINo)
        Catch ex As Exception
            Throw ex
        Finally
            piBFC = Nothing
        End Try
    End Sub
#End Region

#Region "Grid Detail"
    'Sub GridDetail()
    '    Try
    '        With dgv
    '            .Columns.Add(0, "Fabric Details / Item No")
    '            .Columns(0).Width = 200

    '            .Columns.Add(1, "Width x Weight")
    '            .Columns(1).Width = 150

    '            .Columns.Add(2, "Color")
    '            .Columns.Add(3, "Labs Dips No")
    '            .Columns.Add(4, "Bruto")
    '            .Columns.Add(5, "Netto")


    '            .Columns.Add(6, "FabricID")
    '            .Columns(6).Visible = False

    '            .Columns.Add(7, "ColorID")
    '            .Columns(7).Visible = False
    '        End With
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
#End Region

#Region "Clear Data"
    Sub ClearAll()
        txtNoPO.Clear()
        txtCustomer.Clear()
        txtBrand.Clear()
        txtStyle.Clear()
        dtpDateIssues.Focus()
        'dgv.Columns.Clear()
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
        Else
            check = False
        End If
        Return check
    End Function
#End Region

#Region "Set Data"
    Function SetDataHeader() As BonOrderHeaderModel
        Dim headerModel As BonOrderHeaderModel = New BonOrderHeaderModel
        Dim bonBFC As ClsBonOrder = New ClsBonOrder
        Try
            With headerModel
                Select Case conBon
                    Case "Create"
                        .BonOrderID = bonBFC.GetBonOrderID
                        .BonOrderCode = bonBFC.GetBonOrderCode(custCode)
                        .PIHeaderID = cmbPINo.SelectedValue
                        .Status = statusBOn
                        .CreatedBy = userID
                        .CreatedDate = DateTime.Now
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Update"
                        .BonOrderID = bonOrderID
                        .BonOrderCode = txtCode.Text
                        .PIHeaderID = cmbPINo.SelectedValue
                        .Status = statusBOn
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                End Select
            End With
            Return headerModel
        Catch ex As Exception
            Throw ex
        Finally
            bonBFC = Nothing
        End Try
    End Function
    Function SetDetail(bonOrderID As Long) As List(Of BonOrderDetailModel)
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Dim listModel As List(Of BonOrderDetailModel) = New List(Of BonOrderDetailModel)
        Try
            listModel = bonOrderBFC.SetDetail(bonOrderID, dgv)
            Return listModel
        Catch ex As Exception
            Throw ex
        Finally
            bonOrderBFC = Nothing
        End Try
    End Function
#End Region

#Region "Function"
    Sub CheckPermission()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        Try
            roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
            If roleModel.IsCreate = True Then btnSave.Enabled = True
            If roleModel.IsUpdate = True Then btnUpdate.Enabled = True
            If roleModel.IsApprove = True Then btnApprove.Enabled = True
            If roleModel.IsVoid = True Then btnVoid.Enabled = True
        Catch ex As Exception
            Throw ex
        Finally
            roleBFC = Nothing
            roleModel = Nothing
        End Try
    End Sub
    Sub PrepareByHeaderID()
        Dim headerModel As BonOrderHeaderModel = New BonOrderHeaderModel
        Dim bonOrderBFC As ClsBonOrder = New ClsBonOrder
        Try
            ComboBoxPI()
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
        Catch ex As Exception
            Throw ex
        Finally
            headerModel = Nothing
            bonOrderBFC = Nothing
        End Try
    End Sub

    Sub PreparePIByPIHeaderID()
        Dim piModel As PIHeaderModel = New PIHeaderModel
        Dim listDetail As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim piID As Long = cmbPINo.SelectedValue
        Try
            If piID = 0 Then
                Throw New Exception("No data available")
            End If

            piModel = piBFC.RetrieveByID(piID)
            With piModel
                txtCustomer.Text = piModel.CustomerName
                txtNoPO.Text = piModel.RefPO
                txtBrand.Text = piModel.BuyerName
                txtStyle.Text = piModel.BuyerName
            End With

            'GridDetail()
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
                End With
                intBaris = intBaris + 1
            Next
            SumBruto()
            SumNetto()
        Catch ex As Exception
            Throw ex
        Finally
            listDetail = Nothing
            piBFC = Nothing
        End Try
    End Sub

    Sub SumBruto()
        Dim subTotal As Double
        subTotal = 0
        Try
            For i As Integer = 0 To dgv.Rows.Count - 2
                If Convert.ToString(dgv.Rows(i).Cells(4).Value) = "" Then
                    subTotal = 0
                    Throw New Exception("Must fill numeric")
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
                If Convert.ToString(dgv.Rows(i).Cells(5).Value) = "" Then
                    subTotal = 0
                    Throw New Exception("Must fill numeric")
                Else
                    subTotal = subTotal + Val(dgv.Rows(i).Cells(4).Value)
                End If
            Next
            txtTotNetto.Text = subTotal
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub PreCreateDisplay()
        Try
            ClearAll()
            'GridDetail()
            ComboBoxPI()
            CheckPermission()
            btnUpdate.Enabled = False
            btnApprove.Enabled = False
            btnVoid.Enabled = False
            btnPrint.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub PreUpdateDisplay()

    End Sub
#End Region

#Region "Button"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

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
            End Select
        Catch ex As Exception
            MsgBoxError("Error Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub cmbPINo_Validated(sender As Object, e As EventArgs) Handles cmbPINo.Validated
        Try
            PreparePIByPIHeaderID()
        Catch ex As Exception
            MsgBoxError("Error Bon Order : " + ex.Message)
        End Try
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        If e.ColumnIndex = 4 Then
            Try
                SumBruto()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
                dgv.Rows(e.RowIndex).Cells(4).Value = 1
            End Try
        End If

        If e.ColumnIndex = 5 Then
            Try
                SumNetto()
            Catch ex As Exception
                MsgBoxError(msgError + ex.Message)
                dgv.Rows(e.RowIndex).Cells(5).Value = 1
            End Try
        End If

    End Sub
#End Region

End Class