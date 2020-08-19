Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class OP
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If Me.txtopname.Text = "" Or Me.txtage.Text = "" Or Me.txtopadd.Text = "" Or Me.txtcity.Text = "" Or Me.txtpin.Text = "" Or Me.radiomale.Checked = False And Me.radiofemale.Checked = False And Me.radioother.Checked = False And Me.radioother.Checked = False Or Me.txtopno.Text = "" Or Me.txtcare.Text = "" Or Me.dudstate.SelectedItem = "" Or Me.txtref.Text = "" Or Me.dtpopdate.Text = "" Or Me.txtph1.Text = "" Or Me.txtrm.Text = "" Or Me.duddept.SelectedItem = "" Or Me.dudscheme.SelectedItem = "" Then
                MsgBox("Enter all the fields")
            Else
                all_connect()
                cmd.CommandText = "insert into op values(@opno,@opdate,@opname,@opadd,@opcity,@oppin,@opstate,@opph,@opdob,@opage,@opgen,@opscheme,@opdept,@opref,@oprem,@opcare,@opttl,@opctl,@register)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                cmd.Parameters.Add("@opdate", SqlDbType.DateTime).Value = Me.dtpopdate.Value.Date
                cmd.Parameters.Add("@opname", SqlDbType.VarChar).Value = Me.txtopname.Text
                cmd.Parameters.Add("@opadd", SqlDbType.VarChar).Value = Me.txtopadd.Text
                cmd.Parameters.Add("@opcity", SqlDbType.VarChar).Value = Me.txtcity.Text
                cmd.Parameters.Add("@oppin", SqlDbType.Decimal).Value = Me.txtpin.Text
                cmd.Parameters.Add("@opstate", SqlDbType.VarChar).Value = Me.dudstate.Text
                cmd.Parameters.Add("@opph", SqlDbType.Decimal).Value = Me.txtph1.Text
                cmd.Parameters.Add("@opdob", SqlDbType.DateTime).Value = Me.dtpdob.Value.Date
                cmd.Parameters.Add("@opage", SqlDbType.Decimal).Value = Me.txtage.Text
                Dim gn1 As String
                If Me.radiofemale.Checked Then
                    gn1 = Me.radiofemale.Text
                ElseIf Me.radiomale.Checked Then
                    gn1 = Me.radiomale.Text
                Else
                    gn1 = Me.radioother.Text
                End If
                cmd.Parameters.Add("@opgen", SqlDbType.VarChar).Value = gn1
                cmd.Parameters.Add("@opscheme", SqlDbType.VarChar).Value = Me.dudscheme.SelectedItem
                cmd.Parameters.Add("@opdept", SqlDbType.VarChar).Value = Me.duddept.SelectedItem
                cmd.Parameters.Add("@opref", SqlDbType.VarChar).Value = Me.txtref.Text
                cmd.Parameters.Add("@oprem", SqlDbType.VarChar).Value = Me.txtrm.Text
                cmd.Parameters.Add("@opcare", SqlDbType.VarChar).Value = Me.txtcare.Text
                cmd.Parameters.Add("@opttl", SqlDbType.Char).Value = Trim(Me.commrms.SelectedItem)
                cmd.Parameters.Add("@opctl", SqlDbType.Char).Value = Trim(Me.comcare.SelectedItem)
                cmd.Parameters.Add("@register", SqlDbType.VarChar).Value = "notpaid"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Patient registered successfully")
                Me.Panel2.Enabled = False
                Me.Panel1.Enabled = False
                Me.btnsave.Enabled = False
                Me.btnedit.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub dtpdob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdob.ValueChanged
        Dim d1 = System.DateTime.Now.Year - Me.dtpdob.Value.Date.Year
        Dim m1 = System.DateTime.Now.Month - Me.dtpdob.Value.Date.Month
        Dim t1 = System.DateTime.Now.Day - Me.dtpdob.Value.Date.Day
        If m1 <= 0 And t1 <= -1 Then
            d1 = d1 - 1
        Else
            Me.txtage.Text = d1
        End If
        Me.txtage.Text = d1
        If Val(Me.txtage.Text) < 1 Then
            Me.txtage.Clear()
            MsgBox("Age must be positive", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Me.Panel2.Enabled = False
        Me.Panel1.Enabled = False
        Me.btnsave.Enabled = False
        Me.commrms.DropDownStyle = ComboBoxStyle.DropDown
        Me.comcare.DropDownStyle = ComboBoxStyle.DropDown
        Try
            all_connect()
            Dim op
            Dim dt2 As New DataTable
            Dim adp As New SqlDataAdapter
            op = InputBox("Enter the ID")
            cmd.CommandText = "select * from op where opno='" & op & "'"
            adp.SelectCommand = cmd
            dt2.Clear()
            adp.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                Me.txtopno.Text = dt2.Rows(0).Item(0)
                Me.dtpopdate.Value = dt2.Rows(0).Item(1)
                Me.txtopname.Text = dt2.Rows(0).Item(2)
                Me.txtopadd.Text = dt2.Rows(0).Item(3)
                Me.txtcity.Text = dt2.Rows(0).Item(4)
                Me.txtpin.Text = dt2.Rows(0).Item(5)
                Me.dudstate.SelectedItem = dt2.Rows(0).Item(6)
                Me.txtph1.Text = dt2.Rows(0).Item(7)
                Me.dtpdob.Value = dt2.Rows(0).Item(8)
                Me.txtage.Text = dt2.Rows(0).Item(9)
                Dim gen As String
                gen = dt2.Rows(0).Item(10)
                If gen = "Female" Then
                    Me.radiofemale.Checked = True
                ElseIf gen = "Male" Then
                    Me.radiomale.Checked = True
                Else
                    Me.radioother.Checked = True
                End If
                Me.dudscheme.Text = dt2.Rows(0).Item(11)
                Me.duddept.Text = dt2.Rows(0).Item(12)
                Me.txtref.Text = dt2.Rows(0).Item(13)
                Me.txtrm.Text = dt2.Rows(0).Item(14)
                Me.txtcare.Text = dt2.Rows(0).Item(15)
                Me.commrms.Text = dt2.Rows(0).Item(16)
                Me.comcare.Text = dt2.Rows(0).Item(17)
            ElseIf String.IsNullOrEmpty(op) Then
                MsgBox("Empty or cancelled!!")
            Else
                MsgBox("No Records!!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Me.commrms.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comcare.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Panel2.Enabled = True
        Me.Panel1.Enabled = True
        Me.btnsave.Enabled = True
        Me.btnedit.Enabled = False
        Try
            all_connect()
            cmd.CommandText = "select MAX(opno) from op"
            Dim id As Integer
            Dim val As String
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "OPT000"
            End If
            val = val.Substring(3)
            Int32.TryParse(val, id)
            id = id + 1
            val = "OPT" + id.ToString("D3")
            Me.txtopno.Text = val.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
        Me.txtopname.Clear()
        Me.txtopadd.Clear()
        Me.txtcity.Clear()
        Me.txtage.Clear()
        Me.txtcare.Clear()
        Me.txtref.Clear()
        Me.txtph1.Clear()
        Me.txtrm.Clear()
        Me.txtpin.Clear()
    End Sub

    Private Sub OP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.commrms.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comcare.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Panel2.Enabled = False
        Me.Panel1.Enabled = False
        Me.btnedit.Enabled = True
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.commrms.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comcare.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ed
        Me.Panel2.Enabled = True
        Me.Panel1.Enabled = True
        Me.btnsave.Enabled = False
        Try
            all_connect()
            If Me.btnedit.Text = "Edit" Then
                Dim dt1, dt5 As New DataTable
                Dim adp, adp5 As New SqlDataAdapter
                ed = InputBox("Enter the ID")
                cmd.CommandText = "select * from ip where opno='" & ed & "'"
                adp5.SelectCommand = cmd
                dt5.Clear()
                adp5.Fill(dt5)
                If dt5.Rows.Count > 0 Then
                    MsgBox("Editing is not possible when the patient is IP", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                cmd.CommandText = "select * from op where opno='" & ed & "'"
                adp.SelectCommand = cmd
                dt1.Clear()
                adp.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    Me.txtopno.Text = dt1.Rows(0).Item(0)
                    Me.dtpopdate.Value = dt1.Rows(0).Item(1)
                    Me.txtopname.Text = dt1.Rows(0).Item(2)
                    Me.txtopadd.Text = dt1.Rows(0).Item(3)
                    Me.txtcity.Text = dt1.Rows(0).Item(4)
                    Me.txtpin.Text = dt1.Rows(0).Item(5)
                    Me.dudstate.SelectedItem = dt1.Rows(0).Item(6)
                    Me.txtph1.Text = dt1.Rows(0).Item(7)
                    Me.dtpdob.Value = dt1.Rows(0).Item(8)
                    Me.txtage.Text = dt1.Rows(0).Item(9)
                    Dim gen As String
                    gen = dt1.Rows(0).Item(10)
                    If gen = "Female" Then
                        Me.radiofemale.Checked = True
                    ElseIf gen = "Male" Then
                        Me.radiomale.Checked = True
                    Else
                        Me.radioother.Checked = True
                    End If
                    Me.dudscheme.SelectedItem = dt1.Rows(0).Item(11)
                    Me.duddept.SelectedItem = dt1.Rows(0).Item(12)
                    Me.txtref.Text = dt1.Rows(0).Item(13)
                    Me.txtrm.Text = dt1.Rows(0).Item(14)
                    Me.txtcare.Text = dt1.Rows(0).Item(15)
                    Me.commrms.SelectedItem = dt1.Rows(0).Item(16)
                    Me.comcare.SelectedItem = dt1.Rows(0).Item(17)
                    Me.btnedit.Text = "Update"
                Else
                    MsgBox("Invalid ID or Empty")

                End If
            ElseIf Me.btnedit.Text = "Update" Then
                If Me.txtopname.Text = "" Or Me.txtage.Text = "" Or Me.txtopadd.Text = "" Or Me.txtcity.Text = "" Or Me.txtpin.Text = "" Or Me.radiomale.Checked = False And Me.radiofemale.Checked = False And Me.radioother.Checked = False Or Me.txtopno.Text = "" Or Me.txtcare.Text = "" Or Me.dudstate.SelectedItem = "" Or Me.txtref.Text = "" Or Me.dtpopdate.Text = "" Or Me.txtph1.Text = "" Or Me.txtrm.Text = "" Or Me.duddept.SelectedItem = "" Or Me.dudscheme.SelectedItem = "" Then
                    MsgBox("Enter all the fields")
                Else
                    cmd.CommandText = "update op set opdate=@opdate,opname=@opname,opadd=@opadd,opcity=@opcity,oppin=@oppin,opstate=@opstate,opph=@opph,opdob=@opdob,opage=@opage,opgen=@opgen,opscheme=@opscheme,opdept=@opdept,opref=@opref,oprem=@oprem,opcare=@opcare,opttl=@opttl,opctl=@opctl where opno='" & Me.txtopno.Text & "'"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                    cmd.Parameters.Add("@opdate", SqlDbType.DateTime).Value = Me.dtpopdate.Value.Date
                    cmd.Parameters.Add("@opname", SqlDbType.VarChar).Value = Me.txtopname.Text
                    cmd.Parameters.Add("@opadd", SqlDbType.VarChar).Value = Me.txtopadd.Text
                    cmd.Parameters.Add("@opcity", SqlDbType.VarChar).Value = Me.txtcity.Text
                    cmd.Parameters.Add("@oppin", SqlDbType.Decimal).Value = Me.txtpin.Text
                    cmd.Parameters.Add("@opstate", SqlDbType.VarChar).Value = Me.dudstate.Text
                    cmd.Parameters.Add("@opph", SqlDbType.Decimal).Value = Me.txtph1.Text
                    cmd.Parameters.Add("@opdob", SqlDbType.DateTime).Value = Me.dtpdob.Value.Date
                    cmd.Parameters.Add("@opage", SqlDbType.Decimal).Value = Me.txtage.Text
                    Dim gn1 As String
                    If Me.radiofemale.Checked Then
                        gn1 = Me.radiofemale.Text
                    ElseIf Me.radiomale.Checked Then
                        gn1 = Me.radiomale.Text
                    Else
                        gn1 = Me.radioother.Text
                    End If
                    cmd.Parameters.Add("@opgen", SqlDbType.VarChar).Value = gn1
                    cmd.Parameters.Add("@opscheme", SqlDbType.VarChar).Value = Me.dudscheme.SelectedItem
                    cmd.Parameters.Add("@opdept", SqlDbType.VarChar).Value = Me.duddept.SelectedItem
                    cmd.Parameters.Add("@opref", SqlDbType.VarChar).Value = Me.txtref.Text
                    cmd.Parameters.Add("@oprem", SqlDbType.VarChar).Value = Me.txtrm.Text
                    cmd.Parameters.Add("@opcare", SqlDbType.VarChar).Value = Me.txtcare.Text
                    cmd.Parameters.Add("@opttl", SqlDbType.Char).Value = Me.commrms.SelectedItem
                    cmd.Parameters.Add("@opctl", SqlDbType.Char).Value = Me.comcare.SelectedItem
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Updated succesfully successfully")
                    Me.Panel2.Enabled = False
                    Me.Panel1.Enabled = False
                    Me.btnedit.Text = "Edit"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtph1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtph1.Leave
        Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtph1.Text), "^\d{10,}$", RegexOptions.IgnoreCase)
        If rex.Success = False Then
            Me.txtph1.Text = ""
            MsgBox("Enter a valid phone number")
            Me.txtph1.Clear()
        End If
    End Sub

    Private Sub dtpopdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpopdate.ValueChanged
        If System.DateTime.Now.Date < Me.dtpopdate.Value.Date Then
            MsgBox("Invalid joining Date")
            Me.dtpopdate.ResetText()
        End If
    End Sub

    Private Sub txtopname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtopname.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar > "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Me.ProcessTabKey(True)
        End If
    End Sub

    Private Sub txtcare_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcare.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar > "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Me.ProcessTabKey(True)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
End Class