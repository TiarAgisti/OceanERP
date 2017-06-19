Public Class CurrencyModel
    Inherits CoreModel

    Private xCurrencyID As Integer
    Public Property CurrencyID() As Integer
        Get
            Return xCurrencyID
        End Get
        Set(ByVal value As Integer)
            xCurrencyID = value
        End Set
    End Property
    Private xCurrencyCode As String
    Public Property CurrencyCode() As String
        Get
            Return xCurrencyCode
        End Get
        Set(ByVal value As String)
            xCurrencyCode = value
        End Set
    End Property
    Private xCurrencyName As String
    Public Property CurrencyName() As String
        Get
            Return xCurrencyName
        End Get
        Set(ByVal value As String)
            xCurrencyName = value
        End Set
    End Property
End Class
