﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStat
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
        Me.cbxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.btnSortAlpha = New System.Windows.Forms.Button()
        Me.btnSortTemps = New System.Windows.Forms.Button()
        Me.btnSortScore = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelSORT = New System.Windows.Forms.Label()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelTEMPSCUMUL = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lstBox6 = New System.Windows.Forms.ListBox()
        Me.lstBox5 = New System.Windows.Forms.ListBox()
        Me.lstBox4 = New System.Windows.Forms.ListBox()
        Me.lstBox3 = New System.Windows.Forms.ListBox()
        Me.lstBox2 = New System.Windows.Forms.ListBox()
        Me.lstBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPodium2 = New System.Windows.Forms.Label()
        Me.lblPodium3 = New System.Windows.Forms.Label()
        Me.lblPodium1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlStats.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxNomJoueur
        '
        Me.cbxNomJoueur.FormattingEnabled = True
        Me.cbxNomJoueur.Location = New System.Drawing.Point(671, 639)
        Me.cbxNomJoueur.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxNomJoueur.Name = "cbxNomJoueur"
        Me.cbxNomJoueur.Size = New System.Drawing.Size(219, 24)
        Me.cbxNomJoueur.TabIndex = 0
        '
        'btnSortAlpha
        '
        Me.btnSortAlpha.BackColor = System.Drawing.Color.OliveDrab
        Me.btnSortAlpha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortAlpha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortAlpha.ForeColor = System.Drawing.Color.White
        Me.btnSortAlpha.Location = New System.Drawing.Point(341, 691)
        Me.btnSortAlpha.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSortAlpha.Name = "btnSortAlpha"
        Me.btnSortAlpha.Size = New System.Drawing.Size(165, 50)
        Me.btnSortAlpha.TabIndex = 3
        Me.btnSortAlpha.Text = "Alphabétique"
        Me.btnSortAlpha.UseVisualStyleBackColor = False
        '
        'btnSortTemps
        '
        Me.btnSortTemps.BackColor = System.Drawing.Color.Teal
        Me.btnSortTemps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortTemps.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortTemps.ForeColor = System.Drawing.Color.White
        Me.btnSortTemps.Location = New System.Drawing.Point(725, 691)
        Me.btnSortTemps.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSortTemps.Name = "btnSortTemps"
        Me.btnSortTemps.Size = New System.Drawing.Size(165, 50)
        Me.btnSortTemps.TabIndex = 4
        Me.btnSortTemps.Text = "Meilleurs temps"
        Me.btnSortTemps.UseVisualStyleBackColor = False
        '
        'btnSortScore
        '
        Me.btnSortScore.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnSortScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortScore.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortScore.ForeColor = System.Drawing.Color.White
        Me.btnSortScore.Location = New System.Drawing.Point(536, 691)
        Me.btnSortScore.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSortScore.Name = "btnSortScore"
        Me.btnSortScore.Size = New System.Drawing.Size(165, 50)
        Me.btnSortScore.TabIndex = 5
        Me.btnSortScore.Text = "Score"
        Me.btnSortScore.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label1.Location = New System.Drawing.Point(77, 254)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.LabelScore.Location = New System.Drawing.Point(216, 254)
        Me.LabelScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(64, 25)
        Me.LabelScore.TabIndex = 7
        Me.LabelScore.Text = "Score"
        '
        'LabelSORT
        '
        Me.LabelSORT.AutoSize = True
        Me.LabelSORT.Location = New System.Drawing.Point(565, 539)
        Me.LabelSORT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSORT.Name = "LabelSORT"
        Me.LabelSORT.Size = New System.Drawing.Size(29, 16)
        Me.LabelSORT.TabIndex = 8
        Me.LabelSORT.Text = "TRI"
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.LabelTemps.Location = New System.Drawing.Point(336, 254)
        Me.LabelTemps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(143, 25)
        Me.LabelTemps.TabIndex = 9
        Me.LabelTemps.Text = "Meilleur temps "
        '
        'LabelTEMPSCUMUL
        '
        Me.LabelTEMPSCUMUL.AutoSize = True
        Me.LabelTEMPSCUMUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.LabelTEMPSCUMUL.Location = New System.Drawing.Point(791, 254)
        Me.LabelTEMPSCUMUL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTEMPSCUMUL.Name = "LabelTEMPSCUMUL"
        Me.LabelTEMPSCUMUL.Size = New System.Drawing.Size(146, 25)
        Me.LabelTEMPSCUMUL.TabIndex = 12
        Me.LabelTEMPSCUMUL.Text = " Temps cumulé"
        '
        'pnlStats
        '
        Me.pnlStats.Controls.Add(Me.lstBox6)
        Me.pnlStats.Controls.Add(Me.lstBox5)
        Me.pnlStats.Controls.Add(Me.lstBox4)
        Me.pnlStats.Controls.Add(Me.lstBox3)
        Me.pnlStats.Controls.Add(Me.lstBox2)
        Me.pnlStats.Controls.Add(Me.lstBox1)
        Me.pnlStats.Location = New System.Drawing.Point(-44, 281)
        Me.pnlStats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(1045, 330)
        Me.pnlStats.TabIndex = 18
        '
        'lstBox6
        '
        Me.lstBox6.FormattingEnabled = True
        Me.lstBox6.ItemHeight = 16
        Me.lstBox6.Location = New System.Drawing.Point(840, 4)
        Me.lstBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox6.Name = "lstBox6"
        Me.lstBox6.Size = New System.Drawing.Size(148, 308)
        Me.lstBox6.TabIndex = 17
        '
        'lstBox5
        '
        Me.lstBox5.FormattingEnabled = True
        Me.lstBox5.ItemHeight = 16
        Me.lstBox5.Location = New System.Drawing.Point(701, 4)
        Me.lstBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox5.Name = "lstBox5"
        Me.lstBox5.Size = New System.Drawing.Size(96, 308)
        Me.lstBox5.TabIndex = 16
        '
        'lstBox4
        '
        Me.lstBox4.FormattingEnabled = True
        Me.lstBox4.ItemHeight = 16
        Me.lstBox4.Location = New System.Drawing.Point(560, 4)
        Me.lstBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox4.Name = "lstBox4"
        Me.lstBox4.Size = New System.Drawing.Size(96, 308)
        Me.lstBox4.TabIndex = 15
        '
        'lstBox3
        '
        Me.lstBox3.BackColor = System.Drawing.Color.White
        Me.lstBox3.FormattingEnabled = True
        Me.lstBox3.ItemHeight = 16
        Me.lstBox3.Location = New System.Drawing.Point(385, 4)
        Me.lstBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox3.Name = "lstBox3"
        Me.lstBox3.Size = New System.Drawing.Size(131, 308)
        Me.lstBox3.TabIndex = 14
        '
        'lstBox2
        '
        Me.lstBox2.FormattingEnabled = True
        Me.lstBox2.ItemHeight = 16
        Me.lstBox2.Location = New System.Drawing.Point(256, 4)
        Me.lstBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox2.Name = "lstBox2"
        Me.lstBox2.Size = New System.Drawing.Size(81, 308)
        Me.lstBox2.TabIndex = 13
        '
        'lstBox1
        '
        Me.lstBox1.FormattingEnabled = True
        Me.lstBox1.ItemHeight = 16
        Me.lstBox1.Location = New System.Drawing.Point(86, 4)
        Me.lstBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox1.Name = "lstBox1"
        Me.lstBox1.Size = New System.Drawing.Size(123, 308)
        Me.lstBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label2.Location = New System.Drawing.Point(519, 254)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Joueur 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label3.Location = New System.Drawing.Point(660, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Joueur 2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1007, 107)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(341, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 66)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "MasterMind"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label4.Location = New System.Drawing.Point(83, 703)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Tri par caractéristiques :"
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.Brown
        Me.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetour.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRetour.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRetour.Location = New System.Drawing.Point(41, 105)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(124, 36)
        Me.btnRetour.TabIndex = 40
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label5.Location = New System.Drawing.Point(83, 639)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(539, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Saisissez le nom d'un joueur pour avoir ses caractéristiques :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label6.Location = New System.Drawing.Point(65, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 25)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "-------------------------------------"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label8.Location = New System.Drawing.Point(648, 187)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(271, 25)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "-------------------------------------"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label9.Location = New System.Drawing.Point(341, 142)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(285, 25)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "---------------------------------------"
        '
        'lblPodium2
        '
        Me.lblPodium2.AutoSize = True
        Me.lblPodium2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPodium2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPodium2.Location = New System.Drawing.Point(97, 162)
        Me.lblPodium2.Name = "lblPodium2"
        Me.lblPodium2.Size = New System.Drawing.Size(165, 25)
        Me.lblPodium2.TabIndex = 50
        Me.lblPodium2.Text = "2ème classement"
        '
        'lblPodium3
        '
        Me.lblPodium3.AutoSize = True
        Me.lblPodium3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPodium3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPodium3.Location = New System.Drawing.Point(681, 162)
        Me.lblPodium3.Name = "lblPodium3"
        Me.lblPodium3.Size = New System.Drawing.Size(165, 25)
        Me.lblPodium3.TabIndex = 51
        Me.lblPodium3.Text = "2ème classement"
        '
        'lblPodium1
        '
        Me.lblPodium1.AutoSize = True
        Me.lblPodium1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPodium1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPodium1.Location = New System.Drawing.Point(386, 116)
        Me.lblPodium1.Name = "lblPodium1"
        Me.lblPodium1.Size = New System.Drawing.Size(144, 25)
        Me.lblPodium1.TabIndex = 52
        Me.lblPodium1.Text = "1er classement"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(448, 166)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 25)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Top 1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(749, 212)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 25)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Top 3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(159, 212)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 25)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Top 2"
        '
        'FormStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 768)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblPodium1)
        Me.Controls.Add(Me.lblPodium3)
        Me.Controls.Add(Me.lblPodium2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.LabelTEMPSCUMUL)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.LabelSORT)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSortScore)
        Me.Controls.Add(Me.btnSortTemps)
        Me.Controls.Add(Me.btnSortAlpha)
        Me.Controls.Add(Me.cbxNomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormStat"
        Me.Text = "Statistique"
        Me.pnlStats.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxNomJoueur As ComboBox
    Friend WithEvents btnSortAlpha As Button
    Friend WithEvents btnSortTemps As Button
    Friend WithEvents btnSortScore As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelSORT As Label
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelTEMPSCUMUL As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPodium2 As Label
    Friend WithEvents lblPodium3 As Label
    Friend WithEvents lblPodium1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lstBox1 As ListBox
    Friend WithEvents lstBox6 As ListBox
    Friend WithEvents lstBox5 As ListBox
    Friend WithEvents lstBox4 As ListBox
    Friend WithEvents lstBox3 As ListBox
    Friend WithEvents lstBox2 As ListBox
End Class
