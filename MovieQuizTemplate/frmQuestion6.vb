Public Class frmQuestion6
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        Me.Hide()
    End Sub
End Class