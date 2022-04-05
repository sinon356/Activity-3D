Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNum As Integer
        Dim rand1 As New System.Random
        intNum = rand1.Next(10)
        lblNum.text = intNum
    End Sub
End Class
