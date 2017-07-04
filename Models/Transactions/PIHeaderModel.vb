Public Class PIHeaderModel
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
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
    Public Property DelDate() As Date
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
End Class
