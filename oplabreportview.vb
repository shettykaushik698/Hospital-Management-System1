Public Class oplabreportview

    Private Sub oplabreportview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt4
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class