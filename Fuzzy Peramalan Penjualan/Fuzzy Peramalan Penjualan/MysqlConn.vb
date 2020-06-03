Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class MysqlConn
    Public ConnectionString = "server=" + System.Configuration.ConfigurationSettings.AppSettings("HOST") _
                            + ";user id=" + System.Configuration.ConfigurationSettings.AppSettings("USER_NAME") _
                            + ";password='" + System.Configuration.ConfigurationSettings.AppSettings("PASSWORD") _
                            + "';database=" + System.Configuration.ConfigurationSettings.AppSettings("DB_NAME") _
                            + ";Convert Zero Datetime=True"
    Public MysqlConn As New MySqlConnection()
    Public Function Connect() As Boolean
        Dim isConnect As Boolean = False

        MysqlConn.ConnectionString = ConnectionString

        Try
            MysqlConn.Open()
            isConnect = True
            MysqlConn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Kesalahan Koneksi : " & myerror.Message)
            isConnect = False
        Finally
            MysqlConn.Dispose()
        End Try
        Return isConnect


    End Function



End Class
