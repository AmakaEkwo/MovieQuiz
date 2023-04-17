Public Class frmQuestion4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If (btnAnswer1.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQuestion6.Show()
        Me.Hide()
    End Sub


End Class