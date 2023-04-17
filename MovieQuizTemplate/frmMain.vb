Public Class frmMain
    Private Sub bntStart_Click(sender As Object, e As EventArgs) Handles bntStart.Click
        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion4.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class