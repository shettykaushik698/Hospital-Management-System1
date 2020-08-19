Imports System.Data.SqlClient
Public Class ipbill
    Dim adp, adp1, adp2, adp3, adp4, adp5, adp6, adp7, adp8, adp9, adp10, adp11, adp12, adp13, adp14 As New SqlDataAdapter
    Dim dt, dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10, dt11, dt12, dt13, dt14 As New DataTable
    Dim i, j, k, l, m, n, p, q, r, s, t, u, v, w, a, b, c, d, f, cnt1, cnt2
    Private Sub txtipno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtipno.Leave
        Try
            all_connect()
            cmd.CommandText = "select count(*) from lab where opno='" & Me.txtipno.Text & "'"
            cnt1 = cmd.ExecuteScalar()
            cmd.CommandText = "select count(*) from lab where opno='" & Me.txtipno.Text & "' and bill='paid'"
            cnt2 = cmd.ExecuteScalar()
            If cnt1 <> cnt2 Then
                MsgBox("Lab bill pending,Please proceed after lab bill", MsgBoxStyle.Information)
                cnt1 = 0
                cnt2 = 0
                Exit Sub
            End If
            cmd.CommandText = "select count(*) from scan where opno='" & Me.txtipno.Text & "'"
            cnt1 = cmd.ExecuteScalar()
            cmd.CommandText = "select count(*) from scan where opno='" & Me.txtipno.Text & "' and bill='paid'"
            cnt2 = cmd.ExecuteScalar()
            If cnt1 <> cnt2 Then
                MsgBox("Lab bill pending,Please proceed after X-RAY bill", MsgBoxStyle.Information)
                cnt1 = 0
                cnt2 = 0
                Exit Sub
            End If
            cmd.CommandText = "select count(*) from ct where opno='" & Me.txtipno.Text & "'"
            cnt1 = cmd.ExecuteScalar()
            cmd.CommandText = "select count(*) from ct where opno='" & Me.txtipno.Text & "' and bill='paid'"
            cnt2 = cmd.ExecuteScalar()
            If cnt1 <> cnt2 Then
                MsgBox("Lab bill pending,Please proceed after CT-SCAN bill", MsgBoxStyle.Information)
                cnt1 = 0
                cnt2 = 0
                Exit Sub
            End If
            cmd.CommandText = "select count(*) from mri where opno='" & Me.txtipno.Text & "'"
            cnt1 = cmd.ExecuteScalar()
            cmd.CommandText = "select count(*) from mri where opno='" & Me.txtipno.Text & "' and bill='paid'"
            cnt2 = cmd.ExecuteScalar()
            If cnt1 <> cnt2 Then
                MsgBox("Lab bill pending,Please proceed after MRI bill", MsgBoxStyle.Information)
                cnt1 = 0
                cnt2 = 0
                Exit Sub
            End If
            cmd.CommandText = "select count(*) from ecg where opno='" & Me.txtipno.Text & "'"
            cnt1 = cmd.ExecuteScalar()
            cmd.CommandText = "select count(*) from ecg where opno='" & Me.txtipno.Text & "' and bill='paid'"
            cnt2 = cmd.ExecuteScalar()
            If cnt1 <> cnt2 Then
                MsgBox("Lab bill pending,Please proceed after ECG bill", MsgBoxStyle.Information)
                cnt1 = 0
                cnt2 = 0
                Exit Sub
            End If
            cmd.CommandText = "select count(*) from echo where opno='" & Me.txtipno.Text & "'"
            cnt1 = cmd.ExecuteScalar()
            cmd.CommandText = "select count(*) from echo where opno='" & Me.txtipno.Text & "' and bill='paid'"
            cnt2 = cmd.ExecuteScalar()
            If cnt1 <> cnt2 Then
                MsgBox("Lab bill pending,Please proceed after ECHO bill", MsgBoxStyle.Information)
                cnt1 = 0
                cnt2 = 0
                Exit Sub
            End If
            cmd.CommandText = "select * from dischargesummary where ipno='" & Me.txtipno.Text & "'"
            adp4.SelectCommand = cmd
            dt4.Clear()
            adp4.Fill(dt4)
            If dt4.Rows.Count > 0 Then
                cmd.CommandText = "select * from ipbill where ipno='" & Me.txtipno.Text & "'"
                adp3.SelectCommand = cmd
                dt3.Clear()
                adp3.Fill(dt3)
                If dt3.Rows.Count > 0 Then
                    MsgBox("Already generated bill", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                cmd.CommandText = "select opno,ipdate,ipname,ipadd,ipph,ipage,ipgen,ipdoc,ipward,ipwno,ipbed,ipscheme from ip where ipno='" & Me.txtipno.Text & "'"
                adp.SelectCommand = cmd
                dt.Clear()
                adp.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Me.txtopno.Text = dt.Rows(0).Item(0)
                    Me.txtdoa.Text = dt.Rows(0).Item(1)
                    Me.txtname.Text = dt.Rows(0).Item(2)
                    Me.txtadd.Text = dt.Rows(0).Item(3)
                    Me.txtphno.Text = dt.Rows(0).Item(4)
                    Me.txtage.Text = dt.Rows(0).Item(5)
                    Me.txtsex.Text = dt.Rows(0).Item(6)
                    Me.txtdoc.Text = dt.Rows(0).Item(7)
                    Me.txtwt.Text = dt.Rows(0).Item(8)
                    Me.txtwn.Text = dt.Rows(0).Item(9)
                    Me.txtbn.Text = dt.Rows(0).Item(10)
                    Me.txtsceheme.Text = dt.Rows(0).Item(11)
                Else
                    MsgBox("No Records", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                Me.ipbillgrid.Rows.Add("Admission Charge", 250, 1, 250 * 1)
                i = Date.Parse(Convert.ToDateTime(Me.txtdoa.Text))
                cmd.CommandText = "select tname,tcharge from treatment where ipno='" & Me.txtipno.Text & "'"
                adp1.SelectCommand = cmd
                dt1.Clear()
                adp1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    j = Date.Parse(System.DateTime.Today.Date())
                    k = j - i
                    If k.TotalDays = 0 Then
                        k = 1
                    End If
                    Me.ipbillgrid.Rows.Add(dt1.Rows(0).Item(0) & " Treatment Charge", dt1.Rows(0).Item(1), k.TotalDays, Val(dt1.Rows(0).Item(1)) * Val(k.TotalDays))
                Else
                    MsgBox("No treatment charges", MsgBoxStyle.Information)
                End If
                cmd.CommandText = "select wt,pcharge,td from bedcharge where ipno='" & Me.txtipno.Text & "'"
                adp2.SelectCommand = cmd
                dt2.Clear()
                adp2.Fill(dt2)
                m = dt2.Rows.Count - 1
                If dt2.Rows.Count > 0 Then
                    For l = 0 To m
                        Me.ipbillgrid.Rows.Add(dt2.Rows(l).Item(0) & " Charge", dt2.Rows(l).Item(1), dt2.Rows(l).Item(2), Val(dt2.Rows(l).Item(1)) * Val(dt2.Rows(l).Item(2)))
                    Next
                    cmd.CommandText = "select ipward from ip where ipno='" & Me.txtipno.Text & "'"
                    n = cmd.ExecuteScalar().ToString()
                    cmd.CommandText = "select wno from wards where wname='" & n & "'"
                    u = cmd.ExecuteScalar().ToString()
                    cmd.CommandText = "select bcharge from dward where wno='" & u & "'"
                    p = cmd.ExecuteScalar()
                    cmd.CommandText = "select bsdate from bedcharge where ipno='" & Me.txtipno.Text & "'"
                    q = Date.Parse(Convert.ToDateTime(cmd.ExecuteScalar()))
                    r = j - q
                    If r.TotalDays = 0 Then
                        r = 1
                    End If
                    Me.ipbillgrid.Rows.Add(n & " Charge", p, r.TotalDays, p * r.TotalDays)
                Else
                    s = Date.Parse(System.DateTime.Today.Date())
                    t = s - i
                    Dim sk
                    If t.TotalDays = 0 Then
                        sk = 1
                    Else
                        sk = t.TotalDays
                    End If
                    cmd.CommandText = "select ipward from ip where ipno='" & Me.txtipno.Text & "'"
                    n = cmd.ExecuteScalar().ToString()
                    cmd.CommandText = "select wno from wards where wname='" & n & "'"
                    u = cmd.ExecuteScalar().ToString()
                    cmd.CommandText = "select bcharge from dward where wno='" & u & "'"
                    p = cmd.ExecuteScalar()
                    Me.ipbillgrid.Rows.Add(n & " Charge", p, sk, p * sk)
                End If
                v = Date.Parse(System.DateTime.Today.Date())
                w = v - i
                Dim skk
                If w.TotalDays = 0 Then
                    skk = 1
                Else
                    skk = w.TotalDays
                End If
                Me.lbltotdays.Text = w.TotalDays
                Me.ipbillgrid.Rows.Add("Nursing Charges", 500, skk, 500 * skk)
            Else
                MsgBox("Discharge summary not prepared yet", MsgBoxStyle.Exclamation)
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

    Private Sub ipbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            all_connect()
            cmd.CommandText = "select MAX(billno) from ipbill"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.txtbillno.Text = val
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.lbldate.Text = System.DateTime.Today
    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        Me.txtamt.Text = 0
        For a = 0 To Me.ipbillgrid.Rows.Count - 1
            Me.txtamt.Text = Val(Me.txtamt.Text) + Me.ipbillgrid.Rows(a).Cells(3).Value
        Next
        If Me.txtamt.Text = 0 Then
            MsgBox("Empty", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Me.txtsceheme.Text = "Not Applicable" Then
            Me.txtdiscount.Enabled = True
            If Me.txtdiscount.Text = "" Then
                MsgBox("Please enter the discount amount if there", MsgBoxStyle.Information)
            End If
        ElseIf Me.txtsceheme.Text = "Suraksha Scheme" Then
            Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.2
        ElseIf Me.txtsceheme.Text = "Arogya Baghya Scheme" Then
            Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.29
        ElseIf Me.txtsceheme.Text = "PMSBY" Then
            Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.35
        ElseIf Me.txtsceheme.Text = "G Shankar Scheme" Then
            Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.4
        Else
            MsgBox("Invalid Scheme", MsgBoxStyle.Exclamation)
        End If
        If Me.txtdiscount.Text = "" Then
            MsgBox("Please enter the discount amount if there", MsgBoxStyle.Information)
        Else
            Me.txtfamt.Text = Val(Me.txtamt.Text) - Val(Me.txtdiscount.Text)
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            all_connect()
            If Me.combopay.SelectedItem = "" Then
                MsgBox("Please select the payment mode", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Me.ipbillgrid.Rows.Count > 0 Then
                cmd.CommandText = "insert into ipbill values(@billno,@ipno,@opno,@name,@age,@sex,@addr,@scheme,@phno,@doa,@dod,@nod,@doc,@wt,@wn,@bn,@discount,@paym,@famount)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@billno", SqlDbType.Decimal).Value = Me.txtbillno.Text
                cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipno.Text
                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = Me.txtsex.Text
                cmd.Parameters.Add("@addr", SqlDbType.VarChar).Value = Me.txtadd.Text
                cmd.Parameters.Add("@scheme", SqlDbType.VarChar).Value = Me.txtsceheme.Text
                cmd.Parameters.Add("@phno", SqlDbType.Decimal).Value = Me.txtphno.Text
                cmd.Parameters.Add("@doa", SqlDbType.DateTime).Value = Me.txtdoa.Text
                cmd.Parameters.Add("@dod", SqlDbType.DateTime).Value = Me.lbldate.Text
                cmd.Parameters.Add("@nod", SqlDbType.Decimal).Value = Me.lbltotdays.Text
                cmd.Parameters.Add("@doc", SqlDbType.VarChar).Value = Me.txtdoc.Text
                cmd.Parameters.Add("@wt", SqlDbType.VarChar).Value = Me.txtwt.Text
                cmd.Parameters.Add("@wn", SqlDbType.VarChar).Value = Me.txtwn.Text
                cmd.Parameters.Add("@bn", SqlDbType.VarChar).Value = Me.txtbn.Text
                cmd.Parameters.Add("@discount", SqlDbType.Decimal).Value = Me.txtdiscount.Text
                cmd.Parameters.Add("@paym", SqlDbType.VarChar).Value = Me.combopay.SelectedItem
                cmd.Parameters.Add("@famount", SqlDbType.Decimal).Value = Me.txtfamt.Text
                cmd.ExecuteNonQuery()
                For b = 0 To Me.ipbillgrid.Rows.Count - 1
                    cmd.CommandText = "insert into ipcharges values(@ipno,@billno,@description,@charge,@particulars,@amount)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipno.Text
                    cmd.Parameters.Add("@billno", SqlDbType.Decimal).Value = Me.txtbillno.Text
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = Me.ipbillgrid.Rows(b).Cells(0).Value
                    cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.ipbillgrid.Rows(b).Cells(1).Value
                    cmd.Parameters.Add("@particulars", SqlDbType.Decimal).Value = Me.ipbillgrid.Rows(b).Cells(2).Value
                    cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Me.ipbillgrid.Rows(b).Cells(3).Value
                    cmd.ExecuteNonQuery()
                Next
                MsgBox("Saved succesfully", MsgBoxStyle.Information)
            Else
                MsgBox("No Charges", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            cmd.CommandText = "select * from ipbill where ipno='" & Me.txtipno.Text & "'"
            adp5.SelectCommand = cmd
            dt5.Clear()
            adp5.Fill(dt5)
            If dt5.Rows.Count > 0 Then
                cmd.CommandText = " select ipbed from ip where ipno='" & Me.txtipno.Text & "'"
                d = cmd.ExecuteScalar().ToString()
                cmd.CommandText = "update dward set count='vacant' where bedno='" & d & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select * from lab where opno='" & Me.txtipno.Text & "'"
                adp6.SelectCommand = cmd
                dt6.Clear()
                adp6.Fill(dt6)
                If dt6.Rows.Count > 0 Then
                    cmd.CommandText = "delete from lab where opno='" & Me.txtipno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "select * from scan where opno='" & Me.txtipno.Text & "'"
                adp7.SelectCommand = cmd
                dt7.Clear()
                adp7.Fill(dt7)
                If dt7.Rows.Count > 0 Then
                    cmd.CommandText = "delete from scan where opno='" & Me.txtipno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "select * from ct where opno='" & Me.txtipno.Text & "'"
                adp10.SelectCommand = cmd
                dt10.Clear()
                adp10.Fill(dt10)
                If dt10.Rows.Count > 0 Then
                    cmd.CommandText = "delete from ct where opno='" & Me.txtipno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "select * from ecg where opno='" & Me.txtipno.Text & "'"
                adp11.SelectCommand = cmd
                dt11.Clear()
                adp11.Fill(dt11)
                If dt11.Rows.Count > 0 Then
                    cmd.CommandText = "delete from ecg where opno='" & Me.txtipno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "select * from echo where opno='" & Me.txtipno.Text & "'"
                adp12.SelectCommand = cmd
                dt12.Clear()
                adp12.Fill(dt12)
                If dt12.Rows.Count > 0 Then
                    cmd.CommandText = "delete from echo where opno='" & Me.txtipno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
                cmd.CommandText = "select * from mri where opno='" & Me.txtipno.Text & "'"
                adp13.SelectCommand = cmd
                dt13.Clear()
                adp13.Fill(dt13)
                If dt13.Rows.Count > 0 Then
                    cmd.CommandText = "delete from mri where opno='" & Me.txtipno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
            End If
            cmd.CommandText = "select * from bedcharge where ipno='" & Me.txtipno.Text & "'"
            adp8.SelectCommand = cmd
            dt8.Clear()
            adp8.Fill(dt8)
            If dt8.Rows.Count > 0 Then
                cmd.CommandText = "delete from bedcharge where ipno='" & Me.txtipno.Text & "'"
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = "select * from treatment where ipno='" & Me.txtipno.Text & "'"
            adp9.SelectCommand = cmd
            dt9.Clear()
            adp9.Fill(dt9)
            If dt9.Rows.Count > 0 Then
                cmd.CommandText = "delete from treatment where ipno='" & Me.txtipno.Text & "'"
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = "select * from ip where ipno='" & Me.txtipno.Text & "'"
            adp14.SelectCommand = cmd
            dt14.Clear()
            adp14.Fill(dt14)
            If dt14.Rows.Count > 0 Then
                cmd.CommandText = "delete from ip where ipno='" & Me.txtipno.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Dicharge succesfull", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            all_connect()
            Dim adpk, adps As New SqlDataAdapter
            Dim dtk, dts As New DataTable
            Dim ks, kc
            ks = InputBox("Enter the bill number :")
            If String.IsNullOrEmpty(ks) Then
                MsgBox("Empty", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "select * from ipbill where billno=" & ks
            adps.SelectCommand = cmd
            dts.Clear()
            adps.Fill(dts)
            If dts.Rows.Count > 0 Then
                cmd.CommandText = "select ipno from ipbill where billno=" & ks
                kc = cmd.ExecuteScalar().ToString()
                cmd.CommandText = "select * from ipbill where ipno='" & kc & "' and billno=" & ks
                adpk.SelectCommand = cmd
                dtk.Clear()
                adpk.Fill(dtk)
                If dtk.Rows.Count > 0 Then
                    rpt1 = "{ipbill.ipno}='" & kc & "' and {ipbill.billno}=" & ks
                    ipbillview.Show()
                End If
            Else
                MsgBox("Bill Number doesnot exists", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class