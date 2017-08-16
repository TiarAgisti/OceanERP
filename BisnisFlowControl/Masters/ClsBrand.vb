Public Class ClsBrand
    Dim queryBrand As String = "Select * From Brand Where BrandCode Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Brand Code"
                queryBrand += " AND BrandCode LIKE '%" & param & "%' Order By BrandCode Asc"
            Case "Name"
                queryBrand += " AND Name LIKE '%" & param & "%' Order By BrandCode Asc"
            Case "Description"
                queryBrand += " AND Description LIKE '%" & param & "%' Order By BrandCode Asc"
            Case Else
                queryBrand += " Order By BrandCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryBrand)
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
        Dim query As String = "Select max(BrandID) from Brand"
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
        Dim code As String = "BRD"
        Dim hasil As String
        Dim query As String = "Select max(BrandCode) as Code from Brand"
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

    Public Function GetValidateName(brandName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select Name From Brand Where Name = '" & brandName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Brand Name can't duplicate entry")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertBrand(brandModel As BrandModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Brand(BrandID,BrandCode,Name,Description,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & brandModel.BrandID & "','" & brandModel.BrandCode & "','" & brandModel.Name & "','" & brandModel.Description & "'" &
                                ",'" & brandModel.IsActive & "','" & brandModel.CreatedBy & "','" & brandModel.CreatedDate & "'" &
                                ",'" & brandModel.UpdatedBy & "','" & brandModel.UpdatedDate & "')"
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

    Public Function UpdateBrand(brandModel As BrandModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Brand Set Name = '" & brandModel.Name & "',Description='" & brandModel.Description & "'" &
                    ",IsActive = '" & brandModel.IsActive & "',UpdatedBy='" & brandModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & brandModel.UpdatedDate & "' Where BrandID='" & brandModel.BrandID & "'"
            queryList.Add(query)
        Else
            query = "Update Brand Set IsActive = '" & brandModel.IsActive & "',UpdatedBy='" & brandModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & brandModel.UpdatedDate & "' Where BrandID='" & brandModel.BrandID & "'"
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
