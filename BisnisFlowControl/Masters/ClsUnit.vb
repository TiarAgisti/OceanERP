﻿Public Class ClsUnit
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Unit Name"
                query = "Select * From Unit Where UnitName LIKE '%" & param & "%' AND IsActive = 1 Order By UnitName Asc"
            Case "Description"
                query = "Select * From Unit Where Description LIKE '%" & param & "%' AND IsActive = 1 Order By UnitName Asc"
            Case Else
                query = "Select * From Unit Where IsActive = 1 Order By UnitName Asc"
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
        Dim query As String = "Select max(UnitID) from Unit"
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

    Public Function GetValidateUnitName(unitName As String) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select UnitName From Unit Where UnitName = '" & unitName & "'"
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

    Public Function InsertUnit(unitModel As UnitModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Unit(UnitID,UnitName,Description,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & unitModel.UnitID & "','" & unitModel.UnitName & "','" & unitModel.Description & "'" &
                                ",'" & unitModel.IsActive & "','" & unitModel.CreatedBy & "','" & unitModel.CreatedDate & "'" &
                                ",'" & unitModel.UpdatedBy & "','" & unitModel.UpdatedDate & "')"
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

    Public Function UpdateUnit(unitModel As UnitModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then
            query = "Update Unit Set UnitName = '" & unitModel.UnitName & "',Description = '" & unitModel.Description & "'" &
                    ",IsActive = '" & unitModel.IsActive & "',UpdatedBy='" & unitModel.UpdatedBy & "',UpdatedDate = '" & unitModel.UpdatedDate & "'" &
                    " Where UnitID='" & unitModel.UnitID & "'"
            queryList.Add(query)

        Else
            query = "Update Unit Set IsActive = '" & unitModel.IsActive & "',UpdatedBy='" & unitModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & unitModel.UpdatedDate & "' Where UnitID='" & unitModel.UnitID & "'"
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