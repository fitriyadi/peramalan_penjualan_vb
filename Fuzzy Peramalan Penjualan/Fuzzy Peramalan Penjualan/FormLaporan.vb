Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormLaporan
    '---------------- pertama---------------------
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString
        
        Try
            conn.MysqlConn.Open()
            Dim idx As Integer = 0
            Dim Sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim Tahun As New ArrayList()
            Dim Bulan As New ArrayList()

            Dim totJual As Double = 0 
            Sql = "SELECT " & _
                "   * " & _
                " FROM " & _
                "   tb_hasil inner join tb_barang on tb_hasil.id_barang=tb_barang.id_barang  group by tb_hasil.id_barang   " & _
                " ORDER BY " & _
                "   tahun ASC"

            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            idx = 1

            cbIDBarang.Items.Clear()
            While reader.Read() 
                cbIDBarang.Items.Add(reader.GetString(9))               '------ isi ke dropdown-----------

                idx = idx + 1
                End While
            reader.Close()
            '---------------- untuk pilih tahun-------------
            Sql = "SELECT " & _
                "   `id_barang`, `hasil`, `bulan`, `tahun`, `catatan` " & _
                " FROM " & _
                "   tb_hasil group by tahun  " & _
                " ORDER BY " & _
                "   tahun ASC "

            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader() 
            cbTahun.Items.Clear()

            While reader.Read() 
                cbTahun.Items.Add(reader.GetString(3) + 1)
            End While
            reader.Close()
            '---------------- untuk pilih tahun-------------

             
             
            cbTahun.SelectedIndex = 0
            cbIDBarang.SelectedIndex = 0

            conn.MysqlConn.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        

        Me.tb_hasil_cetak_lagiTableAdapter.FillbyFilter(Me.db_peramalan_penjualanDataSet.tb_hasil_cetak_lagi, cbTahun.SelectedItem.ToString, cbIDBarang.SelectedItem.ToString)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        ReportViewer1.PrintDialog()
    End Sub

    Private Sub TbhasilcetakBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbIDBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIDBarang.SelectedIndexChanged

    End Sub

    Private Sub cbTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTahun.SelectedIndexChanged
      
    End Sub
End Class