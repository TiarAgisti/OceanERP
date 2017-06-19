Public Class BrandModel
    Inherits CoreModel

    Private xBrandID As Integer
    Public Property BrandID() As Integer
        Get
            Return xBrandID
        End Get
        Set(ByVal value As Integer)
            xBrandID = value
        End Set
    End Property

    Private xBrandCode As String
    Public Property BrandCode() As String
        Get
            Return xBrandCode
        End Get
        Set(ByVal value As String)
            xBrandCode = value
        End Set
    End Property

    Private xName As String
    Public Property Name() As String
        Get
            Return xName
        End Get
        Set(ByVal value As String)
            xName = value
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
End Class
