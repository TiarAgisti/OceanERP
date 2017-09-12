Public Class StockModel
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

    Private xDocNO As String
    Public Property DocNO() As String
        Get
            Return xDocNO
        End Get
        Set(ByVal value As String)
            xDocNO = value
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

    Private xDoctype As String
    Public Property Doctype() As String
        Get
            Return xDoctype
        End Get
        Set(ByVal value As String)
            xDoctype = value
        End Set
    End Property
End Class
