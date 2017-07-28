Public Class ClsRawMaterial
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Raw Material Code"
                query = "Select * From v_RawMaterial Where RawMaterialCode Like '%" & param & "%' AND IsActive = 1 Order By RawMaterialCode Asc"
            Case "Raw Material Name"
                query = "Select * From v_RawMaterial Where RawMaterialName Like '%" & param & "%' AND IsActive = 1 Order By RawMaterialCode Asc"
            Case "Supplier"
                query = "Select * From v_RawMaterial Where VendorName Like '%" & param & "%' AND IsActive = 1 Order By RawMaterialCode Asc"
            Case Else
                query = "Select * From v_RawMaterial Where IsActive = 1 Order By RawMaterialCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
#End Region

#Region "Method Other"
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(RawMaterialID) from RawMaterial"
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
        Dim code As String
        Dim hasil As String
        Dim query As String
        Dim dataAccess = New ClsDataAccess

        code = "RMS"
        query = "Select Max(RawMaterialCode) as Code From RawMaterial"


        Try
            hasil = dataAccess.GeneratedCode(query, code)
            dataAccess = Nothing
            Return hasil
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function ListComboBox() As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select RawMaterialID,RawMaterialName From RawMaterial Where IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function

    Public Sub ComboBoxRawMaterial(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBox()
            .DisplayMember = "RawMaterialName"
            .ValueMember = "RawMaterialID"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Public Function GetValidateName(rawMaterialName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select RawMaterialName From RawMaterial Where RawMaterialName = '" & rawMaterialName & "'"
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
#End Region

#Region "Insert & Update"
    Public Function InsertData(rawMaterialModel As RawMaterialModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into RawMaterial(RawMaterialID,RawMaterialCode,RawMaterialName,VendorID,SpecRawMaterial,IsActive" &
                                ",CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values('" & rawMaterialModel.RawMaterialID & "'" &
                                ",'" & rawMaterialModel.RawMaterialCode & "','" & rawMaterialModel.RawMaterialName & "'" &
                                ",'" & rawMaterialModel.VendorID & "','" & rawMaterialModel.SpecRawMaterial & "'" &
                                ",'" & rawMaterialModel.IsActive & "','" & rawMaterialModel.CreatedBy & "','" & rawMaterialModel.CreatedDate & "'" &
                                ",'" & rawMaterialModel.UpdatedBy & "','" & rawMaterialModel.UpdatedDate & "')"
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
    Public Function UpdateData(rawMaterialModel As RawMaterialModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update RawMaterial Set RawMaterialName = '" & rawMaterialModel.RawMaterialName & "',VendorID = '" & rawMaterialModel.VendorID & "'" &
                    ",SpecRawMaterial = '" & rawMaterialModel.SpecRawMaterial & "',IsActive = '" & rawMaterialModel.IsActive & "'" &
                    ",UpdatedBy='" & rawMaterialModel.UpdatedBy & "',UpdatedDate = '" & rawMaterialModel.UpdatedDate & "'" &
                    " Where RawMaterialID='" & rawMaterialModel.RawMaterialID & "'"
            queryList.Add(query)

        Else
            query = "Update RawMaterial Set IsActive = '" & rawMaterialModel.IsActive & "',UpdatedBy='" & rawMaterialModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & rawMaterialModel.UpdatedDate & "' Where RawMaterialID='" & rawMaterialModel.RawMaterialID & "'"
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
