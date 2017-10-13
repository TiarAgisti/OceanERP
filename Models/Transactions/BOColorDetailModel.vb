Public Class BOColorDetailModel
    Private xBOID As Long
    Public Property BOID() As Long
        Get
            Return xBOID
        End Get
        Set(ByVal value As Long)
            xBOID = value
        End Set
    End Property
    Private xFabricID As Integer
    Public Property FabricID() As Integer
        Get
            Return xFabricID
        End Get
        Set(ByVal value As Integer)
            xFabricID = value
        End Set
    End Property
    Private xFabricName As String
    Public Property FabricName() As String
        Get
            Return xFabricName
        End Get
        Set(ByVal value As String)
            xFabricName = value
        End Set
    End Property
    Private xColorID As Integer
    Public Property ColorID() As Integer
        Get
            Return xColorID
        End Get
        Set(ByVal value As Integer)
            xColorID = value
        End Set
    End Property

    Private xColorName As String
    Public Property ColorName() As String
        Get
            Return xColorName
        End Get
        Set(ByVal value As String)
            xColorName = value
        End Set
    End Property
    Private xLabsDipsNo As String
    Public Property LabsDipsNo() As String
        Get
            Return xLabsDipsNo
        End Get
        Set(ByVal value As String)
            xLabsDipsNo = value
        End Set
    End Property

    Private xBrutto As Integer
    Public Property Brutto() As Integer
        Get
            Return xBrutto
        End Get
        Set(ByVal value As Integer)
            xBrutto = value
        End Set
    End Property
    Private xNetto As Integer
    Public Property Netto() As Integer
        Get
            Return xNetto
        End Get
        Set(ByVal value As Integer)
            xNetto = value
        End Set
    End Property

    Private xColorCode As String
    Public Property ColorCode() As String
        Get
            Return xColorCode
        End Get
        Set(ByVal value As String)
            xColorCode = value
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

End Class
