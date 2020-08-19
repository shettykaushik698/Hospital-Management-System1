Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class IP
    Dim bds As New BindingSource
    Dim dt2 As New DataTable
    Dim adp As New SqlDataAdapter
    Dim z As Integer
    Dim ip
    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If Me.txtipname.Text = "" Or Me.txtage.Text = "" Or Me.txtipadd.Text = "" Or Me.txtcity.Text = "" Or Me.txtpin.Text = "" Or Me.radiomale.Checked = False And Me.radiofemale.Checked = False Or Me.txtopno.Text = "" Or Me.txtcare.Text = "" Or Me.dudstate.SelectedItem = "" Or Me.txtref.Text = "" Or Me.dtpipdate.Text = "" Or Me.txtph1.Text = "" Or Me.duddoc.Text = "" Or Me.duddept.SelectedItem = "" Or Me.dudscheme.SelectedItem = "" Or Me.dudward.SelectedItem = "" Or Me.txtipdis.SelectedItem = "" Or Me.txtbed.SelectedItem = "" Then
                MsgBox("Enter all the fields")
            Else
                all_connect()
                cmd.CommandText = "insert into ip values(@opno,@ipno,@ipdate,@ipname,@ipcare,@ipadd,@ipcity,@ippin,@ipph,@ipstate,@ipdob,@ipage,@ipgen,@ipdept,@ipref,@ipdoc,@ipward,@ipbed,@ipwno,@ipscheme)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = Me.txtopno.Text
                cmd.Parameters.Add("@ipno", SqlDbType.VarChar).Value = Me.txtipno.Text
                cmd.Parameters.Add("@ipdate", SqlDbType.DateTime).Value = Me.dtpipdate.Value.Date
                cmd.Parameters.Add("@ipname", SqlDbType.VarChar).Value = Me.txtipname.Text
                cmd.Parameters.Add("@ipcare", SqlDbType.VarChar).Value = Me.txtcare.Text
                cmd.Parameters.Add("@ipadd", SqlDbType.VarChar).Value = Me.txtipadd.Text
                cmd.Parameters.Add("@ipcity", SqlDbType.VarChar).Value = Me.txtcity.Text
                cmd.Parameters.Add("@ippin", SqlDbType.Decimal).Value = Me.txtpin.Text
                cmd.Parameters.Add("@ipph", SqlDbType.Decimal).Value = Me.txtph1.Text
                cmd.Parameters.Add("@ipstate", SqlDbType.VarChar).Value = Me.dudstate.SelectedItem
                cmd.Parameters.Add("@ipdob", SqlDbType.DateTime).Value = Me.dtpdob.Value.Date
                cmd.Parameters.Add("@ipage", SqlDbType.Decimal).Value = Me.txtage.Text
                Dim gn1 As String
                If Me.radiofemale.Checked Then
                    gn1 = Me.radiofemale.Text
                ElseIf Me.radiomale.Checked Then
                    gn1 = Me.radiomale.Text
                Else
                    gn1 = Me.radioother.Text
                End If
                cmd.Parameters.Add("@ipgen", SqlDbType.VarChar).Value = gn1
                cmd.Parameters.Add("@ipdept", SqlDbType.VarChar).Value = Me.duddept.SelectedItem
                cmd.Parameters.Add("@ipref", SqlDbType.VarChar).Value = Me.txtref.Text
                cmd.Parameters.Add("@ipdoc", SqlDbType.VarChar).Value = Me.duddoc.SelectedItem
                cmd.Parameters.Add("@ipward", SqlDbType.VarChar).Value = Me.dudward.SelectedItem
                cmd.Parameters.Add("@ipbed", SqlDbType.VarChar).Value = Me.txtbed.SelectedItem
                cmd.Parameters.Add("@ipwno", SqlDbType.VarChar).Value = Me.txtipdis.SelectedItem
                cmd.Parameters.Add("@ipscheme", SqlDbType.VarChar).Value = Me.dudscheme.SelectedItem
                cmd.ExecuteNonQuery()
                cmd.CommandText = "update dward set count='alloted' where bedno='" & Me.txtbed.SelectedItem & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("IN-Patient added successfully")
                Me.Panel2.Enabled = False
                Me.Panel1.Enabled = False
                Me.btnsave.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

   

    Private Sub IP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Panel2.Enabled = False
        Me.Panel3.Enabled = False
        Try
            all_connect()
            Dim adpward As New SqlDataAdapter
            Dim dtward As New DataTable
            Dim i1
            Me.dudward.Items.Clear()
            cmd.CommandText = "select wname from wards"
            adpward.SelectCommand = cmd
            dtward.Clear()
            adpward.Fill(dtward)
            If dtward.Rows.Count > 0 Then
                For i1 = 0 To dtward.Rows.Count - 1
                    Me.dudward.Items.Add(dtward.Rows(i1).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub duddept_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles duddept.SelectedIndexChanged
        Me.duddoc.Text = ""
        Try
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim i As Integer
            Me.duddoc.Items.Clear()
            cmd.CommandText = "select dname from doctor where dept='" + Me.duddept.SelectedItem + "'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.duddoc.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub txtipname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtipname.KeyPress
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

    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
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

    Private Sub txtph1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtph1.Leave
        Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtph1.Text), "^\d{10,}$", RegexOptions.IgnoreCase)
        If rex.Success = False Then
            Me.txtph1.Text = ""
            MsgBox("Enter a valid phone number")
            Me.txtph1.Clear()
        End If
    End Sub

    Private Sub txtref_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtref.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar > "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet")
            e.Handled = True
        End If
        If (e.KeyChar = Chr(Keys.Enter)) Then
            Me.ProcessTabKey(True)
        End If
    End Sub    

    
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.Panel2.Enabled = True
        Me.Panel1.Enabled = True
        Me.btnsave.Enabled = True
        Me.txtopno.Clear()
        Me.txtipno.Clear()
        Me.txtipname.Clear()
        Me.txtcare.Clear()
        Me.txtipadd.Clear()
        Me.txtcity.Clear()
        Me.txtpin.Clear()
        Me.txtph1.Clear()
        Me.txtage.Clear()
        Me.txtref.Clear()
        Me.lblbcharge.Text = "----"
        Me.dudward.Items.Clear()
        Me.txtipdis.Items.Clear()
        Me.txtbed.Items.Clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dudward_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudward.SelectedIndexChanged
        Me.txtipdis.Items.Clear()
        Me.txtipdis.Text = ""
        Me.txtbed.Text = ""
        Me.lblbcharge.Text = "------"
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim v As String
            Dim i
            cmd.CommandText = "select wno from wards where wname='" & Me.dudward.SelectedItem & "'"
            v = cmd.ExecuteScalar().ToString()
            If v = "" Then
                MsgBox("Select ward type", MsgBoxStyle.Information)
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
                    Me.txtipdis.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
            Dim w
            cmd.CommandText = "select bcharge from dward where wno='" & v & "' and count='vacant'"
            w = cmd.ExecuteScalar()
            Me.lblbcharge.Text = w
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtipdis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtipdis.SelectedIndexChanged
        Me.txtbed.Items.Clear()
        Me.txtbed.Text = ""
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            Dim i
            cmd.CommandText = "select bedno from dward where wardno='" & Me.txtipdis.SelectedItem & "' and count='vacant'"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.txtbed.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnad.Click
        If Me.txtopno.Text = "" Then
            MsgBox("Enter OP Number", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Me.Panel2.Enabled = True
            Me.Panel3.Enabled = True
            Try
                all_connect()
                Dim dt2 As New DataTable
                Dim adp1 As New SqlDataAdapter
                cmd.CommandText = "select ipno from ip where opno='" & Me.txtopno.Text & "'"
                adp1.SelectCommand = cmd
                dt2.Clear()
                adp1.Fill(dt2)
                If dt2.Rows.Count > 0 Then
                    MsgBox("In Patient already exists for this OP number")
                Else
                    Dim adp, adp3 As New SqlDataAdapter
                    Dim dt1, dt3 As New DataTable
                    cmd.CommandText = " select * from opbill where opno='" & Me.txtopno.Text & "'"
                    adp3.SelectCommand = cmd
                    dt3.Clear()
                    adp3.Fill(dt3)
                    If dt3.Rows.Count > 0 Then
                        cmd.CommandText = " select opname,opadd,opcity,oppin,opstate,opph,opdob,opage,opgen,opcare,opdept,opref,opscheme,opttl,opctl from op where opno='" & Me.txtopno.Text & "'"
                        adp.SelectCommand = cmd
                        dt1.Clear()
                        adp.Fill(dt1)
                        Me.txtipname.Text = dt1.Rows(0).Item(13) & dt1.Rows(0).Item(0)
                        Me.txtipadd.Text = dt1.Rows(0).Item(1)
                        Me.txtcity.Text = dt1.Rows(0).Item(2)
                        Me.txtpin.Text = dt1.Rows(0).Item(3)
                        Me.dudstate.SelectedItem = dt1.Rows(0).Item(4)
                        Me.txtph1.Text = dt1.Rows(0).Item(5)
                        Me.dtpdob.Value = dt1.Rows(0).Item(6)
                        Me.txtage.Text = dt1.Rows(0).Item(7)
                        Dim gen As String
                        gen = dt1.Rows(0).Item(8)
                        If gen = "Female" Then
                            Me.radiofemale.Checked = True
                        ElseIf gen = "Male" Then
                            Me.radiomale.Checked = True
                        Else
                            Me.radioother.Checked = True
                        End If
                        Me.txtcare.Text = dt1.Rows(0).Item(14) & dt1.Rows(0).Item(9)
                        Me.duddept.SelectedItem = dt1.Rows(0).Item(10)
                        Me.txtref.Text = dt1.Rows(0).Item(11)
                        Me.dudscheme.SelectedItem = dt1.Rows(0).Item(12)
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "select MAX(ipno) from ip"
                        Dim id As Integer
                        Dim val As String
                        val = cmd.ExecuteScalar().ToString()
                        If String.IsNullOrEmpty(val) Then
                            val = "IPT000"
                        End If
                        val = val.Substring(3)
                        Int32.TryParse(val, id)
                        id = id + 1
                        val = "IPT" + id.ToString("D3")
                        Me.txtipno.Text = val
                    Else
                        MsgBox("OP bill pending,can only proceed after OP bill payment", MsgBoxStyle.Exclamation)
                    End If
                End If
            Catch ex As Exception
                MsgBox("Invalid ID or Empty")
            Finally
                cnn.Close()
            End Try
        End If
        Try
            all_connect()
            Dim adpward As New SqlDataAdapter
            Dim dtward As New DataTable
            Dim i1
            Me.dudward.Items.Clear()
            cmd.CommandText = "select wname from wards"
            adpward.SelectCommand = cmd
            dtward.Clear()
            adpward.Fill(dtward)
            If dtward.Rows.Count > 0 Then
                For i1 = 0 To dtward.Rows.Count - 1
                    Me.dudward.Items.Add(dtward.Rows(i1).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

End Class