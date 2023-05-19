Imports System.Windows.Forms
Public Class FormStat
    Private joueurs As Joueur()
    Private statistiques As New List(Of String)()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelNom.Click

    End Sub

    Private Sub FormStat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        joueurs = ModuleJoueur.getJoueurHistorique()
        Try
            For Each joueur As Joueur In joueurs
                ComboBox1.Items.Add(joueur.nom)
            Next
        Catch ex As Exception
            MessageBox.Show("Aucune statistique de jeu n'est disponible, commencez d'abord à jouer ! " & ex.Message, "Erreur")
            Return
        End Try

        statistiques.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()

        For Each joueur As Joueur In joueurs
            Dim statiquesJoueur As String = joueur.nom & vbTab & joueur.score & vbTab & joueur.meilleurTemps & vbTab & joueur.nbrPartiesPremierJoueur & vbTab & joueur.nbrPartiesSecondJoueur & vbTab & joueur.cumulTemps
            statistiques.Add(statiquesJoueur)
        Next

        UpdateListBoxes()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim joueurSelectionne As String = ComboBox1.SelectedItem.ToString()
            Dim joueurs As Joueur() = ModuleJoueur.getJoueurHistorique()

            For Each joueur As Joueur In joueurs
                If joueur.nom = joueurSelectionne Then
                    MessageBox.Show("Voici les statistiques du joueur " & joueur.nom & ":" &
                              vbCrLf & vbCrLf & vbCrLf &
                              " Score : " & joueur.score &
                              vbCrLf & vbCrLf &
                              " Meilleure temps : " & joueur.meilleurTemps &
                              vbCrLf & vbCrLf &
                              " Nombres Partie en tant que joueur 1 : " & joueur.nbrPartiesPremierJoueur &
                              vbCrLf & vbCrLf &
                              " Nombres Partie en tant que joueur 2 :  " & joueur.nbrPartiesSecondJoueur &
                              vbCrLf & vbCrLf & "Temps cumulé à chercher les combinaisons : " & joueur.cumulTemps, "Données statistiques du joueur " & joueur.nom)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSortAlpha.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub ButtonSortScore_Click(sender As Object, e As EventArgs) Handles ButtonSortScore.Click

    End Sub

    Private Sub ButtonSortTEMPS_Click(sender As Object, e As EventArgs) Handles ButtonSortTEMPS.Click

    End Sub

    Private Sub UpdateListBoxes()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()

        For Each stat As String In statistiques
            Dim data As String() = stat.Split(vbTab)
            ListBox1.Items.Add(data(0))
            ListBox2.Items.Add(data(1))
            ListBox3.Items.Add(data(2))
            ListBox4.Items.Add(data(3))
            ListBox5.Items.Add(data(4))
            ListBox6.Items.Add(data(5))
        Next
    End Sub
End Class




