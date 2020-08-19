Imports System.Data.SqlClient
Public Class capmt

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Try
            all_connect()
            If Me.combopatient.SelectedItem <> "" Then
                cmd.CommandText = "delete from consult where pid='" + Me.combopatient.SelectedItem + "'"
                cmd.ExecuteNonQuery()
                MsgBox("succesfully cancelled")
            Else
                MsgBox("Please select op number")
            End If
        Catch ex As Exception
            MsgBox("Appointment for this patient ID not found!!!")
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub capmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            all_connect()
            Dim adp As New SqlDataAdapter
            Dim dt1 As New DataTable
            cmd.CommandText = "select pid from consult"
            adp.SelectCommand = cmd
            dt1.Clear()
            adp.Fill(dt1)
            Dim i As Integer
            Dim n
            n = dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                For i = 0 To n
                    Me.combopatient.Items.Add(dt1.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class