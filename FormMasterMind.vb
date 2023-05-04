Public Class FormMasterMind
    Private Sub FormAccueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Fermer MasterMind", MessageBoxButtons.YesNo)
        If ferm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        FormAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click

    End Sub
End Class
