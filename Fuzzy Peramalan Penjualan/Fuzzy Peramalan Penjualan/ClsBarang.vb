Public Class ClsBarang
    Public id As String
    Public nama As String
    Public kategori As String
    Public harga As String

    Sub New(ByVal _id As String _
            , ByVal _nama As String _
            , ByVal _tipe As String _
            , ByVal _harga As String)
        id = _id
        nama = _nama
        kategori = _tipe
        harga = _harga


    End Sub
End Class
