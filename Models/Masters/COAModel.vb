Public Class COAModel
    Inherits CoreModel
    Private xCoaID As Integer
    Public Property CoaID() As Integer
        Get
            Return xCoaID
        End Get
        Set(ByVal value As Integer)
            xCoaID = value
        End Set
    End Property
    Private xCoaCode As String
    Public Property CoaCode() As String
        Get
            Return xCoaCode
        End Get
        Set(ByVal value As String)
            xCoaCode = value
        End Set
    End Property
    Private xCoaName As String
    Public Property CoaName() As String
        Get
            Return xCoaName
        End Get
        Set(ByVal value As String)
            xCoaName = value
        End Set
    End Property
    Private xCostCenter As String
    Public Property CostCenter() As String
        Get
            Return xCostCenter
        End Get
        Set(ByVal value As String)
            xCostCenter = value
        End Set
    End Property
End Class
