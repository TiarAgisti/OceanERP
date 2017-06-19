Public Class LogHistoryModel

#Region "Properties"
    Private xLogID As Integer
    Public Property LogID() As Integer
        Get
            Return xLogID
        End Get
        Set(ByVal value As Integer)
            xLogID = value
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

    Private xUserID As Integer
    Public Property UserID() As Integer
        Get
            Return xUserID
        End Get
        Set(ByVal value As Integer)
            xUserID = value
        End Set
    End Property

    Private xIP As String
    Public Property IP() As String
        Get
            Return xIP
        End Get
        Set(ByVal value As String)
            xIP = value
        End Set
    End Property

    Private xCreatedDate As DateTime
    Public Property CreatedDate() As DateTime
        Get
            Return xCreatedDate
        End Get
        Set(ByVal value As DateTime)
            xCreatedDate = value
        End Set
    End Property
#End Region
End Class
