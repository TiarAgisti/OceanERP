Public Class BonOrderDetailMaterialModel
    Private xBonOrderID As Long
    Public Property BonOrderID() As Long
        Get
            Return xBonOrderID
        End Get
        Set(ByVal value As Long)
            xBonOrderID = value
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
    Private xQuantity As Integer
    Public Property Quantity() As Integer
        Get
            Return xQuantity
        End Get
        Set(ByVal value As Integer)
            xQuantity = value
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
    Private xRawMaterialName As String
    Public Property RawMaterialName() As String
        Get
            Return xRawMaterialName
        End Get
        Set(ByVal value As String)
            xRawMaterialName = value
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
End Class