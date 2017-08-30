Public Class POPrintOutModel
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
            Return xRawMaterialID
        End Get
        Set(ByVal value As String)
            xRawMaterialID = value
        End Set
    End Property
    Private xUnitName As String
    Public Property UnitName() As String
        Get
            Return xUnitName
        End Get
        Set(ByVal value As String)
            xUnitName = value
        End Set
    End Property
    Private xPODate As Date
    Public Property PODate() As Date
        Get
            Return xPODate
        End Get
        Set(ByVal value As Date)
            xPODate = value
        End Set
    End Property
    Private xPONo As String
    Public Property PONo() As String
        Get
            Return xPONo
        End Get
        Set(ByVal value As String)
            xPONo = value
        End Set
    End Property

    Private xQuantity As Integer
    Public Property Quantity() As Integer
        Get
            Return xQuantity
        End Get
        Set(ByVal value As Integer)
            xQuantity = value
        End Set
    End Property
    Private xUnitPrice As Decimal
    Public Property UnitPrice() As Decimal
        Get
            Return xUnitPrice
        End Get
        Set(ByVal value As Decimal)
            xUnitPrice = value
        End Set
    End Property
    Private xTotal As Decimal
    Public Property Total() As Decimal
        Get
            Return xTotal
        End Get
        Set(ByVal value As Decimal)
            xTotal = value
        End Set
    End Property
End Class
