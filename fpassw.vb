Imports system.data.sqlclient
Public Class fpassw
    Function ValidatePassword(ByVal pwd As String, Optional ByVal minLength As Integer = 8, Optional ByVal numUpper As Integer = 1, Optional ByVal numLower As Integer = 1, Optional ByVal numNumbers As Integer = 1, Optional ByVal numSpecial As Integer = 1) As Boolean
        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub btnuid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuid.Click
        Try
            all_connect()
            Dim adp, adpx As New SqlDataAdapter
            Dim dt, dtx As New DataTable
            If Me.txtcid.Text = "" Then
                MsgBox("Enter the Employee ID", MsgBoxStyle.Information)
                Me.txtcid.Focus()
                Exit Sub
            End If
            If txtcid.Text = "ADMIN" Then
                MsgBox("Cannot accept administrator ID", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                cmd.CommandText = "select * from blocked where bid='" & Me.txtcid.Text & "'"
                adp.SelectCommand = cmd
                dt.Clear()
                adp.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("Account is already blocked")
                    Exit Sub
                Else
                    cmd.CommandText = "select * from employee where eid='" & Me.txtcid.Text & "'"
                    adpx.SelectCommand = cmd
                    dtx.Clear()
                    adpx.Fill(dtx)
                    If dtx.Rows.Count > 0 Then
                        cmd.CommandText = "update hms set status='blocked' where id='" & Me.txtcid.Text & "'"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "insert into blocked values(@bid,@bstatus,@uid)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Me.txtcid.Text
                        cmd.Parameters.Add("@bstatus", SqlDbType.VarChar).Value = "blocked"
                        cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = "generate"
                        cmd.ExecuteNonQuery()
                        MsgBox("Request sent to administrator succesfully,contact admin for the unique ID")
                    Else
                        MsgBox("Invalid ID", MsgBoxStyle.Exclamation)
                        Me.txtcid.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If ValidatePassword(Me.txtccp.Text) = True Then
            If Me.txtcuid.Text = "generate" Then
                MsgBox("Wrong Unique key entered ,check again")
                Me.txtcuid.Clear()
            Else
                Try
                    all_connect()
                    If Me.txtcid.Text = "" Or Me.txtcuid.Text = "" Or Me.txtcnp.Text = "" Or Me.txtccp.Text = "" Then
                        MsgBox("Enter all the fields")
                    Else
                        cmd.CommandText = "select uid from blocked where bid='" + Me.txtcid.Text + "'"
                        Dim uk
                        uk = cmd.ExecuteScalar()
                        If Me.txtcuid.Text = uk Then
                            cmd.CommandText = "update hms set status='active',pw='" + Me.txtccp.Text + "' where id='" + Me.txtcid.Text + "'"
                            cmd.ExecuteNonQuery()
                            MsgBox("Password changed succesfully")
                            cmd.CommandText = "delete from blocked where bid='" + Me.txtcid.Text + "'"
                            cmd.ExecuteNonQuery()
                            Me.txtccp.Clear()
                            Me.txtcid.Clear()
                            Me.txtcuid.Clear()
                            Me.Close()
                            main.Show()
                        Else
                            MsgBox("Wrong Unique Key entered,check again")
                            Me.txtcuid.Clear()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    cnn.Close()
                End Try
            End If
        Else
            MsgBox("Password must be atleast 8 characters and must include uppercase,lowercase,numbers and special characters", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If txtcnp.Text = "" And Me.txtccp.Text = "" Then
            MessageBox.Show("Please enter the password")
        Else
            If Me.CheckBox1.Checked Then
                Me.txtcnp.PasswordChar = ""
                Me.txtccp.PasswordChar = ""
            Else
                Me.txtcnp.PasswordChar = "*"
                Me.txtccp.PasswordChar = "*"
            End If
        End If
    End Sub
End Class