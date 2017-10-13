Public Class ColorModel
    Inherits CoreModel

    Private xColorID As Integer
    Public Property ColorID() As Integer
        Get
            Return xColorID
        End Get
        Set(ByVal value As Integer)
            xColorID = value
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
    Private xColorName As String
    Public Property ColorName() As String
        Get
            Return xColorName
        End Get
        Set(ByVal value As String)
            xColorName = value
        End Set
    End Property
    Private xDescription As String
    Public Property Description() As String
        Get
            Return xDescription
        End Get
        Set(ByVal value As String)
            xDescription = value
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

    Private xRemarksPart As String
    Public Property RemarksPart() As String
        Get
            Return xRemarksPart
        End Get
        Set(ByVal value As String)
            xRemarksPart = value
        End Set
    End Property
    Private xSeason As String
    Public Property Season() As String
        Get
            Return xSeason
        End Get
        Set(ByVal value As String)
            xSeason = value
        End Set
    End Property
    Private xDarkLight As String
    Public Property DarkLight() As String
        Get
            Return xDarkLight
        End Get
        Set(ByVal value As String)
            xDarkLight = value
        End Set
    End Property
End Class
