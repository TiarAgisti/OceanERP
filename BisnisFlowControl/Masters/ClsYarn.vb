﻿Public Class ClsYarn
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = ""

        Select Case options
            Case "Yarn Code"
                query = "Select * From v_Yarn Where YarnCode Like '%" & param & "%' AND IsActive = 1 Order By YarnCode Asc"
            Case "Yarn Name"
                query = "Select * From v_Yarn Where YarnName Like '%" & param & "%' AND IsActive = 1 Order By YarnCode Asc"
            Case "Supplier"
                query = "Select * From v_Yarn Where VendorName Like '%" & param & "%' AND IsActive = 1 Order By YarnCode Asc"
            Case Else
                query = "Select * From v_Yarn Where IsActive = 1 Order By YarnCode Asc"
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
        Dim query As String = "Select YarnName From Yarn Where YarnName = '" & yarnName & "'"
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
                            ",'" & yarnModel.CreatedBy & "','" & yarnModel.CreatedDate & "','" & yarnModel.UpdatedBy & "','" & yarnModel.UpdatedDate & "')"
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
                    ",UpdatedDate = '" & yarnModel.UpdatedDate & "' Where YarnID='" & yarnModel.YarnID & "'"
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
