Imports System.Data.SqlClient
Public Class scan
    Dim i, j, s
    Private Sub combotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combotype.SelectedIndexChanged
        If Me.combotype.SelectedItem = "OUT-PATIENT" Then
            Me.lbltype.Text = "OP No. :"
        ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
            Me.lbltype.Text = "IP No. :"
        Else
            MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub scan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbldate.Text = System.DateTime.Today
        Me.txtid.Enabled = False
        Me.combotype.Enabled = False
        Me.btnapt.Enabled = False
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            Me.txtscan.Text = Me.lblscan.Text
            cmd.CommandText = "select scharge from scannames where sname='" & Me.lblscan.Text & "'"
            Me.txtcharge.Text = cmd.ExecuteScalar()
            If Me.lblscan.Text = "CT-SCAN" Then
                cmd.CommandText = "select * from ct where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.txtid.Enabled = True
        Me.combotype.Enabled = True
        Me.btnapt.Enabled = True
        If Me.lblscan.Text = "CT-SCAN" Then
            Try
                all_connect()
                cmd.CommandText = "select MAX(slno) from ct"
                Dim val As String
                val = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(val) Then
                    val = "0"
                End If
                val = val + 1
                Me.lblslno.Text = val
                Me.txtid.Clear()
                Me.txtname.Clear()
                Me.combotype.ResetText()
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
                cmd.CommandText = "select MAX(slno) from mri"
                Dim val As String
                val = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(val) Then
                    val = "0"
                End If
                val = val + 1
                Me.lblslno.Text = val
                Me.txtid.Clear()
                Me.txtname.Clear()
                Me.combotype.ResetText()
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
                cmd.CommandText = "select MAX(slno) from ecg"
                Dim val As String
                val = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(val) Then
                    val = "0"
                End If
                val = val + 1
                Me.lblslno.Text = val
                Me.txtid.Clear()
                Me.txtname.Clear()
                Me.combotype.ResetText()
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
                cmd.CommandText = "select MAX(slno) from echo"
                Dim val As String
                val = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(val) Then
                    val = "0"
                End If
                val = val + 1
                Me.lblslno.Text = val
                Me.txtid.Clear()
                Me.txtname.Clear()
                Me.combotype.ResetText()
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
                cmd.CommandText = "select MAX(slno) from scan"
                Dim val As String
                val = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(val) Then
                    val = "0"
                End If
                val = val + 1
                Me.lblslno.Text = val
                Me.txtid.Clear()
                Me.txtname.Clear()
                Me.combotype.ResetText()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave
        Try
            all_connect()
            Dim adp, adp1, adp2 As New SqlDataAdapter
            Dim dt, dt1, dt2 As New DataTable
            cmd.CommandText = "select * from ip where opno='" & Me.txtid.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("IP exists for this OP number,Please select the type as IN Patient and enter IP number", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                Me.txtid.Clear()
                Exit Sub
            Else
                If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                    cmd.CommandText = "select * from op where opno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt1.Clear()
                    adp1.Fill(dt1)
                    If dt1.Rows.Count > 0 Then
                        cmd.CommandText = "select opname from op where opno='" & Me.txtid.Text & "'"
                        Me.txtname.Text = cmd.ExecuteScalar().ToString()
                        Me.btnapt.Enabled = True
                    Else
                        MsgBox("OP Number doesn't exist", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                    cmd.CommandText = "select * from ip where ipno='" & Me.txtid.Text & "'"
                    adp2.SelectCommand = cmd
                    dt2.Clear()
                    adp2.Fill(dt2)
                    If dt2.Rows.Count > 0 Then
                        cmd.CommandText = "select ipname from ip where ipno='" & Me.txtid.Text & "'"
                        Me.txtname.Text = cmd.ExecuteScalar().ToString()
                        Me.btnapt.Enabled = True
                    Else
                        MsgBox("IP Number doesn't exist", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                Else
                    MsgBox("select patient type")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnapt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnapt.Click
        If Me.lblscan.Text = "CT-SCAN" Then
            Try
                all_connect()
                Dim adp1, adp2 As New SqlDataAdapter
                Dim dt, dt2 As New DataTable
                If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                    cmd.CommandText = "select * from op where opno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into ct values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnapt.Enabled = False
                        End If
                    Else
                        MsgBox("OP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                    cmd.CommandText = "select * from ip where ipno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into ct values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnapt.Enabled = False
                        End If
                    Else
                        MsgBox("IP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
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
                Dim adp1, adp2 As New SqlDataAdapter
                Dim dt, dt2 As New DataTable
                If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                    cmd.CommandText = "select * from op where opno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into mri values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("OP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                    cmd.CommandText = "select * from ip where ipno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into mri values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnapt.Enabled = False
                        End If
                    Else
                        MsgBox("IP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
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
                Dim adp1, adp2 As New SqlDataAdapter
                Dim dt, dt2 As New DataTable
                If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                    cmd.CommandText = "select * from op where opno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into ecg values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("OP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                    cmd.CommandText = "select * from ip where ipno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into ecg values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnapt.Enabled = False
                        End If
                    Else
                        MsgBox("IP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
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
                Dim adp1, adp2 As New SqlDataAdapter
                Dim dt, dt2 As New DataTable
                If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                    cmd.CommandText = "select * from op where opno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into echo values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("OP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                    cmd.CommandText = "select * from ip where ipno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into echo values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnapt.Enabled = False
                        End If
                    Else
                        MsgBox("IP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
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
                Dim adp1, adp2 As New SqlDataAdapter
                Dim dt, dt2 As New DataTable
                If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                    cmd.CommandText = "select * from op where opno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into scan values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("OP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                    cmd.CommandText = "select * from ip where ipno='" & Me.txtid.Text & "'"
                    adp1.SelectCommand = cmd
                    dt.Clear()
                    adp1.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        If Me.lblslno.Text = "" Or Me.txtname.Text = "" Or Me.txtcharge.Text = "" Or Me.txtid.Text = "" Or Me.txtscan.Text = "" Then
                            MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                        Else
                            cmd.CommandText = "insert into scan values(@sdate,@slno,@opno,@name,@sname,@attender,@charge,@status,@bill)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@sdate", SqlDbType.VarChar).Value = Me.lbldate.Text
                            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                            cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = Me.txtscan.Text
                            cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                            cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                            cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                            cmd.ExecuteNonQuery()
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnapt.Enabled = False
                        End If
                    Else
                        MsgBox("IP number doesn't exists", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Exit Sub
        End If
    End Sub


    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            Me.txtscan.Text = Me.lblscan.Text
            cmd.CommandText = "select scharge from scannames where sname='" & Me.lblscan.Text & "'"
            Me.txtcharge.Text = cmd.ExecuteScalar()
            If Me.lblscan.Text = "CT-SCAN" Then
                cmd.CommandText = "select * from ct where sname='" & Me.lblscan.Text & "'"
                adp2.SelectCommand = cmd
                dt3.Clear()
                adp2.Fill(dt3)
                j = dt3.Rows.Count - 1
                i = 0
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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
                Me.scangrid.DataSource = dt3
                Me.scangrid.Sort(Me.scangrid.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                cmd.ExecuteReader()
                For Each rw As DataGridViewRow In Me.scangrid.Rows
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

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

End Class