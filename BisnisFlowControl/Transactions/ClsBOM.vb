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
                myCode = "BOM" + "000001" + "/" + buyerCode + "/" + Format(Now.Year)
            Else
                Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("BOMCode"), 9)
                hitung = Microsoft.VisualBasic.Right(xCode, 6) + 1
                myCode = "BOM" & Microsoft.VisualBasic.Right("000000" & hitung, 6) & "/" & buyerCode & "/" & Format(Now.Year)
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
                End With
            Next
            Return listDetailModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CRUD"

#End Region
End Class
