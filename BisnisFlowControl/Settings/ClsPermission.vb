Public Class ClsPermission
#Region "Method Retrieve"
    Public Function RetrieveListPermission() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select RoleID,RoleName,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate From RoleH where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function RetrieveListPermissionByName(myName As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select RoleID,RoleName,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate From RoleH" &
                               " where IsActive = 1 And RoleName Like '%" & myName & "%'"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function RetrieveListMenu() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select * From Menu where MenuID <> 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function RetrieveDetails(roleID As Integer) As List(Of RoleDModel)
        Dim dataAccess As New ClsDataAccess
        Dim listDetail As New List(Of RoleDModel)
        Dim query As String = "Select * From v_RoleD where RoleID = '" & roleID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                Dim roleDModel As RoleDModel = New RoleDModel
                roleDModel.MenuID = dataAccess.reader.Item("MenuID")
                roleDModel.MenuDescription = dataAccess.reader.Item("MenuDescription")
                roleDModel.IsCreate = dataAccess.reader.Item("IsCreate")
                roleDModel.IsUpdate = dataAccess.reader.Item("IsUpdate")
                roleDModel.IsDelete = dataAccess.reader.Item("IsDelete")
                roleDModel.IsApprove = dataAccess.reader.Item("IsApprove")
                roleDModel.IsVoid = dataAccess.reader.Item("IsVoid")
                listDetail.Add(roleDModel)
            End While
            Return listDetail
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailsByRoleIDMenuID(roleID As Integer, menuID As Integer) As RoleDModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim roleModel As RoleDModel = New RoleDModel
        Dim query As String = "Select IsCreate,IsUpdate,IsDelete,IsApprove,IsVoid From RoleD Where RoleID = '" & roleID & "' AND MenuID='" & menuID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With roleModel
                    .IsCreate = dataAccess.reader.Item("IsCreate")
                    .IsUpdate = dataAccess.reader.Item("IsUpdate")
                    .IsDelete = dataAccess.reader.Item("IsDelete")
                    .IsApprove = dataAccess.reader.Item("IsApprove")
                    .IsVoid = dataAccess.reader.Item("IsVoid")
                End With
            End While
            Return roleModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Public Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select RoleID,RoleName From RoleH where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function GeneratedAutoNumber() As Integer
        Dim roleID As Integer = 0
        Dim query As String = "Select max(RoleID) from RoleH"
        Dim dataAccess = New ClsDataAccess
        Try
            roleID = dataAccess.GeneratedAutoNumber(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return roleID
    End Function
    Public Function ValidationValue(parameter As String) As Boolean
        Dim validation As Boolean = False
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select RoleName from RoleH where RoleName='" & parameter & "' And IsActive = 1"
        Try
            If dataAccess.ValidationValue(query) = True Then
                validation = True
            End If
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return validation
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertRole(roleModel As RoleHModel, roleDetailModel As List(Of RoleDModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim queryMaster As String = "Insert into RoleH(RoleID,RoleName,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)values" &
                                            "('" & roleModel.RoleID & "','" & roleModel.RoleName & "','" & roleModel.IsActive & "'" &
                                            ",'" & roleModel.CreatedBy & "','" & roleModel.CreatedDate & "','" & roleModel.UpdatedBy & "'" &
                                            ",'" & roleModel.UpdatedDate & "')"

        queryList.Add(queryMaster)

        For Each list In roleDetailModel
            Dim sql As String = "Insert into RoleD(RoleID,MenuID,IsCreate,IsUpdate,IsDelete,IsApprove,IsVoid)values" &
                                            "('" & list.RoleID & "','" & list.MenuID & "','" & list.IsCreate & "'" &
                                            ",'" & list.IsUpdate & "','" & list.IsDelete & "'" &
                                            ",'" & list.IsApprove & "','" & list.IsVoid & "')"
            queryList.Add(sql)
        Next

        queryList.Add(logBFC.SqlInsertLog(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            Return True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function DeleteRole(roleModel As RoleHModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim queryHeader As String = "Update RoleH set IsActive = '" & roleModel.IsActive & "',UpdatedBy = '" & roleModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & roleModel.UpdatedDate & "' Where RoleID = '" & roleModel.RoleID & "'"
        queryList.Add(queryHeader)

        queryList.Add(logBFC.SqlInsertLog(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            Return True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function UpdateRole(roleModel As RoleHModel, listDetail As List(Of RoleDModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim queryMaster As String = "Update RoleH set UpdatedBy = '" & roleModel.UpdatedBy & "',UpdatedDate='" & roleModel.UpdatedDate & "'" &
                                    " Where RoleID = '" & roleModel.RoleID & "'"

        queryList.Add(queryMaster)

        Dim queryDelete As String = "Delete From RoleD where RoleID= '" & roleModel.RoleID & "'"
        queryList.Add(queryDelete)

        For Each list As RoleDModel In listDetail
            Dim sql As String = "Insert into RoleD(RoleID,MenuID,IsCreate,IsUpdate,IsDelete,IsApprove,IsVoid)values" &
                                            "('" & list.RoleID & "','" & list.MenuID & "','" & list.IsCreate & "'" &
                                            ",'" & list.IsUpdate & "','" & list.IsDelete & "'" &
                                            ",'" & list.IsApprove & "','" & list.IsVoid & "')"
            queryList.Add(sql)
        Next

        queryList.Add(logBFC.SqlInsertLog(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            Return True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

End Class
