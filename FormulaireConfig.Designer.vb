<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormulaireConfig
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelTimer = New System.Windows.Forms.Panel()
        Me.RN1 = New System.Windows.Forms.RadioButton()
        Me.RO1 = New System.Windows.Forms.RadioButton()
        Me.TxtNbrCoup = New System.Windows.Forms.TextBox()
        Me.TxtCaraChange = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxChoixTemps = New System.Windows.Forms.ComboBox()
        Me.PanelCaractere = New System.Windows.Forms.Panel()
        Me.RN3 = New System.Windows.Forms.RadioButton()
        Me.RO3 = New System.Windows.Forms.RadioButton()
        Me.PanelCoup = New System.Windows.Forms.Panel()
        Me.RN2 = New System.Windows.Forms.RadioButton()
        Me.RO2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PnlTimerCache = New System.Windows.Forms.Panel()
        Me.BtnValidTimer = New System.Windows.Forms.Button()
        Me.PnlCoupCache = New System.Windows.Forms.Panel()
        Me.BtnValidCoup = New System.Windows.Forms.Button()
        Me.PnlCaraCache = New System.Windows.Forms.Panel()
        Me.BtnValidCara = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNomJoueur = New System.Windows.Forms.TextBox()
        Me.LblNomActu = New System.Windows.Forms.Label()
        Me.BtnValidNom = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTimer.SuspendLayout()
        Me.PanelCaractere.SuspendLayout()
        Me.PanelCoup.SuspendLayout()
        Me.PnlTimerCache.SuspendLayout()
        Me.PnlCoupCache.SuspendLayout()
        Me.PnlCaraCache.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activer le Timer : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Changer nombre Coups Possible : "
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Maroon
        Me.Titre.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Titre.ForeColor = System.Drawing.Color.Transparent
        Me.Titre.Location = New System.Drawing.Point(214, 9)
        Me.Titre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(141, 52)
        Me.Titre.TabIndex = 39
        Me.Titre.Text = "Option"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-20, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 68)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Changer les Caractères Jouables : "
        '
        'PanelTimer
        '
        Me.PanelTimer.Controls.Add(Me.RN1)
        Me.PanelTimer.Controls.Add(Me.RO1)
        Me.PanelTimer.Location = New System.Drawing.Point(302, 85)
        Me.PanelTimer.Name = "PanelTimer"
        Me.PanelTimer.Size = New System.Drawing.Size(132, 41)
        Me.PanelTimer.TabIndex = 41
        '
        'RN1
        '
        Me.RN1.AutoSize = True
        Me.RN1.Location = New System.Drawing.Point(74, 13)
        Me.RN1.Name = "RN1"
        Me.RN1.Size = New System.Drawing.Size(45, 17)
        Me.RN1.TabIndex = 2
        Me.RN1.TabStop = True
        Me.RN1.Text = "Non"
        Me.RN1.UseVisualStyleBackColor = True
        '
        'RO1
        '
        Me.RO1.AutoSize = True
        Me.RO1.Location = New System.Drawing.Point(12, 13)
        Me.RO1.Name = "RO1"
        Me.RO1.Size = New System.Drawing.Size(41, 17)
        Me.RO1.TabIndex = 1
        Me.RO1.TabStop = True
        Me.RO1.Text = "Oui"
        Me.RO1.UseVisualStyleBackColor = True
        '
        'TxtNbrCoup
        '
        Me.TxtNbrCoup.Location = New System.Drawing.Point(231, 6)
        Me.TxtNbrCoup.MaxLength = 6
        Me.TxtNbrCoup.Name = "TxtNbrCoup"
        Me.TxtNbrCoup.Size = New System.Drawing.Size(60, 20)
        Me.TxtNbrCoup.TabIndex = 42
        Me.TxtNbrCoup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCaraChange
        '
        Me.TxtCaraChange.Location = New System.Drawing.Point(303, 2)
        Me.TxtCaraChange.MaxLength = 5
        Me.TxtCaraChange.Name = "TxtCaraChange"
        Me.TxtCaraChange.Size = New System.Drawing.Size(60, 20)
        Me.TxtCaraChange.TabIndex = 43
        Me.TxtCaraChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Le temps laissé au Joueur "
        '
        'CbxChoixTemps
        '
        Me.CbxChoixTemps.FormattingEnabled = True
        Me.CbxChoixTemps.Location = New System.Drawing.Point(200, 3)
        Me.CbxChoixTemps.Name = "CbxChoixTemps"
        Me.CbxChoixTemps.Size = New System.Drawing.Size(104, 21)
        Me.CbxChoixTemps.TabIndex = 45
        '
        'PanelCaractere
        '
        Me.PanelCaractere.Controls.Add(Me.RN3)
        Me.PanelCaractere.Controls.Add(Me.RO3)
        Me.PanelCaractere.Location = New System.Drawing.Point(302, 311)
        Me.PanelCaractere.Name = "PanelCaractere"
        Me.PanelCaractere.Size = New System.Drawing.Size(132, 41)
        Me.PanelCaractere.TabIndex = 42
        '
        'RN3
        '
        Me.RN3.AutoSize = True
        Me.RN3.Location = New System.Drawing.Point(74, 13)
        Me.RN3.Name = "RN3"
        Me.RN3.Size = New System.Drawing.Size(45, 17)
        Me.RN3.TabIndex = 1
        Me.RN3.TabStop = True
        Me.RN3.Text = "Non"
        Me.RN3.UseVisualStyleBackColor = True
        '
        'RO3
        '
        Me.RO3.AutoSize = True
        Me.RO3.Location = New System.Drawing.Point(12, 13)
        Me.RO3.Name = "RO3"
        Me.RO3.Size = New System.Drawing.Size(41, 17)
        Me.RO3.TabIndex = 0
        Me.RO3.TabStop = True
        Me.RO3.Text = "Oui"
        Me.RO3.UseVisualStyleBackColor = True
        '
        'PanelCoup
        '
        Me.PanelCoup.Controls.Add(Me.RN2)
        Me.PanelCoup.Controls.Add(Me.RO2)
        Me.PanelCoup.Location = New System.Drawing.Point(302, 198)
        Me.PanelCoup.Name = "PanelCoup"
        Me.PanelCoup.Size = New System.Drawing.Size(132, 41)
        Me.PanelCoup.TabIndex = 42
        '
        'RN2
        '
        Me.RN2.AutoSize = True
        Me.RN2.Location = New System.Drawing.Point(74, 13)
        Me.RN2.Name = "RN2"
        Me.RN2.Size = New System.Drawing.Size(45, 17)
        Me.RN2.TabIndex = 1
        Me.RN2.TabStop = True
        Me.RN2.Text = "Non"
        Me.RN2.UseVisualStyleBackColor = True
        '
        'RO2
        '
        Me.RO2.AutoSize = True
        Me.RO2.Location = New System.Drawing.Point(12, 13)
        Me.RO2.Name = "RO2"
        Me.RO2.Size = New System.Drawing.Size(41, 17)
        Me.RO2.TabIndex = 0
        Me.RO2.TabStop = True
        Me.RO2.Text = "Oui"
        Me.RO2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Nombre de coups autorisés"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Nouveaux Caracteres Jouables (5)"
        '
        'PnlTimerCache
        '
        Me.PnlTimerCache.Controls.Add(Me.BtnValidTimer)
        Me.PnlTimerCache.Controls.Add(Me.CbxChoixTemps)
        Me.PnlTimerCache.Controls.Add(Me.Label4)
        Me.PnlTimerCache.Location = New System.Drawing.Point(114, 142)
        Me.PnlTimerCache.Name = "PnlTimerCache"
        Me.PnlTimerCache.Size = New System.Drawing.Size(404, 27)
        Me.PnlTimerCache.TabIndex = 48
        Me.PnlTimerCache.Visible = False
        '
        'BtnValidTimer
        '
        Me.BtnValidTimer.Location = New System.Drawing.Point(328, 3)
        Me.BtnValidTimer.Name = "BtnValidTimer"
        Me.BtnValidTimer.Size = New System.Drawing.Size(53, 22)
        Me.BtnValidTimer.TabIndex = 48
        Me.BtnValidTimer.Text = "Valider"
        Me.BtnValidTimer.UseVisualStyleBackColor = True
        '
        'PnlCoupCache
        '
        Me.PnlCoupCache.Controls.Add(Me.BtnValidCoup)
        Me.PnlCoupCache.Controls.Add(Me.TxtNbrCoup)
        Me.PnlCoupCache.Controls.Add(Me.Label5)
        Me.PnlCoupCache.Location = New System.Drawing.Point(102, 257)
        Me.PnlCoupCache.Name = "PnlCoupCache"
        Me.PnlCoupCache.Size = New System.Drawing.Size(416, 30)
        Me.PnlCoupCache.TabIndex = 46
        Me.PnlCoupCache.Visible = False
        '
        'BtnValidCoup
        '
        Me.BtnValidCoup.Location = New System.Drawing.Point(340, 4)
        Me.BtnValidCoup.Name = "BtnValidCoup"
        Me.BtnValidCoup.Size = New System.Drawing.Size(53, 22)
        Me.BtnValidCoup.TabIndex = 49
        Me.BtnValidCoup.Text = "Valider"
        Me.BtnValidCoup.UseVisualStyleBackColor = True
        '
        'PnlCaraCache
        '
        Me.PnlCaraCache.Controls.Add(Me.BtnValidCara)
        Me.PnlCaraCache.Controls.Add(Me.TxtCaraChange)
        Me.PnlCaraCache.Controls.Add(Me.Label6)
        Me.PnlCaraCache.Location = New System.Drawing.Point(30, 371)
        Me.PnlCaraCache.Name = "PnlCaraCache"
        Me.PnlCaraCache.Size = New System.Drawing.Size(488, 25)
        Me.PnlCaraCache.TabIndex = 49
        Me.PnlCaraCache.Visible = False
        '
        'BtnValidCara
        '
        Me.BtnValidCara.Location = New System.Drawing.Point(412, 2)
        Me.BtnValidCara.Name = "BtnValidCara"
        Me.BtnValidCara.Size = New System.Drawing.Size(53, 22)
        Me.BtnValidCara.TabIndex = 50
        Me.BtnValidCara.Text = "Valider"
        Me.BtnValidCara.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(132, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Changer de Nom : "
        '
        'TxtNomJoueur
        '
        Me.TxtNomJoueur.Location = New System.Drawing.Point(302, 469)
        Me.TxtNomJoueur.MaxLength = 500
        Me.TxtNomJoueur.Multiline = True
        Me.TxtNomJoueur.Name = "TxtNomJoueur"
        Me.TxtNomJoueur.Size = New System.Drawing.Size(113, 20)
        Me.TxtNomJoueur.TabIndex = 51
        Me.TxtNomJoueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblNomActu
        '
        Me.LblNomActu.AutoSize = True
        Me.LblNomActu.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomActu.Location = New System.Drawing.Point(311, 439)
        Me.LblNomActu.Name = "LblNomActu"
        Me.LblNomActu.Size = New System.Drawing.Size(89, 16)
        Me.LblNomActu.TabIndex = 49
        Me.LblNomActu.Text = "Nom Actuelle"
        '
        'BtnValidNom
        '
        Me.BtnValidNom.Location = New System.Drawing.Point(321, 503)
        Me.BtnValidNom.Name = "BtnValidNom"
        Me.BtnValidNom.Size = New System.Drawing.Size(79, 22)
        Me.BtnValidNom.TabIndex = 51
        Me.BtnValidNom.Text = "Valider"
        Me.BtnValidNom.UseVisualStyleBackColor = True
        '
        'FormulaireConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 537)
        Me.Controls.Add(Me.BtnValidNom)
        Me.Controls.Add(Me.LblNomActu)
        Me.Controls.Add(Me.TxtNomJoueur)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PnlCaraCache)
        Me.Controls.Add(Me.PnlCoupCache)
        Me.Controls.Add(Me.PnlTimerCache)
        Me.Controls.Add(Me.PanelCoup)
        Me.Controls.Add(Me.PanelCaractere)
        Me.Controls.Add(Me.PanelTimer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormulaireConfig"
        Me.Text = "Configuration "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTimer.ResumeLayout(False)
        Me.PanelTimer.PerformLayout()
        Me.PanelCaractere.ResumeLayout(False)
        Me.PanelCaractere.PerformLayout()
        Me.PanelCoup.ResumeLayout(False)
        Me.PanelCoup.PerformLayout()
        Me.PnlTimerCache.ResumeLayout(False)
        Me.PnlTimerCache.PerformLayout()
        Me.PnlCoupCache.ResumeLayout(False)
        Me.PnlCoupCache.PerformLayout()
        Me.PnlCaraCache.ResumeLayout(False)
        Me.PnlCaraCache.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Titre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelTimer As Panel
    Friend WithEvents RN1 As RadioButton
    Friend WithEvents RO1 As RadioButton
    Friend WithEvents TxtNbrCoup As TextBox
    Friend WithEvents TxtCaraChange As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbxChoixTemps As ComboBox
    Friend WithEvents PanelCaractere As Panel
    Friend WithEvents RN3 As RadioButton
    Friend WithEvents RO3 As RadioButton
    Friend WithEvents PanelCoup As Panel
    Friend WithEvents RN2 As RadioButton
    Friend WithEvents RO2 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PnlTimerCache As Panel
    Friend WithEvents PnlCoupCache As Panel
    Friend WithEvents PnlCaraCache As Panel
    Friend WithEvents BtnValidTimer As Button
    Friend WithEvents BtnValidCoup As Button
    Friend WithEvents BtnValidCara As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNomJoueur As TextBox
    Friend WithEvents LblNomActu As Label
    Friend WithEvents BtnValidNom As Button
End Class
