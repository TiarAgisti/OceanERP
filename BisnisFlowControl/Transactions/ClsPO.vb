Imports Microsoft.Reporting.WinForms
Public Class ClsPO
    Dim querypo As String = "Select POHeaderID,CurrencyID,CurrencyCode,PODate,PONo,SupplierCode,SupplierName,ShipViaMethodCode,ShipViaMethodName,ShippingDate,TermOfPayment,ExpectedReceiptDate" &
                               ",SupplierID,TermOfPaymentID,ShipViaMethodID,StatusDesc From v_POHeader" &
                               " Where Status =2 "
#Region "Method Retrieve"
    Public Function Retrievepo(options As String, param As String) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Select Case options

            Case "PO No"
                querypo += " AND PONo LIKE '%" & param & "%' Order By PONo Asc"
            Case "Supplier Name"
                querypo += " AND SupplierName LIKE '%" & param & "%' Order By PONo Asc"

            Case Else
                querypo += " Order By PONo Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(querypo)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function RetrieveListPurchaseOrder(poNo As String, dateFrom As Date, dateTo As Date, customer As String _
                                                , supplier As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select POHeaderID,CurrencyID,CurrencyCode,PODate,PONo,SupplierCode,SupplierName,ShipViaMethodCode,ShipViaMethodName,ShippingDate,TermOfPayment,ExpectedReceiptDate" &
                               ",SupplierID,TermOfPaymentID,ShipViaMethodID,StatusDesc From v_POHeader" &
                               " Where Status <> 0"

        If Not String.IsNullOrEmpty(poNo) Then
            query += " AND PONo = '" & poNo & "'"
        End If

        If Not dateFrom = "00:00:00" And Not dateTo = "00:00:00" Then
            query += " AND PODate >= '" & dateFrom & "' AND PODate <= '" & dateTo & "'"
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
                    If Not IsDBNull(.Item("POHeaderID")) Then
                        poHeaderModel.POHeaderID = headerID
                        poHeaderModel.PODate = .Item("PODate")
                        poHeaderModel.PONo = .Item("PONo")
                        poHeaderModel.CurrencyID = .Item("CurrencyID")
                        poHeaderModel.CurrencyCode = .Item("CurrencyCode")
                        poHeaderModel.SupplierID = .Item("SupplierID")
                        poHeaderModel.SupplierCode = .Item("SupplierCode")
                        poHeaderModel.SupplierName = .Item("SupplierName")
                        poHeaderModel.AddressSupplier = .Item("AddressSupplier")
                        poHeaderModel.TelephoneSupplier = .Item("TelephoneSupplier")
                        poHeaderModel.FaxSupplier = .Item("FaxSupplier")
                        poHeaderModel.ContactPersonSupplier = .Item("ContactPersonSupplier")
                        poHeaderModel.EmailSupplier = .Item("EmailSupplier")
                        poHeaderModel.ShipViaMethodID = .Item("ShipViaMethodID")
                        poHeaderModel.ShipViaMethodCode = .Item("ShipViaMethodCode")
                        poHeaderModel.ShipViaMethodName = .Item("ShipViaMethodCode")
                        poHeaderModel.ShippingDate = .Item("ShippingDate")
                        poHeaderModel.TermOfPaymentID = .Item("TermOfPaymentID")
                        poHeaderModel.TermOfPayment = .Item("TermOfPayment")
                        poHeaderModel.ExpectedReceiptDate = .Item("ExpectedReceiptDate")
                        poHeaderModel.Subtotal = .Item("Subtotal")
                        poHeaderModel.Discount = .Item("Discount")
                        poHeaderModel.VATRate = .Item("VATRate")
                        poHeaderModel.OtherCost = .Item("OtherCost")
                        poHeaderModel.SH = .Item("SH")
                        poHeaderModel.GrandTotal = .Item("GrandTotal")
                        poHeaderModel.Status = .Item("Status")
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
    Public Function RetrieveByDetailRaw(headerID As Long, rawmatrialID As Integer) As PODetailModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        'Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim dataTable As DataTable = New DataTable
        Dim podetailModel As PODetailModel = New PODetailModel

        Dim query As String = "Select * From v_PODetail Where POHeaderID='" & headerID & "'  AND YarnID = '" & rawmatrialID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader
                    podetailModel.POHeaderID = .Item("POHeaderID")
                    If IsDBNull(.Item("PIHeaderID")) Then
                        podetailModel.PIHeaderID = 0
                    Else
                        podetailModel.PIHeaderID = .Item("BOID")
                    End If
                    If IsDBNull(.Item("BOID")) Then
                        podetailModel.PINo = 0
                    Else
                        podetailModel.PINo = .Item("BOID")
                    End If
                    podetailModel.RawMaterialID = .Item("YarnID")
                    podetailModel.RawMaterialName = .Item("YarnName")
                    podetailModel.UnitID = .Item("UnitID")
                    podetailModel.UnitName = .Item("UnitName")
                    podetailModel.Quantity = .Item("Quantity")
                    podetailModel.UnitPrice = .Item("UnitPrice")
                    podetailModel.PODate = .Item("PODate")
                    podetailModel.PONo = .Item("NoOrder")
                    podetailModel.Total = .Item("Total")
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return podetailModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

    End Function
    Public Function RetrieveRawMaterialByHeaderID(headerID As Long) As List(Of PODetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_PODetail Where POHeaderID='" & headerID & "'"
        Dim myList As List(Of PODetailModel) = New List(Of PODetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim poDetailModel As PODetailModel = New PODetailModel
                    poDetailModel.POHeaderID = .Item("POHeaderID")
                    If IsDBNull(.Item("BOID")) Then
                        poDetailModel.PIHeaderID = 0
                    Else
                        poDetailModel.PIHeaderID = .Item("BOID")
                    End If
                    If IsDBNull(.Item("NoOrder")) Then
                        poDetailModel.PINo = 0
                    Else
                        poDetailModel.PINo = .Item("NoOrder")
                    End If
                    poDetailModel.RawMaterialID = .Item("YarnID")
                    poDetailModel.RawMaterialName = .Item("YarnName")
                    poDetailModel.UnitID = .Item("UnitID")
                    poDetailModel.UnitName = .Item("UnitName")
                    poDetailModel.Quantity = .Item("Quantity")
                    poDetailModel.UnitPrice = .Item("UnitPrice")
                    poDetailModel.PODate = .Item("PODate")
                    poDetailModel.PONo = .Item("NoOrder")
                    poDetailModel.Total = .Item("Total")
                    myList.Add(poDetailModel)
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
    Public Function RetrieveRemarksByHeaderID(headerID As Long) As List(Of PORemarksModel)
        Dim myList As List(Of PORemarksModel) = New List(Of PORemarksModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From PORemarks Where POHeaderID = '" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As PORemarksModel = New PORemarksModel
                    detailModel.Remarks = .Item("Remarks")
                    myList.Add(detailModel)
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
    End Function

#End Region

#Region "Method Generated"
    Protected Function GeneratedPONo() As String
        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(PONo) as Code from POHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("Code")) Then
                myCode = Format(Now.Year) + "0001"
            Else
                Dim xtahun As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("Code"), 4)
                If xtahun = Format(Now.Year) Then
                    Dim xCode As String = Microsoft.VisualBasic.Right(dataAccess.reader.Item("Code"), 4)
                    hitung = Microsoft.VisualBasic.Right(xCode, 4) + 1
                    myCode = Format(Now.Year) & Microsoft.VisualBasic.Right("0000" & hitung, 4)
                Else
                    myCode = Format(Now.Year) + "0001"
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
        Dim query As String = "Select max(POHeaderID) from POHeader"
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
#End Region

#Region "Get"
    Public Function GetPONo() As String
        Dim bonOrderCode As String
        Try
            bonOrderCode = GeneratedPONo()
            Return bonOrderCode
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Function"
    Protected Function ListComboBox() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable

        Dim query As String = "Select POHeaderID,PONo From POHeader Where Status = 2"
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
    Public Sub ComboBoxPO(cmb As ComboBox)
        Try

            With cmb

                .DataSource = ListComboBox()

                .DisplayMember = "PONo"
                .ValueMember = "POHeaderID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Protected Function ListComboBoxPI(headerID As Long) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable

        Dim query As String = "Select PIHeaderID,PINO From v_PODetail where POHeaderID = '" & headerID & "'"
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
    Public Sub ComboBoxPI(cmb As ComboBox, headerID As Long)


        Try
            With cmb
                .DataSource = ListComboBoxPI(headerID)
                .DisplayMember = "PINo"
                .ValueMember = "PIHeaderID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Protected Function ListComboBoxRaw(headerID As Long) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable

        Dim query As String = "Select RawMaterialID,RawMaterialName From v_PODetail Where POHeaderID = '" & headerID & "'"
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
    Public Sub ComboBoxRaw(cmb As ComboBox, headerID As Long)
        Try

            With cmb

                .DataSource = ListComboBoxRaw(headerID)

                .DisplayMember = "RawMaterialName"
                .ValueMember = "RawMaterialID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Protected Function ListComboBoxYarn(headerID As Long) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable

        Dim query As String = "Select YarnID,YarnName From v_ProInvoiceYarnDetail  Where BOID = '" & headerID & "'"
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
    Public Sub ComboBoxYarn(cmb As ComboBox, headerID As Long)
        Try

            With cmb

                .DataSource = ListComboBoxYarn(headerID)

                .DisplayMember = "YarnName"
                .ValueMember = "YarnID"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "Get ID"
    Public Function GetPOHeaderID() As Long
        Dim myID As Long
        myID = GeneratedAutoNumber()
        Return myID
    End Function
#End Region

#Region "Check Available In List"
    Public Function CheckYarnInList(dgvrawmatrial As DataGridView, RawMatrialID As Integer) As Boolean
        Dim cek As Integer
        Dim status As Boolean = True
        For cek = 0 To dgvrawmatrial.Rows.Count - 1
            If dgvrawmatrial.Rows(cek).Cells(0).Value = RawMatrialID Then
                status = False
            End If
        Next
        Return status
    End Function
    Public Function CheckRemarksInList(dgvRemarks As DataGridView, remarks As String) As Boolean
        Dim row As Integer
        Dim status As Boolean = True
        For row = 0 To dgvRemarks.Rows.Count - 1
            If dgvRemarks.Rows(row).Cells(0).Value = remarks Then
                status = False
            End If
        Next
        Return status
    End Function
#End Region

#Region "Set Data Detail"
    Public Function SetDetailRawMatrial(poID As Long, dgvrawmatrial As DataGridView) As List(Of PODetailModel)
        Dim listRawMatrialDetailModel As List(Of PODetailModel) = New List(Of PODetailModel)
        ' Dim poDetailID As Long

        '  poDetailID = GetPODetailID()
        For detail = 0 To dgvrawmatrial.Rows.Count - 2
            Dim detailModel As PODetailModel = New PODetailModel
            With dgvrawmatrial
                detailModel.POHeaderID = poID
                detailModel.RawMaterialID = .Rows(detail).Cells(0).Value
                detailModel.UnitID = .Rows(detail).Cells(2).Value
                detailModel.UnitPrice = .Rows(detail).Cells(4).Value
                detailModel.Quantity = .Rows(detail).Cells(5).Value
                detailModel.Total = .Rows(detail).Cells(6).Value
                detailModel.PIHeaderID = .Rows(detail).Cells(7).Value
                listRawMatrialDetailModel.Add(detailModel)
            End With
            '  poDetailID = poDetailID + 1
        Next
        Return listRawMatrialDetailModel
    End Function
    Public Function SetDetailRemarks(poID As Long, dgvRemarks As DataGridView) As List(Of PORemarksModel)
        Dim listModel As List(Of PORemarksModel) = New List(Of PORemarksModel)
        Dim poBFC As ClsPO = New ClsPO
        Dim poDetailID As Long
        For detail = 0 To dgvRemarks.Rows.Count - 2
            Dim detailModel As PORemarksModel = New PORemarksModel
            With dgvRemarks
                detailModel.POHeaderID = poID
                detailModel.Remarks = .Rows(detail).Cells(0).Value
                listModel.Add(detailModel)
            End With
            poDetailID = poDetailID + 1
        Next
        Return listModel
    End Function
#End Region

#Region "Method CRUD"
    Protected Function SqlInsertHeader(poHeaderModel As POHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into POHeader(POHeaderID,PODate,PONo,SupplierID,ShipViaMethodID,ShippingDate,TermOfPaymentID,ExpectedReceiptDate" &
                                   ",CurrencyID,Subtotal,Discount,VATRate,OtherCost,SH,GrandTotal,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                   "('" & poHeaderModel.POHeaderID & "','" & poHeaderModel.PODate & "','" & poHeaderModel.PONo & "'" &
                                   ",'" & poHeaderModel.SupplierID & "','" & poHeaderModel.ShipViaMethodID & "'" &
                                   ",'" & poHeaderModel.ShippingDate & "','" & poHeaderModel.TermOfPaymentID & "','" & poHeaderModel.ExpectedReceiptDate & "'" &
                                   ",'" & poHeaderModel.CurrencyID & "','" & poHeaderModel.Subtotal & "','" & poHeaderModel.Discount & "','" & poHeaderModel.VATRate & "'" &
                                   ",'" & poHeaderModel.OtherCost & "','" & poHeaderModel.SH & "','" & poHeaderModel.GrandTotal & "'" &
                                   ",'" & poHeaderModel.Status & "','" & poHeaderModel.CreatedBy & "','" & Format(poHeaderModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "'" &
                                   ",'" & poHeaderModel.UpdatedBy & "','" & Format(poHeaderModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
        Return sqlHeader
    End Function

    Protected Function SqlUpdateHeader(myModel As POHeaderModel) As String
        Dim SQL As String
        SQL = "Update POHeader Set  PODate = '" & myModel.PODate & "',SupplierID = '" & myModel.SupplierID & "'" &
                                    ",ShipViaMethodID='" & myModel.ShipViaMethodID & "',ShippingDate = '" & myModel.ShippingDate & "'" &
                                    ",TermOfPaymentID = '" & myModel.TermOfPaymentID & "',ExpectedReceiptDate = '" & myModel.ExpectedReceiptDate & "'" &
                                    ",CurrencyID = '" & myModel.CurrencyID & "',Subtotal = '" & myModel.Subtotal & "',Discount = '" & myModel.Discount & "'" &
                                    ",VATRate = '" & myModel.VATRate & "',OtherCost = '" & myModel.OtherCost & "'" &
                                    ",SH='" & myModel.SH & "',GrandTotal = '" & myModel.GrandTotal & "'" &
                                    ",Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & Format(myModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where POHeaderID = '" & myModel.POHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlInsertDetailRawMatrial(myModel As PODetailModel) As String
        Dim sql As String

        sql = "Insert Into PODetail(POHeaderID,BOID,YarnID,UnitID,Quantity" &
              ",UnitPrice)Values" &
              "('" & myModel.POHeaderID & "','" & myModel.PIHeaderID & "','" & myModel.RawMaterialID & "','" & myModel.UnitID & "'" &
              ",'" & myModel.Quantity & "','" & myModel.UnitPrice & "')"

        Return sql
    End Function

    Protected Function SqlInsertRemarksDetail(myModel As PORemarksModel) As String
        Dim SQL As String
        SQL = "Insert Into PORemarks(POHeaderID,Remarks)Values('" & myModel.POHeaderID & "'" &
                ",'" & myModel.Remarks & "')"
        Return SQL
    End Function

    Protected Function SqlUpdateStatusHeader(myModel As POHeaderModel) As String
        Dim SQL As String
        SQL = "Update POHeader Set Status = '" & myModel.Status & "' Where POHeaderID = '" & myModel.POHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailRawMatrail(myModel As POHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From PODetail Where POHeaderID = '" & myModel.POHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailRemarks(myModel As POHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From PORemarks Where POHeaderID = '" & myModel.POHeaderID & "'"
        Return SQL
    End Function

    Public Function InsertData(pOHeaderModel As POHeaderModel, listPoDetailModel As List(Of PODetailModel) _
                              , listRemarks As List(Of PORemarksModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'insert header
        queryList.Add(SqlInsertHeader(pOHeaderModel))

        'insert RawMatrial detail
        For Each detail In listPoDetailModel
            queryList.Add(SqlInsertDetailRawMatrial(detail))
        Next
        'insert Remarks
        For Each myRemarksDetail In listRemarks
            queryList.Add(SqlInsertRemarksDetail(myRemarksDetail))
        Next


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

    Public Function UpdateData(poHeaderModel As POHeaderModel, listPODetailModel As List(Of PODetailModel) _
                              , listRemarks As List(Of PORemarksModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'delete all detail before update
        queryList.Add(SqlDeleteDetailRawMatrail(poHeaderModel)) 'delete RawMatrial
        queryList.Add(SqlDeleteDetailRemarks(poHeaderModel)) 'delete Remarks

        'update poheader
        queryList.Add(SqlUpdateHeader(poHeaderModel))

        'insert matrial
        For Each detail In listPODetailModel
            queryList.Add(SqlInsertDetailRawMatrial(detail))
        Next
        'insert Remarks
        For Each myRemarksDetail In listRemarks
            queryList.Add(SqlInsertRemarksDetail(myRemarksDetail))
        Next
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

    Public Function UpdateStatusHeader(poHeaderModel As POHeaderModel, logModel As LogHistoryModel) As Boolean
        Dim status As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        Try
            'update header
            queryList.Add(SqlUpdateStatusHeader(poHeaderModel))
            'insert log history
            queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            status = True
        Catch ex As Exception
            status = False
            Throw ex
        End Try
        Return status
    End Function
#End Region
End Class
