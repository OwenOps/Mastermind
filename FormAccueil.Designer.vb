<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.cbxNomJoueur2 = New System.Windows.Forms.ComboBox()
        Me.cbxNomJoueur1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.PnlDiff = New System.Windows.Forms.Panel()
        Me.LblDifficulte = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDiff.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.Label2.Location = New System.Drawing.Point(122, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Joueur 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.Brown
        Me.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Location = New System.Drawing.Point(355, 336)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(130, 37)
        Me.btnQuitter.TabIndex = 12
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.Color.Green
        Me.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJouer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnJouer.ForeColor = System.Drawing.Color.White
        Me.btnJouer.Location = New System.Drawing.Point(96, 275)
        Me.btnJouer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(323, 37)
        Me.btnJouer.TabIndex = 11
        Me.btnJouer.Text = "C'est parti "
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.Goldenrod
        Me.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStats.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStats.ForeColor = System.Drawing.Color.White
        Me.btnStats.Location = New System.Drawing.Point(177, 336)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(157, 37)
        Me.btnStats.TabIndex = 13
        Me.btnStats.Text = "Statistiques"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'cbxNomJoueur2
        '
        Me.cbxNomJoueur2.FormattingEnabled = True
        Me.cbxNomJoueur2.Location = New System.Drawing.Point(211, 228)
        Me.cbxNomJoueur2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxNomJoueur2.Name = "cbxNomJoueur2"
        Me.cbxNomJoueur2.Size = New System.Drawing.Size(178, 21)
        Me.cbxNomJoueur2.TabIndex = 10
        '
        'cbxNomJoueur1
        '
        Me.cbxNomJoueur1.FormattingEnabled = True
        Me.cbxNomJoueur1.Location = New System.Drawing.Point(211, 179)
        Me.cbxNomJoueur1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxNomJoueur1.Name = "cbxNomJoueur1"
        Me.cbxNomJoueur1.Size = New System.Drawing.Size(178, 21)
        Me.cbxNomJoueur1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.Location = New System.Drawing.Point(41, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Avant de commencer, veuillez saisir les noms des 2 joueurs !"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(148, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 52)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(1, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 77)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.Label3.Location = New System.Drawing.Point(122, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Joueur 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.Gray
        Me.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetour.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRetour.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRetour.Location = New System.Drawing.Point(26, 336)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(130, 37)
        Me.btnRetour.TabIndex = 41
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'PnlDiff
        '
        Me.PnlDiff.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PnlDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDiff.Controls.Add(Me.LblDifficulte)
        Me.PnlDiff.ForeColor = System.Drawing.Color.Black
        Me.PnlDiff.Location = New System.Drawing.Point(188, 91)
        Me.PnlDiff.Name = "PnlDiff"
        Me.PnlDiff.Size = New System.Drawing.Size(109, 21)
        Me.PnlDiff.TabIndex = 53
        '
        'LblDifficulte
        '
        Me.LblDifficulte.AutoSize = True
        Me.LblDifficulte.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDifficulte.ForeColor = System.Drawing.Color.Gray
        Me.LblDifficulte.Location = New System.Drawing.Point(18, -1)
        Me.LblDifficulte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDifficulte.Name = "LblDifficulte"
        Me.LblDifficulte.Size = New System.Drawing.Size(77, 19)
        Me.LblDifficulte.TabIndex = 53
        Me.LblDifficulte.Text = "Difficulté"
        Me.LblDifficulte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Niveau de difficulté :"
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 392)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PnlDiff)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.cbxNomJoueur2)
        Me.Controls.Add(Me.cbxNomJoueur1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(528, 431)
        Me.Name = "FormAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDiff.ResumeLayout(False)
        Me.PnlDiff.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents cbxNomJoueur2 As ComboBox
    Friend WithEvents cbxNomJoueur1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents PnlDiff As Panel
    Friend WithEvents LblDifficulte As Label
    Friend WithEvents Label5 As Label
End Class