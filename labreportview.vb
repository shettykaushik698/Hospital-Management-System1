Imports System.Data.SqlClient
Public Class labreportview
    Private Sub labreportview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt3
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class