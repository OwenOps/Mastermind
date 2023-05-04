Public Class FormulaireConfig
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub CbxChoixTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxChoixTemps.SelectedIndexChanged

    End Sub

    Private Sub TxtCaraChange_TextChanged(sender As Object, e As EventArgs) Handles TxtCaraChange.TextChanged

    End Sub

    Private Sub PanelCoup_DragOver(sender As Object, e As DragEventArgs) Handles PanelCoup.DragOver

    End Sub

    Private Sub PanelCoup_EnabledChanged(sender As Object, e As EventArgs) Handles PanelCoup.EnabledChanged

    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles RO1.CheckedChanged, RO2.CheckedChanged, RO3.CheckedChanged, RN1.CheckedChanged, RN2.CheckedChanged, RN3.CheckedChanged
        Dim radioBoutton As RadioButton = TryCast(sender, RadioButton)
        Dim nomRadio = radioBoutton.Name
        If radioBoutton.Checked And radioBoutton.Text.Equals("Oui") Then
            If nomRadio = RO1.Name Then
                PnlTimerCache.Show()
            ElseIf nomRadio = RO2.Name Then
                PnlCoupCache.Show()
            Else
                PnlCaraCache.Show()
            End If
        ElseIf nomRadio = RN1.Name Then
            PnlTimerCache.Hide()
        ElseIf nomRadio = RN2.Name Then
            PnlCoupCache.Hide()
        Else
            PnlCaraCache.Hide()
        End If
    End Sub

    Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNbrCoup.KeyPress, TxtCaraChange.KeyPress, TxtNomJoueur.KeyPress
        Dim textBox As TextBoxBase = TryCast(sender, TextBox)
        Dim textActive = textBox.Name

        If PnlCoupCache.Visible Then
            If textActive = TxtNbrCoup.Name And Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf PnlCaraCache.Visible Then
            If textActive = TxtCaraChange.Name And Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
                e.Handled = True
            End If
        Else
            If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValidTimer.Click, BtnValidCara.Click, BtnValidCoup.Click
        Dim btn As Button = TryCast(sender, Button)
        Dim btnActive = btn.Name
        Dim erreur = False

        If btnActive = BtnValidCoup.Name Then
            If TxtNbrCoup.Text.Length > 0 And TxtNbrCoup.Text <> "" Then
                ModuleConfig.setNombreCoup(TxtNbrCoup.Text)
                TxtNbrCoup.Text = ""
            Else
                erreur = True
            End If
        ElseIf btnActive = BtnValidCara.Name Then
            If TxtCaraChange.Text.Length = ModuleConfig.getNbrCaraMax Then
                setCaraJouable(TxtCaraChange.Text)
                TxtCaraChange.Text = ""
            Else
                erreur = True
            End If
        End If
    End Sub

    Private Sub TxtNomJoueur_TextChanged(sender As Object, e As EventArgs) Handles TxtNomJoueur.TextChanged

    End Sub

    Dim ancienNom As String = ""
    Dim nouveauNom As Boolean = False
    Private Sub BtnValidNom_Click(sender As Object, e As EventArgs) Handles BtnValidNom.Click
        If TxtNomJoueur.Text = "" Then
            MsgBox("Veuillez entrer un nom valide.")
            Exit Sub
        End If

        If ModuleJoueur.estContenuDansHistorique(TxtNomJoueur.Text) Then
            ancienNom = TxtNomJoueur.Text
            nouveauNom = True
            resetTxt()
            LblNomActu.Tag = LblNomActu.Text
            LblNomActu.Text = "Votre nouveau Nom"
            LblNomActu.Left -= 15
        ElseIf Not nouveauNom Then
            MsgBox("Le nom ne correspond pas.")
            Exit Sub
        End If

        If nouveauNom Then
            If ancienNom = TxtNomJoueur.Text Then
                MsgBox("Vous avez rentré le même nom.")
            ElseIf TxtNomJoueur.Text <> "" Then
                ModuleJoueur.changementNomJoueur(TxtNomJoueur.Text)
                MsgBox("Votre nouveau nom a été changé." + vbCrLf + "Ancien nom : " + ancienNom + vbCrLf + "Nouveau nom : " + TxtNomJoueur.Text)
                LblNomActu.Text = LblNomActu.Tag
                resetTxt()
            End If
        End If
    End Sub

    Sub resetTxt()
        TxtNomJoueur.Text = ""
    End Sub
End Class