Imports System.Data.SqlClient
Public Class fileentry
    Private Sub Combodept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combodept.SelectedIndexChanged
        Me.combodoc.Items.Clear()
        Try
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim i As Integer
            cmd.CommandText = "select docid from doctor where dept='" + Me.Combodept.SelectedItem + "'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.combodoc.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnapnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnapnt.Click
        Try
            all_connect()
            If Me.comboopno.SelectedItem = "" Or Me.Combodept.SelectedItem = "" Or Me.combodoc.SelectedItem = "" Then
                MsgBox("Please Enter all the fields", MsgBoxStyle.Information)
            Else
                cmd.CommandText = "insert into consult values(@slno,@pid,@pname,@depart,@did,@dname,@dstatus,@cdate,@ccharge,@cstatus)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@slno", SqlDbType.VarChar).Value = Me.lblslno.Text
                cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = Me.comboopno.SelectedItem
                cmd.Parameters.Add("@pname", SqlDbType.VarChar).Value = Me.txtpname.Text
                cmd.Parameters.Add("@depart", SqlDbType.VarChar).Value = Me.Combodept.SelectedItem
                cmd.Parameters.Add("@did", SqlDbType.VarChar).Value = Me.combodoc.SelectedItem
                cmd.Parameters.Add("@dname", SqlDbType.VarChar).Value = Me.txtname.Text
                cmd.Parameters.Add("@dstatus", SqlDbType.VarChar).Value = "waiting"
                cmd.Parameters.Add("@cdate", SqlDbType.VarChar).Value = Me.datec.Text
                cmd.Parameters.Add("@ccharge", SqlDbType.Decimal).Value = Me.txtdcharge.Text
                cmd.Parameters.Add("@cstatus", SqlDbType.VarChar).Value = "notpaid"
                cmd.ExecuteNonQuery()
                MsgBox("File Entry succesfull!!", MsgBoxStyle.MsgBoxRight)
                Me.btnapnt.Enabled = False
                Me.Combodept.Enabled = False
                Me.comboopno.Enabled = False
                Me.combodoc.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Already entered")
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub fileentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.datec.Text = System.DateTime.Today
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from consult"
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
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            cmd.CommandText = "select opno from op"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim i As Integer
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.comboopno.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub combodoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combodoc.SelectedIndexChanged
        Me.txtname.Text = ""
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim i, j
            cmd.CommandText = "select dname from doctor where docid='" + Me.combodoc.SelectedItem + "'"
            i = cmd.ExecuteScalar()
            Me.txtname.Text = i
            cmd.CommandText = "select charge from doctor where docid='" + Me.combodoc.SelectedItem + "'"
            j = cmd.ExecuteScalar()
            Me.txtdcharge.Text = j
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub comboopno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboopno.SelectedIndexChanged
        Try
            all_connect()
            Dim dt2 As New DataTable
            Dim adp1 As New SqlDataAdapter
            cmd.CommandText = "select ipno from ip where opno='" & Me.comboopno.SelectedItem & "'"
            adp1.SelectCommand = cmd
            dt2.Clear()
            adp1.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                MsgBox("In Patient already exists for this OP number")
                Me.btnapnt.Enabled = False
            Else
                Me.btnapnt.Enabled = True
                Dim i
                cmd.CommandText = "select opname from op where opno='" + Me.comboopno.SelectedItem + "'"
                i = cmd.ExecuteScalar()
                Me.txtpname.Text = i
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Combodept.Enabled = True
        Me.comboopno.Enabled = True
        Me.combodoc.Enabled = True
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from consult"
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
    End Sub
End Class