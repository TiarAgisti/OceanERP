Public Class ClsFabric
    Dim queryFabric As String = "Select FabricID,FabricCode,FabricName,Composition,Specification,VendorName,VendorID,IsActive From v_Fabric" &
                        " Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable

        Select Case options
            Case "Fabric Code"
                queryFabric += " AND FabricCode Like '%" & param & "%' Order By FabricCode Asc"
            Case "Fabric Name"
                queryFabric += " AND FabricName Like '%" & param & "%' Order By FabricCode Asc"
            Case Else
                queryFabric += " Order By FabricCode ASC"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryFabric)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function

    Public Function RetrieveByID(fabricID As Integer) As FabricModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim fabricModel As FabricModel = New FabricModel
        queryFabric += " AND FabricID = '" & fabricID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryFabric)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("FabricCode")) Then
                        fabricModel.FabricID = .Item("FabricID")
                        fabricModel.FabricCode = .Item("FabricCode")
                        fabricModel.FabricName = .Item("FabricName")
                        fabricModel.Composition = .Item("Composition")
                        fabricModel.Specification = .Item("Specification")
                        fabricModel.VendorName = .Item("VendorName")
                        fabricModel.VendorID = .Item("VendorID")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return fabricModel
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
        Dim query As String = "Select max(FabricID) from Fabric"
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
        Dim code As String = "FAB"
        Dim hasil As String
        Dim query As String = "Select max(FabricCode) as Code from Fabric"
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
    Public Function GetValidateName(fabricName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select FabricName From Fabric Where FabricName = '" & fabricName & "'"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Protected Function ListComboBox() As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select FabricID,FabricName From Fabric where IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxFabric(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "FabricID"
                .DisplayMember = "FabricName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Method CRUD"
    Public Function InsertFabric(fabricModel As FabricModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Fabric(FabricID,FabricCode,FabricName,Composition,Specification,VendorID,IsActive,CreatedBy" &
                                ",CreatedDate,UpdatedBy,UpdatedDate)Values('" & fabricModel.FabricID & "','" & fabricModel.FabricCode & "'" &
                                ",'" & fabricModel.FabricName & "','" & fabricModel.Composition & "','" & fabricModel.Specification & "'" &
                                ",'" & fabricModel.VendorID & "','" & fabricModel.IsActive & "','" & fabricModel.CreatedBy & "'" &
                                ",'" & fabricModel.CreatedDate & "','" & fabricModel.UpdatedBy & "','" & fabricModel.UpdatedDate & "')"
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

    Public Function UpdateFabric(fabricModel As FabricModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Fabric Set FabricName = '" & fabricModel.FabricName & "',Composition = '" & fabricModel.Composition & "'" &
                    ",Specification = '" & fabricModel.Specification & "',VendorID='" & fabricModel.VendorID & "',IsActive = '" & fabricModel.IsActive & "'" &
                    ",UpdatedBy='" & fabricModel.UpdatedBy & "',UpdatedDate = '" & fabricModel.UpdatedDate & "' Where FabricID='" & fabricModel.FabricID & "'"
            queryList.Add(query)

        Else
            query = "Update Fabric Set IsActive = '" & fabricModel.IsActive & "',UpdatedBy='" & fabricModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & fabricModel.UpdatedDate & "' Where FabricID='" & fabricModel.FabricID & "'"
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
