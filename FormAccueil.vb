Public Class FormAccueil
    Private Sub FormAccueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ferm As DialogResult = MessageBox.Show("Voulez-vous fermer ?", "Confirmation", MessageBoxButtons.YesNo)
        If ferm = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
