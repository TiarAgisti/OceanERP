Public Class PIDetailModel

    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property

    Private xPIDetailID As Long
    Public Property PIDetailID() As Long
        Get
            Return xPIDetailID
        End Get
        Set(ByVal value As Long)
            xPIDetailID = value
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

    Private xDateDetail As Date
    Public Property DateDetail() As Date
        Get
            Return xDateDetail
        End Get
        Set(ByVal value As Date)
            xDateDetail = value
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

    Private xPPSample As String
    Public Property PPSample() As String
        Get
            Return xPPSample
        End Get
        Set(ByVal value As String)
            xPPSample = value
        End Set
    End Property

    Private xQtyCuttable As Decimal
    Public Property QtyCuttable() As Decimal
        Get
            Return xQtyCuttable
        End Get
        Set(ByVal value As Decimal)
            xQtyCuttable = value
        End Set
    End Property

    Private xQtyWeight As Decimal
    Public Property QtyWeight() As Decimal
        Get
            Return xQtyWeight
        End Get
        Set(ByVal value As Decimal)
            xQtyWeight = value
        End Set
    End Property

    Private xQty As Decimal
    Public Property Qty() As Decimal
        Get
            Return xQty
        End Get
        Set(ByVal value As Decimal)
            xQty = value
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

    Private xUnitPrice As Decimal
    Public Property UnitPrice() As Decimal
        Get
            Return xUnitPrice
        End Get
        Set(ByVal value As Decimal)
            xUnitPrice = value
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

    Private xPINo As String
    Public Property PINo() As String
        Get
            Return xPINo
        End Get
        Set(ByVal value As String)
            xPINo = value
        End Set
    End Property

    Private xPIDate As Date
    Public Property PIDate() As Date
        Get
            Return xPIDate
        End Get
        Set(ByVal value As Date)
            xPIDate = value
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

    Private xUnitName As String
    Public Property UnitName() As String
        Get
            Return xUnitName
        End Get
        Set(ByVal value As String)
            xUnitName = value
        End Set
    End Property

    Private xCurrencyCode As String
    Public Property CurrencyCode() As String
        Get
            Return xCurrencyCode
        End Get
        Set(ByVal value As String)
            xCurrencyCode = value
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
