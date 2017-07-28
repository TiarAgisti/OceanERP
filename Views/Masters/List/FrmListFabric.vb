Public Class FrmListFabric
    Sub PropertiesGrid()
        With dgv
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Fabric Code"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Fabric Name"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "Composition"
            .Columns(3).Width = 200
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
    End Sub

    Sub ListData()
        Dim fabricBFC As ClsFabric = New ClsFabric
        dgv.DataSource = fabricBFC.RetrieveList(cmbCari.Text, txtCari.Text)
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
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub FrmListFabric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
End Class