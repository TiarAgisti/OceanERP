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
    Private xSupllierID As Integer
    Public Property SupllierID() As Integer
        Get
            Return xSupllierID
        End Get
        Set(ByVal value As Integer)
            xSupllierID = value
        End Set
    End Property
    Private xShipViaMethod As String
    Public Property ShipViaMethod() As String
        Get
            Return xShipViaMethod
        End Get
        Set(ByVal value As String)
            xShipViaMethod = value
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
    Private xCustomerName As String
    Public Property CustomerName() As String
        Get
            Return xCustomerName
        End Get
        Set(ByVal value As String)
            xCustomerName = value
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
End Class
