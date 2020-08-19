Imports System.Data.SqlClient
Public Class fblock
    Dim cval
    Private Sub btngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerate.Click
        Me.DataGridView1.Show()
        Try
            all_connect()
            If (Me.DataGridView1.SelectedRows.Count > 0) Then
                cval = Me.DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value.ToString()
                If String.IsNullOrEmpty(cval) Then
                    MsgBox("Empty row selected")
                Else
                    Dim j
                    j = InputBox("Create a Unique Key")
                    If String.IsNullOrEmpty(j) Then
                        MsgBox("Cancelled or Empty", MsgBoxStyle.Information)
                    Else
                        cmd.CommandText = "update blocked set uid='" & j & "' where bid='" & cval & "'"
                        cmd.ExecuteNonQuery()
                        MsgBox("Unique ID generated succesfully")
                    End If
                End If
            Else
                MsgBox("Please select a row", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub fblock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bgroup7DataSet10.blocked' table. You can move, or remove it, as needed.
        Me.BlockedTableAdapter1.Fill(Me.Bgroup7DataSet10.blocked)
        Me.DataGridView1.ClearSelection()
    End Sub
End Class