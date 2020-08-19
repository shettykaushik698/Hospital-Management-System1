Imports System.Data.SqlClient
Public Class salarycal
    Dim x, y, z
    Dim u As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub salarycal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbldate.Text = System.DateTime.Today()
        Me.txtid.Enabled = False
        Me.btncal.Enabled = False
        Me.btnsave.Enabled = False
        z = (System.DateTime.Today.Month - 1).ToString()
        If z = 1 Then
            u = "January"
        ElseIf z = 2 Then
            u = "February"
        ElseIf z = 3 Then
            u = "March"
        ElseIf z = 4 Then
            u = "April"
        ElseIf z = 5 Then
            u = "May"
        ElseIf z = 6 Then
            u = "June"
        ElseIf z = 7 Then
            u = "July"
        ElseIf z = 8 Then
            u = "August"
        ElseIf z = 9 Then
            u = "Semptember"
        ElseIf z = 10 Then
            u = "October"
        ElseIf z = 11 Then
            u = "November"
        ElseIf z = 12 Then
            u = "December"
        Else
            u = "tata bye bye"
        End If
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from salary"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.lblslno.Text = val
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.txtid.Clear()
        Me.txtname.Clear()
        Me.txtdes.Clear()
        Me.txtadv.Clear()
        Me.txtbasic.Clear()
        Me.txtded.Clear()
        Me.txthra.Clear()
        Me.txtot.Clear()
        Me.txttd.Clear()
        Me.txtwd.Clear()
        Me.txtnet.Clear()
        Me.txtgross.Clear()
        Me.txtpf.Clear()
        Me.txtpt.Clear()
        Me.txtid.Enabled = True
        Me.btncal.Enabled = True
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave
        Try
            all_connect()
            Dim k
            Dim s1 As Date
            Dim adp, adp1, adp2 As New SqlDataAdapter
            Dim dt, dt1, dt2 As New DataTable
            cmd.CommandText = "select doj from employee where eid='" & Me.txtid.Text & "'"
            s1 = cmd.ExecuteScalar()
            If s1.Month = Now.Month Then
                MsgBox("Employee just joined,cannot calculate his previous month salary", MsgBoxStyle.Exclamation)
                Me.txtid.Clear()
                Exit Sub
            End If
            cmd.CommandText = "select * from salary where eid='" & Me.txtid.Text & "' and month='" & u & "'"
            adp1.SelectCommand = cmd
            dt1.Clear()
            adp1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                MsgBox("Salary already generated for this employee", MsgBoxStyle.Information)
                Me.txtid.Clear()
            Else
                cmd.CommandText = "select ename,design,basic from employee where eid='" & Me.txtid.Text & "'"
                adp.SelectCommand = cmd
                dt.Clear()
                adp.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Me.txtname.Text = dt.Rows(0).Item(0)
                    Me.txtdes.Text = dt.Rows(0).Item(1)
                    Me.txtbasic.Text = dt.Rows(0).Item(2)
                    cmd.CommandText = "select month,td,wd,el,ot from attendance where empid='" & Me.txtid.Text & "' and month='" & u & "'"
                    adp2.SelectCommand = cmd
                    dt2.Clear()
                    adp2.Fill(dt2)
                    If dt2.Rows.Count > 0 Then
                        Me.txtmonth.Text = dt2.Rows(0).Item(0)
                        Me.txttd.Text = dt2.Rows(0).Item(1)
                        Me.txtwd.Text = dt2.Rows(0).Item(2)
                        x = dt2.Rows(0).Item(3)
                        y = dt2.Rows(0).Item(4)
                        cmd.CommandText = "select empamount from advance where empid='" & Me.txtid.Text & "'"
                        k = cmd.ExecuteScalar().ToString()
                        Me.txtadv.Text = k

                    Else
                        MsgBox("Attendance not calculated for this employee", MsgBoxStyle.Exclamation)
                        Me.btnsave.Enabled = False
                        Me.btncal.Enabled = False
                    End If
                Else
                    MsgBox("Wrong Employee ID,Enter again", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                    Me.txtid.Clear()
                    End If
                End If
        Catch ex As Exception
            Me.txtadv.Text = 0
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        Me.btnsave.Enabled = True
        Dim a, b, c, d, f, g, h, i As Integer
        a = 0
        b = 0
        c = 0
        d = 0
        f = 0
        g = 0
        h = 0
        i = 0
        a = Val(Me.txtbasic.Text) * 0.1
        Me.txthra.Text = a
        b = Val(Me.txtbasic.Text) / Val(Me.txttd.Text)
        c = x * b
        Me.txtded.Text = c
        d = b * y
        Me.txtot.Text = d
        f = Val(Me.txtbasic.Text) * 0.05
        Me.txtpf.Text = f
        If Val(Me.txtbasic.Text) >= 20000 Then
            g = 500
        Else
            g = 200
        End If
        Me.txtpt.Text = g
        h = a + d + Val(Me.txtbasic.Text)
        Me.txtgross.Text = h
        i = c + f + g + Val(Me.txtadv.Text)
        Me.txtnet.Text = h - i
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            all_connect()
            cmd.CommandText = "insert into salary values(@slno,@date,@eid,@name,@desg,@totday,@wrkday,@basicpay,@hra,@gross,@advance,@deduction,@otpay,@pf,@pt,@netpay,@month)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.lblslno.Text)
            cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = Me.lbldate.Text
            cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Me.txtid.Text
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
            cmd.Parameters.Add("@desg", SqlDbType.VarChar).Value = Me.txtdes.Text
            cmd.Parameters.Add("@totday", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txttd.Text)
            cmd.Parameters.Add("@wrkday", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtwd.Text)
            cmd.Parameters.Add("@basicpay", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtbasic.Text)
            cmd.Parameters.Add("@hra", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txthra.Text)
            cmd.Parameters.Add("@gross", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtgross.Text)
            cmd.Parameters.Add("@advance", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtadv.Text)
            cmd.Parameters.Add("@deduction", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtded.Text)
            cmd.Parameters.Add("@otpay", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtot.Text)
            cmd.Parameters.Add("@pf", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtpf.Text)
            cmd.Parameters.Add("@pt", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtpt.Text)
            cmd.Parameters.Add("@netpay", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtnet.Text)
            cmd.Parameters.Add("@month", SqlDbType.VarChar).Value = Me.txtmonth.Text
            cmd.ExecuteNonQuery()
            MsgBox("Saved succesfully")
            Me.txtid.Enabled = False
            Me.btnsave.Enabled = False
            Me.btncal.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class