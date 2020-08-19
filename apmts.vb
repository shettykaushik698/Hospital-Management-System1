Imports System.Data.SqlClient
Public Class apmts
    Dim adp5 As New SqlDataAdapter
    Dim dt5 As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            all_connect()
            Dim u
            u = ""
            u = InputBox("Enter the patient ID whose consultation is done")
            If String.IsNullOrEmpty(u) Then
                MsgBox("Cancelled or Empty")
            Else
                cmd.CommandText = "select * from consult where did='" & admin.lblide.Text & "' and pid='" & u & "'"
                adp5.SelectCommand = cmd
                dt5.Clear()
                adp5.Fill(dt5)
                If dt5.Rows.Count > 0 Then
                    cmd.CommandText = "update consult set dstatus='consulted' where pid='" & u & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("Updated succesfully")
                Else
                    MsgBox("Enter the correct ID")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub apmts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New ex1.bgroup7DataSet4.consultDataTable
            cmd.CommandText = "select *  from consult where did='" & admin.lblide.Text & "' and cstatus='paid'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Try
            all_connect()
            Dim adpdoc As New SqlDataAdapter
            Dim dtdoc As New DataTable
            cmd.CommandText = "select * from consult where dstatus='consulted' and did='" & admin.lblide.Text & "'"
            adpdoc.SelectCommand = cmd
            dtdoc.Clear()
            adpdoc.Fill(dtdoc)
            If dtdoc.Rows.Count > 0 Then
                cmd.CommandText = "delete from consult where dstatus='consulted' and did='" & admin.lblide.Text & "'"
                cmd.ExecuteNonQuery()
            Else
                MsgBox("No consulted patients!!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New ex1.bgroup7DataSet4.consultDataTable
            cmd.CommandText = "select *  from consult where did='" & admin.lblide.Text & "' and cstatus='paid'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Me.DataGridView1.DataSource = dt1
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class