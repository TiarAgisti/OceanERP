Public Class ClsVendor
    Dim queryVendor As String = "Select * From v_Vendor Where IsActive = 1"
#Region "Method Retrieve"
    Public Function RetrieveList(options As String, param As String, status As Char) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        Select Case options
            Case "Customer Code"
                queryVendor += " AND VendorCode Like '%" & param & "%' AND Status = '" & status & "' Order By VendorCode Asc"
            Case "Name"
                queryVendor += " AND VendorName LIKE '%" & param & "%' AND Status = '" & status & "' Order By VendorCode Asc"
            Case "Supplier Code"
                queryVendor += " AND VendorCode LIKE '%" & param & "%' AND Status = '" & status & "' Order By VendorCode Asc"
            Case "Address"
                queryVendor += " AND Address LIKE '%" & param & "%' AND Status = '" & status & "' Order By VendorCode Asc"
            Case Else
                queryVendor += " AND Status = '" & status & "' Order By VendorCode Asc"
        End Select

        Try
            dataTable = dataAccess.RetrieveListData(queryVendor)
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try

        dataAccess = Nothing
        Return dataTable
    End Function

    Public Function RetrieveBuyerName(vendorName As String) As VendorModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim vendorModel As VendorModel = New VendorModel
        Dim query As String = "Select VendorID,VendorCode,VendorName from Vendor where Status = 'C' and IsActive = 1" &
                                " And VendorName = '" & vendorName & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("VendorCode")) Then
                        vendorModel.VendorID = .Item("VendorID")
                        vendorModel.VendorCode = .Item("VendorCode")
                        vendorModel.VendorName = .Item("VendorName")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return vendorModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function

    Public Function RetrieveCustomerName(vendorName As String) As VendorModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim vendorModel As VendorModel = New VendorModel
        Dim query As String = "Select VendorID,VendorCode,VendorName,Address,Telephone,Fax,ContactPerson from Vendor where Status = 'C'" &
                                " And IsActive = 1 And VendorName = '" & vendorName & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("VendorCode")) Then
                        vendorModel.VendorID = .Item("VendorID")
                        vendorModel.VendorCode = .Item("VendorCode")
                        vendorModel.VendorName = .Item("VendorName")
                        vendorModel.Address = .Item("Address")
                        vendorModel.Telephone = .Item("Telephone")
                        vendorModel.Fax = .Item("Fax")
                        vendorModel.ContactPerson = .Item("ContactPerson")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return vendorModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function

    Public Function RetrieveVendorByID(vendorID As Long, statusVendor As Char) As VendorModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim vendorModel As VendorModel = New VendorModel
        Dim query As String = "Select VendorID,VendorCode,VendorName,Address,Telephone,Fax,ContactPerson from Vendor where IsActive = 1" &
                                " And VendorID = '" & vendorID & "' AND Status = '" & statusVendor & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    If Not IsDBNull(.Item("VendorCode")) Then
                        vendorModel.VendorID = .Item("VendorID")
                        vendorModel.VendorCode = .Item("VendorCode")
                        vendorModel.VendorName = .Item("VendorName")
                        vendorModel.Address = .Item("Address")
                        vendorModel.Telephone = .Item("Telephone")
                        vendorModel.Fax = .Item("Fax")
                        vendorModel.ContactPerson = .Item("ContactPerson")
                    End If
                End While
                .Close()
            End With
            dataAccess = Nothing
            Return vendorModel
        Catch ex As Exception
            dataAccess = Nothing
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Method Other"
    Protected Function ListComboBoxVendor(status As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select VendorID,VendorName From Vendor Where Status='" & status & "' AND IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Protected Function ListComboBoxAll()
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String
        query = "Select VendorID,VendorName From Vendor Where IsActive = 1"

        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxVendor(cmb As ComboBox, statusVendor As String)
        With cmb
            .DataSource = ListComboBoxVendor(statusVendor)
            .DisplayMember = "VendorName"
            .ValueMember = "VendorID"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
    Public Sub ComboBoxAllVendor(cmb As ComboBox)
        With cmb
            .DataSource = ListComboBoxAll()
            .DisplayMember = "VendorName"
            .ValueMember = "VendorID"
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub
    Public Function GeneratedAutoNumber() As Integer
        Dim id As Integer = 0
        Dim query As String = "Select max(VendorID) from Vendor"
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
    Public Function GeneratedCode(status As Char) As String
        Dim code As String
        Dim hasil As String
        Dim query As String
        Dim dataAccess = New ClsDataAccess

        If status = "C" Then
            code = "CUS"
            query = "Select Max(VendorCode) as Code From Vendor Where Status = 'C'"
        Else
            code = "SUP"
            query = "Select Max(VendorCode) as Code From Vendor Where Status = 'S'"
        End If


        Try
            hasil = dataAccess.GeneratedCode(query, code)
            dataAccess = Nothing
            Return hasil
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function GetValidateName(vendorName As String, status As Char) As Boolean
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select VendorName From Vendor Where VendorName = '" & vendorName & "' AND Status='" & status & "'"
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

#Region "Method CRUD"
    Public Function InsertVendor(vendorModel As VendorModel, logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)

        Dim sql As String = "Insert into Vendor(VendorID,VendorCode,VendorName,Address,ShippingAddress,Telephone,Fax,ContactPerson,EmailCP,Npwp" &
                            ",TermOfPaymentID,Status,DestinationID,IsActive,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values(" &
                                "'" & vendorModel.VendorID & "','" & vendorModel.VendorCode & "','" & vendorModel.VendorName & "','" & vendorModel.Address & "'" &
                                ",'" & vendorModel.ShippingAddress & "','" & vendorModel.Telephone & "','" & vendorModel.Fax & "','" & vendorModel.ContactPerson & "'" &
                                ",'" & vendorModel.EmailCP & "','" & vendorModel.Npwp & "','" & vendorModel.TermOfPaymentID & "','" & vendorModel.Status & "'" &
                                ",'" & vendorModel.DestinationID & "','" & vendorModel.IsActive & "','" & vendorModel.CreatedBy & "','" & vendorModel.CreatedDate & "'" &
                                ",'" & vendorModel.UpdatedBy & "','" & vendorModel.UpdatedDate & "')"
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
    Public Function UpdateVendor(vendorModel As VendorModel, logModel As LogHistoryModel, options As String) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As New List(Of String)
        Dim query As String

        If options = "Update" Then

            query = "Update Vendor Set VendorName = '" & vendorModel.VendorName & "',Address='" & vendorModel.Address & "'" &
                    ",ShippingAddress='" & vendorModel.ShippingAddress & "',Telephone='" & vendorModel.Telephone & "'" &
                    ",Fax='" & vendorModel.Fax & "',ContactPerson='" & vendorModel.ContactPerson & "',EmailCP='" & vendorModel.EmailCP & "'" &
                    ",Npwp='" & vendorModel.Npwp & "',TermOfPaymentID='" & vendorModel.TermOfPaymentID & "',DestinationID='" & vendorModel.DestinationID & "'" &
                    ",IsActive = '" & vendorModel.IsActive & "',UpdatedBy = '" & vendorModel.UpdatedBy & "',UpdatedDate = '" & vendorModel.UpdatedDate & "'" &
                    " Where VendorID='" & vendorModel.VendorID & "'"
            queryList.Add(query)

        Else
            query = "Update Vendor Set IsActive = '" & vendorModel.IsActive & "',UpdatedBy='" & vendorModel.UpdatedBy & "'" &
                    ",UpdatedDate = '" & vendorModel.UpdatedDate & "' Where VendorID='" & vendorModel.VendorID & "'"
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
