<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlGameArea = New System.Windows.Forms.Panel()
        Me.picBunny2 = New System.Windows.Forms.PictureBox()
        Me.picBunny = New System.Windows.Forms.PictureBox()
        Me.main = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.chkBunny2 = New System.Windows.Forms.CheckBox()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlGameArea.SuspendLayout()
        CType(Me.picBunny2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBunny, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(64, 29)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'pnlGameArea
        '
        Me.pnlGameArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGameArea.Controls.Add(Me.picBunny2)
        Me.pnlGameArea.Controls.Add(Me.picBunny)
        Me.pnlGameArea.Location = New System.Drawing.Point(84, 113)
        Me.pnlGameArea.Name = "pnlGameArea"
        Me.pnlGameArea.Size = New System.Drawing.Size(524, 508)
        Me.pnlGameArea.TabIndex = 1
        '
        'picBunny2
        '
        Me.picBunny2.Image = Global.Catch_the_bunny_game.My.Resources.Resources.BUNNY
        Me.picBunny2.Location = New System.Drawing.Point(334, 288)
        Me.picBunny2.Name = "picBunny2"
        Me.picBunny2.Size = New System.Drawing.Size(48, 63)
        Me.picBunny2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBunny2.TabIndex = 1
        Me.picBunny2.TabStop = False
        '
        'picBunny
        '
        Me.picBunny.Image = Global.Catch_the_bunny_game.My.Resources.Resources.BUNNY
        Me.picBunny.Location = New System.Drawing.Point(127, 81)
        Me.picBunny.Name = "picBunny"
        Me.picBunny.Size = New System.Drawing.Size(48, 63)
        Me.picBunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBunny.TabIndex = 0
        Me.picBunny.TabStop = False
        '
        'main
        '
        Me.main.AutoSize = True
        Me.main.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.main.Location = New System.Drawing.Point(229, 33)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(316, 48)
        Me.main.TabIndex = 2
        Me.main.Text = "Catch The Bunny!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(646, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(677, 158)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 45)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(627, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 45)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time Left"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeLeft.Location = New System.Drawing.Point(677, 288)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(38, 45)
        Me.lblTimeLeft.TabIndex = 6
        Me.lblTimeLeft.Text = "0"
        '
        'chkBunny2
        '
        Me.chkBunny2.AutoSize = True
        Me.chkBunny2.Location = New System.Drawing.Point(614, 359)
        Me.chkBunny2.Name = "chkBunny2"
        Me.chkBunny2.Size = New System.Drawing.Size(203, 29)
        Me.chkBunny2.TabIndex = 7
        Me.chkBunny2.Text = "Add a second bunny"
        Me.chkBunny2.UseVisualStyleBackColor = True
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Location = New System.Drawing.Point(614, 401)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(124, 29)
        Me.radEasy.TabIndex = 8
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy Mode"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(614, 436)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(155, 29)
        Me.radMedium.TabIndex = 9
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium Mode"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(614, 471)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(128, 29)
        Me.radHard.TabIndex = 10
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard Mode"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 657)
        Me.Controls.Add(Me.radHard)
        Me.Controls.Add(Me.radMedium)
        Me.Controls.Add(Me.radEasy)
        Me.Controls.Add(Me.chkBunny2)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.pnlGameArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlGameArea.ResumeLayout(False)
        CType(Me.picBunny2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBunny, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrGame As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents picBunny As PictureBox
    Friend WithEvents main As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents picBunny2 As PictureBox
    Friend WithEvents chkBunny2 As CheckBox
    Friend WithEvents radEasy As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radHard As RadioButton
End Class
