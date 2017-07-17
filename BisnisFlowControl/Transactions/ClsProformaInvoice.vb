Public Class ClsProformaInvoice
    Public Function RetrieveListProformaInvoice(piNo As String, dateFrom As Date, dateTo As Date, customer As String _
                                                , refPO As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select PIHeaderID,PIDate,PINo,VendorCode,VendorName,BuyerName,RefPO,Style,SeasonName,TermOfPayment" &
                               ",DelTerm,TermOfPrice,VendorID,BuyerID,SeasonID,TermOfPaymentID,TermOfPriceID,Status From v_PIHeader" &
                               " Where Status <> 0"

        If Not String.IsNullOrEmpty(piNo) Then
            query += " AND PINo = '" & piNo & "'"
        End If

        If Not dateFrom = "00:00:00" And Not dateTo = "00:00:00" Then
            query += " AND PIDate >= '" & dateFrom & "' AND PIDate <= '" & dateTo & "'"
        End If

        If Not String.IsNullOrEmpty(customer) Then
            query += " AND VendorName = '" & customer & "'"
        End If

        If Not String.IsNullOrEmpty(refPO) Then
            query += " AND RefPO = '" & refPO & "'"
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

    Public Function RetrieveByID(headerID As Long) As PIHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim piHeaderModel As PIHeaderModel = New PIHeaderModel
        Dim query As String = "Select * From v_PIHeader Where PIHeaderID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                If Not IsDBNull(dataAccess.reader.Item("PIHeaderID")) Then
                    piHeaderModel.PIHeaderID = headerID
                    piHeaderModel.PINo = dataAccess.reader.Item("Name")
                    piHeaderModel.BuyerID = dataAccess.reader.Item("BuyerID")
                    piHeaderModel.BuyerName = dataAccess.reader.Item("BuyerName")
                    piHeaderModel.RefPO = dataAccess.reader.Item("RefPO")
                    piHeaderModel.Style = dataAccess.reader.Item("Style")
                    piHeaderModel.SeasonID = dataAccess.reader.Item("SeasonID")
                    piHeaderModel.SeasonName = dataAccess.reader.Item("SeasonName")
                    piHeaderModel.TermOfPaymentID = dataAccess.reader.Item("TermOfPaymentID")
                    piHeaderModel.TermOfPayment = dataAccess.reader.Item("TermOfPayment")
                    piHeaderModel.DelTerm = dataAccess.reader.Item("DelTerm")
                    piHeaderModel.TermOfPriceID = dataAccess.reader.Item("TermOfPriceID")
                    piHeaderModel.TermOfPrice = dataAccess.reader.Item("TermOfPrice")
                    piHeaderModel.ContractNo = dataAccess.reader.Item("ContractNo")
                    piHeaderModel.DestinationID = dataAccess.reader.Item("DestinationID")
                    piHeaderModel.DestinationName = dataAccess.reader.Item("DestinationName")
                    piHeaderModel.VendorID = dataAccess.reader.Item("VendorID")
                    piHeaderModel.VendorCode = dataAccess.reader.Item("VendorCode")
                    piHeaderModel.VendorName = dataAccess.reader.Item("VendorName")
                    piHeaderModel.Address = dataAccess.reader.Item("Address")
                    piHeaderModel.Telephone = dataAccess.reader.Item("Telephone")
                    piHeaderModel.Fax = dataAccess.reader.Item("Fax")
                    piHeaderModel.ContactPerson = dataAccess.reader.Item("ContactPerson")
                    piHeaderModel.GroupSalesID = dataAccess.reader.Item("GroupSalesID")
                    piHeaderModel.SalesName = dataAccess.reader.Item("SalesName")
                    piHeaderModel.DeliveryPlace = dataAccess.reader.Item("DeliveryPlace")
                End If
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return piHeaderModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailsByHeaderID(headerID As Long) As List(Of PIDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim piHeaderModel As PIHeaderModel = New PIHeaderModel
        Dim query As String = "Select * From v_PIDetail Where PIHeaderID='" & headerID & "'"
        Dim myList As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                Dim piDetailModel As PIDetailModel = New PIDetailModel
                piDetailModel.PIHeaderID = dataAccess.reader.Item("PIHeaderID")
                piDetailModel.PIDetailID = dataAccess.reader.Item("PIDetailID")
                piDetailModel.FabricID = dataAccess.reader.Item("FabricID")
                piDetailModel.FabricName = dataAccess.reader.Item("FabricName")
                piDetailModel.DateDetail = dataAccess.reader.Item("DateDetail")
                piDetailModel.ColorID = dataAccess.reader.Item("ColorID")
                piDetailModel.ColorCode = dataAccess.reader.Item("ColorCode")
                piDetailModel.ColorName = dataAccess.reader.Item("ColorName")
                piDetailModel.PPSample = dataAccess.reader.Item("PPSample")
                piDetailModel.QtyCuttable = dataAccess.reader.Item("QtyCuttable")
                piDetailModel.QtyWeight = dataAccess.reader.Item("QtyWeight")
                piDetailModel.Qty = dataAccess.reader.Item("Qty")
                piDetailModel.UnitID = dataAccess.reader.Item("UnitID")
                piDetailModel.UnitName = dataAccess.reader.Item("UnitName")
                piDetailModel.CurrencyID = dataAccess.reader.Item("CurrencyID")
                piDetailModel.CurrencyCode = dataAccess.reader.Item("CurrencyCode")
                piDetailModel.Currency = dataAccess.reader.Item("Currency")
                piDetailModel.UnitPrice = dataAccess.reader.Item("UnitPrice")
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function GeneratedPINo(customerCode As String) As String
        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(PINo) as PINo from PIHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("PINo")) Then
                myCode = "OA" + "0000001" + "-" + customerCode + "-" + Format(Now.Year)
            Else
                Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("PINo"), 9)
                hitung = Microsoft.VisualBasic.Right(xCode, 7) + 1
                myCode = "OA" & Microsoft.VisualBasic.Right("0000000" & hitung, 7) & "-" & customerCode & "-" & Format(Now.Year)
            End If
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myCode
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
        Return myCode
    End Function

    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(PIHeaderID) from PIHeader"
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
    Public Function InsertData(piHeaderModel As PIHeaderModel, listPIDetailModel As List(Of PIDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        Dim sqlHeader As String = "Insert into PIHeader(PIHeaderID,PIDate,PINo,VendorID,BuyerID,GroupSalesID,RefPO,Style,SeasonID,TermOfPaymentID" &
                                   ",DelTerm,TermOfPriceID,ContractNo,DestinationID,DeliveryPlace,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                   "('" & piHeaderModel.PIHeaderID & "','" & piHeaderModel.PIDate & "','" & piHeaderModel.PINo & "'" &
                                   ",'" & piHeaderModel.VendorID & "','" & piHeaderModel.BuyerID & "','" & piHeaderModel.GroupSalesID & "'" &
                                   ",'" & piHeaderModel.RefPO & "','" & piHeaderModel.Style & "','" & piHeaderModel.SeasonID & "'" &
                                   ",'" & piHeaderModel.TermOfPaymentID & "','" & piHeaderModel.DelTerm & "','" & piHeaderModel.TermOfPriceID & "'" &
                                   ",'" & piHeaderModel.ContractNo & "','" & piHeaderModel.DestinationID & "','" & piHeaderModel.DeliveryPlace & "'" &
                                   ",'" & piHeaderModel.Status & "','" & piHeaderModel.CreatedBy & "','" & piHeaderModel.CreatedDate & "'" &
                                   ",'" & piHeaderModel.UpdatedBy & "','" & piHeaderModel.UpdatedDate & "')"
        queryList.Add(sqlHeader)


        For Each detail In listPIDetailModel
            Dim sqlDetail As String = "Insert into PIDetail(PIHeaderID,FabricID,DateDetail,ColorID,PPSample,QtyCuttable,QtyWeight,Qty" &
                                       ",UnitID,UnitPrice,CurrencyID)Values('" & detail.PIHeaderID & "','" & detail.FabricID & "'" &
                                       ",'" & detail.DateDetail & "','" & detail.ColorID & "','" & detail.PPSample & "','" & detail.QtyCuttable & "'" &
                                       ",'" & detail.QtyWeight & "','" & detail.Qty & "','" & detail.UnitID & "','" & detail.UnitPrice & "'" &
                                       ",'" & detail.CurrencyID & "')"
            queryList.Add(sqlDetail)
        Next

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

    Public Function UpdateData(piHeaderModel As PIHeaderModel, listPIDetailModel As List(Of PIDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        Dim sqlHeader As String = "Update PIHeader Set VendorID = '" & piHeaderModel.VendorID & "',BuyerID = '" & piHeaderModel.BuyerID & "'" &
                                    ",GroupSalesID = '" & piHeaderModel.GroupSalesID & "',RefPO = '" & piHeaderModel.RefPO & "'" &
                                    ",Style = '" & piHeaderModel.PIDate & "',SeasonID = '" & piHeaderModel.SeasonID & "'" &
                                    ",TermOfPaymentID = '" & piHeaderModel.TermOfPaymentID & "',DelTerm = '" & piHeaderModel.DelTerm & "'" &
                                    ",TermOfPriceID = '" & piHeaderModel.TermOfPriceID & "',ContractNo = '" & piHeaderModel.ContractNo & "'" &
                                    ",DestinationID = '" & piHeaderModel.DestinationID & "',DeliveryPlace = '" & piHeaderModel.DeliveryPlace & "'" &
                                    ",Status = '" & piHeaderModel.TermOfPriceID & "',UpdatedBy = '" & piHeaderModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & piHeaderModel.UpdatedDate & "' Where PIHeaderID = '" & piHeaderModel.PIHeaderID & "'"

        queryList.Add(sqlHeader)

        Dim sqlDelete As String = "Delete Form PIDetail Where PIHeaderID = '" & piHeaderModel.PIHeaderID & "'"
        queryList.Add(sqlDelete)

        For Each detail In listPIDetailModel
            Dim sqlDetail As String = "Insert into PIDetail(PIHeaderID,PIDetailID,FabricID,DateDetail,ColorID,PPSample,QtyCuttable,QtyWeight,Qty" &
                                       ",UnitID,UnitPrice,CurrencyID)Values('" & detail.PIHeaderID & "','" & detail.PIDetailID & "','" & detail.FabricID & "'" &
                                       ",'" & detail.DateDetail & "','" & detail.ColorID & "','" & detail.PPSample & "','" & detail.QtyCuttable & "'" &
                                       ",'" & detail.QtyWeight & "','" & detail.Qty & "','" & detail.UnitID & "','" & detail.UnitPrice & "'" &
                                       ",'" & detail.CurrencyID & "')"
            queryList.Add(sqlDetail)
        Next

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
