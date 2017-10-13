Public Class BOHeaderModel
    Inherits CoreModel
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
    Private xDateIssues As Date
    Public Property DateIssues() As Date
        Get
            Return xDateIssues
        End Get
        Set(ByVal value As Date)
            xDateIssues = value
        End Set
    End Property
    Private xDeliveryDate As Date
    Public Property DeliveryDate() As Date
        Get
            Return xDeliveryDate
        End Get
        Set(ByVal value As Date)
            xDeliveryDate = value
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
    Private xStatus As Int16
        Public Property Status() As Int16
            Get
                Return xStatus
            End Get
            Set(ByVal value As Int16)
                xStatus = value
            End Set
        End Property
        Private xStatusDesc As String
        Public Property StatusDesc() As String
            Get
                Return xStatusDesc
            End Get
            Set(ByVal value As String)
                xStatusDesc = value
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
    Private xReffPO As String
    Public Property ReffPO() As String
        Get
            Return xReffPO
        End Get
        Set(ByVal value As String)
            xReffPO = value
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
    Private xStyleID As Integer
    Public Property StyleID() As Integer
        Get
            Return xStyleID
        End Get
        Set(ByVal value As Integer)
            xStyleID = value
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
        Private xCustomerName As String
    Public Property CustomerName() As String
        Get
            Return xCustomerName
        End Get
        Set(ByVal value As String)
            xCustomerName = value
        End Set
    End Property
    Private xSumBrutto As Integer
    Public Property SumBrutto() As Integer
        Get
            Return xSumBrutto
        End Get
        Set(ByVal value As Integer)
            xSumBrutto = value
        End Set
    End Property
    Private xSumNetto As Integer
    Public Property SumNetto() As Integer
        Get
            Return xSumNetto
        End Get
        Set(ByVal value As Integer)
            xSumNetto = value
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

    Private xfax As String
    Public Property fax() As String
        Get
            Return xfax
        End Get
        Set(ByVal value As String)
            xfax = value
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
    Private xContactPerson As String
    Public Property ContactPerson() As String
        Get
            Return xContactPerson
        End Get
        Set(ByVal value As String)
            xContactPerson = value
        End Set
    End Property
End Class
