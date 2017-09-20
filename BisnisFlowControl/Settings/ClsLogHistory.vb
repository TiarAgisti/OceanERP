Public Class ClsLogHistory
#Region "Function"
    Public Function GetIPAddressLog() As String
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Return dataAccess.GetIPAddress()
    End Function
    Public Function GetHostNameLog() As String
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Return dataAccess.GetHostName()
    End Function
    Public Function GeneratedAutoNumber() As Long
        Dim logID As Long = 0
        Dim query As String = "Select max(LogID) from LogHistory"
        Dim dataAccess = New ClsDataAccess
        Try
            logID = dataAccess.GeneratedAutoNumber(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return logID
    End Function
    Public Function GeneratedAutoNumberTrans() As Long
        Dim logID As Long = 0
        Dim query As String = "Select max(LogID) from LogHistoryTransaction"
        Dim dataAccess = New ClsDataAccess
        Try
            logID = dataAccess.GeneratedAutoNumber(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return logID
    End Function
    Public Function SetLogHistory(description As String) As LogHistoryModel
        Dim logModel As LogHistoryModel = New LogHistoryModel
        logModel.LogID = GeneratedAutoNumber()
        logModel.Description = description
        logModel.UserID = userID
        logModel.CompName = GetHostNameLog()
        logModel.CreatedDate = Today.Date

        Return logModel
    End Function
    Public Function SetLogHistoryTrans(desc As String) As LogHistoryModel
        Dim logModel As LogHistoryModel = New LogHistoryModel
        logModel.LogID = GeneratedAutoNumberTrans()
        logModel.Description = desc
        logModel.UserID = userID
        logModel.CompName = GetHostNameLog()
        logModel.CreatedDate = DateTime.Now
        Return logModel
    End Function
    Public Function SaveData(logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            Dim query As String = "Insert into LogHistory(LogID,Description,UserID,CompName,CreatedDate)values" &
                            "('" & logModel.LogID & "','" & logModel.Description & "','" & logModel.UserID & "'" &
                           ",'" & logModel.CompName & "','" & logModel.CreatedDate & "')"
            dataAccess.CreateCommand(query)
            dataAccess = Nothing
            Return True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function SqlInsertLog(logModel As LogHistoryModel) As String
        Dim queryLog As String = "Insert into LogHistory(LogID,Description,UserID,CompName,CreatedDate)values('" & logModel.LogID & "','" & logModel.Description & "'" &
                               ",'" & logModel.UserID & "','" & logModel.CompName & "','" & logModel.CreatedDate & "')"
        Return queryLog
    End Function

    Public Function SqlInsertLogHistoryTransaction(logModel As LogHistoryModel) As String
        Dim queryLog As String = "Insert into LogHistoryTransaction(LogID,Description,UserID,CompName,CreatedDate)values('" & logModel.LogID & "','" & logModel.Description & "'" &
                               ",'" & logModel.UserID & "','" & logModel.CompName & "','" & logModel.CreatedDate & "')"
        Return queryLog
    End Function
#End Region
End Class
