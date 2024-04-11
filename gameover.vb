Public Class gameover
    Private Sub gameover_Load(sender As Object, e As EventArgs) Handles Me.Shown

        Dim score As Integer = Form1.scorepointthing
        Form1.Close()
        Label1.Text = score

    End Sub

End Class