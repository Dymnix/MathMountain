<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndScreen
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
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.lblLine3 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLine1
        '
        Me.lblLine1.AutoSize = True
        Me.lblLine1.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1.Location = New System.Drawing.Point(254, 126)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(293, 52)
        Me.lblLine1.TabIndex = 5
        Me.lblLine1.Text = "New High Score!"
        '
        'lblLine2
        '
        Me.lblLine2.AutoSize = True
        Me.lblLine2.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2.Location = New System.Drawing.Point(254, 194)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(193, 52)
        Me.lblLine2.TabIndex = 6
        Me.lblLine2.Text = "Old Score:"
        '
        'lblLine3
        '
        Me.lblLine3.AutoSize = True
        Me.lblLine3.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3.Location = New System.Drawing.Point(254, 261)
        Me.lblLine3.Name = "lblLine3"
        Me.lblLine3.Size = New System.Drawing.Size(204, 52)
        Me.lblLine3.TabIndex = 7
        Me.lblLine3.Text = "New Score:"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.LightGray
        Me.btnReturn.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(193, 352)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(415, 58)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.ForeColor = System.Drawing.Color.Brown
        Me.lblGameTitle.Location = New System.Drawing.Point(149, 9)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(502, 95)
        Me.lblGameTitle.TabIndex = 9
        Me.lblGameTitle.Text = "Math Mountain"
        '
        'EndScreen
        '
        Me.AcceptButton = Me.btnReturn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblLine3)
        Me.Controls.Add(Me.lblLine2)
        Me.Controls.Add(Me.lblLine1)
        Me.Name = "EndScreen"
        Me.Text = "EndScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLine1 As Label
    Friend WithEvents lblLine2 As Label
    Friend WithEvents lblLine3 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblGameTitle As Label
End Class
