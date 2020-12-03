<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level2
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.replayButton = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.fireBird = New System.Windows.Forms.PictureBox()
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.gameover = New System.Windows.Forms.PictureBox()
        Me.yay = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.KirbyBar = New System.Windows.Forms.ProgressBar()
        Me.Fire = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fireBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'replayButton
        '
        Me.replayButton.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replayButton.Location = New System.Drawing.Point(611, 568)
        Me.replayButton.Name = "replayButton"
        Me.replayButton.Size = New System.Drawing.Size(166, 159)
        Me.replayButton.TabIndex = 21
        Me.replayButton.Text = "Retry"
        Me.replayButton.UseVisualStyleBackColor = True
        Me.replayButton.Visible = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'fireBird
        '
        Me.fireBird.BackColor = System.Drawing.Color.Transparent
        Me.fireBird.Image = Global.game.My.Resources.Resources.dyna_blade__1_
        Me.fireBird.Location = New System.Drawing.Point(981, 262)
        Me.fireBird.Name = "fireBird"
        Me.fireBird.Size = New System.Drawing.Size(403, 355)
        Me.fireBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fireBird.TabIndex = 23
        Me.fireBird.TabStop = False
        Me.fireBird.Visible = False
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.Image = Global.game.My.Resources.Resources.d2riyf8_a236a3f4_33ea_4336_a771_77c54796a608
        Me.bird.Location = New System.Drawing.Point(741, 61)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(403, 355)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird.TabIndex = 22
        Me.bird.TabStop = False
        '
        'gameover
        '
        Me.gameover.BackColor = System.Drawing.Color.Transparent
        Me.gameover.Image = Global.game.My.Resources.Resources.gameover
        Me.gameover.Location = New System.Drawing.Point(381, 241)
        Me.gameover.Name = "gameover"
        Me.gameover.Size = New System.Drawing.Size(634, 321)
        Me.gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gameover.TabIndex = 20
        Me.gameover.TabStop = False
        Me.gameover.Visible = False
        '
        'yay
        '
        Me.yay.BackColor = System.Drawing.Color.Transparent
        Me.yay.Image = Global.game.My.Resources.Resources.win2
        Me.yay.Location = New System.Drawing.Point(332, 241)
        Me.yay.Name = "yay"
        Me.yay.Size = New System.Drawing.Size(683, 321)
        Me.yay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.yay.TabIndex = 19
        Me.yay.TabStop = False
        Me.yay.Visible = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = Global.game.My.Resources.Resources.star
        Me.Bullet.Location = New System.Drawing.Point(12, 449)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(83, 83)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 18
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox2.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox2.Location = New System.Drawing.Point(101, 373)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.game.My.Resources.Resources.starship__1_
        Me.PictureBox1.Location = New System.Drawing.Point(60, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Teal
        Me.ProgressBar1.ForeColor = System.Drawing.Color.HotPink
        Me.ProgressBar1.Location = New System.Drawing.Point(41, 41)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(499, 23)
        Me.ProgressBar1.TabIndex = 24
        Me.ProgressBar1.Value = 100
        '
        'KirbyBar
        '
        Me.KirbyBar.Location = New System.Drawing.Point(41, 758)
        Me.KirbyBar.Name = "KirbyBar"
        Me.KirbyBar.Size = New System.Drawing.Size(252, 23)
        Me.KirbyBar.TabIndex = 25
        Me.KirbyBar.Value = 100
        '
        'Fire
        '
        Me.Fire.BackColor = System.Drawing.Color.Transparent
        Me.Fire.Image = Global.game.My.Resources.Resources.fire
        Me.Fire.Location = New System.Drawing.Point(858, 609)
        Me.Fire.Name = "Fire"
        Me.Fire.Size = New System.Drawing.Size(182, 154)
        Me.Fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fire.TabIndex = 27
        Me.Fire.TabStop = False
        Me.Fire.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Defeat the boss!"
        '
        'Level2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.game.My.Resources.Resources.sky
        Me.ClientSize = New System.Drawing.Size(1396, 803)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.replayButton)
        Me.Controls.Add(Me.gameover)
        Me.Controls.Add(Me.yay)
        Me.Controls.Add(Me.Fire)
        Me.Controls.Add(Me.fireBird)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.KirbyBar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.bird)
        Me.DoubleBuffered = True
        Me.Name = "Level2"
        Me.Text = "Level2"
        CType(Me.fireBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents yay As PictureBox
    Friend WithEvents gameover As PictureBox
    Friend WithEvents replayButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents bird As PictureBox
    Friend WithEvents fireBird As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents KirbyBar As ProgressBar
    Friend WithEvents Fire As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label1 As Label
End Class
