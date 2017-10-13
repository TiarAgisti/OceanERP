Public Class ProInvoiceYarnDetailModel
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

    Private xYarnID As Integer
    Public Property YarnID() As Integer
        Get
            Return xYarnID
        End Get
        Set(ByVal value As Integer)
            xYarnID = value
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

    Private xUnitID As Integer
    Public Property UnitID() As Integer
        Get
            Return xUnitID
        End Get
        Set(ByVal value As Integer)
            xUnitID = value
        End Set
    End Property
    Private xUnitname As String
    Public Property Unitname() As String
        Get
            Return xUnitname
        End Get
        Set(ByVal value As String)
            xUnitname = value
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
