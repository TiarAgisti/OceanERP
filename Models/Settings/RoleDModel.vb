Public Class RoleDModel
    Inherits RoleHModel

    Private xMenuID As Integer
    Public Property MenuID() As Integer
        Get
            Return xMenuID
        End Get
        Set(ByVal value As Integer)
            xMenuID = value
        End Set
    End Property

    Private xMenuDescription As String
    Public Property MenuDescription() As String
        Get
            Return xMenuDescription
        End Get
        Set(ByVal value As String)
            xMenuDescription = value
        End Set
    End Property

    Private xIsCreate As Boolean
    Public Property IsCreate() As Boolean
        Get
            Return xIsCreate
        End Get
        Set(ByVal value As Boolean)
            xIsCreate = value
        End Set
    End Property

    Private xIsUpdate As Boolean
    Public Property IsUpdate() As Boolean
        Get
            Return xIsUpdate
        End Get
        Set(ByVal value As Boolean)
            xIsUpdate = value
        End Set
    End Property

    Private xIsDelete As Boolean
    Public Property IsDelete() As Boolean
        Get
            Return xIsDelete
        End Get
        Set(ByVal value As Boolean)
            xIsDelete = value
        End Set
    End Property

    Private xIsApprove As Boolean
    Public Property IsApprove() As Boolean
        Get
            Return xIsApprove
        End Get
        Set(ByVal value As Boolean)
            xIsApprove = value
        End Set
    End Property

    Private xIsVoid As Boolean
    Public Property IsVoid() As Boolean
        Get
            Return xIsVoid
        End Get
        Set(ByVal value As Boolean)
            xIsVoid = value
        End Set
    End Property
End Class
