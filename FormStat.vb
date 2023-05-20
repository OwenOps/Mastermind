Imports System.Drawing.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MasterMind.ModuleJoueur

Public Class FormStat

    'Private Const NBR_JOUEUR_PODIUM = 2
    'Private joueurs As Joueur()
    'Private joueursCopy As Joueur()
    'Private podium(NBR_JOUEUR_PODIUM) As Joueur

    Private joueurs As Joueur()
    Private statistiques As New List(Of String)

    Private Sub FormStat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        joueurs = getJoueurs()
        joueurs = ModuleJoueur.getJoueurHistorique()
        For Each joueur As Joueur In joueurs
            cbxNomJoueur.Items.Add(joueur.nom)
        Next
        statistiques.Clear()
        For Each lstbox As ListBox In pnlStats.Controls
            lstbox.Items.Clear()
        Next

        For Each joueur As Joueur In joueurs
            Dim statiquesJoueur As String = joueur.nom & vbTab & joueur.score & vbTab & afficherTemps(joueur.meilleurTemps) & vbTab & joueur.nbrPartiesPremierJoueur & vbTab & joueur.nbrPartiesSecondJoueur & vbTab & afficherTemps(joueur.cumulTemps)
            statistiques.Add(statiquesJoueur)
        Next

        UpdateListBoxes()
        trierOrdreAlpha()

        remplirPodiumScore()
        lblPodium1.Text = getPodium(0).nom & " : " & getPodium(0).score & " points !"
        lblPodium2.Text = getPodium(1).nom & " : " & getPodium(1).score & " points !"
        lblPodium3.Text = getPodium(2).nom & " : " & getPodium(2).score & " points !"

        cbxNomJoueur.AutoCompleteMode = AutoCompleteMode.Append
        cbxNomJoueur.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub lstAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBox1.SelectedIndexChanged, lstBox2.SelectedIndexChanged, lstBox3.SelectedIndexChanged, lstBox4.SelectedIndexChanged, lstBox5.SelectedIndexChanged, lstBox6.SelectedIndexChanged
        Dim index As Integer = sender.SelectedIndex
        For Each ListBox In pnlStats.Controls
            ListBox.SelectedIndex = index
        Next
    End Sub
    Private Sub btnSortAlpha_Click(sender As Object, e As EventArgs) Handles btnSortAlpha.Click
        trierOrdreAlpha()
    End Sub

    Private Sub btnSortScore_Click(sender As Object, e As EventArgs) Handles btnSortScore.Click
        remplirPodiumScore()
        lblPodium1.Text = getPodium(0).nom & " : " & getPodium(0).score & " points !"
        lblPodium2.Text = getPodium(1).nom & " : " & getPodium(1).score & " points !"
        lblPodium3.Text = getPodium(2).nom & " : " & getPodium(2).score & " points !"

    End Sub

    Private Sub btnSortTemps_Click(sender As Object, e As EventArgs) Handles btnSortTemps.Click
        remplirPodiumTemps()
        lblPodium1.Text = getPodium(0).nom & " : " & afficherTemps(getPodium(0).meilleurTemps)
        lblPodium2.Text = getPodium(1).nom & " : " & afficherTemps(getPodium(1).meilleurTemps)
        lblPodium3.Text = getPodium(2).nom & " : " & afficherTemps(getPodium(2).meilleurTemps)
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
                              " Meilleur temps : " & joueur.meilleurTemps &
                              vbCrLf & vbCrLf &
                              " Nombres de partie en tant que premier joueur : " & joueur.nbrPartiesPremierJoueur &
                              vbCrLf & vbCrLf &
                              " Nombres de partie en tant que second joueur :  " & joueur.nbrPartiesSecondJoueur &
                              vbCrLf & vbCrLf & " Temps cumulé à chercher les bonnes combinaisons : " & joueur.cumulTemps, "Données statistiques du joueur " & joueur.nom)
                    Exit For
                End If
            Next
        End If
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
    Function trierOrdreAlpha()
        lstBox1.Sorted = True
        lstBox2.Items.Clear()
        lstBox3.Items.Clear()
        lstBox4.Items.Clear()
        lstBox5.Items.Clear()
        lstBox6.Items.Clear()

        For Each nom In lstBox1.Items
            For Each joueur As Joueur In joueurs
                If nom = joueur.nom Then
                    lstBox2.Items.Add(joueur.score)
                    lstBox3.Items.Add(afficherTemps(joueur.meilleurTemps))
                    lstBox4.Items.Add(joueur.nbrPartiesPremierJoueur)
                    lstBox5.Items.Add(joueur.nbrPartiesSecondJoueur)
                    lstBox6.Items.Add(afficherTemps(joueur.cumulTemps))
                End If
            Next
        Next
        Return Nothing
    End Function
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormAccueil.Show()
    End Sub
    Private Sub FormStat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class




