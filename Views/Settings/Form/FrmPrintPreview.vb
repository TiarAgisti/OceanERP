Public Class FrmPrintPreview
    Private Sub FrmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rptView.RefreshReport()
        Text = title
    End Sub
End Class