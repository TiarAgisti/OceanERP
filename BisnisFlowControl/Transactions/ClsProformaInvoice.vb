Public Class ClsProformaInvoice
#Region "Method Retrieve"
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
                'piDetailModel.FabricName = dataAccess.reader.Item("FabricName")
                'piDetailModel.DateDetail = dataAccess.reader.Item("DateDetail")
                'piDetailModel.ColorID = dataAccess.reader.Item("ColorID")
                'piDetailModel.ColorCode = dataAccess.reader.Item("ColorCode")
                'piDetailModel.ColorName = dataAccess.reader.Item("ColorName")
                'piDetailModel.PPSample = dataAccess.reader.Item("PPSample")
                piDetailModel.QtyCuttable = dataAccess.reader.Item("QtyCuttable")
                piDetailModel.QtyWeight = dataAccess.reader.Item("QtyWeight")
                'piDetailModel.Qty = dataAccess.reader.Item("Qty")
                piDetailModel.UnitID = dataAccess.reader.Item("UnitID")
                'piDetailModel.UnitName = dataAccess.reader.Item("UnitName")
                'piDetailModel.CurrencyID = dataAccess.reader.Item("CurrencyID")
                'piDetailModel.CurrencyCode = dataAccess.reader.Item("CurrencyCode")
                'piDetailModel.Currency = dataAccess.reader.Item("Currency")
                'piDetailModel.UnitPrice = dataAccess.reader.Item("UnitPrice")
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Generated"
    Public Function GeneratedPINo(customerCode As String) As String
        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(PINo) as PINo from PIHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("PINo")) Then
                myCode = "OA" + "0000001" + "/" + customerCode + "/" + Format(Now.Year)
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

    Public Function GeneratedAutoNumber() As Long
        Dim id As Long = 0
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

    Public Function GeneratedAutoNumberFabricDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIDetailID) from PIDetail"
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
    Public Function GeneratedAutoNumberColorDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIColorDetailID) from PIColorDetail"
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
    Public Function GeneratedAutoNumberYarnDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIYarnDetailID) from PIYarnDetail"
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
    Public Function GeneratedAutoNumberBankDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIBankDetailID) from PIBankDetail"
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
    Public Function GeneratedAutoNumberRemarksDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIRemarksID) from PIRemarks"
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
#End Region

