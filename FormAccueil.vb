Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If ModuleJoueur.getPremierJoueur <> "" Then
        ' cbxNomJoueur1.Items.Add(ModuleJoueur.getPremierJoueur)
        'cbxNomJoueur1.Items.Add(getNomDesJoueurs)
        'cbxNomJoueur2.Items.Add(getNomDesJoueurs)
        'End If
    End Sub
    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If (verifJoueur()) Then
            enregistrerJoueur()
            'MsgBox(ModuleJoueur.getPremierJoueur + ", " + ModuleJoueur.getDeuxiemeJoueur)
            MsgBox(getNomDesJoueurs)
            'FormJeu.Show()
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
        FormulaireConfig.Show()
    End Sub

    Private Sub FormJoueur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class