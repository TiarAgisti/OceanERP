Public Class FrmPrintPreview
    Private Sub FrmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rptView.RefreshReport()
    End Sub
End Class