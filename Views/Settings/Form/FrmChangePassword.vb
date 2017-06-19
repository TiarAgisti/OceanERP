Public Class FrmChangePassword

#Region "Function"
    Sub ClearData()
        txtOldPassword.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
    End Sub
    Function SetModel() As UserModel
        Dim userBFC As ClsUser = New ClsUser
        Dim userModel As UserModel = New UserModel
        userModel.UserID = userID
        userModel.userpassword = userBFC.EncryptionPassword(txtConfirm.Text, valueKey)
        userModel.UpdatedBy = userID
        userModel.UpdatedDate = DateTime.Now
        Return userModel
    End Function
    Function RetrievePassword(id As Integer, pass As String) As Boolean
        Dim userBFC As ClsUser = New ClsUser
        Dim userModel As UserModel = New UserModel
        Try
            userModel = userBFC.RetrievePasswordByUserIDPassword(userID, pass)
            If userModel.userpassword = userBFC.EncryptionPassword(pass, valueKey) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBoxError(ex.Message)
        End Try
    End Function

    Sub UpdatePassword()
        Dim menu As New MenuUtama
        Dim userBFC As ClsUser = New ClsUser
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim desc As String = "Update password for user = " + menu.toltipUserName.Text
        Try
            If userBFC.UpdatePassword(SetModel, logBFC.SetLogHistory(desc)) Then
                ClearData()
                MsgBoxSaved()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region


#Region "Button"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdatePassword()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
#End Region

#Region "Other"
    Private Sub txtOldPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If RetrievePassword(userID, txtOldPassword.Text) Then
                txtPassword.Focus()
            Else
                txtOldPassword.Clear()
                txtOldPassword.Focus()
                MsgBoxWarning("Wrong Password,please try again")
            End If
        End If
    End Sub

    Private Sub txtOldPassword_Validated(sender As Object, e As EventArgs) Handles txtOldPassword.Validated
        If txtOldPassword.Text = "" Then
            txtOldPassword.Text = ""
        Else
            If RetrievePassword(userID, txtOldPassword.Text) Then
                txtPassword.Focus()
            Else
                txtOldPassword.Clear()
                txtOldPassword.Focus()
                MsgBoxWarning("Wrong Password,please try again")
            End If
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
                MsgBoxWarning("Wrong Confirmation Password")
                txtConfirm.Clear()
                txtConfirm.Focus()
            Else
                btnSave.Focus()
            End If
        End If
    End Sub

    Private Sub txtConfirm_Validated(sender As Object, e As EventArgs) Handles txtConfirm.Validated
        If txtConfirm.Text = "" Then
            txtConfirm.Text = ""
        Else
            If txtConfirm.Text <> txtPassword.Text Then
                MsgBoxWarning("Wrong Confirmation Password")
                txtConfirm.Clear()
                txtConfirm.Focus()
            Else
                btnSave.Focus()
            End If
        End If
    End Sub
#End Region
End Class