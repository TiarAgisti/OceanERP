Public Class ClsShipViaMethod
    Dim queryShipViaMethod As String = "Select * From ShipViaMethod Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Select Case options
            Case "Ship Via Method Code"
                queryShipViaMethod += " AND ShipViaMethodCode LIKE '%" & param & "%' Order By ShipViaMethodCode Asc"
            Case "Ship Via Method Name"
                queryShipViaMethod += " AND ShipViaMethodName LIKE '%" & param & "%' Order By ShipViaMethodCode Asc"
            Case "Description"
                queryShipViaMethod += " AND Description LIKE '%" & param & "%' Order By ShipViaMethodCode Asc"
            Case Else
                queryShipViaMethod += " Order By ShipViaMethodCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryShipViaMethod)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function

    Public Function RetrieveByID(shipviamethodID As Integer)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim shipviamethodModel As ShipViaMethodModel = New ShipViaMethodModel
        queryShipViaMethod += " AND ShipViaMethodID = '" & shipviamethodID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryShipViaMethod)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("ShipViaMethodCode")) Then
                        shipviamethodModel.ShipViaMethodcode = .Item("ShipViaMethodCode")
                        shipviamethodModel.ShipViaMethodName = .Item("ShipViaMethodName")
                        shipviamethodModel.Description = .Item("Description")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return shipviamethodModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(ShipViaMethodID) from ShipViaMethod"
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
    Public Function GeneratedCode() As String
        Dim code As String = "SVM"
        Dim hasil As String
        Dim query As String = "Select max(ShipViaMethodCode) as Code from ShipViaMethod"
        Dim dataAccess = New ClsDataAccess
        Try
            hasil = dataAccess.GeneratedCode(query, code)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        dataAccess = Nothing
        Return hasil
    End Function
    Protected Function ListComboBox()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select ShipViaMethodID,ShipViaMethodName From ShipViaMethod Where IsActive = 1"
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
    Protected Function ListComboBoxShipViaMethodCode()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select ShipViaMethodID,ShipViaMethodName From ShipViaMethod Where IsActive = 1"
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
    Public Sub ComboBoxShipViaMethod(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBoxShipViaMethodCode()
                .ValueMember = "ShipViaMethodID"
                .DisplayMember = "ShipViaMethodName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function GetValidateName(shipviamethodName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select ShipViaMethodName From ShipViaMethod Where ShipViaMethodName = '" & shipviamethodName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("shipviamethod Name Can't Duplicate")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertShipViaMethod(shipviamethodModel As ShipViaMethodModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into ShipViaMethod(ShipViaMethodID,ShipViaMethodCode,ShipViaMethodName,Description,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & shipviamethodModel.ShipViaMethodID & "','" & shipviamethodModel.ShipViaMethodCode & "','" & shipviamethodModel.ShipViaMethodName & "','" & shipviamethodModel.Description & "'" &
                                ",'" & shipviamethodModel.IsActive & "','" & shipviamethodModel.CreatedBy & "','" & shipviamethodModel.CreatedDate & "'" &
                                ",'" & shipviamethodModel.UpdatedBy & "','" & shipviamethodModel.UpdatedDate & "')"
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
    Public Function UpdateShipViaMethod(shipviamethodModel As ShipViaMethodModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update ShipViaMethod Set ShipViaMethodName = '" & shipviamethodModel.ShipViaMethodName & "',Description='" & shipviamethodModel.Description & "'" &
                    ",IsActive = '" & shipviamethodModel.IsActive & "',UpdatedBy='" & shipviamethodModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & shipviamethodModel.UpdatedDate & "' Where ShipViaMethodID='" & shipviamethodModel.ShipViaMethodID & "'"
            queryList.Add(query)

        Else
            query = "Update ShipViaMethod Set IsActive = '" & shipviamethodModel.IsActive & "',UpdatedBy='" & shipviamethodModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & shipviamethodModel.UpdatedDate & "' Where ShipViaMethodID='" & shipviamethodModel.ShipViaMethodID & "'"
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
