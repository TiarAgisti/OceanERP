Public Class TermApproveModel
    Inherits CoreModel

    Private xTermApproveID As Long
    Public Property TermApproveID() As Long
        Get
            Return xTermApproveID
        End Get
        Set(ByVal value As Long)
            xTermApproveID = value
        End Set
    End Property

    Private xUserID As Integer
    Public Property UserID() As Integer
        Get
            Return xUserID
        End Get
        Set(ByVal value As Integer)
            xUserID = value
        End Set
    End Property

    Private xCode As String
    Public Property Code() As String
        Get
            Return xCode
        End Get
        Set(ByVal value As String)
            xCode = value
        End Set
    End Property

    Private xNotes As String
    Public Property Notes() As String
        Get
            Return xNotes
        End Get
        Set(ByVal value As String)
            xNotes = value
        End Set
    End Property

    Private xStatus As Int16
    Public Property Status() As Int16
        Get
            Return xStatus
        End Get
        Set(ByVal value As Int16)
            xStatus = value
        End Set
    End Property
End Class
