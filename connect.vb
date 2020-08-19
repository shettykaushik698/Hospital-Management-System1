Imports System.Data.SqlClient
Module connect
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand
    Public rpt, rpt1, rpt2, rpt3, rpt4, rpt5, rpt6, rptds
    Public Sub all_connect()
        cnn.ConnectionString = "data source=default-PC;initial catalog=bgroup7;integrated security=true"
        cnn.Open()
        cmd.Connection = cnn
    End Sub
End Module
