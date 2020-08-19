Imports System.Data.SqlClient
Public Class Resign
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Resign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbldate.Text = System.DateTime.Today
        Me.txtid.Enabled = False
        Me.txtreason.Enabled = False
        Me.btnsave.Enabled = False
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from resign"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.lblslno.Text = val
            Me.txtid.Clear()
            Me.txtname.Clear()
            Me.txtdesg.Clear()
            Me.txtreason.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.txtid.Enabled = True
        Me.txtreason.Enabled = True
        Me.btnsave.Enabled = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If Me.txtid.Text = "" Or Me.txtdesg.Text = "" Or Me.txtname.Text = "" Or Me.txtreason.Text = "" Then
            MsgBox("Enter all the fields")
        Else
            Try
                all_connect()
                Dim dt1 As New DataTable
                Dim adp As New SqlDataAdapter
                cmd.CommandText = "select * from employee where eid='" & Me.txtid.Text & "'"
                adp.SelectCommand = cmd
                dt1.Clear()
                adp.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    cmd.CommandText = "insert into resign values(@slno,@date,@id,@name,@desg,@dob,@addr,@city,@pin,@state,@country,@phno,@email,@doj,@reason)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.lbldate.Text
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                    cmd.Parameters.Add("@desg", SqlDbType.VarChar).Value = Me.txtdesg.Text
                    cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = dt1.Rows(0).Item(2)
                    cmd.Parameters.Add("@addr", SqlDbType.VarChar).Value = dt1.Rows(0).Item(5)
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = dt1.Rows(0).Item(6)
                    cmd.Parameters.Add("@pin", SqlDbType.Decimal).Value = dt1.Rows(0).Item(7)
                    cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = dt1.Rows(0).Item(8)
                    cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = dt1.Rows(0).Item(9)
                    cmd.Parameters.Add("@phno", SqlDbType.Decimal).Value = dt1.Rows(0).Item(13)
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = dt1.Rows(0).Item(14)
                    cmd.Parameters.Add("@doj", SqlDbType.DateTime).Value = dt1.Rows(0).Item(18)
                    cmd.Parameters.Add("@reason", SqlDbType.VarChar).Value = Me.txtreason.Text
                    cmd.ExecuteNonQuery()
                    MsgBox("Resignation Application saved", MsgBoxStyle.Information, "Adarsha Hospital")
                    Me.txtid.Enabled = False
                    Me.txtreason.Enabled = False
                    Me.btnsave.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
        End If
        
    End Sub

    Private Sub txtreason_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreason.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar > "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave
        Try
            all_connect()
            Dim adp, adp1 As New SqlDataAdapter
            Dim dt, dt1 As New DataTable
            cmd.CommandText = "select * from resign where eid='" & Me.txtid.Text & "'"
            adp1.SelectCommand = cmd
            dt1.Clear()
            adp1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                Dim result As Integer = MsgBox("There exists a resignation record for this ID,Do you want to proceed?", MsgBoxStyle.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    cmd.CommandText = "select ename,design from employee where eid='" & Me.txtid.Text & "'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Me.txtname.Text = dt.Rows(0).Item(0)
                        Me.txtdesg.Text = dt.Rows(0).Item(1)
                    Else
                        MsgBox("Wrong Employee ID,Enter again", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                        Me.txtid.Clear()
                    End If
                ElseIf result = Windows.Forms.DialogResult.No Then
                    Me.txtid.Clear()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub


   
   
End Class