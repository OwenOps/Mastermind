Module ModulePartie
    Private tps As Integer = 0
    Private CaraATrouver(NBR_CARA) As String
    Private CaraRestant As String
    Private Const NBR_CARA As Integer = 5
    Private tempsMax As Integer = 10

    Public Sub setCaraATrouver(cara() As Char)
        For i As Integer = 0 To NBR_CARA - 1
            CaraATrouver(i) = cara(i)
        Next
        CaraRestant = getCaraATrouver()
    End Sub

    Public Sub setCaraAleatoire()
        Dim rand As New Random()
        Dim nombreUnique As New HashSet(Of Integer)()

        While nombreUnique.Count < NBR_CARA
            Dim nbr As Integer = rand.Next(0, 5)

            If Not nombreUnique.Contains(nbr) Then
                nombreUnique.Add(nbr)
            End If
        End While

        Dim cara(NBR_CARA) As Char
        For i As Integer = 0 To nombreUnique.Count - 1
            cara(i) = ModuleConfig.getCaraJouable.ToArray(nombreUnique(i))
        Next
        FormCaractere.caraDansTxtBox(cara)
    End Sub

    Public Sub removeCara(indice As Char)
        Dim index = CaraRestant.IndexOf(indice)
        If index <> -1 Then
            CaraRestant = CaraRestant.Remove(index, 1)
        End If
    End Sub

    Public Function getCaraRestant() As String
        Return CaraRestant
    End Function

    Public Function getTempsMax() As Integer
        Return tempsMax
    End Function

    Public Sub setTempsMax(nbr As Integer)
        tempsMax = nbr
    End Sub

    Public Function getCaraATrouver() As String
        Dim caractere As String = ""
        For Each cara In CaraATrouver
            caractere += cara
        Next
        Return caractere
    End Function

    Public Sub lancementTimer()

    End Sub

    Public Function getTimer() As Integer
        Return tps
    End Function

    Public Sub resetTxt(nom As TextBox)
        nom.Text = ""
    End Sub

    Public Function timerFinis() As Boolean
        If tempsMax = 0 Then
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
End Module
