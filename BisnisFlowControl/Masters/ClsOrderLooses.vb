Public Class ClsOrderLooses
    Dim queryloses As String = "Select * From OrderLooses Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String, status As Char) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Order ID"
                queryloses += " AND LoosesID LIKE '%" & param & "%' Order By LoosesID Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryloses)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function RetrieveValueLBS(categoryID As Integer, range As String) As OrderLoosesModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        'Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim dataTable As DataTable = New DataTable
        Dim loosesModel As OrderLoosesModel = New OrderLoosesModel

        Dim query As String = "Select * From OrderLooses WHERE CategoryID='" & categoryID & "' and  [OrderLengthRange(LBS)]= '" & range & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader
                    If Not IsDBNull(.Item("LoosesID")) Then
                        loosesModel.OrderLengthRangeLBS = .Item("OrderLengthRange(LBS)")
                        loosesModel.OrderLengthRangeKG = .Item("OrderLengthRange(KG)")
                        loosesModel.ValueLosses = .Item("ValueLosses(%)")
                    End If
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return loosesModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

    End Function
    Public Function RetrieveValueKG(categoryID As Integer, range As String) As OrderLoosesModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        'Dim rawBFC As ClsRawMaterial = New ClsRawMaterial
        Dim dataTable As DataTable = New DataTable
        Dim loosesModel As OrderLoosesModel = New OrderLoosesModel

        Dim query As String = "Select * From OrderLooses WHERE CategoryID='" & categoryID & "' and  [OrderLengthRange(KG)]= '" & range & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            While dataAccess.reader.Read
                With dataAccess.reader
                    If Not IsDBNull(.Item("LoosesID")) Then
                        loosesModel.OrderLengthRangeLBS = .Item("OrderLengthRange(LBS)")
                        loosesModel.OrderLengthRangeKG = .Item("OrderLengthRange(KG)")
                        loosesModel.ValueLosses = .Item("ValueLosses(%)")
                    End If
                End With
            End While
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return loosesModel
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

    End Function
    Public Function RetrieveByID(loosesID As Integer)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim orderModel As OrderLoosesModel = New OrderLoosesModel

        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryloses)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("LoosesID")) Then
                        orderModel.OrderLengthRangeLBS = .Item("[OrderLengthRange(LBS)]")
                        orderModel.OrderLengthRangeKG = .Item("[OrderLengthRange(KG)]")
                        orderModel.ValueLosses = .Item("[ValueLosses(%)]")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return orderModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Protected Function ListComboBox1() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select DISTINCT [OrderLengthRange(LBS)] From OrderLooses Where  IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxLooses1(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBox1()
            .ValueMember = "OrderLengthRange(LBS)"
            .DisplayMember = "OrderLengthRange(LBS)"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
    Protected Function ListComboBox2() As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select DISTINCT [OrderLengthRange(KG)] From OrderLooses Where IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxLooses2(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBox2()
            .ValueMember = "OrderLengthRange(KG)"
            .DisplayMember = "OrderLengthRange(KG)"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(LoosesID) from OrderLooses"
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
    Public Function InsertOrderLooses(orderloosesModel As OrderLoosesModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into OrderLooses(LoosesID,[OrderLengthRange(LBS)],[OrderLengthRange(KG)],IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & orderloosesModel.LoosesID & "','" & orderloosesModel.OrderLengthRangeLBS & "','" & orderloosesModel.OrderLengthRangeKG & "','" & orderloosesModel.IsActive & "'" &
                                ",'" & orderloosesModel.CreatedBy & "','" & orderloosesModel.CreatedDate & "','" & orderloosesModel.UpdatedBy & "','" & orderloosesModel.UpdatedDate & "')"
        queryList.Add(sql)

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

    Public Function UpdateOrderLooses(orderloosesModel As OrderLoosesModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update OrderLooses Set [OrderLengthRange(LBS)] = '" & orderloosesModel.OrderLengthRangeLBS & "', [OrderLengthRange(KG)] = '" & orderloosesModel.OrderLengthRangeKG & "',IsActive = '" & orderloosesModel.IsActive & "'" &
                    ",UpdatedBy = '" & orderloosesModel.UpdatedBy & "',UpdatedDate = '" & orderloosesModel.UpdatedDate & "' Where LoosesID='" & orderloosesModel.LoosesID & "'"
            queryList.Add(query)

        Else
            query = "Update Destination Set IsActive = '" & orderloosesModel.IsActive & "',UpdatedBy='" & orderloosesModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & orderloosesModel.UpdatedDate & "' Where LoosesID='" & orderloosesModel.LoosesID & "'"
            queryList.Add(query)
        End If

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
