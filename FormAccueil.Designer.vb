<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.cbxNomJoueur2 = New System.Windows.Forms.ComboBox()
        Me.cbxNomJoueur1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(126, 157)
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
        Me.btnQuitter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Location = New System.Drawing.Point(40, 261)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(132, 36)
        Me.btnQuitter.TabIndex = 12
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.Color.Green
        Me.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJouer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnJouer.ForeColor = System.Drawing.Color.White
        Me.btnJouer.Location = New System.Drawing.Point(201, 261)
        Me.btnJouer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(166, 36)
        Me.btnJouer.TabIndex = 11
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.Goldenrod
        Me.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStats.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStats.ForeColor = System.Drawing.Color.White
        Me.btnStats.Location = New System.Drawing.Point(396, 261)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(132, 36)
        Me.btnStats.TabIndex = 13
        Me.btnStats.Text = "Statistique"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'cbxNomJoueur2
        '
        Me.cbxNomJoueur2.FormattingEnabled = True
        Me.cbxNomJoueur2.Location = New System.Drawing.Point(234, 204)
        Me.cbxNomJoueur2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxNomJoueur2.Name = "cbxNomJoueur2"
        Me.cbxNomJoueur2.Size = New System.Drawing.Size(207, 23)
        Me.cbxNomJoueur2.TabIndex = 10
        '
        'cbxNomJoueur1
        '
        Me.cbxNomJoueur1.FormattingEnabled = True
        Me.cbxNomJoueur1.Location = New System.Drawing.Point(234, 158)
        Me.cbxNomJoueur1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxNomJoueur1.Name = "cbxNomJoueur1"
        Me.cbxNomJoueur1.Size = New System.Drawing.Size(207, 23)
        Me.cbxNomJoueur1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(61, 112)
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
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(158, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 52)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 89)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(126, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Joueur 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 316)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(591, 355)
        Me.Name = "FormJoueur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJoueur"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
