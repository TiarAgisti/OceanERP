Public Class BODetailModel
    Private xBOID As Long
    Public Property BOID() As Long
            Get
                Return xBOID
            End Get
            Set(ByVal value As Long)
                xBOID = value
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

    Private xWidth As Integer
    Public Property Width() As Integer
        Get
            Return xWidth
        End Get
        Set(ByVal value As Integer)
            xWidth = value
        End Set
    End Property
    Private xWeight As Integer
    Public Property Weight() As Integer
        Get
            Return xWeight
        End Get
        Set(ByVal value As Integer)
            xWeight = value
        End Set
    End Property
End Class

