Public Class frmQuestion5
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmQuestion5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer3.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion6.Show()
        Me.Hide()
    End Sub
End Class