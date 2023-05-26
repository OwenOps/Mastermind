Public Class FormStat
    Private joueurs As Joueur()
    Private statistiques As New List(Of String)

    Private Sub FormStat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxNomJoueur.AutoCompleteMode = AutoCompleteMode.Append
        cbxNomJoueur.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub FormStat_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        cbxNomJoueur.Items.Clear()

        joueurs = getJoueurs()
        joueurs = ModuleJoueur.getJoueurHistorique()

        For Each joueur As Joueur In joueurs
            cbxNomJoueur.Items.Add(joueur.nom)
        Next

        statistiques.Clear()
        videLstBox()

        For Each joueur As Joueur In joueurs
            Dim statiquesJoueur As String = joueur.nom & vbTab & joueur.score & vbTab & afficherTemps(joueur.meilleurTemps) & vbTab & joueur.nbrPartiesPremierJoueur & vbTab & joueur.nbrPartiesSecondJoueur & vbTab & afficherTemps(joueur.cumulTemps)
            statistiques.Add(statiquesJoueur)
        Next

        UpdateListBoxes()
        trierOrdreAlpha()

        initialiserLabelPodium()
        remplirPodiumScore()
        afficherPodiumScore()
    End Sub

    Private Sub lstAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBox1.SelectedIndexChanged, lstBox2.SelectedIndexChanged, lstBox3.SelectedIndexChanged, lstBox4.SelectedIndexChanged, lstBox5.SelectedIndexChanged, lstBox6.SelectedIndexChanged
        Dim index As Integer = sender.SelectedIndex
        For Each ListBox In pnlStats.Controls
            ListBox.SelectedIndex = index
        Next
    End Sub

    Private Sub btnSortAlpha_Click(sender As Object, e As EventArgs) Handles btnSortAlpha.Click
        trierOrdreAlpha()
        UpdateListBoxes()
    End Sub

    Private Sub btnSortScore_Click(sender As Object, e As EventArgs) Handles btnSortScore.Click
        statistiques = statistiques.OrderBy(Function(stat) Integer.Parse(stat.Split(vbTab)(1))).Reverse().ToList()
        UpdateListBoxes()
        initialiserLabelPodium()
        remplirPodiumScore()
        afficherPodiumScore()
    End Sub

    Private Sub btnSortTemps_Click(sender As Object, e As EventArgs) Handles btnSortTemps.Click
        UpdateListBoxes()
        remplirListBoxTemps()
        initialiserLabelPodium()
        remplirPodiumTemps()
        afficherPodiumTemps()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxNomJoueur.SelectedIndexChanged
        If cbxNomJoueur.SelectedItem IsNot Nothing Then
            Dim joueurSelectionne As String = cbxNomJoueur.SelectedItem.ToString()
            For Each joueur As Joueur In joueurs
                If joueur.nom = joueurSelectionne Then
                    MessageBox.Show("Voici les statistiques du joueur " & joueur.nom & " :" &
                              vbCrLf & vbCrLf & vbCrLf &
                              " Score : " & joueur.score &
                              vbCrLf & vbCrLf &
                              " Meilleur temps : " & afficherTemps(joueur.meilleurTemps) &
                              vbCrLf & vbCrLf &
                              " Nombres de partie en tant que premier joueur : " & joueur.nbrPartiesPremierJoueur &
                              vbCrLf & vbCrLf &
                              " Nombres de partie en tant que second joueur :  " & joueur.nbrPartiesSecondJoueur &
                              vbCrLf & vbCrLf & " Temps cumulé à chercher les bonnes combinaisons : " & afficherTemps(joueur.cumulTemps), "Données statistiques du joueur " & joueur.nom)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub initialiserLabelPodium()
        lblPodium1.Text = Nothing
        lblPodium2.Text = Nothing
        lblPodium3.Text = Nothing
    End Sub

    Private Sub UpdateListBoxes()
        Dim i As Integer
        i = 5
        For Each lstbox As ListBox In pnlStats.Controls
            lstbox.Items.Clear()
        Next

        For Each stat As String In statistiques
            Dim data As String() = stat.Split(vbTab)
            For Each lstBox As ListBox In pnlStats.Controls
                lstBox.Items.Add(data(i))
                i -= 1
            Next
            i = 5
        Next
    End Sub

    Private Sub trierOrdreAlpha()
        Dim sortedStatistiques = statistiques.OrderBy(Function(stat) stat.Split(vbTab)(0))
        statistiques = New List(Of String)(sortedStatistiques)
    End Sub

    Private Sub afficherPodiumTemps()
        If (getPodium(0).meilleurTemps <> ModuleStat.getMaxTemps) Then
            lblPodium1.Text = getPodium(0).nom & " : " & afficherTemps(getPodium(0).meilleurTemps)
        End If
        If (getPodium(1).meilleurTemps <> ModuleStat.getMaxTemps) Then
            lblPodium2.Text = getPodium(1).nom & " : " & afficherTemps(getPodium(1).meilleurTemps)
        End If
        If (getPodium(2).meilleurTemps <> ModuleStat.getMaxTemps) Then
            lblPodium3.Text = getPodium(2).nom & " : " & afficherTemps(getPodium(2).meilleurTemps)
        End If
    End Sub

    Private Sub afficherPodiumScore()
        If (getPodium(0).score <> -1) Then
            lblPodium1.Text = getPodium(0).nom & " : " & getPodium(0).score & " points !"
        End If
        If (getPodium(1).score <> -1) Then
            lblPodium2.Text = getPodium(1).nom & " : " & getPodium(1).score & " points !"
        End If
        If (getPodium(2).score <> -1) Then
            lblPodium3.Text = getPodium(2).nom & " : " & getPodium(2).score & " points !"
        End If
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormAccueil.Show()
    End Sub

    Private Sub remplirListBoxTemps()
        Dim joueurs As Joueur() = getJoueurHistorique()
        Dim joueursCopy As Joueur() = joueurs.Clone()

        Array.Sort(joueursCopy, Function(x, y)
                                    If x.meilleurTemps = 0 AndAlso y.meilleurTemps = 0 Then
                                        Return 0
                                    ElseIf x.meilleurTemps = 0 Then
                                        Return 1
                                    ElseIf y.meilleurTemps = 0 Then
                                        Return -1
                                    Else
                                        Return x.meilleurTemps.CompareTo(y.meilleurTemps)
                                    End If
                                End Function)
        videLstBox()

        For Each joueur As Joueur In joueursCopy
            lstBox1.Items.Add(joueur.nom)
            lstBox2.Items.Add(joueur.score)
            lstBox3.Items.Add(If(joueur.meilleurTemps <> 0, afficherTemps(joueur.meilleurTemps), "Pas encore joué"))
            lstBox4.Items.Add(joueur.nbrPartiesPremierJoueur)
            lstBox5.Items.Add(joueur.nbrPartiesSecondJoueur)
            lstBox6.Items.Add(If(joueur.cumulTemps <> 0, afficherTemps(joueur.cumulTemps), "Pas encore joué"))
        Next
    End Sub

    Private Sub videLstBox()
        For Each lstbox As ListBox In pnlStats.Controls
            lstbox.Items.Clear()
        Next
    End Sub

    Private Sub FormStat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class