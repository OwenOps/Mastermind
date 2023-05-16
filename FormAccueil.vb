﻿Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargerFichierDansHistorique()
        chargercbxNomJoueur()

        cbxNomJoueur1.AutoCompleteMode = AutoCompleteMode.Append
        cbxNomJoueur1.AutoCompleteSource = AutoCompleteSource.ListItems

        cbxNomJoueur2.AutoCompleteMode = AutoCompleteMode.Append
        cbxNomJoueur2.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If (verifJoueur()) Then
            'ArchiverJoueurDansFichier()
            enregistrerJoueur()
            Me.Hide()
            FormCaractere.Show()
        End If
    End Sub

    Private Sub cbxNomJoueur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxNomJoueur1.KeyPress, cbxNomJoueur2.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub cbxNomJoueur1_LostFocus(sender As Object, e As EventArgs) Handles cbxNomJoueur1.LostFocus
        'sender.Text = StrConv(sender.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click

        'Me.Hide()
        Me.Close()
        'FormMasterMind.Close()
        'Application.Exit()
    End Sub

End Class