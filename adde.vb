Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class adde
    Dim flag = 0
    Dim del As String
    Dim adpa, adpb As SqlDataAdapter
    Dim dta, dtb As DataTable
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If Me.dudtype.SelectedItem = "Doctor" Then
                If Me.duddep.SelectedItem = "" Or Me.txtcharge.Text = "" Then
                    MsgBox("Enter all the fields", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
            If Me.txtename.Text = "" Or Me.txtage.Text = "" Or Me.txtadd.Text = "" Or Me.txtcity.Text = "" Or Me.txtpin.Text = "" Or Me.radiomale.Checked = False And Me.radiofemale.Checked = False Or Me.txteid.Text = "" Or Me.txtcont.Text = "" Or Me.dudstate.SelectedItem = "" Or Me.txtrel.Text = "" Or Me.txtbg.SelectedItem = "" Or Me.txtph.Text = "" Or Me.txtemail.Text = "" Or Me.txtnom.Text = "" Or Me.txtqual.Text = "" Or Me.dudms.SelectedItem = "" Or Me.txtbank.Text = "" Or Me.txtbasic.Text = "" Then
                MsgBox("Enter all the fields")
            ElseIf Me.txtage.Text < 24 Or Me.txtage.Text > 60 Then
                MsgBox("Minimum Age is 24 or Invalid Age", MsgBoxStyle.Exclamation)
                Me.dtpb.Focus()
            Else
                all_connect()
                cmd.CommandText = "insert into employee values(@eid,@ename,@dob,@age,@gen,@eadd,@city,@pin,@state,@country,@relgn,@bg,@ms,@phno,@email,@baccno,@qual,@nom,@doj,@design,@bname,@basic)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Me.txteid.Text
                cmd.Parameters.Add("@ename", SqlDbType.VarChar).Value = Me.txtename.Text
                cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = Me.dtpb.Value.Date
                cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                Dim gn As String
                If Me.radiofemale.Checked Then
                    gn = Me.radiofemale.Text
                Else
                    gn = Me.radiomale.Text
                End If
                cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gn
                cmd.Parameters.Add("@eadd", SqlDbType.VarChar).Value = Me.txtadd.Text
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = Me.txtcity.Text
                cmd.Parameters.Add("@pin", SqlDbType.Decimal).Value = Me.txtpin.Text
                cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = Me.dudstate.SelectedItem
                cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = Me.txtcont.Text
                cmd.Parameters.Add("@relgn", SqlDbType.VarChar).Value = Me.txtrel.Text
                cmd.Parameters.Add("@bg", SqlDbType.VarChar).Value = Me.txtbg.SelectedItem
                cmd.Parameters.Add("@ms", SqlDbType.VarChar).Value = Me.dudms.SelectedItem
                cmd.Parameters.Add("@phno", SqlDbType.Decimal).Value = Me.txtph.Text
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Me.txtemail.Text
                cmd.Parameters.Add("@baccno", SqlDbType.Decimal).Value = Me.txtbank.Text
                cmd.Parameters.Add("@qual", SqlDbType.VarChar).Value = Me.txtqual.Text
                cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = Me.txtnom.Text
                cmd.Parameters.Add("@doj", SqlDbType.DateTime).Value = Me.dtpj.Value.Date
                cmd.Parameters.Add("@design", SqlDbType.VarChar).Value = Me.dudtype.SelectedItem
                cmd.Parameters.Add("@bname", SqlDbType.VarChar).Value = Me.Combobname.SelectedItem
                cmd.Parameters.Add("@basic", SqlDbType.Decimal).Value = Me.txtbasic.Text
                cmd.ExecuteNonQuery()
                MsgBox("Added succecfully")
                Me.btnsave.Enabled = False
                Me.btnedit.Enabled = True
                Me.btndel.Enabled = True
                Me.btnsear.Enabled = True
                If Me.dudtype.SelectedItem = "Doctor" Then
                    cmd.CommandText = "insert into doctor values(@docid,@dname,@dept,@charge)"
                    cmd.Parameters.Add("@docid", SqlDbType.VarChar).Value = Me.txteid.Text
                    cmd.Parameters.Add("@dname", SqlDbType.VarChar).Value = "Dr." + Me.txtename.Text
                    cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = Me.duddep.SelectedItem
                    cmd.Parameters.Add("@charge", SqlDbType.VarChar).Value = Me.txtcharge.Text
                    cmd.ExecuteNonQuery()
                End If
                Me.GroupBox1.Enabled = False
                cmd.CommandText = "insert into hms values(@id,@pw,@acc,@status)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Me.txteid.Text
                cmd.Parameters.Add("@pw", SqlDbType.VarChar).Value = Me.txteid.Text & "@a"
                cmd.Parameters.Add("@acc", SqlDbType.VarChar).Value = Me.dudtype.SelectedItem
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "active"
                cmd.ExecuteNonQuery()
                Me.btnnew.Enabled = True
                Me.btnedit.Enabled = True
                Me.btnsave.Enabled = True
                Me.btndel.Enabled = True
                Me.btnsear.Enabled = True
                Me.btnexit.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub dudtype_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudtype.SelectedItemChanged
        cnn.Close()
        Try
            all_connect()
            cmd.CommandText = "select MAX(eid) from employee where design='" & Me.dudtype.SelectedItem & "'"
            Dim id As Integer
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If Me.dudtype.SelectedItem = "Doctor" Then
                If String.IsNullOrEmpty(val) Then
                    val = "DOC000"
                End If
                val = val.Substring(3)
                Int32.TryParse(val, id)
                id = id + 1
                val = "DOC" + id.ToString("D3")
                Me.txteid.Text = val
                Me.duddep.Visible = True
                Me.lbldept.Visible = True
                Me.lblccharge.Visible = True
                Me.txtcharge.Visible = True
            End If
            If Me.dudtype.SelectedItem = "Nurse" Then
                If String.IsNullOrEmpty(val) Then
                    val = "NUR000"
                End If
                val = val.Substring(3)
                Int32.TryParse(val, id)
                id = id + 1
                val = "NUR" + id.ToString("D3")
                Me.txteid.Text = val
                Me.duddep.Visible = False
                Me.lbldept.Visible = False
                Me.lblccharge.Visible = False
                Me.txtcharge.Visible = False
            End If
            If Me.dudtype.SelectedItem = "Accountant" Then
                If String.IsNullOrEmpty(val) Then
                    val = "ACT000"
                End If
                val = val.Substring(3)
                Int32.TryParse(val, id)
                id = id + 1
                val = "ACT" + id.ToString("D3")
                Me.txteid.Text = val
                Me.duddep.Visible = False
                Me.lbldept.Visible = False
                Me.lblccharge.Visible = False
                Me.txtcharge.Visible = False
            End If
            If Me.dudtype.SelectedItem = "HR dept." Then
                If String.IsNullOrEmpty(val) Then
                    val = "HRD000"
                End If
                val = val.Substring(3)
                Int32.TryParse(val, id)
                id = id + 1
                val = "HRD" + id.ToString("D3")
                Me.txteid.Text = val
                Me.duddep.Visible = False
                Me.lbldept.Visible = False
                Me.lblccharge.Visible = False
                Me.txtcharge.Visible = False
            End If
            If Me.dudtype.SelectedItem = "Lab Technician" Then
                If String.IsNullOrEmpty(val) Then
                    val = "LBT000"
                End If
                val = val.Substring(3)
                Int32.TryParse(val, id)
                id = id + 1
                val = "LBT" + id.ToString("D3")
                Me.txteid.Text = val
                Me.duddep.Visible = False
                Me.lbldept.Visible = False
                Me.lblccharge.Visible = False
                Me.txtcharge.Visible = False
            End If
            If Me.dudtype.SelectedItem = "Receptionist" Then
                If String.IsNullOrEmpty(val) Then
                    val = "RPT000"
                End If
                val = val.Substring(3)
                Int32.TryParse(val, id)
                id = id + 1
                val = "RPT" + id.ToString("D3")
                Me.txteid.Text = val
                Me.duddep.Visible = False
                Me.lbldept.Visible = False
                Me.lblccharge.Visible = False
                Me.txtcharge.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtemail.Text), "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", RegexOptions.IgnoreCase)
        If rex.Success = False Then
            Me.txtemail.Text = ""
            MsgBox("Enter a valid email")
            Me.txtemail.Clear()
        End If
    End Sub


    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.txtename.Text = ""
        Me.txtbasic.Clear()
        Me.txtage.Text = ""
        Me.txtadd.Text = ""
        Me.txtcity.Text = ""
        Me.txtpin.Text = ""
        Me.radiomale.Checked = False
        Me.radiofemale.Checked = False
        Me.txteid.Text = ""
        Me.dudstate.ResetText()
        Me.txtrel.Text = ""
        Me.txtbg.ResetText()
        Me.txtph.Text = ""
        Me.txtemail.Text = ""
        Me.txtnom.Text = ""
        Me.txtqual.Text = ""
        Me.dudms.ResetText()
        Me.txtbank.Text = ""
        Me.txtename.ReadOnly = False
        Me.txtadd.ReadOnly = False
        Me.txtcity.ReadOnly = False
        Me.txtpin.ReadOnly = False
        Me.radiomale.Enabled = True
        Me.radiofemale.Enabled = True
        Me.txtrel.ReadOnly = False
        Me.txtph.ReadOnly = False
        Me.txtemail.ReadOnly = False
        Me.txtnom.ReadOnly = False
        Me.txtqual.ReadOnly = False
        Me.txtbank.ReadOnly = False
        Me.dtpb.Enabled = True
        Me.dtpj.Enabled = True
        Me.dudstate.Enabled = True
        Me.dudtype.Enabled = True
        Me.txtbg.Enabled = True
        Me.dudms.Enabled = True
        Me.GroupBox1.Enabled = True
        Me.btnsave.Enabled = True
        Me.btnedit.Enabled = False
        Me.btndel.Enabled = False
        Me.btnsear.Enabled = False
    End Sub
    Private Sub dtpb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpb.ValueChanged
        Dim d1 = System.DateTime.Now.Year - Me.dtpb.Value.Date.Year
        Dim m1 = System.DateTime.Now.Month - Me.dtpb.Value.Date.Month
        Dim t1 = System.DateTime.Now.Day - Me.dtpb.Value.Date.Day
        If m1 <= 0 And t1 <= -1 Then
            d1 = d1 - 1
        Else
            Me.txtage.Text = d1
        End If
        Me.txtage.Text = d1
    End Sub

    Private Sub dtpj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpj.ValueChanged
        If System.DateTime.Now.Date < Me.dtpj.Value.Date Then
            MsgBox("Invalid joining Date")
            Me.dtpj.ResetText()
        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Me.btnnew.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnedit.Enabled = False
        Me.btnsear.Enabled = False
        Try
            all_connect()
            Dim dt1, dt As New DataTable
            Dim adp, adp1 As New SqlDataAdapter
            del = InputBox("Enter the Employee ID")
            If String.IsNullOrEmpty(del) Then
                MsgBox("Cancelled or Empty")
                Me.btnnew.Enabled = True
                Me.btnsave.Enabled = True
                Me.btnedit.Enabled = True
                Me.btnsear.Enabled = True
            Else
                del = del.ToUpper()
                cmd.CommandText = "select * from resign where eid='" & del & "'"
                adp1.SelectCommand = cmd
                dt.Clear()
                adp1.Fill(dt)
                If dt.Rows.Count > 0 Then
                    cmd.CommandText = "select * from employee where eid='" & del & "'"
                    adp.SelectCommand = cmd
                    dt1.Clear()
                    adp.Fill(dt1)
                    If dt1.Rows.Count > 0 Then
                        cmd.CommandText = "delete from employee where eid='" & del & " '"
                        cmd.ExecuteNonQuery()
                        If dt1.Rows(0).Item(19) = "Doctor" Then
                            cmd.CommandText = "delete from doctor where docid='" & del & "'"
                            cmd.ExecuteNonQuery()
                        End If
                        cmd.CommandText = "delete from hms where id='" & del & "'"
                        cmd.ExecuteNonQuery()
                        MsgBox("Deleted  succesfully")
                        cmd.CommandText = "select * from attendance where empid='" & del & "'"
                        adpa.SelectCommand = cmd
                        dta.Clear()
                        adpa.Fill(dta)
                        If dta.Rows.Count > 0 Then
                            cmd.CommandText = "delete from attendance where empid='" & del & "'"
                            cmd.ExecuteNonQuery()
                        Else
                            MsgBox("No attendance records")
                        End If
                        cmd.CommandText = "select * from salary where eid='" & del & "'"
                        adpb.SelectCommand = cmd
                        dtb.Clear()
                        adpb.Fill(dtb)
                        If dtb.Rows.Count > 0 Then
                            cmd.CommandText = "delete from salary where eid='" & del & "'"
                            cmd.ExecuteNonQuery()
                        Else
                            MsgBox("No salary records")
                        End If
                        Me.btnnew.Enabled = True
                        Me.btnedit.Enabled = True
                        Me.btnsave.Enabled = True
                        Me.btndel.Enabled = True
                        Me.btnsear.Enabled = True
                        Me.btnexit.Enabled = True
                        Me.txtename.Text = ""
                        Me.txtage.Text = ""
                        Me.txtadd.Text = ""
                        Me.txtcity.Text = ""
                        Me.txtpin.Text = ""
                        Me.radiomale.Checked = False
                        Me.radiofemale.Checked = False
                        Me.txteid.Text = ""
                        Me.dudstate.ResetText()
                        Me.txtrel.Text = ""
                        Me.txtbg.ResetText()
                        Me.txtph.Text = ""
                        Me.txtemail.Text = ""
                        Me.txtnom.Text = ""
                        Me.txtqual.Text = ""
                        Me.dudms.ResetText()
                        Me.txtbank.Text = ""
                        Me.dudtype.ResetText()
                    Else
                        MsgBox("No Records!!!")
                    End If
                Else
                    MsgBox("Invalid ID or This employee not found in the resignation list", MsgBoxStyle.Exclamation, "Adarsha Hospital")

                End If
            End If
        Catch ex As Exception
            MsgBox("Enter the valid ID")
        Finally
            cnn.Close()
        End Try

    End Sub
    Private Sub adde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.duddep.Visible = False
        Me.lbldept.Visible = False
        Me.lblccharge.Visible = False
        Me.txtcharge.Visible = False
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.btnnew.Enabled = False
        Me.btnsave.Enabled = False
        Me.btnsear.Enabled = False
        Me.btndel.Enabled = False
        Me.GroupBox1.Enabled = True
        Try
            all_connect()
            If Me.btnedit.Text = "Edit" Then
                Dim ed
                Dim dt1, dts As New DataTable
                Dim adp, adps As New SqlDataAdapter
                ed = InputBox("Enter the ID")
                If String.IsNullOrEmpty(ed) Then
                    MsgBox("Cancelled or empty", MsgBoxStyle.Information)
                    Me.btnnew.Enabled = True
                    Me.btnsave.Enabled = True
                    Me.btnsear.Enabled = True
                    Me.btndel.Enabled = True
                    Exit Sub
                End If
                cmd.CommandText = "select * from employee where eid='" & ed & "'"
                adp.SelectCommand = cmd
                dt1.Clear()
                adp.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    Me.txtename.Text = dt1.Rows(0).Item(1)
                    Me.dtpb.Value = dt1.Rows(0).Item(2)
                    Me.txtage.Text = dt1.Rows(0).Item(3)
                    Dim gen As String
                    gen = dt1.Rows(0).Item(4)
                    If gen = "Female" Then
                        Me.radiofemale.Checked = True
                    Else
                        Me.radiomale.Checked = True
                    End If
                    Me.txtadd.Text = dt1.Rows(0).Item(5)
                    Me.txtcity.Text = dt1.Rows(0).Item(6)
                    Me.txtpin.Text = dt1.Rows(0).Item(7)
                    Me.dudstate.SelectedItem = dt1.Rows(0).Item(8)
                    Me.txtcont.Text = dt1.Rows(0).Item(9)
                    Me.txtrel.Text = dt1.Rows(0).Item(10)
                    Me.txtbg.SelectedItem = dt1.Rows(0).Item(11)
                    Me.dudms.SelectedItem = dt1.Rows(0).Item(12)
                    Me.txtph.Text = dt1.Rows(0).Item(13)
                    Me.txtemail.Text = dt1.Rows(0).Item(14)
                    Me.txtbank.Text = dt1.Rows(0).Item(15)
                    Me.txtqual.Text = dt1.Rows(0).Item(16)
                    Me.txtnom.Text = dt1.Rows(0).Item(17)
                    Me.dtpj.Value = dt1.Rows(0).Item(18)
                    Me.dudtype.SelectedItem = dt1.Rows(0).Item(19)
                    Me.txteid.Text = dt1.Rows(0).Item(0)
                    Me.Combobname.SelectedItem = dt1.Rows(0).Item(20)
                    Me.txtbasic.Text = dt1.Rows(0).Item(21)
                    If Me.dudtype.SelectedItem = "Doctor" Then
                        Me.lblccharge.Visible = True
                        Me.txtcharge.Visible = True
                        Me.lbldept.Visible = True
                        Me.duddep.Visible = True
                        cmd.CommandText = "select dept,charge from doctor where docid='" & ed & "'"
                        adps.SelectCommand = cmd
                        dts.Clear()
                        adps.Fill(dts)
                        If dts.Rows.Count > 0 Then
                            Me.duddep.SelectedItem = dts.Rows(0).Item(0)
                            Me.txtcharge.Text = dts.Rows(0).Item(1)
                        Else
                            MsgBox("No records", MsgBoxStyle.Exclamation)
                        End If
                    End If
                    Me.dudtype.Enabled = False
                    Me.btnnew.Enabled = False
                    Me.btnsave.Enabled = False
                    Me.btndel.Enabled = False
                    Me.btnsear.Enabled = False
                    Me.btnexit.Enabled = True
                    Me.txtename.ReadOnly = False
                    Me.txtage.ReadOnly = False
                    Me.txtadd.ReadOnly = False
                    Me.txtcity.ReadOnly = False
                    Me.txtpin.ReadOnly = False
                    Me.radiomale.Enabled = True
                    Me.radiofemale.Enabled = True
                    Me.txteid.ReadOnly = False
                    Me.dudstate.Visible = True
                    Me.dudms.Enabled = True
                    Me.txtbg.Enabled = True
                    Me.txtrel.ReadOnly = False
                    Me.txtph.ReadOnly = False
                    Me.txtemail.ReadOnly = False
                    Me.txtnom.ReadOnly = False
                    Me.txtqual.ReadOnly = False
                    Me.txtbank.ReadOnly = False
                    Me.btnedit.Text = "Update"
                Else
                    MsgBox("Invalid ID or Empty")
                End If
            ElseIf Me.btnedit.Text = "Update" Then
                If Me.txtename.Text = "" Or Me.txtage.Text = "" Or Me.txtadd.Text = "" Or Me.txtcity.Text = "" Or Me.txtpin.Text = "" Or Me.radiomale.Checked = False And Me.radiofemale.Checked = False Or Me.txteid.Text = "" Or Me.txtcont.Text = "" Or Me.dudstate.SelectedItem = "" Or Me.txtrel.Text = "" Or Me.txtbg.SelectedItem = "" Or Me.txtph.Text = "" Or Me.txtemail.Text = "" Or Me.txtnom.Text = "" Or Me.txtqual.Text = "" Or Me.dudms.SelectedItem = "" Or Me.txtbank.Text = "" Then
                    MsgBox("Enter all the fields")
                ElseIf Me.txtage.Text <= 22 Then
                    MsgBox("Minimum age is 22")
                    Me.dtpb.Focus()
                Else
                    cmd.CommandText = "update employee set eid=@eid,ename=@ename,dob=@dob,age=@age,gen=@gen,eadd=@eadd,city=@city,pin=@pin,state=@state,country=@country,relgn=@relgn,bg=@bg,ms=@ms,phno=@phno,email=@email,baccno=@baccno,qual=@qual,nom=@nom,doj=@doj,design=@design,bname=@bname,basic=@basic where eid=@eid"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Me.txteid.Text
                    cmd.Parameters.Add("@ename", SqlDbType.VarChar).Value = Me.txtename.Text
                    cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = Me.dtpb.Value.Date
                    cmd.Parameters.Add("@age", SqlDbType.Decimal).Value = Me.txtage.Text
                    Dim gn As String
                    If Me.radiofemale.Checked Then
                        gn = Me.radiofemale.Text
                    Else
                        gn = Me.radiomale.Text
                    End If
                    cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gn
                    cmd.Parameters.Add("@eadd", SqlDbType.VarChar).Value = Me.txtadd.Text
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = Me.txtcity.Text
                    cmd.Parameters.Add("@pin", SqlDbType.Decimal).Value = Me.txtpin.Text
                    cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = Me.dudstate.SelectedItem
                    cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = Me.txtcont.Text
                    cmd.Parameters.Add("@relgn", SqlDbType.VarChar).Value = Me.txtrel.Text
                    cmd.Parameters.Add("@bg", SqlDbType.VarChar).Value = Me.txtbg.SelectedItem
                    cmd.Parameters.Add("@ms", SqlDbType.VarChar).Value = Me.dudms.SelectedItem
                    cmd.Parameters.Add("@phno", SqlDbType.Decimal).Value = Me.txtph.Text
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Me.txtemail.Text
                    cmd.Parameters.Add("@baccno", SqlDbType.Decimal).Value = Me.txtbank.Text
                    cmd.Parameters.Add("@qual", SqlDbType.VarChar).Value = Me.txtqual.Text
                    cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = Me.txtnom.Text
                    cmd.Parameters.Add("@doj", SqlDbType.DateTime).Value = Me.dtpj.Value.Date
                    cmd.Parameters.Add("@design", SqlDbType.VarChar).Value = Me.dudtype.SelectedItem
                    cmd.Parameters.Add("@bname", SqlDbType.VarChar).Value = Me.Combobname.SelectedItem
                    cmd.Parameters.Add("@basic", SqlDbType.Decimal).Value = Me.txtbasic.Text
                    cmd.ExecuteNonQuery()
                    If Me.dudtype.SelectedItem = "Doctor" Then
                        Me.lblccharge.Visible = True
                        Me.txtcharge.Visible = True
                        Me.lbldept.Visible = True
                        Me.duddep.Visible = True
                        cmd.CommandText = "update doctor set dept=@dept,charge=@charge where docid='" & Me.txteid.Text & "'"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = Me.duddep.SelectedItem
                        cmd.Parameters.Add("@charge", SqlDbType.VarChar).Value = Me.txtcharge.Text
                        cmd.ExecuteNonQuery()
                    End If
                    MsgBox("Records updated!!")
                    Me.btnnew.Enabled = True
                    Me.btndel.Enabled = True
                    Me.btnsear.Enabled = True
                    Me.btnexit.Enabled = True
                    Me.btnedit.Text = "Edit"
                    Me.dudtype.Enabled = True
                    Me.GroupBox1.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnsear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsear.Click
        Me.btnnew.Enabled = False
        Me.btnedit.Enabled = False
        Me.btnsave.Enabled = False
        Me.btndel.Enabled = False
        Try
            all_connect()
            Dim ed1
            Dim dt2 As New DataTable
            Dim adp As New SqlDataAdapter
            ed1 = InputBox("Enter the ID")
            If String.IsNullOrEmpty(ed1) Then
                MsgBox("Cancelled or empty", MsgBoxStyle.Information)
                Me.btnnew.Enabled = True
                Me.btnedit.Enabled = True
                Me.btnsave.Enabled = True
                Me.btndel.Enabled = True
                Exit Sub
            End If
            cmd.CommandText = "select * from employee where eid='" & ed1 & "'"
            adp.SelectCommand = cmd
            dt2.Clear()
            adp.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                Me.txteid.Text = dt2.Rows(0).Item(0)
                Me.txtename.Text = dt2.Rows(0).Item(1)
                Me.dtpb.Value = dt2.Rows(0).Item(2)
                Me.txtage.Text = dt2.Rows(0).Item(3)
                Dim gen As String
                gen = dt2.Rows(0).Item(4)
                If gen = "Female" Then
                    Me.radiofemale.Checked = True
                Else
                    Me.radiomale.Checked = True
                End If
                Me.txtadd.Text = dt2.Rows(0).Item(5)
                Me.txtcity.Text = dt2.Rows(0).Item(6)
                Me.txtpin.Text = dt2.Rows(0).Item(7)
                Me.dudstate.SelectedItem = dt2.Rows(0).Item(8)
                Me.txtcont.Text = dt2.Rows(0).Item(9)
                Me.txtrel.Text = dt2.Rows(0).Item(10)
                Me.txtbg.SelectedItem = dt2.Rows(0).Item(11)
                Me.dudms.SelectedItem = dt2.Rows(0).Item(12)
                Me.txtph.Text = dt2.Rows(0).Item(13)
                Me.txtemail.Text = dt2.Rows(0).Item(14)
                Me.txtbank.Text = dt2.Rows(0).Item(15)
                Me.txtqual.Text = dt2.Rows(0).Item(16)
                Me.txtnom.Text = dt2.Rows(0).Item(17)
                Me.dtpj.Value = dt2.Rows(0).Item(18)
                Me.dudtype.SelectedItem = dt2.Rows(0).Item(19)
                Me.Combobname.SelectedItem = dt2.Rows(0).Item(20)
                Me.txtbasic.Text = dt2.Rows(0).Item(21)
                Me.txtename.ReadOnly = True
                Me.txtage.ReadOnly = True
                Me.txtadd.ReadOnly = True
                Me.txtcity.ReadOnly = True
                Me.txtpin.ReadOnly = True
                Me.radiomale.Enabled = False
                Me.radiofemale.Enabled = False
                Me.txteid.ReadOnly = True
                Me.dudstate.Enabled = False
                Me.txtrel.ReadOnly = True
                Me.txtbg.Enabled = False
                Me.txtph.ReadOnly = True
                Me.txtemail.ReadOnly = True
                Me.txtnom.ReadOnly = True
                Me.txtqual.ReadOnly = True
                Me.dudms.Enabled = False
                Me.txtbank.ReadOnly = True
                Me.dudtype.Enabled = False
                Me.dtpb.Enabled = False
                Me.dtpj.Enabled = False
                Me.btnnew.Enabled = True
                Me.btnedit.Enabled = True
                Me.btnsave.Enabled = True
                Me.btndel.Enabled = True
            Else
                MsgBox("No Records!!")
                Me.btnnew.Enabled = True
                Me.btnedit.Enabled = True
                Me.btnsave.Enabled = True
                Me.btndel.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub txtename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtename.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar > "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Me.ProcessTabKey(True)
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.txtename.ReadOnly = False
        Me.txtage.ReadOnly = False
        Me.txtadd.ReadOnly = False
        Me.txtcity.ReadOnly = False
        Me.txtpin.ReadOnly = False
        Me.radiomale.Enabled = True
        Me.radiofemale.Enabled = True
        Me.txteid.ReadOnly = False
        Me.dudstate.Enabled = False
        Me.txtrel.ReadOnly = False
        Me.txtbg.ReadOnly = False
        Me.txtph.ReadOnly = False
        Me.txtemail.ReadOnly = False
        Me.txtnom.ReadOnly = False
        Me.txtqual.ReadOnly = False
        Me.dudms.ReadOnly = False
        Me.txtbank.ReadOnly = False
        Me.dudtype.ReadOnly = False
        Me.Close()
    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Enter only Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub txtpin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpin.Leave
        Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtpin.Text), "^\d{6,}$", RegexOptions.IgnoreCase)
        If rex.Success = False Then
            Me.txtpin.Text = ""
            MsgBox("Enter a valid pin code")
            Me.txtpin.Clear()
        End If
    End Sub

    Private Sub txtph_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtph.Leave
        Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtph.Text), "^\d{10,}$", RegexOptions.IgnoreCase)
        If rex.Success = False Then
            Me.txtph.Text = ""
            MsgBox("Enter a valid phone number")
            Me.txtph.Clear()
        End If
    End Sub

    Private Sub txtrel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrel.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
    End Sub

    Private Sub txtnom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
    End Sub

    Private Sub txtbank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbank.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Enter only Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub txtbasic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbasic.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Salary Must be in Numbers", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            e.Handled = True
        End If
    End Sub

    
   
    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged
        If Me.txtage.Text = "" Then
            Exit Sub
        End If
        If Me.txtage.Text < 24 Or Me.txtage.Text > 60 Then
            MsgBox("Minimum Age is 24 or Invalid Age", MsgBoxStyle.Exclamation)
            Me.dtpb.Focus()
        End If
    End Sub
End Class