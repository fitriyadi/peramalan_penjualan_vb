Public Class clsRamal
    Public id As Int32
    Public bulan As Int32
    Public tahun As Int32
    Public jumlah As Int32
    Public status As String

    Sub New(ByVal _id As Int32 _
            , ByVal _bulan As Int32 _
            , ByVal _tahun As Int32 _
            , ByVal _jumlah As Int32 _
            , ByVal _status As String)
        id = _id
        bulan = _bulan
        tahun = _tahun
        jumlah = _jumlah
        status = _status

    End Sub
    Sub printData()
        Debug.WriteLine(id & vbTab & bulan & vbTab & tahun & vbTab & jumlah & vbTab & status)
    End Sub

End Class
