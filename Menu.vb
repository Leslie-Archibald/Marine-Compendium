Public Class Menu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAbstractSources_Click(sender As Object, e As EventArgs) Handles btnAbstractSources.Click
        Me.Hide()

    End Sub

    Public Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim frmCompendium As New frmMarineCompendium
        Dim animalSelected As String
        Dim animalIndex As Integer

        animalIndex = lstAnimals.SelectedIndex()
        animalSelected = lstAnimals.SelectedItem()

        MessageBox.Show(animalIndex & ControlChars.CrLf & animalSelected)

        If (animalSelected = "Vampire Squid") Then
            frmCompendium.lblName.Text = names(animalIndex)
            frmCompendium.lblOtherName.Text = otherNames(animalIndex)
            frmCompendium.lblSciName.Text = sciNames(animalIndex)
            frmCompendium.lblTaxonomy.Text = taxonomy(animalIndex)
            frmCompendium.lblSize.Text = animalSize(animalIndex)
            frmCompendium.lblLooks.Text = looks(animalIndex)
            frmCompendium.lblDiet.Text = "Diet: " & diet(animalIndex)
            frmCompendium.lblPredators.Text = "Predators: " & predators(animalIndex)
            frmCompendium.lblHabitat.Text = "Habitat: " & habitat(animalIndex)
            frmCompendium.lblFacts.Text = funFacts(animalIndex)
        End If


        frmMarineCompendium.Show()
        Me.Hide()


    End Sub

    Public Sub animalDisplay(animalIndex As Integer, frmCompendium As frmMarineCompendium)



    End Sub


    ' If (animalIndex = 0) Then
    '   frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\vampireSquid.jpg")
    'ElseIf (indexSelected = 1) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\colossalSquid.jpg")
    'ElseIf (indexSelected = 2) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\giantSquid.jpg")
    'ElseIf (indexSelected = 3) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\fireflySquid.png")
    'ElseIf (indexSelected = 4) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\neonFlyingSquid.jpg")
    'ElseIf (indexSelected = 5) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\humboldtSquid.jpg")
    'ElseIf (indexSelected = 6) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\marketSquid.jpg")
    'ElseIf (indexSelected = 7) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\grimaldiSquid.jpg")
    'ElseIf (indexSelected = 8) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\umbrellaSquid.jpg")
    'ElseIf (indexSelected = 9) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\blueRingedOctopus.jpg")
    'ElseIf (indexSelected = 10) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\giantPacificOctopus.jpg")
    'ElseIf (indexSelected = 11) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\blanketOctopus.jpg")
    'ElseIf (indexSelected = 12) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\dumboOctopus.jpg")
    'ElseIf (indexSelected = 13) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\bioluminescentOctopus.jpg")
    'ElseIf (indexSelected = 14) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\mimicOctopus.jpg")
    'ElseIf (indexSelected = 15) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\argonaut.jpg")
    'ElseIf (indexSelected = 16) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\stripedPJSquid.jpg")
    'ElseIf (indexSelected = 17) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\flamboyantCuttlefish.jpg")
    'ElseIf (indexSelected = 18) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\giantCuttlefish.jpg")
    'ElseIf (indexSelected = 19) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\commonCuttlefish.jpg")
    'ElseIf (indexSelected = 20) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\chamberedNautilus.jpg")
    'ElseIf (indexSelected = 21) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\fuzzyNautilus.jpg")
    'ElseIf (indexSelected = 22) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\palauNautilus.jpg")
    'ElseIf (indexSelected = 23) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\whitePatchedNautilus.jpg")
    'ElseIf (indexSelected = 24) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\californiaSeaLion.jpg")
    'ElseIf (indexSelected = 25) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\stellerSeaLion.jpg")
    'ElseIf (indexSelected = 26) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\manatee.jpg")
    'ElseIf (indexSelected = 27) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\walrus.jpg")
    'ElseIf (indexSelected = 28) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\monkSeal.jpg")
    'ElseIf (indexSelected = 29) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\leopardSeal.jpg")
    'ElseIf (indexSelected = 30) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\harpSeal.jpg")
    'ElseIf (indexSelected = 31) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\orca.jpg")
    'ElseIf (indexSelected = 32) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\commonDolphin.jpg")
    'ElseIf (indexSelected = 33) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\bottlenoseDolphin.jpg")
    'ElseIf (indexSelected = 34) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\rissosDolphin.jpg")
    'ElseIf (indexSelected = 35) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\spectacledPorpoise.jpg")
    'ElseIf (indexSelected = 36) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\pacificWhiteSidedDolphin.jpg")
    'ElseIf (indexSelected = 37) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\grayWhale.jpg")
    'ElseIf (indexSelected = 38) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\belugaWhale.jpg")
    'ElseIf (indexSelected = 39) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\blueWhale.jpg")
    'ElseIf (indexSelected = 40) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\minkeWhale.jpg")
    'ElseIf (indexSelected = 41) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\narwhal.jpg")
    'ElseIf (indexSelected = 42) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\frilledShark.jpg")
    'ElseIf (indexSelected = 43) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\greenlandShark.jpg")
    'ElseIf (indexSelected = 44) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\pelagicThresherShark.jpg")
    'ElseIf (indexSelected = 45) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\nurseShark.jpg")
    'ElseIf (indexSelected = 46) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\greatHammerhead.jpg")
    'ElseIf (indexSelected = 47) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\greatWhiteShark.jpg")
    'ElseIf (indexSelected = 48) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\tigerShark.jpg")
    'ElseIf (indexSelected = 49) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\mantaRay.jpg")
    'ElseIf (indexSelected = 50) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\shortTailStingray.jpg")
    'ElseIf (indexSelected = 51) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\jpEagleRay.jpg")
    'ElseIf (indexSelected = 52) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\spottedRay.jpg")
    'ElseIf (indexSelected = 53) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\greenSeaTurtle.jpg")
    'ElseIf (indexSelected = 54) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\leatherbackSeaTurtle.jpg")
    'ElseIf (indexSelected = 55) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\blueTang.jpg")
    'ElseIf (indexSelected = 56) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\yellowTang.jpg")
    'ElseIf (indexSelected = 57) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\regalTang.jpg")
    'ElseIf (indexSelected = 58) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\frenchAngelfish.jpg")
    'ElseIf (indexSelected = 59) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\regalAngelfish.jpg")
    'ElseIf (indexSelected = 60) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\bluefaceAngelfish.jpg")
    'ElseIf (indexSelected = 61) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\flameAngelfish.jpg")
    'ElseIf (indexSelected = 62) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\queenAngelfish.jpg")
    'ElseIf (indexSelected = 63) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\linedButterflyfish.jpg")
    'ElseIf (indexSelected = 64) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\bandedButterflyfish.jpg")
    'ElseIf (indexSelected = 65) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\elegantFirefish.jpg")
    'ElseIf (indexSelected = 66) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\mandarinFish.jpg")
    'ElseIf (indexSelected = 67) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\indoPacificSailfish.jpg")
    'ElseIf (indexSelected = 68) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\antarcticToothfish.jpg")
    'ElseIf (indexSelected = 69) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\johnDory.jpg")
    'ElseIf (indexSelected = 70) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\coelacanth.jpg")
    'ElseIf (indexSelected = 71) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\commonClownfish.jpg")
    'ElseIf (indexSelected = 72) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\redLionfish.jpg")
    'ElseIf (indexSelected = 73) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\mahiMahi.jpg")
    'ElseIf (indexSelected = 74) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\humpheadWrasse.jpg")
    'ElseIf (indexSelected = 75) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\sheepsheadWrasse.jpg")
    'ElseIf (indexSelected = 76) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\oceanSunfish.jpg")
    'ElseIf (indexSelected = 77) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\stripedGoby.jpg")
    'ElseIf (indexSelected = 78) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\fireGoby.jpg")
    'ElseIf (indexSelected = 79) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\bluefinTuna.jpg")
    'ElseIf (indexSelected = 80) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\yellowfinTuna.jpg")
    'ElseIf (indexSelected = 81) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\seahorse.jpg")
    'ElseIf (indexSelected = 82) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\leafySeaDragon.jpg")
    'ElseIf (indexSelected = 83) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\pistolShrimp.jpg")
    'ElseIf (indexSelected = 84) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\peacockMantisShrimp.jpg")
    'ElseIf (indexSelected = 85) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\morayEel.jpg")
    'ElseIf (indexSelected = 86) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\ribbonEel.jpg")
    'ElseIf (indexSelected = 87) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\pelicanEel.jpg")
    'ElseIf (indexSelected = 88) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\redKingCrab.jpg")
    'ElseIf (indexSelected = 89) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\yetiCrab.jpg")
    'ElseIf (indexSelected = 90) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\lobster.png")
    'ElseIf (indexSelected = 91) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\portugueseManOWar.jpg")
    'ElseIf (indexSelected = 92) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\flowerHatJelly.jpg")
    'ElseIf (indexSelected = 93) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\crystalJelly.jpeg")
    'ElseIf (indexSelected = 94) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\blackSeaNettle.png")
    'ElseIf (indexSelected = 95) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\immortalJellyfish.jpg")
    'ElseIf (indexSelected = 96) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\commonStarfish.jpg")
    'ElseIf (indexSelected = 97) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\commonBrittleStar.jpg")
    'ElseIf (indexSelected = 98) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\reefStarfish.jpg")
    'ElseIf (indexSelected = 99) Then
    '    frmCompendium.picAnimalImage.Load("C:\Users\Leslie Archibald\Desktop\Visual Basic Files\MarineCompendiumBeta\Resources\commonSeaUrchin.jpg")
    ' End If



End Class