Public Class ClsBonOrder
#Region "Retrieve"
    Public Function RetrieveListBonOrder(noBonOrder As String, dateIssues As Date, piNO As String, customerName As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select BonOrderID,BonOrderCode,DateIssues,PINo,RefPO,BuyerName,StyleName,CustomerName,StatusDesc From v_BonOrderHeader"

        If Not String.IsNullOrEmpty(noBonOrder) Then
            query += " AND BonOrderCode LIKE '%" & noBonOrder & "%'"
        End If

        If Not dateIssues = "1900-01-01" Then
            query += " AND DateIssues = '" & dateIssues & "'"
        End If

        If Not String.IsNullOrEmpty(piNO) Then
            query += " AND PINo LIKE '%" & piNO & "%'"
        End If

        If Not String.IsNullOrEmpty(customerName) Then
            query += " AND CustomerName = '" & customerName & "'"
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
    Public Function RetrieveByID(headerID As Long) As BonOrderHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim bonHeaderModel As BonOrderHeaderModel = New BonOrderHeaderModel
        Dim query As String = "Select * From v_BonOrderHeader Where BonOrderID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While dataAccess.reader.Read
                    bonHeaderModel.BonOrderID = .Item("BonOrderID")
                    bonHeaderModel.BonOrderCode = .Item("BonOrderCode")
                    bonHeaderModel.DateIssues = .Item("DateIssues")
                    bonHeaderModel.PIHeaderID = .Item("PIHeaderID")
                    bonHeaderModel.Status = .Item("Status")
                    bonHeaderModel.StatusDesc = .Item("StatusDesc")
                    bonHeaderModel.PINo = .Item("PINo")
                    bonHeaderModel.RefPO = .Item("RefPO")
                    bonHeaderModel.BuyerName = .Item("BuyerName")
                    bonHeaderModel.StyleName = .Item("StyleName")
                    bonHeaderModel.CustomerName = .Item("CustomerName")
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return bonHeaderModel
        Catch ex As Exception
            dataAccess = Nothing
            dataAccess.reader.Close()
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailByID(headerID As Long) As List(Of BonOrderDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BonOrderDetail Where BonOrderID='" & headerID & "'"
        Dim myList As List(Of BonOrderDetailModel) = New List(Of BonOrderDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As BonOrderDetailModel = New BonOrderDetailModel
                    detailModel.BonOrderID = .Item("BonOrderID")
                    detailModel.FabricID = .Item("FabricID")
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.LabsDipsNo = .Item("LabsDipsNo")
                    detailModel.Bruto = .Item("Bruto")
                    detailModel.Netto = .Item("Netto")
                    detailModel.FabricName = .Item("FabricName")
                    detailModel.WidthWeight = .Item("WidthWeight")
                    detailModel.ColorName = .Item("ColorName")
                    myList.Add(detailModel)
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Generated"
    Protected Function GeneratedBonOrderCode(customerCode As String) As String
        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(BonOrderCode) as Code from BonOrderHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("Code")) Then
                myCode = "BON" + "0000001" + "/" + customerCode + "/" + Format(Now.Year)
            Else
                Dim xtahun As String = Microsoft.VisualBasic.Right(dataAccess.reader.Item("Code"), 4)
                If xtahun <> Format(Now.Year) Then
                    Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("Code"), 10)
                    hitung = Microsoft.VisualBasic.Right(xCode, 7) + 1
                    myCode = "BON" & Microsoft.VisualBasic.Right("0000000" & hitung, 7) & "/" & customerCode & "/" & Format(Now.Year)
                Else
                    myCode = "BON" + "0000001" + "/" + customerCode + "/" + Format(Now.Year)
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
        Dim query As String = "Select max(BonOrderID) from BonOrderHeader"
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
    Public Function GetBonOrderCode(customerCode As String) As String
        Dim bonOrderCode As String
        Try
            bonOrderCode = GeneratedBonOrderCode(customerCode)
            Return bonOrderCode
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetBonOrderID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumber()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Set Data Detail"
    Public Function SetDetail(bonOrderID As Long, dgv As DataGridView) As List(Of BonOrderDetailModel)
        Dim listDetailModel As List(Of BonOrderDetailModel) = New List(Of BonOrderDetailModel)
        Try
            For detail = 0 To dgv.Rows.Count - 2
                Dim detailModel As BonOrderDetailModel = New BonOrderDetailModel
                With dgv
                    detailModel.BonOrderID = bonOrderID
                    detailModel.FabricID = .Rows(detail).Cells(6).Value
                    detailModel.ColorID = .Rows(detail).Cells(7).Value
                    detailModel.StyleID = .Rows(detail).Cells(8).Value
                    detailModel.LabsDipsNo = .Rows(detail).Cells(3).Value
                    detailModel.Bruto = .Rows(detail).Cells(4).Value
                    detailModel.Netto = .Rows(detail).Cells(5).Value
                    listDetailModel.Add(detailModel)
                End With
            Next
            Return listDetailModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CRUD"
    Protected Function SqlInsertHeader(headerModel As BonOrderHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into BonOrderHeader(BonOrderID,BonOrderCode,DateIssues,PIHeaderID,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                    "('" & headerModel.BonOrderID & "','" & headerModel.BonOrderCode & "','" & headerModel.DateIssues & "','" & headerModel.PIHeaderID & "'" &
                    ",'" & headerModel.Status & "','" & headerModel.CreatedBy & "','" & headerModel.CreatedDate & "'" &
                    ",'" & headerModel.UpdatedBy & "','" & headerModel.UpdatedDate & "')"
        Return sqlHeader
    End Function

    Protected Function SqlInsertDetail(myModel As BonOrderDetailModel) As String
        Dim sql As String
        sql = "Insert into BonOrderDetail(BonOrderID,FabricID,ColorID,StyleID,LabsDipsNo,Bruto,Netto)Values('" & myModel.BonOrderID & "'" &
            ",'" & myModel.FabricID & "','" & myModel.ColorID & "','" & myModel.StyleID & "','" & myModel.LabsDipsNo & "','" & myModel.Bruto & "','" & myModel.Netto & "')"
        Return sql
    End Function

    Protected Function SqlUpdateHeader(myModel As BonOrderHeaderModel) As String
        Dim SQL As String
        SQL = "Update BonOrderHeader set DateIssues = '" & myModel.DateIssues & "',PIHeaderID = '" & myModel.PIHeaderID & "',Status = '" & myModel.Status & "'" &
              ",UpdatedBy = '" & myModel.UpdatedBy & "',UpdatedDate = '" & myModel.UpdatedDate & "' Where BonOrderID = '" & myModel.BonOrderID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetail(myModel As BonOrderHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From BonOrderDetail Where BonOrderID = '" & myModel.BonOrderID & "'"
        Return SQL
    End Function

    Public Function InsertData(bonHeaderModel As BonOrderHeaderModel, listBonDetail As List(Of BonOrderDetailModel), piModel As PIHeaderModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim piBFC As ClsProformaInvoice = New ClsProformaInvoice

        Dim queryList As List(Of String) = New List(Of String)
        Dim statusInsert As Boolean = False
        'insert header
        queryList.Add(SqlInsertHeader(bonHeaderModel))

        'insert detail
        For Each detail In listBonDetail
            queryList.Add(SqlInsertDetail(detail))
        Next

        'update status proforma invoice
        queryList.Add(piBFC.SqlUpdateStatusHeader(piModel))

        'insert log history
        queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            statusInsert = True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        Return statusInsert
    End Function

    Public Function UpdateData(bonHeaderModel As BonOrderHeaderModel, listBonDetail As List(Of BonOrderDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)
        Dim statusUpdate As Boolean = False
        'delete all detail before update
        queryList.Add(SqlDeleteDetail(bonHeaderModel))

        'update header
        queryList.Add(SqlUpdateHeader(bonHeaderModel))

        'insert detail
        For Each detail In listBonDetail
            queryList.Add(SqlInsertDetail(detail))
        Next

        'insert log history
        queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            statusUpdate = True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        Return statusUpdate
    End Function
#End Region
End Class
