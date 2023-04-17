Public Class frmQuestion2
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If (btnAnswer3.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmQuestion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class