Module ModuleConfig
    Private Const CARA_DEFAUT As String = "ABCDE"
    Private Const NBR_CARA As Integer = 5
    Private Const NBR_COUP_DEFAUT As Integer = 15
    Private Const TEMPS_DEFAUT As Integer = 90

    Private CaraJouable() As String = {"A", "B", "C", "D", "E"}
    Private NombreCoupChoisis As Integer = 15
    Private timerActive = True
    Private tempsMax As Integer = TEMPS_DEFAUT

    Public Function getNombreCoupChoisis() As Integer
        Return NombreCoupChoisis
    End Function

    Public Function caraDifferent(newCara As String)
        If String.Compare(newCara, CARA_DEFAUT) <> 0 Then

            'Hashset c'est pour stocker des caracteres unique.
            Dim caracteres As New HashSet(Of Char)()
            For Each caractere As Char In newCara
                If caracteres.Contains(caractere) Then
                    Return False
                End If
                caracteres.Add(caractere)
            Next
        Else
            Return False
        End If
        Return True
    End Function

    Public Sub setNombreCoupChoisis(nbr As Integer)
        NombreCoupChoisis = nbr
    End Sub

    Public Function configChange() As Boolean
        If NombreCoupChoisis <> NBR_COUP_DEFAUT Or timerActive = False Or tempsMax <> TEMPS_DEFAUT Or getCaraJouable() <> CARA_DEFAUT Then
            Return True
        End If
        Return False
    End Function

    Public Sub resetConfigDefaut()
        NombreCoupChoisis = NBR_COUP_DEFAUT
        timerActive = True
        tempsMax = TEMPS_DEFAUT
        setCaraJouable(CARA_DEFAUT)
        FormulaireConfig.afficheBtnReset()
        FormulaireConfig.resetFormConfig()
    End Sub

    Public Sub setTempsMax(nbr As Integer)
        tempsMax = nbr
    End Sub

    Function getTempsMax() As Integer
        Return tempsMax
    End Function

    Public Sub setTimerActive(timerC As Boolean)
        timerActive = timerC
    End Sub

    Public Function timerEstActive() As Boolean
        Return timerActive
    End Function

    Public Function getNbrCaraMax() As Integer
        Return NBR_CARA
    End Function

    Public Sub setCaraJouable(cara As String)
        If cara <> "" And cara.Length = NBR_CARA Then
            cara = cara.ToArray
            For i As Integer = 0 To NBR_CARA - 1
                CaraJouable(i) = cara(i)
            Next
        End If
    End Sub

    Public Function getCaraJouable() As String
        Dim caractere As String = ""
        For i As Integer = 0 To NBR_CARA - 1
            caractere += CaraJouable(i)
        Next
        Return caractere
    End Function
End Module
