Imports System.Data.SqlClient
Public Class cpass
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
    Private Sub showpw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showpw.CheckedChanged
        If txtnp.Text = "" And Me.txtcp.Text = "" And Me.txtop.Text = "" Then
            MessageBox.Show("Please enter the password")
        Else

            If Me.showpw.Checked Then
                Me.txtnp.PasswordChar = ""
                Me.txtcp.PasswordChar = ""
                Me.txtop.PasswordChar = ""
            Else
                Me.txtnp.PasswordChar = "*"
                Me.txtcp.PasswordChar = "*"
                Me.txtop.PasswordChar = "*"
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click
        If ValidatePassword(Me.txtcp.Text) = True Then
            If Me.txtnp.Text <> Me.txtcp.Text Then
                MessageBox.Show("Password do not match, Enter again")
                Me.txtcp.Clear()
                Me.txtnp.Clear()
                Me.txtnp.Focus()
            Else
                Try
                    all_connect()
                    Dim k
                    cmd.CommandText = "select pw from hms where id='" + Me.lbleid.Text + "'"
                    k = cmd.ExecuteScalar()
                    If Me.txtop.Text = k Then
                        cmd.CommandText = "update hms set pw='" + Me.txtcp.Text + "' where id='" + Me.lbleid.Text + "'"
                        cmd.ExecuteNonQuery()
                        MsgBox("Password changed succesfully")
                    Else
                        MsgBox("Old password incorrect!!!")
                        Me.txtop.Clear()
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

    Private Sub cpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblid.Text = admin.lbluse.Text
        Me.lbleid.Text = admin.lblide.Text
    End Sub
End Class