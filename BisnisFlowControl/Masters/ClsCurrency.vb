Public Class ClsCurrency
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Currency Code"
                query = "select * From Currency where CurrencyCode LIKE '%" & param & "%' AND isActive = 1 order by CurrencyCode asc"
            Case "Name"
                query = "select * From Currency where Name LIKE '%" & param & "%' AND isActive = 1 order by CurrencyCode asc"
            Case Else
                query = "select * From Currency where isActive = 1 order by CurrencyCode asc"
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

    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(CurrencyID) from Currency"
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
        Dim code As String = "CUR"
        Dim hasil As String
        Dim query As String = "Select Max(CurrencyCode) as Code From Currency"

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

    Public Function InsertCurrency(currModel As CurrencyModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Currency(CurrencyID,CurrencyCode,Name,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & currModel.CurrencyID & "','" & currModel.CurrencyCode & "','" & currModel.CurrencyName & "'" &
                                ",'" & currModel.IsActive & "','" & currModel.CreatedBy & "','" & currModel.CreatedDate & "'" &
                                ",'" & currModel.UpdatedBy & "','" & currModel.UpdatedDate & "')"
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

    Public Function UpdateCurrency(currModel As CurrencyModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Currency Set Name = '" & currModel.CurrencyName & "',UpdatedBy='" & currModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & currModel.UpdatedDate & "' Where CurrencyID='" & currModel.CurrencyID & "'"
            queryList.Add(query)
        Else
            query = "Update Currency Set IsActive = '" & currModel.IsActive & "',UpdatedBy='" & currModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & currModel.UpdatedDate & "' Where CurrencyID='" & currModel.CurrencyID & "'"
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
