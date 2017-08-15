Public Class PIPrintOutModel
    Private xStyleName As String
    Public Property StyleName() As String
        Get
            Return xStyleName
        End Get
        Set(ByVal value As String)
            xStyleName = value
        End Set
    End Property

    Private xPIDate As DateTime
    Public Property PIDate() As DateTime
        Get
            Return xPIDate
        End Get
        Set(ByVal value As DateTime)
            xPIDate = value
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

    Private xColDescription As String
    Public Property ColDescription() As String
        Get
            Return xColDescription
        End Get
        Set(ByVal value As String)
            xColDescription = value
        End Set
    End Property

    Private xColorCode As String
    Public Property ColorCode() As String
        Get
            Return xColorCode
        End Get
        Set(ByVal value As String)
            xColorCode = value
        End Set
    End Property

    Private xQtySample As Double
    Public Property QtySample() As Double
        Get
            Return xQtySample
        End Get
        Set(ByVal value As Double)
            xQtySample = value
        End Set
    End Property

    Private xPPSample As String
    Public Property PPSample() As String
        Get
            Return xPPSample
        End Get
        Set(ByVal value As String)
            xPPSample = value
        End Set
    End Property

    Private xQtyOrder As Double
    Public Property QtyOrder() As Double
        Get
            Return xQtyOrder
        End Get
        Set(ByVal value As Double)
            xQtyOrder = value
        End Set
    End Property

    Private xPrice As Double
    Public Property Price() As Double
        Get
            Return xPrice
        End Get
        Set(ByVal value As Double)
            xPrice = value
        End Set
    End Property

    Private xAmount As Double
    Public Property Amount() As Double
        Get
            Return xAmount
        End Get
        Set(ByVal value As Double)
            xAmount = value
        End Set
    End Property
End Class
