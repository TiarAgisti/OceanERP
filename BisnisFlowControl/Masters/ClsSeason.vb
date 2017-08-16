Public Class ClsSeason
    Dim querySeason As String = "Select SeasonID,SeasonCode,SeasonName,Description,VendorName,VendorID,IsActive From v_Season" &
                        " Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Season Code"
                querySeason += " AND SeasonCode Like '%" & param & "%' Order By SeasonCode Asc"
            Case "Season Name"
                querySeason += " AND SeasonName Like '%" & param & "%' Order By SeasonCode Asc"
            Case "Customer"
                querySeason += " AND VendorName Like '%" & param & "%' Order By SeasonCode Asc"
            Case Else
                querySeason += " Order By SeasonCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(querySeason)
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
        Dim query As String = "Select max(SeasonID) from Season"
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
        Dim code As String
        Dim hasil As String
        Dim query As String
        Dim dataAccess = New ClsDataAccess

        code = "SNC"
        query = "Select Max(SeasonCode) as Code From Season"


        Try
            hasil = dataAccess.GeneratedCode(query, code)
            dataAccess = Nothing
            Return hasil
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select SeasonID,SeasonName From Season Where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
            dataAccess = Nothing
            Return dataTable
        Catch ex As Exception
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Sub ComboBoxSeason(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBox()
            .DisplayMember = "SeasonName"
            .ValueMember = "SeasonID"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
    Public Function GetValidateName(seasonName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select SeasonName From Season Where SeasonName = '" & seasonName & "'"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Season name can't duplicate")
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertSeason(seasonModel As SeasonModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Season(SeasonID,SeasonCode,SeasonName,Description,VendorID,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate" &
                            ")Values('" & seasonModel.SeasonID & "','" & seasonModel.SeasonCode & "','" & seasonModel.SeasonName & "'" &
                            ",'" & seasonModel.Description & "','" & seasonModel.VendorID & "','" & seasonModel.IsActive & "'" &
                            ",'" & seasonModel.CreatedBy & "','" & seasonModel.CreatedDate & "','" & seasonModel.UpdatedBy & "','" & seasonModel.UpdatedDate & "')"
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
    Public Function UpdateSeason(seasonModel As SeasonModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update Season set SeasonName='" & seasonModel.SeasonName & "',Description='" & seasonModel.Description & "'" &
                    ",VendorID = '" & seasonModel.VendorID & "' Where SeasonID = '" & seasonModel.SeasonID & "'"
            queryList.Add(query)

        Else
            query = "Update Season Set IsActive = '" & seasonModel.IsActive & "',UpdatedBy='" & seasonModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & seasonModel.UpdatedDate & "' Where SeasonID='" & seasonModel.SeasonID & "'"
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
