Public Class FrmListUser
    Public Shared status As String
#Region "Function"
    Sub CheckPermissions()
        Dim roleBFC As ClsPermission = New ClsPermission
        Dim roleModel As RoleDModel = New RoleDModel
        roleModel = roleBFC.RetrieveDetailsByRoleIDMenuID(roleIDUser, Tag)
        If roleModel.IsCreate = True Then btnAdd.Enabled = True
        If roleModel.IsUpdate = True Then btnEdit.Enabled = True
        If roleModel.IsDelete = True Then btnDelete.Enabled = True
    End Sub
    Private Sub PropertiesGrid()
        dgv.Columns(0).Visible = False
        dgv.Columns(1).HeaderText = "User Name"
        dgv.Columns(1).Width = 250

        dgv.Columns(2).HeaderText = "Password"
        dgv.Columns(2).Visible = False

        dgv.Columns(3).Visible = False
        dgv.Columns(4).Visible = False
        dgv.Columns(5).Visible = False
        dgv.Columns(6).Visible = False
        dgv.Columns(7).Visible = False
        dgv.Columns(8).Visible = False
        dgv.Columns(9).HeaderText = "Permission"
        dgv.Columns(9).Width = 200
    End Sub
    Private Sub ListUsers(myOption As String, myParam As String)
        Try
            Dim usersBFC As ClsUser = New ClsUser
            dgv.DataSource = usersBFC.RetrieveListUser(myOption, myParam)
            dgv.ReadOnly = True
            PropertiesGrid()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub PreCreateDisplay()
        CheckPermissions()
        ListUsers(cmbCari.Text, txtCari.Text)
        cmbCari.Text = ""
        status = ""
        txtCari.Clear()
        cmbCari.Focus()
        Text = title
    End Sub
    Function SetUserModel() As UserModel
        Dim userModel As UserModel = New UserModel
        Dim row As Integer = dgv.CurrentRow.Index
        userModel.UserID = dgv.Item(0, row).Value
        userModel.IsActive = False
        userModel.UpdatedBy = userID
        userModel.UpdatedDate = DateTime.Now
        Return userModel
    End Function
    Private Function SetLogModel() As LogHistoryModel
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim row As Integer = dgv.CurrentRow.Index
        Dim desc As String = "Update User " + dgv.Item(1, row).Value + " to isactive = false"
        Return logBFC.SetLogHistory(desc)
    End Function
    Function DeleteUser() As Boolean
        Dim userBFC As ClsUser = New ClsUser
        If userBFC.DeleteUser(SetUserModel, SetLogModel) = True Then
            Return True
        Else
            Return False
        End If
        userBFC = Nothing
    End Function
#End Region

#Region "Button"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        PreCreateDisplay()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New FrmUser
        frm.display = "Create"
        frm.ShowDialog()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBoxQuestion() = DialogResult.Yes Then
                If DeleteUser() = True Then
                    MsgBoxDeleted()
                    PreCreateDisplay()
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New FrmUser
        Dim row As Integer = dgv.CurrentRow.Index
        frm.myID = dgv.Item(0, row).Value
        frm.display = "Update"
        frm.ShowDialog()
    End Sub
#End Region

#Region "Others"
    Private Sub FrmListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreCreateDisplay()
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCari.SelectedIndexChanged
        txtCari.Focus()
    End Sub

    Private Sub cmbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCari.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ListUsers(cmbCari.Text, txtCari.Text)
    End Sub

    Private Sub FrmListUser_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If status = "Update" Then
            PreCreateDisplay()
        End If
    End Sub
#End Region


End Class