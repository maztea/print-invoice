
Public Class CutiService
    Public Function AddDataCuti(cuti As Cuti) As Boolean

        Return False
    End Function

    Public Function GetAllDataCuti() As List(Of Cuti)
        Return New List(Of Cuti)
    End Function
    Public Function PakaiCuti(nik As String) As Boolean
        Try
            Dim cuti As New Cuti
            cuti.PakaiCuti += 1

            Return True
        Catch ex As Exception
            Debug.WriteLine($"E: {ex.Message.ToString}")
        End Try
        Return False
    End Function
    Public Function BatalCuti(nik As String) As Boolean
        Try
            Dim cuti As New Cuti
            cuti.PakaiCuti -= 1

            Return True
        Catch ex As Exception
            Debug.WriteLine($"E: {ex.Message.ToString}")
        End Try
        Return False
    End Function
End Class