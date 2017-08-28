Public Class ClsPO
#Region "Method Retrieve"
    Public Function RetrieveListPurchaseOrder(poNo As String, dateFrom As Date, dateTo As Date, customer As String _
                                                , supplier As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select POHeaderID,PODate,PONo,CustomerCode,CustomerName,SupplierCode,SupplierName,TermOfPayment" &
                               ",CustomerID,SupplierIDTermOfPaymentID,StatusDesc From v_POHeader" &
                               " Where Status <> 0"

        If Not String.IsNullOrEmpty(poNo) Then
            query += " AND PONo = '" & poNo & "'"
        End If

        If Not dateFrom = "00:00:00" And Not dateTo = "00:00:00" Then
            query += " AND PODate >= '" & dateFrom & "' AND PODate <= '" & dateTo & "'"
        End If

        If Not String.IsNullOrEmpty(customer) Then
            query += " AND CustomerName = '" & customer & "'"
        End If

        If Not String.IsNullOrEmpty(supplier) Then
            query += " AND SupplierName = '" & supplier & "'"
        End If

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
    Public Function RetrieveByID(headerID As Long) As POHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim poHeaderModel As POHeaderModel = New POHeaderModel
        Dim query As String = "Select * From v_POHeader Where POHeaderID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader
                    If Not IsDBNull(.Item("PIHeaderID")) Then
                        poHeaderModel.POHeaderID = headerID
                        poHeaderModel.PODate = .Item("PODate")
                        poHeaderModel.PONo = .Item("PONo")
                        poHeaderModel.CustomerID = .Item("CustomerID")

                    End If
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return poHeaderModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region
End Class
