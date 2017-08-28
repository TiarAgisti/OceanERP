Public Class BOMDetailModel
    Private xBOMHeaderID As Long
    Public Property BOMHeaderID() As Long
        Get
            Return xBOMHeaderID
        End Get
        Set(ByVal value As Long)
            xBOMHeaderID = value
        End Set
    End Property
    Private xBOMDetailID As Integer
    Public Property BOMDetailID() As Integer
        Get
            Return xBOMDetailID
        End Get
        Set(ByVal value As Integer)
            xBOMDetailID = value
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
    Private xUnitID As Integer
    Public Property UnitID() As Integer
        Get
            Return xUnitID
        End Get
        Set(ByVal value As Integer)
            xUnitID = value
        End Set
    End Property
    Private xQty As Decimal
    Public Property Qty() As Decimal
        Get
            Return xQty
        End Get
        Set(ByVal value As Decimal)
            xQty = value
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
