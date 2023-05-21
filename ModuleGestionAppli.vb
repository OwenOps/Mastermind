Module ModuleGestionAppli
    Private fermetureDialog = False
    Dim ferm As DialogResult

    'Demander une seul fois le message pour quitter.
    Public Function fermetureFormDialog() As Boolean
        If fermetureDialog = False Then
            ferm = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?", "Fermer MasterMind", MessageBoxButtons.YesNo)
        End If

        If ferm = DialogResult.No Then
            fermetureDialog = False
            Return False
        Else
            fermetureDialog = True
            Return True
        End If
    End Function
End Module
