Public Class UserModel
    Inherits CoreModel
    Private xUserID As Long
    Public Property UserID() As Long
        Get
            Return xUserID
        End Get
        Set(ByVal value As Long)
            xUserID = value
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

    Private xuserpassword As String
    Public Property userpassword() As String
        Get
            Return xuserpassword
        End Get
        Set(ByVal value As String)
            xuserpassword = value
        End Set
    End Property

    Private xRoleID As Integer
    Public Property RoleID() As Integer
        Get
            Return xRoleID
        End Get
        Set(ByVal value As Integer)
            xRoleID = value
        End Set
    End Property
End Class
