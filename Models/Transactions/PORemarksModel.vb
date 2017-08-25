Public Class PORemarksModel
    Private xPOHeaderID As Long
    Public Property POHeaderID() As Long
        Get
            Return xPOHeaderID
        End Get
        Set(ByVal value As Long)
            xPOHeaderID = value
        End Set
    End Property

    Private xPORemarksID As Integer
    Public Property PORemarksID() As Integer
        Get
            Return xPORemarksID
        End Get
        Set(ByVal value As Integer)
            xPORemarksID = value
        End Set
    End Property

    Private xRemarks As String
    Public Property Remarks() As String
        Get
            Return xRemarks
        End Get
        Set(ByVal value As String)
            xRemarks = value
        End Set
    End Property

    Private xPODate As DateTime
    Public Property PODate() As DateTime
        Get
            Return xPODate
        End Get
        Set(ByVal value As DateTime)
            xPODate = value
        End Set
    End Property

    Private xPONo As String
    Public Property PONo() As String
        Get
            Return xPONo
        End Get
        Set(ByVal value As String)
            xPONo = value
        End Set
    End Property
End Class
