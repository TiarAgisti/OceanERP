Public Class CategoryFabricModel
    Inherits CoreModel
    Private xCategoryID As Integer
    Public Property CategoryID() As Integer
        Get
            Return xCategoryID
        End Get
        Set(ByVal value As Integer)
            xCategoryID = value
        End Set
    End Property
    Private xCategoryName As String
    Public Property CategoryName() As String
        Get
            Return xCategoryName
        End Get
        Set(ByVal value As String)
            xCategoryName = value
        End Set
    End Property

End Class
