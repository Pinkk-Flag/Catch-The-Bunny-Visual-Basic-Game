Public Class Form1
    ' Made by Dario Gerald
    ' 08/11/23 12:23pm

    Dim deltax As Integer = 3
    Dim deltay As Integer = 3
    Dim deltax2 As Integer = 4
    Dim deltay2 As Integer = 4
    Dim Timecount As Integer = 0
    Dim anotherbunny As Boolean

    ' This function is called when the "End" menu item is clicked to close the application.
    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    ' This timer tick event is used to update the game state.
    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        ' Check boundaries and update position for picBunny
        If picBunny.Left < 0 Or picBunny.Left + picBunny.Width > pnlGameArea.Width Then
            deltax = -1 * deltax
        End If
        If picBunny.Top < 0 Or picBunny.Top + picBunny.Height > pnlGameArea.Height Then
            deltay = -1 * deltay
        End If
        picBunny.Left = picBunny.Left + deltax
        picBunny.Top = picBunny.Top + deltay

        If anotherbunny = True Then
            picBunny2.Visible = True

            ' Check boundaries and update position for picBunny2
            If picBunny2.Left < 0 Or picBunny2.Left + picBunny2.Width > pnlGameArea.Width Then
                deltax2 = -1 * deltax2
            End If
            If picBunny2.Top < 0 Or picBunny2.Top + picBunny2.Height > pnlGameArea.Height Then
                deltay2 = -1 * deltay2
            End If
            picBunny2.Left = picBunny2.Left + deltax2
            picBunny2.Top = picBunny2.Top + deltay2
        End If

        ' Update time count and check game over
        Timecount = Timecount + 1
        If Timecount = 50 Then
            lblTimeLeft.Text = Val(lblTimeLeft.Text) - 1
            Timecount = 0
        End If

        If Val(lblTimeLeft.Text) = 0 Then
            tmrGame.Enabled = False
            MsgBox("Game over!")
        End If
    End Sub

    ' This function is called when the game area panel is painted.
    Private Sub pnlGameArea_Paint(sender As Object, e As PaintEventArgs) Handles pnlGameArea.Paint
        pnlGameArea.Cursor = Cursors.Hand
        picBunny.Cursor = Cursors.Hand
        picBunny2.Cursor = Cursors.Hand
    End Sub

    ' This function is called when picBunny is clicked to increase the score.
    Private Sub picBunny_Click(sender As Object, e As EventArgs) Handles picBunny.Click
        If tmrGame.Enabled = True Then
            lblScore.Text = Val(lblScore.Text) + 1
        End If
    End Sub

    ' This function is called when the "Start" menu item is clicked to begin the game.
    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        tmrGame.Enabled = True
        lblScore.Text = "0"
        lblTimeLeft.Text = "20"
        deltax = 3
        deltay = 3
        Timecount = 0
    End Sub

    ' This function is called when the form is loaded and initializes some variables.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBunny2.Visible = False
        anotherbunny = False
        picBunny2.Visible = False
    End Sub

    ' This function is called when the "Bunny2" checkbox state changes.
    Private Sub chkBunny2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBunny2.CheckedChanged
        If chkBunny2.Checked = True Then
            anotherbunny = True
        Else
            anotherbunny = False
            picBunny2.Visible = False
        End If
    End Sub

    ' These radio button events adjust the game difficulty.
    Private Sub radEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        If radEasy.Checked = True Then
            deltax = 2
            deltay = 2
            deltax2 = 3
            deltay2 = 3
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        If radMedium.Checked = True Then
            deltax = 4
            deltay = 4
            deltax2 = 5
            deltay2 = 5
        End If
    End Sub

    Private Sub radHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        If radHard.Checked = True Then
            deltax = 7
            deltay = 7
            deltax2 = 8
            deltay2 = 8
        End If
    End Sub
End Class
