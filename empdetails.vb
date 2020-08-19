Imports System.Data.SqlClient
Public Class empdetails

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub combotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combotype.SelectedIndexChanged
        If Me.radiocurrent.Checked = True Then
            Try
                all_connect()
                Dim adp As New SqlDataAdapter
                Dim dt As New DataTable
                cmd.CommandText = "select * from employee where design='" & Me.combotype.SelectedItem & "'"
                adp.SelectCommand = cmd
                dt.Clear()
                adp.Fill(dt)
                Me.employeegrid.DataSource = dt
                cmd.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
        ElseIf Me.radioresign.Checked Then
            Try
                all_connect()
                Dim adp1 As New SqlDataAdapter
                Dim dt1 As New DataTable
                cmd.CommandText = "select * from resign where desg='" & Me.combotype.SelectedItem & "'"
                adp1.SelectCommand = cmd
                dt1.Clear()
                adp1.Fill(dt1)
                Me.employeegrid.DataSource = dt1
                cmd.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
        End If
        
    End Sub

    Private Sub radioresign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioresign.CheckedChanged
        Me.employeegrid.DataSource = ""
    End Sub

    Private Sub radiocurrent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiocurrent.CheckedChanged
        Me.employeegrid.DataSource = ""
    End Sub
End Class