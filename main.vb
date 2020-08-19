Public Class main
    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        login.lbltype.Text = "ADMIN PORTAL"
        login.Show()
    End Sub

    Private Sub btndoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndoctor.Click
        login.lbltype.Text = "DOCTOR PORTAL"
        login.Show()
    End Sub

    Private Sub btnnurse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnurse.Click
        login.lbltype.Text = "BILLING PORTAL"
        login.Show()
    End Sub

    Private Sub btnhr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhr.Click
        login.lbltype.Text = "HR PORTAL"
        login.Show()
    End Sub

    Private Sub btnlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlab.Click
        login.lbltype.Text = "LABORATORY PORTAL"
        login.Show()
    End Sub

    Private Sub btnrecep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecep.Click
        login.lbltype.Text = "RECEPTIONIST PORTAL"
        login.Show()
    End Sub


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        loadp.Close()
    End Sub

    Private Sub btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class