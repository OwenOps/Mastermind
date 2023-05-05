Imports System.Diagnostics.Eventing.Reader

Public Class FormulaireConfig
    Dim nbrCoupDefault As Integer = 15
    Dim tempsDefault As Integer = 90
    Dim caraDefault As String = "A,B,C,D,E"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ModuleJoueur.addJoueur("Namo")
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles RO1.CheckedChanged, RO2.CheckedChanged, RO3.CheckedChanged, RO4.CheckedChanged, RN1.CheckedChanged, RN2.CheckedChanged, RN3.CheckedChanged, RN4.CheckedChanged
        Dim radioBoutton As RadioButton = TryCast(sender, RadioButton)
        Dim nomRadio = radioBoutton.Name

        Select Case nomRadio
            Case RO1.Name
                PnlTimerCache.Visible = radioBoutton.Checked
            Case RO2.Name
                PnlCoupCache.Visible = radioBoutton.Checked
            Case RO3.Name
                PnlCaraCache.Visible = radioBoutton.Checked
            Case RO4.Name
                If ModuleJoueur.joueurHistoriqueEstVide() And RO4.Checked Then
                    RO4.Checked = False
                    MsgBox("Il n'y a pas encore de joueurs enregistrés", vbOKOnly, "Erreur")
                Else
                    ModuleJoueur.chargercbxNomJoueur()
                    PnlNomCache.Visible = radioBoutton.Checked
                End If
            Case RN1.Name
                PnlTimerCache.Visible = False
            Case RN2.Name
                PnlCoupCache.Visible = False
            Case RN3.Name
                PnlCaraCache.Visible = False
            Case RN4.Name
                PnlNomCache.Visible = False
        End Select

    End Sub

    Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNbrCoup.KeyPress, TxtCaraChange.KeyPress
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

        If btnActive = BtnValidCoup.Name Then
            If TxtNbrCoup.Text.Length > 0 And TxtNbrCoup.Text <> "" Then
                ModuleConfig.setNombreCoup(TxtNbrCoup.Text)
                ModulePartie.resetTxt(TxtNbrCoup)
            End If
        ElseIf btnActive = BtnValidCara.Name Then
            If TxtCaraChange.Text.Length = ModuleConfig.getNbrCaraMax Then
                ModuleConfig.setCaraJouable(TxtCaraChange.Text)
                ModulePartie.resetTxt(TxtCaraChange)
            End If
        ElseIf btnActive = BtnValidTimer.Name Then
            If TxtTemps.Text > 9 Then
                ModulePartie.setTempsMax(TxtTemps.Text)
                ModulePartie.resetTxt(TxtTemps)
            End If
        End If
    End Sub

    Private Sub BtnValidNom_Click(sender As Object, e As EventArgs) Handles BtnValidNom.Click

        If cbxNomJoueurChange.Text = "" Then
            MsgBox("Veuillez entrer un nom valide.")
            Exit Sub
        End If

        If ModuleJoueur.estContenuDansHistorique(cbxNomJoueurChange.Text) Then
            ModuleJoueur.setAncienNom(cbxNomJoueurChange.Text)
            ModuleJoueur.setValid()
            cbxNomJoueurChange.Text = ""
            LblNomActu.Tag = LblNomActu.Text
            LblNomActu.Text = "Entrez votre nouveau nom :"
            BtnValidNom.Width = 75
            BtnValidNom.Text = "Renommer"
        ElseIf Not ModuleJoueur.getValid Then
            MsgBox("Le nom ne correspond pas.")
            Exit Sub
        End If

        If ModuleJoueur.getValid Then
            If ModuleJoueur.getAncienNom() = cbxNomJoueurChange.Text Then
                MsgBox("Vous avez rentré le même nom.")
            ElseIf cbxNomJoueurChange.Text <> "" Then
                ModuleJoueur.changementNomJoueur(cbxNomJoueurChange.Text)
                MsgBox("Votre nouveau nom a été changé." + vbCrLf + "Ancien nom : " + ModuleJoueur.getAncienNom() + vbCrLf + "Nouveau nom : " + cbxNomJoueurChange.Text)
                LblNomActu.Text = LblNomActu.Tag
                cbxNomJoueurChange.Text = ""
                BtnValidNom.Text = "Valider"
                ModuleJoueur.chargercbxNomJoueur()
            End If
        End If


        'FormAccueil.Show()
    End Sub

    Private Sub TxtTemps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTemps.KeyPress
        Dim textBox As TextBox = CType(sender, TextBox)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormMasterMind.Show()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ModuleConfig.setNombreCoup(nbrCoupDefault)
        ModuleConfig.setTimerActive(True)
        ModulePartie.setTempsMax(tempsDefault)
        ModuleConfig.setCaraJouable(caraDefault)
        MsgBox("Configuration remis par default.")
    End Sub
End Class