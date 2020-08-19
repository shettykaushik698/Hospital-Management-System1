Imports System.Data.SqlClient
Public Class admin
    Inherits System.Windows.Forms.Form
    Private Sub admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
        If login.lbltype.Text = "DOCTOR PORTAL" Then
            Me.btnaccount.Enabled = False
            Me.btnem.Enabled = False
            Me.AdvanceToolStripMenuItem.Enabled = False
            Me.WardMasterToolStripMenuItem.Enabled = False
            Me.PatientMasterToolStripMenuItem.Enabled = False
            Me.btnopr.Enabled = False
            Me.ipr.Enabled = False
            Me.IPTreatmentToolStripMenuItem.Enabled = False
            Me.btnfe.Enabled = False
            Me.btndfe.Enabled = False
            Me.LabTestAppointmentToolStripMenuItem.Enabled = False
            Me.CTToolStripMenuItem1.Enabled = False
            Me.BedShiftToolStripMenuItem.Enabled = False
            Me.btnds.Enabled = False
            Me.LabTestToolStripMenuItem.Enabled = False
            Me.ScanToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem15.Enabled = False
            Me.ScanReportsToolStripMenuItem1.Enabled = False
            Me.AddNewEmployeeToolStripMenuItem.Enabled = False
            Me.LeaveToolStripMenuItem.Enabled = False
            Me.SalaryCalculationToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem25.Enabled = False
            Me.ResignationToolStripMenuItem.Enabled = False
            Me.AppointmentsToolStripMenuItem2.Enabled = True
            Me.ResignationToolStripMenuItem1.Enabled = False
            Me.OPChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem31.Enabled = False
            Me.ScanChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem35.Enabled = False
            Me.btnba.Visible = False
            Me.TreatmentMasterToolStripMenuItem.Enabled = False
            Me.LabTestMasterToolStripMenuItem.Enabled = False
        ElseIf login.lbltype.Text = "LABORATORY PORTAL" Then
            Me.AdvanceToolStripMenuItem.Enabled = False
            Me.btnaccount.Enabled = False
            Me.btnem.Enabled = False
            Me.WardMasterToolStripMenuItem.Enabled = False
            Me.PatientMasterToolStripMenuItem.Enabled = False
            Me.btnopr.Enabled = False
            Me.ipr.Enabled = False
            Me.IPTreatmentToolStripMenuItem.Enabled = False
            Me.btnfe.Enabled = False
            Me.btndfe.Enabled = False
            Me.LabTestAppointmentToolStripMenuItem.Enabled = False
            Me.CTToolStripMenuItem1.Enabled = False
            Me.BedShiftToolStripMenuItem.Enabled = False
            Me.btnds.Enabled = False
            Me.LabTestToolStripMenuItem.Enabled = True
            Me.ScanToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem15.Enabled = True
            Me.ScanReportsToolStripMenuItem1.Enabled = True
            Me.AddNewEmployeeToolStripMenuItem.Enabled = False
            Me.LeaveToolStripMenuItem.Enabled = False
            Me.SalaryCalculationToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem25.Enabled = False
            Me.ResignationToolStripMenuItem.Enabled = False
            Me.AppointmentsToolStripMenuItem2.Enabled = False
            Me.ResignationToolStripMenuItem1.Enabled = False
            Me.OPChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem31.Enabled = False
            Me.ScanChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem35.Enabled = False
            Me.btnba.Visible = False
            Me.TreatmentMasterToolStripMenuItem.Enabled = False
            Me.LabTestMasterToolStripMenuItem.Enabled = False
        ElseIf login.lbltype.Text = "RECEPTIONIST PORTAL" Then
            Me.AdvanceToolStripMenuItem.Enabled = False
            Me.btnaccount.Enabled = False
            Me.btnem.Enabled = False
            Me.WardMasterToolStripMenuItem.Enabled = True
            Me.PatientMasterToolStripMenuItem.Enabled = True
            Me.btnopr.Enabled = True
            Me.ipr.Enabled = True
            Me.IPTreatmentToolStripMenuItem.Enabled = True
            Me.btnfe.Enabled = True
            Me.btndfe.Enabled = True
            Me.LabTestAppointmentToolStripMenuItem.Enabled = True
            Me.CTToolStripMenuItem1.Enabled = True
            Me.BedShiftToolStripMenuItem.Enabled = True
            Me.btnds.Enabled = True
            Me.LabTestToolStripMenuItem.Enabled = False
            Me.ScanToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem15.Enabled = False
            Me.ScanReportsToolStripMenuItem1.Enabled = False
            Me.AddNewEmployeeToolStripMenuItem.Enabled = False
            Me.LeaveToolStripMenuItem.Enabled = False
            Me.SalaryCalculationToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem25.Enabled = False
            Me.ResignationToolStripMenuItem.Enabled = False
            Me.AppointmentsToolStripMenuItem2.Enabled = False
            Me.ResignationToolStripMenuItem1.Enabled = False
            Me.OPChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem31.Enabled = False
            Me.ScanChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem35.Enabled = False
            Me.btnba.Visible = False
            Me.TreatmentMasterToolStripMenuItem.Enabled = False
            Me.LabTestMasterToolStripMenuItem.Enabled = False
        ElseIf login.lbltype.Text = "BILLING PORTAL" Then
            Me.AdvanceToolStripMenuItem.Enabled = False
            Me.btnaccount.Enabled = False
            Me.btnem.Enabled = False
            Me.WardMasterToolStripMenuItem.Enabled = False
            Me.PatientMasterToolStripMenuItem.Enabled = False
            Me.btnopr.Enabled = False
            Me.ipr.Enabled = False
            Me.IPTreatmentToolStripMenuItem.Enabled = False
            Me.btnfe.Enabled = False
            Me.btndfe.Enabled = False
            Me.LabTestAppointmentToolStripMenuItem.Enabled = False
            Me.CTToolStripMenuItem1.Enabled = False
            Me.BedShiftToolStripMenuItem.Enabled = False
            Me.btnds.Enabled = False
            Me.LabTestToolStripMenuItem.Enabled = False
            Me.ScanToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem15.Enabled = False
            Me.ScanReportsToolStripMenuItem1.Enabled = False
            Me.AddNewEmployeeToolStripMenuItem.Enabled = False
            Me.LeaveToolStripMenuItem.Enabled = False
            Me.SalaryCalculationToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem25.Enabled = False
            Me.ResignationToolStripMenuItem.Enabled = False
            Me.AppointmentsToolStripMenuItem2.Enabled = False
            Me.ResignationToolStripMenuItem1.Enabled = False
            Me.OPChargeToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem31.Enabled = True
            Me.ScanChargeToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem35.Enabled = True
            Me.btnba.Visible = False
            Me.TreatmentMasterToolStripMenuItem.Enabled = False
            Me.LabTestMasterToolStripMenuItem.Enabled = False
        ElseIf login.lbltype.Text = "HR PORTAL" Then
            Me.AdvanceToolStripMenuItem.Enabled = True
            Me.btnaccount.Enabled = False
            Me.btnem.Enabled = True
            Me.WardMasterToolStripMenuItem.Enabled = True
            Me.PatientMasterToolStripMenuItem.Enabled = True
            Me.btnopr.Enabled = False
            Me.ipr.Enabled = False
            Me.IPTreatmentToolStripMenuItem.Enabled = False
            Me.btnfe.Enabled = False
            Me.btndfe.Enabled = False
            Me.LabTestAppointmentToolStripMenuItem.Enabled = False
            Me.CTToolStripMenuItem1.Enabled = False
            Me.BedShiftToolStripMenuItem.Enabled = False
            Me.btnds.Enabled = False
            Me.LabTestToolStripMenuItem.Enabled = False
            Me.ScanToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem15.Enabled = False
            Me.ScanReportsToolStripMenuItem1.Enabled = False
            Me.AddNewEmployeeToolStripMenuItem.Enabled = True
            Me.LeaveToolStripMenuItem.Enabled = True
            Me.SalaryCalculationToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem25.Enabled = True
            Me.ResignationToolStripMenuItem.Enabled = True
            Me.AppointmentsToolStripMenuItem2.Enabled = False
            Me.ResignationToolStripMenuItem1.Enabled = True
            Me.OPChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem31.Enabled = False
            Me.ScanChargeToolStripMenuItem.Enabled = False
            Me.ToolStripMenuItem35.Enabled = False
            Me.btnba.Visible = False
            Me.TreatmentMasterToolStripMenuItem.Enabled = False
            Me.LabTestMasterToolStripMenuItem.Enabled = False
        ElseIf login.lbltype.Text = "ADMIN" Then
            Me.AdvanceToolStripMenuItem.Enabled = True
            Me.btnaccount.Enabled = True
            Me.btnem.Enabled = True
            Me.WardMasterToolStripMenuItem.Enabled = True
            Me.PatientMasterToolStripMenuItem.Enabled = True
            Me.btnopr.Enabled = True
            Me.ipr.Enabled = True
            Me.IPTreatmentToolStripMenuItem.Enabled = True
            Me.btnfe.Enabled = True
            Me.btndfe.Enabled = True
            Me.LabTestAppointmentToolStripMenuItem.Enabled = True
            Me.CTToolStripMenuItem1.Enabled = True
            Me.BedShiftToolStripMenuItem.Enabled = True
            Me.btnds.Enabled = True
            Me.LabTestToolStripMenuItem.Enabled = True
            Me.ScanToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem15.Enabled = True
            Me.ScanReportsToolStripMenuItem1.Enabled = True
            Me.AddNewEmployeeToolStripMenuItem.Enabled = True
            Me.LeaveToolStripMenuItem.Enabled = True
            Me.SalaryCalculationToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem25.Enabled = True
            Me.ResignationToolStripMenuItem1.Enabled = True
            Me.AppointmentsToolStripMenuItem2.Enabled = True
            Me.ResignationToolStripMenuItem1.Enabled = True
            Me.OPChargeToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem31.Enabled = True
            Me.ScanChargeToolStripMenuItem.Enabled = True
            Me.ToolStripMenuItem35.Enabled = True
            Me.btnba.Visible = True
            Me.TreatmentMasterToolStripMenuItem.Enabled = True
            Me.LabTestMasterToolStripMenuItem.Enabled = True
        End If
        cnn.Close()
        Try
            all_connect()
            If login.txtid.Text = "ADMIN" Then
                Me.lbluse.Text = "ADMIN"
                Me.nnn.Visible = False
                Me.lblide.Visible = False
            Else
                Me.nnn.Visible = True
                Me.lblide.Visible = True
                cmd.CommandText = "select ename from employee where eid='" & login.txtid.Text & "'"
                Me.lbluse.Text = cmd.ExecuteScalar.ToString()
                Me.lblide.Text = login.txtid.Text
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
    Private Sub BedShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BedShiftToolStripMenuItem.Click
        bedshift.Show()
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveToolStripMenuItem.Click
        Attend.Show()
    End Sub

    Private Sub SalaryCalculationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryCalculationToolStripMenuItem.Click
        salarycal.Show()
    End Sub
    Private Sub ResignationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResignationToolStripMenuItem1.Click
        Resign.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
        cpass.Show()
    End Sub

    Private Sub AddNewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        adde.MdiParent = Me
        adde.Show()
    End Sub

    Private Sub btnem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnem.Click
        empdetails.Show()
    End Sub

    Private Sub IPTreatmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPTreatmentToolStripMenuItem.Click
        treatment.Show()
    End Sub

    Private Sub btnds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnds.Click
        dischargesummary.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        labreport.Show()
    End Sub

    
    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        payslip.Show()
    End Sub

    Private Sub OPChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPChargeToolStripMenuItem.Click
        opbill.Show()
    End Sub

    Private Sub AdvanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanceToolStripMenuItem.Click
        advance.Show()
    End Sub

    Private Sub CTScanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTScanToolStripMenuItem1.Click
        scan.lblscan.Text = "CT-SCAN"
        scan.Show()
    End Sub

    Private Sub MRIToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRIToolStripMenuItem2.Click
        scan.lblscan.Text = "MRI"
        scan.Show()
    End Sub

    Private Sub ECHOToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECHOToolStripMenuItem1.Click
        scan.lblscan.Text = "ECHO"
        scan.Show()
    End Sub

    Private Sub ECGToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECGToolStripMenuItem2.Click
        scan.lblscan.Text = "ECG"
        scan.Show()
    End Sub

    Private Sub XRAYToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XRAYToolStripMenuItem2.Click
        scan.lblscan.Text = "X-RAY"
        scan.Show()
    End Sub
    Private Sub XRAYToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XRAYToolStripMenuItem3.Click
        scandis.lblscan.Text = "X-RAY"
        scandis.Show()
    End Sub

    Private Sub CTSCANToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTSCANToolStripMenuItem2.Click
        scandis.lblscan.Text = "CT-SCAN"
        scandis.Show()
    End Sub

    Private Sub MRIToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRIToolStripMenuItem3.Click
        scandis.lblscan.Text = "MRI"
        scandis.Show()
    End Sub

    Private Sub ECHOToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECHOToolStripMenuItem2.Click
        scandis.lblscan.Text = "ECHO"
        scandis.Show()
    End Sub

    Private Sub ECGToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECGToolStripMenuItem3.Click
        scandis.lblscan.Text = "ECG"
        scandis.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lbltime.Text = System.DateTime.Now
    End Sub

    Private Sub BedShiftDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BedShiftDetailsToolStripMenuItem.Click
        wardbs.Show()
    End Sub

    Private Sub ScanChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanChargeToolStripMenuItem.Click
        scanbill.Show()
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        labbill.Show()
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        ipbill.Show()
    End Sub

    Private Sub btnabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabt.Click
        about.Show()
    End Sub

    Private Sub TreatmentMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreatmentMasterToolStripMenuItem.Click
        treatmentmaster.Show()
    End Sub

    Private Sub LabTestMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestMasterToolStripMenuItem.Click
        labmaster.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class