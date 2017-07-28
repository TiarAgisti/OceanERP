Public Class FrmLogin
#Region "Function"
    Sub LoginUser()
        Dim userBFC As ClsUser = New ClsUser
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim userModel As UserModel = New UserModel
        Dim menu As New MenuUtama
        Try
            userModel = userBFC.RetrieveByNamePassword(txtUserName.Text, txtPassword.Text)
            If userModel.UserID <> 0 Then
                userID = userModel.UserID
                userName = userModel.Name
                roleIDUser = userModel.RoleID
                stringIPUser = logBFC.GetIPAddressLog
                MsgBoxInformation("Login Successfully")
                menu.Show()
                Hide()
            Else
                MsgBoxWarning("User Name and password Wrong!!!")
                txtUserName.Focus()
            End If
        Catch ex As Exception
            Dim frm As New FrmConfiguration
            frm.ShowDialog()
        End Try
    End Sub
#End Region

#Region "Button"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginUser()
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
#End Region

#Region "Other"
    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If
    End Sub

    Private Sub btnConfiguration_Click(sender As Object, e As EventArgs) Handles btnConfiguration.Click
        Dim frm As FrmConfiguration = New FrmConfiguration
        frm.ShowDialog()
    End Sub
#End Region


End Class