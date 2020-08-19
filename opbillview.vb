Public Class opbillview

    Private Sub opbillview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class