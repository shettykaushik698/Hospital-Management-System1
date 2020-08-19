Imports System.Data.SqlClient
Public Class labmaster
    Dim i
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If Me.btnadd.Text = "ADD Test" Then
            Me.btnremove.Enabled = False
            Me.txtname.Enabled = True
            Me.txtrange.Enabled = True
            Me.txtcharge.Enabled = True
            Me.btnadd.Text = "Save"
        ElseIf Me.btnadd.Text = "Save" Then
            If Me.txtname.Text = "" Or Me.txtrange.Text = "" Or Me.txtcharge.Text = "" Then
                MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Try
                all_connect()
                cmd.CommandText = "insert into blood values(@tname,@range,@charge)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@tname", SqlDbType.VarChar).Value = Me.txtname.Text
                cmd.Parameters.Add("@range", SqlDbType.VarChar).Value = Me.txtrange.Text
                cmd.Parameters.Add("@charge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                cmd.ExecuteNonQuery()
                MsgBox("Added Succesfully", MsgBoxStyle.Information)
                Me.txtname.Clear()
                Me.btnadd.Text = "ADD Test"
                Me.txtname.Enabled = False
                Me.txtrange.Enabled = False
                Me.txtcharge.Enabled = False
                Me.btnremove.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Try
                all_connect()
                Dim adp2 As New SqlDataAdapter
                Dim dt2 As New DataTable
                cmd.CommandText = "select tname from blood"
                adp2.SelectCommand = cmd
                dt2.Clear()
                adp2.Fill(dt2)
                If dt2.Rows.Count > 0 Then
                    Me.ComboBox1.Items.Clear()
                    For i = 0 To dt2.Rows.Count - 1
                        Me.ComboBox1.Items.Add(dt2.Rows(i).Item(0))
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If Me.btnremove.Text = "Remove Test" Then
            Me.btnadd.Enabled = False
            Me.ComboBox1.Enabled = True
            Me.btnremove.Text = "Delete"
        ElseIf Me.btnremove.Text = "Delete" Then
            If Me.ComboBox1.SelectedItem = "" Then
                MsgBox("select test name", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Try
                all_connect()
                cmd.CommandText = "delete from blood where tname='" & Me.ComboBox1.SelectedItem & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Deleted succesfully", MsgBoxStyle.Information)
                Me.btnadd.Enabled = True
                Me.btnremove.Text = "Remove Test"
                Me.ComboBox1.Items.Clear()
                Me.ComboBox1.Text = ""
                Me.ComboBox1.Enabled = False
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Try
                all_connect()
                Dim adp1 As New SqlDataAdapter
                Dim dt1 As New DataTable
                cmd.CommandText = "select tname from blood"
                adp1.SelectCommand = cmd
                dt1.Clear()
                adp1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    Me.ComboBox1.Items.Clear()
                    For i = 0 To dt1.Rows.Count - 1
                        Me.ComboBox1.Items.Add(dt1.Rows(i).Item(0))
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub labmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            cmd.CommandText = "select tname from blood"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.ComboBox1.Items.Clear()
                For i = 0 To dt.Rows.Count - 1
                    Me.ComboBox1.Items.Add(dt.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.txtname.Enabled = False
        Me.txtrange.Enabled = False
        Me.txtcharge.Enabled = False
        Me.ComboBox1.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub txtcharge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcharge.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Enter only Numbers")
            e.Handled = True
        End If
    End Sub
End Class