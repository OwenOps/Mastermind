Public Class FormJeu
    Private Sub FormulaireJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelBravoPerdu_Click(sender As Object, e As EventArgs) Handles LblBravoPerdu.Click

    End Sub

    Private Sub LstCaratereHistorique_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstCaratereHistorique.SelectedIndexChanged

    End Sub

    Private Sub LblNomJoueur_Click(sender As Object, e As EventArgs) Handles LblNomJoueur.Click
        LblNomJoueur.Text = JoueurActuel(1).nom
    End Sub

    Private Sub LblTimer_Click(sender As Object, e As EventArgs) Handles LblTimer.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PnlCaractereJoue_Paint(sender As Object, e As PaintEventArgs) Handles PnlCaractereJoue.Paint

    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click

    End Sub

    Private Sub BtnBye_Click(sender As Object, e As EventArgs) Handles BtnBye.Click
        FormJoueur.Show()
        Me.Hide()
    End Sub

    Private Sub ListeCaractereJouable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeCaractereJouable.SelectedIndexChanged

    End Sub

    Private Sub FormJeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous fermer ?", "Confirmation", MessageBoxButtons.YesNo)
        If ferm = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
