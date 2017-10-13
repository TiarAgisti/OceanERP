Public Class OrderLoosesModel
    Inherits CoreModel
    Private xLoosesID As Integer
    Public Property LoosesID() As Integer
        Get
            Return xLoosesID
        End Get
        Set(ByVal value As Integer)
            xLoosesID = value
        End Set
    End Property
    Private xOrderLengthRangeLBS As String
    Public Property OrderLengthRangeLBS() As String
        Get
            Return xOrderLengthRangeLBS
        End Get
        Set(ByVal value As String)
            xOrderLengthRangeLBS = value
        End Set
    End Property
    Private xOrderLengthRangeKG As String
    Public Property OrderLengthRangeKG() As String
        Get
            Return xOrderLengthRangeKG
        End Get
        Set(ByVal value As String)
            xOrderLengthRangeKG = value
        End Set
    End Property
    Private xCategoryID As Integer
    Public Property CategoryID() As Integer
        Get
            Return xCategoryID
        End Get
        Set(ByVal value As Integer)
            xCategoryID = value
        End Set
    End Property
    Private xCategoryName As String
    Public Property CategoryName() As String
        Get
            Return xCategoryName
        End Get
        Set(ByVal value As String)
            xCategoryName = value
        End Set
    End Property
    Private xValueLosses As Integer
    Public Property ValueLosses() As Integer
        Get
            Return xValueLosses
        End Get
        Set(ByVal value As Integer)
            xValueLosses = value
        End Set
    End Property
End Class
