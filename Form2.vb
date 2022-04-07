Public Class Form2

    Private Sub CmdExit_Click(sender As Object, e As EventArgs) Handles CmdExit.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPunkteStand.Text = "Du hast " & Form1.Punktestand & " Punkte gemacht!"
    End Sub
End Class