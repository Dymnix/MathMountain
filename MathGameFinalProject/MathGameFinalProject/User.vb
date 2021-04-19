'Class:     User
'Author:    Justin Sanner

Public Class User

    Dim Username As String
    Dim Password As String
    Dim AdditionHighScore As String
    Dim SubtractionHighScore As String
    Dim MixedHighScore As String

    Sub New(ByVal strUser As String, ByVal strPass As String, ByVal strHigh1 As String, ByVal strHigh2 As String, ByVal strHigh3 As String)

        Username = strUser
        Password = strPass
        AdditionHighScore = strHigh1
        SubtractionHighScore = strHigh2
        MixedHighScore = strHigh3
    End Sub

    Function GetUser() As String
        Return Username
    End Function

    Function GetPass() As String
        Return Password
    End Function

    Function GetAddition() As String
        Return AdditionHighScore
    End Function

    Function GetSubtraction() As String
        Return SubtractionHighScore
    End Function

    Function GetMixed() As String
        Return MixedHighScore
    End Function

End Class
