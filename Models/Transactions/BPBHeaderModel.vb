Public Class BPBHeaderModel
    Inherits CoreModel
    Private xBPBHeaderID As Long
    Public Property BPBHeaderID() As Long
        Get
            Return xBPBHeaderID
        End Get
        Set(ByVal value As Long)
            xBPBHeaderID = value
        End Set
    End Property
    Private xBPBNo As String
    Public Property BPBNo() As String
        Get
            Return xBPBNo
        End Get
        Set(ByVal value As String)
            xBPBNo = value
        End Set
    End Property
    Private xPOHeaderID As Long
    Public Property POHeaderID() As Long
        Get
            Return xPOHeaderID
        End Get
        Set(ByVal value As Long)
            xPOHeaderID = value
        End Set
    End Property
    Private xBPBDate As Date
    Public Property BPBDate() As Date
        Get
            Return xBPBDate
        End Get
        Set(ByVal value As Date)
            xBPBDate = value
        End Set
    End Property
    Private xInfactDate As Date
    Public Property InfactDate() As Date
        Get
            Return xInfactDate
        End Get
        Set(ByVal value As Date)
            xInfactDate = value
        End Set
    End Property
    Private xDONo As String
    Public Property DONo() As String
        Get
            Return xDONo
        End Get
        Set(ByVal value As String)
            xDONo = value
        End Set
    End Property
    Private xDocTypeCustoms As String
    Public Property DocTypeCustoms() As String
        Get
            Return xDocTypeCustoms
        End Get
        Set(ByVal value As String)
            xDocTypeCustoms = value
        End Set
    End Property
    Private xDocNoCustoms As String
    Public Property DocNoCustoms() As String
        Get
            Return xDocNoCustoms
        End Get
        Set(ByVal value As String)
            xDocNoCustoms = value
        End Set
    End Property

    Private xDocRegistrationDate As Date
    Public Property DocRegistrationDate() As Date
        Get
            Return xDocRegistrationDate
        End Get
        Set(ByVal value As Date)
            xDocRegistrationDate = value
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
    Private xPONo As String
    Public Property PONo() As String
        Get
            Return xPONo
        End Get
        Set(ByVal value As String)
            xPONo = value
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
End Class
