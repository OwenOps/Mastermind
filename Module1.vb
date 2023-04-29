Module Module1
    Structure Joueur
        Dim nom As String
        Dim score As Integer
        Dim meilleurTemps As Integer
        Dim nbrPartiesPremierJoueur As Integer
        Dim nbrPartiesSecondJoueur As Integer
        Dim cumulTemps As Integer
        Dim estPremierJoueur As Boolean
    End Structure

    Public JoueurActuel(2) As Joueur

    Function enregistrerJoueur()

        JoueurActuel(0).nom = FormJoueur.cbxNomJoueur1.Text
        JoueurActuel(0).estPremierJoueur = True

        JoueurActuel(1).nom = FormJoueur.cbxNomJoueur2.Text
        JoueurActuel(0).estPremierJoueur = False

        For i As Integer = 0 To JoueurActuel.Length - 1
            JoueurActuel(i).score = 0
            JoueurActuel(i).meilleurTemps = 0
            If (JoueurActuel(i).estPremierJoueur) Then
                JoueurActuel(i).nbrPartiesPremierJoueur += 1
            Else
                JoueurActuel(i).nbrPartiesSecondJoueur += 1
            End If
            JoueurActuel(i).cumulTemps = 0
        Next

        Return Nothing
    End Function

    Function verifJoueur() As Boolean

        If FormJoueur.cbxNomJoueur1.Text = "" Or FormJoueur.cbxNomJoueur2.Text = "" Then
            MsgBox("Veuillez entrer un nom pour chaque joueur", vbOKOnly, "Erreur")
            Return False
        End If

        If FormJoueur.cbxNomJoueur1.Text = FormJoueur.cbxNomJoueur2.Text Then
            MsgBox("Veuillez entrer un nom différent pour chaque joueur", vbOKOnly, "Erreur")
            Return False
        End If

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
