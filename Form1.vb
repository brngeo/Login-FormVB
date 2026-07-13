Public Class Form1
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Dim Username As String
        Dim Password As String

        Username = "admin"
        Password = "root"

        If (Username = Username_Textbox.Text And Password = Password_Textbox.Text) Then
            MessageBox.Show("Login Successfully!")
            Form2.Show()
            Hide()
        Else
            MessageBox.Show("Login Failed!")
        End If
    End Sub
End Class
