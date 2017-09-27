Public Class ClsStock
#Region "Method Retrieve"
    Public Function RetrieveRawMaterialStock(rawmatrialID As Integer) As StockModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        'Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim dataTable As DataTable = New DataTable
        Dim stockModel As StockModel = New StockModel

        Dim query As String = "SELECT SUM(QuantityIN) -  SUM(QuantityOUT) as StockAvailable FROM Stock  Where RawMaterialID = '" & rawmatrialID & "' group by RawMaterialID"

        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader

                    If IsDBNull(.Item("StockAvailable")) Then
                        stockModel.QuantityStock = 0
                    Else
                        stockModel.QuantityStock = .Item("StockAvailable")
                    End If
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return stockModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

    End Function
#End Region
End Class
