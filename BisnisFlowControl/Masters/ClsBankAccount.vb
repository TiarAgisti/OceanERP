Public Class ClsBankAccount
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "BankAccount Code"
                query = "Select * From v_BankAccount Where BankAccountCode Like '%" & param & "%' AND IsActive = 1 Order By BankAccountCode Asc"
            Case "Bank"
                query = "Select * From v_BankAccount Where BankName Like '%" & param & "%' AND IsActive = 1 Order By BankAccountCode Asc"
            Case "Supplier / Customer"
                query = "Select * From v_BankAccount Where VendorDesc Like '%" & param & "%' AND IsActive = 1 Order By BankAccountCode Asc"
            Case "Account Name"
                query = "Select * From v_BankAccount Where AccountName Like '%" & param & "%' AND IsActive = 1 Order By BankAccountCode Asc"
            Case "Account Number"
                query = query = "Select * From v_BankAccount Where AccountNumber Like '%" & param & "%' AND IsActive = 1 Order By BankAccountCode Asc"
            Case Else
                query = query = "Select * From v_BankAccount Where IsActive = 1 Order By BankAccountCode Asc"
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
        Dim query As String = "Select max(BankAccountID) from BankAccount"
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

        code = "BAC"
        query = "Select Max(BankAccountCode) as Code From BankAccount"


        Try
            hasil = dataAccess.GeneratedCode(query, code)
            dataAccess = Nothing
            Return hasil
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function InsertBankAccount(bacModel As BankAccountModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into BankAccount(BankAccountID,BankAccountCode,BankID,VendorID,CurrencyID,AccountName,AccountNumber,IsActive,CreatedBy" &
                            ",CreatedDate,UpdatedBy,UpdatedDate)Values('" & bacModel.BankAccountID & "','" & bacModel.BankAccountCode & "'" &
                            ",'" & bacModel.BankID & "','" & bacModel.VendorID & "','" & bacModel.CurrencyID & "','" & bacModel.AccountName & "'" &
                            ",'" & bacModel.AccountNumber & "','" & bacModel.IsActive & "','" & bacModel.CreatedBy & "','" & bacModel.CreatedDate & "'" &
                            ",'" & bacModel.UpdatedBy & "','" & bacModel.UpdatedDate & "')"
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
    Public Function UpdateBankAccount(bacModel As BankAccountModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update BankAccount set BankID='" & bacModel.BankID & "',VendorID = '" & bacModel.VendorID & "',CurrencyID = '" & bacModel.CurrencyID & "'" &
                     ",AccountName='" & bacModel.BankID & "',AccountNumber='" & bacModel.AccountNumber & "' Where BankAccountID = '" & bacModel.BankAccountID & "'"
            queryList.Add(query)

        Else
            query = "Update BankAccount Set IsActive = '" & bacModel.IsActive & "',UpdatedBy='" & bacModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & bacModel.UpdatedDate & "' Where BankAccountID='" & bacModel.BankAccountID & "'"
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
