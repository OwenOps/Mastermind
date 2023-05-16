Public Class FormJeu
    'Toutes les petites fonctions utilises sont en bas
    Private Sub FormJeu_Load() Handles MyBase.Load
        'On initialise le timer et la progressbar
        Dim TempsMax As Integer = ModulePartie.getTempsMax()
        AfficheLabelTimer(TempsMax)
        ProgressBarJeu.Maximum = TempsMax


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

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        If Not CaseVide() Then
            Console.WriteLine(ModulePartie.getCaraATrouver)
            For i As Integer = 0 To PnlCaractereJoue.Controls.Count - 1
                For j As Integer = i To ModulePartie.getCaraATrouver.ToArray.Length - 1
                    If (PnlCaractereJoue.Controls(i).Text = ModulePartie.getCaraATrouver.ToArray(j) And i = j) Then 'Si bon et bien place
                        PnlCaractereJoue.Controls(i).BackColor = Color.Green
                        LstCaraHisto.SelectionColor = Color.Green
                        ModulePartie.removeCara(PnlCaractereJoue.Controls(i).Text)
                        Exit For

                    ElseIf ModulePartie.getCaraRestant.ToArray.Contains(PnlCaractereJoue.Controls(i).Text) Then 'Si present
                        PnlCaractereJoue.Controls(i).BackColor = Color.Blue
                        LstCaraHisto.SelectionColor = Color.Blue
                        Exit For

                    Else 'Si caractere n'est pas present
                        PnlCaractereJoue.Controls(i).BackColor = Color.Red
                        LstCaraHisto.SelectionColor = Color.Red
                        Exit For

                    End If
                Next
                LstCaraHisto.AppendText("   " + PnlCaractereJoue.Controls(i).Text + "   ")
                PnlCaractereJoue.Controls(i).ForeColor = Color.White
            Next

            LstCaraHisto.AppendText(vbCrLf)
            For Each txt As TextBox In PnlCaractereJoue.Controls
                ModulePartie.resetTxt(txt)
            Next

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


    Private Sub TimerJeu_Tick(sender As Object, e As EventArgs) Handles TimerJeu.Tick
        Dim tempsMax = ModulePartie.getTempsMax()
        tempsMax -= 1
        ProgressBarJeu.Value = tempsMax
        AfficheLabelTimer(tempsMax)

        'LblTimer.Text = tempsMax
        ModulePartie.setTempsMax(tempsMax)
        If ModulePartie.timerFinis() Then
            TimerJeu.Stop()
            gagnePerdu(False)
            partieFinis()
        End If

    End Sub

    Sub AfficheLabelTimer(tempsMax As Integer)
        Dim ts As Integer = 0, h = 0, m = 0, s = 0
        ts = tempsMax
        h = ts / 3600
        m = Math.Floor((ts / 60) - 60 * h)
        s = ts - 3600 * h - 60 * m

        If tempsMax >= 3600 Then
            LblTimer.Text = h & " h : " & m & " min : " & s & " sec"
        ElseIf tempsMax >= 60 Then
            LblTimer.Text = m & " min : " & s & " sec"
        Else
            LblTimer.Text = s & " sec"
        End If
    End Sub
End Class
