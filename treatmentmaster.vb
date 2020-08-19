Imports System.Data.SqlClient
Public Class treatmentmaster
    Dim i
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If Me.btnadd.Text = "ADD Treatment" Then
            Me.btnremove.Enabled = False
            Me.TextBox1.Enabled = True
            Me.btnadd.Text = "Save"
        ElseIf Me.btnadd.Text = "Save" Then
            If Me.TextBox1.Text = "" Then
                MsgBox("Enter treatment name", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Try
                all_connect()
                cmd.CommandText = "insert into treatnames values (@tnames)"
                cmd.Parameters.Add("@tnames", SqlDbType.VarChar).Value = Me.TextBox1.Text
                cmd.ExecuteNonQuery()
                MsgBox("Treament added successfully")
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Me.TextBox1.Clear()
            Me.btnadd.Text = "ADD Treatment"
            Me.TextBox1.Enabled = False
            Me.btnremove.Enabled = True
        End If
        Me.ComboBox1.Items.Clear()
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
                    Me.ComboBox1.Items.Add(dtt.Rows(t1).Item(0))
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

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If Me.btnremove.Text = "Remove Treatment" Then
            Me.btnadd.Enabled = False
            Me.ComboBox1.Enabled = True
            Me.btnremove.Text = "Delete"
        ElseIf Me.btnremove.Text = "Delete" Then
            If Me.ComboBox1.SelectedItem = "" Then
                MsgBox("select treatment name", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Try
                all_connect()
                cmd.CommandText = "delete from treatnames where tnames='" & Me.ComboBox1.SelectedItem & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Treament deleted successfully")
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
            Me.btnadd.Enabled = True
            Me.btnremove.Text = "Remove Treatment"
            Me.ComboBox1.Items.Clear()
            Me.ComboBox1.Text = ""
            Me.ComboBox1.Enabled = False
            Me.ComboBox1.Items.Clear()
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
                        Me.ComboBox1.Items.Add(dtt.Rows(t1).Item(0))
                    Next
                Else
                    MsgBox("Currently no treatments are available", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub treatmentmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Items.Clear()
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
                    treatment.combotreat.Items.Add(dtt.Rows(t1).Item(0))
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class