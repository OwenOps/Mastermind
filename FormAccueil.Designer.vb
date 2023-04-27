<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxNomJoueur1 = New System.Windows.Forms.ComboBox()
        Me.cbxNomJoueur2 = New System.Windows.Forms.ComboBox()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxNomJoueur1
        '
        Me.cbxNomJoueur1.FormattingEnabled = True
        Me.cbxNomJoueur1.Location = New System.Drawing.Point(184, 104)
        Me.cbxNomJoueur1.Name = "cbxNomJoueur1"
        Me.cbxNomJoueur1.Size = New System.Drawing.Size(207, 23)
        Me.cbxNomJoueur1.TabIndex = 0
        '
        'cbxNomJoueur2
        '
        Me.cbxNomJoueur2.FormattingEnabled = True
        Me.cbxNomJoueur2.Location = New System.Drawing.Point(184, 151)
        Me.cbxNomJoueur2.Name = "cbxNomJoueur2"
        Me.cbxNomJoueur2.Size = New System.Drawing.Size(207, 23)
        Me.cbxNomJoueur2.TabIndex = 1
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStats.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStats.Location = New System.Drawing.Point(290, 207)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(117, 35)
        Me.btnStats.TabIndex = 4
        Me.btnStats.Text = "Statistique"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJouer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnJouer.Location = New System.Drawing.Point(156, 207)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(115, 35)
        Me.btnJouer.TabIndex = 3
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuitter.Location = New System.Drawing.Point(22, 207)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(115, 35)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 79)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 52)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MasterMind"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(38, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom Joueur 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(35, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nom Joueur 2"
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 264)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.cbxNomJoueur2)
        Me.Controls.Add(Me.cbxNomJoueur1)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxNomJoueur1 As ComboBox
    Friend WithEvents cbxNomJoueur2 As ComboBox
    Friend WithEvents btnStats As Button
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
