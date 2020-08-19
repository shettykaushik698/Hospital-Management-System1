Imports System.Data.SqlClient
Public Class iplabreportview

    Private Sub iplabreportview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt2
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class