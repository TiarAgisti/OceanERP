Public Class ClsTermOfPayment
    Dim queryTOP As String = "Select * From TermOfPayment Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Code"
                queryTOP += " AND TermOfPaymentCode LIKE '%" & param & "%' Order By TermOfPaymentCode Asc"
            Case "Name"
                queryTOP += " AND Name LIKE '%" & param & "%' Order By TermOfPaymentCode Asc"
            Case "Description"
                queryTOP += " AND Description LIKE '%" & param & "%' Order By TermOfPaymentCode Asc"
            Case Else
                queryTOP += " Order By TermOfPaymentCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryTOP)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
#End Region

#Region "Method Other"
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select TermOfPaymentID,Name From TermOfPayment Where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxTOP(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .DisplayMember = "Name"
                .ValueMember = "TermOfPaymentID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(TermOfPaymentID) from TermOfPayment"
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
        Dim code As String = "TOP"
        Dim hasil As String
        Dim query As String = "Select max(TermOfPaymentCode) as Code from TermOfPayment"
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

    Public Function GetValidateName(topName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select Name From TermOfPayment Where Name = '" & topName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Name can't duplicate entry")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Insert & Update"
    Public Function InsertTerm(termModel As TermOfPaymentModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into TermOfPayment(TermOfPaymentID,TermOfPaymentCode,Name,Description,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & termModel.TermOfPaymentID & "','" & termModel.TermOfPaymentCode & "','" & termModel.Name & "','" & termModel.Description & "'" &
                                ",'" & termModel.IsActive & "','" & termModel.CreatedBy & "','" & termModel.CreatedDate & "'" &
                                ",'" & termModel.UpdatedBy & "','" & termModel.UpdatedDate & "')"
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

    Public Function UpdateTerm(termModel As TermOfPaymentModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update TermOfPayment Set Name = '" & termModel.Name & "',Description='" & termModel.Description & "'" &
                    ",IsActive = '" & termModel.IsActive & "',UpdatedBy='" & termModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & termModel.UpdatedDate & "' Where TermOfPaymentID='" & termModel.TermOfPaymentID & "'"
            queryList.Add(query)
        Else
            query = "Update TermOfPayment Set IsActive = '" & termModel.IsActive & "',UpdatedBy='" & termModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & termModel.UpdatedDate & "' Where TermOfPaymentID='" & termModel.TermOfPaymentID & "'"
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
