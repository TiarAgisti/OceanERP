Public Class VendorModel
    Inherits CoreModel
    Private xVendorID As Integer
    Public Property VendorID() As Integer
        Get
            Return xVendorID
        End Get
        Set(ByVal value As Integer)
            xVendorID = value
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
    Private xShippingAddress As String
    Public Property ShippingAddress() As String
        Get
            Return xShippingAddress
        End Get
        Set(ByVal value As String)
            xShippingAddress = value
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
    Private xEmailCP As String
    Public Property EmailCP() As String
        Get
            Return xEmailCP
        End Get
        Set(ByVal value As String)
            xEmailCP = value
        End Set
    End Property
    Private xNpwp As String
    Public Property Npwp() As String
        Get
            Return xNpwp
        End Get
        Set(ByVal value As String)
            xNpwp = value
        End Set
    End Property
    Private xTermOfPaymentID As String
    Public Property TermOfPaymentID() As String
        Get
            Return xTermOfPaymentID
        End Get
        Set(ByVal value As String)
            xTermOfPaymentID = value
        End Set
    End Property
    Private xStatus As Char
    Public Property Status() As Char
        Get
            Return xStatus
        End Get
        Set(ByVal value As Char)
            xStatus = value
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
End Class
