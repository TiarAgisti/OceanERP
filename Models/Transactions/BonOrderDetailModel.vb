Public Class BonOrderDetailModel
    Private xBonOrderID As Long
    Public Property BonOrderID() As Long
        Get
            Return xBonOrderID
        End Get
        Set(ByVal value As Long)
            xBonOrderID = value
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
    Private xColorID As Integer
    Public Property ColorID() As Integer
        Get
            Return xColorID
        End Get
        Set(ByVal value As Integer)
            xColorID = value
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
    Private xLabsDipsNo As String
    Public Property LabsDipsNo() As String
        Get
            Return xLabsDipsNo
        End Get
        Set(ByVal value As String)
            xLabsDipsNo = value
        End Set
    End Property
    Private xBruto As Decimal
    Public Property Bruto() As Decimal
        Get
            Return xBruto
        End Get
        Set(ByVal value As Decimal)
            xBruto = value
        End Set
    End Property
    Private xNetto As Decimal
    Public Property Netto() As Decimal
        Get
            Return xNetto
        End Get
        Set(ByVal value As Decimal)
            xNetto = value
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
    Private xWidthWeight As String
    Public Property WidthWeight() As String
        Get
            Return xWidthWeight
        End Get
        Set(ByVal value As String)
            xWidthWeight = value
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
    Private xStyleName As String
    Public Property StyleName() As String
        Get
            Return xStyleName
        End Get
        Set(ByVal value As String)
            xStyleName = value
        End Set
    End Property
    Private xWidth As String
    Public Property Width() As String
        Get
            Return xWidth
        End Get
        Set(ByVal value As String)
            xWidth = value
        End Set
    End Property
    Private xWeight As String
    Public Property Weight() As String
        Get
            Return xWeight
        End Get
        Set(ByVal value As String)
            xWeight = value
        End Set
    End Property
End Class
