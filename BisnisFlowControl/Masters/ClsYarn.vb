Public Class ClsYarn
    Dim queryYarn As String = "Select * From v_Yarn Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Yarn Code"
                queryYarn += " AND YarnCode Like '%" & param & "%' Order By YarnCode Asc"
            Case "Yarn Name"
                queryYarn += " AND YarnName Like '%" & param & "%' Order By YarnCode Asc"
            Case "Supplier"
                queryYarn += " AND VendorName Like '%" & param & "%' Order By YarnCode Asc"
            Case Else
                queryYarn += " Order By YarnCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryYarn)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function
    Public Function RetrieveByID(yarnID As Integer) As YarnModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim yarnModel As YarnModel = New YarnModel
        queryYarn += " AND YarnID = '" & yarnID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryYarn)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("YarnCode")) Then
                        yarnModel.YarnCode = .Item("YarnCode")
                        yarnModel.YarnName = .Item("YarnName")
                        yarnModel.VendorID = .Item("VendorID")
                        yarnModel.SpecYarn = .Item("SpecYarn")
                        yarnModel.IsActive = .Item("IsActive")
                        yarnModel.VendorName = .Item("VendorName")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return yarnModel
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
        Dim query As String = "Select max(YarnID) from Yarn"
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

        code = "YRN"
        query = "Select Max(YarnCode) as Code From Yarn"


        Try
            hasil = dataAccess.GeneratedCode(query, code)
            dataAccess = Nothing
            Return hasil
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function GetValidateName(yarnName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select YarnName From Yarn Where YarnName = '" & yarnName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("Yarn name can't duplicate")
            Else
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Protected Function ListComboBox()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select YarnID,YarnName From Yarn Where IsActive = 1"
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

    Public Sub ComboBoxYarn(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "YarnID"
                .DisplayMember = "YarnName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Method CRUD"
    Public Function InsertYarn(yarnModel As YarnModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Yarn(YarnID,YarnCode,YarnName,VendorID,SpecYarn,IsActive,CreatedBy,CreatedDate" &
                            ",UpdatedBy,UpdatedDate)Values('" & yarnModel.YarnID & "','" & yarnModel.YarnCode & "','" & yarnModel.YarnName & "'" &
                            ",'" & yarnModel.VendorID & "','" & yarnModel.SpecYarn & "','" & yarnModel.IsActive & "'" &
                            ",'" & yarnModel.CreatedBy & "','" & Format(yarnModel.CreatedDate, "yyyy-MM-dd HH:mm:ss") & "','" & yarnModel.UpdatedBy & "','" & Format(yarnModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "')"
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

    Public Function UpdateYarn(yarnModel As YarnModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update Yarn set YarnName='" & yarnModel.YarnName & "',VendorID = '" & yarnModel.VendorID & "',SpecYarn='" & yarnModel.SpecYarn & "'" &
                        " Where YarnID = '" & yarnModel.YarnID & "'"
            queryList.Add(query)

        Else
            query = "Update Yarn Set IsActive = '" & yarnModel.IsActive & "',UpdatedBy='" & yarnModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & Format(yarnModel.UpdatedDate, "yyyy-MM-dd HH:mm:ss") & "' Where YarnID='" & yarnModel.YarnID & "'"
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
