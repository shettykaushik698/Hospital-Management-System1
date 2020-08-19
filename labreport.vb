Imports System.Data.SqlClient
Public Class labreport

    Private Sub labreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbldate.Text = System.DateTime.Today
        Me.GroupBox2.Enabled = False
        Me.btnview.Enabled = False
        Me.btnprint.Enabled = False
        Me.radioop.Checked = False
        Me.radioip.Checked = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave
        Try
            all_connect()
            Dim a
            If Me.radioip.Checked Then
                cmd.CommandText = "select ipname from ip where ipno='" & Me.txtid.Text & "'"
                a = cmd.ExecuteScalar().ToString()
                If a = "" Then
                    MsgBox("IP Number doesn't exists", MsgBoxStyle.Exclamation)
                Else
                    Me.txtname.Text = a
                    Dim adp As New SqlDataAdapter
                    Dim dt As New DataTable
                    cmd.CommandText = "select * from lab where opno='" & Me.txtid.Text & "' and status='generated'"
                    adp.SelectCommand = cmd
                    dt.Clear()
                    adp.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Me.reportgrid.DataSource = dt
                        cmd.ExecuteReader()
                    Else
                        MsgBox("No Records", MsgBoxStyle.Exclamation)
                    End If
                End If
            ElseIf Me.radioop.Checked Then
                cmd.CommandText = "select opname from op where opno='" & Me.txtid.Text & "'"
                a = cmd.ExecuteScalar().ToString()
                If a = "" Then
                    MsgBox("OP Number doesn't exists", MsgBoxStyle.Exclamation)
                Else
                    Me.txtname.Text = a
                    Dim adp1 As New SqlDataAdapter
                    Dim dt1 As New DataTable
                    cmd.CommandText = "select * from lab where opno='" & Me.txtid.Text & "' and status='generated'"
                    adp1.SelectCommand = cmd
                    dt1.Clear()
                    adp1.Fill(dt1)
                    If dt1.Rows.Count > 0 Then
                        Me.reportgrid.DataSource = dt1
                        cmd.ExecuteReader()
                    Else
                        MsgBox("No Records", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("Please select patient type", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Invalid ID", MsgBoxStyle.Exclamation)
        Finally
            cnn.Close()
        End Try
        Me.btnview.Enabled = True
    End Sub

    Private Sub radioop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioop.CheckedChanged
        Me.GroupBox2.Enabled = True
    End Sub

    Private Sub radioip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioip.CheckedChanged
        Me.GroupBox2.Enabled = True
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.reportgrid.DataSource = ""
        Me.txtid.Clear()
        Me.txtname.Clear()
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            Dim adpk As New SqlDataAdapter
            Dim dtk As New DataTable
            cmd.CommandText = "select * from lab where opno='" & Me.txtid.Text & "'"
            adpk.SelectCommand = cmd
            dtk.Clear()
            adpk.Fill(dtk)
            If dtk.Rows.Count > 0 Then
                If Me.radioip.Checked = True Then
                    rpt2 = "{lab.opno}='" & Me.txtid.Text & "' and {lab.status}='generated'"
                    iplabreportview.Show()
                ElseIf Me.radioop.Checked = True Then
                    rpt4 = "{lab.opno}='" & Me.txtid.Text & "' and {lab.status}='generated'"
                    oplabreportview.Show()
                End If
            Else
                MsgBox("No Reports for this ID", MsgBoxStyle.Exclamation)
                Me.txtid.Clear()
            End If
        Catch ex As Exception

        End Try
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
    End Sub

End Class