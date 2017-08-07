Public Class PIBankDetailModel
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property

    Private xPIBankDetailID As Long
    Public Property PIBankDetailID() As Long
        Get
            Return xPIBankDetailID
        End Get
        Set(ByVal value As Long)
            xPIBankDetailID = value
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

    Private xPINo As String
    Public Property PINo() As String
        Get
            Return xPINo
        End Get
        Set(ByVal value As String)
            xPINo = value
        End Set
    End Property
End Class
