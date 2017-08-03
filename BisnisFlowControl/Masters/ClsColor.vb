Public Class ClsColor
    Dim queryColor As String = "Select * From Colors Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Select Case options
            Case "Color Code"
                queryColor += " AND ColorCode LIKE '%" & param & "%' Order By ColorCode Asc"
            Case "Color Name"
                queryColor += " AND ColorName LIKE '%" & param & "%' Order By ColorCode Asc"
            Case "Description"
                queryColor += " AND Description LIKE '%" & param & "%' Order By ColorCode Asc"
            Case Else
                queryColor += " Order By ColorCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryColor)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function

    Public Function RetrieveByID(colorID As Integer)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim colorModel As ColorModel = New ColorModel
        queryColor += " AND ColorID = '" & colorID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(queryColor)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("ColorCode")) Then
                        colorModel.ColorCode = .Item("ColorCode")
                        colorModel.ColorName = .Item("ColorName")
                        colorModel.Description = .Item("Description")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return colorModel
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
        Dim query As String = "Select max(ColorID) from Colors"
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
        Dim code As String = "COL"
        Dim hasil As String
        Dim query As String = "Select max(ColorCode) as Code from Colors"
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
        query = "Select ColorID,ColorName From Colors Where IsActive = 1"
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
    Protected Function ListComboBoxColorCode()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String
        query = "Select ColorID,ColorCode From Colors Where IsActive = 1"
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
    Public Sub ComboBoxColor(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBoxColorCode()
                .ValueMember = "ColorID"
                .DisplayMember = "ColorCode"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ComboBoxColorYarn(cmb As ComboBox)
        Try
            With cmb
                .DataSource = ListComboBox()
                .ValueMember = "ColorID"
                .DisplayMember = "ColorName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetValidateName(colorName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select ColorName From Colors Where ColorName = '" & colorName & "'"
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
    Public Function InsertColor(colorModel As ColorModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Colors(ColorID,ColorCode,ColorName,Description,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & colorModel.ColorID & "','" & colorModel.ColorCode & "','" & colorModel.ColorName & "','" & colorModel.Description & "'" &
                                ",'" & colorModel.IsActive & "','" & colorModel.CreatedBy & "','" & colorModel.CreatedDate & "'" &
                                ",'" & colorModel.UpdatedBy & "','" & colorModel.UpdatedDate & "')"
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
    Public Function UpdateColor(colorModel As ColorModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Colors Set ColorName = '" & colorModel.ColorName & "',Description='" & colorModel.Description & "'" &
                    ",IsActive = '" & colorModel.IsActive & "',UpdatedBy='" & colorModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & colorModel.UpdatedDate & "' Where ColorID='" & colorModel.ColorID & "'"
            queryList.Add(query)

        Else
            query = "Update Colors Set IsActive = '" & colorModel.IsActive & "',UpdatedBy='" & colorModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & colorModel.UpdatedDate & "' Where ColorID='" & colorModel.ColorID & "'"
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
