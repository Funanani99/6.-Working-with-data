Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMassage As String
        Dim BirthYear As Integer

        YourMassage = "Happy birthday! How old are you now"

        MsgBox(YourMassage)
        BirthYear = Val(InputBox("Enter your birth year"))
        MsgBox("You are now  " & 2023 - BirthYear & " years old")
    End Sub
End Class
