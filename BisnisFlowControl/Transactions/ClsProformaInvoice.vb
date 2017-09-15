Imports Microsoft.Reporting.WinForms
Public Class ClsProformaInvoice
#Region "Method Retrieve"
    Public Function RetrieveListProformaInvoice(piNo As String, dateFrom As Date, dateTo As Date, customer As String _
                                                , refPO As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select PIHeaderID,PIDate,PINo,CustomerCode,CustomerName,BuyerName,RefPO,StyleName,SeasonName,TermOfPayment" &
                               ",DelTerm,TermOfPrice,CustomerID,BuyerID,StyleID,SeasonID,TermOfPaymentID,TermOfPriceID,StatusDesc From v_PIHeader" &
                               " Where Status <> 0"

        If Not String.IsNullOrEmpty(piNo) Then
            query += " AND PINo = '" & piNo & "'"
        End If

        If Not dateFrom = "00:00:00" And Not dateTo = "00:00:00" Then
            query += " AND PIDate >= '" & dateFrom & "' AND PIDate <= '" & dateTo & "'"
        End If

        If Not String.IsNullOrEmpty(customer) Then
            query += " AND CustomerName = '" & customer & "'"
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
                With dataAccess.reader
                    If Not IsDBNull(.Item("PIHeaderID")) Then
                        piHeaderModel.PIHeaderID = headerID
                        piHeaderModel.PIDate = .Item("PIDate")
                        piHeaderModel.PINo = .Item("PINo")
                        piHeaderModel.BuyerID = .Item("BuyerID")
                        piHeaderModel.BuyerName = .Item("BuyerName")
                        piHeaderModel.RefPO = .Item("RefPO")
                        piHeaderModel.StyleID = .Item("StyleID")
                        piHeaderModel.SeasonID = .Item("SeasonID")
                        piHeaderModel.SeasonName = .Item("SeasonName")
                        piHeaderModel.TermOfPaymentID = .Item("TermOfPaymentID")
                        piHeaderModel.TermOfPayment = .Item("TermOfPayment")
                        piHeaderModel.DelTerm = .Item("DelTerm")
                        piHeaderModel.TermOfPriceID = .Item("TermOfPriceID")
                        piHeaderModel.TermOfPrice = .Item("TermOfPrice")
                        piHeaderModel.ContractNo = .Item("ContractNo")
                        piHeaderModel.DestinationID = .Item("DestinationID")
                        piHeaderModel.DestinationName = .Item("DestinationName")
                        piHeaderModel.CustomerID = .Item("CustomerID")
                        piHeaderModel.CustomerCode = .Item("CustomerCode")
                        piHeaderModel.CustomerName = .Item("CustomerName")
                        piHeaderModel.Address = .Item("Address")
                        piHeaderModel.Telephone = .Item("Telephone")
                        piHeaderModel.Fax = .Item("Fax")
                        piHeaderModel.ContactPerson = .Item("ContactPerson")
                        piHeaderModel.GroupSalesID = .Item("GroupSalesID")
                        piHeaderModel.SalesName = .Item("SalesName")
                        piHeaderModel.DeliveryPlace = .Item("DeliveryPlace")
                        piHeaderModel.StyleName = .Item("StyleName")
                        piHeaderModel.Status = .Item("Status")
                    End If
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return piHeaderModel
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function RetrieveFabricByHeaderID(headerID As Long) As List(Of PIDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIDetail Where PIHeaderID='" & headerID & "'"
        Dim myList As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim piDetailModel As PIDetailModel = New PIDetailModel
                    piDetailModel.PIHeaderID = .Item("PIHeaderID")
                    piDetailModel.PIDetailID = .Item("PIDetailID")
                    piDetailModel.FabricID = .Item("FabricID")
                    piDetailModel.StyleID = .Item("StyleID")
                    piDetailModel.RawMaterialID = .Item("RawMaterialID")
                    piDetailModel.TypeGreige = .Item("TypeGreige")
                    piDetailModel.WidthMin = .Item("WidthMin")
                    piDetailModel.WidthMax = .Item("WidthMax")
                    piDetailModel.UnitID = .Item("UnitID")
                    piDetailModel.WeightMin = .Item("WeightMin")
                    piDetailModel.WeightMax = .Item("WeightMax")
                    piDetailModel.DNYardage = .Item("DNYardage")
                    piDetailModel.WeightYard = .Item("WeightYard")
                    piDetailModel.BeforeWash = .Item("BeforeWash")
                    piDetailModel.AfterWash = .Item("AfterWash")
                    piDetailModel.NetWeight = .Item("NetWeight")
                    piDetailModel.SrinkageL = .Item("SrinkageL")
                    piDetailModel.SrinkageW = .Item("SrinkageW")
                    piDetailModel.GSM = .Item("GSM")
                    piDetailModel.PriceGreige = .Item("PriceGreige")
                    piDetailModel.PurchSize = .Item("PurchSize")
                    piDetailModel.StorageSize = .Item("StorageSize")
                    piDetailModel.PPSample = .Item("PPSample")
                    piDetailModel.QtyCuttable = .Item("QtyCuttable")
                    piDetailModel.QtyWeight = .Item("QtyWeight")
                    piDetailModel.PINo = .Item("PINo")
                    piDetailModel.PIDate = .Item("PIDate")
                    piDetailModel.FabricName = .Item("FabricName")
                    piDetailModel.StyleName = .Item("StyleName")
                    piDetailModel.RawMaterialName = .Item("RawMaterialName")
                    piDetailModel.UnitName = .Item("UnitName")
                    piDetailModel.Specification = .Item("Specification")
                    myList.Add(piDetailModel)
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function RetrieveColorByHeaderID(headerID As Long) As List(Of PIColorDetailModel)
        Dim myList As List(Of PIColorDetailModel) = New List(Of PIColorDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIColorDetail Where PIHeaderID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As PIColorDetailModel = New PIColorDetailModel
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.ColorType = .Item("ColorType")
                    detailModel.ColorLabNumber = .Item("ColorLabNumber")
                    detailModel.QtyOrder = .Item("QtyOrder")
                    detailModel.PurchSizeID = .Item("PurchSizeID")
                    detailModel.Price = .Item("Price")
                    detailModel.QtySample = .Item("QtySample")
                    detailModel.DelDate = .Item("DelDate")
                    detailModel.Note = .Item("Note")
                    detailModel.PIDate = .Item("PIDate")
                    detailModel.PINo = .Item("PINo")
                    detailModel.ColorCode = .Item("ColorCode")
                    detailModel.ColorName = .Item("ColorName")
                    detailModel.PurchSizeName = .Item("PurchSizeName")
                    myList.Add(detailModel)
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RetrieveYarnByHeaderID(headerID As Long) As List(Of PIYarnDetailModel)
        Dim myList As List(Of PIYarnDetailModel) = New List(Of PIYarnDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIYarnDetail Where PIHeaderID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As PIYarnDetailModel = New PIYarnDetailModel
                    detailModel.YarnID = .Item("YarnID")
                    detailModel.PriceYarn = .Item("PriceYarn")
                    detailModel.PercentageUsage = .Item("PercentageUsage")
                    detailModel.QtyUsage = .Item("QtyUsage")
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.BrandYarnID = .Item("BrandYarnID")
                    detailModel.Loss = .Item("Loss")
                    detailModel.YarnName = .Item("YarnName")
                    detailModel.VendorName = .Item("VendorName")
                    detailModel.ColorCode = .Item("ColorCode")
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.ColorName = .Item("ColorName")
                    detailModel.BrandYarnName = .Item("BrandYarnName")
                    myList.Add(detailModel)
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
            Return Nothing
        End Try
    End Function

    Public Function RetrieveBankByHeaderID(headerID As Long) As PIBankDetailModel
        Dim piBankModel As PIBankDetailModel = New PIBankDetailModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PIBankDetail Where PIHeaderID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    piBankModel.BankAccountID = .Item("BankAccountID")
                    piBankModel.BankAccountCode = .Item("BankAccountCode")
                    piBankModel.AccountName = .Item("AccountName")
                    piBankModel.AccountNumber = .Item("AccountNumber")
                    piBankModel.BankName = .Item("BankName")
                    piBankModel.SwiftCode = .Item("SwiftCode")
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return piBankModel
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
            Return Nothing
        End Try
    End Function

    Public Function RetrieveRemarksByHeaderID(headerID As Long) As List(Of PIRemarksModel)
        Dim myList As List(Of PIRemarksModel) = New List(Of PIRemarksModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From PIRemarks Where PIHeaderID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As PIRemarksModel = New PIRemarksModel
                    detailModel.Remarks = .Item("Remarks")
                    myList.Add(detailModel)
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
            Return Nothing
        End Try
    End Function

    Public Function RetrieveAllDetailByHeaderID(headerID As Long) As List(Of PIDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim myListModel As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Dim query As String = "Select * From v_PIAllDetail Where PIHeaderID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim piDetailModel As PIDetailModel = New PIDetailModel
                    piDetailModel.PIHeaderID = .Item("PIHeaderID")
                    piDetailModel.StyleName = .Item("StyleName")
                    piDetailModel.PIDate = .Item("PIDate")
                    piDetailModel.PINo = .Item("PINo")
                    piDetailModel.ColDescription = .Item("ColDescription")
                    piDetailModel.ColorCode = .Item("ColorCode")
                    If IsDBNull(.Item("Weight")) Then piDetailModel.Weight = "" Else piDetailModel.Weight = .Item("Weight")
                    If IsDBNull(.Item("Width")) Then piDetailModel.Width = "" Else piDetailModel.Width = .Item("Width")
                    piDetailModel.QtySample = .Item("QtySample")
                    piDetailModel.PPSample = .Item("PPSample")
                    piDetailModel.QtyOrder = .Item("QtyOrder")
                    piDetailModel.Price = .Item("Price")
                    piDetailModel.Amount = .Item("Amount")
                    piDetailModel.FabricID = .Item("FabricID")
                    piDetailModel.ColorID = .Item("ColorID")
                    piDetailModel.StyleID = .Item("StyleID")
                    myListModel.Add(piDetailModel)
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myListModel
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveCustCodeByPIHeaderID(headerID As Long) As PIHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim piHeaderModel As PIHeaderModel = New PIHeaderModel
        Dim query As String = "Select CustomerCode From v_PIHeader Where PIHeaderID='" & headerID & "'"
        Try
            With dataAccess.reader
                While .Read
                    piHeaderModel.CustomerCode = .Item("CustomerCode")
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return piHeaderModel
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Generated"
    Protected Function GeneratedPINo(customerCode As String) As String
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
                Dim xtahun As String = Microsoft.VisualBasic.Right(dataAccess.reader.Item("PINo"), 4)
                If xtahun <> Format(Now.Year) Then
                    Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("PINo"), 9)
                    hitung = Microsoft.VisualBasic.Right(xCode, 7) + 1
                    myCode = "OA" & Microsoft.VisualBasic.Right("0000000" & hitung, 7) & "/" & customerCode & "/" & Format(Now.Year)
                Else
                    myCode = "OA" + "0000001" + "/" + customerCode + "/" + Format(Now.Year)
                End If
            End If
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myCode
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function GeneratedAutoNumber() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIHeaderID) from PIHeader"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            dataAccess = Nothing
            Return id
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function GeneratedAutoNumberFabricDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIDetailID) from PIDetail"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            dataAccess = Nothing
            Return id
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function GeneratedAutoNumberColorDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIColorDetailID) from PIColorDetail"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            dataAccess = Nothing
            Return id
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function GeneratedAutoNumberYarnDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(PIYarnDetailID) from PIYarnDetail"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            dataAccess = Nothing
            Return id
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function GeneratedAutoNumberBankDetail() As Long
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

    Protected Function GeneratedAutoNumberRemarksDetail() As Long
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

#Region "Function"
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select PIHeaderID,PINo From PIHeader"
        query += " LEFT JOIN(Select PIHeaderID FROM BonOrderHeader) as Bon ON bon.PIHeaderID = pih.PIHeaderID"
        query += " Where pih.Status = 2 AND bon.PIHeaderID is null"

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
    Public Sub ComboBoxPI(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .DisplayMember = "PINo"
                .ValueMember = "PIHeaderID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Get"
    Public Function GetPINo(customerCode As String) As String
        Dim piNo As String
        Try
            piNo = GeneratedPINo(customerCode)
            Return piNo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetPiHeaderID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumber()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetPIDetailFabricID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumberFabricDetail()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetPIDetailColorID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumberColorDetail()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetPIDetailYarnID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumberYarnDetail()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetPIDetailBankID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumberBankDetail()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetPIDetailRemarksID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumberRemarksDetail()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Check Available In List"
    Public Function CheckFabricInList(dgvFabric As DataGridView, fabricID As Integer) As Boolean
        Dim cek As Integer
        Dim status As Boolean = True
        Try
            For cek = 0 To dgvFabric.Rows.Count - 1
                If dgvFabric.Rows(cek).Cells(0).Value = fabricID Then
                    status = False
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return status
    End Function

    Public Function CheckColorInList(dgvColor As DataGridView, colorID As Integer) As Boolean
        Dim row As Integer
        Dim status As Boolean = True
        Try
            For row = 0 To dgvColor.Rows.Count - 1
                If dgvColor.Rows(row).Cells(0).Value = colorID Then
                    status = False
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return status
    End Function

    Public Function CheckYarnInList(dgvYarn As DataGridView, yarnID As Integer) As Boolean
        Dim row As Integer
        Dim status As Boolean = True
        Try
            For row = 0 To dgvYarn.Rows.Count - 1
                If dgvYarn.Rows(row).Cells(0).Value = yarnID Then
                    status = False
                End If
            Next
            Return status
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CheckRemarksInList(dgvRemarks As DataGridView, remarks As String) As Boolean
        Dim row As Integer
        Dim status As Boolean = True
        Try
            For row = 0 To dgvRemarks.Rows.Count - 1
                If dgvRemarks.Rows(row).Cells(0).Value = remarks Then
                    status = False
                End If
            Next
            Return status
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Set Data Detail"
    Public Function SetDetailFabric(piID As Long, dgvFabric As DataGridView) As List(Of PIDetailModel)
        Dim listFabricDetailModel As List(Of PIDetailModel) = New List(Of PIDetailModel)
        Dim piDetailID As Long
        Try
            piDetailID = GetPIDetailFabricID()
            For detail = 0 To dgvFabric.Rows.Count - 2
                Dim detailModel As PIDetailModel = New PIDetailModel
                With dgvFabric
                    detailModel.PIHeaderID = piID
                    detailModel.PIDetailID = piDetailID
                    detailModel.FabricID = .Rows(detail).Cells(0).Value
                    detailModel.StyleID = .Rows(detail).Cells(3).Value
                    detailModel.RawMaterialID = .Rows(detail).Cells(5).Value
                    detailModel.TypeGreige = .Rows(detail).Cells(7).Value
                    detailModel.WidthMin = .Rows(detail).Cells(8).Value
                    detailModel.WidthMax = .Rows(detail).Cells(9).Value
                    detailModel.UnitID = .Rows(detail).Cells(10).Value
                    detailModel.WeightMin = .Rows(detail).Cells(12).Value
                    detailModel.WeightMax = .Rows(detail).Cells(13).Value
                    detailModel.DNYardage = .Rows(detail).Cells(14).Value
                    detailModel.WeightYard = .Rows(detail).Cells(15).Value
                    detailModel.BeforeWash = .Rows(detail).Cells(16).Value
                    detailModel.AfterWash = .Rows(detail).Cells(17).Value
                    detailModel.NetWeight = .Rows(detail).Cells(18).Value
                    detailModel.SrinkageL = .Rows(detail).Cells(19).Value
                    detailModel.SrinkageW = .Rows(detail).Cells(20).Value
                    detailModel.GSM = .Rows(detail).Cells(21).Value
                    detailModel.PriceGreige = .Rows(detail).Cells(22).Value
                    detailModel.PurchSize = .Rows(detail).Cells(23).Value
                    detailModel.StorageSize = .Rows(detail).Cells(24).Value
                    detailModel.PPSample = .Rows(detail).Cells(25).Value
                    detailModel.QtyCuttable = .Rows(detail).Cells(26).Value
                    detailModel.QtyWeight = .Rows(detail).Cells(27).Value
                    listFabricDetailModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            Return listFabricDetailModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SetDetailColor(piID As Long, dgvColor As DataGridView) As List(Of PIColorDetailModel)
        Dim listModel As List(Of PIColorDetailModel) = New List(Of PIColorDetailModel)
        Dim piDetailID As Long
        Try
            piDetailID = GetPIDetailColorID()
            For detail = 0 To dgvColor.Rows.Count - 2
                Dim detailModel As PIColorDetailModel = New PIColorDetailModel
                With dgvColor
                    detailModel.PIHeaderID = piID
                    detailModel.PIColorDetailID = piDetailID
                    detailModel.ColorID = .Rows(detail).Cells(0).Value
                    detailModel.ColorType = .Rows(detail).Cells(3).Value
                    detailModel.ColorLabNumber = .Rows(detail).Cells(4).Value
                    detailModel.QtyOrder = .Rows(detail).Cells(5).Value
                    detailModel.PurchSizeID = .Rows(detail).Cells(6).Value
                    detailModel.Price = .Rows(detail).Cells(8).Value
                    detailModel.QtySample = .Rows(detail).Cells(9).Value
                    detailModel.DelDate = .Rows(detail).Cells(10).Value
                    detailModel.Note = .Rows(detail).Cells(11).Value
                    listModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            Return listModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SetDetailYarn(piID As Long, dgvYarn As DataGridView) As List(Of PIYarnDetailModel)
        Dim listModel As List(Of PIYarnDetailModel) = New List(Of PIYarnDetailModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim piDetailID As Long
        Try
            piDetailID = piBFC.GetPIDetailYarnID
            For detail = 0 To dgvYarn.Rows.Count - 2
                Dim detailModel As PIYarnDetailModel = New PIYarnDetailModel
                With dgvYarn
                    detailModel.PIHeaderID = piID
                    detailModel.PIYarnDetailID = piDetailID
                    detailModel.YarnID = .Rows(detail).Cells(0).Value
                    detailModel.PriceYarn = .Rows(detail).Cells(3).Value
                    detailModel.PercentageUsage = .Rows(detail).Cells(4).Value
                    detailModel.QtyUsage = .Rows(detail).Cells(5).Value
                    detailModel.ColorID = .Rows(detail).Cells(6).Value
                    detailModel.BrandYarnID = .Rows(detail).Cells(8).Value
                    detailModel.Loss = .Rows(detail).Cells(10).Value
                    listModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function

    Public Function SetDetailRemarks(piID As Long, dgvRemarks As DataGridView) As List(Of PIRemarksModel)
        Dim listModel As List(Of PIRemarksModel) = New List(Of PIRemarksModel)
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice
        Dim piDetailID As Long
        Try
            piDetailID = piBFC.GetPIDetailRemarksID
            For detail = 0 To dgvRemarks.Rows.Count - 2
                Dim detailModel As PIRemarksModel = New PIRemarksModel
                With dgvRemarks
                    detailModel.PIHeaderID = piID
                    detailModel.PIRemarksID = piDetailID
                    detailModel.Remarks = .Rows(detail).Cells(0).Value
                    listModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            piBFC = Nothing
            Return listModel
        Catch ex As Exception
            piBFC = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Protected Function SqlInsertHeader(piHeaderModel As PIHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into PIHeader(PIHeaderID,PIDate,PINo,BuyerID,RefPO,StyleID,SeasonID,TermOfPaymentID,DelTerm,TermOfPriceID" &
                                   ",ContractNo,DestinationID,CustomerID,GroupSalesID,DeliveryPlace,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                   "('" & piHeaderModel.PIHeaderID & "','" & piHeaderModel.PIDate & "','" & piHeaderModel.PINo & "'" &
                                   ",'" & piHeaderModel.BuyerID & "','" & piHeaderModel.RefPO & "','" & piHeaderModel.StyleID & "'" &
                                   ",'" & piHeaderModel.SeasonID & "','" & piHeaderModel.TermOfPaymentID & "','" & piHeaderModel.DelTerm & "'" &
                                   ",'" & piHeaderModel.TermOfPriceID & "','" & piHeaderModel.ContractNo & "','" & piHeaderModel.DestinationID & "'" &
                                   ",'" & piHeaderModel.CustomerID & "','" & piHeaderModel.GroupSalesID & "','" & piHeaderModel.DeliveryPlace & "'" &
                                   ",'" & piHeaderModel.Status & "','" & piHeaderModel.CreatedBy & "','" & piHeaderModel.CreatedDate & "'" &
                                   ",'" & piHeaderModel.UpdatedBy & "','" & piHeaderModel.UpdatedDate & "')"
        Return sqlHeader
    End Function

    Protected Function SqlInsertDetailFabric(myModel As PIDetailModel) As String
        Dim sql As String

        sql = "Insert Into PIDetail(PIheaderID,PIDetailID,FabricID,StyleID,RawMaterialID,TypeGreige,WidthMin,WidthMax,UnitID,WeightMin,WeightMax,DNYardage,WeightYard" &
              ",BeforeWash,AfterWash,NetWeight,SrinkageL,SrinkageW,GSM,PriceGreige,PurchSize,StorageSize,PPSample,QtyCuttable,QtyWeight)Values" &
              "('" & myModel.PIHeaderID & "','" & myModel.PIDetailID & "','" & myModel.FabricID & "','" & myModel.StyleID & "'" &
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
                "('" & myModel.PIHeaderID & "','" & myModel.PIColorDetailID & "','" & myModel.ColorID & "','" & myModel.ColorType & "'" &
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
        SQL = "Insert Into PIBankDetail(PIHeaderID,PIBankDetailID,BankAccountID)Values('" & myModel.PIHeaderID & "'" &
                ",'" & myModel.PIBankDetailID & "','" & myModel.BankAccountID & "')"
        Return SQL
    End Function

    Protected Function SqlUpdateHeader(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Update PIHeader Set PIDate = '" & myModel.PIDate & "',BuyerID = '" & myModel.BuyerID & "',RefPO = '" & myModel.RefPO & "'" &
                                    ",StyleID = '" & myModel.StyleID & "',SeasonID = '" & myModel.SeasonID & "'" &
                                    ",TermOfPaymentID = '" & myModel.TermOfPaymentID & "',DelTerm = '" & myModel.DelTerm & "'" &
                                    ",TermOfPriceID = '" & myModel.TermOfPriceID & "',ContractNo = '" & myModel.ContractNo & "'" &
                                    ",DestinationID = '" & myModel.DestinationID & "',CustomerID = '" & myModel.CustomerID & "'" &
                                    ",GroupSalesID='" & myModel.GroupSalesID & "',DeliveryPlace = '" & myModel.DeliveryPlace & "'" &
                                    ",Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & myModel.UpdatedDate & "' Where PIHeaderID = '" & myModel.PIHeaderID & "'"
        Return SQL
    End Function

    Public Function SqlUpdateStatusHeader(myModel As PIHeaderModel) As String
        Dim SQL As String
        SQL = "Update PIHeader Set Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
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
        SQL = "Update PIBankDetail Set BankAccountID = '" & myModel.BankAccountID & "' Where PIheaderID = '" & myModel.PIHeaderID & "'"
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
        queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

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
        queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            Return True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function UpdateStatusHeader(piHeaderModel As PIHeaderModel, logModel As LogHistoryModel) As Boolean
        Dim status As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        Try
            'update header
            queryList.Add(SqlUpdateStatusHeader(piHeaderModel))
            'insert log history
            queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            status = True
        Catch ex As Exception
            dataAccess = Nothing
            status = False
            Throw ex
        End Try
        Return status
    End Function
#End Region

End Class
