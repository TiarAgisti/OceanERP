Imports Microsoft.Reporting.WinForms
Public Class ClsPI

#Region "Method Retrieve"
    Public Function RetrieveListProformaInvoice(piNo As String, dateFrom As Date, dateTo As Date, customer As String _
                                                , reffPO As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select BOID,NoOrder,ContractNo,DatePI,DelTerm,ReffPO,CustomerCode,CustomerName,Brand,Style,SeasonName,TermOfPayment" &
                               ",TermOfPrice,SeasonID,TermOfPaymentID,TermOfPriceID,StatusDesc From v_ProInvoiceHeader" &
                               " Where Status <> 0"

        If Not String.IsNullOrEmpty(piNo) Then
            query += " AND NoOrder = '" & piNo & "'"
        End If

        If Not dateFrom = "00:00:00" And Not dateTo = "00:00:00" Then
            query += " AND DatePI >= '" & dateFrom & "' AND DatePI <= '" & dateTo & "'"
        End If

        If Not String.IsNullOrEmpty(customer) Then
            query += " AND CustomerName = '" & customer & "'"
        End If

        If Not String.IsNullOrEmpty(reffPO) Then
            query += " AND ReffPO = '" & reffPO & "'"
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

    Public Function RetrieveByID(headerID As Long) As ProInvoiceHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim piHeaderModel As ProInvoiceHeaderModel = New ProInvoiceHeaderModel
        Dim query As String = "Select * From v_ProInvoiceHeader Where BOID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader
                    If Not IsDBNull(.Item("BOID")) Then
                        piHeaderModel.BOID = headerID
                        piHeaderModel.DatePI = .Item("DatePI")
                        piHeaderModel.DelTerm = .Item("DelTerm")
                        piHeaderModel.NoOrder = .Item("NoOrder")
                        piHeaderModel.ContractNo = .Item("ContractNo")
                        piHeaderModel.BOID = .Item("BOID")
                        piHeaderModel.NoOrder = .Item("NoOrder")
                        piHeaderModel.ReffPO = .Item("ReffPO")
                        piHeaderModel.CustomerID = .Item("CustomerID")
                        piHeaderModel.CustomerCode = .Item("CustomerCode")
                        piHeaderModel.CustomerName = .Item("CustomerName")
                        piHeaderModel.Address = .Item("CustomerAddress")
                        piHeaderModel.Telephone = .Item("Telephone")
                        piHeaderModel.Fax = .Item("Fax")
                        piHeaderModel.FM = .Item("FM")
                        piHeaderModel.EmailCP = .Item("EmailCP")
                        piHeaderModel.BrandID = .Item("BrandID")
                        piHeaderModel.Brand = .Item("Brand")
                        piHeaderModel.StyleID = .Item("StyleID")
                        piHeaderModel.StyleName = .Item("Style")
                        piHeaderModel.SeasonID = .Item("SeasonID")
                        piHeaderModel.SeasonName = .Item("SeasonName")
                        piHeaderModel.TermOfPaymentID = .Item("TermOfPaymentID")
                        piHeaderModel.TermOfPayment = .Item("TermOfPayment")
                        piHeaderModel.TermOfPriceID = .Item("TermOfPriceID")
                        piHeaderModel.TermOfPrice = .Item("TermOfPrice")
                        piHeaderModel.DestinationID = .Item("DestinationID")
                        piHeaderModel.DestinationName = .Item("Destination")
                        piHeaderModel.DeliveryPlace = .Item("DeliveryPlace")
                        piHeaderModel.AddressDeliveryplace = .Item("AddressDeliveryPlace")
                        piHeaderModel.Atention = .Item("Atention")
                        piHeaderModel.AmountTotal = .Item("AmountTotal")
                        piHeaderModel.CurrID = .Item("CurrencyID")
                        piHeaderModel.CurrCode = .Item("CurrencyCode")
                        piHeaderModel.AmountTotal = .Item("AmountTotal")
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

    Public Function RetrieveFabricByHeaderID(headerID As Long) As List(Of ProInvoiceFabricDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceFabricDetail Where BOID='" & headerID & "'"
        Dim myList As List(Of ProInvoiceFabricDetailModel) = New List(Of ProInvoiceFabricDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim piDetailModel As ProInvoiceFabricDetailModel = New ProInvoiceFabricDetailModel
                    piDetailModel.BOID = .Item("BOID")
                    piDetailModel.FabricID = .Item("FabricID")
                    piDetailModel.FabricName = .Item("FabricName")
                    piDetailModel.Specification = .Item("Specification")
                    piDetailModel.RawMaterialID = .Item("RawMaterialID")
                    piDetailModel.RawMaterialName = .Item("RawMaterialName")
                    piDetailModel.UnitID = .Item("UnitID")
                    piDetailModel.UnitName = .Item("UnitName")
                    piDetailModel.TypeGreige = .Item("TypeGreige")
                    piDetailModel.WidthMin = .Item("WidthMin")
                    piDetailModel.WidthMax = .Item("WidthMax")
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

    Public Function RetrieveColorByHeaderID(headerID As Long) As List(Of ProInvoiceColorDetailModel)
        Dim myList As List(Of ProInvoiceColorDetailModel) = New List(Of ProInvoiceColorDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceColorDetail Where BOID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As ProInvoiceColorDetailModel = New ProInvoiceColorDetailModel
                    detailModel.BOID = .Item("BOID")
                    detailModel.NoOrder = .Item("NoOrder")
                    detailModel.FabricID = .Item("FabricID")
                    detailModel.FabricName = .Item("FabricName")
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.ColorName = .Item("ColorName")
                    detailModel.ColorLabNumber = .Item("LabsDipsNo")
                    detailModel.ColorType = .Item("ColorType")
                    detailModel.QtyOrder = .Item("QtyOrder")
                    detailModel.Netto = .Item("Netto")
                    detailModel.PurchSizeID = .Item("PurchSizeID")
                    detailModel.PurchSizeName = .Item("PurchSizeName")
                    detailModel.CurrencyID = .Item("CurrencyID")
                    detailModel.Currency = .Item("CurrencyCode")
                    detailModel.QtySample = .Item("QtySample")
                    detailModel.Price = .Item("Price")
                    detailModel.DelDate = .Item("DelDate")
                    detailModel.Note = .Item("Note")
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

    Public Function RetrieveYarnByHeaderID(headerID As Long) As List(Of ProInvoiceYarnDetailModel)
        Dim myList As List(Of ProInvoiceYarnDetailModel) = New List(Of ProInvoiceYarnDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceYarnDetail Where BOID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As ProInvoiceYarnDetailModel = New ProInvoiceYarnDetailModel
                    detailModel.BOID = .Item("BOID")
                    detailModel.NoOrder = .Item("NoOrder")
                    detailModel.YarnID = .Item("YarnID")
                    detailModel.YarnName = .Item("YarnName")
                    detailModel.VendorName = .Item("VendorName")
                    detailModel.UnitID = .Item("UnitID")
                    detailModel.Unitname = .Item("Unitname")
                    detailModel.PriceYarn = .Item("PriceYarn")
                    detailModel.PercentageUsage = .Item("PercentageUsage")
                    detailModel.QtyUsage = .Item("QtyUsage")
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.ColorName = .Item("ColorName")
                    detailModel.BrandYarnID = .Item("BrandYarnID")
                    detailModel.BrandYarnName = .Item("BrandYarnName")
                    detailModel.Loss = .Item("Loss")
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

    Public Function RetrieveBankByHeaderID(headerID As Long) As ProInvoiceBankDetailModel
        Dim piBankModel As ProInvoiceBankDetailModel = New ProInvoiceBankDetailModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_ProInvoiceBankDetail Where BOID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    piBankModel.BOID = .Item("BOID")
                    piBankModel.NoOrder = .Item("NoOrder")
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

    Public Function RetrieveRemarksByHeaderID(headerID As Long) As List(Of ProInvoiceRemarkDetailModel)
        Dim myList As List(Of ProInvoiceRemarkDetailModel) = New List(Of ProInvoiceRemarkDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From ProInvoiceRemarkDetail Where BOID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As ProInvoiceRemarkDetailModel = New ProInvoiceRemarkDetailModel
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

    Public Function RetrieveCustCodeByPIHeaderID(headerID As Long) As ProInvoiceHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim piHeaderModel As ProInvoiceHeaderModel = New ProInvoiceHeaderModel
        Dim query As String = "Select CustomerCode From v_ProInvoiceHeader Where BOID='" & headerID & "'"
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

#Region "Function"
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select proh.BOID,proh.NoOrder From v_ProInvoiceHeader As proh"
        query += " Left Join(Select BOID FROM PODetail) as podet ON podet.BOID = proh.BOID"
        query += " Where proh.Status = 2 And podet.BOID Is null"
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
                .DisplayMember = "NoOrder"
                .ValueMember = "BOID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
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
    Public Function SetDetailFabric(boID As Long, dgvFabric As DataGridView) As List(Of ProInvoiceFabricDetailModel)
        Dim listFabricDetailModel As List(Of ProInvoiceFabricDetailModel) = New List(Of ProInvoiceFabricDetailModel)
        Dim piDetailID As Long
        Try
            For detail = 0 To dgvFabric.Rows.Count - 2
                Dim detailModel As ProInvoiceFabricDetailModel = New ProInvoiceFabricDetailModel
                With dgvFabric
                    detailModel.BOID = boID
                    detailModel.FabricID = .Rows(detail).Cells(0).Value
                    detailModel.RawMaterialID = .Rows(detail).Cells(3).Value
                    detailModel.TypeGreige = .Rows(detail).Cells(5).Value
                    detailModel.WidthMin = .Rows(detail).Cells(6).Value
                    detailModel.WidthMax = .Rows(detail).Cells(7).Value
                    detailModel.UnitID = .Rows(detail).Cells(8).Value
                    detailModel.WeightMin = .Rows(detail).Cells(10).Value
                    detailModel.WeightMax = .Rows(detail).Cells(11).Value
                    detailModel.DNYardage = .Rows(detail).Cells(12).Value
                    detailModel.WeightYard = .Rows(detail).Cells(13).Value
                    detailModel.BeforeWash = .Rows(detail).Cells(14).Value
                    detailModel.AfterWash = .Rows(detail).Cells(15).Value
                    detailModel.NetWeight = .Rows(detail).Cells(16).Value
                    detailModel.SrinkageL = .Rows(detail).Cells(17).Value
                    detailModel.SrinkageW = .Rows(detail).Cells(18).Value
                    detailModel.GSM = .Rows(detail).Cells(19).Value
                    detailModel.PriceGreige = .Rows(detail).Cells(20).Value
                    detailModel.PurchSize = .Rows(detail).Cells(21).Value
                    detailModel.StorageSize = .Rows(detail).Cells(22).Value
                    detailModel.PPSample = .Rows(detail).Cells(23).Value
                    detailModel.QtyCuttable = .Rows(detail).Cells(24).Value
                    detailModel.QtyWeight = .Rows(detail).Cells(25).Value
                    listFabricDetailModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            Return listFabricDetailModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SetDetailColor(boID As Long, dgvColor As DataGridView) As List(Of ProInvoiceColorDetailModel)
        Dim listModel As List(Of ProInvoiceColorDetailModel) = New List(Of ProInvoiceColorDetailModel)
        Dim piDetailID As Long
        Try

            For detail = 0 To dgvColor.Rows.Count - 2
                Dim detailModel As ProInvoiceColorDetailModel = New ProInvoiceColorDetailModel
                With dgvColor
                    detailModel.BOID = boID
                    detailModel.FabricID = .Rows(detail).Cells(11).Value
                    detailModel.ColorID = .Rows(detail).Cells(0).Value
                    detailModel.ColorType = .Rows(detail).Cells(3).Value
                    detailModel.QtyOrder = .Rows(detail).Cells(4).Value
                    detailModel.PurchSizeID = .Rows(detail).Cells(5).Value
                    detailModel.CurrencyID = .Rows(detail).Cells(13).Value
                    detailModel.Price = .Rows(detail).Cells(7).Value
                    detailModel.QtySample = .Rows(detail).Cells(8).Value
                    detailModel.DelDate = .Rows(detail).Cells(9).Value
                    detailModel.Note = .Rows(detail).Cells(10).Value
                    listModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            Return listModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SetDetailYarn(boID As Long, dgvYarn As DataGridView) As List(Of ProInvoiceYarnDetailModel)
        Dim listModel As List(Of ProInvoiceYarnDetailModel) = New List(Of ProInvoiceYarnDetailModel)

        Dim piDetailID As Long
        Try
            For detail = 0 To dgvYarn.Rows.Count - 2
                Dim detailModel As ProInvoiceYarnDetailModel = New ProInvoiceYarnDetailModel
                With dgvYarn
                    detailModel.BOID = boID
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
            Return listModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SetDetailRemarks(boID As Long, dgvRemarks As DataGridView) As List(Of ProInvoiceRemarkDetailModel)
        Dim listModel As List(Of ProInvoiceRemarkDetailModel) = New List(Of ProInvoiceRemarkDetailModel)
        Dim piDetailID As Long
        Try
            For detail = 0 To dgvRemarks.Rows.Count - 2
                Dim detailModel As ProInvoiceRemarkDetailModel = New ProInvoiceRemarkDetailModel
                With dgvRemarks
                    detailModel.BOID = boID
                    detailModel.Remarks = .Rows(detail).Cells(0).Value
                    listModel.Add(detailModel)
                End With
                piDetailID = piDetailID + 1
            Next
            Return listModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Protected Function SqlInsertHeader(piHeaderModel As ProInvoiceHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into ProInvoiceHeader(BOID,SeasonID,TermOfPaymentID,TermOfPriceID,Atention" &
                                   ",DestinationID,DeliveryPlace,AddressDeliveryPlace,AmountTotal,CurrencyID,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                 "('" & piHeaderModel.BOID & "','" & piHeaderModel.SeasonID & "','" & piHeaderModel.TermOfPaymentID & "','" & piHeaderModel.TermOfPriceID & "'" &
                ",'" & piHeaderModel.Atention & "','" & piHeaderModel.DestinationID & "','" & piHeaderModel.DeliveryPlace & "'" &
                ",'" & piHeaderModel.AddressDeliveryplace & "','" & piHeaderModel.AmountTotal & "','" & piHeaderModel.CurrID & "','" & piHeaderModel.Status & "','" & piHeaderModel.CreatedBy & "'" &
                ",'" & Format(piHeaderModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "','" & piHeaderModel.UpdatedBy & "','" & Format(piHeaderModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
        Return sqlHeader
    End Function

    Protected Function SqlInsertDetailFabric(myModel As ProInvoiceFabricDetailModel) As String
        Dim sql As String

        sql = "Insert Into ProInvoiceFabricDetail(BOID,FabricID,RawMaterialID,TypeGreige,WidthMin,WidthMax,UnitID,WeightMin,WeightMax,DNYardage,WeightYard" &
              ",BeforeWash,AfterWash,NetWeight,SrinkageL,SrinkageW,GSM,PriceGreige,PurchSize,StorageSize,PPSample,QtyCuttable,QtyWeight)Values" &
              "('" & myModel.BOID & "','" & myModel.FabricID & "'" &
              ",'" & myModel.RawMaterialID & "','" & myModel.TypeGreige & "','" & myModel.WidthMin & "','" & myModel.WidthMax & "'" &
              ",'" & myModel.UnitID & "','" & myModel.WeightMin & "','" & myModel.WeightMax & "','" & myModel.DNYardage & "'" &
              ",'" & myModel.WeightYard & "','" & myModel.BeforeWash & "','" & myModel.AfterWash & "','" & myModel.NetWeight & "'" &
              ",'" & myModel.SrinkageL & "','" & myModel.SrinkageW & "','" & myModel.GSM & "','" & myModel.PriceGreige & "','" & myModel.PurchSize & "'" &
              ",'" & myModel.StorageSize & "','" & myModel.PPSample & "','" & myModel.QtyCuttable & "','" & myModel.QtyWeight & "')"

        Return sql
    End Function

    Protected Function SqlInsertDetailColorFabric(myModel As ProInvoiceColorDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into ProInvoiceColorDetail(BOID,FabricID,ColorID,ColorType,QtyOrder,PurchSizeID,CurrencyID,Price,QtySample,DelDate,Note)Values" &
                "('" & myModel.BOID & "','" & myModel.FabricID & "','" & myModel.ColorID & "','" & myModel.ColorType & "'" &
                ",'" & myModel.QtyOrder & "','" & myModel.PurchSizeID & "','" & myModel.CurrencyID & "','" & myModel.Price & "'" &
                ",'" & myModel.QtySample & "','" & myModel.DelDate & "','" & myModel.Note & "')"
        Return SQL
    End Function

    Protected Function SqlInsertYarnDetail(myModel As ProInvoiceYarnDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into ProInvoiceYarnDetail(BOID,YarnID,PriceYarn,PercentageUsage,QtyUsage,ColorID,BrandYarnID,Loss)Values" &
               "('" & myModel.BOID & "','" & myModel.YarnID & "','" & myModel.PriceYarn & "'" &
               ",'" & myModel.PercentageUsage & "','" & myModel.QtyUsage & "','" & myModel.ColorID & "','" & myModel.BrandYarnID & "','" & myModel.Loss & "')"
        Return SQL
    End Function


    Protected Function SqlInsertBankDetail(myModel As ProInvoiceBankDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into ProInvoiceBankDetail(BOID,BankAccountID)Values('" & myModel.BOID & "'" &
                ",'" & myModel.BankAccountID & "')"
        Return SQL
    End Function


    Protected Function SqlInsertRemarksDetail(myModel As ProInvoiceRemarkDetailModel) As String
        Dim SQL As String
        SQL = "Insert Into ProInvoiceRemarkDetail(BOID,Remarks)Values('" & myModel.BOID & "'" &
                ",'" & myModel.Remarks & "')"
        Return SQL
    End Function

    Protected Function SqlUpdateHeader(myModel As ProInvoiceHeaderModel) As String
        Dim SQL As String
        SQL = "Update ProInvoiceHeader Set SeasonID = '" & myModel.SeasonID & "'" &
                                    ",TermOfPaymentID = '" & myModel.TermOfPaymentID & "'" &
                                    ",TermOfPriceID = '" & myModel.TermOfPriceID & "'" &
                                    ",Atention = '" & myModel.Atention & "',DestinationID = '" & myModel.DestinationID & "'" &
                                    ",DeliveryPlace = '" & myModel.DeliveryPlace & "' , AddressDeliveryPlace = '" & myModel.AddressDeliveryplace & "'" &
                                     ",AmountTotal = '" & myModel.AmountTotal & "',CurrencyID = '" & myModel.CurrID & "'" &
                                    ",Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & Format(myModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Public Function SqlUpdateStatusHeader(myModel As ProInvoiceHeaderModel) As String
        Dim SQL As String
        SQL = "Update ProInvoiceHeader Set Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
            ",UpdatedDate = '" & Format(myModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailFabric(myModel As ProInvoiceHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From ProInvoiceFabricDetail Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailColor(myModel As ProInvoiceHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From ProInvoiceColorDetail Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailYarn(myModel As ProInvoiceHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From ProInvoiceYarnDetail Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlUpdateDetailBank(myModel As ProInvoiceBankDetailModel) As String
        Dim SQL As String
        SQL = "Update ProInvoiceBankDetail Set BankAccountID = '" & myModel.BankAccountID & "' Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailRemarks(myModel As ProInvoiceHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From ProInvoiceRemarkDetail Where  BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Public Function InsertData(proinvoiceHeaderModel As ProInvoiceHeaderModel, listDetailFabricModel As List(Of ProInvoiceFabricDetailModel), listColorDetailModel As List(Of ProInvoiceColorDetailModel), listYarnDetailModel As List(Of ProInvoiceYarnDetailModel), listRemarks As List(Of ProInvoiceRemarkDetailModel), listbankDetailModel As ProInvoiceBankDetailModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'insert header
        queryList.Add(SqlInsertHeader(proinvoiceHeaderModel))

        'insert detail fabric
        For Each detail In listDetailFabricModel
            queryList.Add(SqlInsertDetailFabric(detail))
        Next
        'insert detail color
        For Each detailColor In listColorDetailModel
            queryList.Add(SqlInsertDetailColorFabric(detailColor))
        Next
        'insert detail yarn
        For Each detailYarn In listYarnDetailModel
            queryList.Add(SqlInsertYarnDetail(detailYarn))
        Next
        ''insert Remarks
        For Each myRemarksDetail In listRemarks
            queryList.Add(SqlInsertRemarksDetail(myRemarksDetail))
        Next

        ''insert Bank Detail
        queryList.Add(SqlInsertBankDetail(listbankDetailModel))

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

    Public Function UpdateData(piHeaderModel As ProInvoiceHeaderModel, listPIDetailModel As List(Of ProInvoiceFabricDetailModel) _
                               , listColorDetailModel As List(Of ProInvoiceColorDetailModel), listYarnDetailModel As List(Of ProInvoiceYarnDetailModel) _
                               , listRemarks As List(Of ProInvoiceRemarkDetailModel), bankDetailModel As ProInvoiceBankDetailModel, logModel As LogHistoryModel) As Boolean
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

    Public Function UpdateStatusHeader(piHeaderModel As ProInvoiceHeaderModel, logModel As LogHistoryModel) As Boolean
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