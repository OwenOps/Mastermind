Public Class FormJeu
    'Toutes les petites fonctions utilises sont en bas
    Private Sub FormulaireJeu_Load() Handles MyBase.Load
        Dim caraChaine As String = ""
        For Each cara In ModuleConfig.getCaraJouable.ToArray
            caraChaine += "  " & cara & "  "
        Next
        CaraJouable.Text = caraChaine

        'Pour trie dans ordre la liste des txtBox, sans ca probleme
        Dim ctrlList As List(Of Control) = PnlCaractereJoue.Controls.Cast(Of Control).OrderBy(Function(c) c.TabIndex).ToList()

        For i As Integer = 0 To ctrlList.Count - 1
            PnlCaractereJoue.Controls.SetChildIndex(ctrlList(i), i)
        Next

        nombreCoup()
        LblNomJoueur.Text = getDeuxiemeJoueur()
    End Sub

    Private Sub LblBravoPerdu_Click()
        Dim BravoPerdu As Boolean = False
        If ToutValide() Then
            BravoPerdu = True
        ElseIf getNombreCoup() > 0 Then
            Exit Sub
        End If

        gagnePerdu(BravoPerdu)
        partieFinis()
    End Sub

    Private Sub LblTimer_Click(sender As Object, e As EventArgs) Handles LblTimer.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        If Not CaseVide() Then
            Console.WriteLine(ModulePartie.getCaraATrouver)
            For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
                For j As Integer = 0 To ModulePartie.getCaraATrouver.ToArray.Length - 1
                    If (PnlCaractereJoue.Controls(i).Text = ModulePartie.getCaraATrouver.ToArray(j) And i = j) Then 'Si bon et bien place
                        PnlCaractereJoue.Controls(i).BackColor = Color.Green
                        Exit For

                    ElseIf (PnlCaractereJoue.Controls(i).Text = ModulePartie.getCaraATrouver.ToArray(j)) Then 'Si present
                        PnlCaractereJoue.Controls(i).BackColor = Color.Blue

                    ElseIf Not ModulePartie.getCaraATrouver.ToArray.Contains(PnlCaractereJoue.Controls(i).Text) Then 'Si caractere n'est pas present
                        PnlCaractereJoue.Controls(i).BackColor = Color.Red

                    End If
                Next
                PnlCaractereJoue.Controls(i).ForeColor = Color.White
            Next

            Dim LstCara As String = ""
            For Each cara As TextBox In PnlCaractereJoue.Controls
                LstCara += "   " & cara.Text & "   "
            Next
            LstCaratereHistorique.Items.Add(LstCara)

            resetTxtBox()
            ModuleConfig.enleveNombreCoup()
            nombreCoup()
            LblBravoPerdu_Click()
        End If
    End Sub

    Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt1.KeyPress, Txt2.KeyPress, Txt3.KeyPress, Txt4.KeyPress, Txt5.KeyPress
        Dim textBox As TextBox = CType(sender, TextBox)
        If Char.IsLetter(e.KeyChar) Then
            Dim entree As String = e.KeyChar.ToString()
            If ModuleConfig.getCaraJouable.ToArray.Contains(entree) Then
                If textBox.Text.Length > 0 Then
                    e.Handled = True
                End If
            Else
                e.Handled = True

            End If
        ElseIf Char.IsControl(e.KeyChar) Then
        Else
            e.Handled = True
        End If
    End Sub

    Sub gagnePerdu(bravoPerdu As Boolean)
        If bravoPerdu Then
            LblBravoPerdu.Text = "Gagné !!"
            LblBravoPerdu.Left += 12
            LblBravoPerdu.ForeColor = Color.Green
        Else
            LblBravoPerdu.Text = "Perdu, Peut-être la prochaine fois"
            LblBravoPerdu.Left -= 75
            LblBravoPerdu.ForeColor = Color.Red
        End If
    End Sub

    Sub partieFinis()
        BtnGuess.Hide()
        LblBravoPerdu.Show()
    End Sub

    Sub resetTxtBox()
        For Each txt As TextBox In PnlCaractereJoue.Controls
            ModulePartie.resetTxt(txt)
        Next
    End Sub

    Private Sub BtnBye_Click(sender As Object, e As EventArgs) Handles BtnBye.Click
        Me.Hide()
        FormAccueil.Show()
    End Sub

    Sub nombreCoup()
        Me.Text = "Il vous reste " & ModuleConfig.getNombreCoup.ToString & " coup(s)..."
    End Sub

    Private Sub FormJeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class
