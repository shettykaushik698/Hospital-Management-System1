Imports System.Data.SqlClient
Public Class opbill
    Dim adp, adp1, adp2, adp3, adp4 As New SqlDataAdapter
    Dim dt, dt1, dt2, dt3, dt4 As New DataTable
    Dim a, b, c, d, f, g, h, i, j, k, l
    Dim k1, k2
    Private Sub opbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnnew.Enabled = True
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.btnsave.Enabled = True
        Me.btnnew.Enabled = False
        Try
            all_connect()
            cmd.CommandText = "select MAX(billno) from opbill"
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "0"
            End If
            val = val + 1
            Me.txtbillno.Text = val
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.GroupBox1.Enabled = True
        Me.lbldate.Text = System.DateTime.Today
        Me.txtopno.ReadOnly = False
        Me.txtopno.Clear()
        Me.txtname.Clear()
        Me.txtage.Clear()
        Me.txtsex.Clear()
        Me.txtsceheme.Clear()
        Me.txtadd.Clear()
        Me.txtdoc.Clear()
        Me.txtdiscount.Clear()
        Me.txtamt.Clear()
        Me.txtfamt.Clear()
        Me.opbillgrid.Rows.Clear()
        Me.opbillgrid.Refresh()
    End Sub

    Private Sub txtopno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtopno.Leave
        Try
            all_connect()
            cmd.CommandText = "select * from ip where opno='" & Me.txtopno.Text & "'"
            adp4.SelectCommand = cmd
            dt4.Clear()
            adp4.Fill(dt4)
            If dt4.Rows.Count > 0 Then
                MsgBox("There exists a IP ID for this OP Number,Use IP billing for In-Patient", MsgBoxStyle.Exclamation)
            Else
                cmd.CommandText = "select opname,opage,opgen,opscheme,opadd from op where opno='" & Me.txtopno.Text & "'"
                adp.SelectCommand = cmd
                dt.Clear()
                adp.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Me.txtname.Text = dt.Rows(0).Item(0)
                    Me.txtage.Text = dt.Rows(0).Item(1)
                    Me.txtsex.Text = dt.Rows(0).Item(2)
                    Me.txtsceheme.Text = dt.Rows(0).Item(3)
                    Me.txtadd.Text = dt.Rows(0).Item(4)
                Else
                    MsgBox("No Records", MsgBoxStyle.Exclamation)
                    Me.txtopno.Clear()
                End If
                cmd.CommandText = "select dname from consult where pid='" & Me.txtopno.Text & "'"
                adp2.SelectCommand = cmd
                dt2.Clear()
                adp2.Fill(dt2)
                If dt2.Rows.Count > 0 Then
                    Me.txtdoc.Text = dt2.Rows(0).Item(0)
                    cmd.CommandText = "select ccharge from consult where pid='" & Me.txtopno.Text & "' and cstatus='notpaid'"
                    b = cmd.ExecuteScalar().ToString()
                    If b <> "" Then
                        Me.opbillgrid.Rows.Add("File Entry", 20)
                        Me.opbillgrid.Rows.Add("Consultaion", b)
                    End If
                Else
                    MsgBox("No Consultation Charges for this OP", MsgBoxStyle.Information)
                End If
                cmd.CommandText = "select register from op where opno='" & Me.txtopno.Text & "'"
                c = cmd.ExecuteScalar().ToString()
                If c = "notpaid" Then
                    Me.opbillgrid.Rows.Add("Registration", 50)
                End If
                Me.GroupBox2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.txtopno.ReadOnly = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.btnnew.Enabled = True
        Try
            all_connect()
            If Me.combopay.SelectedItem <> "" Then
                If Me.txtamt.Text = "" Then
                    MsgBox("Oops! Nothing to save", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                cmd.CommandText = "insert into opbill values(@date,@opno,@billno,@name,@age,@sex,@address,@scheme,@doctor,@amt,@sdis,@paym,@famt)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = Me.lbldate.Text
                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                cmd.Parameters.Add("@billno", SqlDbType.Decimal).Value = Me.txtbillno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
                cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = Me.txtsex.Text
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = Me.txtadd.Text
                cmd.Parameters.Add("@scheme", SqlDbType.VarChar).Value = Me.txtsceheme.Text
                cmd.Parameters.Add("@doctor", SqlDbType.VarChar).Value = Me.txtdoc.Text
                cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Me.txtamt.Text
                cmd.Parameters.Add("@sdis", SqlDbType.Decimal).Value = Me.txtdiscount.Text
                cmd.Parameters.Add("@paym", SqlDbType.VarChar).Value = Me.combopay.SelectedItem
                cmd.Parameters.Add("@famt", SqlDbType.Decimal).Value = Me.txtfamt.Text
                cmd.ExecuteNonQuery()
                Dim i
                For i = 0 To Me.opbillgrid.Rows.Count - 1
                    cmd.CommandText = "select MAX(slno) from opcharges"
                    Dim val As String
                    val = cmd.ExecuteScalar().ToString()
                    If String.IsNullOrEmpty(val) Then
                        val = "0"
                    End If
                    val = val + 1
                    cmd.CommandText = "insert into opcharges values(@slno,@opno,@billno,@cname,@camt)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@slno", SqlDbType.VarChar).Value = val
                    cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                    cmd.Parameters.Add("@billno", SqlDbType.Decimal).Value = Me.txtbillno.Text
                    cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = Convert.ToString(Me.opbillgrid.Rows(i).Cells(0).Value)
                    cmd.Parameters.Add("@camt", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.opbillgrid.Rows(i).Cells(1).Value)
                    cmd.ExecuteNonQuery()
                Next
                MsgBox("Saved succesfully", MsgBoxStyle.MsgBoxRight)
                Me.btnsave.Enabled = False
                cmd.CommandText = "update op set register='paid' where opno='" & Me.txtopno.Text & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "select * from consult where pid='" & Me.txtopno.Text & "'"
                adp3.SelectCommand = cmd
                dt3.Clear()
                adp3.Fill(dt3)
                If dt3.Rows.Count > 0 Then
                    cmd.CommandText = "update consult set cstatus='paid' where pid='" & Me.txtopno.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
            Else
                MsgBox("Select the payment mode", MsgBoxStyle.Exclamation)
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

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        f = 0
        If Me.opbillgrid.Rows.Count > 0 Then
            For i = 0 To Me.opbillgrid.Rows.Count - 1
                f = f + Val(Me.opbillgrid.Rows(i).Cells(1).Value)
            Next
            If f = 0 Then
                MsgBox("Empty", MsgBoxStyle.Exclamation)
            Else
                Me.txtamt.Text = f
                If Me.txtsceheme.Text = "Not Applicable" Then
                    Me.txtdiscount.Text = 0
                ElseIf Me.txtsceheme.Text = "Suraksha Scheme" Then
                    Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.1
                ElseIf Me.txtsceheme.Text = "Arogya Baghya Scheme" Then
                    Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.15
                ElseIf Me.txtsceheme.Text = "PMSBY" Then
                    Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.25
                ElseIf Me.txtsceheme.Text = "G Shankar Scheme" Then
                    Me.txtdiscount.Text = Val(Me.txtamt.Text) * 0.3
                Else
                    MsgBox("Invalid Scheme", MsgBoxStyle.Exclamation)
                End If
                Me.txtfamt.Text = Val(Me.txtamt.Text) - Val(Me.txtdiscount.Text)
                Me.btnsave.Enabled = True
            End If
        Else
            MsgBox("Empty", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            all_connect()
            Dim adpk, adpl As New SqlDataAdapter
            Dim dtk, dtl As New DataTable
            k1 = InputBox("Enter the bill number")
            If String.IsNullOrEmpty(k1) Then
                MsgBox("Cancelled or empty", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "select opno from opbill where billno=" & k1
            adpl.SelectCommand = cmd
            dtl.Clear()
            adpl.Fill(dtl)
            If dtl.Rows.Count > 0 Then
                k2 = cmd.ExecuteScalar().ToString()
            Else
                MsgBox("Bill number doesn't exists", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "select * from opbill where opno='" & k2 & "'"
            adpk.SelectCommand = cmd
            dtk.Clear()
            adpk.Fill(dtk)
            If dtk.Rows.Count > 0 Then
                rpt = "{opbill.opno}='" & k2 & "' and {opbill.billno}=" & k1
                opbillview.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class