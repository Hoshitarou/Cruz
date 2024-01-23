Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        sql = "Select * from tblUsers where Username='" & TxtUsername.Text & "' and Password= '" & TxtPassword.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            frndashboard.tssusername.Text = TxtUsername.Text
            frndashboard.tssrole.Text = LblRole.Text
            frndashboard.Show()

        Else
            MsgBox("Wrong Password", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged
        sql = "Select [Role] from tblUsers where Username='" & TxtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            LblRole.Text = dr(0).ToString
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
