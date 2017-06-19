Public Class FrmSupplier
#Region "Declaration"
    Dim supplierID As Integer = 0
    Dim display As String = ""
    Const status As String = "S"
    Dim isCreate As Boolean = False
    Dim isUpdate As Boolean = False
    Dim isDelete As Boolean = False
#End Region

#Region "Function"
    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then isCreate = True
        If roleModel.IsUpdate = True Then isUpdate = True
        If roleModel.IsDelete = True Then isDelete = True
    End Sub
    Sub ListSupplier(myOptions As String, myParam As String)
        Try
            Dim vendorBFC As ClsVendor = New ClsVendor
            dgv.DataSource = vendorBFC.RetrieveList(myOptions, myParam, status)
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub ComboBoxTermOfPayment(cmb As ComboBox)
        Dim topBFC As ClsTermOfPayment = New ClsTermOfPayment
        cmb.DataSource = topBFC.ListComboBoxTerm
        cmb.DisplayMember = "Name"
        cmb.ValueMember = "TermOfPaymentID"
    End Sub
    Sub ComboBoxCountry(cmb As ComboBox)
        Dim destBFC As ClsDestination = New ClsDestination
        Dim statusCountry As Char = "C"
        cmb.DataSource = destBFC.ListComboBoxDestination(statusCountry)
        cmb.DisplayMember = "Name"
        cmb.ValueMember = "DestinationID"
    End Sub
    Function CheckEmpty() As Boolean
        If txtName.Text = String.Empty Then
            MsgBoxWarning("Name can't empty")
            txtName.Focus()
            Return True
        ElseIf txtAddress.Text = String.Empty Then
            MsgBoxWarning("Address can't empty")
            txtAddress.Focus()
            Return True
        ElseIf txtShippAddress.Text = String.Empty Then
            MsgBoxWarning("Shipping Address can't empty")
            txtShippAddress.Focus()
            Return True
        ElseIf txtTelephone.Text = String.Empty Then
            MsgBoxWarning("Telephone can't empty")
            txtName.Focus()
            Return True
        ElseIf txtFax.Text = String.Empty Then
            MsgBoxWarning("Fax can't empty")
            txtFax.Focus()
            Return True
        ElseIf txtCP.Text = String.Empty Then
            MsgBoxWarning("Contact Person can't empty")
            txtCP.Focus()
            Return True
        ElseIf txtEmailCP.Text = String.Empty Then
            MsgBoxWarning("Email CP can't empty")
            txtEmailCP.Focus()
            Return True
        ElseIf txtNpwp.Text = String.Empty Then
            MsgBoxWarning("Npwp can't empty")
            txtNpwp.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Function SetModel() As VendorModel
        Dim vendorModel As VendorModel = New VendorModel
        Dim vendorBFC As ClsVendor = New ClsVendor
        With vendorModel
            Select Case display
                Case "Create"
                    .VendorID = vendorBFC.GeneratedAutoNumber
                    .VendorCode = vendorBFC.GeneratedCode(status)
                    .VendorName = txtName.Text
                    .Address = txtAddress.Text
                    .ShippingAddress = txtShippAddress.Text
                    .Telephone = txtTelephone.Text
                    .Fax = txtFax.Text
                    .ContactPerson = txtCP.Text
                    .EmailCP = txtEmailCP.Text
                    .Npwp = txtNpwp.Text
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .DestinationID = cmbCountry.SelectedValue
                    .Status = status
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .VendorID = supplierID
                    .VendorName = txtName.Text
                    .Address = txtAddress.Text
                    .ShippingAddress = txtShippAddress.Text
                    .Telephone = txtTelephone.Text
                    .Fax = txtFax.Text
                    .ContactPerson = txtCP.Text
                    .EmailCP = txtEmailCP.Text
                    .Npwp = txtNpwp.Text
                    .TermOfPaymentID = cmbTOP.SelectedValue
                    .DestinationID = cmbCountry.SelectedValue
                    .Status = status
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case Else
                    .VendorID = supplierID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return vendorModel
    End Function
    Sub InsertSupplier()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Supplier,Supplier name is " + txtName.Text
        Try
            If vendorBFC.InsertVendor(SetModel, logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxSaved()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub UpdateSupplier()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Supplier for Code = " + txtCode.Text
        Try
            If vendorBFC.UpdateVendor(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                MsgBoxUpdated()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub DeleteSupplier()
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Supplier for Code = " + txtCode.Text + ",update IsActive = False"
        display = "Delete"
        Try
            If vendorBFC.UpdateVendor(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                MsgBoxDeleted()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub ClearText()
        txtCode.Text = AutoGenerated
        txtName.Clear()
        txtAddress.Clear()
        txtShippAddress.Clear()
        txtTelephone.Clear()
        txtFax.Clear()
        txtCP.Clear()
        txtEmailCP.Clear()
        txtNpwp.Clear()
        cmbCari.Text = ""
        txtCari.Clear()
    End Sub
    Sub EnabledText(status As Boolean)
        txtName.Enabled = status
        txtAddress.Enabled = status
        txtShippAddress.Enabled = status
        txtTelephone.Enabled = status
        txtFax.Enabled = status
        txtCP.Enabled = status
        txtEmailCP.Enabled = status
        txtNpwp.Enabled = status
        cmbTOP.Enabled = status
        cmbCountry.Enabled = status
    End Sub
    Sub PropertiesGrid()
        With dgv
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Supplier Code"
            .Columns(1).Width = 100

            .Columns(2).HeaderText = "Name"
            .Columns(2).Width = 150

            .Columns(3).HeaderText = "Address"
            .Columns(3).Width = 150

            .Columns(4).HeaderText = "Billing Address"
            .Columns(4).Width = 150

            .Columns(5).HeaderText = "Telephone"
            .Columns(5).Width = 150

            .Columns(6).HeaderText = "Fax"
            .Columns(6).Width = 150

            .Columns(7).HeaderText = "Contact Person"
            .Columns(7).Width = 150

            .Columns(8).HeaderText = "Email CP"
            .Columns(8).Width = 150

            .Columns(9).HeaderText = "Npwp"
            .Columns(9).Width = 150

            .Columns(10).Visible = False

            .Columns(11).HeaderText = "Term Of Payment"
            .Columns(11).Width = 150

            .Columns(12).Visible = False
            .Columns(13).Visible = False

            .Columns(14).HeaderText = "Country"
            .Columns(14).Width = 150

            .Columns(15).Visible = False
        End With
    End Sub
    Sub ButtonAdd()
        If isCreate = True Then btnAdd.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Sub ButtonSave()
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
    End Sub
    Sub ButtonUpdate()
        btnAdd.Enabled = False
        If isUpdate = True Then btnSave.Enabled = True
        If isDelete = True Then btnDelete.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub PreCreateDisplay()
        CheckPermissions()
        ClearText()
        ListSupplier(cmbCari.Text, txtCari.Text)
        ComboBoxCountry(cmbCountry)
        ComboBoxTermOfPayment(cmbTOP)
        EnabledText(False)
        ButtonAdd()
        display = ""
        Text = title
    End Sub
#End Region

#Region "Button"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EnabledText(True)
        display = "Create"
        ButtonSave()
        txtName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmpty() = False Then
            Try
                Select Case display
                    Case "Create"
                        InsertSupplier()
                    Case "Update"
                        UpdateSupplier()
                End Select
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBoxQuestion() = DialogResult.Yes Then
            Try
                DeleteSupplier()
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        PreCreateDisplay()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
#End Region

#Region "Other"
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        If e.KeyChar = Chr(13) Then
            txtShippAddress.Focus()
        End If
    End Sub

    Private Sub txtShippAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShippAddress.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTelephone.Focus()
        End If
    End Sub

    Private Sub txtTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtFax.Focus()
        End If
    End Sub
    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged
        If txtTelephone.Text = "" Then
            txtTelephone.Text = ""
        Else
            If ValidationNumber(txtTelephone) = False Then
                txtTelephone.Clear()
            End If
        End If
    End Sub
    Private Sub txtFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFax.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCP.Focus()
        End If
    End Sub
    Private Sub txtFax_TextChanged(sender As Object, e As EventArgs) Handles txtFax.TextChanged
        If txtFax.Text = "" Then
            txtFax.Text = ""
        Else
            If ValidationNumber(txtFax) = False Then
                txtFax.Clear()
            End If
        End If
    End Sub
    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If e.KeyChar = Chr(13) Then
            txtEmailCP.Focus()
        End If
    End Sub

    Private Sub txtEmailCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmailCP.KeyPress
        If e.KeyChar = Chr(13) Then
            If ValidationEmail(txtEmailCP.Text) = True Then
                txtNpwp.Focus()
            Else
                MsgBoxWarning("Email not valid")
                txtEmailCP.Clear()
                txtEmailCP.Focus()
            End If
        End If
    End Sub

    Private Sub txtEmailCP_Validated(sender As Object, e As EventArgs) Handles txtEmailCP.Validated
        If txtEmailCP.Text = "" Then
            txtEmailCP.Text = ""
        Else
            If ValidationEmail(txtEmailCP.Text) = True Then
                txtNpwp.Focus()
            Else
                MsgBoxWarning("Email not valid")
                txtEmailCP.Clear()
                txtEmailCP.Focus()
            End If
        End If
    End Sub

    Private Sub txtNpwp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNpwp.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbTOP.Focus()
        End If
    End Sub
    Private Sub cmbTOP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTOP.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbTOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTOP.SelectedIndexChanged
        cmbCountry.Focus()
    End Sub

    Private Sub cmbCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCountry.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCountry.SelectedIndexChanged
        btnSave.Focus()
    End Sub
    Private Sub cmbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCari.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCari.SelectedIndexChanged
        txtCari.Focus()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ListSupplier(cmbCari.Text, txtCari.Text)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        ComboBoxCountry(cmbCountry)
        ComboBoxTermOfPayment(cmbTOP)
        With dgv
            If .RowCount > 1 Then
                Dim row As Integer = .CurrentRow.Index
                supplierID = .Item(0, row).Value
                txtCode.Text = .Item(1, row).Value
                txtName.Text = .Item(2, row).Value
                txtAddress.Text = .Item(3, row).Value
                txtShippAddress.Text = .Item(4, row).Value
                txtTelephone.Text = .Item(5, row).Value
                txtFax.Text = .Item(6, row).Value
                txtCP.Text = .Item(7, row).Value
                txtEmailCP.Text = .Item(8, row).Value
                txtNpwp.Text = .Item(9, row).Value
                cmbTOP.SelectedValue = .Item(10, row).Value
                cmbCountry.SelectedValue = .Item(13, row).Value
                display = "Update"

                ButtonUpdate()
                EnabledText(True)
            End If
        End With
    End Sub

    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
    End Sub
#End Region
End Class