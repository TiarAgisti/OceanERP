Public Class ClsBOM
    Dim query As String = "Select BOMHeaderID,BOMCode,FabricName,Composition,Specification,VendorName,StyleName,ColorName,StatusDesc" &
                               ",FabricID,BuyerID,StyleID,ColorID,StatusBOM From v_BOMHeader Where IsActive <> 0"
#Region "Retrieve"
    Public Function RetrieveListBOM(fabricName As String, styleName As String, colorName As String, statusDesc As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable

        If Not String.IsNullOrEmpty(fabricName) Then
            query += " AND FabricName = '" & fabricName & "'"
        End If

        If Not String.IsNullOrEmpty(styleName) Then
            query += " AND StyleName = '" & styleName & "'"
        End If

        If Not String.IsNullOrEmpty(colorName) Then
            query += " AND ColorName = '" & colorName & "'"
        End If

        If Not String.IsNullOrEmpty(statusDesc) Then
            query += " AND StatusDesc = '" & statusDesc & "'"
        End If

        Try
            dataTable = dataAccess.RetrieveListData(query)
            dataAccess = Nothing
            Return dataTable
        Catch ex As Exception
            Return Nothing
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Generated"
    Protected Function GeneratedAutoNumber() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(BOMHeaderID) from BOMHeader"
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

    Protected Function GeneratedIDBOMDetail() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(BOMDetailID) from BOMDetail"
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
#End Region

#Region "Get ID"
    Public Function GetBOMHeaderID() As Long
        Dim myID As Long
        myID = GeneratedAutoNumber()
        Return myID
    End Function
    Public Function GetBOMDetailID() As Long
        Dim myID As Long
        myID = GeneratedIDBOMDetail()
        Return myID
    End Function
#End Region

#Region "Check Available list"

#End Region

#Region "Set Data Detail"

#End Region

#Region "CRUD"

#End Region
End Class
