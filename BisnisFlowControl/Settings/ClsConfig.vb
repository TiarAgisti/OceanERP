Public Class ClsConfig
    Public Function TestConnection() As Boolean
        Try
            Dim dataAccess As ClsDataAccess = New ClsDataAccess
            Return dataAccess.TestConnection()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
