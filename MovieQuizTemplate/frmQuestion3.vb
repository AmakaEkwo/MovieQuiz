﻿Public Class frmQuestion3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (btnAnswer4.Checked) Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        frmHighScore.doScore()
        Me.Hide()

    End Sub
End Class