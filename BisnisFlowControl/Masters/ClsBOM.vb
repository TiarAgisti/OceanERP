Public Class ClsBOM
    Dim query As String = "Select BOMHeaderID,BOMCode,FabricName,Composition,Specification,VendorName,StyleName,ColorName,StatusDesc" &
                               ",FabricID,BuyerID,StyleID,ColorID,StatusBOM From v_BOMHeader Where IsActive <> 0"
#Region "Retrieve"
    Public Function RetrieveListBOM(fabricName As String, styleName As String, colorName As String, statusDesc As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        If Not String.IsNullOrEmpty(fabricName) Then
            query += " AND FabricName = '" & fabricName & "'"
        End If

        If Not String.IsNullOrEmpty(styleName) Then
            query += " AND StyleName = '" & styleName & "'"
        End If

        If Not String.IsNullOrEmpty(colorName) Then
            query += " AND ColorName = '" & colorName & "'"
        End If

        If Not String.IsNullOrEmpty(statusDesc) Then
            query += " AND StatusDesc = '" & statusDesc & "'"
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

    Public Function RetrieveByID(headerID As Long) As BOMHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim bomHeaderModel As BOMHeaderModel = New BOMHeaderModel
        Dim query As String = "Select * From v_BOMHeader Where BOMHeaderID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    bomHeaderModel.BOMHeaderID = headerID
                    bomHeaderModel.BOMCode = .Item("BOMCode")
                    bomHeaderModel.FabricID = .Item("FabricID")
                    bomHeaderModel.BuyerID = .Item("BuyerID")
                    bomHeaderModel.StyleID = .Item("StyleID")
                    bomHeaderModel.ColorID = .Item("ColorID")
                    bomHeaderModel.StatusBOM = .Item("StatusBOM")
                    bomHeaderModel.IsActive = .Item("IsActive")
                    bomHeaderModel.StatusDesc = .Item("StatusDesc")
                    bomHeaderModel.FabricName = .Item("FabricName")
                    bomHeaderModel.Composition = .Item("Composition")
                    bomHeaderModel.Specification = .Item("Specification")
                    bomHeaderModel.VendorName = .Item("VendorName")
                    bomHeaderModel.StyleName = .Item("StyleName")
                    bomHeaderModel.ColorName = .Item("ColorName")
                End While
            End With
            Return bomHeaderModel
        Catch ex As Exception
            Throw ex
        Finally
            dataAccess.reader.Close()
            dataAccess = Nothing
        End Try
    End Function

    Public Function RetrieveDetailByHeaderID(headerID As Long) As List(Of BOMDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BOMDetail Where BOMHeaderID='" & headerID & "'"
        Dim myList As List(Of BOMDetailModel) = New List(Of BOMDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim bomDetailModel As BOMDetailModel = New BOMDetailModel
                    bomDetailModel.BOMHeaderID = .Item("BOMHeaderID")
                    bomDetailModel.BOMDetailID = .Item("BOMDetailID")
                    bomDetailModel.RawMaterialID = .Item("RawMaterialID")
                    bomDetailModel.UnitID = .Item("UnitID")
                    bomDetailModel.Qty = .Item("Qty")
                    bomDetailModel.RawMaterialName = .Item("RawMaterialName")
                    bomDetailModel.SpecRawMaterial = .Item("SpecRawMaterial")
                    bomDetailModel.VendorName = .Item("VendorName")
                    bomDetailModel.UnitName = .Item("UnitName")
                    myList.Add(bomDetailModel)
                End While
            End With
            Return myList
        Catch ex As Exception
            Throw ex
        Finally
            dataAccess.reader.Close()
            dataAccess = Nothing
        End Try
    End Function
#End Region

#Region "Function"
    Public Sub ComboBoxStatus(cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("Production")
        cmb.Items.Add("Development")
    End Sub
#End Region

#Region "Generated"
    Protected Function GeneratedBOMCode(buyerCode As String) As String
        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(BOMCode) as BOMCode from BOMHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("BOMCode")) Then
                myCode = "BOM" + "0000001" + "/" + buyerCode + "/" + Format(Now.Year)
            Else
                Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("BOMCode"), 10)
                hitung = Microsoft.VisualBasic.Right(xCode, 7) + 1
                myCode = "BOM" & Microsoft.VisualBasic.Right("0000000" & hitung, 7) & "/" & buyerCode & "/" & Format(Now.Year)
            End If
            Return myCode
        Catch ex As Exception
            Throw ex
        Finally
            dataAccess.reader.Close()
            dataAccess = Nothing
        End Try
    End Function
    Protected Function GeneratedAutoNumber() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(BOMHeaderID) from BOMHeader"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            Return id
        Catch ex As Exception
            Throw ex
        Finally
            dataAccess = Nothing
        End Try
    End Function

    Protected Function GeneratedIDBOMDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(BOMDetailID) from BOMDetail"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            Return id
        Catch ex As Exception
            Throw ex
        Finally
            dataAccess = Nothing
        End Try
    End Function
#End Region

#Region "Get"
    Public Function GetBOMCode(buyerCode As String) As String
        Dim bomCode As String
        Try
            bomCode = GeneratedBOMCode(buyerCode)
            Return bomCode
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetBOMHeaderID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumber()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetBOMDetailID() As Long
        Dim myID As Long
        Try
            myID = GeneratedIDBOMDetail()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Check Available list"
    Public Function CheckDetailInList(dgv As DataGridView, bomHeaderID As Integer) As Boolean
        Dim check As Integer
        Dim status As Boolean = True
        Try
            For cek = 0 To dgv.Rows.Count - 1
                If dgv.Rows(check).Cells(0).Value = bomHeaderID Then
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
    Public Function SetDetail(bomID As Long, dgv As DataGridView) As List(Of BOMDetailModel)
        Dim listDetailModel As List(Of BOMDetailModel) = New List(Of BOMDetailModel)
        Dim bomDetailID As Long
        Try
            bomDetailID = GetBOMDetailID()
            For detail = 0 To dgv.Rows.Count - 2
                Dim detailModel As BOMDetailModel = New BOMDetailModel
                With dgv
                    detailModel.BOMHeaderID = bomID
                    detailModel.BOMDetailID = bomDetailID
                    detailModel.RawMaterialID = .Rows(detail).Cells(0).Value
                    detailModel.UnitID = .Rows(detail).Cells(4).Value
                    detailModel.Qty = .Rows(detail).Cells(6).Value
                    listDetailModel.Add(detailModel)
                End With
                bomDetailID = bomDetailID + 1
            Next
            Return listDetailModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CRUD"
    Protected Function SqlInsertHeader(bomHeaderModel As BOMHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into BOMHeader(BOMHeaderID,BOMCode,FabricID,BuyerID,StyleID,ColorID,StatusBOM,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                    "('" & bomHeaderModel.BOMHeaderID & "','" & bomHeaderModel.BOMCode & "','" & bomHeaderModel.FabricID & "'" &
                    ",'" & bomHeaderModel.BuyerID & "','" & bomHeaderModel.StyleID & "','" & bomHeaderModel.ColorID & "'" &
                    ",'" & bomHeaderModel.StatusBOM & "','" & bomHeaderModel.IsActive & "','" & bomHeaderModel.CreatedBy & "'" &
                    ",'" & bomHeaderModel.CreatedDate & "','" & bomHeaderModel.UpdatedBy & "','" & bomHeaderModel.UpdatedDate & "')"
        Return sqlHeader
    End Function
    Protected Function SqlInsertDetail(myModel As BOMDetailModel) As String
        Dim sql As String
        sql = "Insert into BOMDetail(BOMHeaderID,BOMDetailID,RawMaterialID,UnitID,Qty)Values('" & myModel.BOMHeaderID & "'" &
            ",'" & myModel.BOMDetailID & "','" & myModel.RawMaterialID & "','" & myModel.UnitID & "','" & myModel.Qty & "')"
        Return sql
    End Function
    Protected Function SqlUpdateHeader(myModel As BOMHeaderModel) As String
        Dim SQL As String
        SQL = "Update BOMHeader set FabricID = '" & myModel.FabricID & "',BuyerID = '" & myModel.BuyerID & "',StyleID = '" & myModel.StyleID & "'" &
              ",ColorID = '" & myModel.ColorID & "',StatusBOM = '" & myModel.StatusBOM & "',IsActive = '" & myModel.IsActive & "',UpdatedBy = '" & myModel.UpdatedBy & "'" &
              ",UpdatedDate = '" & myModel.UpdatedDate & "' Where BOMHeaderID = '" & myModel.BOMHeaderID & "'"
        Return SQL
    End Function
    Protected Function SqlDeleteDetail(myModel As BOMHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From BOMDetail Where BOMHeaderID = '" & myModel.BOMHeaderID & "'"
        Return SQL
    End Function
    Public Function InsertData(bomHeaderModel As BOMHeaderModel, listBomDetail As List(Of BOMDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)
        Dim statusInsert As Boolean = False
        'insert header
        queryList.Add(SqlInsertHeader(bomHeaderModel))

        'insert detail
        For Each detail In listBomDetail
            queryList.Add(SqlInsertDetail(detail))
        Next

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

    Public Function UpdateData(bomHeaderModel As BOMHeaderModel, listBomDetail As List(Of BOMDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)
        Dim statusUpdate As Boolean = False
        'delete all detail before update
        queryList.Add(SqlDeleteDetail(bomHeaderModel))

        'update header
        queryList.Add(SqlUpdateHeader(bomHeaderModel))

        'insert detail
        For Each detail In listBomDetail
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
