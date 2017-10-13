Public Class ClsUnit
    Dim queryUnit As String = "Select * From Unit Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Unit Name"
                queryUnit += " AND UnitName LIKE '%" & param & "%' Order By UnitName Asc"
            Case "Description"
                queryUnit += " AND Description LIKE '%" & param & "%' Order By UnitName Asc"
            Case Else
                queryUnit += " Order By UnitName Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryUnit)
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
        Dim query As String = "Select max(UnitID) from Unit"
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

    Public Function GetValidateUnitName(unitName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select UnitName From Unit Where UnitName = '" & unitName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Unit Name can't duplicate entry")
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Protected Function ListComboBox()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select UnitID,UnitName From Unit Where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
            dataAccess = Nothing
            Return dataTable
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Sub ComboBoxUnit(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "UnitID"
                .DisplayMember = "UnitName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Method CRUD"
    Public Function InsertUnit(unitModel As UnitModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Unit(UnitID,UnitName,Description,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & unitModel.UnitID & "','" & unitModel.UnitName & "','" & unitModel.Description & "'" &
                                ",'" & unitModel.IsActive & "','" & unitModel.CreatedBy & "','" & Format(unitModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "'" &
                                ",'" & unitModel.UpdatedBy & "','" & Format(unitModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
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

    Public Function UpdateUnit(unitModel As UnitModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Unit Set UnitName = '" & unitModel.UnitName & "',Description = '" & unitModel.Description & "'" &
                    ",IsActive = '" & unitModel.IsActive & "',UpdatedBy='" & unitModel.UpdatedBy & "',UpdatedDate = '" & Format(unitModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "'" &
                    " Where UnitID='" & unitModel.UnitID & "'"
            queryList.Add(query)

        Else
            query = "Update Unit Set IsActive = '" & unitModel.IsActive & "',UpdatedBy='" & unitModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & Format(unitModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where UnitID='" & unitModel.UnitID & "'"
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
