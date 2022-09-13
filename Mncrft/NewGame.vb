Public Class NewGame
    Dim diffdesc As New DifficultyDescriptions
    Dim selecteddiff
    Private Sub NewGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Mncrft.MncrftGame.ThisGamesStats.Difficulty
            Case 0 ' peaceful
                RichTextBox1.Text = diffdesc.peaceful
                RadioButton1.Checked = True
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                RadioButton5.Checked = False
                RadioButton6.Checked = False
                RadioButton7.Checked = False
            Case 1 ' easy
                RichTextBox1.Text = diffdesc.easy
                RadioButton1.Checked = False
                RadioButton2.Checked = True
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                RadioButton5.Checked = False
                RadioButton6.Checked = False
                RadioButton7.Checked = False
            Case 2 ' normal
                RichTextBox1.Text = diffdesc.normal
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = True
                RadioButton4.Checked = False
                RadioButton5.Checked = False
                RadioButton6.Checked = False
                RadioButton7.Checked = False
            Case 3 ' hard
                RichTextBox1.Text = diffdesc.hard
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                RadioButton6.Checked = False
                RadioButton7.Checked = False
            Case 4 ' hardcore
                RichTextBox1.Text = diffdesc.hardcore
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                RadioButton6.Checked = False
                RadioButton7.Checked = False
            Case 5 ' nightmare
                RichTextBox1.Text = diffdesc.nightmare
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                RadioButton5.Checked = False
                RadioButton6.Checked = True
                RadioButton7.Checked = False
            Case 6 ' wasteland
                RichTextBox1.Text = diffdesc.wasteland
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                RadioButton5.Checked = False
                RadioButton6.Checked = False
                RadioButton7.Checked = True
            Case Else
                RichTextBox1.Text = diffdesc.UnknownDifficulty
        End Select
    End Sub

    Private Sub UpdateDiffDesc()
        Select Case selecteddiff
            Case 0 ' peaceful
                RichTextBox1.Text = diffdesc.peaceful
            Case 1 ' easy
                RichTextBox1.Text = diffdesc.easy
            Case 2 ' normal
                RichTextBox1.Text = diffdesc.normal
            Case 3 ' hard
                RichTextBox1.Text = diffdesc.hard
            Case 4 ' hardcore
                RichTextBox1.Text = diffdesc.hardcore
            Case 5 ' nightmare
                RichTextBox1.Text = diffdesc.nightmare
            Case 6 ' wasteland
                RichTextBox1.Text = diffdesc.wasteland
            Case Else
                RichTextBox1.Text = diffdesc.UnknownDifficulty
        End Select
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        selecteddiff = 0
        UpdateDiffDesc()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        selecteddiff = 1
        UpdateDiffDesc()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        selecteddiff = 2
        UpdateDiffDesc()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        selecteddiff = 3
        UpdateDiffDesc()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        selecteddiff = 4
        UpdateDiffDesc()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        selecteddiff = 5
        UpdateDiffDesc()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        selecteddiff = 6
        UpdateDiffDesc()
    End Sub

    Private Sub GetOffMyFRICKINGBOX(sender As Object, e As EventArgs) Handles RichTextBox1.Enter
        ActiveControl = GroupBox1 'what can I say? He clearly doesn't want you on his box.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selecteddiff > 4 Then
            Select Case MsgBox("You seem to have selected a difficulty that is not fair," & vbNewLine & "are you sure you want to start a new game with this difficulty?", MsgBoxStyle.YesNo, "Are you sure?")
                Case MsgBoxResult.Yes
                Case MsgBoxResult.No
                    Return
            End Select
        End If
        MncrftGame.StartNewGame(selecteddiff)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

Public Class DifficultyDescriptions
    Public peaceful As String = "Peaceful disables zombies entirely and 10 more base daily energy to allow you to build " &
                                "your base in peace, without any urgency or danger."

    Public easy As String = "Easy makes the game a little easier, with 5 more base daily energy, more effective torches, " &
                            "and less zombies."

    Public normal As String = "Normal is the base difficulty of the game."

    Public hard As String = "With 10 starting energy and more zombies per night, hard makes it a little harder to " &
                            "get your settlement off the ground."

    Public hardcore As String = "Starting energy cut to only 40, zombies added every night is sharply increased, resources " &
                                "are more scarce, and villagers are few and far between. Creating your " &
                                "empire will be harder than normal in this mode, it will put your resourcefulness to the test. " &
                                "Do you have what it takes to face hardcore?"

    Public nightmare As String = "Starting energy at only 30, zombies start at 16 and jump by 16 every night, torches do " &
                                    "nothing, resources are more scarce, villagers are few and far " &
                                    "between. Creating your empire will be much harder than normal in this mode. It will really " &
                                    "test your resourcefulness and persistence. Are you ready to build or die trying?"

    Public wasteland As String = "Beginning in a ruthless wasteland is a truly unfair challenge, with starting energy only at 20, " &
                                    "zombies starting at 20 and jumping by 20 every night, torches doing nothing, resources " &
                                    "being more scarce, less base daily energy, and villagers being near impossible to " &
                                    "find. If you manage to actually build a functioning base in this difficulty I will " &
                                    "honestly be amazed."

    Public UnknownDifficulty = "unknown difficulty"

End Class