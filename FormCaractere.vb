Public Class FormCaractere
    Private Sub FormCaractere_Load() Handles MyBase.Load
        Dim ctrlList As List(Of Control) = PnlCaractereJoue.Controls.Cast(Of Control).OrderBy(Function(c) c.TabIndex).ToList()
        Dim caraChaine As String = ""
        lblNom.Text = getDeuxiemeJoueur().nom
        Me.AcceptButton = btnHide

        For i As Integer = 0 To ctrlList.Count - 1
            PnlCaractereJoue.Controls.SetChildIndex(ctrlList(i), i)
        Next

        For Each cara In ModuleConfig.getCaraJouable.ToArray
            caraChaine += "  " & cara & "  "
        Next
        lblCaraJouable.Text = caraChaine
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBox1.KeyPress, txtBox2.KeyPress, txtBox3.KeyPress, txtBox4.KeyPress, txtBox5.KeyPress
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
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Dim erreur As Boolean = False
        Dim chaineATrouve As String = ""

        For Each txtBox As TextBox In PnlCaractereJoue.Controls
            If (txtBox.Text.Length <= 0) Then
                erreur = True
            Else
                chaineATrouve += txtBox.Text
            End If
        Next

        If erreur = False Then
            If demandeJouer() Then
                ModulePartie.setCaraATrouver(chaineATrouve.ToArray)
                resetFormCaractere()
                FormJeu.resetFormJeu()
            End If

        Else
            MessageBox.Show("Veuillez remplir toutes les cases pour commencer à jouer !", "Erreur")
        End If

    End Sub
    Private Sub btnAleatoire_Click(sender As Object, e As EventArgs) Handles btnAleatoire.Click
        ModulePartie.setCaraAleatoire()
    End Sub
    Sub resetFormCaractere()
        For Each txt As TextBox In PnlCaractereJoue.Controls
            resetTxt(txt)
        Next
    End Sub
    Private Sub FormCaractere_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    ' dans formulaire ou non?
    Function demandeJouer() As Boolean
        Dim demande As DialogResult = MessageBox.Show("Voulez-vous commencer à jouer?", "La partie va commencer !", MessageBoxButtons.YesNo)
        If demande = DialogResult.Yes Then
            Me.Hide()
            FormJeu.Show()
            Return True
        End If
        Return False
    End Function
    Sub caraDansTxtBox(cara() As Char)
        Dim cpt As Integer = 0
        For Each txt As TextBox In PnlCaractereJoue.Controls
            txt.Text = cara(cpt)
            cpt += 1
        Next
    End Sub

End Class
