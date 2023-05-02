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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCaractereJoue.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHIDE
        '
        Me.ButtonHIDE.Location = New System.Drawing.Point(512, 160)
        Me.ButtonHIDE.Name = "ButtonHIDE"
        Me.ButtonHIDE.Size = New System.Drawing.Size(83, 34)
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
        Me.Label7.Location = New System.Drawing.Point(216, 18)
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
        Me.PictureBox1.Size = New System.Drawing.Size(705, 77)
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
        Me.PnlCaractereJoue.Location = New System.Drawing.Point(163, 147)
        Me.PnlCaractereJoue.Name = "PnlCaractereJoue"
        Me.PnlCaractereJoue.Size = New System.Drawing.Size(322, 59)
        Me.PnlCaractereJoue.TabIndex = 43
        '
        'TxtBox5
        '
        Me.TxtBox5.Location = New System.Drawing.Point(267, 19)
        Me.TxtBox5.MaxLength = 1
        Me.TxtBox5.Name = "TxtBox5"
        Me.TxtBox5.Size = New System.Drawing.Size(38, 20)
        Me.TxtBox5.TabIndex = 5
        Me.TxtBox5.Tag = ""
        Me.TxtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox1
        '
        Me.TxtBox1.Location = New System.Drawing.Point(17, 19)
        Me.TxtBox1.MaxLength = 1
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.Size = New System.Drawing.Size(38, 20)
        Me.TxtBox1.TabIndex = 1
        Me.TxtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox4
        '
        Me.TxtBox4.Location = New System.Drawing.Point(206, 19)
        Me.TxtBox4.MaxLength = 1
        Me.TxtBox4.Name = "TxtBox4"
        Me.TxtBox4.Size = New System.Drawing.Size(38, 20)
        Me.TxtBox4.TabIndex = 4
        Me.TxtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox2
        '
        Me.TxtBox2.Location = New System.Drawing.Point(74, 19)
        Me.TxtBox2.MaxLength = 1
        Me.TxtBox2.Name = "TxtBox2"
        Me.TxtBox2.Size = New System.Drawing.Size(38, 20)
        Me.TxtBox2.TabIndex = 2
        Me.TxtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox3
        '
        Me.TxtBox3.Location = New System.Drawing.Point(141, 19)
        Me.TxtBox3.MaxLength = 1
        Me.TxtBox3.Name = "TxtBox3"
        Me.TxtBox3.Size = New System.Drawing.Size(38, 20)
        Me.TxtBox3.TabIndex = 3
        Me.TxtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Choisissez les caractères que vous voulez faire deviner."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Caractères jouables"
        '
        'CaraJouable
        '
        Me.CaraJouable.AutoSize = True
        Me.CaraJouable.Location = New System.Drawing.Point(267, 262)
        Me.CaraJouable.Name = "CaraJouable"
        Me.CaraJouable.Size = New System.Drawing.Size(66, 13)
        Me.CaraJouable.TabIndex = 47
        Me.CaraJouable.Text = "CaraJouable"
        '
        'FormCaractere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 308)
        Me.Controls.Add(Me.CaraJouable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlCaractereJoue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonHIDE)
        Me.MaximumSize = New System.Drawing.Size(644, 348)
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
End Class
