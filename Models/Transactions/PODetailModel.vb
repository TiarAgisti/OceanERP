Public Class PODetailModel
    Private xPOHeaderID As Long
    Public Property POHeaderID() As Long
        Get
            Return xPOHeaderID
        End Get
        Set(ByVal value As Long)
            xPOHeaderID = value
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
    Private xRawMaterialName As String
    Public Property RawMaterialName() As String
        Get
            Return xRawMaterialName
        End Get
        Set(ByVal value As String)
            xRawMaterialName = value
        End Set
    End Property

    Private xUnitID As Integer
    Public Property UnitID() As Integer
        Get
            Return xUnitID
        End Get
        Set(ByVal value As Integer)
            xUnitID = value
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

    Private xPODate As Date
    Public Property PODate() As Date
        Get
            Return xPODate
        End Get
        Set(ByVal value As Date)
            xPODate = value
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

    Private xTotal As Decimal
    Public Property Total() As Decimal
        Get
            Return xTotal
        End Get
        Set(ByVal value As Decimal)
            xTotal = value
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
End Class
