Module ModulePartie
    Private tps As Integer = 0
    Private CaraATrouver(NBR_CARA) As String
    Private CaraRestant As String
    Private Const NBR_CARA As Integer = 5
    Private tempsMax As Integer = 90

    Sub setCaraATrouver(cara() As Char)
        For i As Integer = 0 To NBR_CARA - 1
            CaraATrouver(i) = cara(i)
        Next
        CaraRestant = getCaraATrouver()
    End Sub

    Sub removeCara(indice As Char)
        Dim index = CaraRestant.IndexOf(indice)
        Console.WriteLine(index)
        If index <> -1 Then
            CaraRestant = CaraRestant.Remove(index, 1)
            Console.WriteLine(CaraRestant)
        End If
    End Sub

    Function getCaraRestant() As String
        Return CaraRestant
    End Function

    Function getTempsMax() As Integer
        Return tempsMax
    End Function

    Sub setTempsMax(nbr As Integer)
        tempsMax = nbr
    End Sub

    Function getCaraATrouver() As String
        Dim caractere As String = ""
        For Each cara In CaraATrouver
            caractere += cara
        Next
        Return caractere
    End Function

    Sub lancementTimer()

    End Sub

    Function getTimer() As Integer
        Return tps
    End Function

    Sub resetTxt(nom As TextBox)
        nom.Text = ""
    End Sub

    Function timerFinis() As Boolean
        If tps = tempsMax Then
            Return True
        End If
        Return False
    End Function

    Function ToutValide() As Boolean
        For Each txtBox As TextBox In FormJeu.PnlCaractereJoue.Controls
            If (txtBox.BackColor <> Color.Green) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function CaseVide() As Boolean
        For Each txtBox As TextBox In FormJeu.PnlCaractereJoue.Controls
            If (txtBox.Text.Length = 0) Then
                MsgBox("Veuillez remplir toute les cases.", vbOKOnly, "Erreur")
                Return True
            End If
        Next
        Return False
    End Function
End Module
