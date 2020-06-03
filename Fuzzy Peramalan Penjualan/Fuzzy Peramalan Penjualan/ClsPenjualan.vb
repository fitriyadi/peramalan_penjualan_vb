Public Class ClsPenjualan
    Public id As String
    Public id_barang As String
    Public nama As String
    Public tipe As String
    Public harga As String
    Public jml As String
    Public bulan As String
    Public tahun As String

    Sub New(ByVal _id As String _
            , ByVal _id_barang As String _
            , ByVal _nama As String _
            , ByVal _tipe As String _
            , ByVal _harga As String _
            , ByVal _jml As String _
            , ByVal _bulan As String _
            , ByVal _tahun As String)

        id = _id
        id_barang = _id_barang

        nama = _nama
        tipe = _tipe
        harga = _harga
        jml = _jml
        bulan = _bulan
        tahun = _tahun

    End Sub
End Class
