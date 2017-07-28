﻿Public Class FrmStyle
#Region "Declaration"
    Dim styleID As Integer = 0
    Dim styleName As String = ""
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
        cmbCari.Text = ""
        txtCari.Clear()
        styleName = ""
    End Sub

    Sub PropertiesGrid()
        With dgv
            .Columns(0).HeaderText = "Style ID"
            .Columns(0).Visible = False

            .Columns(1).HeaderText = "Style Code"
            .Columns(1).Width = 100

            .Columns(2).HeaderText = "Style Name"
            .Columns(2).Width = 150

            .Columns(3).HeaderText = "Specification"
            .Columns(3).Width = 150

            .Columns(4).HeaderText = "Is Active"
            .Columns(4).Visible = False

            .Columns(5).HeaderText = "Created By"
            .Columns(5).Visible = False

            .Columns(6).HeaderText = "Created Date"
            .Columns(6).Visible = False

            .Columns(7).HeaderText = "Updated By"
            .Columns(7).Visible = False

            .Columns(8).HeaderText = "Updated Date"
            .Columns(8).Visible = False
        End With
    End Sub

    Sub ListData(myOptions As String, myParam As String)
        Try
            Dim styleBFC As ClsStyle = New ClsStyle
            dgv.DataSource = styleBFC.RetrieveList(myOptions, myParam)
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Function CheckEmpty() As Boolean
        If txtName.Text = String.Empty Then
            MsgBoxWarning("Name can't empty")
            txtName.Focus()
            Return True
        ElseIf txtSpec.Text = String.Empty Then
            MsgBoxWarning("Specification can't empty")
            txtSpec.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Function SetModel() As StyleModel
        Dim styleModel As StyleModel = New StyleModel
        Dim styleBFC As ClsStyle = New ClsStyle
        With styleModel
            Select Case display
                Case "Create"
                    .StyleID = styleBFC.GeneratedAutoNumber
                    .StyleCode = styleBFC.GeneratedCode
                    .StyleName = txtName.Text
                    .SpecStyle = txtSpec.Text
                    .IsActive = True
                    .CreatedBy = userID
                    .CreatedDate = DateTime.Now
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case "Update"
                    .StyleID = styleID
                    .StyleName = txtName.Text
                    .SpecStyle = txtSpec.Text
                    .IsActive = True
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
                Case Else
                    .StyleID = styleID
                    .IsActive = False
                    .UpdatedBy = userID
                    .UpdatedDate = DateTime.Now
            End Select
        End With
        Return styleModel
    End Function

    Sub EnabledText(status As Boolean)
        txtName.Enabled = status
        txtSpec.Enabled = status
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
        Dim styleBFC As ClsStyle = New ClsStyle
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Create new Style,Style name is " + txtName.Text
        Try
            If styleBFC.GetValidateName(txtName.Text) = True Then
                If styleBFC.InsertData(SetModel, logBFC.SetLogHistory(logDesc)) = True Then
                    MsgBoxSaved()
                    PreCreateDisplay()
                End If
            Else
                MsgBoxError("Style Name can't duplicate entry")
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub UpdateData()
        Dim styleBFC As ClsStyle = New ClsStyle
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Style for Code = " + txtCode.Text
        Try
            If txtName.Text = styleName Then
                If styleBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                    MsgBoxUpdated()
                    PreCreateDisplay()
                End If
            ElseIf txtName.Text <> styleName Then
                If styleBFC.GetValidateName(txtName.Text) = True Then
                    If styleBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
                        MsgBoxUpdated()
                        PreCreateDisplay()
                    End If
                Else
                    MsgBoxError("Style Name can't duplicate entry")
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Sub DeleteData()
        Dim styleBFC As ClsStyle = New ClsStyle
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim logDesc As String = "Update Style for Code = " + txtCode.Text + ",update IsActive = False"
        display = "Delete"
        Try
            If styleBFC.UpdateData(SetModel, logBFC.SetLogHistory(logDesc), display) = True Then
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
            txtSpec.Focus()
        End If
    End Sub

    Private Sub txtSpec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpec.KeyPress
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
        ListData(cmbCari.Text, txtCari.Text)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        With dgv
            If .RowCount > 1 Then
                Dim row As Integer = .CurrentRow.Index
                styleID = .Item(0, row).Value
                txtCode.Text = .Item(1, row).Value
                txtName.Text = .Item(2, row).Value
                styleName = .Item(2, row).Value
                txtSpec.Text = .Item(3, row).Value
                display = "Update"

                ButtonUpdate()
                EnabledText(True)
            End If
        End With
    End Sub

    Private Sub FrmStyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
    End Sub
#End Region
End Class