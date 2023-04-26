<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaireJeu
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
        Me.MasterMind = New System.Windows.Forms.Label()
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
        Me.ListeCaratereHistorique = New System.Windows.Forms.ListBox()
        Me.ListeCaractereJouable = New System.Windows.Forms.ListBox()
        Me.PanelCaractereJoué.SuspendLayout()
        Me.SuspendLayout()
        '
        'MasterMind
        '
        Me.MasterMind.AutoSize = True
        Me.MasterMind.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterMind.Location = New System.Drawing.Point(264, 20)
        Me.MasterMind.Name = "MasterMind"
        Me.MasterMind.Size = New System.Drawing.Size(142, 25)
        Me.MasterMind.TabIndex = 0
        Me.MasterMind.Text = "Master Mind"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(488, 302)
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
        Me.Label4.Location = New System.Drawing.Point(488, 332)
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
        Me.Label5.Location = New System.Drawing.Point(488, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Présent et Bien Placé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Caractères jouables"
        '
        'ButtonGuess
        '
        Me.ButtonGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGuess.Location = New System.Drawing.Point(301, 140)
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
        Me.Label1.Location = New System.Drawing.Point(266, 195)
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
        Me.PanelCaractereJoué.Location = New System.Drawing.Point(183, 61)
        Me.PanelCaractereJoué.Name = "PanelCaractereJoué"
        Me.PanelCaractereJoué.Size = New System.Drawing.Size(312, 59)
        Me.PanelCaractereJoué.TabIndex = 22
        '
        'ListeCaratereHistorique
        '
        Me.ListeCaratereHistorique.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListeCaratereHistorique.FormattingEnabled = True
        Me.ListeCaratereHistorique.Location = New System.Drawing.Point(269, 238)
        Me.ListeCaratereHistorique.Name = "ListeCaratereHistorique"
        Me.ListeCaratereHistorique.Size = New System.Drawing.Size(137, 225)
        Me.ListeCaratereHistorique.TabIndex = 21
        '
        'ListeCaractereJouable
        '
        Me.ListeCaractereJouable.BackColor = System.Drawing.SystemColors.Menu
        Me.ListeCaractereJouable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListeCaractereJouable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeCaractereJouable.FormattingEnabled = True
        Me.ListeCaractereJouable.ItemHeight = 15
        Me.ListeCaractereJouable.Location = New System.Drawing.Point(65, 302)
        Me.ListeCaractereJouable.Name = "ListeCaractereJouable"
        Me.ListeCaractereJouable.Size = New System.Drawing.Size(136, 30)
        Me.ListeCaractereJouable.TabIndex = 23
        '
        'FormulaireJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 519)
        Me.Controls.Add(Me.ListeCaractereJouable)
        Me.Controls.Add(Me.ListeCaratereHistorique)
        Me.Controls.Add(Me.PanelCaractereJoué)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGuess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MasterMind)
        Me.Name = "FormulaireJeu"
        Me.Text = "Form1"
        Me.PanelCaractereJoué.ResumeLayout(False)
        Me.PanelCaractereJoué.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MasterMind As Label
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
    Friend WithEvents ListeCaratereHistorique As ListBox
    Friend WithEvents ListeCaractereJouable As ListBox
End Class
