Public Class ProInvoiceRemarkDetailModel
    Private xBOID As Long
    Public Property BOID() As Long
        Get
            Return xBOID
        End Get
        Set(ByVal value As Long)
            xBOID = value
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

    Private xRemarks As String
    Public Property Remarks() As String
        Get
            Return xRemarks
        End Get
        Set(ByVal value As String)
            xRemarks = value
        End Set
    End Property

    Private xDateIssues As Date
    Public Property DateIssues() As Date
        Get
            Return xDateIssues
        End Get
        Set(ByVal value As Date)
            xDateIssues = value
        End Set
    End Property
End Class
