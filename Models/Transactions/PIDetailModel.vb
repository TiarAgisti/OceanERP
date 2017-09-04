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

    Private xStyleID As Integer
    Public Property StyleID() As Integer
        Get
            Return xStyleID
        End Get
        Set(ByVal value As Integer)
            xStyleID = value
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

    Private xTypeGreige As String
    Public Property TypeGreige() As String
        Get
            Return xTypeGreige
        End Get
        Set(ByVal value As String)
            xTypeGreige = value
        End Set
    End Property

    Private xWidthMin As Double
    Public Property WidthMin() As Double
        Get
            Return xWidthMin
        End Get
        Set(ByVal value As Double)
            xWidthMin = value
        End Set
    End Property

    Private xWidthMax As Double
    Public Property WidthMax() As Double
        Get
            Return xWidthMax
        End Get
        Set(ByVal value As Double)
            xWidthMax = value
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

    Private xWeightMin As Double
    Public Property WeightMin() As Double
        Get
            Return xWeightMin
        End Get
        Set(ByVal value As Double)
            xWeightMin = value
        End Set
    End Property

    Private xWeightMax As Double
    Public Property WeightMax() As Double
        Get
            Return xWeightMax
        End Get
        Set(ByVal value As Double)
            xWeightMax = value
        End Set
    End Property

    Private xDNYardage As Double
    Public Property DNYardage() As Double
        Get
            Return xDNYardage
        End Get
        Set(ByVal value As Double)
            xDNYardage = value
        End Set
    End Property

    Private xWeightYard As Double
    Public Property WeightYard() As Double
        Get
            Return xWeightYard
        End Get
        Set(ByVal value As Double)
            xWeightYard = value
        End Set
    End Property

    Private xBeforeWash As Double
    Public Property BeforeWash() As Double
        Get
            Return xBeforeWash
        End Get
        Set(ByVal value As Double)
            xBeforeWash = value
        End Set
    End Property

    Private xAfterWash As Double
    Public Property AfterWash() As Double
        Get
            Return xAfterWash
        End Get
        Set(ByVal value As Double)
            xAfterWash = value
        End Set
    End Property

    Private xNetWeight As Double
    Public Property NetWeight() As Double
        Get
            Return xNetWeight
        End Get
        Set(ByVal value As Double)
            xNetWeight = value
        End Set
    End Property

    Private xSrinkageL As String
    Public Property SrinkageL() As String
        Get
            Return xSrinkageL
        End Get
        Set(ByVal value As String)
            xSrinkageL = value
        End Set
    End Property

    Private xSrinkageW As String
    Public Property SrinkageW() As String
        Get
            Return xSrinkageW
        End Get
        Set(ByVal value As String)
            xSrinkageW = value
        End Set
    End Property

    Private xGSM As String
    Public Property GSM() As String
        Get
            Return xGSM
        End Get
        Set(ByVal value As String)
            xGSM = value
        End Set
    End Property

    Private xPriceGreige As Double
    Public Property PriceGreige() As Double
        Get
            Return xPriceGreige
        End Get
        Set(ByVal value As Double)
            xPriceGreige = value
        End Set
    End Property

    Private xPurchSize As String
    Public Property PurchSize() As String
        Get
            Return xPurchSize
        End Get
        Set(ByVal value As String)
            xPurchSize = value
        End Set
    End Property

    Private xStorageSize As String
    Public Property StorageSize() As String
        Get
            Return xStorageSize
        End Get
        Set(ByVal value As String)
            xStorageSize = value
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

    Private xFabricName As String
    Public Property FabricName() As String
        Get
            Return xFabricName
        End Get
        Set(ByVal value As String)
            xFabricName = value
        End Set
    End Property

    Private xStyleName As String
    Public Property StyleName() As String
        Get
            Return xStyleName
        End Get
        Set(ByVal value As String)
            xStyleName = value
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

    Private xUnitName As String
    Public Property UnitName() As String
        Get
            Return xUnitName
        End Get
        Set(ByVal value As String)
            xUnitName = value
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

    Private xSpecification As String
    Public Property Specification() As String
        Get
            Return xSpecification
        End Get
        Set(ByVal value As String)
            xSpecification = value
        End Set
    End Property

    'Model for v_PIAllDetail
    Private xColDescription As String
    Public Property ColDescription() As String
        Get
            Return xColDescription
        End Get
        Set(ByVal value As String)
            xColDescription = value
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

    Private xQtySample As Double
    Public Property QtySample() As Double
        Get
            Return xQtySample
        End Get
        Set(ByVal value As Double)
            xQtySample = value
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

    Private xPrice As Double
    Public Property Price() As Double
        Get
            Return xPrice
        End Get
        Set(ByVal value As Double)
            xPrice = value
        End Set
    End Property

    Private xAmount As Double
    Public Property Amount() As Double
        Get
            Return xAmount
        End Get
        Set(ByVal value As Double)
            xAmount = value
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

    Private xWeight As String
    Public Property Weight() As String
        Get
            Return xWeight
        End Get
        Set(ByVal value As String)
            xWeight = value
        End Set
    End Property

    Private xWidth As String
    Public Property Width() As String
        Get
            Return xWidth
        End Get
        Set(ByVal value As String)
            xWidth = value
        End Set
    End Property
    'end
End Class
