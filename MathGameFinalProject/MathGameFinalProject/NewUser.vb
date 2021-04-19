'Form:      New User Registration
'Author:    Justin Sanner

Public Class NewUser

    Private Sub btnCreateNewUser_Click(sender As Object, e As EventArgs) Handles btnCreateNewUser.Click

        'Makes sure a username and password are entered
        If txtPassword.TextLength < 1 Or txtUsername.TextLength < 1 Then
            MsgBox("Please enter a username and password.", , "Error")
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If

        'Declare Variables
        Dim objReader As IO.StreamReader
        Dim objWriter As IO.StreamWriter
        Dim strFile As String = "..\..\Resources\login.txt"
        Dim _strInfo(4) As String
        Dim boolNewUser As Boolean = True
        Dim strUser As String
        Dim intCount As Integer = 0

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

            'Checks the username of each user. If a username is already used, prevents a new user from being created
            For entry As Integer = 0 To _strEntry.Length - 2
                _strInfo = Split(_strEntry(entry), ",")
                strUser = _strInfo(0)
                If txtUsername.Text = strUser Then
                    MsgBox("Username already exists. Please choose another username.", , "Error")
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                    boolNewUser = False
                End If
            Next

        End If

        'Creates the user in the login file and returns to the start screen
        If boolNewUser = True Then
            objWriter = IO.File.AppendText(strFile)
            objWriter.WriteLine(txtUsername.Text + "," + txtPassword.Text + ",0,0,0")
            objWriter.Close()
            MsgBox("User successfully created!", , "Success!")

            Dim frmStartScreen As New StartScreen

            Hide()
            frmStartScreen.ShowDialog()
        End If

    End Sub


    Private Sub NewUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Allows program to close correctly with the 'X' button
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Returns to the previous screen
        Dim frmStartScreen As New StartScreen

        Hide()
        frmStartScreen.ShowDialog()
    End Sub
End Class