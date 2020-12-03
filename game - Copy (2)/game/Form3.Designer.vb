<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level3
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.KirbyBar = New System.Windows.Forms.ProgressBar()
        Me.replayButton = New System.Windows.Forms.Button()
        Me.marx = New System.Windows.Forms.PictureBox()
        Me.gameover = New System.Windows.Forms.PictureBox()
        Me.yay = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.laser = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.marx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Teal
        Me.ProgressBar1.ForeColor = System.Drawing.Color.HotPink
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 24)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(499, 23)
        Me.ProgressBar1.TabIndex = 25
        Me.ProgressBar1.Value = 100
        '
        'KirbyBar
        '
        Me.KirbyBar.Location = New System.Drawing.Point(33, 563)
        Me.KirbyBar.Name = "KirbyBar"
        Me.KirbyBar.Size = New System.Drawing.Size(252, 23)
        Me.KirbyBar.TabIndex = 26
        Me.KirbyBar.Value = 100
        '
        'replayButton
        '
        Me.replayButton.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replayButton.Location = New System.Drawing.Point(655, 390)
        Me.replayButton.Name = "replayButton"
        Me.replayButton.Size = New System.Drawing.Size(166, 159)
        Me.replayButton.TabIndex = 27
        Me.replayButton.Text = "Retry"
        Me.replayButton.UseVisualStyleBackColor = True
        Me.replayButton.Visible = False
        '
        'marx
        '
        Me.marx.BackColor = System.Drawing.Color.Transparent
        Me.marx.Image = Global.game.My.Resources.Resources.marx
        Me.marx.Location = New System.Drawing.Point(953, 53)
        Me.marx.Name = "marx"
        Me.marx.Size = New System.Drawing.Size(499, 277)
        Me.marx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.marx.TabIndex = 28
        Me.marx.TabStop = False
        '
        'gameover
        '
        Me.gameover.BackColor = System.Drawing.Color.Transparent
        Me.gameover.Image = Global.game.My.Resources.Resources.other_game_over
        Me.gameover.Location = New System.Drawing.Point(422, 74)
        Me.gameover.Name = "gameover"
        Me.gameover.Size = New System.Drawing.Size(634, 321)
        Me.gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gameover.TabIndex = 21
        Me.gameover.TabStop = False
        Me.gameover.Visible = False
        '
        'yay
        '
        Me.yay.BackColor = System.Drawing.Color.Transparent
        Me.yay.Image = Global.game.My.Resources.Resources.hooray__1_
        Me.yay.Location = New System.Drawing.Point(400, 74)
        Me.yay.Name = "yay"
        Me.yay.Size = New System.Drawing.Size(683, 321)
        Me.yay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.yay.TabIndex = 20
        Me.yay.TabStop = False
        Me.yay.Visible = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = Global.game.My.Resources.Resources.star
        Me.Bullet.Location = New System.Drawing.Point(12, 53)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(83, 83)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 19
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox2.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox2.Location = New System.Drawing.Point(82, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox1.Location = New System.Drawing.Point(33, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.game.My.Resources.Resources.space2
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1491, 621)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'laser
        '
        Me.laser.BackColor = System.Drawing.Color.Transparent
        Me.laser.Image = Global.game.My.Resources.Resources.laser
        Me.laser.Location = New System.Drawing.Point(671, 311)
        Me.laser.Name = "laser"
        Me.laser.Size = New System.Drawing.Size(820, 310)
        Me.laser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.laser.TabIndex = 30
        Me.laser.TabStop = False
        Me.laser.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Defeat the boss!"
        '
        'Level3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.game.My.Resources.Resources.space__1_
        Me.ClientSize = New System.Drawing.Size(1489, 617)
        Me.Controls.Add(Me.replayButton)
        Me.Controls.Add(Me.gameover)
        Me.Controls.Add(Me.yay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.laser)
        Me.Controls.Add(Me.KirbyBar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.marx)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.Name = "Level3"
        Me.Text = "Level3"
        CType(Me.marx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents yay As PictureBox
    Friend WithEvents gameover As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents KirbyBar As ProgressBar
    Friend WithEvents replayButton As Button
    Friend WithEvents marx As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents laser As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label1 As Label
End Class
