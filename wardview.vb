Imports System.Data.SqlClient
Public Class wardview
    Dim b1, b2, b3, b4, b5, b6
    Private Sub wardview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b2 = 100 - (Math.Round((wardm.l / wardm.k) * 100))
        b3 = 100 - (Math.Round((wardm.p / wardm.o) * 100))
        b4 = 100 - (Math.Round((wardm.t / wardm.s) * 100))
        b5 = 100 - (Math.Round((wardm.x / wardm.w) * 100))
        b6 = 100 - (Math.Round((wardm.b / wardm.a) * 100))
        Me.DataGridView1.Rows.Add("GEN-WARD", wardm.k, wardm.j, b2 & "%")
        Me.DataGridView1.Rows.Add("SEMI-SPECIAL-WARD", wardm.o, wardm.m, b3 & "%")
        Me.DataGridView1.Rows.Add("SPECIAL-WARD", wardm.s, wardm.q, b4 & "%")
        Me.DataGridView1.Rows.Add("DELUX-WARD", wardm.w, wardm.u, b5 & "%")
        Me.DataGridView1.Rows.Add("PLATINUM-WARD", wardm.a, wardm.y, b6 & "%")
        b1 = Math.Round(((b2 + b3 + b5 + b5 + b6) / 500) * 100)
        Me.DataGridView1.Rows.Add(" ", " ", "Total", b1 & "% filled")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class