'Form:      GameMode
'Author:    Justin Sanner

Public Class GameMode

    'Initializes the objUser
    Public objUser As User

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        'When the "View High Scores" button is clicked, the user can view their personal high scores

        'Gets the needed info from objUser and displays the information in a messagebox
        Dim strUser As String = objUser.GetUser()
        Dim strPass As String = objUser.GetPass()
        Dim strHigh1 As String = objUser.GetAddition()
        Dim strHigh2 As String = objUser.GetSubtraction()
        Dim strHigh3 As String = objUser.GetMixed()
        MsgBox(strUser + "'s High Scores:" + vbCrLf + vbCrLf + "Addition: " + strHigh1 + vbCrLf + "Subtraction: " + strHigh2 + vbCrLf + "Mixed: " + strHigh3, , "Scores")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the application
        Application.Exit()
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        Dim frmGame As New Game

        'Starts a new game based on which radiobutton is checked
        If radAddition.Checked Then
            frmGame.Mode = "Addition"
        ElseIf radSubtraction.Checked Then
            frmGame.Mode = "Subtraction"
        ElseIf radMixed.Checked Then
            frmGame.Mode = "Mixed"
        End If

        frmGame.objUser = objUser
        Hide()
        frmGame.ShowDialog()

    End Sub
End Class