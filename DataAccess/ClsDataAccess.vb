Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Public Class ClsDataAccess
    Public reader As SqlDataReader
    'Public conn As SqlConnection
    Private Function ConnectionString() As String
        Dim connStr As String
        If My.Settings.winAuthentication = True Then
            connStr = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & "" &
                    ";User Id=" & My.Settings.userId & ";password=" & My.Settings.userPassword & ";"
        Else
            connStr = "Server=" & My.Settings.server & ";Database=" & My.Settings.database & ";trusted_connection=true;"
        End If
        Return connStr
    End Function
    Public Function GetHostName() As String
        Try
            Dim strHostName As String = Dns.GetHostName()
            Return strHostName
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetIPAddress() As String
        Try
            Dim strIPAddress As String = Dns.GetHostEntry(GetHostName()).AddressList(0).ToString()
            If strIPAddress = "::1" Then
                strIPAddress = Dns.GetHostEntry(GetHostName()).AddressList(1).ToString()
            End If
            Return strIPAddress
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function TestConnection() As Boolean
        Using conn As New SqlConnection(ConnectionString())
            Try
                conn.Open()
                conn.Close()
                Return True
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Using
    End Function
    Public Sub CreateCommand(ByVal queryString As String)
        Using conn As New SqlConnection(ConnectionString())
            Using myCommand As New SqlCommand(queryString, conn)
                Try
                    conn.Open()
                    myCommand.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    conn.Close()
                    Throw ex
                End Try
            End Using
        End Using
    End Sub
    Public Function RetrieveListData(query As String) As DataTable
        Dim dataTable As DataTable = New DataTable
        Try
            Using conn = New SqlConnection(ConnectionString())
                conn.Open()
                Dim myCommand As SqlCommand = New SqlCommand(query, conn)
                Using dataAdapter As SqlDataAdapter = New SqlDataAdapter(myCommand)
                    dataAdapter.Fill(dataTable)
                End Using
                myCommand.Dispose()
                conn.Close()
                Return dataTable
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ExecuteReader(query As String) As SqlDataReader
        Dim myConnection As New SqlConnection(ConnectionString)
        myConnection.Open()
        Dim myCommand As SqlCommand = New SqlCommand(query, myConnection)
        reader = myCommand.ExecuteReader(CommandBehavior.Default)
        myCommand.Dispose()
        Return reader
    End Function
    Public Function GeneratedAutoNumber(query As String) As Integer
        Dim id As Integer = 0
        Dim urutan As Integer = 0
        Using myConnection As SqlConnection = New SqlConnection(ConnectionString())
            Using myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Try
                    myConnection.Open()
                    Dim myReader As SqlDataReader = myCommand.ExecuteReader
                    myReader.Read()
                    If myReader.HasRows Then
                        If IsDBNull(myReader.Item(0)) Then
                            urutan = 1
                        Else
                            urutan = myReader.Item(0) + 1
                        End If
                    End If
                    myReader.Close()
                    myCommand.Dispose()
                    myConnection.Close()
                Catch ex As Exception
                    myCommand.Dispose()
                    myConnection.Close()
                    Throw ex
                End Try
            End Using
        End Using
        id = urutan
        Return id
    End Function
    Public Function GeneratedCode(query As String, code As String) As String
        Dim hasil As String
        Dim urutan As String
        Dim hitung As Long

        Try
            reader = ExecuteReader(query)
            reader.Read()

            If IsDBNull(reader.Item("Code")) Then
                urutan = code + "000001"
            Else
                hitung = Microsoft.VisualBasic.Right(reader.Item("Code"), 6) + 1
                urutan = code & Microsoft.VisualBasic.Right("000000" & hitung, 6)
            End If

            hasil = urutan
            reader.Close()
            Return hasil
        Catch ex As Exception
            reader.Close()
            Throw ex
        End Try
    End Function
    Public Function ValidationValue(query As String) As Boolean
        Using myConnection As SqlConnection = New SqlConnection(ConnectionString())
            Dim status As Boolean = False
            Using myCommand As SqlCommand = New SqlCommand(query, myConnection)
                Try
                    myConnection.Open()
                    Dim myReader As SqlDataReader = myCommand.ExecuteReader
                    myReader.Read()
                    If myReader.HasRows Then
                        status = True
                    End If
                    myReader.Close()
                    myCommand.Dispose()
                Catch ex As Exception
                    Throw ex
                End Try
            End Using
            Return status
            myConnection.Close()
        End Using
    End Function
    Public Sub InsertMasterDetail(queryList As List(Of String))
        Using myConnection As SqlConnection = New SqlConnection(ConnectionString())
            myConnection.Open()
            Using myCommand As SqlCommand = myConnection.CreateCommand
                Using myTransaction As SqlTransaction = myConnection.BeginTransaction("Master Detail")
                    myCommand.Connection = myConnection
                    myCommand.Transaction = myTransaction
                    Try
                        For Each sqlDetail In queryList
                            myCommand.CommandText = sqlDetail
                            myCommand.ExecuteNonQuery()
                        Next

                        myTransaction.Commit()
                        myConnection.Close()
                        myCommand.Dispose()
                    Catch ex As Exception
                        myConnection.Close()
                        myCommand.Dispose()
                        Throw ex
                        Try
                            myTransaction.Rollback()
                        Catch ex2 As Exception
                            Throw ex2
                        End Try
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Function MD5Hash(value As String) As Byte()
        Try
            Dim md5 As New MD5CryptoServiceProvider
            Dim des As New TripleDESCryptoServiceProvider
            Return md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Encrypted(input As String, key As String) As String
        Try
            Dim md5 As New MD5CryptoServiceProvider
            Dim des As New TripleDESCryptoServiceProvider

            des.Key = MD5Hash(key)
            des.Mode = CipherMode.ECB

            Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(input)
            Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Decrypted(input As String, key As String) As String
        Try
            Dim md5 As New MD5CryptoServiceProvider
            Dim des As New TripleDESCryptoServiceProvider

            des.Key = MD5Hash(key)
            des.Mode = CipherMode.ECB

            Dim buffer As Byte() = Convert.FromBase64String(input)
            Return ASCIIEncoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
