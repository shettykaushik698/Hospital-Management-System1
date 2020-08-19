Imports System.Data.SqlClient
Public Class accounts
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridView2.Visible = True
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New ex1.bgroup7DataSet2.hmsDataTable
            cmd.CommandText = "select *  from hms "
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Me.DataGridView2.DataSource = dt1
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class