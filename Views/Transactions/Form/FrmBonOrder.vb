Public Class FrmBonOrder
#Region "Declaration"
    Public conBon As String
    Public Shared bonOrderID As Long = 0
    Dim intBaris As Integer
    Dim intPost As Integer
    Dim custCode As String = ""
    Dim statusBOn As Int16
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
    Sub GridDetail()
        Try
            With dgv
                .Columns.Add(0, "Fabric Details / Item No")
                .Columns(0).Width = 200

                .Columns.Add(1, "Width x Weight")
                .Columns(1).Width = 150

                .Columns.Add(2, "Color")
                .Columns.Add(3, "Labs Dips No")
                .Columns.Add(4, "Bruto")
                .Columns.Add(5, "Netto")


                .Columns.Add(6, "FabricID")
                .Columns(6).Visible = False

                .Columns.Add(7, "ColorID")
                .Columns(7).Visible = False
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Clear Data"
    Sub ClearAll()
        txtNoPO.Clear()
        txtCustomer.Clear()
        txtBrand.Clear()
        txtStyle.Clear()
        dgv.Columns.Clear()
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

    Sub PrepareDetailByHeaderID()
        Dim listDetail As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Try
            GridDetail()
            listDetail = piBFC.RetrieveAllDetailByHeaderID(cmbPINo.SelectedValue)
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
        Catch ex As Exception
            Throw ex
        Finally
            listDetail = Nothing
            piBFC = Nothing
        End Try
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

#End Region

End Class