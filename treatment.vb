Imports System.Data.SqlClient
Public Class treatment

    Private Sub treatment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = False
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.GroupBox1.Enabled = True
        Me.txtipno.Clear()
        Me.txtname.Clear()
        Me.txtage.Clear()
        Me.txttno.Clear()
        Me.txtdname.Clear()
        Me.txttcharge.Clear()
        Me.combotreat.Text = ""
        Me.txtdept.ResetText()
        Try
            all_connect()
            cmd.CommandText = "select MAX(sno) from treatment"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.lblslno.Text = val
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Try
            all_connect()
            Dim adpt As New SqlDataAdapter
            Dim dtt As New DataTable
            Dim t1
            cmd.CommandText = "select tnames from treatnames"
            adpt.SelectCommand = cmd
            dtt.Clear()
            adpt.Fill(dtt)
            If dtt.Rows.Count > 0 Then
                For t1 = 0 To dtt.Rows.Count - 1
                    Me.combotreat.Items.Add(dtt.Rows(t1).Item(0))
                Next
            Else
                MsgBox("Currently no treatments are available", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtipno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtipno.Leave
        Try
            all_connect()
            Dim adp, adp1 As New SqlDataAdapter
            Dim dt, dt1 As New DataTable
            cmd.CommandText = "select * from treatment where ipno='" & Me.txtipno.Text & "'"
            adp1.SelectCommand = cmd
            dt1.Clear()
            adp1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                MsgBox("This Patient is already under treatment", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "select ipname,ipage,ipdoc,ipdept from ip where ipno='" & Me.txtipno.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.GroupBox2.Enabled = True
                Me.GroupBox3.Enabled = True
                Me.txtname.Text = dt.Rows(0).Item(0)
                Me.txtage.Text = dt.Rows(0).Item(1)
                Me.txtdname.Text = dt.Rows(0).Item(2)
                Me.txtdept.Text = dt.Rows(0).Item(3)
                cmd.CommandText = "select MAX(tno) from treatment where ipno='" & Me.txtipno.Text & "'"
                Dim val As String
                val = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(val) Then
                    val = "0"
                End If
                val = val + 1
                Me.txttno.Text = val
            Else
                MsgBox("IP number doesn't exists", MsgBoxStyle.Exclamation)
                Me.txtipno.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            all_connect()
            If Me.txtipno.Text = "" Or Me.txttno.Text = "" Or Me.combotreat.SelectedItem = "" Or Me.txttcharge.Text = "" Or Me.txtdname.Text = "" Or Me.txtdept.Text = "" Then
                MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
            Else
                cmd.CommandText = "insert into treatment values(@sno,@ipno,@name,@age,@tno,@tname,@tcharge,@docname,@dept)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@sno", SqlDbType.Decimal).Value = Me.lblslno.Text
                cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                cmd.Parameters.Add("@tno", SqlDbType.Decimal).Value = Me.txttno.Text
                cmd.Parameters.Add("@tname", SqlDbType.VarChar).Value = Me.combotreat.SelectedItem
                cmd.Parameters.Add("@tcharge", SqlDbType.Decimal).Value = Me.txttcharge.Text
                cmd.Parameters.Add("@docname", SqlDbType.VarChar).Value = Me.txtdname.Text()
                cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = Me.txtdept.Text
                cmd.ExecuteNonQuery()
                MsgBox("Saved succesfully", MsgBoxStyle.Information)
                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub txttcharge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttcharge.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Amount Must be in Numbers", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            e.Handled = True
        End If
    End Sub
End Class