Public Class ClsTermOfPayment

#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Code"
                query = "Select * From TermOfPayment Where TermOfPaymentCode LIKE '%" & param & "%' AND IsActive = 1 Order By TermOfPaymentCode Asc"
            Case "Name"
                query = "Select * From TermOfPayment Where Name LIKE '%" & param & "%' AND IsActive = 1 Order By TermOfPaymentCode Asc"
            Case "Description"
                query = "Select * From TermOfPayment Where Description LIKE '%" & param & "%' AND IsActive = 1 Order By TermOfPaymentCode Asc"
            Case Else
                query = "Select * From TermOfPayment Where IsActive = 1 Order By TermOfPaymentCode Asc"
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
#End Region

#Region "Method Other"
    Public Function ListComboBoxTerm() As DataTable
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
