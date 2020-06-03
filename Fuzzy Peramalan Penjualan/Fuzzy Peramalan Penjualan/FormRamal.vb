Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormRamal

    

    '' untuk mengkosongkan dan atur kolom 
    Sub ClearInput()

        Me.dataView.Columns.Clear()
        Me.dataView.Columns.Add("No", "No.")
        Me.dataView.Columns.Add("Tahun", "Tahun")
        Me.dataView.Columns.Add("Bulan", "Bulan")
        Me.dataView.Columns.Add("Hasil", "Hasil Peramalan")
        Me.dataView.Columns.Add("Hasil_Kesalahan", "Hasil Kesalahan")
        'Me.dataView.Columns.Add("Stok", "Stok")
        'Me.dataView.Columns.Add("ERROR", "ERROR")

        Me.dataView.Rows.Clear()

        cbTahun.Items.Clear() 
        cbTahun.Items.Add("All")

        'lblMAD.Text = "MAD : "
        'lblMse.Text = "MSE : "



        cbTahun.SelectedIndex = 0

    End Sub
    Dim DataBarang As ArrayList
    Dim DataPenjualan As ArrayList
    Dim KodeData As ArrayList
    '------ kedua jalan fungsi reload untuk isi nilai dropdown list
    Public Sub Reload()
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        ClearInput()                                                '' untuk mengkosongkan dan atur kolom 

        Try
            conn.MysqlConn.Open()
            Dim i As Integer = 0
            Dim Sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            '------------------------------------------------------------------------------------------
            DataBarang = New ArrayList
            Sql = " SELECT tb_barang.id_barang, tb_barang.nama_barang, tb_barang.tipe, tb_barang.harga FROM tb_barang INNER JOIN tb_penjualan ON tb_barang.id_barang = tb_penjualan.id_barang GROUP BY tb_barang.id_barang  "
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            KodeData = New ArrayList
            Dim idx As Int16 = 1
            While reader.Read()

                Dim barang As New ClsBarang(reader.GetString(0), _
                                            reader.GetString(1), _
                                            reader.GetString(2), _
                                            reader.GetString(3))

                DataBarang.Add(barang)

                idx = idx + 1
            End While
            reader.Close()

            '---- buat ambil data barang dari database untuk pehitungan ------------------- 

            '----------------untuk set nilai dropdown cbIDBarang---------------
            Dim tb As New DataTable
            cbIDBarang.DisplayMember = "Text"
            cbIDBarang.ValueMember = "Value"
            tb.Columns.Add("Text", GetType(String))
            tb.Columns.Add("Value", GetType(String))
            Sql = "SELECT  tb_barang.tipe,tb_barang.nama_barang,tb_barang.id_barang FROM tb_penjualan INNER JOIN tb_barang ON tb_penjualan.id_barang = tb_barang.id_barang GROUP BY tb_barang.id_barang"
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            While reader.Read()

                tb.Rows.Add(reader.GetString(1), reader.GetString(2))
                idx = idx + 1
            End While

            cbIDBarang.DataSource = tb
            reader.Close()
            '------------------------------------------------------------------------------

            'untuk set nilai dropdown cbTahun-----------------------------------------------
            Sql = " SELECT " & _
                      "  tb_penjualan.tahun  " & _
                      "  FROM  tb_penjualan GROUP BY tb_penjualan.tahun   "
            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()

            cbTahun.Items.Clear()
            While reader.Read()

                cbTahun.Items.Add(CInt(reader.GetString(0)) + 0) 'ambil thn
                idx = idx + 1
            End While

            'cbTahun.Items.Add("All")
            cbTahun.SelectedIndex = 0

            reader.Close()
            '--------------------------------untuk set nilai dropdown cbTahun-----
            conn.MysqlConn.Close()


        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try
    End Sub
    'ini pertama buka form ramal
    Private Sub FormRamal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Sub logArray(ByVal a As ArrayList)
        For i = 0 To a.Count - 1
            Debug.WriteLine(a(i))
        Next
    End Sub
    '-----------untuk cetak saat proses peramalan----------
    Sub cetak(ByVal a As String)
        Debug.WriteLine(a)
    End Sub


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnRamal.Click
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString

        Dim dash As String = "---------------------------------------------------------------------"

        Try
            conn.MysqlConn.Open()
            Dim idx As Integer = 0
            Dim Sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim Tahun As New ArrayList()
            Dim Bulan As New ArrayList()
            Dim data_jumlah As New ArrayList()
            Dim Barang As ClsBarang

            Dim totJual As Double = 0

            Barang = DataBarang(cbIDBarang.SelectedIndex)
            Sql = "SELECT " & _
                "   tahun " & _
                " FROM " & _
                "   tb_penjualan " & _
                "   GROUP BY  tahun " & _
                " ORDER BY " & _
                "   tb_penjualan.tanggal ASC"

            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            idx = 1
            While reader.Read()
                Tahun.Add(reader.GetString(0))
                idx = idx + 1
            End While
            reader.Close()

            For i = 1 To 12
                Bulan.Add(i)
            Next
            cetak(dash)
            cetak("TAHUN :")
            cetak(dash)
            logArray(Tahun)
            cetak(dash)
            cetak("BULAN :")
            cetak(dash)
            logArray(Bulan)

            Dim Ramal As New ArrayList()
            Dim thn As Integer
            thn = cbTahun.Text

            Dim rerata As Integer = CInt(tb_target.Text)
            Dim dev As Integer = 0


            Dim jum_data As Integer

            For i = 0 To Tahun.Count - 1
                Sql = "SELECT count(*) FROM tb_penjualan INNER JOIN tb_barang ON tb_penjualan.id_barang = tb_barang.id_barang WHERE tahun =  '" & Tahun(i) & "' AND tb_barang.nama_barang ='" & Barang.nama & "'"
                cmd = New MySqlCommand(Sql, conn.MysqlConn)
                reader = cmd.ExecuteReader()

                While reader.Read()
                    jum_data = CInt(reader.GetString(0))
                End While
                reader.Close()

                For j = 0 To Bulan.Count - 1
                    Sql = "SELECT count(*) FROM tb_penjualan INNER JOIN tb_barang ON tb_penjualan.id_barang = tb_barang.id_barang WHERE tb_penjualan.tahun =  '" & Tahun(i) & "'  AND tb_penjualan.bulan =  '" & Bulan(j) & "' AND  tb_barang.nama_barang ='" & Barang.nama & "'"
                    cmd = New MySqlCommand(Sql, conn.MysqlConn)
                    reader = cmd.ExecuteReader()

                    While reader.Read()
                        data_jumlah.Add(reader.GetString(0))

                    End While
                    reader.Close()

                    Debug.WriteLine(Bulan(j) & "<>" & (cbTahun.SelectedIndex + 1))

                    Dim bln_start As Integer = (Bulan(j)) - rerata
                    Dim bln_end As Integer = (Bulan(j) - 1)

                    Sql = "SELECT Sum(tb_penjualan.jml_satuan) FROM tb_penjualan INNER JOIN tb_barang ON tb_penjualan.id_barang = tb_barang.id_barang WHERE tahun =  '" & Tahun(i) & "'  AND bulan between  '" & bln_start & "' AND '" & bln_end & "' and   tb_barang.nama_barang ='" & Barang.nama & "'"

                    cmd = New MySqlCommand(Sql, conn.MysqlConn)
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim tmpRamal As clsRamal
                        Dim tmpRamal_2 As clsRamal



                        If reader.IsDBNull(0) Then
                            tmpRamal = New clsRamal(0, Bulan(j), cbTahun.Text, 0, "-")
                            Ramal.Add(tmpRamal)
                            Dim hasil_kesalahan As Integer = 0 - data_jumlah(j)
                            Dim m As Integer = dataView.Rows.Add()
                            dataView.Rows.Item(m).Cells(0).Value = Ramal.Count
                            dataView.Rows.Item(m).Cells(1).Value = cbTahun.Text
                            dataView.Rows.Item(m).Cells(2).Value = Bulan(j)
                            dataView.Rows.Item(m).Cells(3).Value = 0
                            dataView.Rows.Item(m).Cells(4).Value = hasil_kesalahan

                            dev = dev + Math.Abs(hasil_kesalahan)
                        Else
                            tmpRamal = New clsRamal(Ramal.Count, Bulan(j), Tahun(i), reader.GetString(0), "-")
                            Dim hasil_ramal As Integer = Math.Ceiling(reader.GetString(0) / rerata)
                            Dim hasil_kesalahan As Integer = hasil_ramal - data_jumlah(j)
                            Dim m As Integer = dataView.Rows.Add()
                            dataView.Rows.Item(m).Cells(0).Value = Ramal.Count
                            dataView.Rows.Item(m).Cells(1).Value = cbTahun.Text
                            dataView.Rows.Item(m).Cells(2).Value = Bulan(j)
                            dataView.Rows.Item(m).Cells(3).Value = hasil_ramal
                            dataView.Rows.Item(m).Cells(4).Value = hasil_kesalahan


                            dev = dev + Math.Abs(hasil_kesalahan)

                            tmpRamal_2 = New clsRamal(Ramal.Count, Bulan(j), Tahun(i), reader.GetString(0), "-")
                            Ramal.Add(tmpRamal)

                            MsgBox("->" + Bulan(j).ToString() + "," + tmpRamal.jumlah.ToString)

                            'Try
                            'tmpRamal_2 = Ramal.Item(2)
                            ' Catch ex As Exception
                            ' tmpRamal_2.status = ""
                            'tmpRamal_2.bulan = Bulan(j)
                            'tmpRamal_2.tahun = Tahun(i)
                            'tmpRamal_2.jumlah = 0
                            'tmpRamal_2.id = 0
                            'End Try

                            'MsgBox("-->" + tmpRamal_2.jumlah.ToString)
                        End If

                    End While
                    reader.Close()




                Next
            Next

            Dim hasil_dev = dev / jum_data
            lblMAD.Text = "MAD : " & hasil_dev.ToString()


















            'cari min max
            Dim XMin As Int32 = Int32.MaxValue
            Dim XMax As Int32 = Int32.MinValue

            cetak(dash)
            cetak("DATA PENJUALAN :")
            cetak(dash)
            For i = 0 To Ramal.Count - 1
                Dim tmpRamal As clsRamal = Ramal(i)
                tmpRamal.printData()

                If (tmpRamal.jumlah > XMax) Then
                    XMax = tmpRamal.jumlah
                End If

                If (tmpRamal.jumlah < XMin) Then
                    XMin = tmpRamal.jumlah
                End If

            Next

            If (Ramal.Count = 0) Then
                MsgBox("Data penjualan untuk filter tersebut tidak ditemukan..")

                Exit Sub
            End If

            cetak(dash)
            cetak("XMax : " & XMax)
            cetak("XMin : " & XMin)
            'cari min max

            '--------- cari interval 
            Dim Data_Interval As New ArrayList()
            For i = 1 To Ramal.Count - 1
                Dim tmpRamal As clsRamal = Ramal(i - 1)
                Dim tmpRamal_2 As clsRamal = Ramal(i)
                Data_Interval.Add(Math.Abs(tmpRamal_2.jumlah - tmpRamal.jumlah))
            Next

            Dim total_data_interval = 0

            cetak(dash)
            cetak("DATA INTERVAL :")
            cetak(dash)
            For i = 0 To Data_Interval.Count - 1
                cetak(i & " : " & Data_Interval(i))
                total_data_interval += Data_Interval(i)
            Next
            cetak(dash)
            cetak("TOTAL DATA INTERVAL : " & total_data_interval)


            Dim selisih As Double = XMax - XMin
            Dim rata As Double = (total_data_interval / Data_Interval.Count)
            Dim jarak As Double = rata / 2
            Dim Basis As Double
            Basis = rata / 2

            Dim Jangkauan_Interval As Double = selisih / Basis
            Dim interval As Integer = Jangkauan_Interval

            If (interval Mod 2 = 0) Then
                interval -= 0
            Else

            End If


            cetak(dash)
            cetak("Selisih : " & selisih)
            cetak("Rata : " & rata)
            cetak("Basis : " & Basis)
            cetak("Jangkauan Interval : " & Jangkauan_Interval)
            cetak("Nilai Interval : " & interval)
            cetak(dash)
            '-------- untuk cari interval

            '---------------- untuk pengurutan data dr dmin dan dmax untuk universe-------------------------
            Dim U As ArrayList
            U = New ArrayList
            U.Add(New ClsUniverse(U.Count, XMin + Basis, XMin))
            U.Add(New ClsUniverse(U.Count, XMin + Basis + 1, XMin))

            For i = 1 To interval - 1
                Dim tmpUniv As ClsUniverse
                tmpUniv = U(i - 1)
                U.Add(New ClsUniverse(U.Count, tmpUniv.xMax + Basis, tmpUniv.xMax))
                If (i Mod 2 = 0) Then
                    U.Add(New ClsUniverse(U.Count, tmpUniv.xMax + Basis + 1, tmpUniv.xMax))
                Else
                    U.Add(New ClsUniverse(U.Count, tmpUniv.xMax + Basis, tmpUniv.xMax))
                End If

            Next
            cetak("UNIVERSE")
            cetak(dash)
            For i = 0 To U.Count - 1
                Dim tmpUniv As ClsUniverse = U(i)
                tmpUniv.printData()
            Next
            '------------------------------untuk pengurutan data dr dmin dan dmax untuk universe-----------------------

            '------------------------- proses fuzzyfikasi dan hasil fuzzy set------------------------------------------------
            Dim A As Dictionary(Of String, Double)
            A = New Dictionary(Of String, Double)
            A.Add("-", 0)
            For i = 0 To interval - 1
                Dim tmpUniv As ClsUniverse
                tmpUniv = U(i)


                A.Add(tmpUniv.FuzzyName, tmpUniv.xMin + ((tmpUniv.xMax - tmpUniv.xMin) / 2))
            Next
            cetak(dash)
            cetak("FUZZY SET")
            cetak(dash)
            Dim pairA As KeyValuePair(Of String, Double)
            For Each pairA In A
                cetak(pairA.Key & " : " & pairA.Value)
            Next


            cetak(dash)
            cetak("FUZZIFIKASI")
            cetak(dash)
            For i = 0 To Ramal.Count - 1
                Dim tmpData As clsRamal = Ramal(i)
                For j = 0 To U.Count - 1
                    Dim u_ As ClsUniverse = U(j)
                    If (tmpData.status = "-" And tmpData.jumlah <= u_.xMax) Then
                        tmpData.status = u_.FuzzyName
                    End If

                Next
                Ramal(i) = tmpData
            Next

            cetak(dash)
            cetak("HASIL FUZZIKIKASI :")
            cetak(dash)
            For i = 0 To Ramal.Count - 1
                Dim tmpRamal As clsRamal = Ramal(i)
                tmpRamal.printData()
            Next
            '--------------------------------proses fuzzyfikasi -----------------------------------------

            '--------------- proses fuzzylogic relationship-----------------------------------------
            cetak(dash)
            cetak("FUZZY LOGIC RELATIONSHIP")

            Dim FLR_Group As New Dictionary(Of String, ArrayList)
            For i = 0 To Ramal.Count - 2
                Dim tmpData As clsRamal = Ramal(i)
                Dim tmpDataNext As clsRamal = Ramal(i + 1)
                If FLR_Group.ContainsKey(tmpData.status) Then
                    If FLR_Group.Item(tmpData.status).Contains(tmpDataNext.status) Then

                    Else
                        FLR_Group.Item(tmpData.status).Add(tmpDataNext.status)
                    End If
                Else
                    Dim tmpNew As New ArrayList()
                    tmpNew.Add(tmpDataNext.status)
                    FLR_Group.Add(tmpData.status, tmpNew)
                End If
            Next

            cetak(dash)
            Dim pair As KeyValuePair(Of String, ArrayList)
            For Each pair In FLR_Group
                cetak("Group Rule  " & pair.Key & "->")
                logArray(pair.Value)
                cetak(dash)
            Next
            '-------------------proses fuzzylogic relationship=----------------------


            '--------------------- prosess defuzzyfikasi-----------------------------
            Dim Forcasted As New Dictionary(Of String, Double)

            cetak("DEFUZZYFIKASI")
            cetak(dash)
            For Each pair In FLR_Group
                Dim fuzzValue As Double = 0
                For i = 0 To pair.Value.Count - 1
                    Dim tmpStates As String = pair.Value(i)
                    'fuzzValue = fuzzValue + A(tmpStates)
                Next
                If (pair.Key = "-") Then
                    ' Forcasted.Add("A1", fuzzValue / pair.Value.Count)
                Else
                    ' Forcasted.Add(pair.Key, fuzzValue / pair.Value.Count)
                End If

            Next
            For Each pairA In Forcasted
                cetak(" " & pairA.Key & " -> " & pairA.Value)
            Next

            cetak(dash)
            cetak("FINISH")

            '--------------------- prosess defuzzyfikasi-----------------------------

            Dim RataJual As Double
            RataJual = totJual / Ramal.Count

            Dim HasilBaru As Integer = XMin + selisih / Basis
            Dim HasilFuzzy As String = "A0"

            For j = 0 To U.Count - 1
                Dim u_ As ClsUniverse = U(j)
                If (HasilBaru >= u_.xMin And HasilBaru < u_.xMax) Then
                    HasilFuzzy = u_.FuzzyName
                End If
            Next

            cetak(dash)
            cetak("HASIL PERAMALAN :")
            cetak(dash)
            For i = 0 To Ramal.Count - 1
                Dim tmpRamal As clsRamal = Ramal(i)
                'cetak(Forcasted.Item(tmpRamal.status))
            Next

            '------------------ selesai--------------------



            cetak(dash)
            cetak("DATA HASIL PERAMALAN BARU")

            Dim n As Integer

            '------ buat atur chart----------------------------------
            Chart1.Series.Clear()
            Chart1.ChartAreas.Clear()
            Chart1.ChartAreas.Add("MainChartArea")
            Chart1.Titles.Add("Hasil Peramalan Barang " & cbIDBarang.SelectedItem.ToString)

            Dim s As New Series
            s.Name = "Penjualan"
            s.ChartType = SeriesChartType.Line
            Dim r As New Series
            r.Name = "Peramalan"
            r.ChartType = SeriesChartType.Line


            For i = 0 To Ramal.Count - 1
                Dim tmpHasil As clsRamal = Ramal(i)
                s.Points.AddXY(tmpHasil.bulan & "/" & tmpHasil.tahun, tmpHasil.jumlah)
                'r.Points.AddXY(tmpHasil.bulan & "/" & tmpHasil.tahun, Forcasted.Item(tmpHasil.status))

            Next

            '------------------- hapus data dr tbhasil-----------------------
            cmd.CommandText = " DELETE FROM `tb_hasil` WHERE  `id_barang` = " & _
                   " '" & Barang.id & "'  "
            cmd.ExecuteNonQuery()
            '------------------- hapus data dr tbhasil-----------------------

            Dim MSE As Double = 0
            Dim AFER As Double = 0
            '-------
            dataView.Rows.Clear()
            idx = 1
            Dim HasilRamal As clsRamal
            Dim isOK As Boolean = False
            Dim nilaiHasil As String
            Dim bulanHasil As String
            Dim nilaiHasilKomplit As String
            Dim bulanHasilKomplit As String
            Dim bulanHasilVertikal As String
            nilaiHasil = ""
            bulanHasilKomplit = ""
            nilaiHasilKomplit = ""
            bulanHasilVertikal = ""
            bulanHasil = ""
            Dim ii As String
            ii = "memenuhi"
            For i = 0 To Ramal.Count - 1
                Dim tmpHasil As clsRamal = Ramal(i)

                If (CStr(tmpHasil.tahun + 1) = (cbTahun.SelectedItem.ToString)) Or cbTahun.SelectedItem.ToString = "All" Then

                    HasilRamal = Ramal(i)

                    n = dataView.Rows.Add()
                    dataView.Rows.Item(n).Cells(0).Value = idx & ". "
                    dataView.Rows.Item(n).Cells(1).Value = tmpHasil.tahun + 1
                    dataView.Rows.Item(n).Cells(2).Value = tmpHasil.bulan
                    dataView.Rows.Item(n).Cells(3).Value = tmpHasil.jumlah

                    If (i = 0) Then                                 '--------------- jika hasil ksong keluar - tok 
                        dataView.Rows.Item(n).Cells(3).Value = "-"
                    Else                                            '---- jika ada data maka ini yang di jalankan
                        Dim tmpHasil_Ramal As clsRamal = Ramal(i - 1)
                        dataView.Rows.Item(n).Cells(3).Value = (Forcasted.Item(tmpHasil_Ramal.status))

                        MsgBox("nilai e" + Forcasted.Item(tmpHasil_Ramal.status).ToString + "," + tb_target.Text)

                        '-------------untuk limit target penjualan---------------------
                        If (Val(Forcasted.Item(tmpHasil_Ramal.status).ToString) < Val(tb_target.Text)) Then
                            nilaiHasil += Forcasted.Item(tmpHasil_Ramal.status).ToString + " " & vbNewLine
                            MsgBox(nilaiHasil + ", ->" + Forcasted.Item(tmpHasil_Ramal.status).ToString)
                            bulanHasil += tmpHasil.bulan.ToString + " " & vbNewLine
                            bulanHasilVertikal += tmpHasil.bulan.ToString + " "
                            ii = "tidak memenuhi"
                        Else
                            nilaiHasilKomplit += Forcasted.Item(tmpHasil_Ramal.status).ToString + " " & vbNewLine
                            bulanHasilKomplit += tmpHasil.bulan.ToString + " " & vbNewLine
                        End If
                        '-------------untuk limit target penjualan---------------------

                        '--------- atur nilaiuntuk report di form laporan--------------
                        MsgBox("ramal count " & (Ramal.Count - 1))
                        If (i = (Ramal.Count - 1)) And ii.Equals("memenuhi") Then
                            nilaiHasil = nilaiHasilKomplit
                            bulanHasil = bulanHasilKomplit
                            bulanHasilVertikal = " target memenuhi sam"
                            MsgBox("aktif")
                        End If
                        '--------- atur nilaiuntuk report di form laporan--------------

                        MsgBox("status e" & Barang.nama.ToString & "," & tmpHasil.jumlah & "," & tmpHasil.bulan & "," & tmpHasil.tahun & "," & nilaiHasil)

                        'isi data e tb hasil atau hasil peramalan
                        cmd.CommandText = " INSERT INTO `tb_hasil` " & _
                    " ( `id_barang`,`hasil`,`bulan`, `tahun`, `hsl_ramal`,  `catatan`  ) " & _
                    " VALUES ('" & Barang.id & "' " & _
                    ", '" & tmpHasil.jumlah & "'  " & _
                    ", '" & tmpHasil.bulan & "'  " & _
                    ", '" & tmpHasil.tahun & "'  " & _
                     ", '" & Forcasted.Item(tmpHasil_Ramal.status).ToString & "'  " & _
                    ", '" & "-" & "'    ) "

                        cmd.ExecuteNonQuery()

                        dataView.Rows.Item(n).Cells(5).Value = ((Math.Abs(tmpHasil.jumlah - Forcasted.Item(tmpHasil_Ramal.status))))
                        '", '0'  " & _
                        AFER += 100 * ((Math.Abs(tmpHasil.jumlah - (Forcasted.Item(tmpHasil_Ramal.status))) / tmpHasil.jumlah))
                        MSE += Math.Pow(tmpHasil.jumlah - Forcasted.Item(tmpHasil_Ramal.status), 2)


                        '-------------------------- untuk grafik hasil ----------------------------------
                        s.Points.AddXY(tmpHasil.bulan + 1 & "/" & tmpHasil.tahun, tmpHasil.jumlah)
                        r.Points.AddXY(tmpHasil.bulan + 1 & "/" & tmpHasil.tahun, Forcasted.Item(tmpHasil_Ramal.status))
                        '-------------------------- untuk grafik hasil ----------------------------------

                    End If
                    HasilRamal.bulan = tmpHasil.bulan + 1
                    HasilRamal.tahun = tmpHasil.tahun
                    HasilRamal.jumlah = CInt(Forcasted.Item(tmpHasil.status))

                    idx = idx + 1
                End If
            Next

            '----------------------------isi ndeek tb cetak gawe print-----------------------------

            Dim catatan As String
            Sql = "SELECT " & _
                "   tb_barang.tipe,  tb_barang.nama_barang " & _
                " FROM " & _
                "   tb_barang order by rand() limit 0,5 "

            If ii.Equals("memenuhi") Then
                catatan = "memenuhi target penjualan untuk barang " & cbIDBarang.Text & "  "
            Else
                catatan = "Pada bulan : " & bulanHasilVertikal.ToString & " tidak memenuhi target penjualan untuk barang " & cbIDBarang.Text & " maka dapat dijual barang : "
            End If


            cmd = New MySqlCommand(Sql, conn.MysqlConn)
            reader = cmd.ExecuteReader()
            Dim namaBarang As String = ""
            While reader.Read()
                If ii.Equals("tidak memenuhi") Then
                    namaBarang &= reader.GetString(1) & ", "
                End If
            End While
            If ii.Equals("tidak memenuhi") Then
                namaBarang &= " dll. "
            End If
            catatan &= namaBarang

            reader.Close()

            cmd.CommandText = " DELETE FROM `tb_hasil_cetak`  "
            cmd.ExecuteNonQuery()

            ''''] Ini untuk masuk ke laporan '''''''''
            If bulanHasil.Equals("") Then
                bulanHasil = "Memenuhi Target"
                bulanHasilVertikal = "Memenuhi Target"
            End If
            cmd.CommandText = " delete from `tb_hasil_cetak` where id_barang='" & cbIDBarang.SelectedValue.ToString & "' and tahun=" & cbTahun.Text
            cmd.ExecuteNonQuery()

            cmd.CommandText = " INSERT INTO `tb_hasil_cetak` " & _
                    " ( `id_barang`,`kategori`, `hasil`,`bulan`, `tahun`,  `catatan`  ) " & _
                    " VALUES ('" & cbIDBarang.SelectedValue.ToString & "' " & _
                    ", '" & cbIDBarang.Text & "'  " & _
                    ", '" & nilaiHasil.ToString & "'  " & _
                    ", '" & bulanHasil.ToString & "'  " & _
                    ", '" & cbTahun.Text & "'  " & _
                    ", '" & catatan & "'    ) "
            Sql = "SELECT" &
            cmd.ExecuteNonQuery()

            MSE = MSE / (Ramal.Count - 1)
            'AFER = AFER / (Ramal.Count - 1)
            'lblMAD.Text = "AFER : " & AFER & " %"
            lblMAD.Text = "MSE : " & MSE

            n = dataView.Rows.Add()
            dataView.Rows.Item(n).Cells(0).Value = "Hasil Peramalan"
            dataView.Rows.Item(n).Cells(1).Value = Tahun(Tahun.Count - 1) + 1
            dataView.Rows.Item(n).Cells(2).Value = 1
            dataView.Rows.Item(n).Cells(3).Value = HasilBaru
            'dataView.Rows.Item(n).Cells(4).Value = CInt(Forcasted.Item(HasilFuzzy))
            dataView.Rows.Item(n).DefaultCellStyle.BackColor = Color.Gold


            dataView.AutoResizeColumns()
            dataView.AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.AllCells


            '------------ untuk keperluan grafik---------------------------------------

            Chart1.ChartAreas("MainChartArea").AxisX.MinorTickMark.Enabled = False
            Chart1.ChartAreas("MainChartArea").AxisX.Interval = 1
            Chart1.ChartAreas("MainChartArea").AxisX.IsLabelAutoFit = True
            Chart1.ChartAreas("MainChartArea").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45

            Chart1.Series.Add(s)
            Chart1.Series.Add(r)



            reader.Close()




            conn.MysqlConn.Close()

            MessageBox.Show("Proses Peramalan Selesai... ")
        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi yyyy : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub cbIDBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIDBarang.SelectedIndexChanged

    End Sub

    Private Sub dataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataView.CellContentClick

    End Sub

    'Private Sub lblMse_Click(sender As Object, e As EventArgs) Handles lblMse.Click

    'End Sub

    Private Sub cbTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTahun.SelectedIndexChanged

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    MsgBox(cbIDBarang.Text & "," & cbIDBarang.SelectedValue)
    'End Sub

    Private Sub PanelEx2_Click(sender As Object, e As EventArgs) Handles PanelEx2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_nmrata.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbl_nmbarang.Click

    End Sub

    Private Sub lblAfer_Click(sender As Object, e As EventArgs) Handles lblMAD.Click

    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click

    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub rbBulan_CheckedChanged(sender As Object, e As EventArgs) Handles rbBulan.CheckedChanged

    End Sub


    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If (MsgBox("Yakin untuk menyimpan hasil ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then

        Else
            Dim conn As New MysqlConn()
            conn.MysqlConn.ConnectionString = conn.ConnectionString
            Try
                conn.MysqlConn.Open()
                Dim cmd As MySqlCommand
                Dim Barang As ClsBarang

                Barang = DataBarang(cbIDBarang.SelectedIndex)
                Dim Sql As String = " INSERT INTO `tb_hasil` WHERE  `id_hasil` = " & _
                       " '" & Barang.kategori & "' "
                cmd = New MySqlCommand(Sql, conn.MysqlConn)
                cmd.CommandText = Sql

                cmd.ExecuteNonQuery()

                conn.MysqlConn.Close()

            Catch myerror As MySqlException
                MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
            Finally
                conn.MysqlConn.Dispose()
            End Try
        End If
    End Sub
End Class