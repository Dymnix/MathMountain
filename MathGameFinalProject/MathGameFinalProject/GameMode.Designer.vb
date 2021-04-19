<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameMode
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
        Me.grpGameMode = New System.Windows.Forms.GroupBox()
        Me.radMixed = New System.Windows.Forms.RadioButton()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.grpGameMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGameMode
        '
        Me.grpGameMode.Controls.Add(Me.radMixed)
        Me.grpGameMode.Controls.Add(Me.radSubtraction)
        Me.grpGameMode.Controls.Add(Me.radAddition)
        Me.grpGameMode.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGameMode.Location = New System.Drawing.Point(29, 184)
        Me.grpGameMode.Name = "grpGameMode"
        Me.grpGameMode.Size = New System.Drawing.Size(598, 405)
        Me.grpGameMode.TabIndex = 3
        Me.grpGameMode.TabStop = False
        Me.grpGameMode.Text = "Select Game Mode:"
        '
        'radMixed
        '
        Me.radMixed.AutoSize = True
        Me.radMixed.Location = New System.Drawing.Point(59, 289)
        Me.radMixed.Name = "radMixed"
        Me.radMixed.Size = New System.Drawing.Size(466, 56)
        Me.radMixed.TabIndex = 2
        Me.radMixed.Text = "Addition and Subtraction"
        Me.radMixed.UseVisualStyleBackColor = True
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(65, 184)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(237, 56)
        Me.radSubtraction.TabIndex = 1
        Me.radSubtraction.Text = "Subtraction"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Checked = True
        Me.radAddition.Location = New System.Drawing.Point(65, 79)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(186, 56)
        Me.radAddition.TabIndex = 0
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "Addition"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(677, 212)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(369, 91)
        Me.btnStartGame.TabIndex = 3
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnHighScores
        '
        Me.btnHighScores.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.Location = New System.Drawing.Point(677, 348)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(369, 91)
        Me.btnHighScores.TabIndex = 4
        Me.btnHighScores.Text = "View High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(677, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(369, 91)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.ForeColor = System.Drawing.Color.Brown
        Me.lblGameTitle.Location = New System.Drawing.Point(183, 16)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(746, 140)
        Me.lblGameTitle.TabIndex = 10
        Me.lblGameTitle.Text = "Math Mountain"
        '
        'GameMode
        '
        Me.AcceptButton = Me.btnStartGame
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1112, 619)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.grpGameMode)
        Me.Name = "GameMode"
        Me.Text = "GameMode"
        Me.grpGameMode.ResumeLayout(False)
        Me.grpGameMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpGameMode As GroupBox
    Friend WithEvents radMixed As RadioButton
    Friend WithEvents radSubtraction As RadioButton
    Friend WithEvents radAddition As RadioButton
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnHighScores As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblGameTitle As Label
End Class
