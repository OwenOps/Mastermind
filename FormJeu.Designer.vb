<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
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
        Me.components = New System.ComponentModel.Container()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblNomJoueur = New System.Windows.Forms.Label()
        Me.LblBravoPerdu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LblTimerReste = New System.Windows.Forms.Label()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.ProgressBarJeu = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCaraJouable = New System.Windows.Forms.Label()
        Me.LstCaraHisto = New System.Windows.Forms.RichTextBox()
        Me.TimerJeu = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblDifficulte = New System.Windows.Forms.Label()
        Me.PnlCaractereJoue.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(233, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(255, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Absent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(255, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Présent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(214, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Présent et Bien Placé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(46, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Caractères jouables"
        '
        'BtnGuess
        '
        Me.BtnGuess.BackColor = System.Drawing.Color.Green
        Me.BtnGuess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuess.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuess.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuess.Location = New System.Drawing.Point(112, 249)
        Me.BtnGuess.Name = "BtnGuess"
        Me.BtnGuess.Size = New System.Drawing.Size(148, 32)
        Me.BtnGuess.TabIndex = 11
        Me.BtnGuess.Text = "Guess"
        Me.BtnGuess.UseVisualStyleBackColor = False
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
        Me.Txt2.Location = New System.Drawing.Point(76, 19)
        Me.Txt2.MaxLength = 1
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(38, 20)
        Me.Txt2.TabIndex = 2
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(136, 19)
        Me.Txt3.MaxLength = 1
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(38, 20)
        Me.Txt3.TabIndex = 3
        Me.Txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(197, 19)
        Me.Txt4.MaxLength = 1
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(38, 20)
        Me.Txt4.TabIndex = 4
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(257, 19)
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
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(394, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Précédents essais"
        '
        'PnlCaractereJoue
        '
        Me.PnlCaractereJoue.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PnlCaractereJoue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCaractereJoue.Controls.Add(Me.Txt5)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt1)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt4)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt2)
        Me.PnlCaractereJoue.Controls.Add(Me.Txt3)
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(30, 170)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(320, 62)
        Me.PnlCaractereJoue.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label8.Location = New System.Drawing.Point(92, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Bonne chance"
        '
        'LblNomJoueur
        '
        Me.LblNomJoueur.AutoSize = True
        Me.LblNomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.LblNomJoueur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNomJoueur.Location = New System.Drawing.Point(206, 98)
        Me.LblNomJoueur.Name = "LblNomJoueur"
        Me.LblNomJoueur.Size = New System.Drawing.Size(112, 20)
        Me.LblNomJoueur.TabIndex = 27
        Me.LblNomJoueur.Text = "NomDuJoueur"
        '
        'LblBravoPerdu
        '
        Me.LblBravoPerdu.AutoSize = True
        Me.LblBravoPerdu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBravoPerdu.Location = New System.Drawing.Point(33, 134)
        Me.LblBravoPerdu.Name = "LblBravoPerdu"
        Me.LblBravoPerdu.Size = New System.Drawing.Size(155, 18)
        Me.LblBravoPerdu.TabIndex = 28
        Me.LblBravoPerdu.Text = "Gagné ! ou Perdu !"
        Me.LblBravoPerdu.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(105, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Quelques précisions"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(112, 250)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 31)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'LblTimerReste
        '
        Me.LblTimerReste.AutoSize = True
        Me.LblTimerReste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LblTimerReste.Location = New System.Drawing.Point(385, 101)
        Me.LblTimerReste.Name = "LblTimerReste"
        Me.LblTimerReste.Size = New System.Drawing.Size(79, 18)
        Me.LblTimerReste.TabIndex = 31
        Me.LblTimerReste.Text = "Il te reste : "
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LblTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTimer.Location = New System.Drawing.Point(456, 101)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(46, 18)
        Me.LblTimer.TabIndex = 32
        Me.LblTimer.Text = "Timer"
        '
        'ProgressBarJeu
        '
        Me.ProgressBarJeu.Location = New System.Drawing.Point(385, 131)
        Me.ProgressBarJeu.Name = "ProgressBarJeu"
        Me.ProgressBarJeu.Size = New System.Drawing.Size(167, 17)
        Me.ProgressBarJeu.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-33, -6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(614, 80)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LblCaraJouable
        '
        Me.LblCaraJouable.AutoSize = True
        Me.LblCaraJouable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaraJouable.Location = New System.Drawing.Point(46, 391)
        Me.LblCaraJouable.Name = "LblCaraJouable"
        Me.LblCaraJouable.Size = New System.Drawing.Size(97, 16)
        Me.LblCaraJouable.TabIndex = 36
        Me.LblCaraJouable.Text = "CaraJouable"
        '
        'LstCaraHisto
        '
        Me.LstCaraHisto.Location = New System.Drawing.Point(400, 206)
        Me.LstCaraHisto.MaxLength = 100000000
        Me.LstCaraHisto.Name = "LstCaraHisto"
        Me.LstCaraHisto.ReadOnly = True
        Me.LstCaraHisto.Size = New System.Drawing.Size(139, 242)
        Me.LstCaraHisto.TabIndex = 37
        Me.LstCaraHisto.Text = ""
        '
        'TimerJeu
        '
        Me.TimerJeu.Enabled = True
        Me.TimerJeu.Interval = 1000
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Maroon
        Me.Label11.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(182, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(228, 52)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "MasterMind"
        '
        'LblDifficulte
        '
        Me.LblDifficulte.AutoSize = True
        Me.LblDifficulte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDifficulte.ForeColor = System.Drawing.Color.Gray
        Me.LblDifficulte.Location = New System.Drawing.Point(1, 77)
        Me.LblDifficulte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDifficulte.Name = "LblDifficulte"
        Me.LblDifficulte.Size = New System.Drawing.Size(70, 19)
        Me.LblDifficulte.TabIndex = 53
        Me.LblDifficulte.Text = "Difficulté"
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 465)
        Me.Controls.Add(Me.LblDifficulte)
        Me.Controls.Add(Me.LstCaraHisto)
        Me.Controls.Add(Me.LblCaraJouable)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBarJeu)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.LblTimerReste)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblBravoPerdu)
        Me.Controls.Add(Me.LblNomJoueur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MaximumSize = New System.Drawing.Size(594, 510)
        Me.Name = "FormJeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partie"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents LblNomJoueur As Label
    Friend WithEvents LblBravoPerdu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents LblTimerReste As Label
    Friend WithEvents LblTimer As Label
    Friend WithEvents ProgressBarJeu As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblCaraJouable As Label
    Friend WithEvents LstCaraHisto As RichTextBox
    Friend WithEvents TimerJeu As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents LblDifficulte As Label
End Class
