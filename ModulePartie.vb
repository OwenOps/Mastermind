Module ModulePartie
    Private CaraATrouver(ModuleConfig.getNbrCaraMax) As String
    Private tempsPartie As Integer
    Private nombreCoupPossible = ModuleConfig.getNombreCoupChoisis
    Private nomJoueur As String
    Private modeEntrainement As Boolean = False
    Private difficulte As String
    Private Const COUP_HARD = 5
    Private Const COUP_FACILE = 20

    Public Sub setModeEntrainement(bool As Boolean, nom As String)
        modeEntrainement = bool
        nomJoueur = nom
    End Sub

    Public Sub setPartie()
        If estHard() Then
            nombreCoupPossible = COUP_HARD
        ElseIf estFacile Then
            nombreCoupPossible = COUP_FACILE
        Else
            nombreCoupPossible = ModuleConfig.getNombreCoupChoisis
        End If
    End Sub

    Public Function estFacile() As Boolean
        Return difficulte = ModuleConfig.getFacile
    End Function

    Public Function estHard() As Boolean
        Return difficulte = ModuleConfig.getHard
    End Function

    Public Sub setDifficultePartie(diff As String)
        difficulte = diff
    End Sub

    Public Function getDifficultePartie() As String
        Return difficulte
    End Function

    Public Function getModeEntrainement() As Boolean
        Return modeEntrainement
    End Function

    Public Sub setCaraATrouver(cara() As Char)
        For i As Integer = 0 To ModuleConfig.getNbrCaraMax - 1
            CaraATrouver(i) = cara(i)
        Next
    End Sub

    Public Sub enleveNombreCoup()
        nombreCoupPossible -= 1
    End Sub

    Public Sub setCaraAleatoire()
        Dim rand As New Random()
        Dim nombreUnique As New HashSet(Of Integer)()

        While nombreUnique.Count < ModuleConfig.getNbrCaraMax
            Dim nbr As Integer = rand.Next(0, 5)

            If Not nombreUnique.Contains(nbr) Then
                nombreUnique.Add(nbr)
            End If
        End While

        Dim cara(ModuleConfig.getNbrCaraMax) As Char
        For i As Integer = 0 To nombreUnique.Count - 1
            cara(i) = ModuleConfig.getCaraJouable.ToArray(nombreUnique(i))
        Next
        FormCaractere.caraDansTxtBox(cara)
    End Sub

    Public Function getTempsPartie() As Integer
        Return tempsPartie
    End Function

    Public Sub setNombreCoup(nbr As Integer)
        nombreCoupPossible = nbr
    End Sub

    Public Function getNombreCoup() As Integer
        Return nombreCoupPossible
    End Function

    Public Sub setTempsPartie(nbr As Integer)
        tempsPartie = nbr
    End Sub

    Public Function getCaraATrouver() As String
        Dim caractere As String = ""
        For Each cara In CaraATrouver
            caractere += cara
        Next
        Return caractere
    End Function

    Public Sub resetTxt(nom As TextBox)
        nom.Text = ""
    End Sub

    Public Sub afficheCaraJouable(label As Label)
        Dim caraChaine As String = ""
        For Each cara In ModuleConfig.getCaraJouable.ToArray
            caraChaine += "  " & cara & "  "
        Next
        label.Text = caraChaine
    End Sub

    Public Function timerFinis() As Boolean
        If ModulePartie.getTempsPartie = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function ToutValide() As Boolean
        For Each txtBox As TextBox In FormJeu.PnlCaractereJoue.Controls
            If (txtBox.BackColor <> Color.Green) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function CaseVide() As Boolean
        For Each txtBox As TextBox In FormJeu.PnlCaractereJoue.Controls
            If (txtBox.Text.Length = 0) Then
                MsgBox("Veuillez remplir toute les cases.", vbOKOnly, "Erreur")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function getNomJoueur() As String
        Return nomJoueur
    End Function

    Public Sub AfficheLabelTimer(tempsMax As Integer, lblTimer As Label)
        Dim ts As Integer = 0, h = 0, m = 0, s = 0
        ts = tempsMax
        h = Math.Floor(ts / 3600)
        m = Math.Floor((ts / 60) - 60 * h)
        s = Math.Floor(ts - 3600 * h - 60 * m)

        If tempsMax >= 3600 Then
            lblTimer.Text = h & " h : " & m & " min : " & s & " sec"
        ElseIf tempsMax >= 60 Then
            lblTimer.Text = m & " min : " & s & " sec"
        Else
            lblTimer.Text = s & " sec"
        End If
    End Sub
End Module
