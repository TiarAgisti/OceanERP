Public Class TermOfPaymentModel
    Inherits CoreModel
    Private xTermOfPaymentID As Integer
    Public Property TermOfPaymentID() As Integer
        Get
            Return xTermOfPaymentID
        End Get
        Set(ByVal value As Integer)
            xTermOfPaymentID = value
        End Set
    End Property
    Private xTermOfPaymentCode As String
    Public Property TermOfPaymentCode() As String
        Get
            Return xTermOfPaymentCode
        End Get
        Set(ByVal value As String)
            xTermOfPaymentCode = value
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
