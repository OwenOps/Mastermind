Public Class FormJeu
    Private Sub FormJeu_Load() Handles MyBase.Load
        'Pour trie dans ordre la liste des txtBox, sans ca probleme
        Dim ctrlList As List(Of Control) = PnlCaractereJoue.Controls.Cast(Of Control).OrderBy(Function(c) c.TabIndex).ToList()

        For i As Integer = 0 To ctrlList.Count - 1
            PnlCaractereJoue.Controls.SetChildIndex(ctrlList(i), i)
        Next
    End Sub

    Private Sub FormJeu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ModulePartie.setPartie()
            LstCaraHisto.TabStop = False
            Me.AcceptButton = BtnGuess
            BtnAbandonner.Enabled = True
            resetDesign()

            If (ModulePartie.getModeEntrainement()) Then
                LblNomJoueur.Text = ModulePartie.getNomJoueur()
            Else
                LblNomJoueur.Text = ModuleJoueur.getDeuxiemeJoueur().nom
            End If

            If ModuleConfig.timerEstActive Or ModulePartie.estFacile Or ModulePartie.estHard Then
                TimerJeu.Start()
                gestionTimerLabel()
            Else
                TimerJeu.Stop()
                LblTimerReste.Text = "Timer Désactivé."
                LblTimer.Hide()
                ProgressBarJeu.Value = ProgressBarJeu.Minimum
            End If

            PnlCaractereJoue.Enabled = True
        End If
    End Sub

    Private Sub resetDesign()
        If LblBravoPerdu.ForeColor = Color.Green Then
            LblBravoPerdu.Left -= 12
        ElseIf LblBravoPerdu.ForeColor = Color.Red Then
            LblBravoPerdu.Left += 4
        End If

        LblBravoPerdu.Hide()
        LstCaraHisto.Clear()
        BtnGuess.Show()
        lblBonneChance.Show()
        LblNomJoueur.Show()
        btnExit.Hide()

        ModuleConfig.afficheDifficulte(LblDifficulte, PnlDiff)
        afficheCaraJouable(LblCaraJouable)
        nombreCoup()

        For Each txt As TextBox In PnlCaractereJoue.Controls
            resetTxt(txt)
            txt.BackColor = Color.White
            txt.ForeColor = Color.Black
        Next
    End Sub

    Private Sub LblBravoPerdu_Click()
        Dim BravoPerdu As Boolean = False

        If ToutValide() Then
            BravoPerdu = True
        ElseIf ModulePartie.getNombreCoup() > 0 Then
            Exit Sub
        End If

        gagnePerdu(BravoPerdu)
        partieFinis()
    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        If Not CaseVide() Then
            Dim cara As Char = ""

            For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
                cara = PnlCaractereJoue.Controls(i).Text

                If bienPlace(cara, i) Then
                    PnlCaractereJoue.Controls(i).BackColor = Color.Green
                    LstCaraHisto.SelectionColor = Color.Green

                ElseIf malPlace(cara) Then
                    PnlCaractereJoue.Controls(i).BackColor = Color.Blue
                    LstCaraHisto.SelectionColor = Color.Blue
                Else
                    PnlCaractereJoue.Controls(i).BackColor = Color.Red
                    LstCaraHisto.SelectionColor = Color.Red
                End If

                LstCaraHisto.AppendText("   " + cara + "   ")
                PnlCaractereJoue.Controls(i).ForeColor = Color.White
            Next

            LstCaraHisto.AppendText(vbCrLf)
            For Each txt As TextBox In PnlCaractereJoue.Controls

                If ModulePartie.estFacile Then
                    If txt.BackColor <> Color.Green Then
                        ModulePartie.resetTxt(txt)
                    End If
                Else
                    ModulePartie.resetTxt(txt)
                End If
            Next

            ModulePartie.enleveNombreCoup()
            nombreCoup()
            LblBravoPerdu_Click()
        End If
    End Sub

    Private Function bienPlace(car As Char, index As Integer) As Boolean
        If car = ModulePartie.getCaraATrouver.ToArray(index) Then
            Return True
        End If
        Return False
    End Function

    Private Function malPlace(car As Char) As Boolean
        Dim chaineUti As String = ""
        Dim chaineAtrouver = ModulePartie.getCaraATrouver

        For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
            chaineUti += PnlCaractereJoue.Controls(i).Text
        Next

        'On prend ceux qui ne sont pas bien placé
        For i As Integer = PnlCaractereJoue.Controls.Count - 1 To 0 Step -1
            If chaineUti(i) = ModulePartie.getCaraATrouver(i) Then
                chaineAtrouver = chaineAtrouver.Remove(i, 1)
            End If
        Next

        Return chaineAtrouver.Contains(car)
    End Function

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

    Private Sub gagnePerdu(gagne As Boolean)
        Dim temps As Integer
        If ModuleConfig.timerEstActive Then
            temps = ModuleConfig.getTempsMax - ModulePartie.getTempsPartie()
        Else
            temps = 0
        End If

        If gagne Then
            LblBravoPerdu.Text = "Bravo, tu remportes cette manche !!!"
            LblBravoPerdu.Left += 12
            LblBravoPerdu.ForeColor = Color.Green

            ModuleJoueur.ajouterStats(getDeuxiemeJoueur, temps)
        Else
            LblBravoPerdu.Text = "Perdu, tu feras mieux la prochaine fois !"
            LblBravoPerdu.Left -= 4
            LblBravoPerdu.ForeColor = Color.Red

            ModuleJoueur.ajouterStats(getPremierJoueur, temps)
        End If
        lblBonneChance.Hide()
        LblNomJoueur.Hide()

        sauvegarderDansHisto()
    End Sub

    Private Sub partieFinis()
        PnlCaractereJoue.Enabled = False
        TimerJeu.Stop()
        BtnGuess.Hide()
        LblBravoPerdu.Show()
        btnExit.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        If ModulePartie.getModeEntrainement() Then
            ModulePartie.setModeEntrainement(False, "")
            FormRegles.Show()
        Else
            FormAccueil.Show()
        End If
    End Sub

    Private Sub nombreCoup()
        Me.Text = "Il vous reste " & ModulePartie.getNombreCoup.ToString & " coup(s)..."
    End Sub

    Sub gestionTimerLabel()
        initTimerEtProgressBar()
        LblTimer.Show()
        LblTimerReste.Text = "Il te reste : "
    End Sub

    'On initialise le timer et la progressbar
    Private Sub initTimerEtProgressBar()
        Dim tempsMax As Integer = ModuleConfig.getTempsMax
        ModulePartie.setTempsPartie(tempsMax)
        ModulePartie.AfficheLabelTimer(tempsMax, LblTimer)
        ProgressBarJeu.Maximum = tempsMax
        ProgressBarJeu.Value = tempsMax
    End Sub

    Private Sub TimerJeu_Tick(sender As Object, e As EventArgs) Handles TimerJeu.Tick
        Dim tempsMax = ModulePartie.getTempsPartie()
        tempsMax -= 1
        ProgressBarJeu.Value = tempsMax
        ModulePartie.AfficheLabelTimer(tempsMax, LblTimer)

        ModulePartie.setTempsPartie(tempsMax)
        If ModulePartie.timerFinis() Then
            BtnAbandonner.Enabled = False
            TimerJeu.Stop()
            gagnePerdu(False)
            partieFinis()
        End If
    End Sub

    Private Sub BtnAbandonner_Click(sender As Object, e As EventArgs) Handles BtnAbandonner.Click
        Dim demande As DialogResult = MessageBox.Show("Etes vous sur de vouloir abandonner ?", "Attention", MessageBoxButtons.YesNo)
        If demande = DialogResult.Yes Then
            gagnePerdu(False)
            partieFinis()
            BtnAbandonner.Enabled = False
        End If
    End Sub

    Private Sub FormJeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class
