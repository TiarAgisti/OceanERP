﻿Public Class FrmRawMaterial
#Region "Declaration"
    Dim rawMaterialID As Integer = 0
    Dim rawMaterialName As String = ""
    Dim display As String = ""
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

    Sub ClearText()
        txtCode.Text = AutoGenerated
        txtName.Clear()
        txtSpec.Clear()
        cmbVendor.Text = ""
        cmbCari.Text = ""
        txtCari.Clear()
    End Sub

    Sub PropertiesGrid()
        With dgv
            .Columns(0).HeaderText = "Raw Material ID"
            .Columns(0).Visible = False

            .Columns(1).HeaderText = "Raw Material Code"
            .Columns(1).Width = 100

            .Columns(2).HeaderText = "Raw Material Name"
            .Columns(2).Width = 150

            .Columns(3).HeaderText = "Supplier ID"
            .Columns(3).Visible = False

            .Columns(4).HeaderText = "Specification"
            .Columns(4).Width = 150

            .Columns(5).HeaderText = "Is Active"
            .Columns(5).Visible = False

            .Columns(6).HeaderText = "Supplier"
            .Columns(6).Width = 200
        End With
    End Sub

    Sub ListData(myOptions As String, myParam As String)
        Try
            Dim rawMaterialBFC As ClsRawMaterial = New ClsRawMaterial
            dgv.DataSource = rawMaterialBFC.RetrieveList(myOptions, myParam)
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub ComboBoxSupplier(cmb As ComboBox)
        Dim vendorBFC As ClsVendor = New ClsVendor
        Dim statusVendor As Char = "S"
        vendorBFC.ComboBoxVendor(cmb, statusVendor)
    End Sub

    Function CheckEmpty() As Boolean
        Dim check As Boolean = True
        If Trim(txtName.Text) = String.Empty Then
            MsgBoxWarning("Name can't empty")
            txtName.Focus()
        ElseIf Trim(txtSpec.Text) = String.Empty Then
            MsgBoxWarning("Specification can't empty")
            txtSpec.Focus()
        ElseIf cmbVendor.SelectedValue = 0 Then
            MsgBoxWarning("Supplier not valid")
            cmbVendor.Focus()
        Else
            check = False
        End If
        Return check
    End Function

    Function SetModel() As RawMaterialModel
        Dim rawModel As RawMaterialModel = New RawMaterialModel
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        With rawModel
            Select Case display
                Case "Create"
                    .RawMaterialID = rawBFC.GeneratedAutoNumber
                    .RawMaterialCode = rawBFC.GeneratedCode
                    .RawMaterialName = txtName.Text
                    .SpecRawMaterial = txtSpec.Text
                    .VendorID = cmbVendor.SelectedValue
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .RawMaterialID = rawMaterialID
                    .RawMaterialName = txtName.Text
                    .SpecRawMaterial = txtSpec.Text
                    .VendorID = cmbVendor.SelectedValue
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case Else
                    .RawMaterialID = rawMaterialID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return rawModel
    End Function

    Sub EnabledText(status As Boolean)
        txtName.Enabled = status
        txtSpec.Enabled = status
        cmbVendor.Enabled = status
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
        ListData(cmbCari.Text, txtCari.Text)
        EnabledText(False)
        ButtonAdd()
        display = ""
        Text = title
    End Sub

    Sub InsertData()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Yarn,Yarn name is " + txtName.Text
        Try
            If rawBFC.GetValidateName(txtName.Text) = True Then
                If rawBFC.InsertData(SetModel, logBFC.SetLogHistory(logDesc)) = True Then
                    MsgBoxSaved()
                    PreCreateDisplay()
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateData()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Raw Material for Code = " + txtCode.Text
        Try
            If txtName.Text = rawMaterialName Then
                If rawBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                    MsgBoxUpdated()
                    PreCreateDisplay()
                End If
            ElseIf txtName.Text <> rawMaterialName Then
                If rawBFC.GetValidateName(txtName.Text) = True Then
                    If rawBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                        MsgBoxUpdated()
                        PreCreateDisplay()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub DeleteData()
        Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Raw Material for Code = " + txtCode.Text + ",update IsActive = False"
        display = "Delete"
        Try
            If rawBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                MsgBoxDeleted()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Button"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EnabledText(True)
        display = "Create"
        ButtonSave()
        ComboBoxSupplier(cmbVendor)
        txtName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmpty() = False Then
            Try
                Select Case display
                    Case "Create"
                        InsertData()
                    Case "Update"
                        UpdateData()
                End Select
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBoxQuestion() = DialogResult.Yes Then
            Try
                DeleteData()
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
            txtSpec.Focus()
        End If
    End Sub

    Private Sub txtSpec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpec.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbVendor.Focus()
        End If
    End Sub

    Private Sub cmbVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbVendor.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor.SelectedIndexChanged
        btnSave.Focus()
    End Sub

    Private Sub cmbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCari.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCari.SelectedIndexChanged
        btnSave.Focus()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ListData(cmbCari.Text, txtCari.Text)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        ComboBoxSupplier(cmbVendor)
        With dgv
            If .RowCount > 1 Then
                Dim row As Integer = .CurrentRow.Index
                rawMaterialID = .Item(0, row).Value
                txtCode.Text = .Item(1, row).Value
                txtName.Text = .Item(2, row).Value
                rawMaterialName = .Item(2, row).Value
                cmbVendor.SelectedValue = .Item(3, row).Value
                txtSpec.Text = .Item(4, row).Value
                display = "Update"

                ButtonUpdate()
                EnabledText(True)
            End If
        End With
    End Sub

    Private Sub FrmRawMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
    End Sub
#End Region
End Class