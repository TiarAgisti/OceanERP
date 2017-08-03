Public Class ClsBankAccount
    Dim queryBankAccount As String = "Select BankAccountID,BankAccountCode,BankName,VendorDesc,CurrencyName,AccountName,AccountNumber,SwiftCode,BankID,VendorID,CurrencyID,IsActive" &
                        " From v_BankAccount Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable

        Select Case options
            Case "BankAccount Code"
                queryBankAccount += " AND BankAccountCode Like '%" & param & "%' Order By BankAccountCode Asc"
            Case "Bank"
                queryBankAccount += " AND BankName Like '%" & param & "%' Order By BankAccountCode Asc"
            Case "Supplier / Customer"
                queryBankAccount += " AND VendorDesc Like '%" & param & "%' Order By BankAccountCode Asc"
            Case "Account Name"
                queryBankAccount = " AND AccountName Like '%" & param & "%' Order By BankAccountCode Asc"
            Case "Account Number"
                queryBankAccount += " AND AccountNumber Like '%" & param & "%' Order By BankAccountCode Asc"
            Case Else
                queryBankAccount += " Order By BankAccountCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryBankAccount)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function

    Public Function RetrieveByID(bankAccountID As Integer) As BankAccountModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim bankAccountModel As BankAccountModel = New BankAccountModel
        queryBankAccount += " AND BankAccountID = '" & bankAccountID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryBankAccount)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("BankAccountCode")) Then
                        bankAccountModel.BankAccountCode = .Item("BankAccountCode")
                        bankAccountModel.BankName = .Item("BankName")
                        bankAccountModel.VendorDesc = .Item("VendorDesc")
                        bankAccountModel.CurrencyName = .Item("CurrencyName")
                        bankAccountModel.AccountName = .Item("AccountName")
                        bankAccountModel.AccountNumber = .Item("AccountNumber")
                        bankAccountModel.SwiftCode = .Item("SwiftCode")
                        bankAccountModel.BankID = .Item("BankID")
                        bankAccountModel.VendorID = .Item("VendorID")
                        bankAccountModel.CurrencyID = .Item("CurrencyID")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return bankAccountModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select BankAccountID,BankAccountCode From BankAccount Where IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxBankAccount(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "BankAccountID"
                .DisplayMember = "BankAccountCode"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
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
#End Region

#Region "Method CRUD"
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
                     ",AccountName='" & bacModel.AccountName & "',AccountNumber='" & bacModel.AccountNumber & "' Where BankAccountID = '" & bacModel.BankAccountID & "'"
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
#End Region
End Class
