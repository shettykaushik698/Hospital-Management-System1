Imports System.Data.SqlClient
Public Class wardm
    Public i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, a, b
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            all_connect()
            Dim adp1 As New SqlDataAdapter
            Dim dt2 As New ex1.bgroup7DataSet5.dwardDataTable
            Dim v As String
            cmd.CommandText = "select wno from wards where wname='" & Me.ComboBox1.SelectedItem & "'"
            v = cmd.ExecuteScalar().ToString()
            If v = "" Then
                MsgBox("Select ward type", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "select *  from dward where wno='" & v & "'"
            adp1.SelectCommand = cmd
            dt2.Clear()
            adp1.Fill(dt2)
            Dim j = dt2.Rows.Count - 1
            Dim s As String
            Dim i = 0
            Me.dgvward.DataSource = dt2
            cmd.ExecuteReader()
            For Each rw As DataGridViewRow In Me.dgvward.Rows
                If i <= j Then
                    s = dt2.Rows(i).Item(4)
                    i += 1
                    If s = "alloted" Then
                        rw.DefaultCellStyle.BackColor = Color.Red
                    Else
                        rw.DefaultCellStyle.BackColor = Color.Green
                    End If
                End If
                
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnav.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select ipno,ipname,ipward,ipwno,ipbed from ip"
            adp2.SelectCommand = cmd
            dt3.Clear()
            adp2.Fill(dt3)
            Me.dgvward.DataSource = dt3
            cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnchart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchart.Click
        Try
            all_connect()
            Dim adpx As New SqlDataAdapter
            Dim dtx As New DataTable
            cmd.CommandText = "select * from dward where wno='W1' and count='alloted'"
            adpx.SelectCommand = cmd
            dtx.Clear()
            adpx.Fill(dtx)
            j = 0
            If dtx.Rows.Count > 0 Then
                For i = 0 To dtx.Rows.Count - 1
                    j = j + 1
                Next
            Else
                j = 0
            End If
            cmd.CommandText = "select count(*) from dward where wno='W1'"
            k = cmd.ExecuteScalar()
            l = k - j
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adpy As New SqlDataAdapter
            Dim dty As New DataTable
            cmd.CommandText = "select * from dward where wno='W2' and count='alloted'"
            adpy.SelectCommand = cmd
            dty.Clear()
            adpy.Fill(dty)
            m = 0
            If dty.Rows.Count > 0 Then
                For n = 0 To dty.Rows.Count - 1
                    m = m + 1
                Next
            Else
                m = 0
            End If
            cmd.CommandText = "select count(*) from dward where wno='W2'"
            o = cmd.ExecuteScalar()
            p = o - m
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adpz As New SqlDataAdapter
            Dim dtz As New DataTable
            cmd.CommandText = "select * from dward where wno='W3' and count='alloted'"
            adpz.SelectCommand = cmd
            dtz.Clear()
            adpz.Fill(dtz)
            q = 0
            If dtz.Rows.Count > 0 Then
                For r = 0 To dtz.Rows.Count - 1
                    q = q + 1
                Next
            Else
                q = 0
            End If
            cmd.CommandText = "select count(*) from dward where wno='W3'"
            s = cmd.ExecuteScalar()
            t = s - q
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adpa As New SqlDataAdapter
            Dim dta As New DataTable
            cmd.CommandText = "select * from dward where wno='W4' and count='alloted'"
            adpa.SelectCommand = cmd
            dta.Clear()
            adpa.Fill(dta)
            u = 0
            If dta.Rows.Count > 0 Then
                For v = 0 To dta.Rows.Count - 1
                    u = u + 1
                Next
            Else
                u = 0
            End If
            cmd.CommandText = "select count(*) from dward where wno='W4'"
            w = cmd.ExecuteScalar()
            x = w - u
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adpb As New SqlDataAdapter
            Dim dtb As New DataTable
            cmd.CommandText = "select * from dward where wno='W5' and count='alloted'"
            adpb.SelectCommand = cmd
            dtb.Clear()
            adpb.Fill(dtb)
            y = 0
            If dtb.Rows.Count > 0 Then
                For z = 0 To dtb.Rows.Count - 1
                    y = y + 1
                Next
            Else
                y = 0
            End If
            cmd.CommandText = "select count(*) from dward where wno='W5'"
            a = cmd.ExecuteScalar()
            b = a - y
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        wardview.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        addward.Show()
    End Sub

    Private Sub wardm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            all_connect()
            Dim adpward As New SqlDataAdapter
            Dim dtward As New DataTable
            Dim i1
            Me.ComboBox1.Items.Clear()
            cmd.CommandText = "select wname from wards"
            adpward.SelectCommand = cmd
            dtward.Clear()
            adpward.Fill(dtward)
            If dtward.Rows.Count > 0 Then
                For i1 = 0 To dtward.Rows.Count - 1
                    Me.ComboBox1.Items.Add(dtward.Rows(i1).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class