﻿Public Class ClsFabric
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Fabric Code"
                query = "Select * From Fabric Where FabricCode LIKE '%" & param & "%' AND IsActive = 1 Order By FabricCode Asc"
            Case "Fabric Name"
                query = "Select * From Fabric Where FabricName LIKE '%" & param & "%' AND IsActive = 1 Order By FabricCode Asc"
            Case Else
                query = "Select * From Fabric Where IsActive = 1 Order By FabricCode Asc"
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

    Public Function InsertFabric(fabricModel As FabricModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Fabric(FabricID,FabricCode,FabricName,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & fabricModel.FabricID & "','" & fabricModel.FabricCode & "','" & fabricModel.FabricName & "'" &
                                ",'" & fabricModel.IsActive & "','" & fabricModel.CreatedBy & "','" & fabricModel.CreatedDate & "'" &
                                ",'" & fabricModel.UpdatedBy & "','" & fabricModel.UpdatedDate & "')"
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
            query = "Update Fabric Set FabricName = '" & fabricModel.FabricName & "',IsActive = '" & fabricModel.IsActive & "'" &
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
End Class