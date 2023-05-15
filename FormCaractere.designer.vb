<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaractere
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
        Me.ButtonHIDE = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlCaractereJoue = New System.Windows.Forms.Panel()
        Me.TxtBox5 = New System.Windows.Forms.TextBox()
        Me.TxtBox1 = New System.Windows.Forms.TextBox()
        Me.TxtBox4 = New System.Windows.Forms.TextBox()
        Me.TxtBox2 = New System.Windows.Forms.TextBox()
        Me.TxtBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CaraJouable = New System.Windows.Forms.Label()
        Me.BtnAleatoire = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCaractereJoue.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHIDE
        '
        Me.ButtonHIDE.Location = New System.Drawing.Point(1024, 308)
        Me.ButtonHIDE.Margin = New System.Windows.Forms.Padding(6)
        Me.ButtonHIDE.Name = "ButtonHIDE"
        Me.ButtonHIDE.Size = New System.Drawing.Size(166, 65)
        Me.ButtonHIDE.TabIndex = 0
        Me.ButtonHIDE.Text = "Hide"
        Me.ButtonHIDE.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(432, 35)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(457, 105)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1410, 148)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PnlCaractereJoue
        '
        Me.PnlCaractereJoue.BackColor = System.Drawing.SystemColors.Menu
        Me.PnlCaractereJoue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCaractereJoue.Controls.Add(Me.TxtBox5)
        Me.PnlCaractereJoue.Controls.Add(Me.TxtBox1)
        Me.PnlCaractereJoue.Controls.Add(Me.TxtBox4)
        Me.PnlCaractereJoue.Controls.Add(Me.TxtBox2)
        Me.PnlCaractereJoue.Controls.Add(Me.TxtBox3)
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(326, 283)
        Me.PnlCaractereJoue.Margin = New System.Windows.Forms.Padding(6)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(640, 110)
        Me.PnlCaractereJoue.TabIndex = 43
        '
        'TxtBox5
        '
        Me.TxtBox5.Location = New System.Drawing.Point(534, 37)
        Me.TxtBox5.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtBox5.MaxLength = 1
        Me.TxtBox5.Name = "TxtBox5"
        Me.TxtBox5.Size = New System.Drawing.Size(72, 31)
        Me.TxtBox5.TabIndex = 5
        Me.TxtBox5.Tag = ""
        Me.TxtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox1
        '
        Me.TxtBox1.Location = New System.Drawing.Point(34, 37)
        Me.TxtBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtBox1.MaxLength = 1
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.Size = New System.Drawing.Size(72, 31)
        Me.TxtBox1.TabIndex = 1
        Me.TxtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox4
        '
        Me.TxtBox4.Location = New System.Drawing.Point(412, 37)
        Me.TxtBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtBox4.MaxLength = 1
        Me.TxtBox4.Name = "TxtBox4"
        Me.TxtBox4.Size = New System.Drawing.Size(72, 31)
        Me.TxtBox4.TabIndex = 4
        Me.TxtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox2
        '
        Me.TxtBox2.Location = New System.Drawing.Point(148, 37)
        Me.TxtBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtBox2.MaxLength = 1
        Me.TxtBox2.Name = "TxtBox2"
        Me.TxtBox2.Size = New System.Drawing.Size(72, 31)
        Me.TxtBox2.TabIndex = 2
        Me.TxtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox3
        '
        Me.TxtBox3.Location = New System.Drawing.Point(282, 37)
        Me.TxtBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtBox3.MaxLength = 1
        Me.TxtBox3.Name = "TxtBox3"
        Me.TxtBox3.Size = New System.Drawing.Size(72, 31)
        Me.TxtBox3.TabIndex = 3
        Me.TxtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(833, 34)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Choisissez les caractères que vous voulez faire deviner."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 442)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 30)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Caractères jouables"
        '
        'CaraJouable
        '
        Me.CaraJouable.AutoSize = True
        Me.CaraJouable.Location = New System.Drawing.Point(534, 504)
        Me.CaraJouable.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.CaraJouable.Name = "CaraJouable"
        Me.CaraJouable.Size = New System.Drawing.Size(134, 25)
        Me.CaraJouable.TabIndex = 47
        Me.CaraJouable.Text = "CaraJouable"
        '
        'BtnAleatoire
        '
        Me.BtnAleatoire.Location = New System.Drawing.Point(116, 308)
        Me.BtnAleatoire.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnAleatoire.Name = "BtnAleatoire"
        Me.BtnAleatoire.Size = New System.Drawing.Size(166, 65)
        Me.BtnAleatoire.TabIndex = 48
        Me.BtnAleatoire.Text = "Aleatoire"
        Me.BtnAleatoire.UseVisualStyleBackColor = True
        '
        'FormCaractere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 601)
        Me.Controls.Add(Me.BtnAleatoire)
        Me.Controls.Add(Me.CaraJouable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonHIDE)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximumSize = New System.Drawing.Size(1320, 672)
        Me.Name = "FormCaractere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pattern à deviner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCaractereJoue.ResumeLayout(False)
        Me.PnlCaractereJoue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHIDE As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlCaractereJoue As Panel
    Friend WithEvents TxtBox5 As TextBox
    Friend WithEvents TxtBox1 As TextBox
    Friend WithEvents TxtBox4 As TextBox
    Friend WithEvents TxtBox2 As TextBox
    Friend WithEvents TxtBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CaraJouable As Label
    Friend WithEvents BtnAleatoire As Button
End Class
