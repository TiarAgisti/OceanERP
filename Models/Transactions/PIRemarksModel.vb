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



End Class
