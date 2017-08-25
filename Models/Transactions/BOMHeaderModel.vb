Public Class BOMHeaderModel
    Inherits CoreModel

    Private xBOMHeaderID As Long
    Public Property BOMHeaderID() As Long
        Get
            Return xBOMHeaderID
        End Get
        Set(ByVal value As Long)
            xBOMHeaderID = value
        End Set
    End Property
    Private xBOMCode As String
    Public Property BOMCode() As String
        Get
            Return xBOMCode
        End Get
        Set(ByVal value As String)
            xBOMCode = value
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
    Private xBuyerID As Integer
    Public Property BUyerID() As Integer
        Get
            Return xBuyerID
        End Get
        Set(ByVal value As Integer)
            xBuyerID = value
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
    Private xColorID As Integer
    Public Property ColorID() As Integer
        Get
            Return xColorID
        End Get
        Set(ByVal value As Integer)
            xColorID = value
        End Set
    End Property
    Private xStatusBOM As Int16
    Public Property StatusBOM() As Int16
        Get
            Return xStatusBOM
        End Get
        Set(ByVal value As Int16)
            xStatusBOM = value
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
    Private xFabricName As String
    Public Property FabricName() As String
        Get
            Return xFabricName
        End Get
        Set(ByVal value As String)
            xFabricName = value
        End Set
    End Property
    Private xComposition As String
    Public Property Composition() As String
        Get
            Return xComposition
        End Get
        Set(ByVal value As String)
            xComposition = value
        End Set
    End Property
    Private xSpecification As String
    Public Property Specification() As String
        Get
            Return xSpecification
        End Get
        Set(ByVal value As String)
            xSpecification = value
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
    Private xStyleName As String
    Public Property StyleName() As String
        Get
            Return xStyleName
        End Get
        Set(ByVal value As String)
            xStyleName = value
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
End Class
