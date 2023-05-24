<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCaractere
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
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlCaractereJoue = New System.Windows.Forms.Panel()
        Me.txtBox5 = New System.Windows.Forms.TextBox()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox4 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCaraJouable = New System.Windows.Forms.Label()
        Me.btnAleatoire = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.PnlDiff = New System.Windows.Forms.Panel()
        Me.LblDifficulte = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCaractereJoue.SuspendLayout()
        Me.PnlDiff.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.ForestGreen
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHide.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHide.Location = New System.Drawing.Point(474, 174)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(83, 40)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(184, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 52)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(705, 83)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
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
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(138, 165)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(322, 62)
        Me.PnlCaractereJoue.TabIndex = 43
        '
        'txtBox5
        '
        Me.txtBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox5.Location = New System.Drawing.Point(266, 20)
        Me.txtBox5.MaxLength = 1
        Me.txtBox5.Name = "txtBox5"
        Me.txtBox5.Size = New System.Drawing.Size(38, 19)
        Me.txtBox5.TabIndex = 5
        Me.txtBox5.Tag = ""
        Me.txtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox1
        '
        Me.txtBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox1.Location = New System.Drawing.Point(17, 20)
        Me.txtBox1.MaxLength = 1
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(38, 19)
        Me.txtBox1.TabIndex = 1
        Me.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox4
        '
        Me.txtBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox4.Location = New System.Drawing.Point(203, 20)
        Me.txtBox4.MaxLength = 1
        Me.txtBox4.Name = "txtBox4"
        Me.txtBox4.Size = New System.Drawing.Size(38, 19)
        Me.txtBox4.TabIndex = 4
        Me.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox2
        '
        Me.txtBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox2.Location = New System.Drawing.Point(76, 20)
        Me.txtBox2.MaxLength = 1
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(38, 19)
        Me.txtBox2.TabIndex = 2
        Me.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox3
        '
        Me.txtBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox3.Location = New System.Drawing.Point(140, 20)
        Me.txtBox3.MaxLength = 1
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(38, 19)
        Me.txtBox3.TabIndex = 3
        Me.txtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Choisissez la combinaison secrète à faire devenir à "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(532, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Attention, vous ne pouvez qu'utiliser la liste des caractères jouables ci-dessous" &
    " !"
        '
        'lblCaraJouable
        '
        Me.lblCaraJouable.AutoSize = True
        Me.lblCaraJouable.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblCaraJouable.Location = New System.Drawing.Point(227, 280)
        Me.lblCaraJouable.Name = "lblCaraJouable"
        Me.lblCaraJouable.Size = New System.Drawing.Size(99, 20)
        Me.lblCaraJouable.TabIndex = 47
        Me.lblCaraJouable.Text = "CaraJouable"
        '
        'btnAleatoire
        '
        Me.btnAleatoire.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAleatoire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAleatoire.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAleatoire.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAleatoire.Location = New System.Drawing.Point(36, 174)
        Me.btnAleatoire.Name = "btnAleatoire"
        Me.btnAleatoire.Size = New System.Drawing.Size(83, 40)
        Me.btnAleatoire.TabIndex = 48
        Me.btnAleatoire.Text = "Aléatoire"
        Me.btnAleatoire.UseVisualStyleBackColor = False
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNom.Location = New System.Drawing.Point(465, 133)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(57, 20)
        Me.lblNom.TabIndex = 49
        Me.lblNom.Text = "lblNom"
        '
        'PnlDiff
        '
        Me.PnlDiff.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PnlDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDiff.Controls.Add(Me.LblDifficulte)
        Me.PnlDiff.ForeColor = System.Drawing.Color.Black
        Me.PnlDiff.Location = New System.Drawing.Point(8, 92)
        Me.PnlDiff.Name = "PnlDiff"
        Me.PnlDiff.Size = New System.Drawing.Size(56, 31)
        Me.PnlDiff.TabIndex = 54
        '
        'LblDifficulte
        '
        Me.LblDifficulte.AutoSize = True
        Me.LblDifficulte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDifficulte.ForeColor = System.Drawing.Color.Gray
        Me.LblDifficulte.Location = New System.Drawing.Point(3, 4)
        Me.LblDifficulte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDifficulte.Name = "LblDifficulte"
        Me.LblDifficulte.Size = New System.Drawing.Size(28, 19)
        Me.LblDifficulte.TabIndex = 53
        Me.LblDifficulte.Text = "Dif"
        Me.LblDifficulte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCaractere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 321)
        Me.Controls.Add(Me.PnlDiff)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btnAleatoire)
        Me.Controls.Add(Me.lblCaraJouable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHide)
        Me.MaximumSize = New System.Drawing.Size(617, 360)
        Me.Name = "FormCaractere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pattern à deviner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCaractereJoue.ResumeLayout(False)
        Me.PnlCaractereJoue.PerformLayout()
        Me.PnlDiff.ResumeLayout(False)
        Me.PnlDiff.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHide As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlCaractereJoue As Panel
    Friend WithEvents txtBox5 As TextBox
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox4 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCaraJouable As Label
    Friend WithEvents btnAleatoire As Button
    Friend WithEvents lblNom As Label
    Friend WithEvents PnlDiff As Panel
    Friend WithEvents LblDifficulte As Label
End Class
