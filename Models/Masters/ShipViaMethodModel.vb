Public Class ShipViaMethodModel
    Inherits CoreModel

    Private xShipViaMethodID As Integer
    Public Property ShipViaMethodID() As Integer
        Get
            Return xShipViaMethodID
        End Get
        Set(ByVal value As Integer)
            xShipViaMethodID = value
        End Set
    End Property
    Private xShipViaMethodCode As String
    Public Property ShipViaMethodCode() As String
        Get
            Return xShipViaMethodCode
        End Get
        Set(ByVal value As String)
            xShipViaMethodCode = value
        End Set
    End Property
    Private xShipViaMethodName As String
    Public Property ShipViaMethodName() As String
        Get
            Return xShipViaMethodName
        End Get
        Set(ByVal value As String)
            xShipViaMethodName = value
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
