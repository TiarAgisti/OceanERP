Public Class CoreModel
    Private xIsActive As Boolean
    Public Property IsActive() As Boolean
        Get
            Return xIsActive
        End Get
        Set(ByVal value As Boolean)
            xIsActive = value
        End Set
    End Property

    Private xCreatedBy As Integer
    Public Property CreatedBy() As Integer
        Get
            Return xCreatedBy
        End Get
        Set(ByVal value As Integer)
            xCreatedBy = value
        End Set
    End Property

    Private xCreatedDate As DateTime
    Public Property CreatedDate() As DateTime
        Get
            Return xCreatedDate
        End Get
        Set(ByVal value As DateTime)
            xCreatedDate = value
        End Set
    End Property

    Private xUpdatedBy As Integer
    Public Property UpdatedBy() As Integer
        Get
            Return xUpdatedBy
        End Get
        Set(ByVal value As Integer)
            xUpdatedBy = value
        End Set
    End Property

    Private xUpdatedDate As DateTime
    Public Property UpdatedDate() As DateTime
        Get
            Return xUpdatedDate
        End Get
        Set(ByVal value As DateTime)
            xUpdatedDate = value
        End Set
    End Property
End Class
