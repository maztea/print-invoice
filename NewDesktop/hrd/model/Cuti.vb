
Public Class Cuti
    Private mTahunCuti As String
    Public Property TahunCuti() As String
        Get
            Return mTahunCuti
        End Get
        Set(ByVal value As String)
            mTahunCuti = value
        End Set
    End Property
    Private mNIK As String
    Public Property NIK() As String
        Get
            Return mNIK
        End Get
        Set(ByVal value As String)
            mNIK = value
        End Set
    End Property
    Private mJatahCuti As Integer
    Public Property JatahCuti() As Integer
        Get
            Return mJatahCuti
        End Get
        Set(ByVal value As Integer)
            mJatahCuti = value
        End Set
    End Property
    Private mPakaiCuti As Integer
    Public Property PakaiCuti() As Integer
        Get
            Return mPakaiCuti
        End Get
        Set(ByVal value As Integer)
            mPakaiCuti = value
        End Set
    End Property

    Public Function GetSisaCuti() As Integer
        Return mJatahCuti - mPakaiCuti
    End Function

End Class
