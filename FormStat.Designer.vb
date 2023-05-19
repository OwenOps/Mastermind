<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonSortAlpha = New System.Windows.Forms.Button()
        Me.ButtonSortTEMPS = New System.Windows.Forms.Button()
        Me.ButtonSortScore = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelSORT = New System.Windows.Forms.Label()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelJOUEUR1 = New System.Windows.Forms.Label()
        Me.LabelJOUEUR2 = New System.Windows.Forms.Label()
        Me.LabelTEMPSCUMUL = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(70, 375)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(32, 383)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(32, 13)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "NOM"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(78, 277)
        Me.ListBox1.TabIndex = 2
        '
        'ButtonSortAlpha
        '
        Me.ButtonSortAlpha.Location = New System.Drawing.Point(424, 376)
        Me.ButtonSortAlpha.Name = "ButtonSortAlpha"
        Me.ButtonSortAlpha.Size = New System.Drawing.Size(106, 20)
        Me.ButtonSortAlpha.TabIndex = 3
        Me.ButtonSortAlpha.Text = "Alphabetique"
        Me.ButtonSortAlpha.UseVisualStyleBackColor = True
        '
        'ButtonSortTEMPS
        '
        Me.ButtonSortTEMPS.Location = New System.Drawing.Point(536, 375)
        Me.ButtonSortTEMPS.Name = "ButtonSortTEMPS"
        Me.ButtonSortTEMPS.Size = New System.Drawing.Size(106, 20)
        Me.ButtonSortTEMPS.TabIndex = 4
        Me.ButtonSortTEMPS.Text = "Meilleurs Temps"
        Me.ButtonSortTEMPS.UseVisualStyleBackColor = True
        '
        'ButtonSortScore
        '
        Me.ButtonSortScore.Location = New System.Drawing.Point(312, 375)
        Me.ButtonSortScore.Name = "ButtonSortScore"
        Me.ButtonSortScore.Size = New System.Drawing.Size(106, 20)
        Me.ButtonSortScore.TabIndex = 5
        Me.ButtonSortScore.Text = "SCORE"
        Me.ButtonSortScore.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSortScore.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(102, 9)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(35, 13)
        Me.LabelScore.TabIndex = 7
        Me.LabelScore.Text = "Score"
        '
        'LabelSORT
        '
        Me.LabelSORT.AutoSize = True
        Me.LabelSORT.Location = New System.Drawing.Point(309, 342)
        Me.LabelSORT.Name = "LabelSORT"
        Me.LabelSORT.Size = New System.Drawing.Size(25, 13)
        Me.LabelSORT.TabIndex = 8
        Me.LabelSORT.Text = "TRI"
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Location = New System.Drawing.Point(161, 9)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(77, 13)
        Me.LabelTemps.TabIndex = 9
        Me.LabelTemps.Text = "Meilleur temps "
        '
        'LabelJOUEUR1
        '
        Me.LabelJOUEUR1.AutoSize = True
        Me.LabelJOUEUR1.Location = New System.Drawing.Point(244, 9)
        Me.LabelJOUEUR1.Name = "LabelJOUEUR1"
        Me.LabelJOUEUR1.Size = New System.Drawing.Size(197, 13)
        Me.LabelJOUEUR1.TabIndex = 10
        Me.LabelJOUEUR1.Text = " Nombre de parties en tant que joueur 1 "
        '
        'LabelJOUEUR2
        '
        Me.LabelJOUEUR2.AutoSize = True
        Me.LabelJOUEUR2.Location = New System.Drawing.Point(447, 9)
        Me.LabelJOUEUR2.Name = "LabelJOUEUR2"
        Me.LabelJOUEUR2.Size = New System.Drawing.Size(194, 13)
        Me.LabelJOUEUR2.TabIndex = 11
        Me.LabelJOUEUR2.Text = "Nombre de parties en tant que joueur 2 "
        '
        'LabelTEMPSCUMUL
        '
        Me.LabelTEMPSCUMUL.AutoSize = True
        Me.LabelTEMPSCUMUL.Location = New System.Drawing.Point(647, 9)
        Me.LabelTEMPSCUMUL.Name = "LabelTEMPSCUMUL"
        Me.LabelTEMPSCUMUL.Size = New System.Drawing.Size(79, 13)
        Me.LabelTEMPSCUMUL.TabIndex = 12
        Me.LabelTEMPSCUMUL.Text = " Temps cumulé"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(96, 38)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(62, 277)
        Me.ListBox2.TabIndex = 13
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(164, 38)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(74, 277)
        Me.ListBox3.TabIndex = 14
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(247, 38)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(194, 277)
        Me.ListBox4.TabIndex = 15
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(450, 38)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(180, 277)
        Me.ListBox5.TabIndex = 16
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(650, 38)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(114, 277)
        Me.ListBox6.TabIndex = 17
        '
        'FormStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.LabelTEMPSCUMUL)
        Me.Controls.Add(Me.LabelJOUEUR2)
        Me.Controls.Add(Me.LabelJOUEUR1)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.LabelSORT)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSortScore)
        Me.Controls.Add(Me.ButtonSortTEMPS)
        Me.Controls.Add(Me.ButtonSortAlpha)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FormStat"
        Me.Text = "Statistique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonSortAlpha As Button
    Friend WithEvents ButtonSortTEMPS As Button
    Friend WithEvents ButtonSortScore As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelSORT As Label
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelJOUEUR1 As Label
    Friend WithEvents LabelJOUEUR2 As Label
    Friend WithEvents LabelTEMPSCUMUL As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
End Class
