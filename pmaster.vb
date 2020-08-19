Imports System.Data.SqlClient
Public Class pmaster

    Private Sub btnop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnop.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select * from op"
            adp2.SelectCommand = cmd
            dt3.Clear()
            adp2.Fill(dt3)
            Me.pgrid.DataSource = dt3
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnip.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select * from ip"
            adp2.SelectCommand = cmd
            dt3.Clear()
            adp2.Fill(dt3)
            Me.pgrid.DataSource = dt3
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class