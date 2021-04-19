<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.btnCreateNewUser = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreateNewUser
        '
        Me.btnCreateNewUser.BackColor = System.Drawing.Color.LightGray
        Me.btnCreateNewUser.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewUser.Location = New System.Drawing.Point(57, 322)
        Me.btnCreateNewUser.Name = "btnCreateNewUser"
        Me.btnCreateNewUser.Size = New System.Drawing.Size(319, 84)
        Me.btnCreateNewUser.TabIndex = 12
        Me.btnCreateNewUser.Text = "Create New User"
        Me.btnCreateNewUser.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightGray
        Me.txtPassword.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(384, 215)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(384, 59)
        Me.txtPassword.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.LightGray
        Me.txtUsername.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(384, 129)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(384, 59)
        Me.txtUsername.TabIndex = 10
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(57, 218)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(295, 52)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Enter Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(57, 132)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(298, 52)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "Enter Username:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightGray
        Me.btnBack.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(425, 322)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(319, 84)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.ForeColor = System.Drawing.Color.Brown
        Me.lblGameTitle.Location = New System.Drawing.Point(149, 9)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(502, 95)
        Me.lblGameTitle.TabIndex = 14
        Me.lblGameTitle.Text = "Math Mountain"
        '
        'NewUser
        '
        Me.AcceptButton = Me.btnCreateNewUser
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCreateNewUser)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateNewUser As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblGameTitle As Label
End Class
