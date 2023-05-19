Public Class FormMasterMind
    Private Sub FormMasterMind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnStart
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        FormAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        FormulaireConfig.Show()
        Me.Hide()
    End Sub
    Private Sub btnRegles_Click(sender As Object, e As EventArgs) Handles btnRegles.Click
        Me.Hide()
        'FormRegles.Show()
    End Sub

    Private Sub FormAccueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Fermer MasterMind", MessageBoxButtons.YesNo)
        If ferm = DialogResult.Yes Then
            ArchiverJoueurDansFichier()
            Application.Exit()
        End If
    End Sub

End Class