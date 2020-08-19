Imports System.Data.SqlClient
Public Class advance
   
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.txtid.Enabled = True
        Me.txtamount.Enabled = True
        Me.btnsearch.Enabled = False
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from advance"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.lblslno.Text = val
            Me.txtid.Clear()
            Me.txtname.Clear()
            Me.txtdesign.Clear()
            Me.txtamount.Clear()
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
            cmd.CommandText = "select ename,design from employee where eid='" & Me.txtid.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.txtname.Text = dt.Rows(0).Item(0)
                Me.txtdesign.Text = dt.Rows(0).Item(1)
            Else
                MsgBox("Wrong Employee ID,Enter again", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                Me.txtid.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.txtid.Enabled = False
        Me.txtamount.Enabled = False
        Try
            all_connect()
            If Me.txtid.Text = "" Or Me.txtamount.Text = "" Then
                MsgBox("Enter all the fields", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                Me.txtid.Enabled = True
                Me.txtamount.Enabled = True
            Else
                If Val(Me.txtamount.Text) <= 10000 And Val(Me.txtamount.Text) > 0 Then
                    cmd.CommandText = "insert into advance values(@slno,@empid,@empname,@empdesign,@empmonth,@empamount)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                    cmd.Parameters.Add("@empid", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@empname", SqlDbType.VarChar).Value = Me.txtname.Text
                    cmd.Parameters.Add("@empdesign", SqlDbType.VarChar).Value = Me.txtdesign.Text
                    cmd.Parameters.Add("@empmonth", SqlDbType.VarChar).Value = Me.txtmonth.Text
                    cmd.Parameters.Add("@empamount", SqlDbType.Decimal).Value = Me.txtamount.Text
                    cmd.ExecuteNonQuery()
                    MsgBox("Saved Succesfully")
                    Me.btnsearch.Enabled = True
                Else
                    MsgBox("Advance amount should not be greater than 10000 or cannot be zero", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                    Me.txtid.Enabled = True
                    Me.txtamount.Enabled = True
                    Me.txtamount.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("The employee had already taken advance amount", MsgBoxStyle.Information, "Adarsha Hospital")
            Me.txtid.Enabled = True
            Me.txtamount.Enabled = True
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub advance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnsearch.Enabled = True
        Dim d
        d = System.DateTime.Today.Month.ToString()
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
        Me.txtid.Enabled = False
        Me.txtamount.Enabled = False
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Amount Must be in digits", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            e.Handled = True
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            all_connect()
            Dim adp1 As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim a
            a = InputBox("Enter the employee ID")
            cmd.CommandText = "select * from advance where empid='" & a & "'"
            adp1.SelectCommand = cmd
            dt1.Clear()
            adp1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                Me.lblslno.Text = dt1.Rows(0).Item(0)
                Me.txtid.Text = dt1.Rows(0).Item(1)
                Me.txtname.Text = dt1.Rows(0).Item(2)
                Me.txtdesign.Text = dt1.Rows(0).Item(3)
                Me.txtmonth.Text = dt1.Rows(0).Item(4)
                Me.txtamount.Text = dt1.Rows(0).Item(5)
            Else
                MsgBox("No Records", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class