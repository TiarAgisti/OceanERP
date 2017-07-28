Public Class FabricModel
    Inherits CoreModel
    Private xFabricID As Integer
    Public Property FabricID() As Integer
        Get
            Return xFabricID
        End Get
        Set(ByVal value As Integer)
            xFabricID = value
        End Set
    End Property
    Private xFabricCode As String
    Public Property FabricCode() As String
        Get
            Return xFabricCode
        End Get
        Set(ByVal value As String)
            xFabricCode = value
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
    Private xVendorID As Integer
    Public Property VendorID() As Integer
        Get
            Return xVendorID
        End Get
        Set(ByVal value As Integer)
            xVendorID = value
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
