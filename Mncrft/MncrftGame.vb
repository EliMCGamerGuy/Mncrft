Public Class MncrftGame
#Disable Warning BC42025
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        Process.Start("https://github.com/EliMCGamerGuy/Mncrft")
    End Sub

    Private Sub WikiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WikiToolStripMenuItem.Click
        Process.Start("https://github.com/EliMCGamerGuy/Mncrft/wiki#welcome-to-the-mncrft-wiki")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        EndDayButton.Enabled = True
    End Sub

    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Saved Game Files (*.sav*)|*.sav" 'set filter
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then 'show the window until the user closes it
            Dim tempstring = "" & 'First, save ActionCosts.
                Int(ThisGamesStats.Defense) & vbNewLine &
                Int(ThisGamesStats.Difficulty) & vbNewLine &
                Int(ThisGamesStats.NightScore) & vbNewLine &
                Int(ThisGamesStats.LastZombieCount) & vbNewLine &
                Int(ThisGamesStats.Offense) & vbNewLine &
                Int(ThisGamesStats.PersonalDefense) & vbNewLine &
                Int(ThisGamesStats.ActionCosts.AxeCost) & vbNewLine &
                Int(ThisGamesStats.ActionCosts.PickaxeCost) & vbNewLine & 'With ActionCosts done, let's reset Materials.
                Int(ThisGamesStats.Materials.Energy.Amount) & vbNewLine & 'Energy.
                Int(ThisGamesStats.Materials.Energy.NightlyAmount) & vbNewLine & 'Energy done.
                Int(ThisGamesStats.Materials.WoodAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.SticksAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.WoolAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.StoneAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.CoalAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.IronOreAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.GoldOreAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.IronIngotAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.GoldIngotAmount) & vbNewLine &
                Int(ThisGamesStats.Materials.DiamondsAmount) & vbNewLine & 'With Materials done, let's save buildings.
                Int(ThisGamesStats.Buildings.Bed.Amount) & vbNewLine &
                Int(ThisGamesStats.Buildings.House.Amount) & vbNewLine &
                Int(ThisGamesStats.Buildings.Tower.Amount) & vbNewLine &
                Int(ThisGamesStats.Buildings.GuardTower.Amount) & vbNewLine & 'With Buildings done, let's do items.
                Int(ThisGamesStats.Items.WoodenSword.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.WoodenPickaxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.WoodenAxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.StoneSword.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.StonePickaxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.StoneAxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.GoldSword.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.GoldPickaxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.GoldAxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.IronSword.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.IronPickaxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.IronAxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.DiamondSword.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.DiamondPickaxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.DiamondAxe.Amount) & vbNewLine &
                Int(ThisGamesStats.Items.FurnaceAmount) & vbNewLine &
                Int(ThisGamesStats.Items.TorchAmount) & vbNewLine & 'With Items done, let's do villagers.
                Int(ThisGamesStats.Villagers.GreenCoatAmount) & vbNewLine &
                Int(ThisGamesStats.Villagers.IronSmelterAmount) & vbNewLine &
                Int(ThisGamesStats.Villagers.GoldSmelterAmount) & vbNewLine &
                Int(ThisGamesStats.Villagers.ShepherdAmount) & vbNewLine & 'Guards.
                Int(ThisGamesStats.Villagers.Guard.Wood.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Guard.Stone.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Guard.Gold.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Guard.Iron.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Guard.Diamond.Amount) & vbNewLine & 'Lumberjacks.
                Int(ThisGamesStats.Villagers.Lumberjack.Wood.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Lumberjack.Stone.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Lumberjack.Gold.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Lumberjack.Iron.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Lumberjack.Diamond.Amount) & vbNewLine & 'Miners.
                Int(ThisGamesStats.Villagers.Miner.Wood.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Miner.Stone.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Miner.Gold.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Miner.Iron.Amount) & vbNewLine &
                Int(ThisGamesStats.Villagers.Miner.Diamond.Amount) & vbNewLine & 'And we're done!
                My.Application.Info.Version.ToString
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, tempstring, False)
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName.Replace(".sav", ".log"), RichTextBox1.Text, False)
            RichTextBox1.AppendText(vbNewLine & "Saved!")
        End If
    End Sub

    Private Sub LoadGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadGameToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Saved Game Files (*.sav*)|*.sav" 'set filter
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then 'show the window until the user closes it
            Dim tempstring = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName) 'read the file
            Dim parts As String() = tempstring.Split(New String() {Environment.NewLine}, StringSplitOptions.None) 'split the file into it's parts
            Dim ver As Version
            Try 'handler for this crashing and burning
                ver = Version.Parse(parts(60))
            Catch ex As Exception
                MsgBox("Version check threw error " & Str(ex), MsgBoxStyle.OkOnly, "Error")
                RichTextBox1.AppendText(vbNewLine & "Version check threw error " & Str(ex))
                Return
            End Try
            Dim compver = My.Application.Info.Version.CompareTo(ver)
            If compver < 0 Then
                Select Case MsgBox("This game was saved with a newer version of Mncrft!" & vbNewLine & "You can load the save here, but some data may be lost." & vbNewLine & "Do you want to load the game anyway?", MsgBoxStyle.YesNo, "Load?")
                    Case MsgBoxResult.Yes
                    Case MsgBoxResult.No
                        RichTextBox1.AppendText(vbNewLine & "Loading was canceled.")
                        Return
                End Select
            End If
            'Everything seems to be in order.
            'Alright, Gordon, your suit should keep you comfortable through all this...
            ThisGamesStats = New MncrftInfo 'LOAD! LOAD! LOAD! LOAD! LOAD!

            ThisGamesStats.Defense = parts(0)
            ThisGamesStats.Difficulty = parts(1)
            ThisGamesStats.NightScore = parts(2)
            ThisGamesStats.LastZombieCount = parts(3)
            ThisGamesStats.Offense = parts(4)
            ThisGamesStats.PersonalDefense = parts(5)
            ThisGamesStats.ActionCosts.AxeCost = parts(6)
            ThisGamesStats.ActionCosts.PickaxeCost = parts(7) 'With ActionCosts done, let's load Materials.
            ThisGamesStats.Materials.Energy.Amount = parts(8) 'Energy.
            ThisGamesStats.Materials.Energy.NightlyAmount = parts(9) 'Energy done.
            ThisGamesStats.Materials.WoodAmount = parts(10)
            ThisGamesStats.Materials.SticksAmount = parts(11)
            ThisGamesStats.Materials.WoolAmount = parts(12)
            ThisGamesStats.Materials.StoneAmount = parts(13)
            ThisGamesStats.Materials.CoalAmount = parts(14)
            ThisGamesStats.Materials.IronOreAmount = parts(15)
            ThisGamesStats.Materials.GoldOreAmount = parts(16)
            ThisGamesStats.Materials.IronIngotAmount = parts(17)
            ThisGamesStats.Materials.GoldIngotAmount = parts(18)
            ThisGamesStats.Materials.DiamondsAmount = parts(19) 'With Materials done, let's load buildings.
            ThisGamesStats.Buildings.Bed.Amount = parts(20)
            ThisGamesStats.Buildings.House.Amount = parts(21)
            ThisGamesStats.Buildings.Tower.Amount = parts(22)
            ThisGamesStats.Buildings.GuardTower.Amount = parts(23) 'With Buildings done, let's do items.
            ThisGamesStats.Items.WoodenSword.Amount = parts(24)
            ThisGamesStats.Items.WoodenPickaxe.Amount = parts(25)
            ThisGamesStats.Items.WoodenAxe.Amount = parts(26)
            ThisGamesStats.Items.StoneSword.Amount = parts(27)
            ThisGamesStats.Items.StonePickaxe.Amount = parts(28)
            ThisGamesStats.Items.StoneAxe.Amount = parts(29)
            ThisGamesStats.Items.GoldSword.Amount = parts(30)
            ThisGamesStats.Items.GoldPickaxe.Amount = parts(31)
            ThisGamesStats.Items.GoldAxe.Amount = parts(32)
            ThisGamesStats.Items.IronSword.Amount = parts(33)
            ThisGamesStats.Items.IronPickaxe.Amount = parts(34)
            ThisGamesStats.Items.IronAxe.Amount = parts(35)
            ThisGamesStats.Items.DiamondSword.Amount = parts(36)
            ThisGamesStats.Items.DiamondPickaxe.Amount = parts(37)
            ThisGamesStats.Items.DiamondAxe.Amount = parts(38)
            ThisGamesStats.Items.FurnaceAmount = parts(39)
            ThisGamesStats.Items.TorchAmount = parts(40) 'With Items done, let's do villagers.
            ThisGamesStats.Villagers.GreenCoatAmount = parts(41)
            ThisGamesStats.Villagers.IronSmelterAmount = parts(42)
            ThisGamesStats.Villagers.GoldSmelterAmount = parts(43)
            ThisGamesStats.Villagers.ShepherdAmount = parts(44) 'Guards.
            ThisGamesStats.Villagers.Guard.Wood.Amount = parts(45)
            ThisGamesStats.Villagers.Guard.Stone.Amount = parts(46)
            ThisGamesStats.Villagers.Guard.Gold.Amount = parts(47)
            ThisGamesStats.Villagers.Guard.Iron.Amount = parts(48)
            ThisGamesStats.Villagers.Guard.Diamond.Amount = parts(49) 'Lumberjacks.
            ThisGamesStats.Villagers.Lumberjack.Wood.Amount = parts(50)
            ThisGamesStats.Villagers.Lumberjack.Stone.Amount = parts(51)
            ThisGamesStats.Villagers.Lumberjack.Gold.Amount = parts(52)
            ThisGamesStats.Villagers.Lumberjack.Iron.Amount = parts(53)
            ThisGamesStats.Villagers.Lumberjack.Diamond.Amount = parts(54) 'Miners.
            ThisGamesStats.Villagers.Miner.Wood.Amount = parts(55)
            ThisGamesStats.Villagers.Miner.Stone.Amount = parts(56)
            ThisGamesStats.Villagers.Miner.Gold.Amount = parts(57)
            ThisGamesStats.Villagers.Miner.Iron.Amount = parts(58)
            ThisGamesStats.Villagers.Miner.Diamond.Amount = parts(59) 'And we're done!
            UpdateStatDisplay()
            Try
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName.Replace(".sav", ".log"))
                RichTextBox1.AppendText(vbNewLine & "Loaded successfully!")
            Catch ex As Exception
                RichTextBox1.Text = "Welcome to Mncrft!" & vbNewLine & "Something happened during loading of the log file, but otherwise loaded OK!"
            End Try
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Select Case MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit?")
            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No
                Return
        End Select
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

    End Sub
End Class
#Enable Warning BC42025