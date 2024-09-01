' CONTROLS AND EVENTS PROGRAMMING ASSIGNMENT
' Purpose: to show I have a solid foundation to create a Visual Basic program
' Josiah Barringer


Public Class Form1
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Update the TextBox text and change the form background color
        txtCore.Text = "I will not use code that was never covered in class or in our textbook. If you do, you must be able to explain your code when asked by the professor. Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating."
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' Quit the application
        Me.Close()
    End Sub
End Class
