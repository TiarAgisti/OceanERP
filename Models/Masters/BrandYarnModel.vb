Public Class BrandYarnModel
    Inherits CoreModel
    Private xBrandYarnID As Integer
    Public Property BrandYarnID() As Integer
        Get
            Return xBrandYarnID
        End Get
        Set(ByVal value As Integer)
            xBrandYarnID = value
        End Set
    End Property
    Private xBrandYarnName As String
    Public Property BrandYarnName() As String
        Get
            Return xBrandYarnName
        End Get
        Set(ByVal value As String)
            xBrandYarnName = value
        End Set
    End Property
End Class
