Public Class FormRegles

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormMasterMind.Show()
        Me.AcceptButton = btnEntrainement
    End Sub
    Private Sub FormRegles_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnEntrainement_Click(sender As Object, e As EventArgs) Handles btnEntrainement.Click
        Dim nomJoueur = InputBox("Quel est ton nom ?", "Nom d'entrainement")

        Dim demande As DialogResult = MsgBox("Voulez-vous lancer l'entrainement", vbYesNo, "Entrainement")
        If demande = DialogResult.Yes Then

            ModulePartie.setCaraAleatoire()

            Dim chaineATrouve As String = ""
            For Each txtBox As TextBox In FormCaractere.PnlCaractereJoue.Controls
                chaineATrouve += txtBox.Text
            Next

            ModulePartie.setCaraATrouver(chaineATrouve.ToArray)
            ModulePartie.setModeEntrainement(True, nomJoueur)

            Me.Hide()
            FormJeu.Show()
        End If
    End Sub
End Class