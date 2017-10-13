Public Class ClsBrandYarn
    Dim queryBrandYarn As String = "Select * From BrandYarn Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Brand Yarn"
                queryBrandYarn += " AND BrandYarnName Like '%" & param & "%' Order By BrandYarnName Asc"
            Case Else
                queryBrandYarn += " Order By BrandYarnName Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryBrandYarn)
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
        Dim query As String = "Select max(BrandYarnID) from BrandYarn"
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

    Protected Function ListComboBox() As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select BrandYarnID,BrandYarnName From BrandYarn Where IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function

    Public Sub ComboBoxBrandYarn(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBox()
            .DisplayMember = "BrandYarnName"
            .ValueMember = "BrandYarnID"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Public Function GetValidateName(brandYarnName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select BrandYarnName From BrandYarn Where BrandYarnName = '" & brandYarnName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Brand Yarn Name can't duplicate entry")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertData(brandYarnModel As BrandYarnModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into BrandYarn(BrandYarnID,BrandYarnName,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)" &
                                "Values('" & brandYarnModel.BrandYarnID & "','" & brandYarnModel.BrandYarnName & "'" &
                                ",'" & brandYarnModel.IsActive & "','" & brandYarnModel.CreatedBy & "','" & Format(brandYarnModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "'" &
                                ",'" & brandYarnModel.UpdatedBy & "','" & Format(brandYarnModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
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
    Public Function UpdateData(brandYarnModel As BrandYarnModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update BrandYarn Set BrandYarnName = '" & brandYarnModel.BrandYarnName & "',IsActive = '" & brandYarnModel.IsActive & "'" &
                    ",UpdatedBy='" & brandYarnModel.UpdatedBy & "',UpdatedDate = '" & Format(brandYarnModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "'" &
                    " Where BrandYarnID='" & brandYarnModel.BrandYarnID & "'"
            queryList.Add(query)

        Else
            query = "Update BrandYarn Set IsActive = '" & brandYarnModel.IsActive & "',UpdatedBy='" & brandYarnModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & Format(brandYarnModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where BrandYarnID='" & brandYarnModel.BrandYarnID & "'"
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
