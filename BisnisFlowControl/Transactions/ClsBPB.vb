Public Class ClsBPB

#Region "Method Retrieve"
    Public Function RetrieveListBPB(bpbNo As String, dateFrom As Date, dateTo As Date, supplier As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select BPBHeaderID,BPBNo,BPBDate,InfactDate,DONo,DocTypeCustoms,DocNoCustoms,DocRegistrationDate,POHeaderID,PONo" &
                               ",SupplierID,SupplierCode,SupplierName,StatusDesc From v_BPBHeader Where Status <> 0"

        If Not String.IsNullOrEmpty(bpbNo) Then
            query += " AND BPBNO = '" & bpbNo & "'"
        End If

        If Not dateFrom = "00:00:00" And Not dateTo = "00:00:00" Then
            query += " AND BPBDate >= '" & dateFrom & "' AND BPBDate <= '" & dateTo & "'"
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
    Public Function RetrieveByID(headerID As Long) As BPBHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim bpbHeaderModel As BPBHeaderModel = New BPBHeaderModel
        Dim query As String = "Select * From v_BPBHeader Where BPBHeaderID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader
                    If Not IsDBNull(.Item("BPBHeaderID")) Then
                        bpbHeaderModel.BPBHeaderID = headerID
                        bpbHeaderModel.BPBNo = .Item("BPBNo")
                        bpbHeaderModel.BPBDate = .Item("BPBDate")
                        bpbHeaderModel.InfactDate = .Item("InfactDate")
                        bpbHeaderModel.DONo = .Item("DONo")
                        bpbHeaderModel.DocTypeCustoms = .Item("DocTypeCustoms")
                        bpbHeaderModel.DocNoCustoms = .Item("DocNoCustoms")
                        bpbHeaderModel.DocRegistrationDate = .Item("DocRegistrationDate")
                        bpbHeaderModel.POHeaderID = .Item("POHeaderID")
                        bpbHeaderModel.PONo = .Item("PONo")
                        bpbHeaderModel.SupplierID = .Item("SupplierID")
                        bpbHeaderModel.SupplierCode = .Item("SupplierCode")
                        bpbHeaderModel.SupplierName = .Item("SupplierName")
                        bpbHeaderModel.Status = .Item("Status")
                    End If
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return bpbHeaderModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveRawMaterialBPBByHeaderID(headerID As Long) As List(Of BPBDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BPBDetail Where BPBHeaderID='" & headerID & "'"
        Dim myList As List(Of BPBDetailModel) = New List(Of BPBDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim bpbDetailModel As BPBDetailModel = New BPBDetailModel
                    bpbDetailModel.BPBHeaderID = .Item("BPBHeaderID")
                    If IsDBNull(.Item("PIHeaderID")) Then
                        bpbDetailModel.PIHeaderID = 0
                    Else
                        bpbDetailModel.PIHeaderID = .Item("PIHeaderID")
                    End If
                    If IsDBNull(.Item("PINo")) Then
                        bpbDetailModel.PINo = 0
                    Else
                        bpbDetailModel.PINo = .Item("PINo")
                    End If
                    'bpbDetailModel.PIHeaderID = .Item("PIHeaderID")
                    'bpbDetailModel.PINo = .Item("PINo")
                    bpbDetailModel.POHeaderID = .Item("POHeaderID")
                    bpbDetailModel.PONo = .Item("PONo")
                    bpbDetailModel.RawMaterialID = .Item("RawMaterialID")
                    bpbDetailModel.RawMaterialName = .Item("RawMaterialName")
                    bpbDetailModel.UnitID = .Item("UnitID")
                    bpbDetailModel.UnitName = .Item("UnitName")
                    bpbDetailModel.QuantityPO = .Item("QuantityPO")
                    bpbDetailModel.Received = .Item("Received")
                    bpbDetailModel.Outstanding = .Item("Outstanding")
                    bpbDetailModel.QuantityPackaging = .Item("QuantityPackaging")
                    myList.Add(bpbDetailModel)
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

#End Region

#Region "Method Generated"

    Protected Function GeneratedBPBNo(supplierCode As String) As String

        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(BPBNo) as Code from BPBHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("Code")) Then
                myCode = "BPB" + "0000001" + "/" + supplierCode + "/" + Format(Now.Year)
            Else
                Dim xtahun As String = Microsoft.VisualBasic.Right(dataAccess.reader.Item("Code"), 4)
                If xtahun <> Format(Now.Year) Then
                    Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("Code"), 10)
                    hitung = Microsoft.VisualBasic.Right(xCode, 7) + 1
                    myCode = "BPB" & Microsoft.VisualBasic.Right("0000000" & hitung, 7) & "/" & supplierCode & "/" & Format(Now.Year)
                Else
                    myCode = "BPB" + "0000001" + "/" + supplierCode + "/" + Format(Now.Year)
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
        Dim query As String = "Select max(BPBHeaderID) from BPBHeader"
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
    Protected Function GeneratedAutoNumberStockID() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(StockID) from Stock"
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
    Public Function GetBPBNo(supplierCode As String) As String
        Dim bpbNo As String
        bpbNo = GeneratedBPBNo(supplierCode)
        Return bpbNo
    End Function

#End Region

#Region "Get ID"
    Public Function GetBPBHeaderID() As Long
        Dim myID As Long
        myID = GeneratedAutoNumber()
        Return myID
    End Function

    Public Function GetStockID() As Long
        Dim myID As Long
        myID = GeneratedAutoNumberStockID()
        Return myID
    End Function

#End Region

#Region "Check Available In List"
    Public Function CheckRawMatrialBPBInList(dgv As DataGridView, RawMatrialID As Integer) As Boolean
        Dim cek As Integer
        Dim status As Boolean = True
        For cek = 0 To dgv.Rows.Count - 1
            If dgv.Rows(cek).Cells(0).Value = RawMatrialID Then
                status = False
            End If
        Next
        Return status
    End Function
#End Region

#Region "Set Data Detail"
    Public Function SetDetailRawMatrial(bpbID As Long, dgv As DataGridView) As List(Of BPBDetailModel)
        Dim listRawMatrialDetailModel As List(Of BPBDetailModel) = New List(Of BPBDetailModel)
        ' Dim poDetailID As Long

        '  poDetailID = GetPODetailID()
        For detail = 0 To dgv.Rows.Count - 2
            Dim detailModel As BPBDetailModel = New BPBDetailModel
            With dgv
                detailModel.BPBHeaderID = bpbID
                detailModel.POHeaderID = .Rows(detail).Cells(7).Value
                detailModel.PIHeaderID = .Rows(detail).Cells(9).Value
                detailModel.RawMaterialID = .Rows(detail).Cells(0).Value
                detailModel.Received = .Rows(detail).Cells(2).Value
                detailModel.QuantityPackaging = .Rows(detail).Cells(3).Value
                detailModel.UnitID = .Rows(detail).Cells(4).Value
                listRawMatrialDetailModel.Add(detailModel)
            End With
            '  poDetailID = poDetailID + 1
        Next
        Return listRawMatrialDetailModel
    End Function
    Public Function SetDetailStock(bpbID As Long, bpbCode As String, dgv2 As DataGridView) As List(Of StockModel)
        Dim listDetail As List(Of StockModel) = New List(Of StockModel)
        For detail = 0 To dgv2.Rows.Count - 2
            Dim detailModel As StockModel = New StockModel
            With dgv2
                detailModel.StockID = GetStockID()
                detailModel.PIHeaderID = .Rows(detail).Cells(9).Value
                detailModel.RawMaterialID = .Rows(detail).Cells(0).Value
                detailModel.QuantityIN = .Rows(detail).Cells(2).Value
                detailModel.QuantityOUT = 0
                detailModel.DocID = bpbID
                detailModel.DocDate = .Rows(detail).Cells(12).Value
                detailModel.DocType = "BPB"
                listDetail.Add(detailModel)
            End With
            '  poDetailID = poDetailID + 1
        Next
        Return listDetail
    End Function

#End Region

#Region "Method CRUD"
    Protected Function SqlInsertHeader(bpbHeaderModel As BPBHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into BPBHeader(BPBHeaderID,POHeaderID,BPBNo,BPBDate,InfactDate,DONo,DocTypeCustoms,DocNoCustoms,DocRegistrationDate" &
                                   ",Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                                   "('" & bpbHeaderModel.BPBHeaderID & "','" & bpbHeaderModel.POHeaderID & "','" & bpbHeaderModel.BPBNo & "'" &
                                   ",'" & bpbHeaderModel.BPBDate & "','" & bpbHeaderModel.InfactDate & "','" & bpbHeaderModel.DONo & "'" &
                                   ",'" & bpbHeaderModel.DocTypeCustoms & "','" & bpbHeaderModel.DocNoCustoms & "','" & bpbHeaderModel.DocRegistrationDate & "'" &
                                   ",'" & bpbHeaderModel.Status & "','" & bpbHeaderModel.CreatedBy & "','" & bpbHeaderModel.CreatedDate & "'" &
                                   ",'" & bpbHeaderModel.UpdatedBy & "','" & bpbHeaderModel.UpdatedDate & "')"
        Return sqlHeader
    End Function

    Protected Function SqlUpdateHeader(myModel As BPBHeaderModel) As String
        Dim SQL As String
        SQL = "Update BPBHeader Set  POHeaderID = '" & myModel.POHeaderID & "',BPBDate = '" & myModel.BPBDate & "',InfactDate = '" & myModel.InfactDate & "'" &
                                    ",DONo='" & myModel.DONo & "',DocTypeCustoms = '" & myModel.DocTypeCustoms & "'" &
                                    ",DocNoCustoms = '" & myModel.DocNoCustoms & "',DocRegistrationDate = '" & myModel.DocRegistrationDate & "'" &
                                     ",Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
                                    ",UpdatedDate = '" & myModel.UpdatedDate & "' Where BPBHeaderID = '" & myModel.BPBHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlInsertDetailBPB(myModel As BPBDetailModel) As String
        Dim sql As String

        sql = "Insert Into BPBDetail(BPBHeaderID,POHeaderID,PIHeaderID,RawMaterialID,QuantityBPB,QuantityPackaging" &
              ",UnitID)Values" &
              "('" & myModel.BPBHeaderID & "','" & myModel.POHeaderID & "','" & myModel.PIHeaderID & "','" & myModel.RawMaterialID & "'" &
              ",'" & myModel.Received & "','" & myModel.QuantityPackaging & "','" & myModel.UnitID & "')"

        Return sql
    End Function
    Protected Function SqlInsertStock(myModel As StockModel) As String
        Dim sql As String

        sql = "Insert Into Stock(StockID,PIHeaderID,RawMaterialID,QuantityIN,QuantityOut,DocID,DocDate" &
              ",DocType)Values" &
              "('" & myModel.StockID & "','" & myModel.PIHeaderID & "','" & myModel.RawMaterialID & "'" &
              ",'" & myModel.QuantityIN & "','" & myModel.QuantityOUT & "','" & myModel.DocID & "','" & myModel.DocDate & "','" & myModel.DocType & "')"

        Return sql
    End Function

    Protected Function SqlUpdateStatusHeader(myModel As BPBHeaderModel) As String
        Dim SQL As String
        SQL = "Update BPBHeader Set Status = '" & myModel.Status & "' Where BPBHeaderID = '" & myModel.BPBHeaderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailBPB(myModel As BPBHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From BPBDetail Where BPBHeaderID = '" & myModel.BPBHeaderID & "'"
        Return SQL
    End Function
    Protected Function SqlDeleteStock(myModel As BPBHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From Stock Where StockID = '" & myModel.BPBHeaderID & "'"
        Return SQL
    End Function



    Public Function InsertData(bpbHeaderModel As BPBHeaderModel, listBpbDetailModel As List(Of BPBDetailModel), liststokDetailModel As List(Of StockModel) _
                              , logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'insert header
        queryList.Add(SqlInsertHeader(bpbHeaderModel))

        'insert RawMatrial detail
        For Each detail In listBpbDetailModel
            queryList.Add(SqlInsertDetailBPB(detail))
        Next
        'insert stok detail
        For Each detail In liststokDetailModel
            queryList.Add(SqlInsertStock(detail))
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

    Public Function UpdateData(bpbHeaderModel As BPBHeaderModel, listBpbDetailModel As List(Of BPBDetailModel), liststokDetailModel As List(Of StockModel) _
                              , logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        'delete all detail before update
        queryList.Add(SqlDeleteDetailBPB(bpbHeaderModel))

        'update poheader
        queryList.Add(SqlUpdateHeader(bpbHeaderModel))

        'insert matrial
        For Each detail In listBpbDetailModel
            queryList.Add(SqlInsertDetailBPB(detail))
        Next
        For Each detail In liststokDetailModel
            queryList.Add(SqlInsertStock(detail))
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

    Public Function UpdateStatusHeader(bpbHeaderModel As BPBHeaderModel, logModel As LogHistoryModel) As Boolean
        Dim status As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)

        Try
            'update header
            queryList.Add(SqlUpdateStatusHeader(bpbHeaderModel))
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
