Imports System.Data.SqlClient
Public Class scanbillview
    Private Sub scanbillview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt5
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class