#Region "Method CRUD"
    Protected Function SqlInsertHeader(piHeaderModel As PIHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into PIHeader(PIHeaderID,PIDate,PINo,VendorID,BuyerID,GroupSalesID,RefPO,Style,SeasonID,TermOfPaymentID" &
                                   ",DelTerm,TermOfPriceID,ContractNo,DestinationID,DeliveryPlace,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                   "('" & piHeaderModel.PIHeaderID & "','" & piHeaderModel.PIDate & "','" & piHeaderModel.PINo & "'" &
                                   ",'" & piHeaderModel.VendorID & "','" & piHeaderModel.BuyerID & "','" & piHeaderModel.GroupSalesID & "'" &
                                   ",'" & piHeaderModel.RefPO & "','" & piHeaderModel.Style & "','" & piHeaderModel.SeasonID & "'" &
                                   ",'" & piHeaderModel.TermOfPaymentID & "','" & piHeaderModel.DelTerm & "','" & piHeaderModel.TermOfPriceID & "'" &
                                   ",'" & piHeaderModel.ContractNo & "','" & piHeaderModel.DestinationID & "','" & piHeaderModel.DeliveryPlace & "'" &
                                   ",'" & piHeaderModel.Status & "','" & piHeaderModel.CreatedBy & "','" & piHeaderModel.CreatedDate & "'" &
                                   ",'" & piHeaderModel.UpdatedBy & "','" & piHeaderModel.UpdatedDate & "')"
        Return sqlHeader
    End Function

    Protected Function SqlInsertDetailFabric(myModel As PIDetailModel) As String
        Dim sql As String

        sql = "Insert Into PIDetail(PIheaderID,PIDetailID,FabricID,StyleID,RawMaterialID,TypeGreige,WidthMin,WidthMax,UnitID,WeightMin,WeightMax,DNYardage,WeightYard" &
              ",BeforeWash,AfterWash,NetWeight,SrinkageL,SrinkageW,GSM,PriceGreige,PurchSize,StorageSize,PPSample,QtyCuttable,QtyWeight)Values" &
              "('" & myModel.PIHeaderID & "',,'" & myModel.PIDetailID & "',,'" & myModel.FabricID & "','" & myModel.StyleID & "'" &
              ",'" & myModel.RawMaterialID & "','" & myModel.TypeGreige & "','" & myModel.WidthMin & "','" & myModel.WidthMax & "'" &
              ",'" & myModel.UnitID & "','" & myModel.WeightMin & "','" & myModel.WeightMax & "','" & myModel.DNYardage & "'" &
              ",'" & myModel.WeightYard & "','" & myModel.BeforeWash & "','" & myModel.AfterWash & "','" & myModel.NetWeight & "'" &
              ",'" & myModel.SrinkageL & "','" & myModel.SrinkageW & "','" & myModel.GSM & "','" & myModel.PriceGreige & "','" & myModel.PurchSize & "'" &
              ",'" & myModel.StorageSize & "','" & myModel.PPSample & "','" & myModel.QtyCuttable & "','" & myModel.QtyWeight & "')"

        Return sql
    End Function


    Protected Function SqlInsertDetailColorFabric(myModel As PIColorDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into PIColorDetail(PIHeaderID,PIColorDetailID,ColorID,ColorType,ColorLabNumber,QtyOrder,PurchSizeID,Price,QtySample,DelDate,Note)Values" &
                "('" & myModel.PIHeaderID & "','" & myModel.PIColorDetailID & "','" & myModel.ColorID & "', '" & myModel.ColorType & "'" &
                ",'" & myModel.ColorLabNumber & "','" & myModel.QtyOrder & "','" & myModel.PurchSizeID & "','" & myModel.Price & "'" &
                ",'" & myModel.QtySample & "','" & myModel.DelDate & "','" & myModel.Note & "')"
        Return SQL
    End Function

    Protected Function SqlInsertYarnDetail(myModel As PIYarnDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into PIYarnDetail(PIHeaderID,PIYarnDetailID,YarnID,PriceYarn,PercentageUsage,QtyUsage,ColorID,BrandYarnID,Loss)Values" &
               "('" & myModel.PIHeaderID & "','" & myModel.PIYarnDetailID & "','" & myModel.YarnID & "','" & myModel.PriceYarn & "'" &
               ",'" & myModel.PercentageUsage & "','" & myModel.QtyUsage & "','" & myModel.ColorID & "','" & myModel.BrandYarnID & "','" & myModel.Loss & "')"
        Return SQL
    End Function

    Protected Function SqlInsertRemarksDetail(myModel As PIRemarksModel) As String
        Dim SQL As String
        SQL = "Insert Into PIRemarks(PIHeaderID,PIRemarksID,Remarks)Values('" & myModel.PIHeaderID & "'" &
                ",'" & myModel.PIRemarksID & "','" & myModel.Remarks & "')"
        Return SQL
    End Function

    Protected Function SqlInsertBankDetail(myModel As PIBankDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into PIBankDetail(PIHeaderID,PIBankDetailID,BankID)Values('" & myModel.PIHeaderID & "'" &
                ",'" & myModel.PIBankDetailID & "','" & myModel.BankID & "')"
        Return SQL
    End Function

    Protected Function SqlUpdateHeader(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Update PIHeader Set VendorID = '" & myModel.VendorID & "',BuyerID = '" & myModel.BuyerID & "'" &
                                    ",GroupSalesID = '" & myModel.GroupSalesID & "',RefPO = '" & myModel.RefPO & "'" &
                                    ",Style = '" & myModel.PIDate & "',SeasonID = '" & myModel.SeasonID & "'" &
                                    ",TermOfPaymentID = '" & myModel.TermOfPaymentID & "',DelTerm = '" & myModel.DelTerm & "'" &
                                    ",TermOfPriceID = '" & myModel.TermOfPriceID & "',ContractNo = '" & myModel.ContractNo & "'" &
                                    ",DestinationID = '" & myModel.DestinationID & "',DeliveryPlace = '" & myModel.DeliveryPlace & "'" &
                                    ",Status = '" & myModel.TermOfPriceID & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & myModel.UpdatedDate & "' Where PIHeaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailFabric(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From PIDetail Where PIHeaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailColor(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From PIColorDetail Where PIHeaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailYarn(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From PIYarnDetail Where PIHeaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlUpdateDetailBank(myModel As PIBankDetailModel) As String
        Dim SQL As String
        SQL = "Update PIBankDetail Set BankID = '" & myModel.BankID & "' Where PIheaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailRemarks(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From PIRemarks Where PIHeaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function
    Public Function InsertData(piHeaderModel As PIHeaderModel, listPIDetailModel As List(Of PIDetailModel) _
                               , listColorDetailModel As List(Of PIColorDetailModel), listYarnDetailModel As List(Of PIYarnDetailModel) _
                               , listRemarks As List(Of PIRemarksModel), bankDetailModel As PIBankDetailModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'insert header
        queryList.Add(SqlInsertHeader(piHeaderModel))

        'insert fabric detail
        For Each detail In listPIDetailModel
            queryList.Add(SqlInsertDetailFabric(detail))
        Next

        'insert color detail
        For Each myColorDetail In listColorDetailModel
            queryList.Add(SqlInsertDetailColorFabric(myColorDetail))
        Next

        'insert yarn detail
        For Each myYarnDetail In listYarnDetailModel
            queryList.Add(SqlInsertYarnDetail(myYarnDetail))
        Next

        'insert Remarks
        For Each myRemarksDetail In listRemarks
            queryList.Add(SqlInsertRemarksDetail(myRemarksDetail))
        Next

        'insert Bank Detail
        queryList.Add(SqlInsertBankDetail(bankDetailModel))

        'insert log history
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

    Public Function UpdateData(piHeaderModel As PIHeaderModel, listPIDetailModel As List(Of PIDetailModel) _
                               , listColorDetailModel As List(Of PIColorDetailModel), listYarnDetailModel As List(Of PIYarnDetailModel) _
                               , listRemarks As List(Of PIRemarksModel), bankDetailModel As PIBankDetailModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'delete all detail before update
        queryList.Add(SqlDeleteDetailFabric(piHeaderModel)) 'delete fabric
        queryList.Add(SqlDeleteDetailColor(piHeaderModel)) 'delete Color
        queryList.Add(SqlDeleteDetailYarn(piHeaderModel)) 'delete yarn detail
        queryList.Add(SqlDeleteDetailRemarks(piHeaderModel)) 'delete Remarks

        'update piheader
        queryList.Add(SqlUpdateHeader(piHeaderModel))

        'insert fabric
        For Each detail In listPIDetailModel
            queryList.Add(SqlInsertDetailFabric(detail))
        Next

        'insert color detail
        For Each myColorDetail In listColorDetailModel
            queryList.Add(SqlInsertDetailColorFabric(myColorDetail))
        Next

        'insert yarn detail
        For Each myYarnDetail In listYarnDetailModel
            queryList.Add(SqlInsertYarnDetail(myYarnDetail))
        Next

        'insert Remarks
        For Each myRemarksDetail In listRemarks
            queryList.Add(SqlInsertRemarksDetail(myRemarksDetail))
        Next

        'update bank detail
        queryList.Add(SqlUpdateDetailBank(bankDetailModel))

        'insert log history
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
