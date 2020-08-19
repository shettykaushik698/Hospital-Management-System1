Imports System.Data.SqlClient
Public Class admin
    Inherits System.Windows.Forms.Form
    Private Sub admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If login.lbltype.Text = "DOCTOR PORTAL" Then
            Me.ToolStripDropDownButton1.Enabled = False
        Else
            Me.ToolStripDropDownButton1.Enabled = True
        End If
        cnn.Close()
        Try
            all_connect()
            If login.txtid.Text = "ADMIN" Then
                Me.lbluse.Text = "ADMIN"
            Else
                cmd.CommandText = "select ename from employee where eid='" & login.txtid.Text & "'"
                Me.lbluse.Text = cmd.ExecuteScalar.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlog.Click
        login.Close()
        main.Show()
        Me.Close()
    End Sub

    Private Sub btnaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccount.Click
        accounts.MdiParent = Me
        accounts.Show()
    End Sub

    Private Sub btnem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnem.Click
        adde.MdiParent = Me
        adde.Show()
    End Sub

    Private Sub btnba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fblock.MdiParent = Me
        fblock.Show()
    End Sub

    Private Sub btnopr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopr.Click
        OP.MdiParent = Me
        OP.Show()
    End Sub

    Private Sub ipr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipr.Click
        IP.MdiParent = Me
        IP.Show()
    End Sub

    Private Sub btnfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfe.Click
        fileentry.MdiParent = Me
        fileentry.Show()
    End Sub

    Private Sub btndfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndfe.Click
        capmt.MdiParent = Me
        capmt.Show()
    End Sub

    Private Sub AppointmentsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentsToolStripMenuItem2.Click
        apmts.Show()
    End Sub

    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangep.Click
        cpass.Show()
    End Sub

    Private Sub WardMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WardMasterToolStripMenuItem.Click
        wardm.Show()
    End Sub

    Private Sub btnba_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnba.Click
        fblock.Show()
    End Sub

    Private Sub PatientMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientMasterToolStripMenuItem.Click
        pmaster.Show()
    End Sub

    Private Sub LabTestAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestAppointmentToolStripMenuItem.Click
        labap.Show()
    End Sub

    Private Sub LabTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestToolStripMenuItem.Click
        labdis.Show()
    End Sub

    Private Sub ScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanToolStripMenuItem.Click
        scandis.Show()
    End Sub

    Private Sub CTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTToolStripMenuItem1.Click
        scan.Show()
    End Sub

    Private Sub BedShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BedShiftToolStripMenuItem.Click
        bedshift.Show()
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveToolStripMenuItem.Click
        Attend.Show()
    End Sub
End Class