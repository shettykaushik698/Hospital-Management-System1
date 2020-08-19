Public Class loadp
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 5
        If Me.ProgressBar1.Value >= 100 Then
            Me.Timer1.Enabled = False
            main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub loadp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
    End Sub
End Class