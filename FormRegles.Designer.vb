<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegles
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAleatoire = New System.Windows.Forms.Button()
        Me.PnlCaractereJoue = New System.Windows.Forms.Panel()
        Me.txtBox5 = New System.Windows.Forms.TextBox()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox4 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEntrainement = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCaractereJoue.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(269, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 66)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-40, -10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(939, 95)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.Maroon
        Me.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetour.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRetour.ForeColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(72, 571)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(173, 46)
        Me.btnRetour.TabIndex = 42
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(165, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(491, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Célèbre jeu des années 1970, ses règles sont simples !"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(43, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 22)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "A chaque manche, 2 joueurs vont s'affonter la victoire à tour de rôle : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(43, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(433, 22)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "- Le premier joueur arrivera sur le formulaire Pattern. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(728, 22)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Son but : trouver une combinaison secrète assez complexe parmi les caractères aut" &
    "orisés "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(43, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(397, 22)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "- Le second joueur arrivera sur le formulaire Jeu."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(44, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 22)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Exemple :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(43, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(692, 22)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Son but : déchiffrer cette combinaison sans dépasser le temps imparti et le nombr" &
    "e de"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(43, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 22)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "coups maximum."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label11.Location = New System.Drawing.Point(135, 522)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(537, 22)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "S'il réussit, il remporte le point. Sinon, le premier joueur l'emporte !"
        '
        'btnAleatoire
        '
        Me.btnAleatoire.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAleatoire.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnAleatoire.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAleatoire.ForeColor = System.Drawing.Color.White
        Me.btnAleatoire.Location = New System.Drawing.Point(99, 334)
        Me.btnAleatoire.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAleatoire.Name = "btnAleatoire"
        Me.btnAleatoire.Size = New System.Drawing.Size(101, 38)
        Me.btnAleatoire.TabIndex = 57
        Me.btnAleatoire.Text = "Aléatoire"
        Me.btnAleatoire.UseVisualStyleBackColor = False
        '
        'PnlCaractereJoue
        '
        Me.PnlCaractereJoue.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PnlCaractereJoue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCaractereJoue.Controls.Add(Me.txtBox5)
        Me.PnlCaractereJoue.Controls.Add(Me.txtBox1)
        Me.PnlCaractereJoue.Controls.Add(Me.txtBox4)
        Me.PnlCaractereJoue.Controls.Add(Me.txtBox2)
        Me.PnlCaractereJoue.Controls.Add(Me.txtBox3)
        Me.PnlCaractereJoue.ForeColor = System.Drawing.Color.Black
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(223, 334)
        Me.PnlCaractereJoue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(423, 37)
        Me.PnlCaractereJoue.TabIndex = 55
        '
        'txtBox5
        '
        Me.txtBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox5.Location = New System.Drawing.Point(349, 7)
        Me.txtBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox5.MaxLength = 1
        Me.txtBox5.Name = "txtBox5"
        Me.txtBox5.Size = New System.Drawing.Size(49, 22)
        Me.txtBox5.TabIndex = 5
        Me.txtBox5.Tag = ""
        Me.txtBox5.Text = "B"
        Me.txtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox1
        '
        Me.txtBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox1.Location = New System.Drawing.Point(16, 7)
        Me.txtBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox1.MaxLength = 1
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(49, 22)
        Me.txtBox1.TabIndex = 1
        Me.txtBox1.Text = "D"
        Me.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox4
        '
        Me.txtBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox4.Location = New System.Drawing.Point(267, 7)
        Me.txtBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox4.MaxLength = 1
        Me.txtBox4.Name = "txtBox4"
        Me.txtBox4.Size = New System.Drawing.Size(49, 22)
        Me.txtBox4.TabIndex = 4
        Me.txtBox4.Text = "C"
        Me.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox2
        '
        Me.txtBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox2.Location = New System.Drawing.Point(96, 7)
        Me.txtBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox2.MaxLength = 1
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(49, 22)
        Me.txtBox2.TabIndex = 2
        Me.txtBox2.Text = "A"
        Me.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox3
        '
        Me.txtBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox3.Location = New System.Drawing.Point(180, 7)
        Me.txtBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox3.MaxLength = 1
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(49, 22)
        Me.txtBox3.TabIndex = 3
        Me.txtBox3.Text = "E"
        Me.txtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.ForestGreen
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(668, 334)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(95, 38)
        Me.btnHide.TabIndex = 54
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label12.Location = New System.Drawing.Point(280, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(180, 22)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Caractères jouables :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(467, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 25)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "A  B  C  D  E "
        '
        'btnEntrainement
        '
        Me.btnEntrainement.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnEntrainement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrainement.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEntrainement.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEntrainement.Location = New System.Drawing.Point(280, 571)
        Me.btnEntrainement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEntrainement.Name = "btnEntrainement"
        Me.btnEntrainement.Size = New System.Drawing.Size(507, 46)
        Me.btnEntrainement.TabIndex = 60
        Me.btnEntrainement.Text = "Vous souhaitez vous entraîner ? Alors, cliquez ici !"
        Me.btnEntrainement.UseVisualStyleBackColor = False
        '
        'FormRegles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 641)
        Me.Controls.Add(Me.btnEntrainement)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnAleatoire)
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormRegles"
        Me.Text = "FormRegles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCaractereJoue.ResumeLayout(False)
        Me.PnlCaractereJoue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FormRegles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAleatoire As Button
    Friend WithEvents PnlCaractereJoue As Panel
    Friend WithEvents txtBox5 As TextBox
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox4 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents btnHide As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnEntrainement As Button
End Class
