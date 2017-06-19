Public Class ClsBank
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Bank Code"
                query = "select * From Bank where BankCode LIKE '%" & param & "%' AND isActive = 1 order by BankCode asc"
            Case "Bank Name"
                query = "select * From Bank where Name LIKE '%" & param & "%' AND isActive = 1 order by BankCode asc"
            Case "Account Number"
                query = "select * From Bank where Account LIKE '%" & param & "%' AND isActive = 1 order by BankCode asc"
            Case "Account Name"
                query = "select * From Bank where AccountName LIKE '%" & param & "%' AND isActive = 1 order by BankCode asc"
            Case "Swift Code"
                query = "select * From Bank where SwiftCode LIKE '%" & param & "%' AND isActive = 1 order by BankCode asc"
            Case Else
                query = "select * From Bank where isActive = 1 order by BankCode asc"
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
        Dim query As String = "Select max(BankID) from Bank"
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
        Dim code As String = "BNK"
        Dim hasil As String
        Dim query As String = "Select Max(BankCode) as Code From Bank"

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
    Public Function InsertBank(bankModel As BankModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Bank(BankID,BankCode,Name,Account,AccountName,SwiftCode,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & bankModel.BankID & "','" & bankModel.BankCode & "','" & bankModel.Name & "','" & bankModel.Account & "'" &
                                ",'" & bankModel.AccountName & "','" & bankModel.SwiftCode & "','" & bankModel.IsActive & "','" & bankModel.CreatedBy & "'" &
                                ",'" & bankModel.CreatedDate & "','" & bankModel.UpdatedBy & "','" & bankModel.UpdatedDate & "')"
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

    Public Function UpdateBank(bankModel As BankModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Bank Set Name = '" & bankModel.Name & "',Account='" & bankModel.Account & "',AccountName = '" & bankModel.AccountName & "'" &
                    ",SwiftCode='" & bankModel.SwiftCode & "',IsActive = '" & bankModel.IsActive & "',UpdatedBy='" & bankModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & bankModel.UpdatedDate & "' Where BankID='" & bankModel.BankID & "'"
            queryList.Add(query)
        Else
            query = "Update Bank Set IsActive = '" & bankModel.IsActive & "',UpdatedBy='" & bankModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & bankModel.UpdatedDate & "' Where BankID='" & bankModel.BankID & "'"
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
