Public Class FormJeu
    Dim test() As Char = {"a", "z", "e", "r", "t"}
    Dim NbrCoup As Integer = 15
    Dim timerTest As Integer = 0
    Private Sub FormulaireJeu_Load() Handles MyBase.Load
        If (ListeCaractereJouable.Items.Count = 0) Then
            Dim te As String = ""
            For Each t In test
                te += "  " & t & "  "
            Next
            ListeCaractereJouable.Items.Add(te)
        End If

        'Pour trie dans ordre, sans ca probleme
        Dim ctrlList As List(Of Control) = PnlCaractereJoue.Controls.Cast(Of Control).OrderBy(Function(c) c.TabIndex).ToList()

        For i As Integer = 0 To ctrlList.Count - 1
            PnlCaractereJoue.Controls.SetChildIndex(ctrlList(i), i)
        Next


        Me.Text = "Il vous reste " & NbrCoup.ToString & " coup(s)..."
    End Sub

    Private Sub LabelBravoPerdu_Click(sender As Object, e As EventArgs) Handles LblBravoPerdu.Click
        If (NbrCoup = 0 Or timerTest = 90) Then
            LblBravoPerdu.Text = "Perdu"
        Else
            LblBravoPerdu.Text = "Gagné"
        End If
        LblBravoPerdu.Show()
    End Sub

    Private Sub LblNomJoueur_Click(sender As Object, e As EventArgs) Handles LblNomJoueur.Click
        LblNomJoueur.Text = JoueurActuel(1).nom
    End Sub

    Private Sub LblTimer_Click(sender As Object, e As EventArgs) Handles LblTimer.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        If Not CaseVide() Then
            Dim LstCara As String = ""

            For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
                LstCara += PnlCaractereJoue.Controls(i).Text
            Next

            For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
                For j As Integer = 0 To test.Length - 1
                    If (PnlCaractereJoue.Controls(i).Text = test(j) And i = j) Then 'Si bon et bien place
                        LstCara = LstCara.Remove(i, 1).Insert(i, "B")
                        PnlCaractereJoue.Controls(i).BackColor = Color.Green

                    ElseIf (PnlCaractereJoue.Controls(i).Text = test(j)) Then 'Si present
                        LstCara = LstCara.Replace(PnlCaractereJoue.Controls(i).Text, "P")
                        PnlCaractereJoue.Controls(i).BackColor = Color.Blue

                    ElseIf Not test.Contains(PnlCaractereJoue.Controls(i).Text) Then 'Si caractere n'est pas present
                        LstCara = LstCara.Replace(PnlCaractereJoue.Controls(i).Text, "F")
                        PnlCaractereJoue.Controls(i).BackColor = Color.Red

                    End If
                    PnlCaractereJoue.Controls(i).ForeColor = Color.White
                Next
            Next

            'Essayer d'enlever pour optimiser
            Dim newLst As String = ""
            For Each st In LstCara
                newLst += "   " & st & "   "
            Next

            LstCaratereHistorique.Items.Add(newLst)

            'Reset
            For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
                PnlCaractereJoue.Controls(i).Text = ""
            Next

            NbrCoup = NbrCoup - 1
            Me.Text = "Il vous reste " & NbrCoup.ToString & " coup(s)..."
        End If
    End Sub


    Private Sub BtnBye_Click(sender As Object, e As EventArgs) Handles BtnBye.Click
        Me.Hide()
        FormJoueur.Show()
    End Sub

    Private Sub FormJeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class
