Public Class BonOrderHeaderModel
    Inherits CoreModel
    Private xBonOrderID As Long
    Public Property BonOrderID() As Long
        Get
            Return xBonOrderID
        End Get
        Set(ByVal value As Long)
            xBonOrderID = value
        End Set
    End Property
    Private xBonOrderCode As String
    Public Property BonOrderCode() As String
        Get
            Return xBonOrderCode
        End Get
        Set(ByVal value As String)
            xBonOrderCode = value
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
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
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
    Private xPINo As String
    Public Property PINo() As String
        Get
            Return xPINo
        End Get
        Set(ByVal value As String)
            xPINo = value
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
    Private xBuyerName As String
    Public Property BuyerName() As String
        Get
            Return xBuyerName
        End Get
        Set(ByVal value As String)
            xBuyerName = value
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
End Class
