Imports System.Data.SqlClient
Public Class labbill
    Dim adp1, adp2, adp3, adp4, adp5, adp6, adp7, adp8 As New SqlDataAdapter
    Dim dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8 As New DataTable
    Dim i, f, g, a, b
    Dim k1, k2
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            all_connect()
            cmd.CommandText = "select MAX(billno) from labbill"
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
        Me.GroupBox2.Enabled = True
        Me.labbillgrid.Rows.Clear()
        Me.labbillgrid.Refresh()
        Me.txtopno.Clear()
        Me.txtname.Clear()
        Me.txtadd.Clear()
        Me.txtphno.Clear()
        Me.txtage.Clear()
        Me.txtsex.Clear()
        Me.btnsave.Enabled = True
    End Sub

    Private Sub labbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.lbldate.Text = System.DateTime.Today
    End Sub

    Private Sub txtopno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtopno.Leave
        Try
            all_connect()
            If Me.combotype.SelectedItem = "OUT-PATIENT" Then
                cmd.CommandText = "select * from ip where opno='" & Me.txtopno.Text & "'"
                adp8.SelectCommand = cmd
                dt8.Clear()
                adp8.Fill(dt8)
                If dt8.Rows.Count > 0 Then
                    MsgBox("IP exists for this Number,Please select in patient", MsgBoxStyle.Exclamation)
                    Me.txtopno.Clear()
                    Exit Sub
                End If
                cmd.CommandText = "select opname,opph,opage,opgen,opadd from op where opno='" & Me.txtopno.Text & "'"
                adp1.SelectCommand = cmd
                dt1.Clear()
                adp1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    Me.txtname.Text = dt1.Rows(0).Item(0)
                    Me.txtphno.Text = dt1.Rows(0).Item(1)
                    Me.txtage.Text = dt1.Rows(0).Item(2)
                    Me.txtsex.Text = dt1.Rows(0).Item(3)
                    Me.txtadd.Text = dt1.Rows(0).Item(4)
                Else
                    MsgBox("No Records", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                cmd.CommandText = "select slno,lname,lcharge  from lab where opno='" & Me.txtopno.Text & "' and status='generated' and bill='notpaid'"
                adp2.SelectCommand = cmd
                dt2.Clear()
                adp2.Fill(dt2)
                g = dt2.Rows.Count - 1
                If dt2.Rows.Count > 0 Then
                    For i = 0 To g
                        Me.labbillgrid.Rows.Add(dt2.Rows(i).Item(0), dt2.Rows(i).Item(1), dt2.Rows(i).Item(2))
                    Next
                    If Me.labbillgrid.Rows.Count > 0 Then
                        f = 0
                        For i = 0 To Me.labbillgrid.Rows.Count - 1
                            f = f + Val(Me.labbillgrid.Rows(i).Cells(2).Value)
                            Me.txtfamt.Text = f
                        Next
                    Else
                        MsgBox("Empty", MsgBoxStyle.Information)
                    End If
                End If
            ElseIf Me.combotype.SelectedItem = "IN-PATIENT" Then
                cmd.CommandText = "select ipname,ipph,ipage,ipgen,ipadd from ip where ipno='" & Me.txtopno.Text & "'"
                adp3.SelectCommand = cmd
                dt3.Clear()
                adp3.Fill(dt3)
                If dt3.Rows.Count > 0 Then
                    Me.txtname.Text = dt3.Rows(0).Item(0)
                    Me.txtphno.Text = dt3.Rows(0).Item(1)
                    Me.txtage.Text = dt3.Rows(0).Item(2)
                    Me.txtsex.Text = dt3.Rows(0).Item(3)
                    Me.txtadd.Text = dt3.Rows(0).Item(4)
                Else
                    MsgBox("No Records", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                cmd.CommandText = "select slno,lname,lcharge  from lab where opno='" & Me.txtopno.Text & "' and status='generated' and bill='notpaid'"
                adp4.SelectCommand = cmd
                dt4.Clear()
                adp4.Fill(dt4)
                g = dt4.Rows.Count - 1
                If dt4.Rows.Count > 0 Then
                    For i = 0 To g
                        Me.labbillgrid.Rows.Add(dt4.Rows(i).Item(0), dt4.Rows(i).Item(1), dt4.Rows(i).Item(2))
                    Next
                    If Me.labbillgrid.Rows.Count > 0 Then
                        f = 0
                        For i = 0 To Me.labbillgrid.Rows.Count - 1
                            f = f + Val(Me.labbillgrid.Rows(i).Cells(2).Value)
                            Me.txtfamt.Text = f
                        Next
                    Else
                        MsgBox("Empty", MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("Please select the patient type", MsgBoxStyle.Exclamation)
                Me.txtopno.Clear()
                Exit Sub
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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            all_connect()
            If Me.txtopno.Text = "" Or Me.txtname.Text = "" Or Me.txtfamt.Text = "" Then
                MsgBox("Enter all the fields", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Me.combopay.SelectedItem = "" Then
                MsgBox("Select Payment Mode", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "insert into labbill values(@billno,@opno,@name,@age,@sex,@phno,@bdate,@addr,@pmode,@famt)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@billno", SqlDbType.Decimal).Value = Me.txtbillno.Text
            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Me.txtname.Text
            cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
            cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = Me.txtsex.Text
            cmd.Parameters.Add("@phno", SqlDbType.Decimal).Value = Me.txtphno.Text
            cmd.Parameters.Add("@bdate", SqlDbType.VarChar).Value = Me.lbldate.Text
            cmd.Parameters.Add("@addr", SqlDbType.VarChar).Value = Me.txtadd.Text
            cmd.Parameters.Add("@pmode", SqlDbType.VarChar).Value = Me.combopay.SelectedItem
            cmd.Parameters.Add("@famt", SqlDbType.Decimal).Value = Me.txtfamt.Text
            cmd.ExecuteNonQuery()
            MsgBox("Bill generated Succesfully", MsgBoxStyle.Information)
            Me.btnsave.Enabled = False
            For a = 0 To Me.labbillgrid.Rows.Count - 1
                cmd.CommandText = "update lab set bill='paid' where slno=" & Me.labbillgrid.Rows(a).Cells(0).Value
                cmd.ExecuteNonQuery()
            Next
            For b = 0 To Me.labbillgrid.Rows.Count - 1
                cmd.CommandText = "insert into labcharges values(@billno,@opno,@cname,@amt)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@billno", SqlDbType.Decimal).Value = Me.txtbillno.Text
                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = Me.labbillgrid.Rows(b).Cells(1).Value
                cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = Me.labbillgrid.Rows(b).Cells(2).Value
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
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
            cmd.CommandText = "select opno from labbill where billno=" & k1
            adpl.SelectCommand = cmd
            dtl.Clear()
            adpl.Fill(dtl)
            If dtl.Rows.Count > 0 Then
                k2 = cmd.ExecuteScalar().ToString()
            Else
                MsgBox("Bill number doesn't exists", MsgBoxStyle.Information)
                Exit Sub
            End If
            cmd.CommandText = "select * from labbill where opno='" & k2 & "'"
            adpk.SelectCommand = cmd
            dtk.Clear()
            adpk.Fill(dtk)
            If dtk.Rows.Count > 0 Then
                rpt3 = "{labbill.opno}='" & k2 & "' and {labbill.billno}=" & k1
                labreportview.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub
End Class