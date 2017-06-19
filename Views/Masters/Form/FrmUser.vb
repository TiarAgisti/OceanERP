Public Class FrmUser
#Region "Declaration"
    Public myID As Integer = 0
    Public display As String
#End Region

#Region "Function"
    Private Sub ClearText()
        txtUserName.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
    End Sub
    Private Sub ListPermission()
        Dim permissBFC As ClsPermission = New ClsPermission
        cmbPermission.DataSource = permissBFC.ListComboBox
        cmbPermission.DisplayMember = "RoleName"
        cmbPermission.ValueMember = "RoleID"
        permissBFC = Nothing
    End Sub
    Private Sub PreCreateDisplay()
        ClearText()
        ListPermission()
        txtUserName.Enabled = True
        txtUserName.Focus()
        myID = 0
    End Sub
    Function CheckEmpty() As Boolean
        If txtUserName.Text = String.Empty Then
            MsgBoxWarning("User name can't empty")
            txtUserName.Focus()
            Return True
        ElseIf txtPassword.Text = String.Empty Then
            MsgBoxWarning("Password can't empty")
            txtPassword.Focus()
            Return True
        ElseIf txtConfirm.Text = String.Empty Then
            MsgBoxWarning("Confirmation password can't empty")
            txtConfirm.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Function SetUserModel() As UserModel
        Dim user As UserModel = New UserModel
        Dim userBFC As ClsUser = New ClsUser
        Select Case display
            Case "Create"
                user.UserID = userBFC.GeneratedAutoNumber
                user.Name = txtUserName.Text
                user.userpassword = userBFC.EncryptionPassword(txtPassword.Text, valueKey)
                user.RoleID = cmbPermission.SelectedValue
                user.IsActive = True
                user.CreatedBy = userID
                user.CreatedDate = DateTime.Now
                user.UpdatedBy = userID
                user.UpdatedDate = DateTime.Now
            Case "Update"
                user.UserID = myID
                user.Name = txtUserName.Text
                user.userpassword = userBFC.EncryptionPassword(txtPassword.Text, valueKey)
                user.RoleID = cmbPermission.SelectedValue
                user.IsActive = True
                user.UpdatedBy = userID
                user.UpdatedDate = DateTime.Now
        End Select
        Return user
    End Function
    Private Sub InsertUser()
        Dim userBFC As ClsUser = New ClsUser
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim myUserID As Integer = userID
        Dim logDesc As String = "Create new user " + txtUserName.Text
        Try
            If userBFC.InsertUser(SetUserModel, logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxSaved()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub UpdateUser()
        Dim userBFC As ClsUser = New ClsUser
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim myUserID As Integer = userID
        Dim logDesc As String = "Update user " + txtUserName.Text
        Try
            If userBFC.UpdateUser(SetUserModel, logBFC.SetLogHistory(logDesc)) = True Then
                MsgBoxUpdated()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Other"

    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case display
            Case "Create"
                PreCreateDisplay()
            Case "Update"
                ListPermission()
                Dim userBFC As ClsUser = New ClsUser
                Dim userModel As UserModel = New UserModel
                Try
                    userModel = userBFC.RetrieveByID(myID)

                    txtUserName.Text = userModel.Name
                    txtPassword.Text = userBFC.DecryptionPassword(userModel.userpassword, valueKey)
                    txtConfirm.Text = userBFC.DecryptionPassword(userModel.userpassword, valueKey)
                    cmbPermission.SelectedValue = userModel.RoleID

                    txtUserName.Enabled = False
                    txtPassword.Focus()
                Catch ex As Exception
                    MsgBoxError(ex.Message)
                End Try
        End Select
    End Sub
    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim userBFC As ClsUser = New ClsUser
            Try
                If userBFC.CheckUserName(txtUserName.Text) Then
                    txtPassword.Focus()
                Else
                    MsgBoxError("User Name is Available,please change user name!!!")
                    txtUserName.Clear()
                    txtUserName.Focus()
                End If
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtUserName_Validated(sender As Object, e As EventArgs) Handles txtUserName.Validated
        If txtUserName.Text = "" Then
            txtUserName.Text = ""
        Else
            Dim userBFC As ClsUser = New ClsUser
            Try
                If userBFC.CheckUserName(txtUserName.Text) Then
                    txtPassword.Focus()
                Else
                    MsgBoxError("User Name is Available,please change user name!!!")
                    txtUserName.Clear()
                    txtUserName.Focus()
                End If
            Catch ex As Exception
                MsgBoxError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            txtConfirm.Focus()
        End If
    End Sub
    Private Sub txtConfirm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirm.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtConfirm.Text <> txtPassword.Text Then
                MsgBoxError("Wrong password confirmation!!!")
                txtConfirm.Clear()
                txtConfirm.Focus()
            Else
                cmbPermission.Focus()
            End If
        End If
    End Sub
    Private Sub txtConfirm_Validated(sender As Object, e As EventArgs) Handles txtConfirm.Validated
        If txtConfirm.Text = "" Then
            txtConfirm.Text = ""
        Else
            If txtConfirm.Text <> txtPassword.Text Then
                MsgBoxError("Wrong password confirmation!!!")
                txtConfirm.Clear()
                txtConfirm.Focus()
            Else
                cmbPermission.Focus()
            End If
        End If
    End Sub
    Private Sub cmbPermission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermission.SelectedIndexChanged
        btnSave.Focus()
    End Sub
    Private Sub cmbPermission_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPermission.KeyPress
        e.KeyChar = Chr(0)
    End Sub
#End Region

#Region "Button"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        PreCreateDisplay()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If CheckEmpty() = False Then
                Select Case display
                    Case "Create"
                        InsertUser()
                    Case "Update"
                        UpdateUser()
                End Select
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region
End Class