Public Class StyleModel
    Inherits CoreModel
    Private xStyleID As Integer
    Public Property StyleID() As Integer
        Get
            Return xStyleID
        End Get
        Set(ByVal value As Integer)
            xStyleID = value
        End Set
    End Property
    Private xStyleCode As String
    Public Property StyleCode() As String
        Get
            Return xStyleCode
        End Get
        Set(ByVal value As String)
            xStyleCode = value
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
    Private xSpecStyle As String
    Public Property SpecStyle() As String
        Get
            Return xSpecStyle
        End Get
        Set(ByVal value As String)
            xSpecStyle = value
        End Set
    End Property
End Class
