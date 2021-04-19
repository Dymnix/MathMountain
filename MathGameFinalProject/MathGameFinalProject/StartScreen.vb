'Form:      Start Screen
'Author:    Justin Sanner

Public Class StartScreen
    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        Dim frmNewUser As New NewUser
        'Goes to the New User form
        Hide()
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmLogin As New Login
        'Goes to the Login Form
        Hide()
        frmLogin.ShowDialog()
    End Sub
End Class
