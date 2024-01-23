Imports System.Data.OleDb
Public Class frndashboard
    Private Sub frndashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub
End Class