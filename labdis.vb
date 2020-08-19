Imports System.Data.SqlClient
Public Class labdis
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cval
    Dim i, j As Integer
    Dim s As String
    Private Sub btnseen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseen.Click
        Try
            all_connect()
            If (Me.labviewgrid.SelectedRows.Count > 0) Then
                cval = Me.labviewgrid.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                cmd.CommandText = "update lab set status='seen' where slno='" & cval & "'and status='waiting'"
                cmd.ExecuteNonQuery()
                Me.btnupdate.Enabled = True
            Else
                MsgBox("Please select the row")
            End If
        Catch ex As Exception
            MsgBox("The test is already been attended", MsgBoxStyle.Information, "Adarsha Hospital")
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub labdis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnupdate.Enabled = False
        Try
            all_connect()
            cmd.CommandText = "select * from lab"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            j = dt.Rows.Count - 1
            i = 0
            Me.labviewgrid.DataSource = dt
            Me.labviewgrid.Sort(Me.labviewgrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            cmd.ExecuteReader()
            For Each rw As DataGridViewRow In Me.labviewgrid.Rows
                If i <= j Then
                    s = dt.Rows(i).Item(8)
                    i += 1
                    If s = "waiting" Then
                        rw.DefaultCellStyle.BackColor = Color.Red
                    ElseIf s = "seen" Then
                        rw.DefaultCellStyle.BackColor = Color.Green
                    Else
                        rw.DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            Next
            Me.labviewgrid.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select * from lab"
            adp2.SelectCommand = cmd
            dt3.Clear()
            adp2.Fill(dt3)
            j = dt3.Rows.Count - 1
            i = 0
            Me.labviewgrid.DataSource = dt3
            Me.labviewgrid.Sort(Me.labviewgrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            cmd.ExecuteReader()
            For Each rw As DataGridViewRow In Me.labviewgrid.Rows
                If i <= j Then
                    s = dt3.Rows(i).Item(8)
                    i += 1
                    If s = "waiting" Then
                        rw.DefaultCellStyle.BackColor = Color.Red
                    ElseIf s = "seen" Then
                        rw.DefaultCellStyle.BackColor = Color.Green
                    Else
                        rw.DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            Next
            Me.labviewgrid.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            all_connect()
            If Me.TextBox1.Text = "" Then
                MsgBox("Enter the value", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If (Me.labviewgrid.SelectedRows.Count > 0) Then
                cval = Me.labviewgrid.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                cmd.CommandText = "update lab set status='generated',obv='" & Me.TextBox1.Text & "',attender='" & admin.lbluse.Text & "'  where slno='" & cval & "' and status='seen'"
                cmd.ExecuteNonQuery()
            Else
                MsgBox("Please select the row")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
            Me.btnupdate.Enabled = False
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

   
End Class