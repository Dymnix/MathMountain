<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblGameTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.ForeColor = System.Drawing.Color.Brown
        Me.lblGameTitle.Location = New System.Drawing.Point(211, 26)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(502, 95)
        Me.lblGameTitle.TabIndex = 3
        Me.lblGameTitle.Text = "Math Mountain"
        Me.lblGameTitle.Visible = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.Location = New System.Drawing.Point(17, 111)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(149, 52)
        Me.lblLives.TabIndex = 4
        Me.lblLives.Text = "Lives: 3"
        Me.lblLives.Visible = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(757, 111)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(151, 52)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "Time: 7"
        Me.lblTimer.Visible = False
        '
        'lblEquation
        '
        Me.lblEquation.AutoSize = True
        Me.lblEquation.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquation.Location = New System.Drawing.Point(287, 235)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(240, 52)
        Me.lblEquation.TabIndex = 6
        Me.lblEquation.Text = "XXX + XXX ="
        Me.lblEquation.Visible = False
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.LightGray
        Me.txtAnswer.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(538, 232)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 59)
        Me.txtAnswer.TabIndex = 7
        Me.txtAnswer.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LightGray
        Me.btnConfirm.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(262, 347)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(401, 63)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm (Enter)"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'lblCountdown
        '
        Me.lblCountdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.Brown
        Me.lblCountdown.Location = New System.Drawing.Point(363, 157)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(210, 52)
        Me.lblCountdown.TabIndex = 9
        Me.lblCountdown.Text = "Incorrect!!"
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCountdown.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Game
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(925, 487)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGameTitle As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblEquation As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblCountdown As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
