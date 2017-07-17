Public Class PIHeaderModel
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

    Private xPIDate As Date
    Public Property PIDate() As Date
        Get
            Return xPIDate
        End Get
        Set(ByVal value As Date)
            xPIDate = value
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

    Private xVendorID As Integer
    Public Property VendorID() As Integer
        Get
            Return xVendorID
        End Get
        Set(ByVal value As Integer)
            xVendorID = value
        End Set
    End Property

    Private xBuyerID As Integer
    Public Property BuyerID() As Integer
        Get
            Return xBuyerID
        End Get
        Set(ByVal value As Integer)
            xBuyerID = value
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

    Private xRefPO As String
    Public Property RefPO() As String
        Get
            Return xRefPO
        End Get
        Set(ByVal value As String)
            xRefPO = value
        End Set
    End Property

    Private xStyle As String
    Public Property Style() As String
        Get
            Return xStyle
        End Get
        Set(ByVal value As String)
            xStyle = value
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

    Private xDestinationID As Integer
    Public Property DestinationID() As Integer
        Get
            Return xDestinationID
        End Get
        Set(ByVal value As Integer)
            xDestinationID = value
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

    Private xStatus As Int16
    Public Property Status() As Int16
        Get
            Return xStatus
        End Get
        Set(ByVal value As Int16)
            xStatus = value
        End Set
    End Property

    Private xVendorCode As String
    Public Property VendorCode() As String
        Get
            Return xVendorCode
        End Get
        Set(ByVal value As String)
            xVendorCode = value
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

    Private xContactPerson As String
    Public Property ContactPerson() As String
        Get
            Return xContactPerson
        End Get
        Set(ByVal value As String)
            xContactPerson = value
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


End Class
