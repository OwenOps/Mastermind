Module ModuleConfig
    Private Const CARA_DEFAUT As String = "ABCDE"
    Private Const NBR_CARA As Integer = 5
    Private Const NBR_COUP_DEFAUT As Integer = 15
    Private Const TEMPS_DEFAUT As Integer = 90
    Private Const DIFFICULTE_DEFAUT As String = "Normal"
    Private Const HARD As String = "Hard"
    Private Const FACILE As String = "Facile"
    Private Const TEMPS_HARD As Integer = 10

    Private CaraJouable() As String = {"A", "B", "C", "D", "E"}
    Private NombreCoupChoisis As Integer = 15
    Private timerActive = True
    Private tempsMax As Integer = TEMPS_DEFAUT
    Private difficultePartie As String = DIFFICULTE_DEFAUT

    Public Function getNombreCoupChoisis() As Integer
        Return NombreCoupChoisis
    End Function

    Public Function getNbrCoupDefaut() As Integer
        Return NBR_COUP_DEFAUT
    End Function

    Public Sub afficheDifficulte(lbl As Label, pnl As Panel)
        If estHard() Then
            lbl.Visible = True
            lbl.Text = HARD
            lbl.ForeColor = Color.Red
            pnl.Show()
        ElseIf estFacile() Then
            lbl.Visible = True
            lbl.Text = FACILE
            lbl.ForeColor = Color.Green
            pnl.Show()
        Else
            pnl.Hide()
            lbl.Visible = False
        End If
    End Sub

    Private Function estHard() As Boolean
        Return difficultePartie = HARD
    End Function

    Private Function estFacile() As Boolean
        Return difficultePartie = FACILE
    End Function

    Public Function getHard() As String
        Return HARD
    End Function

    Public Function getFacile() As String
        Return FACILE
    End Function

    Public Function getNormal() As String
        Return DIFFICULTE_DEFAUT
    End Function

    Public Sub setDifficulte(difficulte As String)
        difficultePartie = difficulte
        ModulePartie.setDifficultePartie(difficulte)

        If estHard() Then
            tempsMax = TEMPS_HARD
        Else
            tempsMax = TEMPS_DEFAUT
        End If
    End Sub

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
        If NombreCoupChoisis <> NBR_COUP_DEFAUT Or timerActive = False Or tempsMax <> TEMPS_DEFAUT Or getCaraJouable() <> CARA_DEFAUT Or difficultePartie <> DIFFICULTE_DEFAUT Then
            Return True
        End If
        Return False
    End Function

    Public Sub resetConfigDefaut()
        NombreCoupChoisis = NBR_COUP_DEFAUT
        tempsMax = TEMPS_DEFAUT
        difficultePartie = DIFFICULTE_DEFAUT
        setCaraJouable(CARA_DEFAUT)
        ModulePartie.setDifficultePartie(DIFFICULTE_DEFAUT)

        timerActive = True
        FormulaireConfig.afficheBtnReset()
        FormulaireConfig.resetFormConfig()

        For Each txt As Button In FormulaireConfig.PnlDifficulte.Controls
            txt.Enabled = True
        Next
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
