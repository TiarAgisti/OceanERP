Public Class ClsGroupSales
    Dim querySales As String = "Select * From GroupSales Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Code"
                querySales += " AND GroupSalesCode LIKE '%" & param & "%' Order By GroupSalesCode Asc"
            Case "Name"
                querySales += " AND GroupSalesName LIKE '%" & param & "%' Order By GroupSalesCode Asc"
            Case Else
                querySales += " Order By GroupSalesCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(querySales)
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
        Dim query As String = "Select max(GroupSalesID) from GroupSales"
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
        Dim code As String = "GRP"
        Dim hasil As String
        Dim query As String = "Select max(GroupSalesCode) as Code from GroupSales"
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
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select GroupSalesID,Name From GroupSales where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
            dataAccess = Nothing
            Return dataTable
        Catch ex As Exception
            Return Nothing
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Sub ComboBoxSales(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBox()
            .ValueMember = "GroupSalesID"
            .DisplayMember = "Name"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
    Public Function GetValidateName(salesName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select Name From GroupSales Where Name = '" & salesName & "''"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertGroupSales(grpSalesModel As GroupSalesModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into GroupSales(GroupSalesID,GroupSalesCode,Name,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & grpSalesModel.GroupSalesID & "','" & grpSalesModel.GroupSalesCode & "','" & grpSalesModel.Name & "'" &
                                ",'" & grpSalesModel.IsActive & "','" & grpSalesModel.CreatedBy & "','" & grpSalesModel.CreatedDate & "'" &
                                ",'" & grpSalesModel.UpdatedBy & "','" & grpSalesModel.UpdatedDate & "')"
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
    Public Function UpdateGroupSales(grpSalesModel As GroupSalesModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update GroupSales Set Name = '" & grpSalesModel.Name & "',IsActive = '" & grpSalesModel.IsActive & "'" &
                    ",UpdatedBy='" & grpSalesModel.UpdatedBy & "',UpdatedDate = '" & grpSalesModel.UpdatedDate & "' Where GroupSalesID='" & grpSalesModel.GroupSalesID & "'"
            queryList.Add(query)

        Else
            query = "Update GroupSales Set IsActive = '" & grpSalesModel.IsActive & "',UpdatedBy='" & grpSalesModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & grpSalesModel.UpdatedDate & "' Where GroupSalesID='" & grpSalesModel.GroupSalesID & "'"
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
