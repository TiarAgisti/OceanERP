Public Class FrmUnit
#Region "Declaration"
    Dim unitID As Integer = 0
    Dim unitName As String = ""
    Dim display As String = ""
    Dim isCreate As Boolean = False
    Dim isUpdate As Boolean = False
    Dim isDelete As Boolean = False
#End Region

#Region "Function"
    Sub ClearText()
        txtUnitName.Clear()
        txtDescription.Clear()
        cmbCari.Text = ""
        txtCari.Clear()
    End Sub
    Sub PropertiesGrid()
        With dgv
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Unit Name"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Description"
            .Columns(2).Width = 200
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    Sub ListUnit(myOptions As String, myParam As String)
        Try
            Dim unitBFC As ClsUnit = New ClsUnit
            With dgv
                .DataSource = unitBFC.RetrieveList(myOptions, myParam)
                .ReadOnly = True
            End With
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub EnabledText(status As Boolean)
        txtUnitName.Enabled = status
        txtDescription.Enabled = status
    End Sub

    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then isCreate = True
        If roleModel.IsUpdate = True Then isUpdate = True
        If roleModel.IsDelete = True Then isDelete = True
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
        ListUnit(cmbCari.Text, txtCari.Text)
        EnabledText(False)
        ButtonAdd()
        display = ""
        btnAdd.Focus()
    End Sub

    Function CheckEmpty() As Boolean
        If txtUnitName.Text = String.Empty Then
            MsgBoxWarning("Unit Name can't empty")
            txtUnitName.Focus()
            Return True
        ElseIf txtDescription.Text = String.Empty Then
            MsgBoxWarning("Description can't empty")
            txtDescription.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Function SetModel() As UnitModel
        Dim unitModel As UnitModel = New UnitModel
        Dim unitBFC As ClsUnit = New ClsUnit
        Select Case display
            Case "Create"
                With unitModel
                    .UnitID = unitBFC.GeneratedAutoNumber
                    .UnitName = txtUnitName.Text
                    .Description = txtDescription.Text
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
            Case "Update"
                With unitModel
                    .UnitID = unitID
                    .UnitName = txtUnitName.Text
                    .Description = txtDescription.Text
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
            Case Else
                With unitModel
                    .UnitID = unitID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                End With
        End Select
        Return unitModel
    End Function
    Sub InsertUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Unit,Unit name is " + txtUnitName.Text
        Try
            If unitBFC.GetValidateUnitName(txtUnitName.Text) = True Then
                If unitBFC.InsertUnit(SetModel, logBFC.SetLogHistory(logDesc)) = True Then
                    MsgBoxSaved()
                    PreCreateDisplay()
                End If
            Else
                MsgBoxError("Unit Name can't duplicate entry")
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Unit for unit id = " + Convert.ToString(unitID)
        Try
            If txtUnitName.Text = unitName Then
                If unitBFC.UpdateUnit(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                    MsgBoxUpdated()
                    PreCreateDisplay()
                End If
            ElseIf txtUnitName.Text <> unitName Then
                If unitBFC.GetValidateUnitName(txtUnitName.Text) = True Then
                    If unitBFC.UpdateUnit(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                        MsgBoxUpdated()
                        PreCreateDisplay()
                    End If
                Else
                    MsgBoxError("Unit Name can't duplicate entry")
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub DeleteUnit()
        Dim unitBFC As ClsUnit = New ClsUnit
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Unit for unit id = " + Convert.ToString(unitID) + ",update IsActive = False"
        display = "Delete"
        Try
            If unitBFC.UpdateUnit(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
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
        txtUnitName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckEmpty() = False Then
            Try
                Select Case display
                    Case "Create"
                        InsertUnit()
                    Case "Update"
                        UpdateUnit()
                End Select
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBoxQuestion() = DialogResult.Yes Then
            Try
                DeleteUnit()
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
    Private Sub txtUnitName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDescription.Focus()
        End If
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub cmbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCari.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCari.SelectedIndexChanged
        txtCari.Focus()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ListUnit(cmbCari.Text, txtCari.Text)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        With dgv
            Dim row As Integer = .CurrentRow.Index
            unitID = .Item(0, row).Value
            txtUnitName.Text = .Item(1, row).Value
            unitName = .Item(1, row).Value
            txtDescription.Text = .Item(2, row).Value
        End With

        display = "Update"

        ButtonUpdate()
        EnabledText(True)
    End Sub

    Private Sub FrmUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
        Text = title
    End Sub
#End Region

End Class