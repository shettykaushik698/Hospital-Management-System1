Imports System.Data.SqlClient
Public Class treatdetails
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Me.txtipno.Text = "" Then
                MsgBox("Enter the IP number", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            all_connect()
            cmd.CommandText = "select * from treatment where ipno='" & Me.txtipno.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.tdgrid.DataSource = dt
                cmd.ExecuteReader()
            Else
                MsgBox("No Records", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class