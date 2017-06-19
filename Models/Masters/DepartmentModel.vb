Public Class DepartmentModel
    Inherits CoreModel
    Private xDepartmentID As Integer
    Public Property DepartmentID() As Integer
        Get
            Return xDepartmentID
        End Get
        Set(ByVal value As Integer)
            xDepartmentID = value
        End Set
    End Property

    Private xDepartmentCode As String
    Public Property DepartmentCode() As String
        Get
            Return xDepartmentCode
        End Get
        Set(ByVal value As String)
            xDepartmentCode = value
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
