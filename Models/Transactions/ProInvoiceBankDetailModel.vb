Public Class ProInvoiceBankDetailModel
    Private xBOID As Long
    Public Property BOID() As Long
        Get
            Return xBOID
        End Get
        Set(ByVal value As Long)
            xBOID = value
        End Set
    End Property
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

    Private xBankName As String
    Public Property BankName() As String
        Get
            Return xBankName
        End Get
        Set(ByVal value As String)
            xBankName = value
        End Set
    End Property

    Private xSwiftCode As String
    Public Property SwiftCode() As String
        Get
            Return xSwiftCode
        End Get
        Set(ByVal value As String)
            xSwiftCode = value
        End Set
    End Property
    Private xNoOrder As String
    Public Property NoOrder() As String
        Get
            Return xNoOrder
        End Get
        Set(ByVal value As String)
            xNoOrder = value
        End Set
    End Property
End Class
