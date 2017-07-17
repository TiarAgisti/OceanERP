Public Class FrmListCustomer
    Public Shared condition As String
    Sub PropertiesGrid()
        With dgv
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Customer Code"
            .Columns(1).Width = 100

            .Columns(2).HeaderText = "Name"
            .Columns(2).Width = 150

            .Columns(3).HeaderText = "Address"
            .Columns(3).Width = 150

            .Columns(4).HeaderText = "Shipping Address"
            .Columns(4).Width = 150

            .Columns(5).HeaderText = "Telephone"
            .Columns(5).Width = 150

            .Columns(6).HeaderText = "Fax"
            .Columns(6).Width = 150

            .Columns(7).HeaderText = "Contact Person"
            .Columns(7).Width = 150

            .Columns(8).HeaderText = "Email CP"
            .Columns(8).Width = 150

            .Columns(9).HeaderText = "Npwp"
            .Columns(9).Width = 150

            .Columns(10).Visible = False

            .Columns(11).HeaderText = "Term Of Payment"
            .Columns(11).Width = 150

            .Columns(12).Visible = False
            .Columns(13).Visible = False

            .Columns(14).HeaderText = "Country"
            .Columns(14).Width = 150

            .Columns(15).Visible = False
        End With
    End Sub
    Sub ListData(options As String, param As String)
        Dim status As Char = "C"
        Dim vendorBFC As ClsVendor = New ClsVendor
        dgv.DataSource = vendorBFC.RetrieveList(options, param, status)
        dgv.ReadOnly = True
        PropertiesGrid()
    End Sub
    Private Sub cmbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCari.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCari.SelectedIndexChanged
        txtCari.Focus()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Try
            ListData(cmbCari.Text, txtCari.Text)
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        With dgv
            Dim row As Integer = .CurrentRow.Index
            If condition = "Buyer" Then
                FrmProformaInvoice.buyerID = .Item(0, row).Value
                FrmProformaInvoice.buyerName = .Item(2, row).Value
            Else
                FrmProformaInvoice.customerID = .Item(0, row).Value
                FrmProformaInvoice.customerCode = .Item(1, row).Value
                FrmProformaInvoice.customerName = .Item(2, row).Value
                FrmProformaInvoice.customerAddress = .Item(3, row).Value
                FrmProformaInvoice.customerTlp = .Item(5, row).Value
                FrmProformaInvoice.customerFax = .Item(6, row).Value
                FrmProformaInvoice.customerAtten = .Item(7, row).Value
            End If
        End With
        Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub FrmListVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListData(cmbCari.Text, txtCari.Text)
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
End Class