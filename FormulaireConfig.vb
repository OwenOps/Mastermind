Imports System.Diagnostics.Eventing.Reader

Public Class FormulaireConfig
    Dim caraDefault As String = "A,B,C,D,E"
    Dim ancienNom

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

    Sub resetFormConfig()
        resetTxt(TxtCaraChange)
        resetTxt(TxtNbrCoup)
        resetTxt(TxtTempsMin)
        resetTxt(TxtTempsSec)

        PnlCoupCache.Visible = False
        PnlCaraCache.Visible = False

        If PnlNomCache.Visible = True Then
            PnlNomCache.Visible = False
        End If

        For Each pnl As Panel In PnlRadioBtn.Controls
            For Each rd As RadioButton In pnl.Controls
                rd.Checked = False
            Next
        Next
    End Sub

    Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNbrCoup.KeyPress, TxtCaraChange.KeyPress
        Dim textBox As TextBoxBase = TryCast(sender, TextBox)
        Dim textActive = textBox.Name

        If e.KeyChar = vbBack Then Exit Sub

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

            Dim nbrCoup As Integer = 0
            If TxtNbrCoup.Text <> "" And Integer.TryParse(TxtNbrCoup.Text, nbrCoup) AndAlso nbrCoup > 0 Then
                ModuleConfig.setNombreCoup(TxtNbrCoup.Text)
                ModulePartie.resetTxt(TxtNbrCoup)
            Else
                MessageBox.Show("Le nombre de coup doit etre supérieur a 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf btnActive = BtnValidCara.Name Then

            If TxtCaraChange.Text.Length = ModuleConfig.getNbrCaraMax Then
                If caraDifferent() Then
                    ModuleConfig.setCaraJouable(TxtCaraChange.Text)
                Else
                    MessageBox.Show("Les caractères doivent être différent.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ModulePartie.resetTxt(TxtCaraChange)
            Else
                MessageBox.Show("Le nombre de caractère minimum est de 5.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf btnActive = BtnValidTimer.Name Then
            temps()
        End If
    End Sub

    Private Function caraDifferent()
        If String.Compare(TxtCaraChange.Text, ModuleConfig.getCaraJouable) = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub temps()
        Dim min As Integer
        Dim sec As Integer

        If TxtTempsMin.Text = "" Then
            min = 0
        Else
            min = TxtTempsMin.Text
        End If

        If TxtTempsSec.Text = "" Then
            sec = 0
        Else
            sec = TxtTempsSec.Text
        End If

        Dim tempsMax = min * 60 + sec
        If sec < 0 Or sec > 60 Then
            MsgBox("Le nombre de seconde doit être compris entre 0 et 60", vbOKOnly, "Erreur")
            Exit Sub
        End If

        If min < 0 Or min > 60 Then
            MsgBox("Le nombre de minutes doit être compris entre 0 et 60", vbOKOnly, "Erreur")
            Exit Sub
        End If

        If tempsMax < 5 Then
            MsgBox("Le temps minimum doit être de 5 secondes", vbOKOnly, "Erreur")
            Exit Sub
        End If

        ModuleConfig.setTempsMax(tempsMax)
        ModulePartie.resetTxt(TxtTempsSec)
        ModulePartie.resetTxt(TxtTempsMin)
    End Sub


    Private Sub BtnValidNom_Click(sender As Object, e As EventArgs) Handles BtnValidNom.Click
        If cbxNomJoueurChange.Text = "" Then
            MsgBox("Veuillez entrer un nom valide.")
            Exit Sub
        End If

        Dim nom = cbxNomJoueurChange.Text
        If ModuleJoueur.getValider = True Then

            If String.Compare(nom, ancienNom) = 0 Then
                MessageBox.Show("Vous avez rentré le meme nom.", "Erreur")
            Else

                ModuleJoueur.changementNomJoueur(ancienNom, nom)
                ModuleJoueur.setValider(False)
                MessageBox.Show("Votre nouveau nom : " & nom & ", et ancien nom : " & ModuleJoueur.getJoueurSpecifique(nom).ancienNom)
                ModuleJoueur.chargercbxNomJoueur()
                cbxNomJoueurChange.Text = ""
                LblNomActu.Text = LblNomActu.Tag
                BtnValidNom.Text = BtnValidNom.Tag
            End If
            Exit Sub
        End If

        If ModuleJoueur.estContenuDansHistorique(nom) Then
            cbxNomJoueurChange.Text = ""
            LblNomActu.Tag = LblNomActu.Text
            LblNomActu.Text = "Entrez votre nouveau nom :"
            BtnValidNom.Width = 75
            BtnValidNom.Tag = BtnValidNom.Text
            BtnValidNom.Text = "Renommer"
            ModuleJoueur.setValider(True)
            'MEttre poour alex son ancien nom alex
            ModuleJoueur.setAncienNomJoueur(nom)
            ancienNom = nom
        End If
        'FormAccueil.Show()
    End Sub

    Private Sub TxtTemps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTempsMin.KeyPress, TxtTempsSec.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
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
        ModuleConfig.setNombreCoup(ModuleConfig.getCoupDefaut)
        ModuleConfig.setTimerActive(True)
        ModuleConfig.setTempsMax(ModuleConfig.getTempsDefaut)
        ModuleConfig.setCaraJouable(caraDefault)
        MsgBox("Configuration remis par default.")
    End Sub

    Private Sub FormConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class