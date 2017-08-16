Public Class ClsUser
    Dim queryUser As String = "select * From v_Users where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveListUser(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "User Name"
                queryUser += " AND Name LIKE '%" & param & "%' order by Name asc"
            Case "Permission"
                queryUser += " AND RoleName LIKE '%" & param & "%' order by Name asc"
            Case Else
                queryUser += " order by Name asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryUser)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable

    End Function

    Public Function RetrieveByID(myID As Integer) As UserModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim userModel As UserModel = New UserModel
        queryUser += " AND UserID='" & myID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryUser)
            While dataAccess.reader.Read
                If Not IsDBNull(dataAccess.reader.Item("UserID")) Then
                    userModel.UserID = myID
                    userModel.Name = dataAccess.reader.Item("Name")
                    userModel.userpassword = dataAccess.reader.Item("userpassword")
                    userModel.RoleID = dataAccess.reader.Item("RoleID")
                End If
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return userModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveByNamePassword(userName As String, pass As String) As UserModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim userModel As UserModel = New UserModel
        Dim query As String = "Select UserID,Name,userpassword,RoleID From Users Where Name='" & userName & "'" &
                            " And userpassword='" & EncryptionPassword(pass, valueKey) & "' AND IsActive = 1"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                If dataAccess.reader.HasRows Then
                    userModel.UserID = dataAccess.reader.Item("UserID")
                    userModel.Name = dataAccess.reader.Item("Name")
                    userModel.userpassword = dataAccess.reader.Item("userpassword")
                    userModel.RoleID = dataAccess.reader.Item("RoleID")
                End If
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return userModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        Return userModel
    End Function
    Public Function RetrievePasswordByUserIDPassword(myUserID As Integer, password As String) As UserModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim userModel As UserModel = New UserModel
        Dim query As String = "Select userpassword From Users Where UserID='" & userID & "'" &
                                " And userpassword = '" & EncryptionPassword(password, valueKey) & "' AND IsActive = 1"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                If dataAccess.reader.HasRows Then
                    userModel.userpassword = dataAccess.reader.Item("userpassword")
                End If
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return userModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        Return userModel
    End Function
#End Region
#Region "Method Other"
    Public Function CheckUserName(myUserName As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select COUNT(Name) as Name From Users Where Name = '" & myUserName & "' AND IsActive = 1"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If dataAccess.reader.Item("Name") = 0 Then
                Return True
            Else
                Return False
            End If
            dataAccess.reader.Close()
            dataAccess = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EncryptionPassword(myPassword As String, key As String) As String
        Try
            Dim dataAccess As ClsDataAccess = New ClsDataAccess
            Dim str As String
            str = dataAccess.Encrypted(myPassword, key)
            dataAccess = Nothing
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DecryptionPassword(myPassword As String, key As String) As String
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim str As String
        Try
            str = dataAccess.Decrypted(myPassword, key)
            dataAccess = Nothing
            Return str
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(UserID) from Users"
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
#End Region

#Region "Method CRUD"
    Public Function InsertUser(userModel As UserModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sqlUser As String = "Insert into Users(UserID,Name,userpassword,RoleID,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                "('" & userModel.UserID & "','" & userModel.Name & "','" & userModel.userpassword & "','" & userModel.RoleID & "'" &
                                ",'" & userModel.IsActive & "','" & userModel.CreatedBy & "','" & userModel.CreatedDate & "','" & userModel.UpdatedBy & "'" &
                                ",'" & userModel.UpdatedDate & "')"
        queryList.Add(sqlUser)

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
    Public Function DeleteUser(userModel As UserModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim sqlUser As String = "Update Users Set IsActive = '" & userModel.IsActive & "',UpdatedBy='" & userModel.UpdatedBy & "'" &
                                ",UpdatedDate = '" & userModel.UpdatedDate & "' Where UserID='" & userModel.UserID & "'"
        queryList.Add(sqlUser)

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
    Public Function UpdateUser(userModel As UserModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim sqlUser As String = "Update Users Set userpassword='" & userModel.userpassword & "',RoleID='" & userModel.RoleID & "',IsActive = '" & userModel.IsActive & "'" &
                                ",UpdatedBy='" & userModel.UpdatedBy & "',UpdatedDate = '" & userModel.UpdatedDate & "' Where UserID='" & userModel.UserID & "'"
        queryList.Add(sqlUser)

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
    Public Function UpdatePassword(userModel As UserModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim sqlUser As String = "Update Users Set userpassword='" & userModel.userpassword & "',UpdatedBy='" & userModel.UpdatedBy & "'" &
                                ",UpdatedDate = '" & userModel.UpdatedDate & "' Where UserID='" & userModel.UserID & "'"
        queryList.Add(sqlUser)

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
