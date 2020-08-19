Imports System.Data.SqlClient
Public Class dischargesummary
    Dim f = 0
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            all_connect()
            cmd.CommandText = "select MAX(slno) from dischargesummary"
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
        Me.GroupBox1.Enabled = True
        Me.txtipid.Clear()
        Me.txtopid.Clear()
        Me.txtage.Clear()
        Me.txtadd.Clear()
        Me.txtsex.Clear()
        Me.txtdoa.Clear()
        Me.txtfd.Clear()
        Me.txtcr.Clear()
        Me.txtdrug.Clear()
        Me.txtph.Clear()
        Me.txtdiet.Clear()
        Me.txtadvice.Clear()
        Me.txtdoc.Clear()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If Me.txtfd.Text = "" Or Me.txtcr.Text = "" Or Me.txtph.Text = "" Or Me.txtdrug.Text = "" Or Me.txtadvice.Text = "" Or Me.txtdiet.Text = "" Then
                MsgBox("Fill in all", MsgBoxStyle.Exclamation)
            Else
                all_connect()
                Dim b
                cmd.CommandText = "select count(*) from dischargesummary where ipno='" & Me.txtipid.Text & "'"
                b = cmd.ExecuteScalar()
                If b <> 0 Then
                    MsgBox("Already record exists for this patient", MsgBoxStyle.Exclamation)
                Else
                    cmd.CommandText = "insert into dischargesummary values(@slno,@ipno,@opno,@name,@age,@addr,@sex,@doa,@dod,@finaldiag,@complaints,@past,@drugs,@furtheradv,@dietadv,@doctor)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                    cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipid.Text
                    cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopid.Text
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                    cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                    cmd.Parameters.Add("@addr", SqlDbType.VarChar).Value = Me.txtadd.Text
                    cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = Me.txtsex.Text
                    cmd.Parameters.Add("@doa", SqlDbType.VarChar).Value = Me.txtdoa.Text
                    cmd.Parameters.Add("@dod", SqlDbType.VarChar).Value = Me.txtdod.Text
                    cmd.Parameters.Add("@finaldiag", SqlDbType.VarChar).Value = Me.txtfd.Text
                    cmd.Parameters.Add("@complaints", SqlDbType.VarChar).Value = Me.txtcr.Text
                    cmd.Parameters.Add("@past", SqlDbType.VarChar).Value = Me.txtph.Text
                    cmd.Parameters.Add("@drugs", SqlDbType.VarChar).Value = Me.txtdrug.Text
                    cmd.Parameters.Add("@furtheradv", SqlDbType.VarChar).Value = Me.txtadvice.Text
                    cmd.Parameters.Add("@dietadv", SqlDbType.VarChar).Value = Me.txtdiet.Text
                    cmd.Parameters.Add("@doctor", SqlDbType.VarChar).Value = Me.txtdoc.Text
                    cmd.ExecuteNonQuery()
                    MsgBox("Saved Succesfully", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            all_connect()
            Dim adp2 As New SqlDataAdapter
            Dim dt2 As New DataTable
            If Me.btnedit.Text = "Edit" Then
                Me.GroupBox2.Enabled = True
                f = InputBox("Enter the IN-Patient ID:")
                Me.txtipid.Enabled = False
                cmd.CommandText = "select * from dischargesummary where ipno='" & f & "'"
                adp2.SelectCommand = cmd
                dt2.Clear()
                adp2.Fill(dt2)
                If dt2.Rows.Count > 0 Then
                    Me.lblslno.Text = dt2.Rows(0).Item(0)
                    Me.txtipid.Text = dt2.Rows(0).Item(1)
                    Me.txtopid.Text = dt2.Rows(0).Item(2)
                    Me.txtname.Text = dt2.Rows(0).Item(3)
                    Me.txtage.Text = dt2.Rows(0).Item(4)
                    Me.txtadd.Text = dt2.Rows(0).Item(5)
                    Me.txtsex.Text = dt2.Rows(0).Item(6)
                    Me.txtdoa.Text = dt2.Rows(0).Item(7)
                    Me.txtdod.Text = dt2.Rows(0).Item(8)
                    Me.txtfd.Text = dt2.Rows(0).Item(9)
                    Me.txtcr.Text = dt2.Rows(0).Item(10)
                    Me.txtph.Text = dt2.Rows(0).Item(11)
                    Me.txtdrug.Text = dt2.Rows(0).Item(12)
                    Me.txtadvice.Text = dt2.Rows(0).Item(13)
                    Me.txtdiet.Text = dt2.Rows(0).Item(14)
                    Me.txtdoc.Text = dt2.Rows(0).Item(15)
                    Me.btnedit.Text = "Update"
                Else
                    MsgBox("No Records", MsgBoxStyle.Exclamation)
                End If
            ElseIf Me.btnedit.Text = "Update" Then
                If Me.txtfd.Text = "" Or Me.txtcr.Text = "" Or Me.txtph.Text = "" Or Me.txtdrug.Text = "" Or Me.txtadvice.Text = "" Or Me.txtdiet.Text = "" Then
                    MsgBox("Fill in all", MsgBoxStyle.Exclamation)
                Else
                    cmd.CommandText = "update dischargesummary set @slno=slno,ipno=@ipno,opno=@opno,name=@name,age=@age,addr=@addr,sex=@sex,doa=@doa,dod=@dod,finaldiag=@finaldiag,complaints=@complaints,past=@past,drugs=@drugs,furtheradv=@furtheradv,dietadv=@dietadv,doctor=@doctor where ipno='" & f & "'"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@slno", SqlDbType.Decimal).Value = Me.lblslno.Text
                    cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipid.Text
                    cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopid.Text
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                    cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                    cmd.Parameters.Add("@addr", SqlDbType.VarChar).Value = Me.txtadd.Text
                    cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = Me.txtsex.Text
                    cmd.Parameters.Add("@doa", SqlDbType.VarChar).Value = Me.txtdoa.Text
                    cmd.Parameters.Add("@dod", SqlDbType.VarChar).Value = Me.txtdod.Text
                    cmd.Parameters.Add("@finaldiag", SqlDbType.VarChar).Value = Me.txtfd.Text
                    cmd.Parameters.Add("@complaints", SqlDbType.VarChar).Value = Me.txtcr.Text
                    cmd.Parameters.Add("@past", SqlDbType.VarChar).Value = Me.txtph.Text
                    cmd.Parameters.Add("@drugs", SqlDbType.VarChar).Value = Me.txtdrug.Text
                    cmd.Parameters.Add("@furtheradv", SqlDbType.VarChar).Value = Me.txtadvice.Text
                    cmd.Parameters.Add("@dietadv", SqlDbType.VarChar).Value = Me.txtdiet.Text
                    cmd.Parameters.Add("@doctor", SqlDbType.VarChar).Value = Me.txtdoc.Text
                    cmd.ExecuteNonQuery()
                    MsgBox("Updated Succesfully", MsgBoxStyle.Information)
                    Me.txtipid.Enabled = True
                    Me.btnedit.Text = "Edit"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub dischargesummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnedit.Text = "Edit"
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.txtdod.Text = System.DateTime.Today.ToString()
    End Sub

    Private Sub txtipid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtipid.Leave
        Try
            all_connect()
            Dim adp3 As New SqlDataAdapter
            Dim dt3 As New DataTable
            cmd.CommandText = "select opno,ipname,ipage,ipadd,ipgen,ipdate,ipdoc from ip where ipno='" & Me.txtipid.Text & "'"
            adp3.SelectCommand = cmd
            dt3.Clear()
            adp3.Fill(dt3)
            If dt3.Rows.Count > 0 Then
                Me.txtopid.Text = dt3.Rows(0).Item(0)
                Me.txtname.Text = dt3.Rows(0).Item(1)
                Me.txtage.Text = dt3.Rows(0).Item(2)
                Me.txtadd.Text = dt3.Rows(0).Item(3)
                Me.txtsex.Text = dt3.Rows(0).Item(4)
                Me.txtdoa.Text = dt3.Rows(0).Item(5).ToString()
                Me.txtdoc.Text = dt3.Rows(0).Item(6)
                Me.GroupBox2.Enabled = True
            Else
                MsgBox("No Records", MsgBoxStyle.Exclamation)
                Me.txtipid.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Me.GroupBox2.Enabled = False
        Me.GroupBox1.Enabled = False
        Try
            all_connect()
            Dim adp4 As New SqlDataAdapter
            Dim dt4 As New DataTable
            Dim h
            h = InputBox("Enter the IN-Patient ID:")
            cmd.CommandText = "select * from dischargesummary where ipno='" & h & "'"
            adp4.SelectCommand = cmd
            dt4.Clear()
            adp4.Fill(dt4)
            If dt4.Rows.Count > 0 Then
                Me.lblslno.Text = dt4.Rows(0).Item(0)
                Me.txtipid.Text = dt4.Rows(0).Item(1)
                Me.txtopid.Text = dt4.Rows(0).Item(2)
                Me.txtname.Text = dt4.Rows(0).Item(3)
                Me.txtage.Text = dt4.Rows(0).Item(4)
                Me.txtadd.Text = dt4.Rows(0).Item(5)
                Me.txtsex.Text = dt4.Rows(0).Item(6)
                Me.txtdoa.Text = dt4.Rows(0).Item(7)
                Me.txtdod.Text = dt4.Rows(0).Item(8)
                Me.txtfd.Text = dt4.Rows(0).Item(9)
                Me.txtcr.Text = dt4.Rows(0).Item(10)
                Me.txtph.Text = dt4.Rows(0).Item(11)
                Me.txtdrug.Text = dt4.Rows(0).Item(12)
                Me.txtadvice.Text = dt4.Rows(0).Item(13)
                Me.txtdiet.Text = dt4.Rows(0).Item(14)
                Me.txtdoc.Text = dt4.Rows(0).Item(15)
            Else
                MsgBox("No Records", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click
        Try
            Dim adpk As New SqlDataAdapter
            Dim dtk As New DataTable
            cmd.CommandText = "select * from dischargesummary where ipno='" & Me.txtipid.Text & "'"
            adpk.SelectCommand = cmd
            dtk.Clear()
            adpk.Fill(dtk)
            If dtk.Rows.Count > 0 Then
                rptds = "{dischargesummary.ipno}='" & Me.txtipid.Text & "'"
                dsview.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class