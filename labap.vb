Imports System.Data.SqlClient
Public Class labap
    Dim i, j As Integer
    Dim s As String
    Dim sval
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Try
            all_connect()
            cmd.CommandText = "delete from blab"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
            Me.Close()
        End Try
    End Sub


    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.btnsave.Enabled = True
        Me.txtid.Enabled = True
        Me.combotype.Enabled = True
        Me.txttname.Enabled = True
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from lab"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.lblslno.Text = val
            Me.txtid.Clear()
            Me.txttname.ResetText()
            Me.txttcharge.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            cmd.CommandText = "delete from blab"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            cmd.CommandText = "select * from blab"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            Me.dgvtemp.DataSource = dt
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub combotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combotype.SelectedIndexChanged
        If Me.combotype.SelectedItem = "OUT-PATIENT" Then
            Me.lblid.Text = "OP No. :"
        ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
            Me.lblid.Text = "IP No. :"
        Else
            MsgBox("Select the patient type", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
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
                    If Me.lblslno.Text = "" Or Me.txttname.Text = "" Or Me.txttcharge.Text = "" Or Me.txtid.Text = "" Then
                        MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                    Else
                        cmd.CommandText = "select tname,nrange from blab"
                        adp2.SelectCommand = cmd
                        dt2.Clear()
                        adp2.Fill(dt2)
                        Dim i As Integer
                        If dt2.Rows.Count > 0 Then
                            For i = 0 To dt2.Rows.Count - 1
                                cmd.CommandText = "select MAX(slno) from lab"
                                Dim val As String
                                val = cmd.ExecuteScalar().ToString()
                                If String.IsNullOrEmpty(val) Then
                                    val = "0"
                                End If
                                val = val + 1
                                cmd.CommandText = "insert into lab values(@ldate,@slno,@ptype,@opno,@lname,@obv,@nrange,@lcharge,@status,@attender,@bill)"
                                cmd.Parameters.Clear()
                                cmd.Parameters.Add("@ldate", SqlDbType.VarChar).Value = Me.lbldate.Text
                                cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = val
                                cmd.Parameters.Add("@ptype", SqlDbType.VarChar).Value = Me.combotype.SelectedItem
                                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                                cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = dt2.Rows(i).Item(0)
                                cmd.Parameters.Add("@obv", SqlDbType.VarChar).Value = "---"
                                cmd.Parameters.Add("@nrange", SqlDbType.VarChar).Value = dt2.Rows(i).Item(1)
                                cmd.Parameters.Add("@lcharge", SqlDbType.Decimal).Value = Me.txttcharge.Text
                                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                                cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                                cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                                cmd.ExecuteNonQuery()
                            Next
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                            Me.btnsave.Enabled = False
                        End If
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
                    If Me.lblslno.Text = "" Or Me.txttname.Text = "" Or Me.txttcharge.Text = "" Or Me.txtid.Text = "" Then
                        MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                    Else
                        cmd.CommandText = "select tname,nrange from blab"
                        adp2.SelectCommand = cmd
                        dt2.Clear()
                        adp2.Fill(dt2)
                        Dim i As Integer
                        If dt2.Rows.Count > 0 Then
                            For i = 0 To dt2.Rows.Count - 1
                                cmd.CommandText = "select MAX(slno) from lab"
                                Dim val As String
                                val = cmd.ExecuteScalar().ToString()
                                If String.IsNullOrEmpty(val) Then
                                    val = "0"
                                End If
                                val = val + 1
                                cmd.CommandText = "insert into lab values(@ldate,@slno,@ptype,@opno,@lname,@obv,@nrange,@lcharge,@status,@attender,@bill)"
                                cmd.Parameters.Clear()
                                cmd.Parameters.Add("@ldate", SqlDbType.VarChar).Value = Me.lbldate.Text
                                cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = val
                                cmd.Parameters.Add("@ptype", SqlDbType.VarChar).Value = Me.combotype.SelectedItem
                                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtid.Text
                                cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = dt2.Rows(i).Item(0)
                                cmd.Parameters.Add("@obv", SqlDbType.VarChar).Value = "---"
                                cmd.Parameters.Add("@nrange", SqlDbType.VarChar).Value = dt2.Rows(i).Item(1)
                                cmd.Parameters.Add("@lcharge", SqlDbType.Decimal).Value = Me.txttcharge.Text
                                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "waiting"
                                cmd.Parameters.Add("@attender", SqlDbType.VarChar).Value = "---"
                                cmd.Parameters.Add("@bill", SqlDbType.VarChar).Value = "notpaid"
                                cmd.ExecuteNonQuery()
                            Next
                            MsgBox("Added succesfully", MsgBoxStyle.Information)
                        End If
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
    End Sub

    Private Sub labap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbldate.Text = System.DateTime.Today
        Me.btnsave.Enabled = False
        Me.txtid.Enabled = False
        Me.combotype.Enabled = False
        Me.txttname.Enabled = False
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select ldate,slno,ptype,opno,lname,lcharge,attender,status from lab"
            adp2.SelectCommand = cmd
            dt3.Clear()
            adp2.Fill(dt3)
            j = dt3.Rows.Count - 1
            i = 0
            Me.dgvlab.DataSource = dt3
            Me.dgvlab.Sort(Me.dgvlab.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            cmd.ExecuteReader()
            For Each rw As DataGridViewRow In Me.dgvlab.Rows
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
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adp4 As New SqlDataAdapter
            Dim dt4 As New DataTable
            cmd.CommandText = "select tname from blood"
            adp4.SelectCommand = cmd
            dt4.Clear()
            adp4.Fill(dt4)
            Dim i, n
            n = dt4.Rows.Count - 1
            If dt4.Rows.Count > 0 Then
                For i = 0 To n
                    Me.txttname.Items.Add(dt4.Rows(i).Item(0))
                Next
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
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select ldate,slno,ptype,opno,lname,lcharge,attender,status from lab"
            adp2.SelectCommand = cmd
            dt3.Clear()
            adp2.Fill(dt3)
            j = dt3.Rows.Count - 1
            i = 0
            Me.dgvlab.DataSource = dt3
            Me.dgvlab.Sort(Me.dgvlab.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            cmd.ExecuteReader()
            For Each rw As DataGridViewRow In Me.dgvlab.Rows
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
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txttname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttname.SelectedIndexChanged
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim r, s
            cmd.CommandText = "select MAX(sn) from blab"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            cmd.CommandText = "select range from blood where tname='" & Me.txttname.SelectedItem & "'"
            r = cmd.ExecuteScalar.ToString()
            cmd.CommandText = "select charge from blood where tname='" & Me.txttname.SelectedItem & "'"
            s = cmd.ExecuteScalar.ToString()
            Me.txttcharge.Text = s
            cmd.CommandText = "insert into blab values(@sn,@tname,@nrange,@charge) "
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@sn", SqlDbType.Decimal).Value = val
            cmd.Parameters.Add("@tname", SqlDbType.VarChar).Value = Me.txttname.SelectedItem
            cmd.Parameters.Add("@nrange", SqlDbType.VarChar).Value = r
            cmd.Parameters.Add("@charge", SqlDbType.VarChar).Value = Me.txttcharge.Text
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select * from blab"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Me.dgvtemp.DataSource = dt1
            Me.dgvtemp.Sort(Me.dgvtemp.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(" This test is already added")
            'MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Try
            all_connect()
            cmd.CommandText = "delete from blab"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adp1 As New SqlDataAdapter
            Dim dt1 As New DataTable
            cmd.CommandText = "select * from blab"
            adp1.SelectCommand = cmd
            dt1.Clear()
            adp1.Fill(dt1)
            Me.dgvtemp.DataSource = dt1
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            cmd.CommandText = "select * from ip where opno='" & Me.txtid.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("IP exists for this OP number,Please select the type as IN Patient and enter IP number", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                Me.txtid.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

End Class