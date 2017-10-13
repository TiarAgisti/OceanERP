Public Class ClsCategoryFabric
    Dim query As String = "Select * From CategoryFabric where  IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Category Fabric"
                query += " AND CategoryName Like '%" & param & "%' Order By CategoryID Asc"

            Case Else
                query += " Order By CategoryID Asc"
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
    Public Function RetrieveByID(CategoryID As Integer) As CategoryFabricModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim categoryModel As CategoryFabricModel = New CategoryFabricModel
        query += " AND CategoryID = '" & CategoryID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("CategoryID")) Then
                        categoryModel.CategoryName = .Item("CategoryName")

                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return categoryModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(CategoryID) from CategoryFabric"
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
    Public Function GetValidateName(categoryName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select CategoryName From CategoryFabric Where CategoryName = '" & categoryName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Category name can't duplicate")
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
        query = "Select CategoryID,CategoryName From CategoryFabric  Where IsActive = 1"
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

    Public Sub ComboBoxCategory(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "CategoryID"
                .DisplayMember = "CategoryName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Method CRUD"
    Public Function InsertCategory(categoryModel As CategoryFabricModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into CategoryFabric(CategoryID,CategoryName,IsActive,CreatedBy,CreatedDate" &
                            ",UpdatedBy,UpdatedDate)Values('" & categoryModel.CategoryID & "','" & categoryModel.CategoryName & "'" &
                            ",'" & categoryModel.IsActive & "','" & categoryModel.CreatedBy & "','" & Format(categoryModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "','" & categoryModel.UpdatedBy & "','" & Format(categoryModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
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

    Public Function UpdateCategory(categoryModel As CategoryFabricModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update CategoryFabric set CategoryName='" & categoryModel.CategoryName & "'" &
                        " Where CategoryID = '" & categoryModel.CategoryID & "'"
            queryList.Add(query)

        Else
            query = "Update CategoryFabric Set IsActive = '" & categoryModel.IsActive & "',UpdatedBy='" & categoryModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & Format(categoryModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where CategoryID='" & categoryModel.CategoryID & "'"
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
