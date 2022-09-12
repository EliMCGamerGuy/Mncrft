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
        SaveFileDialog1.Filter = "Saved Game Files (*.sav*)|*.sav"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
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
            RichTextBox1.AppendText(vbNewLine & "Saved!")
        End If
    End Sub

    Private Sub LoadGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadGameToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Saved Game Files (*.sav*)|*.sav"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim tempstring = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Dim parts As String() = tempstring.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)


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
End Class
#Enable Warning BC42025