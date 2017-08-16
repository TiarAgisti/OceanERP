Public Class ClsCOA
    Dim queryCOA As String = "Select CoaID,CoaCode,CoaName,CostCenter,IsActive From COA Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "COA Code"
                queryCOA += " AND CoaCode Like '%" & param & "%' Order By CoaCode Asc"
            Case "COA Name"
                queryCOA += " AND CoaName Like '%" & param & "%' Order By CoaCode Asc"
            Case Else
                queryCOA += " Order By CoaCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryCOA)
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
        Dim query As String = "Select max(CoaID) from COA"
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

        code = "COA"
        query = "Select Max(CoaCode) as Code From COA"


        Try
            hasil = dataAccess.GeneratedCode(query, code)
            dataAccess = Nothing
            Return hasil
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Public Function GetValidateName(coaName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select CoaName From COA Where CoaName = '" & coaName & "' AND IsActive = 1"
        Try
            dataTable = dataAccess.RetrieveListData(query)

            If dataTable.Rows.Count > 0 Then
                Throw New Exception("COA name can't duplicate")
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Method CRUD"
    Public Function InsertCOA(coaModel As COAModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into COA(CoaID,CoaCode,CoaName,CostCenter,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values('" & coaModel.CoaID & "'" &
                            ",'" & coaModel.CoaCode & "','" & coaModel.CoaName & "','" & coaModel.CostCenter & "','" & coaModel.IsActive & "'" &
                            ",'" & coaModel.CreatedBy & "','" & coaModel.CreatedDate & "','" & coaModel.UpdatedBy & "','" & coaModel.UpdatedDate & "')"
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
    Public Function UpdateCOA(coaModel As COAModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update COA set CoaName='" & coaModel.CoaName & "',CostCenter = '" & coaModel.CostCenter & "' Where CoaID = '" & coaModel.CoaID & "'"
            queryList.Add(query)

        Else
            query = "Update COA Set IsActive = '" & coaModel.IsActive & "',UpdatedBy='" & coaModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & coaModel.UpdatedDate & "' Where CoaID='" & coaModel.CoaID & "'"
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
