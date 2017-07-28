Public Class RawMaterialModel
    Inherits CoreModel
    Private xRawMaterialID As Integer
    Public Property RawMaterialID() As Integer
        Get
            Return xRawMaterialID
        End Get
        Set(ByVal value As Integer)
            xRawMaterialID = value
        End Set
    End Property
    Private xRawMaterialCode As String
    Public Property RawMaterialCode() As String
        Get
            Return xRawMaterialCode
        End Get
        Set(ByVal value As String)
            xRawMaterialCode = value
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
    Private xVendorID As Integer
    Public Property VendorID() As Integer
        Get
            Return xVendorID
        End Get
        Set(ByVal value As Integer)
            xVendorID = value
        End Set
    End Property
    Private xSpecRawMaterial As String
    Public Property SpecRawMaterial() As String
        Get
            Return xSpecRawMaterial
        End Get
        Set(ByVal value As String)
            xSpecRawMaterial = value
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
End Class
