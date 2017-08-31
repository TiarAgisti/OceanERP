Public Class POHeaderModel
    Inherits CoreModel
    Private xPOHeaderID As Long
    Public Property POHeaderID() As Long
        Get
            Return xPOHeaderID
        End Get
        Set(ByVal value As Long)
            xPOHeaderID = value
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
    Private xCustomerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return xCustomerID
        End Get
        Set(ByVal value As Integer)
            xCustomerID = value
        End Set
    End Property
    Private xSupplierID As Integer
    Public Property SupplierID() As Integer
        Get
            Return xSupplierID
        End Get
        Set(ByVal value As Integer)
            xSupplierID = value
        End Set
    End Property
    Private xShipViaMethodCode As String
    Public Property ShipViaMethodCode() As String
        Get
            Return xShipViaMethodCode
        End Get
        Set(ByVal value As String)
            xShipViaMethodCode = value
        End Set
    End Property
    Private xShippingDate As Date
    Public Property ShippingDate() As Date
        Get
            Return xShippingDate
        End Get
        Set(ByVal value As Date)
            xShippingDate = value
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
    Private xExpectedReceiptDate As Date
    Public Property ExpectedReceiptDate() As Date
        Get
            Return xExpectedReceiptDate
        End Get
        Set(ByVal value As Date)
            xExpectedReceiptDate = value
        End Set
    End Property

    Private xSubtotal As Decimal
    Public Property Subtotal() As Decimal
        Get
            Return xSubtotal
        End Get
        Set(ByVal value As Decimal)
            xSubtotal = value
        End Set
    End Property
    Private xDiscount As Decimal
    Public Property Discount() As Decimal
        Get
            Return xDiscount
        End Get
        Set(ByVal value As Decimal)
            xDiscount = value
        End Set
    End Property
    Private xVATRate As Decimal
    Public Property VATRate() As Decimal
        Get
            Return xVATRate
        End Get
        Set(ByVal value As Decimal)
            xVATRate = value
        End Set
    End Property
    Private xOtherCost As Decimal
    Public Property OtherCost() As Decimal
        Get
            Return xOtherCost
        End Get
        Set(ByVal value As Decimal)
            xOtherCost = value
        End Set
    End Property
    Private xSH As Decimal
    Public Property SH() As Decimal
        Get
            Return xSH
        End Get
        Set(ByVal value As Decimal)
            xSH = value
        End Set
    End Property
    Private xGrandTotal As Decimal
    Public Property GrandTotal() As Decimal
        Get
            Return xGrandTotal
        End Get
        Set(ByVal value As Decimal)
            xGrandTotal = value
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
    Private xTermOfPayment As String
    Public Property TermOfPayment() As String
        Get
            Return xTermOfPayment
        End Get
        Set(ByVal value As String)
            xTermOfPayment = value
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

    Private xAddressCustomer As String
    Public Property AddressCustomer() As String
        Get
            Return xAddressCustomer
        End Get
        Set(ByVal value As String)
            xAddressCustomer = value
        End Set
    End Property

    Private xTelephoneCustomer As String
    Public Property TelephoneCustomer() As String
        Get
            Return xTelephoneCustomer
        End Get
        Set(ByVal value As String)
            xTelephoneCustomer = value
        End Set
    End Property

    Private xFaxCustomer As String
    Public Property FaxCustomer() As String
        Get
            Return xFaxCustomer
        End Get
        Set(ByVal value As String)
            xFaxCustomer = value
        End Set
    End Property

    Private xContactPersonCustomer As String
    Public Property ContactPersonCustomer() As String
        Get
            Return xContactPersonCustomer
        End Get
        Set(ByVal value As String)
            xContactPersonCustomer = value
        End Set
    End Property
    Private xEmailCustomer As String
    Public Property EmailCustomer() As String
        Get
            Return xEmailCustomer
        End Get
        Set(ByVal value As String)
            xEmailCustomer = value
        End Set
    End Property
    Private xSupplierCode As String
    Public Property SupplierCode() As String
        Get
            Return xSupplierCode
        End Get
        Set(ByVal value As String)
            xSupplierCode = value
        End Set
    End Property
    Private xSupplierName As String
    Public Property SupplierName() As String
        Get
            Return xSupplierName
        End Get
        Set(ByVal value As String)
            xSupplierName = value
        End Set
    End Property

    Private xAddressSupplier As String
    Public Property AddressSupplier() As String
        Get
            Return xAddressSupplier
        End Get
        Set(ByVal value As String)
            xAddressSupplier = value
        End Set
    End Property

    Private xTelephoneSupplier As String
    Public Property TelephoneSupplier() As String
        Get
            Return xTelephoneSupplier
        End Get
        Set(ByVal value As String)
            xTelephoneSupplier = value
        End Set
    End Property

    Private xFaxSupplier As String
    Public Property FaxSupplier() As String
        Get
            Return xFaxSupplier
        End Get
        Set(ByVal value As String)
            xFaxSupplier = value
        End Set
    End Property

    Private xContactPersonSupplier As String
    Public Property ContactPersonSupplier() As String
        Get
            Return xContactPersonSupplier
        End Get
        Set(ByVal value As String)
            xContactPersonSupplier = value
        End Set
    End Property
    Private xEmailSupplier As String
    Public Property EmailSupplier() As String
        Get
            Return xEmailSupplier
        End Get
        Set(ByVal value As String)
            xEmailSupplier = value
        End Set
    End Property

    Private xShipViaMethodID As Integer
    Public Property ShipViaMethodID() As Integer
        Get
            Return xShipViaMethodID
        End Get
        Set(ByVal value As Integer)
            xShipViaMethodID = value
        End Set
    End Property
    Private xShipViaMethodName As String
    Public Property ShipViaMethodName() As String
        Get
            Return xShipViaMethodName
        End Get
        Set(ByVal value As String)
            xShipViaMethodName = value
        End Set
    End Property
End Class
