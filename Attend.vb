Imports System.Data.SqlClient
Public Class Attend
    Dim d, td, b
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub Attend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d = (System.DateTime.Today.Month - 1).ToString()
        If d = 1 Then
            Me.txtmonth.Text = "January"
        ElseIf d = 2 Then
            Me.txtmonth.Text = "February"
        ElseIf d = 3 Then
            Me.txtmonth.Text = "March"
        ElseIf d = 4 Then
            Me.txtmonth.Text = "April"
        ElseIf d = 5 Then
            Me.txtmonth.Text = "May"
        ElseIf d = 6 Then
            Me.txtmonth.Text = "June"
        ElseIf d = 7 Then
            Me.txtmonth.Text = "July"
        ElseIf d = 8 Then
            Me.txtmonth.Text = "August"
        ElseIf d = 9 Then
            Me.txtmonth.Text = "Semptember"
        ElseIf d = 10 Then
            Me.txtmonth.Text = "October"
        ElseIf d = 11 Then
            Me.txtmonth.Text = "November"
        ElseIf d = 12 Then
            Me.txtmonth.Text = "December"
        Else
            Me.txtmonth.Text = "tata bye bye"
        End If
        td = System.DateTime.DaysInMonth(System.DateTime.Today.Year, d)
        Me.txttd.Text = td
        b = countsunday(New DateTime(2019, d, td), DayOfWeek.Sunday)
        Me.txttl.Text = b.ToString()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Public Function countsunday(ByVal DateTargeted As Date, Optional ByVal StartingDay As DayOfWeek = DayOfWeek.Sunday)
        Dim dcount As New DateTime(DateTargeted.Year, DateTargeted.Month, 1)
        Dim i As Integer = DateTime.DaysInMonth(dcount.Year, dcount.Month)
        Dim j As Integer = (7 + CType(StartingDay, Integer) - dcount.DayOfWeek) Mod 7
        Dim k As Integer = dcount.AddDays(j).Day
        Return Math.Truncate((i - k) / 7) + 1
    End Function

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        Dim n, c As Integer
        Me.txtel.Clear()
        Me.txtot.Clear()
        If Me.txtel.Text = "" Then
            Me.txtel.Text = 0
        End If
        If Me.txtot.Text = "" Then
            Me.txtot.Text = 0
        End If
        If Me.txtwd.Text = "" Then
            MsgBox("Enter the number of worked days", MsgBoxStyle.Exclamation, "Adarsha Hospital")
        Else
            n = Val(Me.txttd.Text) - Val(Me.txtwd.Text)
            If n < 0 Then
                MsgBox("Worked days cannot be more that total number of days", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            Else
                c = Val(Me.txttd.Text) - Val(Me.txttl.Text)
                If Val(Me.txtwd.Text) < c Then
                    Me.txtel.Text = c - Val(Me.txtwd.Text)
                Else
                    Me.txtot.Text = Val(Me.txtwd.Text) - c
                End If
                Me.btncal.Enabled = False
                Me.txtwd.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.txteid.Clear()
        Me.txtname.Clear()
        Me.txtwd.Clear()
        Me.txttl.Clear()
        Me.txtel.Clear()
        Me.txtot.Clear()
        Me.btncal.Enabled = True
        Me.txtwd.ReadOnly = False
    End Sub

    Private Sub txteid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txteid.Leave
        Try
            all_connect()
            Dim s1 As Date
            cmd.CommandText = "select doj from employee where eid='" & Me.txteid.Text & "'"
            s1 = cmd.ExecuteScalar()
            If s1.Month = Now.Month() Then
                MsgBox("Employee joined this month", MsgBoxStyle.Exclamation)
                Me.txteid.Clear()
                Exit Sub
            End If
            cmd.CommandText = "select ename from employee where eid='" & Me.txteid.Text & "'"
            Me.txtname.Text = cmd.ExecuteScalar().ToString()
        Catch ex As Exception
            MsgBox("Employee ID doesn't exists")
            Me.txteid.Clear()
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            all_connect()
            cmd.CommandText = "select * from attendance where empid='" & Me.txteid.Text & "' and month='" & Me.txtmonth.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Already calculated", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            cmd.CommandText = "insert into attendance values(@empid,@empname,@month,@year,@td,@wd,@tl,@el,@ot)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@empid", SqlDbType.VarChar).Value = Me.txteid.Text
            cmd.Parameters.Add("@empname", SqlDbType.VarChar).Value = Me.txtname.Text
            cmd.Parameters.Add("@month", SqlDbType.VarChar).Value = Me.txtmonth.Text
            cmd.Parameters.Add("@year", SqlDbType.Decimal).Value = System.DateTime.Today.Year
            cmd.Parameters.Add("@td", SqlDbType.Decimal).Value = Me.txttd.Text
            cmd.Parameters.Add("@wd", SqlDbType.Decimal).Value = Me.txtwd.Text
            cmd.Parameters.Add("@tl", SqlDbType.Decimal).Value = Me.txttl.Text
            cmd.Parameters.Add("@el", SqlDbType.Decimal).Value = Me.txtel.Text
            cmd.Parameters.Add("@ot", SqlDbType.Decimal).Value = Me.txtot.Text
            cmd.ExecuteNonQuery()
            MsgBox("Saved succesfully")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

End Class