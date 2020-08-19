Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.SelectionFormula = rpt
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class