Public Class ClsDepartment
    Dim queryDepartment As String = "Select * From Department Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Department Code"
                queryDepartment += " AND DepartmentCode LIKE '%" & param & "%' Order By DepartmentCode Asc"
            Case "Name"
                queryDepartment += " AND Name LIKE '%" & param & "%' Order By DepartmentCode Asc"
            Case Else
                queryDepartment += " Order By DepartmentCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryDepartment)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
#End Region

#Region "Method Other"
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(DepartmentID) from Department"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return id
    End Function

    Public Function GeneratedCode() As String
        Dim code As String = "DPT"
        Dim hasil As String
        Dim query As String = "Select max(DepartmentCode) as Code from Department"
        Dim dataAccess = New ClsDataAccess
        Try
            hasil = dataAccess.GeneratedCode(query, code)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return hasil
    End Function

    Public Function GetValidateName(deptName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select Name From Department Where Name = '" & deptName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Name can't duplicate entry")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertDepart(departModel As DepartmentModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Department(DepartmentID,DepartmentCode,Name,SBU,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & departModel.DepartmentID & "','" & departModel.DepartmentCode & "','" & departModel.Name & "','" & departModel.SBU & "'" &
                                ",'" & departModel.IsActive & "','" & departModel.CreatedBy & "','" & departModel.CreatedDate & "'" &
                                ",'" & departModel.UpdatedBy & "','" & departModel.UpdatedDate & "')"
        queryList.Add(sql)

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

    Public Function UpdateDepartment(departModel As DepartmentModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Department Set Name = '" & departModel.Name & "',SBU = '" & departModel.SBU & "',IsActive = '" & departModel.IsActive & "'" &
                    ",UpdatedBy='" & departModel.UpdatedBy & "',UpdatedDate = '" & departModel.UpdatedDate & "' Where DepartmentID='" & departModel.DepartmentID & "'"
            queryList.Add(query)
        Else
            query = "Update Department Set IsActive = '" & departModel.IsActive & "',UpdatedBy='" & departModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & departModel.UpdatedDate & "' Where DepartmentID='" & departModel.DepartmentID & "'"
            queryList.Add(query)
        End If

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
