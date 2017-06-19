Public Class RoleHModel
    Inherits CoreModel

    Private xRoleID As Integer
    Public Property RoleID() As Integer
        Get
            Return xRoleID
        End Get
        Set(ByVal value As Integer)
            xRoleID = value
        End Set
    End Property
    Private xRoleName As String
    Public Property RoleName() As String
        Get
            Return xRoleName
        End Get
        Set(ByVal value As String)
            xRoleName = value
        End Set
    End Property


End Class
