Imports MySql.Data.MySqlClient

Public Class FormMain

    Shared Property USER As String

    Private Sub ApplicationButton1_Click(sender As Object, e As EventArgs) Handles ApplicationButton1.Click

    End Sub
    Public Sub Reload()
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString


        Me.dataView.Columns.Clear()
        Me.dataView.Columns.Add("No", "No.")
        Me.dataView.Columns.Add("IDPenjualan", "ID Penjualan")

        Me.dataView.Columns.Add("Bulan", "Bulan/Tahun")
        Me.dataView.Columns.Add("Barang", "Barang")

        Me.dataView.Columns.Add("Kategori", "Kategori")
        Me.dataView.Columns.Add("Harga", "Harga")
        Me.dataView.Columns.Add("Jml", "Jml.Satuan")
        Me.dataView.Columns.Add("Tanggal", "Tanggal")

        Me.dataView.Rows.Clear()

        Try
            conn.MysqlConn.Open()
            Dim idx As Integer = 0
            Dim Sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
               
            Sql = "SELECT " & _
                       "   tb_penjualan.id_penjualan," & _
                       "   tb_penjualan.bulan," & _
                       "   tb_barang.id_barang," & _
                       "   tb_barang.nama_barang," & _
                       "   tb_barang.tipe," & _
                       "   tb_barang.harga," & _
                       "   tb_penjualan.jml_satuan," & _
                       "   tb_penjualan.tanggal ," & _
                       "   tb_penjualan.tahun " & _
                       " FROM" & _
                       "   tb_barang" & _
                       " INNER JOIN tb_penjualan ON tb_barang.id_barang = tb_penjualan.id_barang where tb_penjualan.tanggal >= CURDATE() limit 25 "
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader() 
            dataView.Rows.Clear()
            idx = 1
            While reader.Read()

                Dim n As Integer = dataView.Rows.Add()
                dataView.Rows.Item(n).Cells(0).Value = idx & ". "
                dataView.Rows.Item(n).Cells(1).Value = reader.GetString(0)
                dataView.Rows.Item(n).Cells(2).Value = reader.GetString(1) & "/" & reader.GetString(8)
                dataView.Rows.Item(n).Cells(3).Value = reader.GetString(2) & " : " & reader.GetString(3)
                dataView.Rows.Item(n).Cells(4).Value = reader.GetString(4)
                dataView.Rows.Item(n).Cells(5).Value = reader.GetString(5)
                dataView.Rows.Item(n).Cells(6).Value = reader.GetString(6)
                dataView.Rows.Item(n).Cells(7).Value = reader.GetDateTime(7).ToString("d MMMM yyyy")

                

                idx = idx + 1
            End While

            dataView.AutoResizeColumns()
            dataView.AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.AllCells


            reader.Close()
            conn.MysqlConn.Close()


        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try

    End Sub
    Public isLogin As Boolean
    Private Sub ButtonItem13_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (MsgBox("Yakin untuk menutup aplikasi?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            End
        Else

        End If
    End Sub


    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If (MsgBox("Yakin untuk menutup aplikasi?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            e.Cancel = False
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Hide()
        FormLogin.ShowDialog()
        Reload()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        FormBarang.ShowDialog(Me)
    End Sub

    Private Sub btnJual_Click(sender As Object, e As EventArgs) Handles btnJual.Click
        FormPenjualan.ShowDialog(Me)
    End Sub

    Private Sub btnRamal_Click(sender As Object, e As EventArgs) Handles btnRamal.Click
        FormRamal.ShowDialog(Me)
    End Sub

    Private Sub btnLapor_Click(sender As Object, e As EventArgs) Handles btnLapor.Click
        FormLaporan.ShowDialog(Me)
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub
End Class
