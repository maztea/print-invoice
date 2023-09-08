Public Class QueryCuti
    Private Sub QueryCuti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cuti As New Cuti
        cuti.TahunCuti = "2023"
        cuti.NIK = "1234"
        cuti.JatahCuti = 12

        Dim cutiSrv As New CutiService
        cutiSrv.GetAllDataCuti()

    End Sub
End Class