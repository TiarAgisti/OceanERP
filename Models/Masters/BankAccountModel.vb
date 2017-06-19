Public Class BankAccountModel
    Inherits CoreModel
    Private xBankAccountID As Integer
    Public Property BankAccountID() As Integer
        Get
            Return xBankAccountID
        End Get
        Set(ByVal value As Integer)
            xBankAccountID = value
        End Set
    End Property

    Private xBankAccountCode As String
    Public Property BankAccountCode() As String
        Get
            Return xBankAccountCode
        End Get
        Set(ByVal value As String)
            xBankAccountCode = value
        End Set
    End Property

    Private xBankID As Integer
    Public Property BankID() As Integer
        Get
            Return xBankID
        End Get
        Set(ByVal value As Integer)
            xBankID = value
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
    Private xCurrencyID As Integer
    Public Property CurrencyID() As Integer
        Get
            Return xCurrencyID
        End Get
        Set(ByVal value As Integer)
            xCurrencyID = value
        End Set
    End Property

    Private xAccountName As String
    Public Property AccountName() As String
        Get
            Return xAccountName
        End Get
        Set(ByVal value As String)
            xAccountName = value
        End Set
    End Property

    Private xAccountNumber As String
    Public Property AccountNumber() As String
        Get
            Return xAccountNumber
        End Get
        Set(ByVal value As String)
            xAccountNumber = value
        End Set
    End Property

End Class
