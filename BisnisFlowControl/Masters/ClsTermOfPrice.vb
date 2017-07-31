Public Class ClsTermOfPrice
#Region "Method Other"
    Protected Function ListComboBox() As DataTable
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

    Public Sub ComboBoxTermPrice(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .DisplayMember = "Name"
                .ValueMember = "TermOfPriceID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
