Public Class FrmListPermission
#Region "Function"
    Private Sub ListPermission()
        Try
            Dim permissBFC As ClsPermission = New ClsPermission
            dgv.DataSource = permissBFC.RetrieveListPermission
            dgv.ReadOnly = True
            dgv.Columns(0).Visible = False
            dgv.Columns(2).Visible = False
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub ListPermissionByName(myName As String)
        Try
            Dim permissBFC As ClsPermission = New ClsPermission
            dgv.DataSource = permissBFC.RetrieveListPermissionByName(myName)
            dgv.ReadOnly = True
            dgv.Columns(0).Visible = False
            dgv.Columns(2).Visible = False
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub PreCreateDisplay()
        ListPermission()
        Me.Text = title
    End Sub
    Private Function SetRoleHeaderModel() As RoleHModel
        Dim roleHModel As RoleHModel = New RoleHModel
        Dim row As Integer = dgv.CurrentRow.Index
        roleHModel.RoleID = dgv.Item(0, row).Value
        roleHModel.IsActive = False
        roleHModel.UpdatedBy = userID
        roleHModel.UpdatedDate = DateTime.Now
        Return roleHModel
    End Function
    Private Function SetLogModel() As LogHistoryModel
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim row As Integer = dgv.CurrentRow.Index
        Dim desc As String = "Update permission " + dgv.Item(1, row).Value + " to isactive = false"
        Return logBFC.SetLogHistory(desc)
    End Function
    Private Function DeleteRole() As Boolean
        Dim permissionBFC As ClsPermission = New ClsPermission
        If permissionBFC.DeleteRole(SetRoleHeaderModel, SetLogModel) = True Then
            Return True
        Else
            Return False
        End If
        permissionBFC = Nothing
    End Function
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        PreCreateDisplay()
    End Sub
#End Region

#Region "Button"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ListPermission()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New FrmPermission()
        frm.display = "Create"
        frm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New FrmPermission
        Dim row As Integer = dgv.CurrentRow.Index
        frm.roleID = dgv.Item(0, row).Value
        frm.txtName.Text = dgv.Item(1, row).Value
        frm.display = "Update"
        frm.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBoxQuestion() = DialogResult.Yes Then
                If DeleteRole() = True Then
                    MsgBoxDeleted()
                    ListPermission()
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region
#Region "Other"
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ListPermissionByName(txtCari.Text)
    End Sub
#End Region
End Class