Module ModuleConfig
    Private CaraJouable() As String = {"A", "B", "C", "D", "E"}
    Private NombreDeCoupPossible As Integer = 15
    Private Const NBR_COUP_DEFAULT As Integer = 15
    Private Const NBR_CARA As Integer = 5
    Private timerActive = True

    Sub enleveNombreCoup()
        NombreDeCoupPossible = NombreDeCoupPossible - 1
    End Sub

    Sub setTimerActive(timerC As Boolean)
        timerActive = timerC
    End Sub

    Function getNbrCaraMax() As Integer
        Return NBR_CARA
    End Function

    Sub setNombreCoup(nbr As Integer)
        NombreDeCoupPossible = nbr
    End Sub

    Function timerEstActive() As Boolean
        Return timerActive
    End Function

    Function getNombreCoup() As Integer
        Return NombreDeCoupPossible
    End Function

    Sub setCaraJouable(cara As String)
        If cara <> "" And cara.Length = NBR_CARA Then
            cara = cara.ToArray
            For i As Integer = 0 To NBR_CARA - 1
                CaraJouable(i) = cara(i)
            Next
        End If
    End Sub

    Function getCaraJouable() As String
        Dim caractere As String = ""
        For i As Integer = 0 To NBR_CARA - 1
            caractere += CaraJouable(i)
        Next
        Return caractere
    End Function
End Module
