﻿Public Class frmQuestion4
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer1.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion5.Show()
        Me.Hide()

    End Sub
End Class