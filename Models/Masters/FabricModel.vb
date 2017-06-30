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
End Class
