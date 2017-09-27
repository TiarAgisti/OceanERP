Public Class StockModel
    Private xStockID As Long
    Public Property StockID() As Long
        Get
            Return xStockID
        End Get
        Set(ByVal value As Long)
            xStockID = value
        End Set
    End Property
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property
    Private xPINo As String
    Public Property PINo() As String
        Get
            Return xPINo
        End Get
        Set(ByVal value As String)
            xPINo = value
        End Set
    End Property
    Private xRawMaterialID As Integer
    Public Property RawMaterialID() As Integer
        Get
            Return xRawMaterialID
        End Get
        Set(ByVal value As Integer)
            xRawMaterialID = value
        End Set
    End Property
    Private xRawMaterialName As String
    Public Property RawMaterialName() As String
        Get
            Return xRawMaterialName
        End Get
        Set(ByVal value As String)
            xRawMaterialName = value
        End Set
    End Property
    Private xQuantityIN As Integer
    Public Property QuantityIN() As Integer
        Get
            Return xQuantityIN
        End Get
        Set(ByVal value As Integer)
            xQuantityIN = value
        End Set
    End Property
    Private xQuantityOUT As Integer
    Public Property QuantityOUT() As Integer
        Get
            Return xQuantityOUT
        End Get
        Set(ByVal value As Integer)
            xQuantityOUT = value
        End Set
    End Property

    Private xDocID As Long
    Public Property DocID() As Long
        Get
            Return xDocID
        End Get
        Set(ByVal value As Long)
            xDocID = value
        End Set
    End Property

    Private xDocDate As Date
    Public Property DocDate() As Date
        Get
            Return xDocDate
        End Get
        Set(ByVal value As Date)
            xDocDate = value
        End Set
    End Property

    Private xDocType As String
    Public Property DocType() As String
        Get
            Return xDocType
        End Get
        Set(ByVal value As String)
            xDocType = value
        End Set
    End Property

    Private xQuantityStock As Integer
    Public Property QuantityStock() As Integer
        Get
            Return xQuantityStock
        End Get
        Set(ByVal value As Integer)
            xQuantityStock = value
        End Set
    End Property
End Class
