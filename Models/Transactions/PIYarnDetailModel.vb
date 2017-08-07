Public Class PIYarnDetailModel
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property

    Private xPIYarnDetailID As Long
    Public Property PIYarnDetailID() As Long
        Get
            Return xPIYarnDetailID
        End Get
        Set(ByVal value As Long)
            xPIYarnDetailID = value
        End Set
    End Property

    Private xYarnID As Integer
    Public Property YarnID() As Integer
        Get
            Return xYarnID
        End Get
        Set(ByVal value As Integer)
            xYarnID = value
        End Set
    End Property


    Private xPriceYarn As Double
    Public Property PriceYarn() As Double
        Get
            Return xPriceYarn
        End Get
        Set(ByVal value As Double)
            xPriceYarn = value
        End Set
    End Property


    Private xPercentageUsage As Double
    Public Property PercentageUsage() As Double
        Get
            Return xPercentageUsage
        End Get
        Set(ByVal value As Double)
            xPercentageUsage = value
        End Set
    End Property

    Private xQtyUsage As Double
    Public Property QtyUsage() As Double
        Get
            Return xQtyUsage
        End Get
        Set(ByVal value As Double)
            xQtyUsage = value
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

    Private xBrandYarnID As Integer
    Public Property BrandYarnID() As Integer
        Get
            Return xBrandYarnID
        End Get
        Set(ByVal value As Integer)
            xBrandYarnID = value
        End Set
    End Property

    Private xLoss As Double
    Public Property Loss() As Double
        Get
            Return xLoss
        End Get
        Set(ByVal value As Double)
            xLoss = value
        End Set
    End Property

    Private xYarnName As String
    Public Property YarnName() As String
        Get
            Return xYarnName
        End Get
        Set(ByVal value As String)
            xYarnName = value
        End Set
    End Property

    Private xVendorName As String
    Public Property VendorName() As String
        Get
            Return xVendorName
        End Get
        Set(ByVal value As String)
            xVendorName = value
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

    Private xBrandYarnName As String
    Public Property BrandYarnName() As String
        Get
            Return xBrandYarnName
        End Get
        Set(ByVal value As String)
            xBrandYarnName = value
        End Set
    End Property
End Class
