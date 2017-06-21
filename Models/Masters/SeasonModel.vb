Public Class SeasonModel
    Inherits CoreModel
    Private xSeasonID As Integer
    Public Property SeasonID() As Integer
        Get
            Return xSeasonID
        End Get
        Set(ByVal value As Integer)
            xSeasonID = value
        End Set
    End Property
    Private xSeasonCode As String
    Public Property SeasonCode() As String
        Get
            Return xSeasonCode
        End Get
        Set(ByVal value As String)
            xSeasonCode = value
        End Set
    End Property
    Private xSeasonName As String
    Public Property SeasonName() As String
        Get
            Return xSeasonName
        End Get
        Set(ByVal value As String)
            xSeasonName = value
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
    Private xVendorID As Integer
    Public Property VendorID() As Integer
        Get
            Return xVendorID
        End Get
        Set(ByVal value As Integer)
            xVendorID = value
        End Set
    End Property
End Class
