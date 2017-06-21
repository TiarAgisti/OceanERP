Public Class ClsCOA
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "COA Code"
                query = "Select CoaID,CoaCode,CoaName,CostCenter,IsActive From COA Where CoaCode Like '%" & param & "%' AND IsActive = 1 Order By CoaCode Asc"
            Case "COA Name"
                query = "Select CoaID,CoaCode,CoaName,CostCenter,IsActive From COA Where CoaName Like '%" & param & "%' AND IsActive = 1 Order By CoaCode Asc"
            Case Else
                query = "Select CoaID,CoaCode,CoaName,CostCenter,IsActive From COA Where IsActive = 1 Order By CoaCode Asc"
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
End Class
