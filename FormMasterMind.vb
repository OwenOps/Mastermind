Public Class FormMasterMind
    Private Sub FormMasterMind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleJoueur.chargerFichierDansHistorique()
        Me.AcceptButton = btnStart
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        FormAccueil.Show()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        FormulaireConfig.afficheBtnReset()
        FormulaireConfig.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegles_Click(sender As Object, e As EventArgs) Handles btnRegles.Click
        Me.Hide()
        FormRegles.Show()
    End Sub

    Private Sub FormMasterMind_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModuleGestionAppli.fermetureFormDialog Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class