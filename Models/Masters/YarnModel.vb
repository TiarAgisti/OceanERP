Public Class YarnModel
    Inherits CoreModel
    Private xYarnID As Integer
    Public Property YarnID() As Integer
        Get
            Return xYarnID
        End Get
        Set(ByVal value As Integer)
            xYarnID = value
        End Set
    End Property
    Private xYarnCode As String
    Public Property YarnCode() As String
        Get
            Return xYarnCode
        End Get
        Set(ByVal value As String)
            xYarnCode = value
        End Set
    End Property
    Private xYarnName As String
    Public Property YarnName() As String
        Get
            Return xYarnName
        End Get
        Set(ByVal value As String)
            xYarnName = value
        End Set
    End Property
    Private xVendorID As Integer
    Public Property VendorID() As Integer
        Get
            Return xVendorID
        End Get
        Set(ByVal value As Integer)
            xVendorID = value
        End Set
    End Property
    Private xVendorName As String
    Public Property VendorName() As String
        Get
            Return xVendorName
        End Get
        Set(ByVal value As String)
            xVendorName = value
        End Set
    End Property
End Class
