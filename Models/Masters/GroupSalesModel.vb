Public Class GroupSalesModel
    Inherits CoreModel
    Private xGroupSalesID As Integer
    Public Property GroupSalesID() As Integer
        Get
            Return xGroupSalesID
        End Get
        Set(ByVal value As Integer)
            xGroupSalesID = value
        End Set
    End Property
    Private xGroupSalesCode As String
    Public Property GroupSalesCode() As String
        Get
            Return xGroupSalesCode
        End Get
        Set(ByVal value As String)
            xGroupSalesCode = value
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
End Class
