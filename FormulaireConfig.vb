﻿Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Public Class FormulaireConfig
    Public Sub afficheBtnReset()
        If ModuleConfig.configChange Then
            BtnReset.Enabled = True
        Else
            BtnReset.Enabled = False
        End If
    End Sub

    Private Sub FormulaireConfig_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            resetFormConfig()
        End If
    End Sub

    Public Sub resetFormConfig()
        resetTxt(TxtCaraChange)
        resetTxt(TxtNbrCoup)
        resetTxt(TxtTempsMin)
        resetTxt(TxtTempsSec)
        Me.AcceptButton = btnRetour

        PnlCoupCache.Visible = False
        PnlCaraCache.Visible = False

        If PnlNomCache.Visible = True Then
            PnlNomCache.Visible = False
        End If

        For Each pnl As Panel In PnlRadioBtn.Controls
            For Each rd As RadioButton In pnl.Controls
                rd.Checked = False
            Next
        Next
        BtnNormal.Enabled = False
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles RO1.CheckedChanged, RO2.CheckedChanged, RO3.CheckedChanged, RO4.CheckedChanged, RN1.CheckedChanged, RN2.CheckedChanged, RN3.CheckedChanged, RN4.CheckedChanged
        Dim radioBoutton As RadioButton = TryCast(sender, RadioButton)
        Dim nomRadio = radioBoutton.Name

        Select Case nomRadio
            Case RO1.Name
                PnlTimerCache.Visible = radioBoutton.Checked
                ModuleConfig.setTimerActive(True)
                afficheBtnReset()
            Case RO2.Name
                PnlCoupCache.Visible = radioBoutton.Checked
            Case RO3.Name
                PnlCaraCache.Visible = radioBoutton.Checked
            Case RO4.Name
                If ModuleJoueur.joueurHistoriqueEstVide() And RO4.Checked Then
                    RO4.Checked = False
                    MsgBox("Il n'y a pas encore de joueurs enregistré", vbOKOnly, "Erreur")
                Else
                    ModuleJoueur.chargercbxNomJoueur()
                    PnlNomCache.Visible = radioBoutton.Checked
                End If
            Case RN1.Name
                PnlTimerCache.Visible = False
                ModuleConfig.setTimerActive(False)
                afficheBtnReset()
            Case RN2.Name
                PnlCoupCache.Visible = False
            Case RN3.Name
                PnlCaraCache.Visible = False
            Case RN4.Name
                PnlNomCache.Visible = False
        End Select
    End Sub

    Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNbrCoup.KeyPress, TxtTempsMin.KeyPress, TxtTempsSec.KeyPress
        Dim textBox As TextBoxBase = TryCast(sender, TextBox)
        Dim textActive = textBox.Name

        If e.KeyChar = vbBack Then Exit Sub


        If PnlCoupCache.Visible Or PnlTimerCache.Visible Then
            If textActive = TxtNbrCoup.Name And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            ElseIf (textActive = TxtTempsMin.Name Or textActive = TxtTempsSec.Name) And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Else
            If Not Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValidTimer.Click, BtnValidCara.Click, BtnValidCoup.Click
        Dim btn As Button = TryCast(sender, Button)
        Dim btnActive = btn.Name

        If btnActive = BtnValidCoup.Name Then

            Dim nbrCoup As Integer = 0
            If TxtNbrCoup.Text <> "" And Integer.TryParse(TxtNbrCoup.Text, nbrCoup) AndAlso nbrCoup > 0 Then
                If Not estFacile() And Not estHard() Then
                    ModuleConfig.setNombreCoupChoisis(TxtNbrCoup.Text)
                    ModulePartie.resetTxt(TxtNbrCoup)
                    afficheMiseAJour()
                Else
                    afficheModeActive()
                End If
            Else
                MessageBox.Show("Le nombre de coup doit être supérieur a 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf btnActive = BtnValidCara.Name Then

            Dim nouveauCara = TxtCaraChange.Text
            If nouveauCara.Length = ModuleConfig.getNbrCaraMax Then
                If ModuleConfig.caraDifferent(nouveauCara) Then
                    ModuleConfig.setCaraJouable(nouveauCara)
                    afficheMiseAJour()
                Else
                    MessageBox.Show("Les caractères doivent être différent", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ModulePartie.resetTxt(TxtCaraChange)
            Else
                MessageBox.Show("Le nombre de caractère minimum est de 5", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf btnActive = BtnValidTimer.Name Then
            temps()
        End If
        afficheBtnReset()
    End Sub

    Public Sub afficheMiseAJour()
        MessageBox.Show("Configuration mise à jour.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub afficheModeActive()
        MessageBox.Show("Vous devez être en mode " & ModuleConfig.getNormal & " pour pouvoir changer cette option.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub temps()
        Dim min As Integer
        Dim sec As Integer

        If TxtTempsMin.Text = "" Then
            min = 0
        Else
            min = TxtTempsMin.Text
        End If

        If TxtTempsSec.Text = "" Then
            sec = 0
        Else
            sec = TxtTempsSec.Text
        End If

        Dim tempsMax = min * 60 + sec
        If sec < 0 Or sec > 60 Then
            MsgBox("Le nombre de seconde doit être compris entre 0 et 60", vbOKOnly, "Erreur")
            Exit Sub
        End If

        If min < 0 Or min > 60 Then
            MsgBox("Le nombre de minutes doit être compris entre 0 et 60", vbOKOnly, "Erreur")
            Exit Sub
        End If

        If tempsMax < 5 Then
            MsgBox("Le temps minimum doit être de 5 secondes", vbOKOnly, "Erreur")
            Exit Sub
        End If

        If Not estFacile() And Not estHard() Then
            afficheMiseAJour()
            ModuleConfig.setTempsMax(tempsMax)
            ModulePartie.resetTxt(TxtTempsSec)
            ModulePartie.resetTxt(TxtTempsMin)
        Else
            afficheModeActive()
        End If
    End Sub

    Private Sub BtnValidNom_Click(sender As Object, e As EventArgs) Handles BtnValidNom.Click
        If cbxNomJoueurChange.Text = "" Then
            MsgBox("Veuillez entrer un nom valide.", "Erreur")
            Exit Sub
        End If

        Dim nom = cbxNomJoueurChange.Text
        If ModuleJoueur.getValider = True Then

            If String.Compare(nom, ModuleJoueur.getAncienNomTemp) = 0 Then
                MessageBox.Show("Vous avez rentré le même nom.", "Erreur")
            Else

                ModuleJoueur.changementNomJoueur(ModuleJoueur.getAncienNomTemp, nom)
                ModuleJoueur.setValider(False)
                MessageBox.Show("Votre nouveau ancien nom " & ModuleJoueur.getJoueurSpecifique(nom).ancienNom & " a été remplacé par : " & nom, "Changement réalisé avec succès")
                ModuleJoueur.chargercbxNomJoueur()
                cbxNomJoueurChange.Text = ""
                LblNomActu.Text = LblNomActu.Tag
                BtnValidNom.Text = BtnValidNom.Tag
            End If
            Exit Sub
        End If

        If ModuleJoueur.estContenuDansHistorique(nom) Then
            cbxNomJoueurChange.Text = ""
            LblNomActu.Tag = LblNomActu.Text
            LblNomActu.Text = "Entrez votre nouveau nom :"
            BtnValidNom.Width = 75
            BtnValidNom.Tag = BtnValidNom.Text
            BtnValidNom.Text = "Renommer"

            ModuleJoueur.setValider(True)
            ModuleJoueur.setAncienNomJoueur(nom)
            ModuleJoueur.setAncienNomTemp(nom)
        Else
            MessageBox.Show("La personne n'existe pas", "Erreur")
        End If
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormMasterMind.Show()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        If ModuleConfig.configChange Then
            ModuleConfig.resetConfigDefaut()
        End If
        MessageBox.Show("Configuration remise par défaut", "Informations")
    End Sub

    Private Sub BtnDifficulte_Click(sender As Object, e As EventArgs) Handles BtnFacile.Click, BtnNormal.Click, BtnHard.Click
        Dim btn As Button = TryCast(sender, Button)
        Dim nomBtn = btn.Name

        Select Case nomBtn
            Case BtnFacile.Name
                ModuleConfig.setDifficulte(ModuleConfig.getFacile)
            Case BtnNormal.Name
                ModuleConfig.setDifficulte(ModuleConfig.getNormal)
            Case BtnHard.Name
                ModuleConfig.setDifficulte(ModuleConfig.getHard)
        End Select

        For Each btnA As Button In PnlDifficulte.Controls
            If btnA.Name = nomBtn Then
                btn.Enabled = False
            Else
                btnA.Enabled = True
            End If
        Next
        afficheBtnReset()
    End Sub

    Private Sub BtnFichier_Click(sender As Object, e As EventArgs) Handles BtnFichier.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim nouveauChemin As String = folderBrowserDialog.SelectedPath

            ModuleJoueur.setCheminFichier(nouveauChemin)

            MessageBox.Show("Un fichier de sauvegarde sera présent ici : " & nouveauChemin & MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FormConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FormulaireConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class