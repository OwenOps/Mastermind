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
        Me.LstCaraHisto = New System.Windows.Forms.RichTextBox()
        Me.PnlCaractereJoue.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 837)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(484, 896)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Absent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(484, 977)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Présent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(480, 1048)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Présent et Bien Placé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 837)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Caractères jouables"
        '
        'BtnGuess
        '
        Me.BtnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuess.Location = New System.Drawing.Point(290, 513)
        Me.BtnGuess.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnGuess.Name = "BtnGuess"
        Me.BtnGuess.Size = New System.Drawing.Size(146, 44)
        Me.BtnGuess.TabIndex = 11
        Me.BtnGuess.Text = "Guess"
        Me.BtnGuess.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(34, 37)
        Me.Txt1.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt1.MaxLength = 1
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(72, 31)
        Me.Txt1.TabIndex = 1
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(148, 37)
        Me.Txt2.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt2.MaxLength = 1
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(72, 31)
        Me.Txt2.TabIndex = 2
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(282, 37)
        Me.Txt3.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt3.MaxLength = 1
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(72, 31)
        Me.Txt3.TabIndex = 3
        Me.Txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(412, 37)
        Me.Txt4.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt4.MaxLength = 1
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(72, 31)
        Me.Txt4.TabIndex = 4
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(534, 37)
        Me.Txt5.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt5.MaxLength = 1
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(72, 31)
        Me.Txt5.TabIndex = 5
        Me.Txt5.Tag = "1"
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(894, 360)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 34)
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
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(52, 360)
        Me.PnlCaractereJoue.Margin = New System.Windows.Forms.Padding(6)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(640, 110)
        Me.PnlCaractereJoue.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 30)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Bonne chance"
        '
        'LblNomJoueur
        '
        Me.LblNomJoueur.AutoSize = True
        Me.LblNomJoueur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNomJoueur.Location = New System.Drawing.Point(382, 202)
        Me.LblNomJoueur.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblNomJoueur.Name = "LblNomJoueur"
        Me.LblNomJoueur.Size = New System.Drawing.Size(161, 25)
        Me.LblNomJoueur.TabIndex = 27
        Me.LblNomJoueur.Text = "NomDuJoueur !"
        '
        'LblBravoPerdu
        '
        Me.LblBravoPerdu.AutoSize = True
        Me.LblBravoPerdu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBravoPerdu.Location = New System.Drawing.Point(278, 606)
        Me.LblBravoPerdu.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBravoPerdu.Name = "LblBravoPerdu"
        Me.LblBravoPerdu.Size = New System.Drawing.Size(294, 37)
        Me.LblBravoPerdu.TabIndex = 28
        Me.LblBravoPerdu.Text = "Bravo ! ou Perdu !"
        Me.LblBravoPerdu.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 758)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 44)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Les règles"
        '
        'BtnBye
        '
        Me.BtnBye.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBye.Location = New System.Drawing.Point(1032, 1033)
        Me.BtnBye.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnBye.Name = "BtnBye"
        Me.BtnBye.Size = New System.Drawing.Size(146, 44)
        Me.BtnBye.TabIndex = 30
        Me.BtnBye.Text = "Bye"
        Me.BtnBye.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(864, 202)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 30)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Il te reste : "
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(1064, 202)
        Me.LblTimer.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(66, 25)
        Me.LblTimer.TabIndex = 32
        Me.LblTimer.Text = "Timer"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(870, 263)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(308, 31)
        Me.ProgressBar1.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(406, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(457, 105)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-30, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1410, 148)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'CaraJouable
        '
        Me.CaraJouable.AutoSize = True
        Me.CaraJouable.Location = New System.Drawing.Point(112, 896)
        Me.CaraJouable.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.CaraJouable.Name = "CaraJouable"
        Me.CaraJouable.Size = New System.Drawing.Size(134, 25)
        Me.CaraJouable.TabIndex = 36
        Me.CaraJouable.Text = "CaraJouable"
        '
        'LstCaraHisto
        '
        Me.LstCaraHisto.Location = New System.Drawing.Point(900, 433)
        Me.LstCaraHisto.Margin = New System.Windows.Forms.Padding(6)
        Me.LstCaraHisto.MaxLength = 100000000
        Me.LstCaraHisto.Name = "LstCaraHisto"
        Me.LstCaraHisto.ReadOnly = True
        Me.LstCaraHisto.Size = New System.Drawing.Size(274, 462)
        Me.LstCaraHisto.TabIndex = 37
        Me.LstCaraHisto.Text = ""
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 1136)
        Me.Controls.Add(Me.LstCaraHisto)
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
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximumSize = New System.Drawing.Size(1284, 1207)
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
    Friend WithEvents LstCaraHisto As RichTextBox
End Class
