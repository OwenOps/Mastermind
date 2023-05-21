Module ModuleGestionAppli
    Dim cpt As Integer = 0
    Dim ferm As DialogResult

    'Demander une seul fois le message pour quitter.
    Public Function fermetureFormDialog() As Boolean
        If cpt = 0 Then
            ferm = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Fermer MasterMind", MessageBoxButtons.YesNo)
        End If

        If ferm = DialogResult.No Then
            Return False
        Else
            If cpt = 0 Then
                ArchiverJoueurDansFichier()
            End If

            cpt = cpt + 1
            Return True
        End If
    End Function
End Module
