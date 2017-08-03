Public Class ClsBank
    Dim queryBank As String = "select * From Bank where isActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Bank Code"
                queryBank += " AND BankCode LIKE '%" & param & "%' order by BankCode asc"
            Case "Bank Name"
                queryBank += " AND Name LIKE '%" & param & "%' order by BankCode asc"
            Case "Swift Code"
                queryBank += " AND SwiftCode LIKE '%" & param & "%' order by BankCode asc"
            Case Else
                queryBank += " order by BankCode asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryBank)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function

    Public Function RetrieveByID(bankID As Integer) As BankModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim bankModel As BankModel = New BankModel
        queryBank += " AND BankID = '" & bankID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryBank)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("BankCode")) Then
                        bankModel.BankCode = .Item("BankCode")
                        bankModel.Name = .Item("Name")
                        bankModel.SwiftCode = .Item("SwiftCode")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return bankModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Public Function ListComboBoxBank() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select BankID,Name From Bank Where IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
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
    Protected Function ListComboBox()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select BankID,BankCode From Bank Where IsActive = 1"
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
    Public Sub ComboBoxBank(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "BankID"
                .DisplayMember = "BankCode"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GetValidateName(bankName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select Name From Bank Where Name = '" & bankName & "'"
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
    Public Function InsertBank(bankModel As BankModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Bank(BankID,BankCode,Name,SwiftCode,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & bankModel.BankID & "','" & bankModel.BankCode & "','" & bankModel.Name & "','" & bankModel.SwiftCode & "'" &
                                ",'" & bankModel.IsActive & "','" & bankModel.CreatedBy & "','" & bankModel.CreatedDate & "','" & bankModel.UpdatedBy & "'" &
                                ",'" & bankModel.UpdatedDate & "')"
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
            query = "Update Bank Set Name = '" & bankModel.Name & "',SwiftCode='" & bankModel.SwiftCode & "'" &
                    ",IsActive = '" & bankModel.IsActive & "',UpdatedBy='" & bankModel.UpdatedBy & "'" &
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
#End Region

End Class
