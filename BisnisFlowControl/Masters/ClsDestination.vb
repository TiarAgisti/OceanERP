Public Class ClsDestination
    Dim queryDest As String = "Select * From Destination Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String, status As Char) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Country Code"
                queryDest += " AND DestinationCode LIKE '%" & param & "%' AND Status = '" & status & "' Order By DestinationCode Asc"
            Case "Name"
                queryDest += " AND Name LIKE '%" & param & "%' AND Status = '" & status & "' Order By DestinationCode Asc"
            Case "SeaPort Code"
                queryDest += " AND DestinationCode LIKE '%" & param & "%' AND Status = '" & status & "' Order By DestinationCode Asc"
            Case Else
                queryDest += " AND Status = '" & status & "' Order By DestinationCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryDest)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
#End Region

#Region "Method Other"
    Protected Function ListComboBox(status As String) As DataTable
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
    Public Sub ComboBoxDestination(cmb As ComboBox, status As String)
        With cmb
            .DataSource = ListComboBox(status)
            .DisplayMember = "Name"
            .ValueMember = "DestinationID"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
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

    Public Function GetValidateName(destiName As String, status As Char) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select Name From Destination Where Name = '" & destiName & "' AND Status = '" & status & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Name can't duplicate")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertDestination(destModel As DestinationModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Destination(DestinationID,DestinationCode,Name,IsActive,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & destModel.DestinationID & "','" & destModel.DestinationCode & "','" & destModel.Name & "','" & destModel.IsActive & "','" & destModel.Status & "'" &
                                ",'" & destModel.CreatedBy & "','" & Format(destModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "','" & destModel.UpdatedBy & "','" & Format(destModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
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
                    ",UpdatedBy = '" & destModel.UpdatedBy & "',UpdatedDate = '" & Format(destModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where DestinationID='" & destModel.DestinationID & "'"
            queryList.Add(query)

        Else
            query = "Update Destination Set IsActive = '" & destModel.IsActive & "',UpdatedBy='" & destModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & Format(destModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where DestinationID='" & destModel.DestinationID & "'"
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
