Public Class ClsTermOfPrice
#Region "Method Other"
    Public Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select TermOfPriceID,Name From TermOfPrice"
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
#End Region
End Class
