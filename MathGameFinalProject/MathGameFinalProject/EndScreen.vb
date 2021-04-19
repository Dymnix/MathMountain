'Form:      End Screen
'Author:    Justin Sanner

Public Class EndScreen

    'Declare variables
    Public objUser As User
    Public updatedUser As User
    Public intScore As Integer
    Public Mode As String


    Private Sub EndScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Declare variables
        Dim strUser As String = objUser.GetUser()
        Dim strPass As String = objUser.GetPass()
        Dim strHigh1 As String = objUser.GetAddition()
        Dim strHigh2 As String = objUser.GetSubtraction()
        Dim strHigh3 As String = objUser.GetMixed()

        'Compares current score to high score based on game mode, then displays the appropriate text
        'If high score, write the new score into the file. 
        Select Case Mode
            Case "Addition"
                If objUser.GetAddition() < intScore Then
                    lblLine1.Text = "New High Score!"
                    lblLine2.Text = "Old Score: " + objUser.GetAddition()
                    lblLine3.Text = "New Score: " + intScore.ToString()
                    updatedUser = WriteToFile(strUser, strPass, strHigh1, strHigh2, strHigh3, Mode, intScore)
                Else
                    lblLine1.Text = "Try Again!"
                    lblLine2.Text = "High Score: " + objUser.GetAddition()
                    lblLine3.Text = "Your Score: " + intScore.ToString()
                    updatedUser = objUser
                End If
            Case "Subtraction"
                If objUser.GetSubtraction() < intScore Then
                    lblLine1.Text = "New High Score!"
                    lblLine2.Text = "Old Score: " + objUser.GetSubtraction()
                    lblLine3.Text = "New Score: " + intScore.ToString()
                    updatedUser = WriteToFile(strUser, strPass, strHigh1, strHigh2, strHigh3, Mode, intScore)
                Else
                    lblLine1.Text = "Try Again!"
                    lblLine2.Text = "High Score: " + objUser.GetSubtraction()
                    lblLine3.Text = "Your Score: " + intScore.ToString()
                    updatedUser = objUser
                End If
            Case "Mixed"
                If objUser.GetMixed() < intScore Then
                    lblLine1.Text = "New High Score!"
                    lblLine2.Text = "Old Score: " + objUser.GetMixed()
                    lblLine3.Text = "New Score: " + intScore.ToString()
                    updatedUser = WriteToFile(strUser, strPass, strHigh1, strHigh2, strHigh3, Mode, intScore)
                Else
                    lblLine1.Text = "Try Again!"
                    lblLine2.Text = "High Score: " + objUser.GetMixed()
                    lblLine3.Text = "Your Score: " + intScore.ToString()
                    updatedUser = objUser
                End If
        End Select
    End Sub

    'Writes new high scores to the login.txt file
    Function WriteToFile(strUser, strPass, strHigh1, strHigh2, strHigh3, Mode, intScore) As User
        Dim strFile As String = "..\..\Resources\login.txt"

        'Perform method if file exists. Else, skip.
        If IO.File.Exists(strFile) Then
            Dim objReader As IO.StreamReader
            Dim objWriter As IO.StreamWriter
            Dim intCount As Integer = 0
            Dim _strInfo(4) As String
            Dim boolCorrectUser As Boolean = False

            'Create an array of users, including their username, password, and high scores.
            Dim _strEntry(IO.File.ReadAllLines(strFile).Length) As String
            objReader = IO.File.OpenText(strFile)
            Do While objReader.Peek <> -1
                _strEntry(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            'Updates the array to include the new high score
            Do Until boolCorrectUser = True
                For entry As Integer = 0 To _strEntry.Length - 2
                    _strInfo = Split(_strEntry(entry), ",")
                    If strUser = _strInfo(0) Then
                        Select Case Mode
                            Case "Addition"
                                _strInfo(2) = intScore.ToString()
                                strHigh1 = intScore.ToString()
                            Case "Subtraction"
                                _strInfo(3) = intScore.ToString()
                                strHigh2 = intScore.ToString()
                            Case "Mixed"
                                _strInfo(4) = intScore.ToString()
                                strHigh3 = intScore.ToString()
                        End Select
                        _strEntry(entry) = _strInfo(0) + "," + _strInfo(1) + "," + _strInfo(2) + "," + _strInfo(3) + "," + _strInfo(4)
                        boolCorrectUser = True
                    End If
                Next
            Loop

            'Deletes the file, then writes the array into a new login.txt file
            IO.File.Delete(strFile)
            objWriter = IO.File.AppendText(strFile)
            For entry As Integer = 0 To _strEntry.Length - 2
                _strInfo = Split(_strEntry(entry), ",")
                For Int As Integer = 0 To 3
                    objWriter.Write(_strInfo(Int) + ",")
                Next
                objWriter.WriteLine(_strInfo(4))
            Next
            objWriter.Close()

            'Creates new user object to pass through so that the function can return a user object
            Dim userPass As New User(strUser, strPass, strHigh1, strHigh2, strHigh3)

            Return userPass
        Else
            'Completes function without saving data
            MsgBox("High Score could not be saved.", , "Error")

            'Creates new user object to pass through so that the function can return a user object
            Dim userPass As New User(strUser, strPass, strHigh1, strHigh2, strHigh3)

            Return userPass
        End If
    End Function


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Returns to the GameMode form
        Dim frmGameMode As New GameMode

        frmGameMode.objUser = updatedUser
        Hide()
        frmGameMode.ShowDialog()
    End Sub
End Class