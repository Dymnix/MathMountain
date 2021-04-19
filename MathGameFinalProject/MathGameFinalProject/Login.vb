'Form:      Login
'Author:    Justin Sanner

Public Class Login

    Private Sub btnLoginUser_Click(sender As Object, e As EventArgs) Handles btnLoginUser.Click

        'Declare Variables
        Dim objReader As IO.StreamReader
        Dim strFile As String = "..\..\Resources\login.txt"
        Dim _strInfo(4) As String
        Dim strUser As String
        Dim strPass As String
        Dim strHigh1 As String
        Dim strHigh2 As String
        Dim strHigh3 As String
        Dim intCount As Integer = 0
        Dim boolSuccess As Boolean = False
        Dim boolEmpty As Boolean = True

        'Makes sure a username and password are entered
        If txtPassword.TextLength < 1 Or txtUsername.TextLength < 1 Then
            MsgBox("Please enter a username and password.", , "Error")
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        Else
            boolEmpty = False
        End If

        'If the login file exists (users exist)
        If IO.File.Exists(strFile) Then

            'Create an array of users, including their username, password, and high scores.
            Dim _strEntry(IO.File.ReadAllLines(strFile).Length) As String
            objReader = IO.File.OpenText(strFile)
            Do While objReader.Peek <> -1
                _strEntry(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            'Checks the username and password of each user. If there is a match, login.
            For entry As Integer = 0 To _strEntry.Length - 2
                _strInfo = Split(_strEntry(entry), ",")
                strUser = _strInfo(0)
                strPass = _strInfo(1)
                strHigh1 = _strInfo(2)
                strHigh2 = _strInfo(3)
                strHigh3 = _strInfo(4)
                If txtUsername.Text = strUser And txtPassword.Text = strPass Then
                    boolSuccess = True
                    Dim objUser As User
                    objUser = New User(strUser, strPass, strHigh1, strHigh2, strHigh3)

                    Dim frmGameMode As New GameMode
                    frmGameMode.objUser = objUser
                    Hide()
                    frmGameMode.ShowDialog()
                End If
            Next

            'If the username and password do not match the login.txt, display an error clear the textboxes
            If boolSuccess = False And boolEmpty = False Then
                MsgBox("Username and Password do not match. Please try again.", , "Error")
                txtPassword.Clear()
                txtUsername.Clear()
                txtUsername.Focus()
            End If

        Else
            'If no file exists, returns to the StartScreen form
            MsgBox("No users exist yet... Why not create a new account?", , "Error")
            Dim frmStartScreen As New StartScreen
            Hide()
            frmStartScreen.ShowDialog()
        End If

    End Sub

    'Allows program to close correctly with the 'X' button
    Private Sub Login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Returns to the previous screen
        Dim frmStartScreen As New StartScreen

        Hide()
        frmStartScreen.ShowDialog()
    End Sub

End Class