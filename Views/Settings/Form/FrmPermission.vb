Public Class FrmPermission
#Region "Declaration"
    Dim intBaris As Integer = 0
    Dim intPost As Integer = 0
    Public roleID As Integer = 0
    Public display As String
#End Region

#Region "Function"
    Private Sub ListMenu()
        Dim permissBFC As ClsPermission = New ClsPermission
        cmbMenu.DataSource = permissBFC.RetrieveListMenu
        cmbMenu.DisplayMember = "MenuDescription"
        cmbMenu.ValueMember = "MenuID"
        permissBFC = Nothing
    End Sub
    Private Sub WidthGrid()
        dgv.Columns(1).Width = 250
        dgv.Columns(2).Width = 60
        dgv.Columns(3).Width = 60
        dgv.Columns(4).Width = 60
        dgv.Columns(5).Width = 60
        dgv.Columns(6).Width = 60
    End Sub
    Private Sub PrepareGrid()
        dgv.Columns.Add(0, "Menu ID")
        dgv.Columns.Add(1, "Menu Descriptions")
        dgv.Columns.Add(2, "Create")
        dgv.Columns.Add(3, "Update")
        dgv.Columns.Add(4, "Delete")
        dgv.Columns.Add(5, "Approve")
        dgv.Columns.Add(6, "Void")
        dgv.Columns(0).Visible = False
        WidthGrid()
    End Sub
    Private Function IsCreate() As Boolean
        Dim isCreated As Boolean = False
        If CkCreate.Checked = True Then
            isCreated = True
        End If
        Return isCreated
    End Function
    Private Function IsUpdate() As Boolean
        Dim isUpdated As Boolean = False
        If ckUpdate.Checked = True Then
            isUpdated = True
        End If
        Return isUpdated
    End Function
    Private Function IsDelete() As Boolean
        Dim isDeleted As Boolean = False
        If ckDelete.Checked = True Then
            isDeleted = True
        End If
        Return isDeleted
    End Function
    Private Function IsApprove() As Boolean
        Dim isApproved As Boolean = False
        If ckApprove.Checked = True Then
            isApproved = True
        End If
        Return isApproved
    End Function
    Private Function IsVoid() As Boolean
        Dim isVoided As Boolean = False
        If ckVoid.Checked = True Then
            isVoided = True
        End If
        Return isVoided
    End Function
    Private Sub ClearCheckBox()
        CkCreate.Checked = False
        ckUpdate.Checked = False
        ckDelete.Checked = False
        ckApprove.Checked = False
        ckVoid.Checked = False
    End Sub
    Private Sub PreCreateDisplay()
        dgv.Columns.Clear()
        ListMenu()
        PrepareGrid()
        ClearCheckBox()
        txtName.Enabled = True
        txtName.Clear()
        txtName.Focus()
    End Sub
    Private Sub AddDataToGrid()
        Try
            Dim count As Integer
            For count = 0 To Me.dgv.Rows.Count - 1
                If dgv.Rows(count).Cells(1).Value = cmbMenu.Text Then
                    MsgBox("Menu avalaible in list", MsgBoxStyle.Critical, "Warning")
                    Me.cmbMenu.Focus()
                    Exit Sub
                End If
            Next
            dgv.Rows.Add()
            dgv.Item(0, intBaris).Value = cmbMenu.SelectedValue
            dgv.Item(1, intBaris).Value = cmbMenu.Text
            dgv.Item(2, intBaris).Value = IsCreate()
            dgv.Item(3, intBaris).Value = IsUpdate()
            dgv.Item(4, intBaris).Value = IsDelete()
            dgv.Item(5, intBaris).Value = IsApprove()
            dgv.Item(6, intBaris).Value = IsVoid()
            intBaris = intBaris + 1
            ClearCheckBox()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub DeleteGridData()
        dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex)
        intBaris = intBaris - 1
    End Sub
    Private Function CheckEmpty() As Boolean
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBoxWarning("Name can't empty")
            txtName.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Private Function SetRoleHModel(myRoleID As Integer, myUserID As Integer, myDate As DateTime, myActive As Boolean) As RoleHModel
        Dim myModel As RoleHModel = New RoleHModel
        myModel.RoleID = myRoleID
        myModel.RoleName = txtName.Text
        myModel.IsActive = myActive
        myModel.CreatedBy = myUserID
        myModel.UpdatedBy = myUserID
        myModel.CreatedDate = myDate
        myModel.UpdatedDate = myDate
        Return myModel
    End Function
    Private Function SetRoleDModel() As List(Of RoleDModel)
        Dim myList As New List(Of RoleDModel)
        Dim detail As Integer
        For detail = 0 To Me.dgv.Rows.Count - 2
            Dim myModel As RoleDModel = New RoleDModel
            myModel.RoleID = roleID
            myModel.MenuID = dgv.Rows(detail).Cells(0).Value
            myModel.IsCreate = dgv.Rows(detail).Cells(2).Value
            myModel.IsUpdate = dgv.Rows(detail).Cells(3).Value
            myModel.IsDelete = dgv.Rows(detail).Cells(4).Value
            myModel.IsApprove = dgv.Rows(detail).Cells(5).Value
            myModel.IsVoid = dgv.Rows(detail).Cells(6).Value
            myList.Add(myModel)
        Next
        Return myList
    End Function
    Private Sub InsertRoleData()
        Dim myBFC As ClsPermission = New ClsPermission
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim myUserID As Integer = userID
        Dim myDate As DateTime = DateTime.Now
        Dim myActive As Boolean = True
        Dim desc As String = "Create new permission " + txtName.Text
        Try
            roleID = myBFC.GeneratedAutoNumber()
            If myBFC.InsertRole(SetRoleHModel(roleID, myUserID, myDate, myActive), SetRoleDModel, logBFC.SetLogHistory(desc)) = True Then
                MsgBoxSaved()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub UpdateRoleData()
        Dim myBFC As ClsPermission = New ClsPermission
        Dim logBFC As ClsLogHistory = New ClsLogHistory

        Dim roleModel As RoleHModel = New RoleHModel
        roleModel.RoleID = roleID
        roleModel.UpdatedBy = userID
        roleModel.UpdatedDate = DateTime.Now


        Dim desc As String = "Update permission " + txtName.Text
        Try
            If myBFC.UpdateRole(roleModel, SetRoleDModel, logBFC.SetLogHistory(desc)) = True Then
                MsgBoxUpdated()
                PreCreateDisplay()
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Public Sub RetrieveDetails(myRoleID As Integer)
        Try
            Dim permissionBFC As ClsPermission = New ClsPermission
            Dim listDetails As New List(Of RoleDModel)
            listDetails = permissionBFC.RetrieveDetails(myRoleID)
            For Each list As RoleDModel In listDetails
                dgv.Rows.Add()
                dgv.Item(0, intBaris).Value = list.MenuID
                dgv.Item(1, intBaris).Value = list.MenuDescription
                dgv.Item(2, intBaris).Value = list.IsCreate
                dgv.Item(3, intBaris).Value = list.IsUpdate
                dgv.Item(4, intBaris).Value = list.IsDelete
                dgv.Item(5, intBaris).Value = list.IsApprove
                dgv.Item(6, intBaris).Value = list.IsVoid
                intBaris = intBaris + 1
            Next
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Other"
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Dim permissBFC As ClsPermission = New ClsPermission
                If permissBFC.ValidationValue(txtName.Text) = True Then
                    MsgBoxError("Name is available,please change name")
                Else
                    cmbMenu.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub txtName_Validated(sender As Object, e As EventArgs) Handles txtName.Validated
        Try
            If txtName.Text = "" Then
                txtName.Focus()
            Else
                Dim permissBFC As ClsPermission = New ClsPermission
                If permissBFC.ValidationValue(txtName.Text) Then
                    MsgBoxError("Name is available,please change name")
                Else
                    cmbMenu.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub
    Private Sub FrmPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case display
            Case "Create"
                PreCreateDisplay()
            Case "Update"
                ListMenu()
                txtName.Enabled = False
                cmbMenu.Focus()
                PrepareGrid()
                RetrieveDetails(roleID)
        End Select
        Text = title
    End Sub
#End Region

#Region "Button"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddDataToGrid()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            DeleteGridData()
        Catch ex As Exception
            MsgBoxError(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case display
            Case "Create"
                If CheckEmpty() = False Then
                    InsertRoleData()
                End If
            Case "Update"
                UpdateRoleData()
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Select Case display
            Case "Create"
                PreCreateDisplay()
            Case "Update"
        End Select
    End Sub
#End Region

End Class