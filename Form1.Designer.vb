<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMarineCompendium
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
        Me.grpNames = New System.Windows.Forms.GroupBox()
        Me.lblSciName = New System.Windows.Forms.Label()
        Me.lblOtherName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpGenInfp = New System.Windows.Forms.GroupBox()
        Me.lblHabitat = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblLooks = New System.Windows.Forms.Label()
        Me.lblDiet = New System.Windows.Forms.Label()
        Me.lblPredators = New System.Windows.Forms.Label()
        Me.grpImage = New System.Windows.Forms.GroupBox()
        Me.picAnimalImage = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnAbstractSources = New System.Windows.Forms.Button()
        Me.grpFacts = New System.Windows.Forms.GroupBox()
        Me.lblFacts = New System.Windows.Forms.Label()
        Me.grpTaxonomySize = New System.Windows.Forms.GroupBox()
        Me.lblTaxonomy = New System.Windows.Forms.Label()
        Me.grpControlPanel = New System.Windows.Forms.GroupBox()
        Me.btnSelectAnimal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAnimalSelection = New System.Windows.Forms.ListBox()
        Me.grpNames.SuspendLayout()
        Me.grpGenInfp.SuspendLayout()
        Me.grpImage.SuspendLayout()
        CType(Me.picAnimalImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFacts.SuspendLayout()
        Me.grpTaxonomySize.SuspendLayout()
        Me.grpControlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNames
        '
        Me.grpNames.Controls.Add(Me.lblSciName)
        Me.grpNames.Controls.Add(Me.lblOtherName)
        Me.grpNames.Controls.Add(Me.lblName)
        Me.grpNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNames.Location = New System.Drawing.Point(32, 13)
        Me.grpNames.Name = "grpNames"
        Me.grpNames.Size = New System.Drawing.Size(296, 163)
        Me.grpNames.TabIndex = 0
        Me.grpNames.TabStop = False
        Me.grpNames.Text = "Names"
        '
        'lblSciName
        '
        Me.lblSciName.Location = New System.Drawing.Point(6, 56)
        Me.lblSciName.Name = "lblSciName"
        Me.lblSciName.Size = New System.Drawing.Size(281, 40)
        Me.lblSciName.TabIndex = 2
        Me.lblSciName.Text = "SciName"
        '
        'lblOtherName
        '
        Me.lblOtherName.Location = New System.Drawing.Point(6, 108)
        Me.lblOtherName.Name = "lblOtherName"
        Me.lblOtherName.Size = New System.Drawing.Size(281, 40)
        Me.lblOtherName.TabIndex = 1
        Me.lblOtherName.Text = "Other Names"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(6, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(281, 26)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'grpGenInfp
        '
        Me.grpGenInfp.Controls.Add(Me.lblHabitat)
        Me.grpGenInfp.Controls.Add(Me.lblSize)
        Me.grpGenInfp.Controls.Add(Me.lblLooks)
        Me.grpGenInfp.Controls.Add(Me.lblDiet)
        Me.grpGenInfp.Controls.Add(Me.lblPredators)
        Me.grpGenInfp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGenInfp.Location = New System.Drawing.Point(363, 13)
        Me.grpGenInfp.Name = "grpGenInfp"
        Me.grpGenInfp.Size = New System.Drawing.Size(577, 441)
        Me.grpGenInfp.TabIndex = 3
        Me.grpGenInfp.TabStop = False
        Me.grpGenInfp.Text = "General Information"
        '
        'lblHabitat
        '
        Me.lblHabitat.Location = New System.Drawing.Point(32, 199)
        Me.lblHabitat.Name = "lblHabitat"
        Me.lblHabitat.Size = New System.Drawing.Size(232, 120)
        Me.lblHabitat.TabIndex = 4
        Me.lblHabitat.Text = "Habitat"
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(297, 199)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSize.Size = New System.Drawing.Size(247, 120)
        Me.lblSize.TabIndex = 1
        Me.lblSize.Text = "size"
        '
        'lblLooks
        '
        Me.lblLooks.Location = New System.Drawing.Point(32, 35)
        Me.lblLooks.Name = "lblLooks"
        Me.lblLooks.Size = New System.Drawing.Size(512, 144)
        Me.lblLooks.TabIndex = 0
        Me.lblLooks.Text = "Looks"
        '
        'lblDiet
        '
        Me.lblDiet.Location = New System.Drawing.Point(32, 333)
        Me.lblDiet.Name = "lblDiet"
        Me.lblDiet.Size = New System.Drawing.Size(232, 86)
        Me.lblDiet.TabIndex = 2
        Me.lblDiet.Text = "diet"
        '
        'lblPredators
        '
        Me.lblPredators.Location = New System.Drawing.Point(300, 333)
        Me.lblPredators.Name = "lblPredators"
        Me.lblPredators.Size = New System.Drawing.Size(244, 86)
        Me.lblPredators.TabIndex = 3
        Me.lblPredators.Text = "predators"
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.picAnimalImage)
        Me.grpImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpImage.Location = New System.Drawing.Point(29, 182)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(299, 266)
        Me.grpImage.TabIndex = 6
        Me.grpImage.TabStop = False
        Me.grpImage.Text = "Image"
        '
        'picAnimalImage
        '
        Me.picAnimalImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picAnimalImage.Location = New System.Drawing.Point(9, 19)
        Me.picAnimalImage.Name = "picAnimalImage"
        Me.picAnimalImage.Size = New System.Drawing.Size(284, 241)
        Me.picAnimalImage.TabIndex = 1
        Me.picAnimalImage.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(18, 475)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 49)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start of List"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(131, 384)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 45)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next Animal"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(18, 384)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 45)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous Animal"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(131, 568)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 64)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Exit Program"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(131, 475)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 49)
        Me.btnEnd.TabIndex = 11
        Me.btnEnd.Text = "End of List"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnAbstractSources
        '
        Me.btnAbstractSources.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbstractSources.Location = New System.Drawing.Point(18, 568)
        Me.btnAbstractSources.Name = "btnAbstractSources"
        Me.btnAbstractSources.Size = New System.Drawing.Size(75, 64)
        Me.btnAbstractSources.TabIndex = 12
        Me.btnAbstractSources.Text = "Abstract and Sources"
        Me.btnAbstractSources.UseVisualStyleBackColor = True
        '
        'grpFacts
        '
        Me.grpFacts.Controls.Add(Me.lblFacts)
        Me.grpFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFacts.Location = New System.Drawing.Point(363, 460)
        Me.grpFacts.Name = "grpFacts"
        Me.grpFacts.Size = New System.Drawing.Size(577, 227)
        Me.grpFacts.TabIndex = 4
        Me.grpFacts.TabStop = False
        Me.grpFacts.Text = "Interesting Facts"
        '
        'lblFacts
        '
        Me.lblFacts.Location = New System.Drawing.Point(17, 23)
        Me.lblFacts.Name = "lblFacts"
        Me.lblFacts.Size = New System.Drawing.Size(540, 193)
        Me.lblFacts.TabIndex = 0
        Me.lblFacts.Text = "Fun Facts"
        '
        'grpTaxonomySize
        '
        Me.grpTaxonomySize.Controls.Add(Me.lblTaxonomy)
        Me.grpTaxonomySize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTaxonomySize.Location = New System.Drawing.Point(32, 460)
        Me.grpTaxonomySize.Name = "grpTaxonomySize"
        Me.grpTaxonomySize.Size = New System.Drawing.Size(299, 227)
        Me.grpTaxonomySize.TabIndex = 5
        Me.grpTaxonomySize.TabStop = False
        Me.grpTaxonomySize.Text = "Taxonomy"
        '
        'lblTaxonomy
        '
        Me.lblTaxonomy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxonomy.Location = New System.Drawing.Point(9, 44)
        Me.lblTaxonomy.Name = "lblTaxonomy"
        Me.lblTaxonomy.Size = New System.Drawing.Size(278, 167)
        Me.lblTaxonomy.TabIndex = 2
        Me.lblTaxonomy.Text = "Taxonomy"
        Me.lblTaxonomy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpControlPanel
        '
        Me.grpControlPanel.Controls.Add(Me.btnSelectAnimal)
        Me.grpControlPanel.Controls.Add(Me.Label1)
        Me.grpControlPanel.Controls.Add(Me.lstAnimalSelection)
        Me.grpControlPanel.Controls.Add(Me.btnPrevious)
        Me.grpControlPanel.Controls.Add(Me.btnNext)
        Me.grpControlPanel.Controls.Add(Me.btnStart)
        Me.grpControlPanel.Controls.Add(Me.btnQuit)
        Me.grpControlPanel.Controls.Add(Me.btnAbstractSources)
        Me.grpControlPanel.Controls.Add(Me.btnEnd)
        Me.grpControlPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpControlPanel.Location = New System.Drawing.Point(964, 13)
        Me.grpControlPanel.Name = "grpControlPanel"
        Me.grpControlPanel.Size = New System.Drawing.Size(231, 674)
        Me.grpControlPanel.TabIndex = 13
        Me.grpControlPanel.TabStop = False
        Me.grpControlPanel.Text = "Control Panel"
        '
        'btnSelectAnimal
        '
        Me.btnSelectAnimal.Location = New System.Drawing.Point(18, 321)
        Me.btnSelectAnimal.Name = "btnSelectAnimal"
        Me.btnSelectAnimal.Size = New System.Drawing.Size(188, 33)
        Me.btnSelectAnimal.TabIndex = 13
        Me.btnSelectAnimal.Text = "Select Animal"
        Me.btnSelectAnimal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of Animals"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstAnimalSelection
        '
        Me.lstAnimalSelection.FormattingEnabled = True
        Me.lstAnimalSelection.ItemHeight = 16
        Me.lstAnimalSelection.Items.AddRange(New Object() {"Vampire Squid", "Colossal Squid", "Giant Squid", "Firefly Squid", "Neon Flying Squid", "Humboldt Squid", "Market Squid", "Grimaldi Scaled Squid", "Umbrella Squid", "Blue-Ringed Octopus", "Giant Pacific Octopus", "Common Blanket Octopus", "Dumbo Octopus", "Bioluminescent Octopus", "Mimic Octopus", "Greater Argonaut", "Striped Pyjama Squid", "Flamboyant Cuttlefish", "Giant Cuttlefish", "Common Cuttlefish", "Chambered Nautilus", "Fuzzy Nautilus", "Palau Nautilus", "White-Patched Nautilus", "California Sea Lion", "Steller Sea Lion", "West Indian Manatee", "Walrus", "Mediterranean Monk Seal", "Leopard Seal", "Harp Seal", "Orca", "Common Dolphin", "Common Bottlenose Dolphin", "Risso's Dolphin", "Spectacled Porpoise", "Pacific White-Sided Dolphin", "Gray Whale", "Beluga Whale", "Blue Whale", "Minke Whale", "Narwhal", "Frilled Shark", "Greenland Shark", "Pelagic Thresher Shark", "Nurse Shark", "Greater Hammerhead Shark", "Great White Shark", "Tiger Shark", "Giant Oceanic Manta Ray", "Smooth Stingray", "Japanese Eagle Ray", "Spotted Ray", "Green Sea Turtle", "Leatherback Sea Turtle", "Blue Tang", "Yellow Tang", "Regal Tang", "French Angelfish", "Royal Angelfish", "Blueface Angelfish", "Flame Angelfish", "Queen Angelfish", "Lined Butterflyfish", "Banded Butterflyfish", "Elegant Firefish", "Mandarinfish", "Indo-Pacific Sailfish", "Antarctic Toothfish", "John Dory", "Coelacanth", "Common Clownfish", "Red Lionfish", "Mahi Mahi", "Humphead Wrasse", "Sheepshead Wrasse", "Ocean Sunfish", "Striped Goby", "Fire Goby ", "Atlantic Bluefin Tuna", "Yellowfin Tuna", "Short-Snouted Seahorse", "Leafy Sea Dragon", "Pistol Shrimp", "Peacock Mantis Shrimp", "Giant Moray Eel", "Ribbon Eel", "Pelican Eel", "Red King Crab", "Yeti Crab", "American Lobster", "Portuguese Man O' War", "Flower Hat Jellyfish", "Crystal Jellyfish", "Black Sea Nettle", "Immortal Jellyfish", "Japanese Common Starfish", "Common Brittlestar", "Reef Starfish", "Common Sea Urchin"})
        Me.lstAnimalSelection.Location = New System.Drawing.Point(6, 88)
        Me.lstAnimalSelection.Name = "lstAnimalSelection"
        Me.lstAnimalSelection.Size = New System.Drawing.Size(219, 212)
        Me.lstAnimalSelection.TabIndex = 0
        '
        'frmMarineCompendium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 749)
        Me.Controls.Add(Me.grpControlPanel)
        Me.Controls.Add(Me.grpTaxonomySize)
        Me.Controls.Add(Me.grpNames)
        Me.Controls.Add(Me.grpFacts)
        Me.Controls.Add(Me.grpGenInfp)
        Me.Controls.Add(Me.grpImage)
        Me.Name = "frmMarineCompendium"
        Me.Text = "Marine Compendium"
        Me.grpNames.ResumeLayout(False)
        Me.grpGenInfp.ResumeLayout(False)
        Me.grpImage.ResumeLayout(False)
        CType(Me.picAnimalImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFacts.ResumeLayout(False)
        Me.grpTaxonomySize.ResumeLayout(False)
        Me.grpControlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpNames As GroupBox
    Friend WithEvents picAnimalImage As PictureBox
    Friend WithEvents grpGenInfp As GroupBox
    Friend WithEvents grpImage As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblSciName As Label
    Friend WithEvents lblOtherName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPredators As Label
    Friend WithEvents lblDiet As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblLooks As Label
    Friend WithEvents lblHabitat As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnAbstractSources As Button
    Friend WithEvents grpFacts As GroupBox
    Friend WithEvents lblFacts As Label
    Friend WithEvents grpTaxonomySize As GroupBox
    Friend WithEvents lblTaxonomy As Label
    Friend WithEvents grpControlPanel As GroupBox
    Friend WithEvents lstAnimalSelection As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectAnimal As Button
End Class
