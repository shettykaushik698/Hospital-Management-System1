Public Class payslipview

    Private Sub payslipview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt6
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class