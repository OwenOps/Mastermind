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
        Me.PanelCaractere = New System.Windows.Forms.Panel()
        Me.RN3 = New System.Windows.Forms.RadioButton()
        Me.RO3 = New System.Windows.Forms.RadioButton()
        Me.PanelCoup = New System.Windows.Forms.Panel()
        Me.RN2 = New System.Windows.Forms.RadioButton()
        Me.RO2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PnlTimerCache = New System.Windows.Forms.Panel()
        Me.TxtTempsSec = New System.Windows.Forms.TextBox()
        Me.TxtTempsMin = New System.Windows.Forms.TextBox()
        Me.BtnValidTimer = New System.Windows.Forms.Button()
        Me.PnlCoupCache = New System.Windows.Forms.Panel()
        Me.BtnValidCoup = New System.Windows.Forms.Button()
        Me.PnlCaraCache = New System.Windows.Forms.Panel()
        Me.BtnValidCara = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblNomActu = New System.Windows.Forms.Label()
        Me.BtnValidNom = New System.Windows.Forms.Button()
        Me.PnlNomCache = New System.Windows.Forms.Panel()
        Me.cbxNomJoueurChange = New System.Windows.Forms.ComboBox()
        Me.PanelNom = New System.Windows.Forms.Panel()
        Me.RN4 = New System.Windows.Forms.RadioButton()
        Me.RO4 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.PnlRadioBtn = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTimer.SuspendLayout()
        Me.PanelCaractere.SuspendLayout()
        Me.PanelCoup.SuspendLayout()
        Me.PnlTimerCache.SuspendLayout()
        Me.PnlCoupCache.SuspendLayout()
        Me.PnlCaraCache.SuspendLayout()
        Me.PnlNomCache.SuspendLayout()
        Me.PanelNom.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRadioBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 154)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activer le Timer : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Changer le Nombre Coups Possible"
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Maroon
        Me.Titre.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Titre.ForeColor = System.Drawing.Color.Transparent
        Me.Titre.Location = New System.Drawing.Point(348, 10)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(285, 66)
        Me.Titre.TabIndex = 39
        Me.Titre.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-27, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1068, 84)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Changer les Caractères Jouables"
        '
        'PanelTimer
        '
        Me.PanelTimer.Controls.Add(Me.RN1)
        Me.PanelTimer.Controls.Add(Me.RO1)
        Me.PanelTimer.Location = New System.Drawing.Point(7, 7)
        Me.PanelTimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTimer.Name = "PanelTimer"
        Me.PanelTimer.Size = New System.Drawing.Size(133, 30)
        Me.PanelTimer.TabIndex = 0
        '
        'RN1
        '
        Me.RN1.AutoSize = True
        Me.RN1.Location = New System.Drawing.Point(75, 4)
        Me.RN1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RN1.Name = "RN1"
        Me.RN1.Size = New System.Drawing.Size(53, 20)
        Me.RN1.TabIndex = 0
        Me.RN1.Text = "Non"
        Me.RN1.UseVisualStyleBackColor = True
        '
        'RO1
        '
        Me.RO1.AutoSize = True
        Me.RO1.Location = New System.Drawing.Point(13, 5)
        Me.RO1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RO1.Name = "RO1"
        Me.RO1.Size = New System.Drawing.Size(48, 20)
        Me.RO1.TabIndex = 1
        Me.RO1.Text = "Oui"
        Me.RO1.UseVisualStyleBackColor = True
        '
        'TxtNbrCoup
        '
        Me.TxtNbrCoup.Location = New System.Drawing.Point(188, 7)
        Me.TxtNbrCoup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNbrCoup.MaxLength = 6
        Me.TxtNbrCoup.Name = "TxtNbrCoup"
        Me.TxtNbrCoup.Size = New System.Drawing.Size(123, 22)
        Me.TxtNbrCoup.TabIndex = 42
        Me.TxtNbrCoup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCaraChange
        '
        Me.TxtCaraChange.Location = New System.Drawing.Point(228, 4)
        Me.TxtCaraChange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCaraChange.MaxLength = 5
        Me.TxtCaraChange.Name = "TxtCaraChange"
        Me.TxtCaraChange.Size = New System.Drawing.Size(123, 22)
        Me.TxtCaraChange.TabIndex = 43
        Me.TxtCaraChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Durée du timer (en min et sec) :"
        '
        'PanelCaractere
        '
        Me.PanelCaractere.Controls.Add(Me.RN3)
        Me.PanelCaractere.Controls.Add(Me.RO3)
        Me.PanelCaractere.Location = New System.Drawing.Point(4, 142)
        Me.PanelCaractere.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCaractere.Name = "PanelCaractere"
        Me.PanelCaractere.Size = New System.Drawing.Size(136, 30)
        Me.PanelCaractere.TabIndex = 42
        '
        'RN3
        '
        Me.RN3.AutoSize = True
        Me.RN3.Location = New System.Drawing.Point(77, 5)
        Me.RN3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RN3.Name = "RN3"
        Me.RN3.Size = New System.Drawing.Size(53, 20)
        Me.RN3.TabIndex = 1
        Me.RN3.Text = "Non"
        Me.RN3.UseVisualStyleBackColor = True
        '
        'RO3
        '
        Me.RO3.AutoSize = True
        Me.RO3.Location = New System.Drawing.Point(12, 5)
        Me.RO3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RO3.Name = "RO3"
        Me.RO3.Size = New System.Drawing.Size(48, 20)
        Me.RO3.TabIndex = 0
        Me.RO3.Text = "Oui"
        Me.RO3.UseVisualStyleBackColor = True
        '
        'PanelCoup
        '
        Me.PanelCoup.Controls.Add(Me.RN2)
        Me.PanelCoup.Controls.Add(Me.RO2)
        Me.PanelCoup.Location = New System.Drawing.Point(7, 74)
        Me.PanelCoup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCoup.Name = "PanelCoup"
        Me.PanelCoup.Size = New System.Drawing.Size(133, 34)
        Me.PanelCoup.TabIndex = 42
        '
        'RN2
        '
        Me.RN2.AutoSize = True
        Me.RN2.Location = New System.Drawing.Point(76, 9)
        Me.RN2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RN2.Name = "RN2"
        Me.RN2.Size = New System.Drawing.Size(53, 20)
        Me.RN2.TabIndex = 1
        Me.RN2.Text = "Non"
        Me.RN2.UseVisualStyleBackColor = True
        '
        'RO2
        '
        Me.RO2.AutoSize = True
        Me.RO2.Location = New System.Drawing.Point(12, 9)
        Me.RO2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RO2.Name = "RO2"
        Me.RO2.Size = New System.Drawing.Size(48, 20)
        Me.RO2.TabIndex = 0
        Me.RO2.Text = "Oui"
        Me.RO2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Nombre de coups :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(4, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 19)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Caracteres Jouables (5) : "
        '
        'PnlTimerCache
        '
        Me.PnlTimerCache.Controls.Add(Me.TxtTempsSec)
        Me.PnlTimerCache.Controls.Add(Me.TxtTempsMin)
        Me.PnlTimerCache.Controls.Add(Me.BtnValidTimer)
        Me.PnlTimerCache.Controls.Add(Me.Label4)
        Me.PnlTimerCache.Location = New System.Drawing.Point(532, 144)
        Me.PnlTimerCache.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlTimerCache.Name = "PnlTimerCache"
        Me.PnlTimerCache.Size = New System.Drawing.Size(471, 33)
        Me.PnlTimerCache.TabIndex = 48
        Me.PnlTimerCache.Visible = False
        '
        'TxtTempsSec
        '
        Me.TxtTempsSec.Location = New System.Drawing.Point(335, 5)
        Me.TxtTempsSec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTempsSec.MaxLength = 10
        Me.TxtTempsSec.Name = "TxtTempsSec"
        Me.TxtTempsSec.Size = New System.Drawing.Size(40, 22)
        Me.TxtTempsSec.TabIndex = 51
        Me.TxtTempsSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTempsMin
        '
        Me.TxtTempsMin.Location = New System.Drawing.Point(285, 5)
        Me.TxtTempsMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTempsMin.MaxLength = 10
        Me.TxtTempsMin.Name = "TxtTempsMin"
        Me.TxtTempsMin.Size = New System.Drawing.Size(40, 22)
        Me.TxtTempsMin.TabIndex = 50
        Me.TxtTempsMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnValidTimer
        '
        Me.BtnValidTimer.Location = New System.Drawing.Point(384, 5)
        Me.BtnValidTimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnValidTimer.Name = "BtnValidTimer"
        Me.BtnValidTimer.Size = New System.Drawing.Size(71, 25)
        Me.BtnValidTimer.TabIndex = 48
        Me.BtnValidTimer.Text = "Valider"
        Me.BtnValidTimer.UseVisualStyleBackColor = True
        '
        'PnlCoupCache
        '
        Me.PnlCoupCache.Controls.Add(Me.BtnValidCoup)
        Me.PnlCoupCache.Controls.Add(Me.TxtNbrCoup)
        Me.PnlCoupCache.Controls.Add(Me.Label5)
        Me.PnlCoupCache.Location = New System.Drawing.Point(532, 214)
        Me.PnlCoupCache.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlCoupCache.Name = "PnlCoupCache"
        Me.PnlCoupCache.Size = New System.Drawing.Size(467, 37)
        Me.PnlCoupCache.TabIndex = 46
        Me.PnlCoupCache.Visible = False
        '
        'BtnValidCoup
        '
        Me.BtnValidCoup.Location = New System.Drawing.Point(384, 5)
        Me.BtnValidCoup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnValidCoup.Name = "BtnValidCoup"
        Me.BtnValidCoup.Size = New System.Drawing.Size(71, 25)
        Me.BtnValidCoup.TabIndex = 49
        Me.BtnValidCoup.Text = "Valider"
        Me.BtnValidCoup.UseVisualStyleBackColor = True
        '
        'PnlCaraCache
        '
        Me.PnlCaraCache.Controls.Add(Me.BtnValidCara)
        Me.PnlCaraCache.Controls.Add(Me.TxtCaraChange)
        Me.PnlCaraCache.Controls.Add(Me.Label6)
        Me.PnlCaraCache.Location = New System.Drawing.Point(532, 282)
        Me.PnlCaraCache.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlCaraCache.Name = "PnlCaraCache"
        Me.PnlCaraCache.Size = New System.Drawing.Size(467, 32)
        Me.PnlCaraCache.TabIndex = 49
        Me.PnlCaraCache.Visible = False
        '
        'BtnValidCara
        '
        Me.BtnValidCara.Location = New System.Drawing.Point(384, 2)
        Me.BtnValidCara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnValidCara.Name = "BtnValidCara"
        Me.BtnValidCara.Size = New System.Drawing.Size(71, 25)
        Me.BtnValidCara.TabIndex = 50
        Me.BtnValidCara.Text = "Valider"
        Me.BtnValidCara.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(16, 351)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 21)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Changer un Nom de la liste"
        '
        'LblNomActu
        '
        Me.LblNomActu.AutoSize = True
        Me.LblNomActu.Font = New System.Drawing.Font("Bookman Old Style", 9.0!)
        Me.LblNomActu.Location = New System.Drawing.Point(4, 7)
        Me.LblNomActu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNomActu.Name = "LblNomActu"
        Me.LblNomActu.Size = New System.Drawing.Size(227, 19)
        Me.LblNomActu.TabIndex = 49
        Me.LblNomActu.Text = "Veuillez sectionner un nom :"
        '
        'BtnValidNom
        '
        Me.BtnValidNom.Location = New System.Drawing.Point(387, 2)
        Me.BtnValidNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnValidNom.Name = "BtnValidNom"
        Me.BtnValidNom.Size = New System.Drawing.Size(71, 25)
        Me.BtnValidNom.TabIndex = 51
        Me.BtnValidNom.Text = "Valider"
        Me.BtnValidNom.UseVisualStyleBackColor = True
        '
        'PnlNomCache
        '
        Me.PnlNomCache.Controls.Add(Me.cbxNomJoueurChange)
        Me.PnlNomCache.Controls.Add(Me.LblNomActu)
        Me.PnlNomCache.Controls.Add(Me.BtnValidNom)
        Me.PnlNomCache.Location = New System.Drawing.Point(532, 353)
        Me.PnlNomCache.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlNomCache.Name = "PnlNomCache"
        Me.PnlNomCache.Size = New System.Drawing.Size(493, 32)
        Me.PnlNomCache.TabIndex = 52
        Me.PnlNomCache.Visible = False
        '
        'cbxNomJoueurChange
        '
        Me.cbxNomJoueurChange.FormattingEnabled = True
        Me.cbxNomJoueurChange.Location = New System.Drawing.Point(255, 2)
        Me.cbxNomJoueurChange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxNomJoueurChange.Name = "cbxNomJoueurChange"
        Me.cbxNomJoueurChange.Size = New System.Drawing.Size(123, 24)
        Me.cbxNomJoueurChange.TabIndex = 53
        '
        'PanelNom
        '
        Me.PanelNom.Controls.Add(Me.RN4)
        Me.PanelNom.Controls.Add(Me.RO4)
        Me.PanelNom.Location = New System.Drawing.Point(4, 208)
        Me.PanelNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelNom.Name = "PanelNom"
        Me.PanelNom.Size = New System.Drawing.Size(136, 30)
        Me.PanelNom.TabIndex = 43
        '
        'RN4
        '
        Me.RN4.AutoSize = True
        Me.RN4.Location = New System.Drawing.Point(76, 5)
        Me.RN4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RN4.Name = "RN4"
        Me.RN4.Size = New System.Drawing.Size(53, 20)
        Me.RN4.TabIndex = 1
        Me.RN4.Text = "Non"
        Me.RN4.UseVisualStyleBackColor = True
        '
        'RO4
        '
        Me.RO4.AutoSize = True
        Me.RO4.Location = New System.Drawing.Point(12, 5)
        Me.RO4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RO4.Name = "RO4"
        Me.RO4.Size = New System.Drawing.Size(48, 20)
        Me.RO4.TabIndex = 0
        Me.RO4.Text = "Oui"
        Me.RO4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Sylfaen", 14.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(439, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 31)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Option"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Silver
        Me.PictureBox2.Location = New System.Drawing.Point(346, 79)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 32)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(308, 418)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(85, 25)
        Me.btnRetour.TabIndex = 55
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(445, 418)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(128, 25)
        Me.BtnReset.TabIndex = 56
        Me.BtnReset.Text = "Reset (Default)"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'PnlRadioBtn
        '
        Me.PnlRadioBtn.Controls.Add(Me.PanelNom)
        Me.PnlRadioBtn.Controls.Add(Me.PanelCaractere)
        Me.PnlRadioBtn.Controls.Add(Me.PanelCoup)
        Me.PnlRadioBtn.Controls.Add(Me.PanelTimer)
        Me.PnlRadioBtn.Location = New System.Drawing.Point(360, 139)
        Me.PnlRadioBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlRadioBtn.Name = "PnlRadioBtn"
        Me.PnlRadioBtn.Size = New System.Drawing.Size(144, 241)
        Me.PnlRadioBtn.TabIndex = 57
        '
        'FormulaireConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 466)
        Me.Controls.Add(Me.PnlRadioBtn)
        Me.Controls.Add(Me.PnlCoupCache)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PnlCaraCache)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PnlNomCache)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PnlTimerCache)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.PnlNomCache.ResumeLayout(False)
        Me.PnlNomCache.PerformLayout()
        Me.PanelNom.ResumeLayout(False)
        Me.PanelNom.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRadioBtn.ResumeLayout(False)
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
    Friend WithEvents LblNomActu As Label
    Friend WithEvents BtnValidNom As Button
    Friend WithEvents TxtTempsMin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PnlNomCache As Panel
    Friend WithEvents cbxNomJoueurChange As ComboBox
    Friend WithEvents PanelNom As Panel
    Friend WithEvents RN4 As RadioButton
    Friend WithEvents RO4 As RadioButton
    Friend WithEvents btnRetour As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtTempsSec As TextBox
    Friend WithEvents PnlRadioBtn As Panel
End Class
