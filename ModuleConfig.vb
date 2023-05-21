Module ModuleConfig
    Private CaraJouable() As String = {"A", "B", "C", "D", "E"}
    'Les coups au court de la partie
    Private NombreDeCoupPossible As Integer = 15

    'Les coups defauts choisis par l'utilisateur ou non
    Private NbrCoupDefaut As Integer = 15
    Private Const NBR_CARA As Integer = 5

    Private timerActive = True
    Private tempsDefaut As Integer = 90
    Private tempsMax As Integer = tempsDefaut



    Public Sub HandleFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermer", MessageBoxButtons.YesNo)

        If ferm = DialogResult.No Then
            e.Cancel = True ' Annuler la fermeture du formulaire
        Else
            ArchiverJoueurDansFichier()
            Application.Exit()
        End If
    End Sub

    Public Sub enleveNombreCoup()
        NombreDeCoupPossible = NombreDeCoupPossible - 1
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

    Public Function getNbrCaraMax() As Integer
        Return NBR_CARA
    End Function

    Public Sub setNombreCoup(nbr As Integer)
        NombreDeCoupPossible = nbr
        NbrCoupDefaut = nbr
    End Sub

    Public Function timerEstActive() As Boolean
        Return timerActive
    End Function

    Public Function getNombreCoup() As Integer
        Return NombreDeCoupPossible
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

    Public Function getCoupDefaut() As Integer
        Return NbrCoupDefaut
    End Function

    Public Function getTempsDefaut() As Integer
        Return tempsDefaut
    End Function
End Module
