Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class addward

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.txtwt.Enabled = True
        Me.txtwno.Enabled = True
        Me.txtbn.Enabled = True
        Me.txtcharge.Enabled = True
        Me.txtcharge.Clear()
        Me.txtwt.Clear()
        Me.txtwno.Clear()
        Me.txtbn.Clear()
    End Sub

    Private Sub addward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtwt.Enabled = False
        Me.txtwno.Enabled = False
        Me.txtbn.Enabled = False
        Me.txtcharge.Enabled = False
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim idb As Integer
        Dim valb As String
        Dim id As Integer
        Dim val As String
        Dim ida As Integer
        Dim vala As String
        Try
            all_connect()
            If Me.txtwt.Text = "" Or Me.txtwno.Text = "" Or Me.txtbn.Text = "" Then
                MsgBox("Enter the fields Required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Me.txtwno.Text <= 0 Or Me.txtbn.Text <= 0 Then
                MsgBox("cannot be zero or negative values", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Me.txtcharge.Text <= 0 Then
                MsgBox("invalid amount or cannot be zero", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            cmd.CommandText = "select MAX(wno) from wards"
            val = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(val) Then
                val = "W0"
            End If
            val = val.Substring(1)
            Int32.TryParse(val, id)
            id = id + 1
            val = "W" + id.ToString("D1")
            cmd.CommandText = "insert into wards values(@wno,@wname)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@wno", SqlDbType.VarChar).Value = val
            cmd.Parameters.Add("@wname", SqlDbType.VarChar).Value = Me.txtwt.Text
            cmd.ExecuteNonQuery()
            Dim a, b, i, j As Integer
            a = Me.txtwno.Text
            b = Me.txtbn.Text
            vala = 0
            cmd.CommandText = "select MAX(wardno) from dward"
            vala = cmd.ExecuteScalar().ToString()
            valb = 0
            cmd.CommandText = "select MAX(bedno) from dward"
            valb = cmd.ExecuteScalar().ToString()
            For i = 1 To a
                If String.IsNullOrEmpty(vala) Then
                    vala = "X500"
                End If
                vala = vala.Substring(1)
                Int32.TryParse(vala, ida)
                ida = ida + 1
                vala = "X" + ida.ToString("D3")
                For j = 1 To b
                    If String.IsNullOrEmpty(valb) Then
                        valb = "I0"
                    End If
                    valb = valb.Substring(1)
                    Int32.TryParse(valb, idb)
                    idb = idb + 1
                    valb = "I" + idb.ToString("D1")
                    cmd.CommandText = "insert into dward values(@wno,@wardno,@bedno,@bcharge,@count)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@wno", SqlDbType.VarChar).Value = val
                    cmd.Parameters.Add("@wardno", SqlDbType.VarChar).Value = vala
                    cmd.Parameters.Add("@bedno", SqlDbType.VarChar).Value = valb
                    cmd.Parameters.Add("@bcharge", SqlDbType.Decimal).Value = Me.txtcharge.Text
                    cmd.Parameters.Add("@count", SqlDbType.VarChar).Value = "vacant"
                    cmd.ExecuteNonQuery()
                Next
            Next
            MsgBox("Added Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtwno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtwno.Leave
        Try
            Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtwno.Text), "^\d{1,}$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                Me.txtwno.Text = ""
                MsgBox("Currently limited to single digit", MsgBoxStyle.Information)
                Me.txtwno.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
       
    End Sub

    Private Sub txtbn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbn.Leave
        Try
            Dim rex As System.Text.RegularExpressions.Match = Regex.Match(Trim(Me.txtbn.Text), "^\d{1,}$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                Me.txtbn.Text = ""
                MsgBox("Currently limited to single digit", MsgBoxStyle.Information)
                Me.txtbn.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        
    End Sub

    Private Sub txtwt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwt.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = " " Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar >= "a" And e.KeyChar <= "z")) Then
            MsgBox("Enter only alphabet", MsgBoxStyle.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub txtwt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtwt.Leave
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            cmd.CommandText = "select * from wards where wname='" & Me.txtwt.Text & "'"
            adp.SelectCommand = cmd
            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Already existing ward", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtcharge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcharge.KeyPress
        If Not ((e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "" Or e.KeyChar = Chr(Keys.Enter)) Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MsgBox("Amount must be in numbers", MsgBoxStyle.Exclamation, "Adarsha Hospital")
            e.Handled = True
        End If
    End Sub

End Class