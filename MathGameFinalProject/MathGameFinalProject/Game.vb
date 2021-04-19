'Form:      Game
'Author:    Justin Sanner

Public Class Game

    'Declare variables
    Public Mode As String
    Public objUser As User
    Dim intCountdown As Integer = 3
    Dim intTime As Integer = 8
    Dim intLives As Integer = 3
    Dim intAnswer As Integer
    Dim intX As Integer
    Dim intY As Integer
    Dim prevX As Integer = 1
    Dim intMinX As Integer = 1
    Dim intMinY As Integer = 0
    Dim intMaxX As Integer = 2
    Dim intMaxY As Integer = 1
    Dim intScore As Integer = 0
    Dim strMixedSign As String
    Dim intMixedSignNum As Integer


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        'Checks if anything is entered into the textbox. 
        If txtAnswer.TextLength > 0 Then

            'Increments the Max X and Max Y (Linear Difficulty)
            intMaxX += 1
            intMaxY += 1

            'Resets time
            intTime = 7

            'Tries to compare entered text to intAnswer. If exception, treat it as a wrong answer
            Try
                If txtAnswer.Text <> intAnswer Then
                    'If answer is wrong, deduct 1 life and display "Incorrect!!!!" on screen
                    intLives -= 1
                    lblCountdown.Visible = True
                    lblCountdown.Text = "Incorrect!!!!"
                    Timer2.Start()
                Else
                    'If answer correct, increment score by 1
                    intScore += 1
                End If
            Catch ex As Exception
                'Exception treated as an incorrect answer
                intLives -= 1
                lblCountdown.Visible = True
                lblCountdown.Text = "Incorrect!!!!"
                Timer2.Start()
            End Try

            'Updates on-screen text to match variables
            lblLives.Text = "Lives: " + intLives.ToString()
            lblTimer.Text = "Time: " + intTime.ToString()

            'Loads a new equation
            txtAnswer.Clear()
            CreateEquation(Mode)
        End If

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets a random seed so equations are different every time
        Randomize()

        'Initiates the countdown and creates first equation
        lblCountdown.Visible = True
        lblCountdown.Text = "      " + intCountdown.ToString()
        Timer1.Start()
        CreateEquation(Mode)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Decrements the countdown every 1 second and updates the label
        lblCountdown.Visible = True
        intCountdown -= 1
        lblCountdown.Text = "      " + intCountdown.ToString()

        'Once the countdown is 0, display "Go!!", start Timer3, and stop Timer1
        If intCountdown = 0 Then
            lblCountdown.Text = "     Go!!"
            Timer3.Start()
            Timer1.Stop()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'When an incorrect answer is used, make the lblCountdown (displaying "Incorrect!!") visible for 0.5 seconds
        lblCountdown.Visible = False
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'This timer activates every 1 second

        'Decrement the time by 1 and update the Timer label
        intTime -= 1
        lblTimer.Text = "Time: " + intTime.ToString()

        'If Time hits 0, reset the time, subtract a life, and load a new equation
        If intTime = 0 Then
            intTime = 8
            intLives -= 1
            lblLives.Text = "Lives: " + intLives.ToString()
            txtAnswer.Clear()
            CreateEquation(Mode)
        End If

        'If lives hit 0, reset lives and time variables and end the game, taking the user to the EndScreen form
        If intLives = 0 Then
            intLives = 3
            intTime = 8
            Timer3.Stop()
            Dim frmEndScreen As New EndScreen

            frmEndScreen.objUser = objUser
            frmEndScreen.intScore = intScore
            frmEndScreen.Mode = Mode
            Hide()
            frmEndScreen.ShowDialog()
        End If

        'Sets necessary items to Visible (only effective on the first tick) and focuses on txtAnswer
        'General Note: I am aware that there is no score displayed. This was an intentional choice,
        'as I like the idea of not knowing if the user has passed their high score until the end.
        lblEquation.Visible = True
        lblGameTitle.Visible = True
        lblLives.Visible = True
        lblTimer.Visible = True
        txtAnswer.Visible = True
        btnConfirm.Visible = True
        lblCountdown.Visible = False
        txtAnswer.Focus()
    End Sub

    Function CreateEquation(Mode)
        'This function creates a new equation using logic to increase difficulty over time

        'sets the X integer to a random number between intMinX and intMaxX
        intX = (intMaxX - intMinX + 1) * Rnd() + intMinX

        'If the previous X value (default 1) is the same as the current X value, increment the current X value by 1
        'This prevents repeat equations from occuring consecutively
        If prevX = intX Then
            intX += 1
        End If

        'Overwrite the prevX variable with the current intX
        prevX = intX

        'sets the Y integer to a random number between intMinY and intMaxY
        intY = (intMaxY - intMinY + 1) * Rnd() + intMinY

        'Each game mode creates the equations differently
        'Each mode will set the lblEquation to match the equation asked, and set an intAnswer to the answer to said equation
        'The intAnswer is compared to the value in the textbox when the Confirm button is clicked (See btnConfirm subroutine for context)
        Select Case Mode
            Case "Addition"
                'In Addition mode, equations are simply X + Y
                lblEquation.Text = intX.ToString() & " + " & intY.ToString() & " = "
                intAnswer = intX + intY
            Case "Subtraction"
                'In Subtraction mode, if the score is less than 12 and the X value is less than the Y value, the order of X and Y are swapped
                'This is to prevent negative numbers from appearing as solutions for the first few equations as difficulty balance
                If intScore < 12 And intX < intY Then
                    lblEquation.Text = intY.ToString() & " - " & intX.ToString() & " = "
                    intAnswer = intY - intX
                Else
                    'After score is greater than 12, negative numbers are just as likely to appear as positive numbers
                    lblEquation.Text = intX.ToString() & " - " & intY.ToString() & " = "
                    intAnswer = intX - intY
                End If
            Case "Mixed"
                'Mixed (Addition and Subtraction Mode) uses the same logic as the above two modes, but can switch between them randomly
                'intMixedSignNum is a random number between 1 and 2. If 1, addition is performed. If 2, subtraction is performed.
                'Subtraction still checks for negative number solutions before score reaches 12. Additionally, addition is the default in case of 
                'this variable returning a number other than 1 or 2 somehow
                intMixedSignNum = 2 * Rnd() + 1
                If intMixedSignNum = 1 Then
                    lblEquation.Text = intY.ToString() & " + " & intX.ToString() & " = "
                    intAnswer = intY + intX
                ElseIf intMixedSignNum = 2 And intScore < 12 And intX < intY Then
                    lblEquation.Text = intY.ToString() & " - " & intX.ToString() & " = "
                    intAnswer = intY - intX
                ElseIf intMixedSignNum = 2 Then
                    lblEquation.Text = intX.ToString() & " - " & intY.ToString() & " = "
                    intAnswer = intX - intY
                Else
                    lblEquation.Text = intX.ToString() & " + " & intY.ToString() & " = "
                    intAnswer = intX + intY
                End If
        End Select

        'Focuses the textbox and returns the intAnswer
        txtAnswer.Focus()
        Return intAnswer
    End Function
End Class