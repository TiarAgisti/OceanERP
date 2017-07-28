Public Class PIColorDetailModel
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property

    Private xPIColorDetailID As Long
    Public Property PIColorDetailID() As Long
        Get
            Return xPIColorDetailID
        End Get
        Set(ByVal value As Long)
            xPIColorDetailID = value
        End Set
    End Property

    Private xColorID As Integer
    Public Property ColorID() As Integer
        Get
            Return xColorID
        End Get
        Set(ByVal value As Integer)
            xColorID = value
        End Set
    End Property

    Private xColorType As String
    Public Property ColorType() As String
        Get
            Return xColorType
        End Get
        Set(ByVal value As String)
            xColorType = value
        End Set
    End Property

    Private xColorLabNumber As String
    Public Property ColorLabNumber() As String
        Get
            Return xColorLabNumber
        End Get
        Set(ByVal value As String)
            xColorLabNumber = value
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

    Private xPurchSizeID As Integer
    Public Property PurchSizeID() As Integer
        Get
            Return xPurchSizeID
        End Get
        Set(ByVal value As Integer)
            xPurchSizeID = value
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

    Private xQtySample As Double
    Public Property QtySample() As Double
        Get
            Return xQtySample
        End Get
        Set(ByVal value As Double)
            xQtySample = value
        End Set
    End Property

    Private xDelDate As Date
    Public Property DelDate() As Date
        Get
            Return xDelDate
        End Get
        Set(ByVal value As Date)
            xDelDate = value
        End Set
    End Property

    Private xNote As String
    Public Property Note() As String
        Get
            Return xNote
        End Get
        Set(ByVal value As String)
            xNote = value
        End Set
    End Property
End Class
