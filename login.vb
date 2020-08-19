Imports System.Data.SqlClient
Public Class login
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim count As Integer
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
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim p As String
        Try
            all_connect()
            If Me.txtid.Text = "" Or Me.txtpw.Text = "" Then
                MsgBox("Enter all the fields")
            ElseIf Me.lbltype.Text = "ADMIN PORTAL" Then

                cmd.CommandText = "select pw from hms where id=@i and acc='administrator' and status='active'"
                cmd.Parameters.AddWithValue("@i", Me.txtid.Text)
                p = cmd.ExecuteScalar()
                If Me.txtpw.Text = p Then
                    admin.Show()
                    admin.ChangePasswordToolStripMenuItem1.Visible = False
                    MsgBox("Login Succesfull", MsgBoxStyle.Information, "Hello")
                    Me.txtid.Text = ""
                    Me.txtpw.Clear()
                    Me.Close()
                Else
                    MsgBox("Wrong user ID or password")
                End If
            ElseIf Me.lbltype.Text = "DOCTOR PORTAL" Then

                newpw.lbluser.Text = Me.txtid.Text
                If count < 3 Then
                    cmd.CommandText = "select * from hms where id='" & Me.txtid.Text & "' and acc='Doctor'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        cmd.CommandText = "select pw from hms where id='" & Me.txtid.Text & "' and acc='Doctor'"
                        p = cmd.ExecuteScalar().ToString()
                        Dim q As String
                        cmd.CommandText = "select status from hms where id='" & Me.txtid.Text & "'"
                        q = cmd.ExecuteScalar()
                        If q = "blocked" Then
                            MsgBox("Account has been blocked,contact administrator")
                            Exit Sub
                        ElseIf Me.txtid.Text & "@a" = p And Me.txtpw.Text = p Then
                            newpw.Show()
                        ElseIf Me.txtpw.Text = p Then
                            admin.Show()
                            Me.txtid.Text = ""
                            Me.txtpw.Clear()
                            Me.Close()
                        Else
                            MsgBox("Wrong password", MsgBoxStyle.Exclamation)
                            count += 1
                        End If
                    Else
                        MsgBox("Wrong user ID", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Number of attempts reached,Account blocked!!Contact Administrator for the unique id to change password", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                    cmd.CommandText = "update hms set status='blocked' where id='" & Me.txtid.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "insert into blocked values(@bid,@bstatus,@uid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@bstatus", SqlDbType.VarChar).Value = "blocked"
                    cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = "generate"
                    cmd.ExecuteNonQuery()
                End If
            ElseIf Me.lbltype.Text = "BILLING PORTAL" Then
                newpw.lbluser.Text = Me.txtid.Text
                If count < 3 Then
                    cmd.CommandText = "select * from hms where id='" & Me.txtid.Text & "' and acc='Accountant'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        cmd.CommandText = "select pw from hms where id='" & Me.txtid.Text & "' and acc='Accountant'"
                        p = cmd.ExecuteScalar().ToString()
                        Dim q As String
                        cmd.CommandText = "select status from hms where id='" & Me.txtid.Text & "'"
                        q = cmd.ExecuteScalar()
                        If q = "blocked" Then
                            MsgBox("Account has been blocked,contact administrator")
                            Exit Sub
                        ElseIf Me.txtid.Text & "@a" = p And Me.txtpw.Text = p Then
                            newpw.Show()
                        ElseIf Me.txtpw.Text = p Then
                            admin.Show()
                            Me.txtid.Text = ""
                            Me.txtpw.Clear()
                            Me.Close()
                        Else
                            MsgBox("Wrong password", MsgBoxStyle.Exclamation)
                            count += 1
                        End If
                    Else
                        MsgBox("Wrong user ID", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Number of attempts reached,Account blocked!!Contact Administrator for the unique id to change password")
                    cmd.CommandText = "update hms set status='blocked' where id='" & Me.txtid.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "insert into blocked values(@bid,@bstatus,@uid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@bstatus", SqlDbType.VarChar).Value = "blocked"
                    cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = "generate"
                    cmd.ExecuteNonQuery()
                End If
            ElseIf Me.lbltype.Text = "HR PORTAL" Then
                newpw.lbluser.Text = Me.txtid.Text
                If count < 3 Then
                    cmd.CommandText = "select * from hms where id='" & Me.txtid.Text & "' and acc='HR dept.'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        cmd.CommandText = "select pw from hms where id='" & Me.txtid.Text & "' and acc='HR dept.'"
                        p = cmd.ExecuteScalar().ToString()
                        Dim q As String
                        cmd.CommandText = "select status from hms where id='" & Me.txtid.Text & "'"
                        q = cmd.ExecuteScalar()
                        If q = "blocked" Then
                            MsgBox("Account has been blocked,contact administrator")
                            Exit Sub
                        ElseIf Me.txtid.Text & "@a" = p And Me.txtpw.Text = p Then
                            newpw.Show()
                        ElseIf Me.txtpw.Text = p Then
                            admin.Show()
                            Me.txtid.Text = ""
                            Me.txtpw.Clear()
                            Me.Close()
                        Else
                            MsgBox("Wrong password", MsgBoxStyle.Exclamation)
                            count += 1
                        End If
                    Else
                        MsgBox("Wrong user ID", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Number of attempts reached,Account blocked!!Contact Administrator for the unique id to change password")
                    cmd.CommandText = "update hms set status='blocked' where id='" & Me.txtid.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "insert into blocked values(@bid,@bstatus,@uid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@bstatus", SqlDbType.VarChar).Value = "blocked"
                    cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = "generate"
                    cmd.ExecuteNonQuery()
                End If
            ElseIf Me.lbltype.Text = "LABORATORY PORTAL" Then
                newpw.lbluser.Text = Me.txtid.Text
                If count < 3 Then
                    cmd.CommandText = "select * from hms where id='" & Me.txtid.Text & "' and acc='Lab Technician'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        cmd.CommandText = "select pw from hms where id='" & Me.txtid.Text & "' and acc='Lab Technician'"
                        p = cmd.ExecuteScalar().ToString()
                        Dim q As String
                        cmd.CommandText = "select status from hms where id='" & Me.txtid.Text & "'"
                        q = cmd.ExecuteScalar()
                        If q = "blocked" Then
                            MsgBox("Account has been blocked,contact administrator")
                            Exit Sub
                        ElseIf Me.txtid.Text & "@a" = p And Me.txtpw.Text = p Then
                            newpw.Show()
                        ElseIf Me.txtpw.Text = p Then
                            admin.Show()
                            Me.txtid.Text = ""
                            Me.txtpw.Clear()
                            Me.Close()
                        Else
                            MsgBox("Wrong password", MsgBoxStyle.Exclamation)
                            count += 1
                        End If
                    Else
                        MsgBox("Wrong user ID", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Number of attempts reached,Account blocked!!Contact Administrator for the unique id to change password")
                    cmd.CommandText = "update hms set status='blocked' where id='" & Me.txtid.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "insert into blocked values(@bid,@bstatus,@uid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@bstatus", SqlDbType.VarChar).Value = "blocked"
                    cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = "generate"
                    cmd.ExecuteNonQuery()
                End If
            ElseIf Me.lbltype.Text = "RECEPTIONIST PORTAL" Then
                newpw.lbluser.Text = Me.txtid.Text
                If count < 3 Then
                    cmd.CommandText = "select * from hms where id='" & Me.txtid.Text & "' and acc='Receptionist'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        cmd.CommandText = "select pw from hms where id='" & Me.txtid.Text & "' and acc='Receptionist'"
                        p = cmd.ExecuteScalar().ToString()
                        Dim q As String
                        cmd.CommandText = "select status from hms where id='" & Me.txtid.Text & "'"
                        q = cmd.ExecuteScalar()
                        If q = "blocked" Then
                            MsgBox("Account has been blocked,contact administrator")
                            Exit Sub
                        ElseIf Me.txtid.Text & "@a" = p And Me.txtpw.Text = p Then
                            newpw.Show()
                        ElseIf Me.txtpw.Text = p Then
                            admin.Show()
                            Me.txtid.Text = ""
                            Me.txtpw.Clear()
                            Me.Close()
                        Else
                            MsgBox("Wrong password", MsgBoxStyle.Exclamation)
                            count += 1
                        End If
                    Else
                        MsgBox("Wrong user ID", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Number of attempts reached,Account blocked!!Contact Administrator for the unique id to change password")
                    cmd.CommandText = "update hms set status='blocked' where id='" & Me.txtid.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "insert into blocked values(@bid,@bstatus,@uid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Me.txtid.Text
                    cmd.Parameters.Add("@bstatus", SqlDbType.VarChar).Value = "blocked"
                    cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = "generate"
                    cmd.ExecuteNonQuery()
                End If
            End If
            cmd.Parameters.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub showpw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showpw.CheckedChanged
        If txtpw.Text = "" Then
            MessageBox.Show("Please enter the password")
        Else

            If Me.showpw.Checked Then
                Me.txtpw.PasswordChar = ""
            Else
                Me.txtpw.PasswordChar = "*"
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        fpassw.Show()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main.Hide()
        If Me.lbltype.Text = "ADMIN PORTAL" Then
            Me.LinkLabel1.Visible = False
            Me.btnhelp.Visible = False
            Me.txtid.Enabled = False
            Me.txtid.Text = "ADMIN"
        ElseIf Me.lbltype.Text = "DOCTOR PORTAL" Then
            Me.txtid.Text = "DOC"
        ElseIf Me.lbltype.Text = "BILLING PORTAL" Then
            Me.txtid.Text = "ACT"
        ElseIf Me.lbltype.Text = "HR PORTAL" Then
            Me.txtid.Text = "HRD"
        ElseIf Me.lbltype.Text = "LABORATORY PORTAL" Then
            Me.txtid.Text = "LBT"
        ElseIf Me.lbltype.Text = "RECEPTIONIST PORTAL" Then
            Me.txtid.Text = "RPT"
        Else
            Me.LinkLabel1.Visible = True
            Me.btnhelp.Visible = True
            Me.txtid.Text = ""
            Me.txtid.Enabled = False
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Dim msgsure As MsgBoxResult = MsgBox("Are you sure?", MsgBoxStyle.OkCancel)
        If msgsure = MsgBoxResult.Ok Then
            main.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click
        MsgBox("To log in, Enter your user ID and password or if you are new here, use your ID and same as your password proceeding with @a", MsgBoxStyle.Information, "Adarsha Hospital")
    End Sub
End Class