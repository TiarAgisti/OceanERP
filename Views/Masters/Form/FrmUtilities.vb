﻿Public Class FrmUtilities
    Dim isCreate As Boolean = False
    Dim isUpdate As Boolean = False
    Dim isDelete As Boolean = False
    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then isCreate = True
        If roleModel.IsUpdate = True Then isUpdate = True
        If roleModel.IsDelete = True Then isDelete = True
    End Sub
#Region "Declaration Department"
    Dim deptID As Integer = 0
    Dim displayDept As String = ""
#End Region

#Region "Declaration Brand"
    Dim brandID As Integer = 0
    Dim displayBrand As String = ""
#End Region

#Region "Function Department"
    Sub ClearTextDepart()
        txtCodeDept.Text = AutoGenerated
        txtNameDept.Clear()
        cmbCariDept.Text = ""
        txtCariDept.Clear()
    End Sub

    Sub PropertiesGridDept()
        With dgvDept
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Department Code"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Name"
            .Columns(2).Width = 350
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    Sub ListDept(myOptions As String, myParam As String)
        Try
            Dim deptBFC As ClsDepartment = New ClsDepartment
            With dgvDept
                .DataSource = deptBFC.RetrieveList(myOptions, myParam)
                .ReadOnly = True
            End With
            PropertiesGridDept()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub EnabledTextDept(status As Boolean)
        txtNameDept.Enabled = status
    End Sub

    Sub ButtonAddDept()
        If isCreate = True Then btnAddDept.Enabled = True
        btnSaveDept.Enabled = False
        btnDeleteDept.Enabled = False
        btnCancelDept.Enabled = False
    End Sub
    Sub ButtonSaveDept()
        btnAddDept.Enabled = False
        btnSaveDept.Enabled = True
        btnDeleteDept.Enabled = False
        btnCancelDept.Enabled = True
    End Sub
    Sub ButtonUpdateDept()
        btnAddDept.Enabled = False
        If isUpdate = True Then btnSaveDept.Enabled = True
        If isDelete = True Then btnDeleteDept.Enabled = True
        btnCancelDept.Enabled = True
    End Sub
    Sub PreCreateDisplayDept()
        ClearTextDepart()
        ListDept(cmbCariDept.Text, txtCariDept.Text)
        EnabledTextDept(False)
        ButtonAddDept()
        displayDept = ""
    End Sub
    Function CheckEmptyDept() As Boolean
        If txtNameDept.Text = String.Empty Then
            MsgBoxWarning("Name can't empty")
            txtNameDept.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Function SetDeptModel() As DepartmentModel
        Dim deptModel As DepartmentModel = New DepartmentModel
        Dim deptBFC As ClsDepartment = New ClsDepartment
        Select Case displayDept
            Case "Create"
                With deptModel
                    .DepartmentID = deptBFC.GeneratedAutoNumber
                    .DepartmentCode = deptBFC.GeneratedCode
                    .Name = txtNameDept.Text
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
            Case "Update"
                With deptModel
                    .DepartmentID = deptID
                    .Name = txtNameDept.Text
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
            Case Else
                With deptModel
                    .DepartmentID = deptID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
        End Select
        Return deptModel
    End Function
    Sub InsertDept()
        Dim deptBFC As ClsDepartment = New ClsDepartment
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Department,Department name is " + txtNameDept.Text
        Try
            If deptBFC.InsertDepart(SetDeptModel, logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxSaved()
                PreCreateDisplayDept()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateDept()
        Dim deptBFC As ClsDepartment = New ClsDepartment
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Department for DepartmentCode = " + txtCodeDept.Text
        Try
            If deptBFC.UpdateDepartment(SetDeptModel, logBFC.SetLogHistory(logDesc), displayDept) = True Then
                MsgBoxUpdated()
                PreCreateDisplayDept()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub DeleteDept()
        Dim deptBFC As ClsDepartment = New ClsDepartment
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Department for DepartmentCode = " + txtCodeDept.Text + ",update IsActive = False"
        displayDept = "Delete"
        Try
            If deptBFC.UpdateDepartment(SetDeptModel, logBFC.SetLogHistory(logDesc), displayDept) = True Then
                MsgBoxDeleted()
                PreCreateDisplayDept()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Function Brand"
    Sub ClearTextBrand()
        txtCodeBrand.Text = AutoGenerated
        txtNameBrand.Clear()
        txtDesc.Clear()
        cmbCariBrand.Text = ""
        txtCariBrand.Clear()
    End Sub
    Sub PropertiesGridBrand()
        With dgvBrand
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Brand Code"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Name"
            .Columns(2).Width = 250
            .Columns(3).HeaderText = "Description"
            .Columns(3).Width = 250
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
    End Sub

    Sub ListBrand(myOptions As String, myParam As String)
        Try
            Dim brandBFC As ClsBrand = New ClsBrand
            With dgvBrand
                .DataSource = brandBFC.RetrieveList(myOptions, myParam)
                .ReadOnly = True
            End With
            PropertiesGridBrand()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub EnabledTextBrand(status As Boolean)
        txtNameBrand.Enabled = status
        txtDesc.Enabled = status
    End Sub

    Sub ButtonAddBrand()
        If isCreate = True Then btnAddBrand.Enabled = True
        btnSaveBrand.Enabled = False
        btnDeleteBrand.Enabled = False
        btnCancelBrand.Enabled = False
    End Sub
    Sub ButtonSaveBrand()
        btnAddBrand.Enabled = False
        btnSaveBrand.Enabled = True
        btnDeleteBrand.Enabled = False
        btnCancelBrand.Enabled = True
    End Sub
    Sub ButtonUpdateBrand()
        btnAddBrand.Enabled = False
        If isUpdate = True Then btnSaveBrand.Enabled = True
        If isDelete = True Then btnDeleteBrand.Enabled = True
        btnCancelBrand.Enabled = True
    End Sub
    Sub PreCreateDisplayBrand()
        ClearTextBrand()
        ListBrand(cmbCariBrand.Text, txtCariBrand.Text)
        EnabledTextBrand(False)
        ButtonAddBrand()
        displayBrand = ""
    End Sub
    Function CheckEmptyBrand() As Boolean
        If txtNameBrand.Text = String.Empty Then
            MsgBoxWarning("Name can't empty")
            txtNameBrand.Focus()
            Return True
        ElseIf txtDesc.Text = String.Empty Then
            MsgBoxWarning("Description can't empty")
            txtDesc.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Function SetBrandModel() As BrandModel
        Dim brandModel As BrandModel = New BrandModel
        Dim brandBFC As ClsBrand = New ClsBrand
        Select Case displayBrand
            Case "Create"
                With brandModel
                    .BrandID = brandBFC.GeneratedAutoNumber
                    .BrandCode = brandBFC.GeneratedCode
                    .Name = txtNameBrand.Text
                    .Description = txtDesc.Text
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
            Case "Update"
                With brandModel
                    .BrandID = brandID
                    .Name = txtNameBrand.Text
                    .Description = txtDesc.Text
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
            Case Else
                With brandModel
                    .BrandID = brandID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
        End Select
        Return brandModel
    End Function
    Sub InsertBrand()
        Dim brandBFC As ClsBrand = New ClsBrand
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Brand,Brand name is " + txtNameBrand.Text
        Try
            If brandBFC.InsertBrand(SetBrandModel, logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxSaved()
                PreCreateDisplayBrand()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub UpdateBrand()
        Dim brandBFC As ClsBrand = New ClsBrand
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Brand for BrandCode = " + txtCodeBrand.Text
        Try
            If brandBFC.UpdateBrand(SetBrandModel, logBFC.SetLogHistory(logDesc), displayBrand) = True Then
                MsgBoxUpdated()
                PreCreateDisplayBrand()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Sub DeleteBrand()
        Dim brandBFC As ClsBrand = New ClsBrand
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Brand for BrandCode = " + txtCodeBrand.Text + ",update IsActive = False"
        displayBrand = "Delete"
        Try
            If brandBFC.UpdateBrand(SetBrandModel, logBFC.SetLogHistory(logDesc), displayBrand) = True Then
                MsgBoxDeleted()
                PreCreateDisplayBrand()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Button Department"
    Private Sub btnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click
        EnabledTextDept(True)
        displayDept = "Create"
        ButtonSaveDept()
        txtNameDept.Focus()
    End Sub

    Private Sub btnSaveDept_Click(sender As Object, e As EventArgs) Handles btnSaveDept.Click
        If CheckEmptyDept() = False Then
            Try
                Select Case displayDept
                    Case "Create"
                        InsertDept()
                    Case "Update"
                        UpdateDept()
                End Select
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDeleteDept_Click(sender As Object, e As EventArgs) Handles btnDeleteDept.Click
        If MsgBoxQuestion() = DialogResult.Yes Then
            Try
                DeleteDept()
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelDept_Click(sender As Object, e As EventArgs) Handles btnCancelDept.Click
        PreCreateDisplayDept()
    End Sub

    Private Sub btnExitDept_Click(sender As Object, e As EventArgs) Handles btnExitDept.Click
        Close()
    End Sub
#End Region

#Region "Button Brand"
    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        EnabledTextBrand(True)
        displayBrand = "Create"
        ButtonSaveBrand()
        txtNameBrand.Focus()
    End Sub

    Private Sub btnSaveBrand_Click(sender As Object, e As EventArgs) Handles btnSaveBrand.Click
        If CheckEmptyBrand() = False Then
            Try
                Select Case displayBrand
                    Case "Create"
                        InsertBrand()
                    Case "Update"
                        UpdateBrand()
                End Select
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDeleteBrand_Click(sender As Object, e As EventArgs) Handles btnDeleteBrand.Click
        If MsgBoxQuestion() = DialogResult.Yes Then
            Try
                DeleteBrand()
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelBrand_Click(sender As Object, e As EventArgs) Handles btnCancelBrand.Click
        PreCreateDisplayBrand()
    End Sub

    Private Sub btnExitBrand_Click(sender As Object, e As EventArgs) Handles btnExitBrand.Click
        Close()
    End Sub
#End Region

#Region "Other Department"
    Private Sub txtNameDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameDept.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSaveDept.Focus()
        End If
    End Sub

    Private Sub cmbCariDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCariDept.SelectedIndexChanged
        txtCariDept.Focus()
    End Sub

    Private Sub cmbCariDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCariDept.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txtCariDept_TextChanged(sender As Object, e As EventArgs) Handles txtCariDept.TextChanged
        ListDept(cmbCariDept.Text, txtCariDept.Text)
    End Sub
    Private Sub dgvDept_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDept.CellClick
        With dgvDept
            Dim row As Integer = .CurrentRow.Index
            deptID = .Item(0, row).Value
            txtCodeDept.Text = .Item(1, row).Value
            txtNameDept.Text = .Item(2, row).Value
        End With

        displayDept = "Update"

        ButtonUpdateDept()
        EnabledTextDept(True)
    End Sub
#End Region

#Region "Other Brand"
    Private Sub txtNameBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameBrand.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDesc.Focus()
        End If
    End Sub

    Private Sub txtDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSaveBrand.Focus()
        End If
    End Sub

    Private Sub cmbCariBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCariBrand.SelectedIndexChanged
        txtCariBrand.Focus()
    End Sub

    Private Sub cmbCariBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCariBrand.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txtCariBrand_TextChanged(sender As Object, e As EventArgs) Handles txtCariBrand.TextChanged
        ListBrand(cmbCariBrand.Text, txtCariBrand.Text)
    End Sub
    Private Sub dgvBrand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrand.CellClick
        With dgvBrand
            Dim row As Integer = .CurrentRow.Index
            brandID = .Item(0, row).Value
            txtCodeBrand.Text = .Item(1, row).Value
            txtNameBrand.Text = .Item(2, row).Value
            txtDesc.Text = .Item(3, row).Value
        End With

        displayBrand = "Update"

        ButtonUpdateBrand()
        EnabledTextBrand(True)
    End Sub
#End Region
    Private Sub FrmUtilities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckPermissions()
        PreCreateDisplayDept()
        PreCreateDisplayBrand()
        Text = title
    End Sub
End Class