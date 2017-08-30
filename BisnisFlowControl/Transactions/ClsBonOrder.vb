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
        Dim query As String = "Select * From v_PIHeader Where PIHeaderID='" & headerID & "'"
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
            Return bonHeaderModel
        Catch ex As Exception
            Throw ex
        Finally
            dataAccess = Nothing
            dataAccess.reader.Close()
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
        Return myCode
    End Function
#End Region

#Region "Get"

#End Region

#Region "Set Data Detail"

#End Region

#Region "CRUD"

#End Region
End Class
