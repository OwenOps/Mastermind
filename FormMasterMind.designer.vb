<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterMind
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
        Me.BtnRules = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnConfig = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRules
        '
        Me.BtnRules.BackColor = System.Drawing.Color.Brown
        Me.BtnRules.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRules.ForeColor = System.Drawing.Color.White
        Me.BtnRules.Location = New System.Drawing.Point(129, 253)
        Me.BtnRules.Name = "BtnRules"
        Me.BtnRules.Size = New System.Drawing.Size(609, 60)
        Me.BtnRules.TabIndex = 10
        Me.BtnRules.Text = "Prendre connaissance des règles"
        Me.BtnRules.UseVisualStyleBackColor = False
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.Green
        Me.BtnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(129, 475)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(609, 60)
        Me.BtnStart.TabIndex = 11
        Me.BtnStart.Text = "Commençons !"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.Location = New System.Drawing.Point(22, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(803, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Bienvenue sur MasterMind, un jeu créé par le groupe ..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(231, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(457, 105)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "MasterMind"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1409, 148)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'BtnConfig
        '
        Me.BtnConfig.BackColor = System.Drawing.Color.Gray
        Me.BtnConfig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnConfig.ForeColor = System.Drawing.Color.White
        Me.BtnConfig.Location = New System.Drawing.Point(129, 362)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(609, 60)
        Me.BtnConfig.TabIndex = 38
        Me.BtnConfig.Text = "Configuration Du Jeu"
        Me.BtnConfig.UseVisualStyleBackColor = False
        '
        'FormMasterMind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 572)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnRules)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximumSize = New System.Drawing.Size(921, 643)
        Me.Name = "FormMasterMind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterMind"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRules As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnConfig As Button
End Class