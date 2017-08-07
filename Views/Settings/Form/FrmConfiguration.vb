Public Class FrmConfiguration
    Private Sub LoadConfig()
        If My.Settings.winAuthentication = True Then
            cmbAuthentication.Text = "Windows Authentication"
            txtLogin.Enabled = False
            txtPassword.Enabled = False
        Else
            cmbAuthentication.Text = "SQL Authentication"
            txtLogin.Enabled = True
            txtPassword.Enabled = True
            txtLogin.Text = My.Settings.userId
            txtPassword.Text = My.Settings.userPassword
        End If
        txtServer.Text = My.Settings.server
        txtDatabase.Text = My.Settings.database
        txtReportPath.Text = My.Settings.reportPath
    End Sub
    Private Sub PreCreateDisplay()
        cmbAuthentication.Items.Add("SQL Authentication")
        cmbAuthentication.Items.Add("Windows Authentication")
        Me.Text = title
        LoadConfig()
    End Sub
    Private Sub SaveConfig()
        My.Settings.server = txtServer.Text
        My.Settings.database = txtDatabase.Text
        If cmbAuthentication.Text = "Windows Authentication" Then
            My.Settings.winAuthentication = True
        Else
            My.Settings.winAuthentication = False
            My.Settings.userId = txtLogin.Text
            My.Settings.userPassword = txtPassword.Text
            My.Settings.reportPath = txtReportPath.Text
        End If
        My.Settings.Save()
    End Sub
    Private Function SetLogHistory() As LogHistoryModel
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim desc As String = "Test Connection & Save Configuration"
        Return logBFC.SetLogHistory(desc)
    End Function
    Public Sub New()
        InitializeComponent()
        PreCreateDisplay()
        txtServer.Focus()
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim connection As New ClsConfig
        SaveConfig()
        Try
            If connection.TestConnection() = True Then
                Dim logBFC As ClsLogHistory = New ClsLogHistory
                If logBFC.SaveData(SetLogHistory) = True Then
                    MsgBox("Connection Successfully", MsgBoxStyle.Information, title)
                End If
                connection = Nothing
                logBFC = Nothing
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub cmbAuthentication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuthentication.SelectedIndexChanged
        If cmbAuthentication.Text = "Windows Authentication" Then
            txtLogin.Enabled = False
            txtPassword.Enabled = False
            btnTest.Focus()
        Else
            txtLogin.Enabled = True
            txtPassword.Enabled = True
            txtLogin.Focus()
        End If
    End Sub

    Private Sub cmbAuthentication_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAuthentication.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txtServer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServer.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDatabase.Focus()
        End If
    End Sub

    Private Sub txtDatabase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatabase.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbAuthentication.Focus()
        End If
    End Sub

    Private Sub txtLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLogin.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub
End Class