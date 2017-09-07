Public Class BPBDetailModel
    Private xBPBHeaderID As Long
    Public Property BPBHeaderID() As Long
        Get
            Return xBPBHeaderID
        End Get
        Set(ByVal value As Long)
            xBPBHeaderID = value
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
    Private xPINo As String
    Public Property PINo() As String
        Get
            Return xPINo
        End Get
        Set(ByVal value As String)
            xPINo = value
        End Set
    End Property
    Private xPOHeaderID As String
    Public Property POHeaderID() As String
        Get
            Return xPOHeaderID
        End Get
        Set(ByVal value As String)
            xPOHeaderID = value
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
    Private xRawMaterialID As Integer
    Public Property RawMaterialID() As Integer
        Get
            Return xRawMaterialID
        End Get
        Set(ByVal value As Integer)
            xRawMaterialID = value
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
    Private xUnitID As Integer
    Public Property UnitID() As Integer
        Get
            Return xUnitID
        End Get
        Set(ByVal value As Integer)
            xUnitID = value
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
    Private xQuantityPO As Integer
    Public Property QuantityPO() As Integer
        Get
            Return xQuantityPO
        End Get
        Set(ByVal value As Integer)
            xQuantityPO = value
        End Set
    End Property
    Private xReceived As Integer
    Public Property Received() As Integer
        Get
            Return xReceived
        End Get
        Set(ByVal value As Integer)
            xReceived = value
        End Set
    End Property
    Private xOutstanding As Integer
    Public Property Outstanding() As Integer
        Get
            Return xOutstanding
        End Get
        Set(ByVal value As Integer)
            xOutstanding = value
        End Set
    End Property
    Private xQuantityPackaging As String
    Public Property QuantityPackaging() As String
        Get
            Return xQuantityPackaging
        End Get
        Set(ByVal value As String)
            xQuantityPackaging = value
        End Set
    End Property
End Class
