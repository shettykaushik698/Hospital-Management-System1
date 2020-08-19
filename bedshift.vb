Imports System.Data.SqlClient
Public Class bedshift

    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            If Me.txtipno.Text = "" Then
                MsgBox("Please enter the IP Number", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cmd.CommandText = "select ipname,ipward,ipwno,ipbed from ip where ipno='" & Me.txtipno.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.txtname.Text = dt.Rows(0).Item(0)
                Me.txtwt.Text = dt.Rows(0).Item(1)
                Me.txtwn.Text = dt.Rows(0).Item(2)
                Me.txtbn.Text = dt.Rows(0).Item(3)
                Me.Panel1.Enabled = True
                Me.btnshift.Enabled = True
            Else
                MsgBox("No Records for this IP number or IP doesn't exists!!!", MsgBoxStyle.Exclamation, "Adarsha Hospital")
                Me.txtipno.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub bedshift_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Panel1.Enabled = False
        Try
            all_connect()
            Dim adpward As New SqlDataAdapter
            Dim dtward As New DataTable
            Dim i1
            Me.combowt.Items.Clear()
            cmd.CommandText = "select wname from wards"
            adpward.SelectCommand = cmd
            dtward.Clear()
            adpward.Fill(dtward)
            If dtward.Rows.Count > 0 Then
                For i1 = 0 To dtward.Rows.Count - 1
                    Me.combowt.Items.Add(dtward.Rows(i1).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub combowt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combowt.SelectedIndexChanged
        Me.combown.Items.Clear()
        Me.combown.Text = ""
        Me.combobn.Items.Clear()
        Me.combobn.Text = ""
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim v As String
            Dim i
            v = "null"
            cmd.CommandText = "select wno from wards where wname='" & Me.combowt.SelectedItem & "'"
            v = cmd.ExecuteScalar().ToString()
            If v = "" Then
                MsgBox("select ward type", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            cmd.CommandText = "select distinct(wardno) from dward where wno='" & v & "' and count='vacant'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.combown.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub combown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combown.SelectedIndexChanged
        Me.combobn.Items.Clear()
        Me.combobn.Text = ""
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim i
            cmd.CommandText = "select bedno from dward where wardno='" & Me.combown.SelectedItem & "' and count='vacant'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.combobn.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub btnshift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshift.Click
        Try
            all_connect()
            Dim adp1, adpj As New SqlDataAdapter
            Dim dt1, dtj As New DataTable
            Dim b, f, g
            Dim c, d As Date
            If Me.combowt.SelectedItem = "" Or Me.combown.SelectedItem = "" Or Me.combobn.SelectedItem = "" Then
                MsgBox("Please select the ward correctly", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            cmd.CommandText = "select * from bedcharge where ipno='" & Me.txtipno.Text & "'"
            adpj.SelectCommand = cmd
            dtj.Clear()
            adpj.Fill(dtj)
            If dtj.Rows.Count > 0 Then
                cmd.CommandText = "select bsdate from bedcharge where ipno='" & Me.txtipno.Text & "' and bn='" & Me.txtbn.Text & "'"
                c = Date.Parse(Convert.ToDateTime(cmd.ExecuteScalar()))
            Else
                cmd.CommandText = "select ipdate from ip where ipno='" & Me.txtipno.Text & "'"
                c = cmd.ExecuteScalar()
            End If
            cmd.CommandText = "select bcharge from dward where bedno='" & Me.txtbn.Text & "'"
            b = cmd.ExecuteScalar().ToString()
            d = System.DateTime.Today
            f = d - c
            If f.TotalDays = 0 Then
                g = 1
            Else
                g = f.TotalDays
            End If
            cmd.CommandText = "insert into bedcharge values(@ipno,@ipname,@wt,@wn,@bn,@pcharge,@td,@bsdate)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipno.Text
            cmd.Parameters.Add("@ipname", SqlDbType.VarChar).Value = Me.txtname.Text
            cmd.Parameters.Add("@wt", SqlDbType.VarChar).Value = Me.txtwt.Text
            cmd.Parameters.Add("@wn", SqlDbType.VarChar).Value = Me.txtwn.Text
            cmd.Parameters.Add("@bn", SqlDbType.VarChar).Value = Me.txtbn.Text
            cmd.Parameters.Add("@pcharge", SqlDbType.Decimal).Value = Convert.ToDecimal(b)
            cmd.Parameters.Add("@td", SqlDbType.Decimal).Value = Convert.ToDecimal(g)
            cmd.Parameters.Add("@bsdate", SqlDbType.DateTime).Value = d
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update dward set count='vacant' where  bedno='" & Me.txtbn.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update ip set ipward='" & Me.combowt.SelectedItem & "',ipwno='" & Me.combown.SelectedItem & "',ipbed='" & Me.combobn.SelectedItem & "' where ipno='" & Me.txtipno.Text & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update dward set count='alloted' where  bedno='" & Me.combobn.SelectedItem & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Patient Shifted succesfully", MsgBoxStyle.Information, "Adarsha Hospital")
            Me.btnshift.Enabled = False
            Me.combown.Items.Clear()
            Me.combobn.Items.Clear()
            Me.Panel1.Enabled = False
            cmd.CommandText = "select ipname,ipward,ipwno,ipbed from ip where ipno='" & Me.txtipno.Text & "'"
            adp1.SelectCommand = cmd
            dt1.Clear()
            adp1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                Me.txtname.Text = dt1.Rows(0).Item(0)
                Me.txtwt.Text = dt1.Rows(0).Item(1)
                Me.txtwn.Text = dt1.Rows(0).Item(2)
                Me.txtbn.Text = dt1.Rows(0).Item(3)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class