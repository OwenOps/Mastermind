Public Class FormJeu
    Dim erreur As Boolean = False
    Private Sub FormulaireJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelBravoPerdu_Click(sender As Object, e As EventArgs) Handles LblBravoPerdu.Click

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
        If Not erreur Then
            Dim LstCara As String = ""

            'Sans ca, ne met pas dans l'odre les caracteres
            Dim ctrlList As List(Of Control) = PnlCaractereJoue.Controls.Cast(Of Control).OrderBy(Function(c) c.Name).ToList()

            For i As Integer = 0 To ctrlList.Count - 1
                LstCara += "   " & ctrlList(i).Text & "   "
            Next
           
            LstCaratereHistorique.Items.Add(LstCara)
        End If
    End Sub


    Private Sub BtnBye_Click(sender As Object, e As EventArgs) Handles BtnBye.Click
        Me.Hide()
        FormJoueur.Show()
    End Sub


    Private Sub ListeCaractereJouable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeCaractereJouable.SelectedIndexChanged

    End Sub

    Private Sub FormJeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub PnlCaractereJoue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PnlCaractereJoue.KeyPress
        'For Each cara As TextBox In PnlCaractereJoue.Controls
        'If cara Then
        'e.Handled = True
        'End If
        'Next
    End Sub
End Class
