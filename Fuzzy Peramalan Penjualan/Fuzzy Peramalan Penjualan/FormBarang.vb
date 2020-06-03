Imports MySql.Data.MySqlClient

Public Class FormBarang
    Dim Defaults As String = ""
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click

        Reload()
    End Sub
    Sub ClearInput()

        txtNama.Text = Defaults
        txtHarga.Text = Defaults 
        txtIDBarang.Text = Defaults


        txtIDBarang.Enabled = True
        btnSimpan.Text = "Simpan"
         
        txtHarga.Text = "0"
        'txtStok.Text = "0"


        Me.dataView.Columns.Clear()
        Me.dataView.Columns.Add("No", "No.")
        Me.dataView.Columns.Add("ID", "ID")
        Me.dataView.Columns.Add("Nama", "Nama")
        Me.dataView.Columns.Add("Tipe", "Tipe")
        Me.dataView.Columns.Add("Harga", "Harga")


        Me.dataView.Rows.Clear()

    End Sub
    Dim DataBarang As ArrayList

    Public Sub Reload()
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        ClearInput()

        Try
            conn.MysqlConn.Open()
            Dim i As Integer = 0
            Dim kode As String = String.Format("B{0:000}", i)
            Dim ketemu As Boolean = False
            Dim Sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            While Not ketemu
                i = i + 1
                kode = String.Format("B{0:000}", i)
                Sql = " SELECT " & _
                        " tb_barang.id_barang," & _
                        " tb_barang.nama_barang," & _
                        " tb_barang.tipe," & _
                        " tb_barang.harga" & _
                        "  FROM tb_barang where  id_barang ='" & kode & "' "
                cmd = New MySqlCommand(Sql, conn.MysqlConn)
                reader = cmd.ExecuteReader()
                If (Not reader.HasRows) Then
                    ketemu = True
                End If
                reader.Close()
            End While
            DataBarang = New ArrayList
            Sql = " SELECT " & _
                       " tb_barang.id_barang," & _
                       " tb_barang.nama_barang," & _
                       " tb_barang.tipe," & _
                       " tb_barang.harga" & _
                       "  FROM tb_barang  "
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            KodeData = New ArrayList
            dataView.Rows.Clear()
            Dim idx As Int16 = 1
            While reader.Read()

                Dim n As Integer = dataView.Rows.Add()
                dataView.Rows.Item(n).Cells(0).Value = idx & ". "
                dataView.Rows.Item(n).Cells(1).Value = reader.GetString(0)
                dataView.Rows.Item(n).Cells(2).Value = reader.GetString(1)
                dataView.Rows.Item(n).Cells(3).Value = reader.GetString(2)
                'dataView.Rows.Item(n).Cells(4).Value = reader.GetString(3)
                'dataView.Rows.Item(n).Cells(5).Value = reader.GetString(4)
                KodeData.Add(reader.GetString(0))
                Dim barang As New ClsBarang(reader.GetString(0), _
                                            reader.GetString(1), _
                                            reader.GetString(2), _
                                            reader.GetString(3))


                DataBarang.Add(barang)
                idx = idx + 1 
            End While
            dataView.AutoResizeColumns()
            dataView.AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.AllCells


            reader.Close()

            Sql = " SELECT " & _
                       "  tb_kategori.kategori  " & _
                       "  FROM tb_kategori  "
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()

            cbIDBarang.Items.Clear() 
            While reader.Read()
                  
                cbIDBarang.Items.Add(reader.GetString(0)) 
                idx = idx + 1
            End While
            cbIDBarang.SelectedIndex = 0

            reader.Close()
            conn.MysqlConn.Close()
            txtIDBarang.Text = kode

        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi 87 : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If (MsgBox("Yakin untuk menyimpan data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
           
                SimpanData() 
        End If
    End Sub


    Private Sub SimpanData()

        Dim id As String = txtIDBarang.Text.Trim
        Dim nama As String = txtNama.Text.Trim
        Dim tipe As String = cbIDBarang.SelectedItem.ToString.Trim
        Dim harga As String = txtHarga.Value
        'Dim stok As String = txtStok.Value

        If (id.Length = 0 Or nama.Length = 0 Or tipe.Length = 0 Or harga.Length = 0) Then
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
                cmd.CommandText = " INSERT INTO `tb_barang` " & _
                    " ( `id_barang`, `nama_barang`, `tipe`, `harga` ) " & _
                    " VALUES ('" & id & "' " & _
                    ", '" & nama & "' " & _
                    ", '" & tipe & "' " & _
                    ", '" & harga & "' " & _
                    "     ) "
            Else
                cmd.CommandText = " UPDATE  `tb_barang` SET " & _
                   "  `nama_barang` = '" & nama & _
                   "' , `tipe` = '" & tipe & _
                   "' , `harga`= '" & harga & _
                   "'  WHERE  `id_barang`  = '" & id & "' "
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

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        If (MsgBox("Yakin untuk menghapus data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            HapusData()
        End If
    End Sub

    Public KodeData As ArrayList

    Private Sub HapusData()


        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        Dim cmd As New MySqlCommand()

        Dim kode As String = KodeData(dataView.SelectedRows.Item(0).Index)
        Try
            conn.MysqlConn.Open()
            cmd.Connection = conn.MysqlConn

            cmd.CommandText = " DELETE FROM `tb_barang` WHERE id_barang = '" & kode & "' "
            Debug.WriteLine(" DELETE FROM `tb_barang` WHERE id_barang = '" & kode & "' ")

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


        Dim barang As ClsBarang
        barang = DataBarang(dataView.SelectedRows.Item(0).Index)

        txtIDBarang.Text = barang.id
        txtNama.Text = barang.nama
        txtHarga.Text = barang.harga
        cbIDBarang.Text = barang.kategori
        'txtStok.Text = barang.stok

        txtIDBarang.Enabled = False
        btnSimpan.Text = "Update"


    End Sub

    Private Sub cbIDBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIDBarang.SelectedIndexChanged

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Tipe As String = InputBox("Tipe Barang", "Isikan Tipe Barang")
        If Tipe.Trim <> "" Then
            Dim conn As New MysqlConn()
            conn.MysqlConn.ConnectionString = conn.ConnectionString

            Dim cmd As New MySqlCommand()
            Try
                conn.MysqlConn.Open()


                cmd.Connection = conn.MysqlConn
                cmd.CommandText = " Delete from tb_kategori where kategori ='" & Tipe.Trim & "'  "

                cmd.ExecuteNonQuery()

                cmd.CommandText = " INSERT INTO `tb_kategori` " & _
                " ( `kategori`  ) " & _
                " VALUES ('" & Tipe.Trim & "'   ) "

                cmd.ExecuteNonQuery()
                conn.MysqlConn.Close()

                Reload()
                MsgBox("Proses penyimpan Kategori berhasil.", MsgBoxStyle.Exclamation)
            Catch myerror As MySqlException
                MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
            Finally
                conn.MysqlConn.Dispose()
            End Try
        Else
            MsgBox("Inputan tidak boleh kosong")

        End If

    End Sub

    Private Sub dataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataView.CellContentClick

    End Sub

    'Private Sub DoubleInput1_ValueChanged(sender As Object, e As EventArgs) Handles txtStok.ValueChanged

    'End Sub

    Private Sub LabelX5_Click(sender As Object, e As EventArgs)

    End Sub
End Class