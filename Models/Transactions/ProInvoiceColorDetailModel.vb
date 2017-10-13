Public Class ProInvoiceColorDetailModel
    Private xBOID As Long
    Public Property BOID() As Long
        Get
            Return xBOID
        End Get
        Set(ByVal value As Long)
            xBOID = value
        End Set
    End Property
    Private xNoOrder As String
    Public Property NoOrder() As String
        Get
            Return xNoOrder
        End Get
        Set(ByVal value As String)
            xNoOrder = value
        End Set
    End Property
    Private xFabricID As Integer
    Public Property FabricID() As Integer
        Get
            Return xFabricID
        End Get
        Set(ByVal value As Integer)
            xFabricID = value
        End Set
    End Property
    Private xFabricName As String
    Public Property FabricName() As String
        Get
            Return xFabricName
        End Get
        Set(ByVal value As String)
            xFabricName = value
        End Set
    End Property
    Private xColorID As Integer
    Public Property ColorID() As Integer
        Get
            Return xColorID
        End Get
        Set(ByVal value As Integer)
            xColorID = value
        End Set
    End Property

    Private xColorType As String
    Public Property ColorType() As String
        Get
            Return xColorType
        End Get
        Set(ByVal value As String)
            xColorType = value
        End Set
    End Property

    Private xColorLabNumber As String
    Public Property ColorLabNumber() As String
        Get
            Return xColorLabNumber
        End Get
        Set(ByVal value As String)
            xColorLabNumber = value
        End Set
    End Property

    Private xQtyOrder As Double
    Public Property QtyOrder() As Double
        Get
            Return xQtyOrder
        End Get
        Set(ByVal value As Double)
            xQtyOrder = value
        End Set
    End Property
    Private xNetto As Double
    Public Property Netto() As Double
        Get
            Return xNetto
        End Get
        Set(ByVal value As Double)
            xNetto = value
        End Set
    End Property
    Private xPurchSizeID As Integer
    Public Property PurchSizeID() As Integer
        Get
            Return xPurchSizeID
        End Get
        Set(ByVal value As Integer)
            xPurchSizeID = value
        End Set
    End Property

    Private xPrice As Double
    Public Property Price() As Double
        Get
            Return xPrice
        End Get
        Set(ByVal value As Double)
            xPrice = value
        End Set
    End Property

    Private xQtySample As Double
    Public Property QtySample() As Double
        Get
            Return xQtySample
        End Get
        Set(ByVal value As Double)
            xQtySample = value
        End Set
    End Property

    Private xDelDate As Date
    Public Property DelDate() As Date
        Get
            Return xDelDate
        End Get
        Set(ByVal value As Date)
            xDelDate = value
        End Set
    End Property

    Private xNote As String
    Public Property Note() As String
        Get
            Return xNote
        End Get
        Set(ByVal value As String)
            xNote = value
        End Set
    End Property


    Private xColorCode As String
    Public Property ColorCode() As String
        Get
            Return xColorCode
        End Get
        Set(ByVal value As String)
            xColorCode = value
        End Set
    End Property

    Private xColorName As String
    Public Property ColorName() As String
        Get
            Return xColorName
        End Get
        Set(ByVal value As String)
            xColorName = value
        End Set
    End Property

    Private xPurchSizeName As String
    Public Property PurchSizeName() As String
        Get
            Return xPurchSizeName
        End Get
        Set(ByVal value As String)
            xPurchSizeName = value
        End Set
    End Property

    Private xCurrencyID As Integer
    Public Property CurrencyID() As Integer
        Get
            Return xCurrencyID
        End Get
        Set(ByVal value As Integer)
            xCurrencyID = value
        End Set
    End Property
    Private xCurrency As String
    Public Property Currency() As String
        Get
            Return xCurrency
        End Get
        Set(ByVal value As String)
            xCurrency = value
        End Set
    End Property
End Class
