﻿Imports System.IO

Module ModuleJoueur
    Private Const NBR_MAX_JOUEUR = 2
    Private ancienNom As String = ""
    Private valid As Boolean = False
    Structure Joueur
        Dim nom As String
        Dim score As Integer
        Dim meilleurTemps As Integer
        Dim nbrPartiesPremierJoueur As Integer
        Dim nbrPartiesSecondJoueur As Integer
        Dim cumulTemps As Integer
        Dim estPremierJoueur As Boolean
        Dim ancienNom As String
    End Structure

    Private JoueurActuel(NBR_MAX_JOUEUR - 1) As Joueur
    Private JoueurHistorique(NBR_MAX_JOUEUR - 1) As Joueur
    Dim estPremiereFois As Boolean = True
    Dim estPremiereChargement As Boolean = True
    Dim nbJoueurHistorique As Integer
    Dim cheminFichier As String
    Public Sub enregistrerJoueur()
        resetJoueurActuel()
        JoueurActuel(0).nom = FormAccueil.cbxNomJoueur1.Text
        JoueurActuel(0).estPremierJoueur = True

        JoueurActuel(1).nom = FormAccueil.cbxNomJoueur2.Text
        JoueurActuel(1).estPremierJoueur = False

        For i As Integer = 0 To JoueurActuel.Length - 1
            JoueurActuel(i).score = 0
            JoueurActuel(i).meilleurTemps = 0
            JoueurActuel(i).cumulTemps = 0
            JoueurActuel(i).ancienNom = ""
            If (JoueurActuel(i).estPremierJoueur) Then
                JoueurActuel(i).nbrPartiesPremierJoueur += 1
            Else
                JoueurActuel(i).nbrPartiesSecondJoueur += 1
            End If


        Next
        ajouterJoueurDansHisto()
        chargercbxNomJoueur()
    End Sub

    Public Sub changeJoueur1ToJoueur2()
        FormAccueil.cbxNomJoueur1.Text = JoueurActuel(1).nom
        FormAccueil.cbxNomJoueur2.Text = JoueurActuel(0).nom
    End Sub

    Public Sub resetJoueurActuel()
        Array.Clear(JoueurActuel, 0, JoueurActuel.Length)
    End Sub

    Public Sub ajouterJoueurDansHisto()
        For j As Integer = 0 To JoueurActuel.Length - 1
            If estContenuDansHistorique(JoueurActuel(j).nom) = False Then
                If Not estPremiereFois Then
                    ReDim Preserve JoueurHistorique(JoueurHistorique.Length)
                    JoueurHistorique(JoueurHistorique.Length - 1) = JoueurActuel(j)
                Else
                    Array.Copy(JoueurActuel, JoueurHistorique, JoueurActuel.Length)
                    estPremiereFois = False
                End If
            End If
        Next
    End Sub
    Public Sub ajouterStats(joueur As Joueur)
        joueur.score += 1
        joueur.cumulTemps += FormPartie.getTimer()

    End Sub

    Public Sub sauvegarderDansHisto()
        For i As Integer = 0 To JoueurHistorique.Length - 1
            If JoueurHistorique(i).nom = JoueurActuel(0).nom Then
                JoueurHistorique(i).score += JoueurActuel(0).score
                JoueurHistorique(i).cumulTemps += JoueurActuel(0).cumulTemps
                If JoueurActuel(0).meilleurTemps > JoueurHistorique(i).meilleurTemps Then
                    JoueurHistorique(i).meilleurTemps = JoueurActuel(0).meilleurTemps
                End If
            End If
        Next

    End Sub

    Public Sub chargercbxNomJoueur()
        If Not joueurHistoriqueEstVide() Then
            FormAccueil.cbxNomJoueur1.Items.Clear()
            FormAccueil.cbxNomJoueur2.Items.Clear()
            For i As Integer = 0 To JoueurHistorique.Length - 1
                FormAccueil.cbxNomJoueur1.Items.Add(JoueurHistorique(i).nom)
                FormAccueil.cbxNomJoueur2.Items.Add(JoueurHistorique(i).nom)
            Next

            FormulaireConfig.cbxNomJoueurChange.Items.Clear()
            For i As Integer = 0 To JoueurHistorique.Length - 1
                FormulaireConfig.cbxNomJoueurChange.Items.Add(JoueurHistorique(i).nom)
            Next

        End If
    End Sub

    Public Sub chargerFichierDansHistorique()
        If Not estPremiereChargement = True Then
            Dim num As Integer = FreeFile()
            FileOpen(num, "..\..\InfosJoueur.txt", OpenMode.Input)
            nbJoueurHistorique = LineInput(num)
            ReDim Preserve JoueurHistorique(nbJoueurHistorique - 1)
            Do Until EOF(num)
                For i As Integer = 0 To nbJoueurHistorique - 1
                    JoueurHistorique(i).nom = LineInput(num)
                    JoueurHistorique(i).score = LineInput(num)
                    JoueurHistorique(i).meilleurTemps = LineInput(num)
                    JoueurHistorique(i).nbrPartiesPremierJoueur = LineInput(num)
                    JoueurHistorique(i).nbrPartiesSecondJoueur = LineInput(num)
                    JoueurHistorique(i).cumulTemps = LineInput(num)
                Next
            Loop
            FileClose(num)
        End If
    End Sub

    Public Sub ArchiverJoueurDansFichier()
        Dim num As Integer = FreeFile()
        FileOpen(num, "..\..\InfosJoueur.txt", OpenMode.Output)
        PrintLine(num, JoueurHistorique.Length)
        For i As Integer = 0 To JoueurHistorique.Length - 1
            PrintLine(num, JoueurHistorique(i).nom)
            PrintLine(num, JoueurHistorique(i).score)
            PrintLine(num, JoueurHistorique(i).meilleurTemps)
            PrintLine(num, JoueurHistorique(i).nbrPartiesPremierJoueur)
            PrintLine(num, JoueurHistorique(i).nbrPartiesSecondJoueur)
            PrintLine(num, JoueurHistorique(i).cumulTemps)
        Next
        FileClose(num)
    End Sub

    Public Sub resetFormAccueil()
        FormAccueil.cbxNomJoueur1.Text = ""
        FormAccueil.cbxNomJoueur2.Text = ""
    End Sub

    Public Function verifJoueur() As Boolean
        If FormAccueil.cbxNomJoueur1.Text = "" Or FormAccueil.cbxNomJoueur2.Text = "" Then
            MsgBox("Veuillez entrer un nom pour chaque joueur", vbOKOnly, "Erreur")
            Return False
        End If

        If FormAccueil.cbxNomJoueur1.Text = FormAccueil.cbxNomJoueur2.Text Then
            MsgBox("Veuillez entrer un nom différent pour chaque joueur", vbOKOnly, "Erreur")
            Return False
        End If
        Return True
    End Function

    Public Function estContenuDansHistorique(nom As String) As Boolean
        For i As Integer = 0 To JoueurHistorique.Length - 1
            If JoueurHistorique(i).nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function joueurHistoriqueEstVide() As Boolean
        If JoueurHistorique(0).nom = Nothing Then
            Return True
        End If
        Return False
    End Function

    Public Sub changementNomJoueur(nouveauNom As String)
        For i As Integer = 0 To JoueurHistorique.Length - 1
            If JoueurHistorique(i).nom = ancienNom Then
                JoueurHistorique(i).ancienNom = ancienNom
                JoueurHistorique(i).nom = nouveauNom
                Exit Sub
            End If
        Next
    End Sub


    Public Function getPremierJoueur() As Joueur
        Return JoueurActuel(0)
    End Function

    Public Function getDeuxiemeJoueur() As Joueur
        Return JoueurActuel(1)
    End Function

    Public Function getNombreJoueur() As Integer
        Return NBR_MAX_JOUEUR
    End Function

    Public Function getNomDesJoueurs() As String
        Return getPremierJoueur().nom + ", " + getDeuxiemeJoueur().nom
    End Function

    Public Function getValid() As Boolean
        Return valid
    End Function

    Public Sub setAncienNom(nouveauNom As String)
        ancienNom = nouveauNom
    End Sub

    Public Function getAncienNom() As String
        Return ancienNom
    End Function

    Public Sub setValid()
        valid = True
    End Sub


End Module