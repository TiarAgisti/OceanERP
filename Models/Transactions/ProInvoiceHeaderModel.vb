Public Class ProInvoiceHeaderModel
    Inherits CoreModel
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property

    Private xDatePI As Date
    Public Property DatePI() As Date
        Get
            Return xDatePI
        End Get
        Set(ByVal value As Date)
            xDatePI = value
        End Set
    End Property

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

    Private xReffPO As String
    Public Property ReffPO() As String
        Get
            Return xReffPO
        End Get
        Set(ByVal value As String)
            xReffPO = value
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

    Private xSeasonID As Integer
    Public Property SeasonID() As Integer
        Get
            Return xSeasonID
        End Get
        Set(ByVal value As Integer)
            xSeasonID = value
        End Set
    End Property

    Private xTermOfPaymentID As Integer
    Public Property TermOfPaymentID() As Integer
        Get
            Return xTermOfPaymentID
        End Get
        Set(ByVal value As Integer)
            xTermOfPaymentID = value
        End Set
    End Property

    Private xDelTerm As Date
    Public Property DelTerm() As Date
        Get
            Return xDelTerm
        End Get
        Set(ByVal value As Date)
            xDelTerm = value
        End Set
    End Property

    Private xTermOfPriceID As Integer
    Public Property TermOfPriceID() As Integer
        Get
            Return xTermOfPriceID
        End Get
        Set(ByVal value As Integer)
            xTermOfPriceID = value
        End Set
    End Property

    Private xContractNo As String
    Public Property ContractNo() As String
        Get
            Return xContractNo
        End Get
        Set(ByVal value As String)
            xContractNo = value
        End Set
    End Property
    Private xAtention As String
    Public Property Atention() As String
        Get
            Return xAtention
        End Get
        Set(ByVal value As String)
            xAtention = value
        End Set
    End Property
    Private xDestinationID As Integer
    Public Property DestinationID() As Integer
        Get
            Return xDestinationID
        End Get
        Set(ByVal value As Integer)
            xDestinationID = value
        End Set
    End Property

    Private xCustomerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return xCustomerID
        End Get
        Set(ByVal value As Integer)
            xCustomerID = value
        End Set
    End Property

    Private xGroupSalesID As Integer
    Public Property GroupSalesID() As Integer
        Get
            Return xGroupSalesID
        End Get
        Set(ByVal value As Integer)
            xGroupSalesID = value
        End Set
    End Property

    Private xStatus As Int16
    Public Property Status() As Int16
        Get
            Return xStatus
        End Get
        Set(ByVal value As Int16)
            xStatus = value
        End Set
    End Property

    Private xCustomerCode As String
    Public Property CustomerCode() As String
        Get
            Return xCustomerCode
        End Get
        Set(ByVal value As String)
            xCustomerCode = value
        End Set
    End Property

    Private xCustomerName As String
    Public Property CustomerName() As String
        Get
            Return xCustomerName
        End Get
        Set(ByVal value As String)
            xCustomerName = value
        End Set
    End Property

    Private xAddress As String
    Public Property Address() As String
        Get
            Return xAddress
        End Get
        Set(ByVal value As String)
            xAddress = value
        End Set
    End Property

    Private xTelephone As String
    Public Property Telephone() As String
        Get
            Return xTelephone
        End Get
        Set(ByVal value As String)
            xTelephone = value
        End Set
    End Property

    Private xFax As String
    Public Property Fax() As String
        Get
            Return xFax
        End Get
        Set(ByVal value As String)
            xFax = value
        End Set
    End Property

    Private xFM As String
    Public Property FM() As String
        Get
            Return xFM
        End Get
        Set(ByVal value As String)
            xFM = value
        End Set
    End Property

    Private xEmailCP As String
    Public Property EmailCP() As String
        Get
            Return xEmailCP
        End Get
        Set(ByVal value As String)
            xEmailCP = value
        End Set
    End Property

    Private xBrandID As Integer
    Public Property BrandID() As Integer
        Get
            Return xBrandID
        End Get
        Set(ByVal value As Integer)
            xBrandID = value
        End Set
    End Property

    Private xBrand As String
    Public Property Brand() As String
        Get
            Return xBrand
        End Get
        Set(ByVal value As String)
            xBrand = value
        End Set
    End Property

    Private xBuyerName As String
    Public Property BuyerName() As String
        Get
            Return xBuyerName
        End Get
        Set(ByVal value As String)
            xBuyerName = value
        End Set
    End Property

    Private xSalesName As String
    Public Property SalesName() As String
        Get
            Return xSalesName
        End Get
        Set(ByVal value As String)
            xSalesName = value
        End Set
    End Property

    Private xSeasonName As String
    Public Property SeasonName() As String
        Get
            Return xSeasonName
        End Get
        Set(ByVal value As String)
            xSeasonName = value
        End Set
    End Property

    Private xTermOfPayment As String
    Public Property TermOfPayment() As String
        Get
            Return xTermOfPayment
        End Get
        Set(ByVal value As String)
            xTermOfPayment = value
        End Set
    End Property

    Private xTermOfPrice As String
    Public Property TermOfPrice() As String
        Get
            Return xTermOfPrice
        End Get
        Set(ByVal value As String)
            xTermOfPrice = value
        End Set
    End Property

    Private xDestinationName As String
    Public Property DestinationName() As String
        Get
            Return xDestinationName
        End Get
        Set(ByVal value As String)
            xDestinationName = value
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

    Private xDeliveryPlace As String
    Public Property DeliveryPlace() As String
        Get
            Return xDeliveryPlace
        End Get
        Set(ByVal value As String)
            xDeliveryPlace = value

        End Set
    End Property

    Private xAddressDeliveryPlace As String
    Public Property AddressDeliveryplace() As String
        Get
            Return xAddressDeliveryPlace
        End Get
        Set(ByVal value As String)
            xAddressDeliveryPlace = value
        End Set
    End Property

    Private xAmountTotal As Decimal
    Public Property AmountTotal() As Decimal
        Get
            Return xAmountTotal
        End Get
        Set(ByVal value As Decimal)
            xAmountTotal = value
        End Set
    End Property

    Private xCurrID As Integer
    Public Property CurrID() As Integer
        Get
            Return xCurrID
        End Get
        Set(ByVal value As Integer)
            xCurrID = value
        End Set
    End Property

    Private xCurrCode As String
    Public Property CurrCode() As String
        Get
            Return xCurrCode
        End Get
        Set(ByVal value As String)
            xCurrCode = value
        End Set
    End Property
End Class
