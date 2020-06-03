Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        'gawe handle jika inputan kosong
        If (TextBoxX1.Text.Trim = "" Or
               TextBoxX2.Text.Trim = "") Then
            MsgBox("Silahkan cek inputan, inputan tidak boleh kosong..", MsgBoxStyle.Exclamation
                   )

            Return
        End If
        Dim ada As Boolean = True
        If doLogin() Then
            FormMain.Show() 'jika login berhasil dilihat dari database,pindah halaman ke form main
            Close()
            Exit Sub
        Else
            MsgBox("Login gagal, silahkan cek username dan password anda..", MsgBoxStyle.Exclamation)
            'jika gagal muncul iki
        End If
        TextBoxX2.Text = ""
        TextBoxX1.Text = ""
        TextBoxX1.Focus()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxX2.Text = "admin"
        TextBoxX1.Text = "admin"
    End Sub
    Function doLogin() As Boolean
        Dim conn As New MysqlConn()
        conn.MysqlConn.ConnectionString = conn.ConnectionString
        Dim idx As Int16 = 0

        Try
            conn.MysqlConn.Open() 

            Dim Sql As String = " SELECT  `id_user` FROM `tb_user`   WHERE  `id_user` ='" & TextBoxX1.Text.Trim & "' AND `passwd`  =SHA1('" & TextBoxX2.Text.Trim & "')    "
            Dim cmd As MySqlCommand = New MySqlCommand(Sql, conn.MysqlConn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            FormMain.USER = ""
            FormMain.isLogin = False
            While reader.Read()
                idx = idx + 1
                FormMain.USER = TextBoxX1.Text.Trim
                FormMain.isLogin = True
            End While

            reader.Close()


            conn.MysqlConn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
        Finally
            conn.MysqlConn.Dispose()
        End Try

        If idx = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If (MsgBox("Yakin untuk menutup aplikasi?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then

            End
        Else

        End If
    End Sub
End Class