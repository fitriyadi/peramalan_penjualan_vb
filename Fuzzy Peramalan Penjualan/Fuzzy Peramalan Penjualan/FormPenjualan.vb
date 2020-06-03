Imports MySql.Data.MySqlClient

Public Class FormPenjualan
    Dim Defaults As String = ""
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click

        Reload()
    End Sub

    Sub ClearInput()

        txtNamaBarang.Text = Defaults
        txtHarga.Text = Defaults
        txtJml.Text = Defaults
        txtTipe.Text = Defaults

        cbBulan.Items.Clear()
        cbBulan.Items.Add("Januari")
        cbBulan.Items.Add("Februari")
        cbBulan.Items.Add("Maret")
        cbBulan.Items.Add("April")
        cbBulan.Items.Add("Mei")
        cbBulan.Items.Add("Juni")
        cbBulan.Items.Add("Juli")
        cbBulan.Items.Add("Agustus")
        cbBulan.Items.Add("September")
        cbBulan.Items.Add("Oktober")
        cbBulan.Items.Add("November")
        cbBulan.Items.Add("Desember")

        cbTahun.Items.Clear()
        cbTahun.Items.Add("2009")
        cbTahun.Items.Add("2010")
        cbTahun.Items.Add("2011")
        cbTahun.Items.Add("2012")
        cbTahun.Items.Add("2013")
        cbTahun.Items.Add("2014")
        cbTahun.Items.Add("2015") 
        cbTahun.Items.Add("2016")



        cbBulan.SelectedIndex = 0
        cbTahun.SelectedIndex = 0

        cbFBulan.Items.Clear()
        For i = 0 To cbBulan.Items.Count - 1
            cbFBulan.Items.Add(cbBulan.Items(i).ToString)
        Next

        cbFTahun.Items.Clear()
        For i = 0 To cbTahun.Items.Count - 1
            cbFTahun.Items.Add(cbTahun.Items(i).ToString)
        Next

        cbFBulan.SelectedIndex = 0
        cbFTahun.SelectedIndex = 0


        cbIDBarang.Enabled = True
        btnSimpan.Text = "Simpan"

        txtJml.Text = "0"
        txtHarga.Text = "0"
        txtIDJual.Text = Defaults


        Me.dataView.Columns.Clear()
        Me.dataView.Columns.Add("No", "No.")
        Me.dataView.Columns.Add("IDPenjualan", "ID Penjualan")

        Me.dataView.Columns.Add("Bulan", "Bulan/Tahun")
        Me.dataView.Columns.Add("Barang", "Barang")

        Me.dataView.Columns.Add("Kategori", "Kategori")
        Me.dataView.Columns.Add("Harga", "Harga")
        Me.dataView.Columns.Add("Jml", "Jml.Satuan")

        Me.dataView.Rows.Clear()

    End Sub
    Dim DataBarang As ArrayList
    Dim DataPenjualan As ArrayList
    Dim KodeData As ArrayList
    Public Sub Reload()
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        ClearInput()

        Try
            conn.MysqlConn.Open()
            Dim i As Integer = 0 
            Dim Sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
             
            DataBarang = New ArrayList
            Sql = " SELECT " & _
                       " tb_barang.id_barang," & _
                       " tb_barang.nama_barang," & _
                       " tb_barang.tipe," & _
                       " tb_barang.harga " & _
                       "  FROM tb_barang  "
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            KodeData = New ArrayList
            cbIDBarang.Items.Clear()
            Dim idx As Int16 = 1
            While reader.Read()
                 
                Dim barang As New ClsBarang(reader.GetString(0), _
                                            reader.GetString(1), _
                                            reader.GetString(2), _
                                            reader.GetString(3))


                DataBarang.Add(barang)
                cbIDBarang.Items.Add(barang.id & " : " & barang.nama)


                idx = idx + 1
            End While
            cbIDBarang.SelectedIndex = 0
            reader.Close()

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
                       " INNER JOIN tb_penjualan ON tb_barang.id_barang = tb_penjualan.id_barang where tb_penjualan.tanggal >= CURDATE() limit 25"
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            DataPenjualan = New ArrayList
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

                Dim jual As New ClsPenjualan(reader.GetString(0), _
                                               reader.GetString(2), reader.GetString(3), _
                                                reader.GetString(4), reader.GetString(5), _
                                                 reader.GetString(8), reader.GetString(6), _
                                                  reader.GetString(1))
                DataPenjualan.Add(jual)

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

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub cbIDBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIDBarang.SelectedIndexChanged
        Dim barang As ClsBarang
        barang = DataBarang(cbIDBarang.SelectedIndex)
        txtNamaBarang.Text = barang.nama
        txtTipe.Text = barang.kategori
        txtHarga.Text = barang.harga

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        ' If (MsgBox("Yakin untuk menyimpan data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then

        SimpanData()
        ' End If
    End Sub


    Private Sub SimpanData()
        Dim idbarang As ClsBarang
        idbarang = DataBarang(cbIDBarang.SelectedIndex)

        Dim id As String = idbarang.id
        Dim jml As String = txtJml.Text.Trim
        Dim bulan As String = cbBulan.SelectedIndex + 1
        Dim tahun As String = cbTahun.SelectedIndex + 2010

        If (id.Length = 0 Or jml.Length = 0 Or bulan.Length = 0) Then
            MsgBox("Inputan tidak boleh ada yang kosong, silahkan cek dulu..", MsgBoxStyle.Critical)
            Exit Sub
        End If


        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        Dim cmd As New MySqlCommand()
        Try
            conn.MysqlConn.Open()

            cmd.Connection = conn.MysqlConn
            If btnSimpan.Text = "Simpan" Then
                cmd.CommandText = " INSERT INTO `tb_penjualan` " & _
                    " ( `id_barang`, `jml_satuan`, `tanggal`, `bulan`, `tahun`  ) " & _
                    " VALUES ('" & id & "' " & _
                    ", '" & jml & "' " & _
                    ", NOW() " & _
                    ", '" & bulan & "'  , '" & tahun & "'    ) "
            Else
                Dim idJual As ClsPenjualan
                idJual = DataPenjualan(dataView.SelectedRows.Item(0).Index)
                cmd.CommandText = " UPDATE  `tb_penjualan` SET " & _
                   "  `jml_satuan` = '" & jml & _
                   "' , `bulan` = '" & bulan & _
                   "' , `tahun` = '" & tahun & _
                   "'    WHERE  `id_penjualan`  = '" & idJual.id & "' "
                End If
            cmd.ExecuteNonQuery()
            conn.MysqlConn.Close()

            Reload()
            MsgBox("Proses penyimpan data berhasil.", MsgBoxStyle.Exclamation)
        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try



    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        If (MsgBox("Yakin untuk menghapus data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            HapusData()
        End If
    End Sub


    Private Sub HapusData()


        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        Dim cmd As New MySqlCommand()
        Dim jual As ClsPenjualan
        jual = DataPenjualan(dataView.SelectedRows.Item(0).Index)
        Dim kode As String = jual.id
        Try
            conn.MysqlConn.Open()
            cmd.Connection = conn.MysqlConn

            cmd.CommandText = " DELETE FROM `tb_penjualan` WHERE id_penjualan ='" & kode & "' " 

            cmd.ExecuteNonQuery()

            conn.MysqlConn.Close()
            Reload()
            MsgBox("Proses penghapusan data berhasil.", MsgBoxStyle.Exclamation)
        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click


        Dim jual As ClsPenjualan
        jual = DataPenjualan(dataView.SelectedRows.Item(0).Index)

        Dim i As Integer
        For i = 0 To cbIDBarang.Items.Count - 1
            If cbIDBarang.Items(i).ToString.StartsWith(jual.id_barang) Then
                cbIDBarang.SelectedItem = i
                Exit For
            End If
        Next
         
        txtJml.Text = jual.jml
        cbBulan.SelectedIndex = jual.bulan - 1
        cbTahun.SelectedIndex = jual.tahun - 2010

        cbIDBarang.Enabled = False
        btnSimpan.Text = "Update"
        txtIDJual.Text = jual.id

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        Dim bulan As String = cbFBulan.SelectedIndex + 1
        Dim tahun As String = cbFTahun.SelectedIndex + 2010

        Dim Sql As String = ""
        If rbBulan.Checked = True Then


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
                       " INNER JOIN tb_penjualan ON tb_barang.id_barang = tb_penjualan.id_barang where tb_penjualan.bulan ='" & bulan & "' Limit 30 "

        ElseIf rbTahun.Checked = True Then

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
                       " INNER JOIN tb_penjualan ON tb_barang.id_barang = tb_penjualan.id_barang where tb_penjualan.tahun ='" & tahun & "'  Limit 30  "

        End If
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString
         

        Try
            conn.MysqlConn.Open()
            Dim i As Integer = 0
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
             
            Dim idx As Int16 = 1
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            DataPenjualan = New ArrayList
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

                Dim jual As New ClsPenjualan(reader.GetString(0), _
                                               reader.GetString(2), reader.GetString(3), _
                                                reader.GetString(4), reader.GetString(5), _
                                                 reader.GetString(8), reader.GetString(6), _
                                                  reader.GetString(1))
                DataPenjualan.Add(jual)

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

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub cbTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTahun.SelectedIndexChanged

    End Sub

    Private Sub rbBulan_CheckedChanged(sender As Object, e As EventArgs) Handles rbBulan.CheckedChanged

    End Sub

    Private Sub cbFBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFBulan.SelectedIndexChanged

    End Sub

    Private Sub cbFTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFTahun.SelectedIndexChanged

    End Sub
End Class