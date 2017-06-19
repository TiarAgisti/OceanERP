﻿Public Class ClsColor
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Color Code"
                query = "Select * From Colors Where ColorCode LIKE '%" & param & "%' AND IsActive = 1 Order By ColorCode Asc"
            Case "Color Name"
                query = "Select * From Colors Where ColorName LIKE '%" & param & "%' AND IsActive = 1 Order By ColorCode Asc"
            Case "Description"
                query = "Select * From Colors Where Description LIKE '%" & param & "%' AND IsActive = 1 Order By ColorCode Asc"
            Case Else
                query = "Select * From Colors Where IsActive = 1 Order By ColorCode Asc"
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
End Class