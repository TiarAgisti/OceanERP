Public Class FrmBonOrder
#Region "Declaration"
    Public conBon As String
    Public Shared bonOrderID As Long = 0
    Dim intBaris As Integer
    Dim intPost As Integer
    Dim custCode As String = ""
    Dim statusBOM As Int16
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
                        '.BOMCode = bomBFC.GetBOMCode(buyerCode)
                        '.FabricID = cmbFabric.SelectedValue
                        '.BuyerID = cmbBuyer.SelectedValue
                        '.StyleID = cmbStyle.SelectedValue
                        '.ColorID = cmbColor.SelectedValue
                        '.StatusBOM = status
                        .IsActive = 1
                        .CreatedBy = userID
                        .CreatedDate = DateTime.Now
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                    Case "Update"
                        '.BOMHeaderID = bomHeaderID
                        '.BOMCode = txtCode.Text
                        '.FabricID = cmbFabric.SelectedValue
                        '.BuyerID = cmbBuyer.SelectedValue
                        '.StyleID = cmbStyle.SelectedValue
                        '.ColorID = cmbColor.SelectedValue
                        '.StatusBOM = status
                        .IsActive = 1
                        .UpdatedBy = userID
                        .UpdatedDate = DateTime.Now
                End Select
            End With
            Return headerModel
        Catch ex As Exception
            Throw ex
        Finally
            bomBFC = Nothing
        End Try
    End Function
#End Region

#Region "Function"

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

    End Sub

    Private Sub txtNoPO_TextChanged(sender As Object, e As EventArgs) Handles txtNoPO.TextChanged

    End Sub


#End Region

#Region "Raw State Change"

#End Region

#Region "Other"

#End Region

End Class