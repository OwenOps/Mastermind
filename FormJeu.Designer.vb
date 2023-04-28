<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonGuess = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCaractereJoué = New System.Windows.Forms.Panel()
        Me.LstCaratereHistorique = New System.Windows.Forms.ListBox()
        Me.ListeCaractereJouable = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.LblBravoPerdu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnBye = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PanelCaractereJoué.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Absent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(242, 540)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Présent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(240, 577)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Présent et Bien Placé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Caractères jouables"
        '
        'ButtonGuess
        '
        Me.ButtonGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGuess.Location = New System.Drawing.Point(145, 267)
        Me.ButtonGuess.Name = "ButtonGuess"
        Me.ButtonGuess.Size = New System.Drawing.Size(73, 23)
        Me.ButtonGuess.TabIndex = 11
        Me.ButtonGuess.Text = "Guess"
        Me.ButtonGuess.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 19)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(38, 20)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(71, 19)
        Me.TextBox6.MaxLength = 1
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(38, 20)
        Me.TextBox6.TabIndex = 17
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 19)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(38, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(194, 19)
        Me.TextBox3.MaxLength = 1
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(38, 20)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(256, 19)
        Me.TextBox4.MaxLength = 1
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(38, 20)
        Me.TextBox4.TabIndex = 20
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(447, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Precedents essais"
        '
        'PanelCaractereJoué
        '
        Me.PanelCaractereJoué.BackColor = System.Drawing.SystemColors.Menu
        Me.PanelCaractereJoué.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelCaractereJoué.Controls.Add(Me.TextBox2)
        Me.PanelCaractereJoué.Controls.Add(Me.TextBox6)
        Me.PanelCaractereJoué.Controls.Add(Me.TextBox4)
        Me.PanelCaractereJoué.Controls.Add(Me.TextBox1)
        Me.PanelCaractereJoué.Controls.Add(Me.TextBox3)
        Me.PanelCaractereJoué.Location = New System.Drawing.Point(26, 187)
        Me.PanelCaractereJoué.Name = "PanelCaractereJoué"
        Me.PanelCaractereJoué.Size = New System.Drawing.Size(312, 59)
        Me.PanelCaractereJoué.TabIndex = 22
        '
        'LstCaratereHistorique
        '
        Me.LstCaratereHistorique.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LstCaratereHistorique.FormattingEnabled = True
        Me.LstCaratereHistorique.Location = New System.Drawing.Point(450, 234)
        Me.LstCaratereHistorique.Name = "LstCaratereHistorique"
        Me.LstCaratereHistorique.Size = New System.Drawing.Size(139, 225)
        Me.LstCaratereHistorique.TabIndex = 21
        '
        'ListeCaractereJouable
        '
        Me.ListeCaractereJouable.BackColor = System.Drawing.SystemColors.Menu
        Me.ListeCaractereJouable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListeCaractereJouable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeCaractereJouable.FormattingEnabled = True
        Me.ListeCaractereJouable.ItemHeight = 15
        Me.ListeCaractereJouable.Location = New System.Drawing.Point(45, 498)
        Me.ListeCaractereJouable.Name = "ListeCaractereJouable"
        Me.ListeCaractereJouable.Size = New System.Drawing.Size(136, 30)
        Me.ListeCaractereJouable.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(234, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 52)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(-24, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(689, 68)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Bonne chance"
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelNomJoueur.Location = New System.Drawing.Point(191, 105)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(81, 13)
        Me.LabelNomJoueur.TabIndex = 27
        Me.LabelNomJoueur.Text = "NomDuJoueur !"
        '
        'LblBravoPerdu
        '
        Me.LblBravoPerdu.AutoSize = True
        Me.LblBravoPerdu.Location = New System.Drawing.Point(125, 330)
        Me.LblBravoPerdu.Name = "LblBravoPerdu"
        Me.LblBravoPerdu.Size = New System.Drawing.Size(93, 13)
        Me.LblBravoPerdu.TabIndex = 28
        Me.LblBravoPerdu.Text = "Bravo ! ou Perdu !"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 419)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 22)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Les règles"
        '
        'BtnBye
        '
        Me.BtnBye.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBye.Location = New System.Drawing.Point(516, 569)
        Me.BtnBye.Name = "BtnBye"
        Me.BtnBye.Size = New System.Drawing.Size(73, 23)
        Me.BtnBye.TabIndex = 30
        Me.BtnBye.Text = "Bye"
        Me.BtnBye.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(432, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Il te reste : "
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(532, 105)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(33, 13)
        Me.LblTimer.TabIndex = 32
        Me.LblTimer.Text = "Timer"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(435, 137)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(154, 16)
        Me.ProgressBar1.TabIndex = 33
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 608)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnBye)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblBravoPerdu)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListeCaractereJouable)
        Me.Controls.Add(Me.LstCaratereHistorique)
        Me.Controls.Add(Me.PanelCaractereJoué)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGuess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormJeu"
        Me.Text = "FormJeu"
        Me.PanelCaractereJoué.ResumeLayout(False)
        Me.PanelCaractereJoué.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonGuess As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCaractereJoué As Panel
    Friend WithEvents LstCaratereHistorique As ListBox
    Friend WithEvents ListeCaractereJouable As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelNomJoueur As Label
    Friend WithEvents LblBravoPerdu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnBye As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents LblTimer As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
