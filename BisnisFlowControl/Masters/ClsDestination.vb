Public Class ClsDestination
    Public Function RetrieveList(options As String, param As String, status As Char) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Country Code"
                query = "Select * From Destination Where DestinationCode LIKE '%" & param & "%' AND IsActive = 1 AND Status = '" & status & "' Order By DestinationCode Asc"
            Case "Name"
                query = "Select * From Destination Where Name LIKE '%" & param & "%' AND IsActive = 1 AND Status = '" & status & "' Order By DestinationCode Asc"
            Case "SeaPort Code"
                query = "Select * From Destination Where DestinationCode LIKE '%" & param & "%' AND IsActive = 1 AND Status = '" & status & "' Order By DestinationCode Asc"
            Case Else
                query = "Select * From Destination Where IsActive = 1 AND Status = '" & status & "' Order By DestinationCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function ListComboBoxDestination(status As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select DestinationID,Name From Destination Where Status='" & status & "' AND IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(DestinationID) from Destination"
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

    Public Function GeneratedCodeCountry() As String
        Dim code As String = "COU"
        Dim hasil As String
        Dim query As String = "Select Max(DestinationCode) as Code From Destination Where Status = 'C'"
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

    Public Function GeneratedCodeSeaPort() As String
        Dim code As String = "SEA"
        Dim hasil As String
        Dim query As String = "Select Max(DestinationCode) as Code From Destination Where Status = 'S'"
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

    Public Function InsertDestination(destModel As DestinationModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Destination(DestinationID,DestinationCode,Name,IsActive,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & destModel.DestinationID & "','" & destModel.DestinationCode & "','" & destModel.Name & "','" & destModel.IsActive & "','" & destModel.Status & "'" &
                                ",'" & destModel.CreatedBy & "','" & destModel.CreatedDate & "','" & destModel.UpdatedBy & "','" & destModel.UpdatedDate & "')"
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

    Public Function UpdateDestination(destModel As DestinationModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update Destination Set Name = '" & destModel.Name & "',IsActive = '" & destModel.IsActive & "',Status='" & destModel.Status & "'" &
                    ",UpdatedBy = '" & destModel.UpdatedBy & "',UpdatedDate = '" & destModel.UpdatedDate & "' Where DestinationID='" & destModel.DestinationID & "'"
            queryList.Add(query)

        Else
            query = "Update Destination Set IsActive = '" & destModel.IsActive & "',UpdatedBy='" & destModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & destModel.UpdatedDate & "' Where DestinationID='" & destModel.DestinationID & "'"
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
End Class
