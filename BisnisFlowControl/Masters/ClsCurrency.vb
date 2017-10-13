Public Class ClsCurrency
    Dim queryCurrency As String = "select * From Currency where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Currency Code"
                queryCurrency += " AND CurrencyCode LIKE '%" & param & "%' order by CurrencyCode asc"
            Case "Name"
                queryCurrency += " AND Name LIKE '%" & param & "%' order by CurrencyCode asc"
            Case Else
                queryCurrency += " order by CurrencyCode asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryCurrency)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable

    End Function

    Public Function RetrieveByID(currencylID As Integer) As CurrencyModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim currencyModel As CurrencyModel = New CurrencyModel
        queryCurrency += " AND CurrencyID = '" & currencylID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryCurrency)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("CurrencyCode")) Then
                        currencyModel.CurrencyID = .Item("CurrencyID")
                        currencyModel.CurrencyCode = .Item("CurrencyCode")
                        currencyModel.CurrencyName = .Item("Name")

                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return currencyModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Public Function ListComboBoxCurrency() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select CurrencyID,CurrencyCode +' - '+ Name as CurrCode From Currency Where IsActive = 1"

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
    Protected Function ListComboBox()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select CurrencyID,CurrencyCode From Currency Where IsActive = 1"
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
    Public Sub ComboBoxCurrency(cmb As ComboBox)

        With cmb
                .DataSource = ListComboBox()
            .ValueMember = "CurrencyID"
            .DisplayMember = "CurrencyCode"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
    End Sub
    Public Function GetValidateCurrencyCode(currCode As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select CurrencyCode From Currency Where CurrencyCode = '" & currCode & "'"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Currency Code can't duplicate entry")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertCurrency(currModel As CurrencyModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Currency(CurrencyID,CurrencyCode,Name,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & currModel.CurrencyID & "','" & currModel.CurrencyCode & "','" & currModel.CurrencyName & "'" &
                                ",'" & currModel.IsActive & "','" & currModel.CreatedBy & "','" & Format(currModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "'" &
                                ",'" & currModel.UpdatedBy & "','" & Format(currModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
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
                    ",UpdatedDate = '" & Format(currModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where CurrencyID='" & currModel.CurrencyID & "'"
            queryList.Add(query)
        Else
            query = "Update Currency Set IsActive = '" & currModel.IsActive & "',UpdatedBy='" & currModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & Format(currModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where CurrencyID='" & currModel.CurrencyID & "'"
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
