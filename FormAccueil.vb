Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleJoueur.chargercbxNomJoueur()
        Me.AcceptButton = btnJouer

        cbxNomJoueur1.AutoCompleteMode = AutoCompleteMode.Append
        cbxNomJoueur1.AutoCompleteSource = AutoCompleteSource.ListItems
        cbxNomJoueur2.AutoCompleteMode = AutoCompleteMode.Append
        cbxNomJoueur2.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub FormAccueil_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ModuleJoueur.changeJoueur1ToJoueur2()
        End If
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

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        If (joueurHistoriqueEstVide()) Then
            MsgBox("Aucune statistique n'est disponible, commencez d'abord à jouer! ", , "Erreur")
        Else
            Me.Hide()
            FormStat.resetFormStats()
            FormStat.Show()
        End If
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormMasterMind.Show()
    End Sub

    Private Sub FormAccueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class