Public Class FormAccueil
    Private Sub FormAccueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Fermer MasterMind", MessageBoxButtons.YesNo)
        If ferm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
