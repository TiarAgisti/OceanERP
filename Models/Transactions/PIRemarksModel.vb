Public Class PIRemarksModel
    Private xPIHeaderID As Long
    Public Property PIHeaderID() As Long
        Get
            Return xPIHeaderID
        End Get
        Set(ByVal value As Long)
            xPIHeaderID = value
        End Set
    End Property

    Private xPIRemarksID As Integer
    Public Property PIRemarksID() As Integer
        Get
            Return xPIRemarksID
        End Get
        Set(ByVal value As Integer)
            xPIRemarksID = value
        End Set
    End Property

    Private xRemarks As String
    Public Property Remarks() As String
        Get
            Return xRemarks
        End Get
        Set(ByVal value As String)
            xRemarks = value
        End Set
    End Property

    Private xPIDate As DateTime
    Public Property PIDate() As DateTime
        Get
            Return xPIDate
        End Get
        Set(ByVal value As DateTime)
            xPIDate = value
        End Set
    End Property

    Private xPINo As String
    Public Property PINo() As String
        Get
            Return xPINo
        End Get
        Set(ByVal value As String)
            xPINo = value
        End Set
    End Property
End Class
