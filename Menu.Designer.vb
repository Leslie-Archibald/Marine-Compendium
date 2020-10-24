<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.lstAnimals = New System.Windows.Forms.ListBox()
        Me.lblAnimalTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnAbstractSources = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAnimals
        '
        Me.lstAnimals.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAnimals.FormattingEnabled = True
        Me.lstAnimals.ItemHeight = 16
        Me.lstAnimals.Items.AddRange(New Object() {"Vampire Squid", "Colossal Squid", "Giant Squid", "Firefly Squid", "Neon Flying Squid", "Humboldt Squid", "Market Squid", "Grimaldi Scaled Squid", "Umbrella Squid", "Blue-Ringed Octopus", "Giant Pacific Octopus", "Common Blanket Octopus", "Dumbo Octopus", "Bioluminescent Octopus", "Mimic Octopus", "Greater Argonaut", "Striped Pyjama Squid", "Flamboyant Cuttlefish", "Giant Cuttlefish", "Common Cuttlefish", "Chambered Nautilus", "Fuzzy Nautilus", "Palau Nautilus", "White-Patched Nautilus", "California Sea Lion", "Steller Sea Lion", "West Indian Manatee", "Walrus", "Mediterranean Monk Seal", "Leopard Seal", "Harp Seal", "Orca", "Common Dolphin", "Common Bottlenose Dolphin", "Risso's Dolphin", "Spectacled Porpoise", "Pacific White-Sided Dolphin", "Gray Whale", "Beluga Whale", "Minke Whale", "Narwhal", "Frilled Shark", "Greenland Shark", "Pelagic Thresher Shark", "Nurse Shark", "Greater Hammerhead Shark", "Great White Shark", "Tiger Shark", "Giant Oceanic Manta Ray", "Smooth Stingray", "Japanese Eagle Ray", "Spotted Ray", "Green Sea Turtle", "Leatherback Sea Turtle", "Blue Tang", "Yellow Tang", "Regal Tang", "French Angelfish", "Royal Angelfish", "Blueface Angelfish", "Flame Angelfish", "Queen Angelfish", "Lined Butterflyfish", "Banded Butterflyfish", "Elegant Firefish", "Mandarinfish", "Indo-Pacific Sailfish", "Antarctic Toothfish", "John Dory", "Coelacanth", "Common Clownfish", "Red Lionfish", "Mahi Mahi", "Humphead Wrasse", "Sheepshead Wrasse", "Ocean Sunfish", "Striped Goby", "Fire Goby ", "Atlantic Bluefin Tuna", "Yellowfin Tuna", "Short-Snouted Seahorse", "Leafy Sea Dragon", "Pistol Shrimp", "Peacock Mantis Shrimp", "Giant Moray Eel", "Ribbon Eel", "Pelican Eel", "Red King Crab", "Yeti Crab", "American Lobster", "Portuguese Man O' War", "Flower Hat Jellyfish", "Crystal Jellyfish", "Black Sea Nettle", "Immortal Jellyfish", "Japanese Common Starfish", "Common Brittlestar", "Reef Starfish", "Common Sea Urchin"})
        Me.lstAnimals.Location = New System.Drawing.Point(15, 74)
        Me.lstAnimals.Name = "lstAnimals"
        Me.lstAnimals.Size = New System.Drawing.Size(191, 260)
        Me.lstAnimals.TabIndex = 0
        '
        'lblAnimalTitle
        '
        Me.lblAnimalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimalTitle.Location = New System.Drawing.Point(35, 34)
        Me.lblAnimalTitle.Name = "lblAnimalTitle"
        Me.lblAnimalTitle.Size = New System.Drawing.Size(144, 20)
        Me.lblAnimalTitle.TabIndex = 1
        Me.lblAnimalTitle.Text = "List of Animals"
        Me.lblAnimalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(264, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 45)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Quit Application"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.Location = New System.Drawing.Point(264, 129)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(99, 45)
        Me.btnRandom.TabIndex = 3
        Me.btnRandom.Text = "Random Animal"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(264, 52)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(99, 42)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Animal"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnAbstractSources
        '
        Me.btnAbstractSources.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbstractSources.Location = New System.Drawing.Point(264, 210)
        Me.btnAbstractSources.Name = "btnAbstractSources"
        Me.btnAbstractSources.Size = New System.Drawing.Size(99, 52)
        Me.btnAbstractSources.TabIndex = 5
        Me.btnAbstractSources.Text = "Abstract and Sources"
        Me.btnAbstractSources.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 378)
        Me.Controls.Add(Me.btnAbstractSources)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAnimalTitle)
        Me.Controls.Add(Me.lstAnimals)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAnimals As ListBox
    Friend WithEvents lblAnimalTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRandom As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnAbstractSources As Button
End Class
