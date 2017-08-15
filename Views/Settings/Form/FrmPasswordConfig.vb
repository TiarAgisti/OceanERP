Public Class FrmPasswordConfig
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Text = title
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txtPass.Text) Then
            MsgBoxError("Password can't empty")
        Else
            If txtPass.Text = My.Settings.superPassword Then
                Dim frm As FrmConfiguration = New FrmConfiguration
                frm.ShowDialog()
                Me.Hide()
            Else
                MsgBoxError("Wrong password")
            End If
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSubmit.Focus()
        End If
    End Sub
End Class