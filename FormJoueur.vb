Public Class FormJoueur
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If JoueurActuel(0).nom <> "" Then
        ' cbxNomJoueur1.Items.Add(JoueurActuel(0).nom)
        'For i As Integer = 0 To JoueurActuel.Length - 1
        '    cbxNomJoueur1.Items.Add(JoueurActuel(i).nom)
        'Next
        'For i As Integer = 0 To JoueurActuel.Length - 1
        '    cbxNomJoueur2.Items.Add(JoueurActuel(i).nom)
        'Next
        'End If
    End Sub
    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        If (verifJoueur()) Then
            enregistrerJoueur()
            MsgBox(JoueurActuel(0).nom + JoueurActuel(1).nom)
            'FormJeu.Show()
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Voulez-vous vraiment quitter le jeu ?", vbYesNo, "Fermer MasterMind") Then
            Me.Close()
        End If
        '++++ qd on ferme avec croix
    End Sub
    Private Sub cbxNomJoueur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxNomJoueur1.KeyPress, cbxNomJoueur2.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Sub cbxNomJoueur1_LostFocus(sender As Object, e As EventArgs) Handles cbxNomJoueur1.LostFocus
        sender.Text = StrConv(sender.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub FormJoueur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous fermer ?", "Confirmation", MessageBoxButtons.YesNo)
        If ferm = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class