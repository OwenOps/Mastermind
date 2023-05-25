Module ModuleStat
    Private Const NBR_JOUEUR_PODIUM = 2
    Private Const MAX_TEMPS = 100000
    Private joueurs As Joueur()
    Private joueursCopy As Joueur()
    Private podium(NBR_JOUEUR_PODIUM) As Joueur

    Function getJoueurs() As Joueur()
        Return joueurs
    End Function

    Public Function getMaxTemps() As Integer
        Return MAX_TEMPS
    End Function

    Public Function getPodium() As Joueur()
        Return podium
    End Function

    Public Sub remplirPodiumScore()
        joueurs = ModuleJoueur.getJoueurHistorique()
        Dim temp As Joueur
        joueursCopy = joueurs.Clone
        For i As Integer = 0 To podium.Length - 1
            temp.score = -1
            temp.nom = "Personne"
            For j As Integer = 0 To joueursCopy.Length - 1
                If joueursCopy(j).score > temp.score And joueursCopy(j).score <> 0 Then
                    temp = joueursCopy(j)
                End If
            Next
            podium(i) = temp
            supprimerJoueur(temp)
        Next
    End Sub

    Public Sub remplirPodiumTemps()
        joueurs = ModuleJoueur.getJoueurHistorique()
        Dim temp As Joueur
        joueursCopy = joueurs.Clone
        For i As Integer = 0 To podium.Length - 1
            temp.meilleurTemps = 100000
            temp.nom = "Personne"
            For j As Integer = 0 To joueursCopy.Length - 1
                If joueursCopy(j).meilleurTemps < temp.meilleurTemps And joueursCopy(j).meilleurTemps <> 0 Then
                    temp = joueursCopy(j)
                End If
            Next
            podium(i) = temp
            supprimerJoueur(temp)
        Next
    End Sub

    Public Sub supprimerJoueur(Joueurs As Joueur)
        For j As Integer = 0 To joueursCopy.Length - 1
            If joueursCopy(j).nom = Joueurs.nom Then
                joueursCopy(j).score = -1
                joueursCopy(j).meilleurTemps = 100000
            End If
        Next
    End Sub

    Public Function afficherTemps(temps As Integer) As String
        Dim tempsAffichage As String
        Dim ts As Integer = 0, h = 0, m = 0, s = 0
        ts = temps
        h = ts / 3600
        m = Math.Floor((ts / 60) - 60 * h)
        s = ts - 3600 * h - 60 * m

        If temps >= 3600 Then
            tempsAffichage = h & " h : " & m & " min : " & s & " sec"
        ElseIf temps >= 60 Then
            tempsAffichage = m & " min : " & s & " sec"
        Else
            tempsAffichage = s & " sec"
        End If
        Return tempsAffichage
    End Function
End Module
