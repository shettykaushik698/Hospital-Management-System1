Imports System.Data.SqlClient
Public Class payslip
    Dim k1, k2, m, n
    Private Sub empid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles empid.Leave
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            cmd.CommandText = "select name,desg,basicpay,netpay,month from salary where eid='" & Me.empid.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.empname.Text = dt.Rows(0).Item(0)
                Me.empdesign.Text = dt.Rows(0).Item(1)
                Me.empbasic.Text = dt.Rows(0).Item(2)
                Me.empnet.Text = dt.Rows(0).Item(3)
                m = dt.Rows(0).Item(4)
            Else
                MsgBox("Not calculated salary yet or wrong employee ID", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub payslip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbldate.Text = System.DateTime.Today
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Try
            all_connect()
            Dim adpk, adpl, adp2 As New SqlDataAdapter
            Dim dtk, dtl, dt2 As New DataTable
            k1 = Me.empid.Text
            If String.IsNullOrEmpty(k1) Then
                MsgBox("Enter the id", MsgBoxStyle.Information)
                Exit Sub
            End If
            n = InputBox("Enter the month of which you want to print")
            If String.IsNullOrEmpty(n) Then
                MsgBox("Cancelled or empty", MsgBoxStyle.Information)
                Exit Sub
            Else
                cmd.CommandText = "select * from salary where eid='" & Me.empid.Text & "' and month='" & n & "'"
                adp2.SelectCommand = cmd
                dt2.Clear()
                adp2.Fill(dt2)
                If dt2.Rows.Count > 0 Then
                    rpt6 = "{salary.eid}='" & k1 & "' and {salary.month}='" & n & "'"
                    payslipview.Show()
                Else
                    MsgBox("No Records", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.empid.Clear()
        Me.empname.Clear()
        Me.empdesign.Clear()
        Me.empbasic.Clear()
        Me.empnet.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class