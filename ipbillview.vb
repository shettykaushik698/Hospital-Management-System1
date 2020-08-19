Imports System.Data.SqlClient
Public Class ipbillview

    Private Sub ipbillview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CrystalReportViewer1.SelectionFormula = rpt1
            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class