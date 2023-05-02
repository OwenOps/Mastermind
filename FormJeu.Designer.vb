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
        Me.BtnGuess = New System.Windows.Forms.Button()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlCaractereJoue = New System.Windows.Forms.Panel()
        Me.LstCaratereHistorique = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblNomJoueur = New System.Windows.Forms.Label()
        Me.LblBravoPerdu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnBye = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CaraJouable = New System.Windows.Forms.Label()
        Me.PnlCaractereJoue.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 466)
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
        Me.Label4.Location = New System.Drawing.Point(242, 508)
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
        Me.Label5.Location = New System.Drawing.Point(240, 545)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Présent et Bien Placé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Caractères jouables"
        '
        'BtnGuess
        '
        Me.BtnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuess.Location = New System.Drawing.Point(145, 267)
        Me.BtnGuess.Name = "BtnGuess"
        Me.BtnGuess.Size = New System.Drawing.Size(73, 23)
        Me.BtnGuess.TabIndex = 11
        Me.BtnGuess.Text = "Guess"
        Me.BtnGuess.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(17, 19)
        Me.Txt1.MaxLength = 1
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(38, 20)
        Me.Txt1.TabIndex = 1
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(74, 19)
        Me.Txt2.MaxLength = 1
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(38, 20)
        Me.Txt2.TabIndex = 2
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(141, 19)
        Me.Txt3.MaxLength = 1
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(38, 20)
        Me.Txt3.TabIndex = 3
        Me.Txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(206, 19)
        Me.Txt4.MaxLength = 1
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(38, 20)
        Me.Txt4.TabIndex = 4
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(267, 19)
        Me.Txt5.MaxLength = 1
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(38, 20)
        Me.Txt5.TabIndex = 5
        Me.Txt5.Tag = "1"
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'PnlCaractereJoue
        '
        Me.PnlCaractereJoue.BackColor = System.Drawing.SystemColors.Menu
        Me.PnlCaractereJoue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCaractereJoue.Controls.Add(Me.Txt5)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt1)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt4)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt2)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt3)
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(26, 187)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(322, 59)
        Me.PnlCaractereJoue.TabIndex = 6
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
        'LblNomJoueur
        '
        Me.LblNomJoueur.AutoSize = True
        Me.LblNomJoueur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNomJoueur.Location = New System.Drawing.Point(191, 105)
        Me.LblNomJoueur.Name = "LblNomJoueur"
        Me.LblNomJoueur.Size = New System.Drawing.Size(81, 13)
        Me.LblNomJoueur.TabIndex = 27
        Me.LblNomJoueur.Text = "NomDuJoueur !"
        '
        'LblBravoPerdu
        '
        Me.LblBravoPerdu.AutoSize = True
        Me.LblBravoPerdu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBravoPerdu.Location = New System.Drawing.Point(139, 315)
        Me.LblBravoPerdu.Name = "LblBravoPerdu"
        Me.LblBravoPerdu.Size = New System.Drawing.Size(150, 18)
        Me.LblBravoPerdu.TabIndex = 28
        Me.LblBravoPerdu.Text = "Bravo ! ou Perdu !"
        Me.LblBravoPerdu.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(156, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 22)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Les règles"
        '
        'BtnBye
        '
        Me.BtnBye.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBye.Location = New System.Drawing.Point(516, 537)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(203, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 52)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-15, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(705, 77)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'CaraJouable
        '
        Me.CaraJouable.AutoSize = True
        Me.CaraJouable.Location = New System.Drawing.Point(56, 466)
        Me.CaraJouable.Name = "CaraJouable"
        Me.CaraJouable.Size = New System.Drawing.Size(66, 13)
        Me.CaraJouable.TabIndex = 36
        Me.CaraJouable.Text = "CaraJouable"
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 575)
        Me.Controls.Add(Me.CaraJouable)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnBye)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblBravoPerdu)
        Me.Controls.Add(Me.LblNomJoueur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LstCaratereHistorique)
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximumSize = New System.Drawing.Size(632, 614)
        Me.Name = "FormJeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NbrCara"
        Me.PnlCaractereJoue.ResumeLayout(False)
        Me.PnlCaractereJoue.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnGuess As Button
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlCaractereJoue As Panel
    Friend WithEvents LstCaratereHistorique As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LblNomJoueur As Label
    Friend WithEvents LblBravoPerdu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnBye As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents LblTimer As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CaraJouable As Label
End Class
