Public Class DestinationModel
    Inherits CoreModel

    Private xDestinationID As Integer
    Public Property DestinationID() As Integer
        Get
            Return xDestinationID
        End Get
        Set(ByVal value As Integer)
            xDestinationID = value
        End Set
    End Property

    Private xDestinationCode As String
    Public Property DestinationCode() As String
        Get
            Return xDestinationCode
        End Get
        Set(ByVal value As String)
            xDestinationCode = value
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

    Private xStatus As Char
    Public Property Status() As Char
        Get
            Return xStatus
        End Get
        Set(ByVal value As Char)
            xStatus = value
        End Set
    End Property
End Class
