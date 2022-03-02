<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MncrftGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MncrftGame))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.gominingbutton = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.MaterialNumbers = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VillagerNumbers = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuildingNumbers = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.Gatherwoodbutton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatNumbers = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox9 = New System.Windows.Forms.RichTextBox()
        Me.smeltbutton = New System.Windows.Forms.Button()
        Me.EndDayButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.placetorchesbutton = New System.Windows.Forms.Button()
        Me.findsheepbutton = New System.Windows.Forms.Button()
        Me.findvillagersbutton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.hirefirebutton = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Hirehirebutton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ItemNumbers = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox11 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.craftdisassemblebutton = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Craftcraftbutton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Builddismantlebutton = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.BuildBuildbutton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.CausesValidation = False
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(411, 411)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = ""
        '
        'gominingbutton
        '
        Me.gominingbutton.Location = New System.Drawing.Point(6, 48)
        Me.gominingbutton.Name = "gominingbutton"
        Me.gominingbutton.Size = New System.Drawing.Size(120, 23)
        Me.gominingbutton.TabIndex = 1
        Me.gominingbutton.Text = "Go mining (0)"
        Me.gominingbutton.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(641, 25)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox2.Size = New System.Drawing.Size(90, 150)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = "Energy" & Global.Microsoft.VisualBasic.ChrW(10) & "Wood" & Global.Microsoft.VisualBasic.ChrW(10) & "Sticks" & Global.Microsoft.VisualBasic.ChrW(10) & "Wool" & Global.Microsoft.VisualBasic.ChrW(10) & "Stone" & Global.Microsoft.VisualBasic.ChrW(10) & "Coal" & Global.Microsoft.VisualBasic.ChrW(10) & "Iron Ore" & Global.Microsoft.VisualBasic.ChrW(10) & "Smelted Iron" & Global.Microsoft.VisualBasic.ChrW(10) & "Gold Ore" & Global.Microsoft.VisualBasic.ChrW(10) & "Smelted Gold" & Global.Microsoft.VisualBasic.ChrW(10) & "Di" &
    "amonds"
        Me.RichTextBox2.WordWrap = False
        '
        'MaterialNumbers
        '
        Me.MaterialNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialNumbers.Location = New System.Drawing.Point(759, 25)
        Me.MaterialNumbers.Name = "MaterialNumbers"
        Me.MaterialNumbers.ReadOnly = True
        Me.MaterialNumbers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.MaterialNumbers.Size = New System.Drawing.Size(63, 150)
        Me.MaterialNumbers.TabIndex = 3
        Me.MaterialNumbers.Text = "60" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.MaterialNumbers.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(645, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Materials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(645, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Villagers"
        '
        'VillagerNumbers
        '
        Me.VillagerNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VillagerNumbers.Location = New System.Drawing.Point(759, 190)
        Me.VillagerNumbers.Name = "VillagerNumbers"
        Me.VillagerNumbers.ReadOnly = True
        Me.VillagerNumbers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.VillagerNumbers.Size = New System.Drawing.Size(62, 255)
        Me.VillagerNumbers.TabIndex = 6
        Me.VillagerNumbers.Text = "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.VillagerNumbers.WordWrap = False
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Location = New System.Drawing.Point(641, 190)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox5.Size = New System.Drawing.Size(112, 255)
        Me.RichTextBox5.TabIndex = 5
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        Me.RichTextBox5.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buildings"
        '
        'BuildingNumbers
        '
        Me.BuildingNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BuildingNumbers.Location = New System.Drawing.Point(546, 25)
        Me.BuildingNumbers.Name = "BuildingNumbers"
        Me.BuildingNumbers.ReadOnly = True
        Me.BuildingNumbers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.BuildingNumbers.Size = New System.Drawing.Size(62, 59)
        Me.BuildingNumbers.TabIndex = 9
        Me.BuildingNumbers.Text = "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BuildingNumbers.WordWrap = False
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox7.Location = New System.Drawing.Point(428, 25)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.ReadOnly = True
        Me.RichTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox7.Size = New System.Drawing.Size(90, 59)
        Me.RichTextBox7.TabIndex = 8
        Me.RichTextBox7.Text = "Beds" & Global.Microsoft.VisualBasic.ChrW(10) & "Houses" & Global.Microsoft.VisualBasic.ChrW(10) & "Towers" & Global.Microsoft.VisualBasic.ChrW(10) & "Guard Towers" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox7.WordWrap = False
        '
        'Gatherwoodbutton
        '
        Me.Gatherwoodbutton.Location = New System.Drawing.Point(6, 19)
        Me.Gatherwoodbutton.Name = "Gatherwoodbutton"
        Me.Gatherwoodbutton.Size = New System.Drawing.Size(120, 23)
        Me.Gatherwoodbutton.TabIndex = 11
        Me.Gatherwoodbutton.Text = "Gather Wood (10)"
        Me.Gatherwoodbutton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Statistics"
        '
        'StatNumbers
        '
        Me.StatNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatNumbers.Location = New System.Drawing.Point(546, 101)
        Me.StatNumbers.Name = "StatNumbers"
        Me.StatNumbers.ReadOnly = True
        Me.StatNumbers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.StatNumbers.Size = New System.Drawing.Size(62, 69)
        Me.StatNumbers.TabIndex = 13
        Me.StatNumbers.Text = "0" & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "10" & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.StatNumbers.WordWrap = False
        '
        'RichTextBox9
        '
        Me.RichTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox9.Location = New System.Drawing.Point(428, 101)
        Me.RichTextBox9.Name = "RichTextBox9"
        Me.RichTextBox9.ReadOnly = True
        Me.RichTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox9.Size = New System.Drawing.Size(90, 69)
        Me.RichTextBox9.TabIndex = 12
        Me.RichTextBox9.Text = "Defense" & Global.Microsoft.VisualBasic.ChrW(10) & "Personal Defense" & Global.Microsoft.VisualBasic.ChrW(10) & "Offense" & Global.Microsoft.VisualBasic.ChrW(10) & "Daily Energy" & Global.Microsoft.VisualBasic.ChrW(10) & "Days Survived" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox9.WordWrap = False
        '
        'smeltbutton
        '
        Me.smeltbutton.Location = New System.Drawing.Point(6, 39)
        Me.smeltbutton.Name = "smeltbutton"
        Me.smeltbutton.Size = New System.Drawing.Size(265, 23)
        Me.smeltbutton.TabIndex = 22
        Me.smeltbutton.Text = "Smelt"
        Me.smeltbutton.UseVisualStyleBackColor = True
        '
        'EndDayButton
        '
        Me.EndDayButton.Location = New System.Drawing.Point(6, 113)
        Me.EndDayButton.Name = "EndDayButton"
        Me.EndDayButton.Size = New System.Drawing.Size(239, 23)
        Me.EndDayButton.TabIndex = 23
        Me.EndDayButton.Text = "End Day"
        Me.EndDayButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.placetorchesbutton)
        Me.GroupBox1.Controls.Add(Me.findsheepbutton)
        Me.GroupBox1.Controls.Add(Me.findvillagersbutton)
        Me.GroupBox1.Controls.Add(Me.Gatherwoodbutton)
        Me.GroupBox1.Controls.Add(Me.gominingbutton)
        Me.GroupBox1.Controls.Add(Me.EndDayButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 142)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'placetorchesbutton
        '
        Me.placetorchesbutton.Location = New System.Drawing.Point(6, 77)
        Me.placetorchesbutton.Name = "placetorchesbutton"
        Me.placetorchesbutton.Size = New System.Drawing.Size(239, 23)
        Me.placetorchesbutton.TabIndex = 14
        Me.placetorchesbutton.Text = "Place Torches (5 Energy, 4 Torches)"
        Me.placetorchesbutton.UseVisualStyleBackColor = True
        '
        'findsheepbutton
        '
        Me.findsheepbutton.Location = New System.Drawing.Point(125, 19)
        Me.findsheepbutton.Name = "findsheepbutton"
        Me.findsheepbutton.Size = New System.Drawing.Size(120, 23)
        Me.findsheepbutton.TabIndex = 13
        Me.findsheepbutton.Text = "Find Sheep (20)"
        Me.findsheepbutton.UseVisualStyleBackColor = True
        '
        'findvillagersbutton
        '
        Me.findvillagersbutton.Location = New System.Drawing.Point(125, 48)
        Me.findvillagersbutton.Name = "findvillagersbutton"
        Me.findvillagersbutton.Size = New System.Drawing.Size(120, 23)
        Me.findvillagersbutton.TabIndex = 12
        Me.findvillagersbutton.Text = "Find Villagers (40)"
        Me.findvillagersbutton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.smeltbutton)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(546, 510)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 68)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Smelt"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1 Smelted Iron (1 Iron Ore, 1 Coal)", "1 Smelted Gold (1 Gold Ore, 1 Coal)"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(265, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.hirefirebutton)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.Hirehirebutton)
        Me.GroupBox3.Location = New System.Drawing.Point(546, 436)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 68)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hire"
        '
        'hirefirebutton
        '
        Me.hirefirebutton.Location = New System.Drawing.Point(139, 39)
        Me.hirefirebutton.Name = "hirefirebutton"
        Me.hirefirebutton.Size = New System.Drawing.Size(130, 23)
        Me.hirefirebutton.TabIndex = 24
        Me.hirefirebutton.Text = "Fire"
        Me.hirefirebutton.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Wood Guard (1 Villager, 1 Wooden Sword)", "Wood Miner (1 Villager, 1 Wooden Pickaxe", "Wood Lumberjack (1 Villager, 1 Wooden Axe)", "Stone Guard (1 Villager, 1 Stone Sword)", "Stone Miner (1 Villager, 1 Stone Pickaxe)", "Stone Lumberjack (1 Villager, 1 Stone Axe)", "Iron Guard (1 Villager, 1 Iron Sword)", "Iron Miner (1 Villager, 1 Iron Pickaxe)", "Iron Lumberjack (1 Villager, 1 Iron Axe)", "Gold Guard (1 Villager, 1 Golden Sword)", "Gold Miner (1 Villager, 1 Golden Pickaxe)", "Gold Lumberjack (1 Villager, 1 Golden Axe)", "Diamond Guard (1 Villager, 1 Diamond Sword)", "Diamond Miner (1 Villager, 1 Diamond Pickaxe)", "Diamond Lumberjack (1 Villager, 1 Diamond Axe)", "Iron Smelter (1 Villager, 1 Furnace)", "Gold Smelter (1 Villager, 1 Furnace)", "Shepherd (1 Villager, 1 Stick)"})
        Me.ComboBox2.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(265, 21)
        Me.ComboBox2.TabIndex = 23
        '
        'Hirehirebutton
        '
        Me.Hirehirebutton.Location = New System.Drawing.Point(6, 39)
        Me.Hirehirebutton.Name = "Hirehirebutton"
        Me.Hirehirebutton.Size = New System.Drawing.Size(130, 23)
        Me.Hirehirebutton.TabIndex = 22
        Me.Hirehirebutton.Text = "Hire"
        Me.Hirehirebutton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Items"
        '
        'ItemNumbers
        '
        Me.ItemNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemNumbers.Location = New System.Drawing.Point(546, 190)
        Me.ItemNumbers.Name = "ItemNumbers"
        Me.ItemNumbers.ReadOnly = True
        Me.ItemNumbers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.ItemNumbers.Size = New System.Drawing.Size(62, 226)
        Me.ItemNumbers.TabIndex = 28
        Me.ItemNumbers.Text = "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.ItemNumbers.WordWrap = False
        '
        'RichTextBox11
        '
        Me.RichTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox11.Location = New System.Drawing.Point(428, 190)
        Me.RichTextBox11.Name = "RichTextBox11"
        Me.RichTextBox11.ReadOnly = True
        Me.RichTextBox11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox11.Size = New System.Drawing.Size(90, 226)
        Me.RichTextBox11.TabIndex = 27
        Me.RichTextBox11.Text = resources.GetString("RichTextBox11.Text")
        Me.RichTextBox11.WordWrap = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.craftdisassemblebutton)
        Me.GroupBox4.Controls.Add(Me.ComboBox3)
        Me.GroupBox4.Controls.Add(Me.Craftcraftbutton)
        Me.GroupBox4.Location = New System.Drawing.Point(269, 510)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 68)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Craft"
        '
        'craftdisassemblebutton
        '
        Me.craftdisassemblebutton.Location = New System.Drawing.Point(138, 39)
        Me.craftdisassemblebutton.Name = "craftdisassemblebutton"
        Me.craftdisassemblebutton.Size = New System.Drawing.Size(130, 23)
        Me.craftdisassemblebutton.TabIndex = 24
        Me.craftdisassemblebutton.Text = "Disassemble"
        Me.craftdisassemblebutton.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"4 Sticks (2 Wood)", "Furnace (8 Stone)", "Wooden Sword (2 Wood, 1 Stick)", "Wooden Pickaxe (3 Wood, 2 Sticks)", "Wooden Axe (3 Wood, 2 Sticks)", "Stone Sword (2 Stone, 1 Stick)", "Stone Pickaxe (3 Stone, 2 Sticks)", "Stone Axe (3 Stone, 2 Sticks)", "Iron Sword (2 Smelted Iron, 1 Stick)", "Iron Pickaxe (3 Smelted Iron, 2 Sticks)", "Iron Axe (3 Smelted Iron, 2 Sticks", "Gold Sword (2 Smelted Gold, 1 Stick)", "Gold Pickaxe (3 Smelted Gold, 2 Sticks)", "Gold Axe (3 Smelted Gold, 2 Sticks)", "Diamond Sword (2 Diamonds, 1 Stick) ", "Diamond Pickaxe (3 Diamonds, 2 Sticks)", "Diamond Axe (3 Diamonds, 2 Sticks)", "4 Torches (1 Coal, 1 Stick)"})
        Me.ComboBox3.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(262, 21)
        Me.ComboBox3.TabIndex = 23
        '
        'Craftcraftbutton
        '
        Me.Craftcraftbutton.Location = New System.Drawing.Point(6, 39)
        Me.Craftcraftbutton.Name = "Craftcraftbutton"
        Me.Craftcraftbutton.Size = New System.Drawing.Size(130, 23)
        Me.Craftcraftbutton.TabIndex = 22
        Me.Craftcraftbutton.Text = "Craft"
        Me.Craftcraftbutton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Builddismantlebutton)
        Me.GroupBox5.Controls.Add(Me.ComboBox4)
        Me.GroupBox5.Controls.Add(Me.BuildBuildbutton)
        Me.GroupBox5.Location = New System.Drawing.Point(269, 436)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(274, 68)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Build"
        '
        'Builddismantlebutton
        '
        Me.Builddismantlebutton.Location = New System.Drawing.Point(138, 39)
        Me.Builddismantlebutton.Name = "Builddismantlebutton"
        Me.Builddismantlebutton.Size = New System.Drawing.Size(130, 23)
        Me.Builddismantlebutton.TabIndex = 24
        Me.Builddismantlebutton.Text = "Dismantle"
        Me.Builddismantlebutton.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Bed (3 Wool, 3 Wood)", "House (10 Wood, 10 Stone)", "Tower (30 Stone)", "Guard Tower (80 Stone, 1 Jobless villager, 1 Iron sword)"})
        Me.ComboBox4.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(262, 21)
        Me.ComboBox4.TabIndex = 23
        '
        'BuildBuildbutton
        '
        Me.BuildBuildbutton.Location = New System.Drawing.Point(6, 39)
        Me.BuildBuildbutton.Name = "BuildBuildbutton"
        Me.BuildBuildbutton.Size = New System.Drawing.Size(130, 23)
        Me.BuildBuildbutton.TabIndex = 22
        Me.BuildBuildbutton.Text = "Build"
        Me.BuildBuildbutton.UseVisualStyleBackColor = True
        '
        'MncrftGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(829, 590)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ItemNumbers)
        Me.Controls.Add(Me.RichTextBox11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StatNumbers)
        Me.Controls.Add(Me.RichTextBox9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BuildingNumbers)
        Me.Controls.Add(Me.RichTextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VillagerNumbers)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialNumbers)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "MncrftGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mncrft"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents gominingbutton As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents MaterialNumbers As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VillagerNumbers As RichTextBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BuildingNumbers As RichTextBox
    Friend WithEvents RichTextBox7 As RichTextBox
    Friend WithEvents Gatherwoodbutton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents StatNumbers As RichTextBox
    Friend WithEvents RichTextBox9 As RichTextBox
    Friend WithEvents smeltbutton As Button
    Friend WithEvents EndDayButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Hirehirebutton As Button
    Friend WithEvents hirefirebutton As Button
    Friend WithEvents placetorchesbutton As Button
    Friend WithEvents findsheepbutton As Button
    Friend WithEvents findvillagersbutton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ItemNumbers As RichTextBox
    Friend WithEvents RichTextBox11 As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents craftdisassemblebutton As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Craftcraftbutton As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Builddismantlebutton As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents BuildBuildbutton As Button



    Private Sub MncrftGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'ThisGamesStats = New MncrftInfo()
        'ThisGamesStats.ActionCosts() = New MncrftInfo.ActionCosts()

        MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        MyBase.MaximizeBox = False
        RichTextBox1.Text = "Welcome to Mncrft!"
        RichTextBox1.HideSelection = False
        VBMath.Randomize()
        Call UpdateStatDisplay()
    End Sub



    Dim ThisGamesStats As New MncrftInfo


    Private Sub UpdateStatDisplay() 'IT'S THE LITTLE NUMBER PEOPLE!!!
        Call TWES() 'TWES, Tool and Weapon Equipment System!

        'set the buildings info
        BuildingNumbers.Text = ThisGamesStats.Buildings.Bed.Amount & vbNewLine & ThisGamesStats.Buildings.House.Amount & vbNewLine & ThisGamesStats.Buildings.Tower.Amount & vbNewLine & ThisGamesStats.Buildings.GuardTower.Amount
        'set the items info
        ItemNumbers.Text = ThisGamesStats.Items.WoodenSword.Amount & vbNewLine & ThisGamesStats.Items.WoodenPickaxe.Amount & vbNewLine & ThisGamesStats.Items.WoodenAxe.Amount & vbNewLine &
            ThisGamesStats.Items.StoneSword.Amount & vbNewLine & ThisGamesStats.Items.StonePickaxe.Amount & vbNewLine & ThisGamesStats.Items.StoneAxe.Amount & vbNewLine &
            ThisGamesStats.Items.IronSword.Amount & vbNewLine & ThisGamesStats.Items.IronPickaxe.Amount & vbNewLine & ThisGamesStats.Items.IronAxe.Amount & vbNewLine &
            ThisGamesStats.Items.GoldSword.Amount & vbNewLine & ThisGamesStats.Items.GoldPickaxe.Amount & vbNewLine & ThisGamesStats.Items.GoldAxe.Amount & vbNewLine &
            ThisGamesStats.Items.DiamondSword.Amount & vbNewLine & ThisGamesStats.Items.DiamondPickaxe.Amount & vbNewLine & ThisGamesStats.Items.DiamondAxe.Amount & vbNewLine &
            ThisGamesStats.Items.FurnaceAmount & vbNewLine & ThisGamesStats.Items.TorchAmount
        'set the materials info
        MaterialNumbers.Text = ThisGamesStats.Materials.Energy.Amount & vbNewLine & ThisGamesStats.Materials.WoodAmount & vbNewLine & ThisGamesStats.Materials.SticksAmount & vbNewLine &
            ThisGamesStats.Materials.WoolAmount & vbNewLine & ThisGamesStats.Materials.StoneAmount & vbNewLine & ThisGamesStats.Materials.CoalAmount & vbNewLine &
            ThisGamesStats.Materials.IronOreAmount & vbNewLine & ThisGamesStats.Materials.IronIngotAmount & vbNewLine & ThisGamesStats.Materials.GoldOreAmount & vbNewLine &
            ThisGamesStats.Materials.GoldIngotAmount & vbNewLine & ThisGamesStats.Materials.DiamondsAmount
        'set the statistics info
        StatNumbers.Text = ThisGamesStats.Defense & vbNewLine & ThisGamesStats.PersonalDefense & vbNewLine & ThisGamesStats.Offense & vbNewLine & ThisGamesStats.Materials.Energy.NightlyAmount & vbNewLine & ThisGamesStats.NightScore
        'set the villagers' info
        VillagerNumbers.Text = ThisGamesStats.Villagers.GreenCoatAmount & vbNewLine & ThisGamesStats.Villagers.Guard.Wood.Amount & vbNewLine & ThisGamesStats.Villagers.Guard.Stone.Amount _
            & vbNewLine & ThisGamesStats.Villagers.Guard.Iron.Amount & vbNewLine & ThisGamesStats.Villagers.Guard.Gold.Amount & vbNewLine & ThisGamesStats.Villagers.Guard.Diamond.Amount _
            & vbNewLine & ThisGamesStats.Villagers.Lumberjack.Wood.Amount & vbNewLine & ThisGamesStats.Villagers.Lumberjack.Stone.Amount & vbNewLine & ThisGamesStats.Villagers.Lumberjack.Iron.Amount _
            & vbNewLine & ThisGamesStats.Villagers.Lumberjack.Gold.Amount & vbNewLine & ThisGamesStats.Villagers.Lumberjack.Diamond.Amount & vbNewLine & ThisGamesStats.Villagers.Miner.Wood.Amount _
            & vbNewLine & ThisGamesStats.Villagers.Miner.Stone.Amount & vbNewLine & ThisGamesStats.Villagers.Miner.Iron.Amount & vbNewLine & ThisGamesStats.Villagers.Miner.Gold.Amount _
            & vbNewLine & ThisGamesStats.Villagers.Miner.Diamond.Amount & vbNewLine & ThisGamesStats.Villagers.IronSmelterAmount & vbNewLine & ThisGamesStats.Villagers.GoldSmelterAmount _
            & vbNewLine & ThisGamesStats.Villagers.ShepherdAmount
    End Sub



    Private Sub GetOffMyFRICKINGBOX(sender As Object, e As EventArgs) Handles RichTextBox1.Enter, RichTextBox11.Enter, RichTextBox2.Enter, RichTextBox5.Enter, RichTextBox7.Enter, RichTextBox9.Enter, BuildingNumbers.Enter, ItemNumbers.Enter, MaterialNumbers.Enter, StatNumbers.Enter, VillagerNumbers.Enter
        ActiveControl = GroupBox1 'what can I say? He clearly doesn't want you on his box.
    End Sub



    Private Sub Gatherwoodbutton_Click(sender As Object, e As EventArgs) Handles Gatherwoodbutton.Click 'Advancement made: CAVEMAN HATE TREE

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        If ThisGamesStats.Materials.Energy.Amount < ThisGamesStats.ActionCosts.AxeCost Then 'check if the user has enough energy to gather wood. if they don't, kill the sub.
            RichTextBox1.AppendText(vbNewLine & "You don't have enough energy for this!")
            Exit Sub
        End If

        ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - ThisGamesStats.ActionCosts.AxeCost 'remove energy from ThisGamesStats
        Dim tempiterations As Integer = 0
        Dim targetiterations As Integer = Int(4 * Rnd()) + 1 'generate a number from 1 to 5
        Dim temptargetamount As Integer = 0
        While tempiterations < targetiterations
            Dim temprandom As Integer = Int(16 * Rnd()) + 4 'generate a number from 4 to 20
            ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + temprandom 'add gathered Wood.
            temptargetamount = temptargetamount + temprandom
            tempiterations = tempiterations + 1
        End While

        RichTextBox1.AppendText(vbNewLine & "You used 10 Energy gathering" & Str(temptargetamount) & " Wood from" & Str(targetiterations) & " Trees.") 'and tell the user/player about it

        Call UpdateStatDisplay() 'toss the logs to the little number people, they'll figure it out.
    End Sub



    Private Sub EndDayButton_Click(sender As Object, e As EventArgs) Handles EndDayButton.Click 'PLAYER ENDED DAY, RELEASE THE ZOMBIES!

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'press F to pay respects
            ThisGamesStats = New MncrftInfo
            Call UpdateStatDisplay()
            RichTextBox1.Text = "Welcome to Mncrft!"
            Exit Sub
        End If

        RichTextBox1.AppendText(vbNewLine & "The day turns to night...")
        Dim zombieamount As Integer = ThisGamesStats.LastZombieCount + Int(1 * Rnd()) + 1 + ThisGamesStats.NightScore
        ThisGamesStats.LastZombieCount = zombieamount
        RichTextBox1.AppendText(vbNewLine & Str(zombieamount) & " zombie(s) spawn...") 'report amount of zombies that spawn.
        zombieamount = zombieamount - ThisGamesStats.Offense
        zombieamount = zombieamount - ThisGamesStats.PersonalDefense
        If zombieamount < 1 Then 'high offense check
            RichTextBox1.AppendText(vbNewLine & "All" & Str(ThisGamesStats.LastZombieCount) & " zombie(s) were killed, moving on.")
            Call UpdateStatDisplay()
            Call CalculateDayStart()
            Exit Sub
        Else 'low offense check
            RichTextBox1.AppendText(vbNewLine & Str(ThisGamesStats.Offense + ThisGamesStats.PersonalDefense) & " zombie(s) were killed," & Str(zombieamount) & " remain.")
            zombieamount = zombieamount - ThisGamesStats.Defense
            If zombieamount < 1 Then 'high defense check
                RichTextBox1.AppendText(vbNewLine & "All remaining zombie(s) are stopped from entering your base thanks to your defenses, the sun starts rising and they all burn up in the daylight.")
                Call UpdateStatDisplay()
                Call CalculateDayStart()
                Exit Sub
            Else 'low defense check
                ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - zombieamount
                If ThisGamesStats.Materials.Energy.Amount < 1 Then 'death.png
                    RichTextBox1.AppendText(vbNewLine & "The remaining zombies overwhelm your defenses and start to attack you, unfortunately you do not have enough energy to fend them off, and also get overwhelmed." & vbNewLine & vbNewLine & "GAME OVER" & vbNewLine & "Days survived: " & Str(ThisGamesStats.NightScore))
                    ThisGamesStats.PlayerIsDead = True
                    Call UpdateStatDisplay()
                Else 'A MIRACLE HAPPENED! I'M WELL!
                    RichTextBox1.AppendText(vbNewLine & "The remaining zombies overwhelm your defenses and start to attack you, you expend " & Str(zombieamount) & " energy fending them off. That was close!")
                    Call UpdateStatDisplay()
                    Call CalculateDayStart()
                    Exit Sub
                End If
            End If
        End If
    End Sub



    Private Sub CalculateDayStart() 'Loopin' through all your villagers (if you have any) oh also energy right forgot about that
        ThisGamesStats.NightScore = ThisGamesStats.NightScore + 1
        ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount + ThisGamesStats.Materials.Energy.NightlyAmount
        RichTextBox1.AppendText(vbNewLine & "Sleeping through the night gave you" & Str(ThisGamesStats.Materials.Energy.NightlyAmount) & " energy.")


        Call UpdateStatDisplay() 'you probably shouldn't throw people. just count them yourself and tell the number people.
    End Sub



    Private Sub Craftcraftbutton_Click(sender As Object, e As EventArgs) Handles Craftcraftbutton.Click 'Nothin' like a good crafting table.

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        Select Case ComboBox3.SelectedIndex 'check case of crafting combobox
            Case 0 ' S T I C K S
                If ThisGamesStats.Materials.WoodAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount - 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 4
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted 4 sticks!")
                End If
            Case 1 ' F U R N A C E
                If ThisGamesStats.Materials.StoneAmount < 8 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 8
                    ThisGamesStats.Items.FurnaceAmount = ThisGamesStats.Items.FurnaceAmount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a furnace!")
                End If
            Case 2 ' W O O D E N   S W O R D
                If ThisGamesStats.Materials.WoodAmount < 2 Or ThisGamesStats.Materials.SticksAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount - 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 1
                    ThisGamesStats.Items.WoodenSword.Amount = ThisGamesStats.Items.WoodenSword.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a wooden sword!")
                End If
            Case 3 ' W O O D E N   P I C K A X E
                If ThisGamesStats.Materials.WoodAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.WoodenPickaxe.Amount = ThisGamesStats.Items.WoodenPickaxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a wooden pickaxe!")
                End If
            Case 4 ' wooden axe (i'm sorry but the spaced out text was too time-consuming to make.)
                If ThisGamesStats.Materials.WoodAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.WoodenAxe.Amount = ThisGamesStats.Items.WoodenAxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a wooden axe!")
                End If
            Case 5 ' stone sword
                If ThisGamesStats.Materials.StoneAmount < 2 Or ThisGamesStats.Materials.SticksAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 1
                    ThisGamesStats.Items.StoneSword.Amount = ThisGamesStats.Items.StoneSword.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a stone sword!")
                End If
            Case 6 ' stone pickaxe
                If ThisGamesStats.Materials.StoneAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.StonePickaxe.Amount = ThisGamesStats.Items.StonePickaxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a stone pickaxe!")
                End If
            Case 7 ' stone axe
                If ThisGamesStats.Materials.StoneAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.StoneAxe.Amount = ThisGamesStats.Items.StoneAxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a stone axe!")
                End If
            Case 8 ' iron sword
                If ThisGamesStats.Materials.IronIngotAmount < 2 Or ThisGamesStats.Materials.SticksAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount - 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 1
                    ThisGamesStats.Items.IronSword.Amount = ThisGamesStats.Items.IronSword.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a iron sword!")
                End If
            Case 9 ' iron pickaxe
                If ThisGamesStats.Materials.IronIngotAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.IronPickaxe.Amount = ThisGamesStats.Items.IronPickaxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a iron pickaxe!")
                End If
            Case 10 ' iron axe
                If ThisGamesStats.Materials.IronIngotAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.IronAxe.Amount = ThisGamesStats.Items.IronAxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a iron axe!")
                End If
            Case 11 ' gold sword
                If ThisGamesStats.Materials.GoldIngotAmount < 2 Or ThisGamesStats.Materials.SticksAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount - 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 1
                    ThisGamesStats.Items.GoldSword.Amount = ThisGamesStats.Items.GoldSword.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a gold sword!")
                End If
            Case 12 ' gold pickaxe
                If ThisGamesStats.Materials.GoldIngotAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.GoldPickaxe.Amount = ThisGamesStats.Items.GoldPickaxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a gold pickaxe!")
                End If
            Case 13 ' gold axe
                If ThisGamesStats.Materials.GoldIngotAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.GoldAxe.Amount = ThisGamesStats.Items.GoldAxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a gold axe!")
                End If
            Case 14 ' diamond sword
                If ThisGamesStats.Materials.DiamondsAmount < 2 Or ThisGamesStats.Materials.SticksAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount - 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 1
                    ThisGamesStats.Items.DiamondSword.Amount = ThisGamesStats.Items.DiamondSword.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a diamond sword!")
                End If
            Case 15 ' diamond pickaxe
                If ThisGamesStats.Materials.DiamondsAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.DiamondPickaxe.Amount = ThisGamesStats.Items.DiamondPickaxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a diamond pickaxe!")
                End If
            Case 16 ' diamond axe
                If ThisGamesStats.Materials.DiamondsAmount < 3 Or ThisGamesStats.Materials.SticksAmount < 2 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount - 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 2
                    ThisGamesStats.Items.DiamondAxe.Amount = ThisGamesStats.Items.DiamondAxe.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted a diamond axe!")
                End If
            Case 17 ' torches
                If ThisGamesStats.Materials.CoalAmount < 1 Or ThisGamesStats.Materials.SticksAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.CoalAmount = ThisGamesStats.Materials.CoalAmount - 1
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 1
                    ThisGamesStats.Items.TorchAmount = ThisGamesStats.Items.TorchAmount + 4
                    RichTextBox1.AppendText(vbNewLine & "Successfully crafted 4 torches!")
                End If
            Case Else
                RichTextBox1.AppendText(vbNewLine & "Please select a crafting recipe!")
        End Select
        Call UpdateStatDisplay() 'just chuck the product over to the itty bitty digit city, they'll be fine.
    End Sub



    Private Sub gominingbutton_Click(sender As Object, e As EventArgs) Handles gominingbutton.Click 'so we back in the mine...

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        Dim RandStoneAmount As Integer = Int(15 * Rnd()) + 10
        Dim RandCoalAmount As Integer = Int(12 * Rnd()) + 4
        Dim RandIronAmount As Integer = Int(14 * Rnd()) + 6
        Dim RandGoldAmount As Integer = Int(6 * Rnd()) + 4
        Dim RandDiamAmount As Integer = Int(2 * Rnd())
        Dim AllowIron As Boolean
        Dim AllowGold As Boolean
        Dim AllowDiam As Boolean

        If ThisGamesStats.Materials.Energy.Amount < ThisGamesStats.ActionCosts.PickaxeCost Then
            RichTextBox1.AppendText(vbNewLine & "You don't have the energy to effectively swing your pickaxe right now.")
            Exit Sub
        End If

        If ThisGamesStats.Items.DiamondPickaxe.Amount > 0 Then ' BAM! Diamond pick!
            RichTextBox1.AppendText(vbNewLine & "You used" + Str(ThisGamesStats.Items.DiamondPickaxe.EnergyCost) + " energy to go mining with your diamond pickaxe, you mined:")
            AllowIron = ThisGamesStats.Items.DiamondPickaxe.IronMinable
            AllowGold = ThisGamesStats.Items.DiamondPickaxe.GoldMinable
            AllowDiam = ThisGamesStats.Items.DiamondPickaxe.DiamMinable
            ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - ThisGamesStats.Items.DiamondPickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.IronPickaxe.Amount > 0 Then ' Isn't it iron pick
            RichTextBox1.AppendText(vbNewLine & "You used" + Str(ThisGamesStats.Items.IronPickaxe.EnergyCost) + " energy to go mining with your iron pickaxe, you mined:")
            AllowIron = ThisGamesStats.Items.IronPickaxe.IronMinable
            AllowGold = ThisGamesStats.Items.IronPickaxe.GoldMinable
            AllowDiam = ThisGamesStats.Items.IronPickaxe.DiamMinable
            ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - ThisGamesStats.Items.IronPickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.GoldPickaxe.Amount > 0 Then ' GOLD PICKAXE??? WHY GOLD???
            RichTextBox1.AppendText(vbNewLine & "You used" + Str(ThisGamesStats.Items.GoldPickaxe.EnergyCost) + " energy to go mining with your gold pickaxe, you mined:")
            AllowIron = ThisGamesStats.Items.GoldPickaxe.IronMinable
            AllowGold = ThisGamesStats.Items.GoldPickaxe.GoldMinable
            AllowDiam = ThisGamesStats.Items.GoldPickaxe.DiamMinable
            ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - ThisGamesStats.Items.GoldPickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.StonePickaxe.Amount > 0 Then ' TRUSTY STONE FRICKIN PICKAXE
            RichTextBox1.AppendText(vbNewLine & "You used" + Str(ThisGamesStats.Items.StonePickaxe.EnergyCost) + " energy to go mining with your stone pickaxe, you mined:")
            AllowIron = ThisGamesStats.Items.StonePickaxe.IronMinable
            AllowGold = ThisGamesStats.Items.StonePickaxe.GoldMinable
            AllowDiam = ThisGamesStats.Items.StonePickaxe.DiamMinable
            ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - ThisGamesStats.Items.StonePickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.WoodenPickaxe.Amount > 0 Then ' two-sided sharpened stick
            RichTextBox1.AppendText(vbNewLine & "You used" + Str(ThisGamesStats.Items.WoodenPickaxe.EnergyCost) + " energy to go mining with your wooden pickaxe, you mined:")
            AllowIron = ThisGamesStats.Items.WoodenPickaxe.IronMinable
            AllowGold = ThisGamesStats.Items.WoodenPickaxe.GoldMinable
            AllowDiam = ThisGamesStats.Items.WoodenPickaxe.DiamMinable
            ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - ThisGamesStats.Items.WoodenPickaxe.EnergyCost

        Else '  \/  NO  PICKAXE  \/
            RichTextBox1.AppendText(vbNewLine & "You're not going to get very far without a pickaxe.") 'what? why? why are you trying to mine without a pickaxe?
            Exit Sub
        End If

        ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + RandStoneAmount 'report mined amounts!
        RichTextBox1.AppendText(vbNewLine & "   " + Str(RandStoneAmount) + " Stone")

        ThisGamesStats.Materials.CoalAmount = ThisGamesStats.Materials.CoalAmount + RandCoalAmount
        RichTextBox1.AppendText(vbNewLine & "   " + Str(RandCoalAmount) + " Coal")
        If AllowIron Then
            ThisGamesStats.Materials.IronOreAmount = ThisGamesStats.Materials.IronOreAmount + RandIronAmount
            RichTextBox1.AppendText(vbNewLine & "   " + Str(RandIronAmount) + " Iron ore")
        End If
        If AllowGold Then
            ThisGamesStats.Materials.GoldOreAmount = ThisGamesStats.Materials.GoldOreAmount + RandGoldAmount
            RichTextBox1.AppendText(vbNewLine & "   " + Str(RandGoldAmount) + " Gold ore")
        End If
        If AllowDiam Then
            ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount + RandDiamAmount
            RichTextBox1.AppendText(vbNewLine & "   " + Str(RandDiamAmount) + " Diamonds")
        End If

        Call UpdateStatDisplay() ' just throw your rocks at the little number people, they'll know what to do.
    End Sub



    Private Sub placetorchesbutton_Click(sender As Object, e As EventArgs) Handles placetorchesbutton.Click 'couldn't think of a humorous comment for placing torches, guess I'm not that bright.

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        If ThisGamesStats.Materials.Energy.Amount < 5 Then
            RichTextBox1.AppendText(vbNewLine & "You must've done something seriously wrong to not have enough energy to place torches.")
            Exit Sub
        ElseIf ThisGamesStats.Items.TorchAmount < 4 Then
            RichTextBox1.AppendText(vbNewLine & "You don't have enough torches to do that.")
            Exit Sub
        End If

        ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - 5
        ThisGamesStats.Items.TorchAmount = ThisGamesStats.Items.TorchAmount - 4
        ThisGamesStats.LastZombieCount = ThisGamesStats.LastZombieCount - 5
        RichTextBox1.AppendText(vbNewLine & "You place down four torches in the area around your base, that should stop some of the zombies.")

        If ThisGamesStats.LastZombieCount < 0 Then 'don't allow negative zombies.
            ThisGamesStats.LastZombieCount = 0
        End If

        Call UpdateStatDisplay() 'send a telegram to the little number people in your computer to tell them what numbers to make.
    End Sub



    Private Sub TWES()
        Dim calculatedMiningCost As Integer ' MINING ENERGY COST

        If ThisGamesStats.Items.DiamondPickaxe.Amount > 0 Then ' best pickaxe
            calculatedMiningCost = ThisGamesStats.Items.DiamondPickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.IronPickaxe.Amount > 0 Then ' irno pcikaex
            calculatedMiningCost = ThisGamesStats.Items.IronPickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.GoldPickaxe.Amount > 0 Then ' haha silly puddy pickaxe
            calculatedMiningCost = ThisGamesStats.Items.GoldPickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.StonePickaxe.Amount > 0 Then ' pebblePick
            calculatedMiningCost = ThisGamesStats.Items.StonePickaxe.EnergyCost

        ElseIf ThisGamesStats.Items.WoodenPickaxe.Amount > 0 Then ' smacking a log against stone would be better
            calculatedMiningCost = ThisGamesStats.Items.WoodenPickaxe.EnergyCost
        Else
            calculatedMiningCost = 0
        End If

        ThisGamesStats.ActionCosts.PickaxeCost = calculatedMiningCost ' save calculated cost
        gominingbutton.Text = "Go Mining (" + Str(calculatedMiningCost) + ")" ' make button reflect saved cost


        Dim calculatedPerDef As Integer ' calculate Personal Defense
        If ThisGamesStats.Items.DiamondSword.Amount > 0 Then ' ye olde "slice 'n' dice"
            calculatedPerDef = ThisGamesStats.Items.DiamondSword.PerDef

        ElseIf ThisGamesStats.Items.IronSword.Amount > 0 Then ' i-ron shword
            calculatedPerDef = ThisGamesStats.Items.IronSword.PerDef

        ElseIf ThisGamesStats.Items.GoldSword.Amount > 0 Then ' haha butter knife
            calculatedPerDef = ThisGamesStats.Items.GoldSword.PerDef

        ElseIf ThisGamesStats.Items.StoneSword.Amount > 0 Then ' rockWeapon
            calculatedPerDef = ThisGamesStats.Items.StoneSword.PerDef

        ElseIf ThisGamesStats.Items.WoodenSword.Amount > 0 Then ' "...PICKS UP A YARD STICK, AND HOLDS IT LIKE A SAMURAI WARRIOR"
            calculatedPerDef = ThisGamesStats.Items.WoodenSword.PerDef
        Else
            calculatedPerDef = 0
        End If

        ThisGamesStats.PersonalDefense = calculatedPerDef ' save personal defense.


        If ThisGamesStats.Items.FurnaceAmount > 0 Then ' enable or disable smelting gui
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If


        Dim calculatedWoodcuttingCost As Integer 'WOODCUTTING ENERGY COST

        If ThisGamesStats.Items.DiamondAxe.Amount > 0 Then ' the best "choppy choppy"
            calculatedWoodcuttingCost = ThisGamesStats.Items.DiamondAxe.EnergyCost

        ElseIf ThisGamesStats.Items.IronAxe.Amount > 0 Then ' metal hatchet
            calculatedWoodcuttingCost = ThisGamesStats.Items.IronAxe.EnergyCost

        ElseIf ThisGamesStats.Items.GoldAxe.Amount > 0 Then ' cute soft little shiny axe
            calculatedWoodcuttingCost = ThisGamesStats.Items.GoldAxe.EnergyCost

        ElseIf ThisGamesStats.Items.StoneAxe.Amount > 0 Then ' one stick away from "ooga booga beat tree with rock"
            calculatedWoodcuttingCost = ThisGamesStats.Items.StoneAxe.EnergyCost

        ElseIf ThisGamesStats.Items.WoodenAxe.Amount > 0 Then ' *picks up fallen tree limb* *beats tree with it*
            calculatedWoodcuttingCost = ThisGamesStats.Items.WoodenAxe.EnergyCost
        Else
            calculatedWoodcuttingCost = 15
        End If

        ThisGamesStats.ActionCosts.AxeCost = calculatedWoodcuttingCost ' save calculated woodcutting cost.
        Gatherwoodbutton.Text = "Gather Wood (" + Str(calculatedWoodcuttingCost) + ")" ' reflect any changes on button


        Dim calculatedDefense As Integer ' tweedle dee
        Dim calculatedOffense As Integer ' and tweedle dum

        ThisGamesStats.Materials.Energy.NightlyAmount = ThisGamesStats.Buildings.Bed.DailyEnergyAddition * ThisGamesStats.Buildings.Bed.Amount + ThisGamesStats.Buildings.House.DailyEnergyAddition * ThisGamesStats.Buildings.House.Amount + 10 '*chugs 6,209.25 "5 hour energy" bottles*

        calculatedDefense = ThisGamesStats.Buildings.House.Amount * ThisGamesStats.Buildings.House.Defense + ThisGamesStats.Buildings.Tower.Defense * ThisGamesStats.Buildings.Tower.Amount + ThisGamesStats.Buildings.GuardTower.Defense * ThisGamesStats.Buildings.GuardTower.Amount

        calculatedOffense = ThisGamesStats.Buildings.GuardTower.Offense * ThisGamesStats.Buildings.GuardTower.Amount

        calculatedDefense = calculatedDefense + ThisGamesStats.Villagers.Guard.Wood.Amount * ThisGamesStats.Villagers.Guard.Wood.Defense +
            ThisGamesStats.Villagers.Guard.Stone.Amount * ThisGamesStats.Villagers.Guard.Stone.Defense + ' Hired villagers count too!
            ThisGamesStats.Villagers.Guard.Gold.Amount * ThisGamesStats.Villagers.Guard.Gold.Defense +
            ThisGamesStats.Villagers.Guard.Iron.Amount * ThisGamesStats.Villagers.Guard.Iron.Defense +
            ThisGamesStats.Villagers.Guard.Diamond.Amount * ThisGamesStats.Villagers.Guard.Diamond.Defense

        calculatedOffense = calculatedOffense + ThisGamesStats.Villagers.Guard.Wood.Amount * ThisGamesStats.Villagers.Guard.Wood.Offense +
            ThisGamesStats.Villagers.Guard.Stone.Amount * ThisGamesStats.Villagers.Guard.Stone.Offense +
            ThisGamesStats.Villagers.Guard.Gold.Amount * ThisGamesStats.Villagers.Guard.Gold.Offense +
            ThisGamesStats.Villagers.Guard.Iron.Amount * ThisGamesStats.Villagers.Guard.Iron.Offense +
            ThisGamesStats.Villagers.Guard.Diamond.Amount * ThisGamesStats.Villagers.Guard.Diamond.Offense

        ThisGamesStats.Defense = calculatedDefense ' and here we see off tweedle dee
        ThisGamesStats.Offense = calculatedOffense ' and tweedle dum
    End Sub



    Private Sub findsheepbutton_Click(sender As Object, e As EventArgs) Handles findsheepbutton.Click ' baa button

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        If ThisGamesStats.Materials.Energy.Amount < 20 Then 'check if the user has enough energy to gather wool. if they don't, kill the sub.
            RichTextBox1.AppendText(vbNewLine & "You don't have enough energy for this!") ' can you tell this code is recycled from the woodcutting button?
            Exit Sub
        End If

        ThisGamesStats.Materials.Energy.Amount = ThisGamesStats.Materials.Energy.Amount - 20 'remove energy from ThisGamesStats
        Dim tempiterations As Integer = 0
        Dim targetiterations As Integer = Int(6 * Rnd()) 'generate a number from 0 to 6
        Dim temptargetamount As Integer = 0
        While tempiterations < targetiterations
            Dim temprandom As Integer = Int(2 * Rnd()) + 1 'generate a number from 0 to 2
            temptargetamount = temptargetamount + temprandom
            tempiterations = tempiterations + 1
        End While
        If targetiterations < 1 Then
            RichTextBox1.AppendText(vbNewLine & "You, unfortunately, used 20 energy but found no sheep.") ' rip
        Else
            RichTextBox1.AppendText(vbNewLine & "You used 20 Energy gathering" & Str(temptargetamount) & " wool from" & Str(targetiterations) & " sheep.") 'and tell the user/player about it
            ThisGamesStats.Materials.WoolAmount = ThisGamesStats.Materials.WoolAmount + temptargetamount 'add gathered wool.
        End If

        Call UpdateStatDisplay() 'deliver the wool to the hexidecimal club, they'll use it as ammo in pillow fights.
    End Sub



    Private Sub BuildBuildbutton_Click(sender As Object, e As EventArgs) Handles BuildBuildbutton.Click

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        Select Case ComboBox4.SelectedIndex 'check case of building combobox
            Case 0 ' bed
                If ThisGamesStats.Materials.WoodAmount < 3 Or ThisGamesStats.Materials.WoolAmount < 3 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount - 3
                    ThisGamesStats.Materials.WoolAmount = ThisGamesStats.Materials.WoolAmount - 3
                    ThisGamesStats.Buildings.Bed.Amount = ThisGamesStats.Buildings.Bed.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully built a bed!")
                End If
            Case 1 ' house
                If ThisGamesStats.Materials.WoodAmount < 10 Or ThisGamesStats.Materials.StoneAmount < 10 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount - 10
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 10
                    ThisGamesStats.Buildings.House.Amount = ThisGamesStats.Buildings.House.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully built a house!")
                End If
            Case 2 ' tower
                If ThisGamesStats.Materials.StoneAmount < 30 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 30
                    ThisGamesStats.Buildings.Tower.Amount = ThisGamesStats.Buildings.Tower.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully built a tower!")
                End If
            Case 3 ' guard tower TODO: add jobless villager to requirements
                If ThisGamesStats.Materials.StoneAmount < 80 Or ThisGamesStats.Items.IronSword.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough materials for that.")
                Else
                    ThisGamesStats.Items.IronSword.Amount = ThisGamesStats.Items.IronSword.Amount - 1
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount - 80
                    ThisGamesStats.Buildings.GuardTower.Amount = ThisGamesStats.Buildings.GuardTower.Amount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully built a tower!")
                End If
            Case Else
                RichTextBox1.AppendText(vbNewLine & "Please select a building recipe!")
        End Select
        Call UpdateStatDisplay() 'how far can you toss a building? you should probably opt for just sliding it over to the numeral guys.
    End Sub



    Private Sub craftdisassemblebutton_Click(sender As Object, e As EventArgs) Handles craftdisassemblebutton.Click ' breaking things, purposefully.

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        Select Case ComboBox3.SelectedIndex 'check case of crafting combobox
            Case 0 ' S T I C K S
                If ThisGamesStats.Materials.SticksAmount < 4 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough sticks to remake the plank.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount - 4
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled 4 sticks!")
                End If
            Case 1 ' F U R N A C E
                If ThisGamesStats.Materials.StoneAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 8
                    ThisGamesStats.Items.FurnaceAmount = ThisGamesStats.Items.FurnaceAmount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a furnace!")
                End If
            Case 2 ' W O O D E N   S W O R D
                If ThisGamesStats.Items.WoodenSword.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 1
                    ThisGamesStats.Items.WoodenSword.Amount = ThisGamesStats.Items.WoodenSword.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a wooden sword!")
                End If
            Case 3 ' W O O D E N   P I C K A X E
                If ThisGamesStats.Items.WoodenPickaxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.WoodenPickaxe.Amount = ThisGamesStats.Items.WoodenPickaxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a wooden pickaxe!")
                End If
            Case 4 ' wooden axe (i'm sorry but the spaced out text was too time-consuming to make.)
                If ThisGamesStats.Items.WoodenAxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.WoodenAxe.Amount = ThisGamesStats.Items.WoodenAxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a wooden axe!")
                End If
            Case 5 ' stone sword
                If ThisGamesStats.Items.StoneSword.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 1
                    ThisGamesStats.Items.StoneSword.Amount = ThisGamesStats.Items.StoneSword.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a stone sword!")
                End If
            Case 6 ' stone pickaxe
                If ThisGamesStats.Items.StonePickaxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.StonePickaxe.Amount = ThisGamesStats.Items.StonePickaxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a stone pickaxe!")
                End If
            Case 7 ' stone axe
                If ThisGamesStats.Items.StoneAxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.StoneAxe.Amount = ThisGamesStats.Items.StoneAxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a stone axe!")
                End If
            Case 8 ' iron sword
                If ThisGamesStats.Items.IronSword.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount + 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 1
                    ThisGamesStats.Items.IronSword.Amount = ThisGamesStats.Items.IronSword.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a iron sword!")
                End If
            Case 9 ' iron pickaxe
                If ThisGamesStats.Items.IronPickaxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.IronPickaxe.Amount = ThisGamesStats.Items.IronPickaxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a iron pickaxe!")
                End If
            Case 10 ' iron axe
                If ThisGamesStats.Items.IronAxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.IronAxe.Amount = ThisGamesStats.Items.IronAxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a iron axe!")
                End If
            Case 11 ' gold sword
                If ThisGamesStats.Items.GoldSword.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount + 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 1
                    ThisGamesStats.Items.GoldSword.Amount = ThisGamesStats.Items.GoldSword.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a gold sword!")
                End If
            Case 12 ' gold pickaxe
                If ThisGamesStats.Items.GoldPickaxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.GoldPickaxe.Amount = ThisGamesStats.Items.GoldPickaxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a gold pickaxe!")
                End If
            Case 13 ' gold axe
                If ThisGamesStats.Items.GoldAxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.GoldAxe.Amount = ThisGamesStats.Items.GoldAxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a gold axe!")
                End If
            Case 14 ' diamond sword
                If ThisGamesStats.Items.DiamondSword.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount + 2
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 1
                    ThisGamesStats.Items.DiamondSword.Amount = ThisGamesStats.Items.DiamondSword.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a diamond sword!")
                End If
            Case 15 ' diamond pickaxe
                If ThisGamesStats.Items.DiamondPickaxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.DiamondPickaxe.Amount = ThisGamesStats.Items.DiamondPickaxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a diamond pickaxe!")
                End If
            Case 16 ' diamond axe
                If ThisGamesStats.Items.DiamondAxe.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.DiamondsAmount = ThisGamesStats.Materials.DiamondsAmount + 3
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 2
                    ThisGamesStats.Items.DiamondAxe.Amount = ThisGamesStats.Items.DiamondAxe.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled a diamond axe!")
                End If
            Case 17 ' torches
                If ThisGamesStats.Items.TorchAmount < 4 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough torches for that.")
                Else
                    ThisGamesStats.Materials.CoalAmount = ThisGamesStats.Materials.CoalAmount + 1
                    ThisGamesStats.Materials.SticksAmount = ThisGamesStats.Materials.SticksAmount + 1
                    ThisGamesStats.Items.TorchAmount = ThisGamesStats.Items.TorchAmount - 4
                    RichTextBox1.AppendText(vbNewLine & "Successfully disassembled 4 torches!")
                End If
            Case Else
                RichTextBox1.AppendText(vbNewLine & "Please select a disassembly recipe!")
        End Select
        Call UpdateStatDisplay() 'just chuck the product over to the itty bitty digit city, they'll be fine.
    End Sub



    Private Sub smeltbutton_Click(sender As Object, e As EventArgs) Handles smeltbutton.Click ' Hot topic!

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        Select Case ComboBox1.SelectedIndex 'check case of smelting combobox
            Case 0 ' smelt iron ore
                If ThisGamesStats.Materials.IronOreAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough iron ore for that.")

                ElseIf ThisGamesStats.Materials.CoalAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough coal for that.")
                Else
                    ThisGamesStats.Materials.IronOreAmount = ThisGamesStats.Materials.IronOreAmount - 1
                    ThisGamesStats.Materials.CoalAmount = ThisGamesStats.Materials.CoalAmount - 1
                    ThisGamesStats.Materials.IronIngotAmount = ThisGamesStats.Materials.IronIngotAmount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully smelted an iron ingot!")
                End If
            Case 1 ' Smelt gold ore
                If ThisGamesStats.Materials.GoldOreAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough gold ore for that.")

                ElseIf ThisGamesStats.Materials.CoalAmount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have enough coal for that.")
                Else
                    ThisGamesStats.Materials.GoldOreAmount = ThisGamesStats.Materials.GoldOreAmount - 1
                    ThisGamesStats.Materials.CoalAmount = ThisGamesStats.Materials.CoalAmount - 1
                    ThisGamesStats.Materials.GoldIngotAmount = ThisGamesStats.Materials.GoldIngotAmount + 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully smelted an gold ingot!")
                End If
            Case Else
                RichTextBox1.AppendText(vbNewLine & "Please select something to smelt!")
        End Select
        Call UpdateStatDisplay() 'oops
    End Sub



    Private Sub Builddismantlebutton_Click(sender As Object, e As EventArgs) Handles Builddismantlebutton.Click

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

        Select Case ComboBox4.SelectedIndex 'check case of building combobox
            Case 0 ' bed
                If ThisGamesStats.Buildings.Bed.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + 3
                    ThisGamesStats.Materials.WoolAmount = ThisGamesStats.Materials.WoolAmount + 3
                    ThisGamesStats.Buildings.Bed.Amount = ThisGamesStats.Buildings.Bed.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully dismantled a bed!")
                End If
            Case 1 ' house
                If ThisGamesStats.Buildings.House.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.WoodAmount = ThisGamesStats.Materials.WoodAmount + 10
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 10
                    ThisGamesStats.Buildings.House.Amount = ThisGamesStats.Buildings.House.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully dismantled a house!")
                End If
            Case 2 ' tower
                If ThisGamesStats.Buildings.Tower.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 30
                    ThisGamesStats.Buildings.Tower.Amount = ThisGamesStats.Buildings.Tower.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully dismantled a tower!")
                End If
            Case 3 ' guard tower TODO: add jobless villager to requirements
                If ThisGamesStats.Buildings.GuardTower.Amount < 1 Then
                    RichTextBox1.AppendText(vbNewLine & "Sorry, You don't have that.")
                Else
                    ThisGamesStats.Items.IronSword.Amount = ThisGamesStats.Items.IronSword.Amount + 1
                    ThisGamesStats.Materials.StoneAmount = ThisGamesStats.Materials.StoneAmount + 80
                    ThisGamesStats.Buildings.GuardTower.Amount = ThisGamesStats.Buildings.GuardTower.Amount - 1
                    RichTextBox1.AppendText(vbNewLine & "Successfully dismantled a tower!")
                End If
            Case Else
                RichTextBox1.AppendText(vbNewLine & "Please select a dismantling recipe!")
        End Select
        Call UpdateStatDisplay() 'BRING OUT YOUR RUBBLE
    End Sub



    Private Sub DeadNotify()
        If ThisGamesStats.PlayerIsDead Then 'F
            RichTextBox1.AppendText(vbNewLine & "You are dead, there is nothing you can do now.

Due to a bug related to having classes within classes in VB.NET, please restart the program to restart. pressing 'End Day' may make it seem that the game has restarted, but you will quickly find that the game gets thrown into an unplayable state.

I have tried several times to make the contents of ThisGamesStats not shared, but it always throws the error ''Reference to a non-shared member requires an object reference'' or some other error.

Thanks for playing.")
        End If
    End Sub

    Private Sub findvillagersbutton_Click(sender As Object, e As EventArgs) Handles findvillagersbutton.Click

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

    End Sub

    Private Sub Hirehirebutton_Click(sender As Object, e As EventArgs) Handles Hirehirebutton.Click

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

    End Sub

    Private Sub hirefirebutton_Click(sender As Object, e As EventArgs) Handles hirefirebutton.Click

        RichTextBox1.AppendText(vbNewLine)

        If ThisGamesStats.PlayerIsDead Then 'F
            Call DeadNotify()
            Exit Sub
        End If

    End Sub
End Class
'#Enable Warning BC42025



'GAME DATA YEAHH
Public Class MncrftInfo
    Public PlayerIsDead As Boolean = False
    Public NightScore As Integer = 0
    Public LastZombieCount As Integer = 0
    Public Offense As Integer = 0
    Public PersonalDefense As Integer = 0
    Public Defense As Integer

    Public Class ActionCosts
        Public Shared AxeCost As Integer = 15
        Public Shared PickaxeCost As Integer = 0
    End Class

    Public Class Materials
        Public Class Energy
            Public Shared Amount As Integer = 60 '99999999
            Public Shared NightlyAmount As Integer = 10
        End Class

        Public Shared WoodAmount As Integer
        Public Shared SticksAmount As Integer
        Public Shared WoolAmount As Integer
        Public Shared StoneAmount As Integer
        Public Shared CoalAmount As Integer
        Public Shared IronOreAmount As Integer
        Public Shared GoldOreAmount As Integer
        Public Shared IronIngotAmount As Integer
        Public Shared GoldIngotAmount As Integer
        Public Shared DiamondsAmount As Integer
    End Class

    Public Class Buildings
        Public Class Bed
            Public Shared Amount As Integer
            Public Shared ReadOnly DailyEnergyAddition As Integer = 5
        End Class

        Public Class House
            Public Shared Amount As Integer
            Public Shared ReadOnly Defense As Integer = 4
            Public Shared ReadOnly DailyEnergyAddition As Integer = 2
        End Class

        Public Class Tower
            Public Shared Amount As Integer
            Public Shared ReadOnly Defense As Integer = 6
        End Class

        Public Class GuardTower
            Public Shared Amount As Integer
            Public Shared ReadOnly Offense As Integer = 6
            Public Shared ReadOnly Defense As Integer = 10
        End Class
    End Class

    Public Class Items
        Public Class WoodenSword
            Public Shared Amount As Integer
            Public Shared ReadOnly PerDef As Integer = 5
        End Class

        Public Class WoodenPickaxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 20
            Public Shared ReadOnly IronMinable As Boolean = False
            Public Shared ReadOnly GoldMinable As Boolean = False
            Public Shared ReadOnly DiamMinable As Boolean = False
        End Class

        Public Class WoodenAxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 10
        End Class

        Public Class StoneSword
            Public Shared Amount As Integer = 0
            Public Shared ReadOnly PerDef As Integer = 8
        End Class

        Public Class StonePickaxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 18
            Public Shared ReadOnly IronMinable As Boolean = True
            Public Shared ReadOnly GoldMinable As Boolean = False
            Public Shared ReadOnly DiamMinable As Boolean = False
        End Class

        Public Class StoneAxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 8
        End Class

        Public Class GoldSword
            Public Shared Amount As Integer
            Public Shared ReadOnly PerDef As Integer = 10
        End Class

        Public Class GoldPickaxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 16
            Public Shared ReadOnly IronMinable As Boolean = True
            Public Shared ReadOnly GoldMinable As Boolean = False
            Public Shared ReadOnly DiamMinable As Boolean = False
        End Class

        Public Class GoldAxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 6
        End Class

        Public Class IronSword
            Public Shared Amount As Integer = 0
            Public Shared ReadOnly PerDef As Integer = 12
        End Class

        Public Class IronPickaxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 14
            Public Shared ReadOnly IronMinable As Boolean = True
            Public Shared ReadOnly GoldMinable As Boolean = True
            Public Shared ReadOnly DiamMinable As Boolean = True
        End Class

        Public Class IronAxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 4
        End Class

        Public Class DiamondSword
            Public Shared Amount As Integer
            Public Shared ReadOnly PerDef As Integer = 15
        End Class
        Public Class DiamondPickaxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 10
            Public Shared ReadOnly IronMinable As Boolean = True
            Public Shared ReadOnly GoldMinable As Boolean = True
            Public Shared ReadOnly DiamMinable As Boolean = True
        End Class

        Public Class DiamondAxe
            Public Shared Amount As Integer
            Public Shared ReadOnly EnergyCost As Integer = 2
        End Class

        Public Shared FurnaceAmount As Integer
        Public Shared TorchAmount As Integer
    End Class

    Public Class Villagers
        Public Shared TotalVillagerAmount As Integer
        Public Shared GreenCoatAmount As Integer
        Public Shared IronSmelterAmount As Integer
        Public Shared GoldSmelterAmount As Integer
        Public Shared ShepherdAmount As Integer

        Public Class Guard
            Public Class Wood
                Public Shared Amount As Integer
                Public Shared ReadOnly Offense As Integer = 1
                Public Shared ReadOnly Defense As Integer = 2
            End Class

            Public Class Stone
                Public Shared Amount As Integer
                Public Shared ReadOnly Offense As Integer = 2
                Public Shared ReadOnly Defense As Integer = 4
            End Class

            Public Class Gold
                Public Shared Amount As Integer
                Public Shared ReadOnly Offense As Integer = 4
                Public Shared ReadOnly Defense As Integer = 6
            End Class

            Public Class Iron
                Public Shared Amount As Integer
                Public Shared ReadOnly Offense As Integer = 6
                Public Shared ReadOnly Defense As Integer = 10
            End Class

            Public Class Diamond
                Public Shared Amount As Integer
                Public Shared ReadOnly Offense As Integer = 10
                Public Shared ReadOnly Defense As Integer = 20
            End Class
        End Class

        Public Class Lumberjack
            Public Class Wood
                Public Shared Amount As Integer
                Public Shared ReadOnly WoodPerDay As Integer = 2
            End Class

            Public Class Stone
                Public Shared Amount As Integer
                Public Shared ReadOnly WoodPerDay As Integer = 4
            End Class

            Public Class Gold
                Public Shared Amount As Integer
                Public Shared ReadOnly WoodPerDay As Integer = 6
            End Class

            Public Class Iron
                Public Shared Amount As Integer
                Public Shared ReadOnly WoodPerDay As Integer = 8
            End Class

            Public Class Diamond
                Public Shared Amount As Integer
                Public Shared ReadOnly WoodPerDay As Integer = 16
            End Class
        End Class

        Public Class Miner
            Public Class Wood
                Public Shared Amount As Integer
                Public Shared ReadOnly StonePerDay As Integer = 8
                Public Shared ReadOnly CoalPerDay As Integer = 2
                Public Shared ReadOnly IronPerDay As Integer = 0
                Public Shared ReadOnly GoldPerDay As Integer = 0
                Public Shared ReadOnly DiamondPerDay As Integer = 0
            End Class

            Public Class Stone
                Public Shared Amount As Integer
                Public Shared ReadOnly StonePerDay As Integer = 12
                Public Shared ReadOnly CoalPerDay As Integer = 6
                Public Shared ReadOnly IronPerDay As Integer = 2
                Public Shared ReadOnly GoldPerDay As Integer = 0
                Public Shared ReadOnly DiamondPerDay As Integer = 0
            End Class

            Public Class Gold
                Public Shared Amount As Integer
                Public Shared ReadOnly StonePerDay As Integer = 14
                Public Shared ReadOnly CoalPerDay As Integer = 8
                Public Shared ReadOnly IronPerDay As Integer = 2
                Public Shared ReadOnly GoldPerDay As Integer = 6
                Public Shared ReadOnly DiamondPerDay As Integer = 0
            End Class

            Public Class Iron
                Public Shared Amount As Integer
                Public Shared ReadOnly StonePerDay As Integer = 16
                Public Shared ReadOnly CoalPerDay As Integer = 10
                Public Shared ReadOnly IronPerDay As Integer = 4
                Public Shared ReadOnly GoldPerDay As Integer = 2
                Public Shared ReadOnly DiamondPerDay As Integer = 0
            End Class

            Public Class Diamond
                Public Shared Amount As Integer
                Public Shared ReadOnly StonePerDay As Integer = 20
                Public Shared ReadOnly CoalPerDay As Integer = 14
                Public Shared ReadOnly IronPerDay As Integer = 6
                Public Shared ReadOnly GoldPerDay As Integer = 2
                Public Shared ReadOnly DiamondPerDay As Integer = 1
            End Class
        End Class
    End Class
End Class