Public Class frmHighScore
    Public Sub doScore()
        If (playerScore < 1) Then
            Label1.Text = "Sorry Your Score Was Not Good Enough"
        Else
            Label1.Text = "Congratulations Your Score Will Be Will Be Added To The Hall Of Fame"
            IstHighScore.Items.Add(playerName & vbTab & vbTab & playerScore)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class