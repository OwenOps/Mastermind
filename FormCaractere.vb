Public Class FormCaractere
    Dim rectangle As Graphics
    Private Sub FormCaractere_Load() Handles MyBase.Load
        Dim caraChaine As String = ""
        For Each cara In ModuleConfig.CaraJouable
            caraChaine += "  " & cara & "  "
        Next
        CaraJouable.Text = caraChaine
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBox1.KeyPress, TxtBox2.KeyPress, TxtBox3.KeyPress, TxtBox4.KeyPress, TxtBox5.KeyPress
        Dim textBox As TextBox = CType(sender, TextBox)
        If Char.IsLetter(e.KeyChar) Then
            Dim entree As String = e.KeyChar.ToString()
            If ModuleConfig.CaraJouable.Contains(entree) Then
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

    Private Sub ButtonHIDE_Click(sender As Object, e As EventArgs) Handles ButtonHIDE.Click
        Dim erreur As Boolean = False

        For Each txtBox As TextBox In PnlCaractereJoue.Controls
            If (txtBox.Text.Length <= 0) Then
                erreur = True
            End If
        Next

        If erreur = False Then
            Dim demande As DialogResult = MessageBox.Show("Voulez-vous commencer à jouer?", "La partie va commencer !", MessageBoxButtons.YesNo)
            If demande = DialogResult.Yes Then
                Me.Hide()
                FormJeu.Show()
            End If
        Else
            MessageBox.Show("Veuillez remplir toutes les cases pour commencer à jouer.")
        End If
    End Sub

    Private Sub ListeCaractereJouable_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
