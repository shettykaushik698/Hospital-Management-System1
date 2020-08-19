Imports System.Data.SqlClient
Public Class scandis
    Dim i, j, s, cval
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            If Me.lblscan.Text = "CT-SCAN" Then
                cmd.CommandText = "select * from ct where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Exit Sub
            End If
            If Me.lblscan.Text = "MRI" Then
                cmd.CommandText = "select * from mri where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Exit Sub
            End If
            If Me.lblscan.Text = "ECHO" Then
                cmd.CommandText = "select * from echo where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Exit Sub
            End If
            If Me.lblscan.Text = "ECG" Then
                cmd.CommandText = "select * from ecg where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Exit Sub
            End If
            If Me.lblscan.Text = "X-RAY" Then
                cmd.CommandText = "select * from scan where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub scandis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btndone.Enabled = False
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            If Me.lblscan.Text = "CT-SCAN" Then
                cmd.CommandText = "select * from ct where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Me.scandisplay.ClearSelection()
                Exit Sub
            End If
            If Me.lblscan.Text = "MRI" Then
                cmd.CommandText = "select * from mri where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Me.scandisplay.ClearSelection()
                Exit Sub
            End If
            If Me.lblscan.Text = "ECHO" Then
                cmd.CommandText = "select * from echo where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Me.scandisplay.ClearSelection()
                Exit Sub
            End If
            If Me.lblscan.Text = "ECG" Then
                cmd.CommandText = "select * from ecg where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Me.scandisplay.ClearSelection()
                Exit Sub
            End If
            If Me.lblscan.Text = "X-RAY" Then
                cmd.CommandText = "select * from scan where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scandisplay.DataSource = dt3
                Me.scandisplay.Sort(Me.scandisplay.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scandisplay.Rows
                    If i <= j Then
                        s = dt3.Rows(i).Item(7)
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
                Me.scandisplay.ClearSelection()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnattend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnattend.Click
        If Me.lblscan.Text = "CT-SCAN" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update ct set status='seen' where slno='" & cval & "' and status='waiting'"
                    cmd.ExecuteNonQuery()
                    Me.btndone.Enabled = True
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "MRI" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update mri set status='seen' where slno='" & cval & "' and status='waiting'"
                    cmd.ExecuteNonQuery()
                    Me.btndone.Enabled = True
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "ECHO" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update echo set status='seen' where slno='" & cval & "' and status='waiting'"
                    cmd.ExecuteNonQuery()
                    Me.btndone.Enabled = True
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "ECG" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update ecg set status='seen' where slno='" & cval & "' and status='waiting'"
                    cmd.ExecuteNonQuery()
                    Me.btndone.Enabled = True
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "X-RAY" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update scan set status='seen' where slno='" & cval & "' and status='waiting'"
                    cmd.ExecuteNonQuery()
                    Me.btndone.Enabled = True
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        If Me.lblscan.Text = "CT-SCAN" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update ct set status='generated',attender='" & admin.lbluse.Text & "' where slno='" & cval & "' and status='seen'"
                    cmd.ExecuteNonQuery()
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox("The scan is not attended yet", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
                Me.btndone.Enabled = False
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "MRI" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update mri set status='generated',attender='" & admin.lbluse.Text & "' where slno='" & cval & "' and status='seen'"
                    cmd.ExecuteNonQuery()
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox("The scan is not attended yet", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
                Me.btndone.Enabled = False
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "ECHO" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update echo set status='generated',attender='" & admin.lbluse.Text & "' where slno='" & cval & "' and status='seen'"
                    cmd.ExecuteNonQuery()
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox("The scan is not attended yet", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
                Me.btndone.Enabled = False
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "ECG" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update ecg set status='generated',attender='" & admin.lbluse.Text & "' where slno='" & cval & "' and status='seen'"
                    cmd.ExecuteNonQuery()
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox("The scan is not attended yet", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
                Me.btndone.Enabled = False
            End Try
            Exit Sub
        End If
        If Me.lblscan.Text = "X-RAY" Then
            Try
                all_connect()
                If (Me.scandisplay.SelectedRows.Count > 0) Then
                    cval = Me.scandisplay.SelectedRows.Item(0).Cells.Item(1).Value.ToString()
                    cmd.CommandText = "update scan set status='generated',attender='" & admin.lbluse.Text & "' where slno='" & cval & "' and status='seen'"
                    cmd.ExecuteNonQuery()
                Else
                    MsgBox("Please select the row")
                End If
            Catch ex As Exception
                MsgBox("The scan is not attended yet", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
                Me.btndone.Enabled = False
            End Try
            Exit Sub
        End If
    End Sub
End Class