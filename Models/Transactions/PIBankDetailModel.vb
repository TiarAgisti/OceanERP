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

    Private xBankID As Integer
    Public Property BankID() As Integer
        Get
            Return xBankID
        End Get
        Set(ByVal value As Integer)
            xBankID = value
        End Set
    End Property
End Class
