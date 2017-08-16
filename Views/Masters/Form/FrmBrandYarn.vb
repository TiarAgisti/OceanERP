Public Class FrmBrandYarn
#Region "Declaration"
    Dim brandYarnID As Integer = 0
    Dim brandYarnName As String = ""
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
        txtName.Clear()
        txtCari.Clear()
    End Sub

    Sub PropertiesGrid()
        With dgv
            .Columns(0).HeaderText = "Brand Yarn ID"
            .Columns(0).Visible = False

            .Columns(1).HeaderText = "Brand Yarn Name"
            .Columns(1).Width = 100

            .Columns(2).HeaderText = "Is Active"
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "Created By"
            .Columns(3).Visible = False

            .Columns(4).HeaderText = "Created Date"
            .Columns(4).Visible = False

            .Columns(5).HeaderText = "Updated By"
            .Columns(5).Visible = False

            .Columns(6).HeaderText = "Updated Date"
            .Columns(6).Visible = False
        End With
    End Sub

    Sub ListData(myOptions As String, myParam As String)
        Try
            Dim brandYarnBFC As ClsBrandYarn = New ClsBrandYarn
            dgv.DataSource = brandYarnBFC.RetrieveList(myOptions, myParam)
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Function CheckEmpty() As Boolean
        Dim check As Boolean = True
        If Trim(txtName.Text) = String.Empty Then
            MsgBoxWarning("Name can't empty")
            txtName.Focus()
        Else
            check = False
        End If
        Return check
    End Function

    Function SetModel() As BrandYarnModel
        Dim brandYarnModel As BrandYarnModel = New BrandYarnModel
        Dim brandYarnBFC As ClsBrandYarn = New ClsBrandYarn
        With brandYarnModel
            Select Case display
                Case "Create"
                    .BrandYarnID = brandYarnBFC.GeneratedAutoNumber
                    .BrandYarnName = txtName.Text
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .BrandYarnID = brandYarnID
                    .BrandYarnName = txtName.Text
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case Else
                    .BrandYarnID = brandYarnID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return brandYarnModel
    End Function
    Sub EnabledText(status As Boolean)
        txtName.Enabled = status
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
        ListData("", txtCari.Text)
        EnabledText(False)
        ButtonAdd()
        display = ""
        Text = title
    End Sub

    Sub InsertData()
        Dim brandYarnBFC As ClsBrandYarn = New ClsBrandYarn
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Brand Yarn,Brand Yarn name is " + txtName.Text
        Try
            If brandYarnBFC.GetValidateName(txtName.Text) = True Then
                If brandYarnBFC.InsertData(SetModel, logBFC.SetLogHistory(logDesc)) = True Then
                    MsgBoxSaved()
                    PreCreateDisplay()
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateData()
        Dim brandYarnBFC As ClsBrandYarn = New ClsBrandYarn
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Brand Yarn for Brand Yarn ID =  " & Convert.ToString(brandYarnID)
        Try
            If txtName.Text = brandYarnName Then
                If brandYarnBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                    MsgBoxUpdated()
                    PreCreateDisplay()
                End If
            ElseIf txtName.Text <> brandYarnName Then
                If brandYarnBFC.GetValidateName(txtName.Text) = True Then
                    If brandYarnBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
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
        Dim brandYarnBFC As ClsBrandYarn = New ClsBrandYarn
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Brand Yarn for ID = " & Convert.ToString(brandYarnID) & ",update IsActive = False"
        display = "Delete"
        Try
            If brandYarnBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
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
            btnSave.Focus()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ListData("Brand Yarn", txtCari.Text)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        With dgv
            If .RowCount > 1 Then
                Dim row As Integer = .CurrentRow.Index
                brandYarnID = .Item(0, row).Value
                txtName.Text = .Item(1, row).Value
                brandYarnName = .Item(1, row).Value
                display = "Update"

                ButtonUpdate()
                EnabledText(True)
            End If
        End With
    End Sub

    Private Sub FrmBrandYarn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
    End Sub

#End Region
End Class