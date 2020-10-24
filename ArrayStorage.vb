Module ArrayStorage

	'Parallel Array Declaration

	Public names() As String = {
		"Vampire Squid",
		"Colossal Squid",
		"Giant Squid",
		"Firefly Squid",
		"Neon Flying Squid",
		"Humboldt Squid",
		"Market Squid",
		"Grimaldi Scaled Squid",
		"Umbrella Squid",
		"Blue-Ringed Octopus",
		"Giant Pacific Octopus",
		"Common Blanket Octopus",
		"Dumbo Octopus",
		"Bioluminescent Octopus",
		"Mimic Octopus",
		"Greater Argonaut",
		"Striped Pyjama Squid",
		"Flamboyant Cuttlefish",
		"Giant Cuttlefish",
		"Common Cuttlefish",
		"Chambered Nautilus",
		"Fuzzy Nautilus",
		"Palau Nautilus",
		"White-Patched Nautilus",
		"California Sea Lion",
		"Stellar Sea Lion",
		"West Indian Manatee",
		"Walrus",
		"Mediterranean Monk Seal",
		"Leopard Seal",
		"Harp Seal",
		"Orca",
		"Common Dolphin",
		"Common Bottlenose Dolphin",
		"Risso's Dolphin",
		"Spectacled Porpoise",
		"Pacific White-Sided Dolphin",
		"Gray Whale",
		"Beluga Whale",
		"Blue Whale",
		"Minke Whale",
		"Narwhal",
		"Frilled Shark",
		"Greenland Shark",
		"Pelagic Thresher Shark",
		"Nurse Shark",
		"Greater Hammerhead Shark",
		"Great White Shark",
		"Tiger Shark",
		"Giant Oceanic Manta Ray",
		"Smooth Stingray",
		"Japanese Eagle Ray",
		"Spotted Ray",
		"Green Sea Turtle",
		"Leatherback Sea Turtle",
		"Blue Tang",
		"Yellow Tang",
		"Regal Tang",
		"French Angelfish",
		"Royal Angelfish",
		"Blueface Angelfish",
		"Flame Angelfish",
		"Queen Angelfish",
		"Lined Butterflyfish",
		"Banded Butterflyfish",
		"Elegant Firefish",
		"Mandarinfish",
		"Indo-Pacific Sailfish",
		"Antarctic Toothfish",
		"John Dory",
		"Coelacanth",
		"Common Clownfish",
		"Red Lionfish",
		"Mahi Mahi",
		"Humphead Wrasse",
		"Sheepshead Wrasse",
		"Ocean Sunfish",
		"Striped Goby",
		"Fire Goby",
		"Atlantic Bluefin Tuna",
		"Yellowfin Tuna",
		"Short-Snouted Seahorse",
		"Leafy Seadragon",
		"Pistol Shrimp",
		"Peacock Mantis Shrimp",
		"Giant Moray Eel",
		"Ribbon Eel",
		"Pelican Eel",
		"Red King Crab",
		"Yeti Crab",
		"American Lobster",
		"Portuguese Man O' War",
		"Flower Hat Jelly",
		"Crystal Jelly",
		"Black Sea Nettle",
		"Immortal Jellyfish",
		"Japanese Common Starfish",
		"Common Brittle Star",
		"Reef Starfish",
		"Common Sea Urchin"
	}

	'***************************************************************************************************************************************************'

	Public otherNames() As String = {
		"   ",    'vampire squid, no other names
		"Antarctic Squid, Giant Cranch Squid",
		"   ",    ' giant squid, no other name
		"Sparkling Enope Squid, Hotaru-Ika",
		"Red Flying Squid, Akaika, Red Squid",
		"Jumbo Squid, Jumbo Flying Squid, Diablo Rojo",
		"Opalescent Inshore Squid, California Market Squid, Common Market Squid",
		"    ",   ' Grimaldi scaled squid, no other name
		"Jewelled Umbrella Squid, Jewel Squid",
		"    ",   ' blue ringed octopus, no other name
		"North Pacific Giant Octopus",
		"Violet Blanket Octopus, Blanket Octopus",
		"   ",    ' dumbo octopus, no other name
		"Glowing Sucker Octopus",
		"Lizard Island Octopus, Indonesian Mimic Octopus",
		"Paper Nautilus",
		"Pyjama Squid, Striped Dumpling Squid",
		"Pfefferi's Flamboyant Cuttlefish",
		"Australian Giant Cuttlefish",
		"European Common Cuttlefish",
		"Pearly Nautilus",
		"Crusty Nautilus",
		"King Nautilus",
		"    ",    ' white-patched nautilus, no other name
		"    ",    ' California sea lion, no other name
		"Northern Sea Lion, Steller's Sea Lion",
		"North American Manatee, Sea Cow",
		"Pacific Walrus, Atlantic Walrus, Morse",
		"Monk Seal",
		"Sea Leopard",
		"Saddleback Seal",
		"Killer Whale",
		"Short-Beaked Common Dolphin, Long-Beaked Common Dolphin",
		"Atlantic Bottlenose Dolphin, Bottlenose Dolphin",
		"Grampus, Grey Grampus, White-Headed Grampus, Gee Gees, Monk Dolphin",
		"    ",   ' Spectacled Porpoise, no other name
		"Hookfin Porpoise",
		"Gray Back Whale, Pacific Gray Whale, California Gray Whale, Devil Fish",
		"White Whale, Sea Canary, Melonhead, Belukha",
		"Sulphur Bottom",
		"Common Minke Whale, Northern Minke Whale, Southern Minke Whale, Antarctic Minke Whale",
		"Narwhale",
		"Frill Shark, Lizard Shark, Scaffold Shark, Silk Shark",
		"Gurry Shark, Gray Shark, Eqalussuaq (Kalaallisut name)",
		"Pelagic Thresher",
		"Tiburon Gato, Carpet Shark, Cat Shark",
		"Greater Hammerhead Shark",
		"Great White, White Shark, White Pointer",
		"Man-Eater Shark",
		"Manta Ray, Devilfish",
		"Short-Tailed Stingray, Bull Ray, Giant Stingray, Giant Black Stingray",
		"Kite Ray, Cowhead Eagle Ray",
		"Spotted Eagle Ray, Bonnet Ray, Bonnet Skate, Duckbill Ray",
		"Green Turtle, Black Turtle, Black Sea Turtle, Pacific Green Turtle",
		"Lute Turtle, Leathery Turtle, Luth",
		"Atlantic Blue Tang, Blue Barber, Blue Doctor, Blue Doctorfish",
		"Hawaiian Yellow Tang, Lau'ipala",
		"Pallete Sturgeonfish, Blue Tang, Royal Blue Tang, Blue Surgeonfish",
		"    ",   ' French Angelfish, no other name
		"Regal Angelfish",
		"Yellowface Angelfish",
		"Flame Angel, Dwarf Flame Angelfish, Japanese Pygmy Angelfish",
		"Blue Angelfish, Golden Angelfish, Queen Angel, Yellow Angelfish",
		"New Moon Coralfish",
		"Butterbun, Portuguese Butterflyfish, School Mistress, Banded Mariposa",
		"Purple Fire-Goby,  Decorated Dartfish, Firefish Goby, Flame Firefish",
		"Mandarin Dragonet, Mandarin Goby, Psychedelic Mandarinfish, ",
		"Bayonet Fish, Billfish, Atlantic Sailfish (former name)",
		"Antarctic Cod (misnomer)",
		"St. Pierre's Fish, St Peter's Fish, Kuparu",
		"Indian Ocean Coelacanth, African Coelacanth, Gombessa",
		"False Percula Clownfish, False Clownfish, Clownfish",
		"    ",   ' Red Lionfish, no other name
		"Common Dolphinfish, Dorado, Calitos, Lampuka, Maverikos, Rakingo",
		"Maori Wrasse, Napoleon Fish, Napoleonfish",
		"Asian Sheepshead Wrasse, Kobudai",
		"Common Mola",
		"    ",  ' Striped Goby, no other name
		"Firefish, Fire Dartfish, Red Fire Goby, Magnificent Dartfish",
		"Bluefin Tuna, Northern Bluefin Tuna, Giant Bluefin Tuna, Tunny",
		"Ahi, Albacore (misnomer)",
		"Seahorse",
		"Glauert's Seadragon, Leafies",
		"Snapping Shrimp, Alpheid Shrimp",
		"Harlequin Mantis Shrimp, Painted Mantis Shrimp, Clown Mantis Shrimp",
		"Moray Eel, Moray",
		"Leaf-Nosed Moray Eel, Bernis Eel",
		"Gulper Eel, Pelican Gulper, Umbrella-Mouth Gulper",
		"King Crab, Alaskan King Crab, Kamchatka Crab",
		"Yeti Lobster, Furry Lobster",
		"Atlantic Lobster, Canadian Lobster, True Lobster, Canadian Reds ",
		"Atlantic Portuguese Man O' War, Blue Bottle",
		"Flower Hat Jellyfish",
		"Crystal Jellyfish",
		"Black Jellyfish, Sarlacc Jellyfish",
		"Immortal Jelly",
		"Northern Pacific Seastar",
		"Common European Brittle Star, Hairy Brittle Star",
		"Reef Seastar",
		"European Edible Sea Urchin"
	}

	'***************************************************************************************************************************************************'

	Public sciNames() As String = {
	"Vampyroteuthis infernalis",
	"Mesonychoteuthis hamiltoni",
	"Architeuthis dux",
	"Watasenia scintillans",
	"Ommastrephes bartrami",
	"Dosidicus gigas",
	"Doryteuthis opalescens",
	"Lepidoteuthis grimaldii",
	"Histioteuthis bonnellii",
	"Hapalochlaena lunulata, Hapalochlaena maculosa, Hapalochlaena fasciata",
	"Enteroctopus dofleini",
	"Tremoctopus violaceus",
	"Grimpoteuthis umbellata",
	"Strauroteuthis syrtensis",
	"Thaumoctopus mimicus",
	"Argonauta argo",
	"Sepioloidea lineolata",
	"Metasepia pfefferi",
	"Sepia apama",
	"Sepia officinalis",
	"Nautilus pompilius",
	"Allonautilus scrobiculatus",
	"Nautilus belauensis",
	"Nautilus stenomphalus",
	"Zalophus californianus",
	"Eumetopias jubatus",
	"Trichechus manatus",
	"Odobenus rosmarus",
	"Monachus monachus",
	"Hydrurga leptonyx",
	"Pagophilus groenlandcus",
	"Orcinus orca",
	"Delphinus delphis," & ControlChars.CrLf & "Delphinus capensis",
	"Tursiops truncatus",
	"Grampus griseus",
	"Phocoena dioptrica",
	"Lagenorhynchus obliquidens",
	"Eschrichtius robustus",
	"Delphinapterus leucas",
	"Balaenoptera musculus",
	"Balaenoptera acutorostra," & ControlChars.CrLf & "Balaenoptera bonaerensis",
	"Monodon monoceros",
	"Chlamydoselachus anguineus",
	"Somniosus microcephalus",
	"Alopias pelagicus",
	"Ginglymostoma cirratum",
	"Sphyrna morkarran",
	"Caracharodon carcharias",
	"Galeocerdo cuvier",
	"Mobula birostris",
	"Bathytoshia brevicaudata",
	"Myliobatis tobijei",
	"Aetobatus narinari",
	"Chelonia mydas",
	"Dermochelys coriacea",
	"Acanturus coeruleus",
	"Zebrasoma flavescens",
	"Paracanthurus hepatus",
	"Pomacanthidae paru",
	"Pygoplites diacanthus",
	"Pomacanthus xanthometopon",
	"Centropyge loriculus",
	"Holacanthus ciliaris",
	"Chaetodon lineolatus",
	"Chaetodon striatus",
	"Nemateleotris decora",
	"Synchiropus spledidus",
	"Istiophorus platypterus," & ControlChars.CrLf & "Istiophorus albicans (formerly)",
	"Dissostichus mawsoni",
	"Zeus faber",
	"Latimeria chalumnae",
	"Amphiprion ocellaris",
	"Pterois volitans",
	"Corphaena hippurus",
	"Cheilinus undulatus",
	"Semicossyphus reticulatus",
	"Mola mola",
	"Gobius vittatus",
	"Nemateleotris magnifica",
	"Thunnus thynnus",
	"Thunnus albacares",
	"Hippocampus hippocampus",
	"Phycodurus eques",
	"Alpheus digitalis",
	"Ocontodactyllus scyllarus",
	"Gymnothorax javanicus",
	"Rhinomuraena quaesita",
	"Eurypharynx pelecanoides",
	"Paralithodes camtschaticus",
	"Kiwa hirsuta",
	"Homarus americanus",
	"Physalia physalis",
	"Olidias formosus",
	"Aequorea victoria",
	"Chrysaora achlyos",
	"Turritopsis dohrnii",
	"Asterias amurensis",
	"Ophiothrix fragilis",
	"Stitchaster australis",
	"Echinus esculentus"
	}

	'***********************************************************************************************************************************************'

	Public looks() As String = {
		"Vampire squids have a small body with eight tentaclses and two " &
			"sensory filaments. The tentacles are webbed, creating a cloak that " &
			"is lined with flesh spines called cirri. Its outside coloring " &
			"ranges from deep black to pale red, while the interior side of the " &
			"cloak is pitch black. The vampire squid has large eyes that are either red or blue " &
			"in color depending on the light. It also has small fins on either side " &
			"of its mantle that serve as the animal's primary means of propulsion.",
		"A colossal squid has a wide and stout mantle, making it extremely " &
			"heavy. The arms and tentacles have suckers equipped with sharp hooks that help it " &
			"capture prey. Some of the hooks a single point and a base " &
			"that swivels in place, and others having a fixed base and a trio of points. " &
			"Their beaks are extremely large, and their eyes have the distinction of being " &
			"the largest documented in the animalkingdom. Mature females are much larger than " &
			"mature males. Captured specimens are red in color, but it is possible that they " &
			"appear in a range of colors in their natural habitat.",
		"Much like other squids, the giant squid's body is composed of " &
			"a mantle, eight arms, and two longer tentacles. Their tentacular can grow longer than " &
			" any known cephalopod. The limbs' inner " &
			"surfaces are lined with surfaces, which themselves are lined with sharp teeth. " &
			"The teeth and suckers work in tandem to both capture prey and fight of predators " &
			"that may attack it. Their bodies range in color from red-orange to reddish browns, " &
			"similar to rust. The underside of their tentacles are pale white, a stark contrast " &
			"to the rest of the body. Both the beak and the eyes are quite large in size",
		"This tiny squid is mostly white, yellow, or light gray in color, with some small " &
		 	"brownish-red patches on the upper mantle. The tentacles are long and thin, appearing to be " &
		 	"almost translucent in some cases. Their entire body and tentacles appear to be speckled with " &
		 	"tiny black dots that are actually chromatophores. When threatened, attracting mates, or" &
		 	"hunting the squid will activate these chromatophores, causing their body to glow a brilliant" &
		 	"blue color. Suckers on the underside of the tentacles are equipped with small hooks",
		 "They are a reddish-brown and pale tan in color, making their rich black eyes " &
			"out against their coloration. Like over squid species, suckers cover the entirety of " &
			"their tentacles. However, unlike others, the neon flying squid doesn't have hooks " &
			"set into the suckers. Instead, theirs are lined wtih tiny teeth. A distinctive silver" &
			"streak along the front of their mantles helps to distinguish the neon flying squid " &
			"from other species of flying squid",
		"Humboldt squids are among the largest flying squids on earth, with" &
			"some larger specimens reaching a mantle length of two and a half meters. " &
			"Their neutral coloration is pale. However, they will often flash a variety " &
			"of colors to communicate with each other. Most notably, they will switch " &
			"from red to white during hunts, causing some to call them diablo rojos, or" &
			"red devils. Their fins are quite large, as is usual for species of flying " &
			"squid. The tentacles have approximately one hundred to two hundred suckers, " &
			"each one lined with sharp teeth-like structures.",
		"Market squids are long and thin, with the length of their mantles oftentimes being " &
			"four to five times larger than the width. Curiously, however, this size difference does not " &
			"extend to the fins, which are equal in length and width. Males and female tend to be " &
			"around the same size as one another. This differs from other squid species. Their bodies are " &
			"normally range in color from white to light brown. However, much like other cephalopods, they " &
			"have the ability to alter their color at will based on their mood and the need for camoflauge",
		"These pale squids are completely covered with dermal scales on their mantles. " &
			"Their tentacular clubs fail to grow to any great lengths, and in fact are often " &
			"completely lost in adults, leaving them with just eight arms. What little tentacles " &
			"the juveniles have contain small suckers with a single hook. The fins in both juveniles." &
			"and adults are quite large in proportion to their body size",
		"An umbrella squid is normally purple in color, though they have the ability to " &
			"alter their coloring as necessary. Their large wings form a heart shaped protrusion at " &
			"top of their mantle. Long tentacles trail from their lower mantle, and are connected " &
			"with webbing. The females of these species are much larger than the males. Large photophores " &
			"cover the outside of their bodies.",
		"These cephalopods are extremely tiny, with most of them " &
			"being less than a foot long. Despite this, however, they are rather " &
			"easy to spot thanks to their unique coloring. Their skin is pale yellow" &
			" and, as their name suggests, peppered with brilliant blue rings outlined" &
			"in black. When a blue-ringed octopus feels threatened, this already stunning" &
			" color scheme quickly and dramatically changes. Their skin's yellow hue " &
			"will brighten, while the rings themselves flash iridescent blue. The black " &
			"outlines also expand in size to further emphasize the color contrast.",
		"As the name suggests, this octopus is quite large. In fact, the " &
			"giant pacific octopus is the largest octopus currently alive (although " &
			"not the largest cephalopod alive). Like most cephalopods, they are great at " &
			"camoflauging themselves. However, their normal coloring appears to be a pale " &
			"reddish brown. Their mantles are covered in longitudinal folds that give the " &
			"body a slightly ruffled look. Their arms are lined with suckers and linked " &
			"together with webbing. When they are fully extened, this creates a parachute-like " &
			"structure",
		"The sexual dimorphism exhibited by this species is extreme, with the females " &
			"being up to sixty-six times larger than the males. The dorsal and dorsolateral arms " &
			"of the females are much larger than the others. These large arms are connected to " &
			"voluminous web-like membranes. Most of the time, this webbing is rolled up and stored " &
			"at the base of the tentacles. However, when threatened the blanket octopus unrolls it, " &
			"causing the animal's size to appear drastically larger. They are normally purple in " &
			"color, though like other cephalopods have the ability to change color at will",
		"These tiny umbrella octopodes have a very unique feature that makes them one of the " &
			"cutest octopodes in the world. Protruding from the top of their mantles is a pair of " &
			"ear-like fins. When the dumbo octopode flaps them to move around they look like large wings." &
			"Their tentacles are long, and can grow to about 20.4 cm (8 in) in length. They are joined at " &
			"the base with large web-like membranes. Like other octopodes, a dumbo octopus is able to change" &
			"its coloration at will. However, since there have only been a few specimens of the species" &
			"discovered it is unknown what it's natural or default coloration is.",
		"While the mantle of the bioluminescent octopus is small, their arms can grow to be" &
			"extremely large. Curiously, they also appear to grow to unequal lengths. This differs from " &
			"other species of octopodes, whose arms tend to be at similar lengths to one another. Webbing " &
			"connects the arms together, giving the animal an umbrella like shape. Cirri and suckers line the " &
			"underside of the arms, and are used to capture food. They are a translucent reddish brown color, " &
			"and it is possible to see the internal organs through their skin.",
		"Mimic octopodes are small creatures, and only grow to be about 60 cm (2 ft) on average. " &
			"This measurement includes the length of the arms, as opposed to only including the mantle. " &
			"Small horns protrude from the skin directly above each eye, which is useful when the animal is " &
			"impersonating various predators. They are naturally a light brown or beige color, but are usually " &
			"seen with a much more noticeable dark brown and white striped pattern. This, combined with its " &
			"movement in the water, allows it to impersonate many different species.",
		"The males of this species are small and form no shell. Females, on the " &
			"other hand, grow up to be about five times as large. They are a pale bluish " &
			"white in color. Calcite is excreted from the arms to create a thin shell, not " &
			"unlike that of an egg. The shell is extremely thin and papery, with smooth ribs " &
			"and distinct horn-like protrusions on either side. Juveniles for similar shells, " &
			"although theirs lack the horns. They live in this shell for most of their lives, " &
			"but are able to exit it if the need arises.",
		"Despite its name, this striped cephalopod is actually a cuttlefish" &
			"Notable differences between this animal and a squid include them having " &
			"W-shaped pupils and having an internal cuttlebone. They are normally white " &
			"in color with black linear stripes running along its entire length. Their " &
			"eyes are colored yellow and turned upwards instead of facing forwards. " &
			"The body of the animal is rounded, giving it a dumpling-like appearance. " &
			"This resemblance is only heightened when they tuck their ten limbs underneath " &
			"their body",
		"The flamboyant cuttlefish is a riot of color, " &
			"naturally being a bright burgandy and yellow in hue. Other " &
			"colors that can appear on its body include pale fuscia, hot pink, " &
			"white, and orange. Like other cephalopods, though, it is good " &
			"at changing its color to act as camouflage. Its mantle is oval " &
			"shaped, which is a bit unusual for other cuttlefish. Similarly " &
			"unusual are its broad and flat blade-like limbs. On the underside " &
			"of its limbs are four rows of suckers, some lined with papillae " &
			"to help it grip things better.",
		"The giant cuttlefish has a broad shaped mantle and short tentacles. They are " &
			"normally a brownish-red in color. Despite this they are able to alter their coloring and " &
			"patterns at will using chromatophones that cover their bodies. Their eyes are positioned " &
			"forwards rather than on the sides of their body. The sides of their mantle is covered " &
			"with a frill-like membrane.",
		"Sepia officinalis, the common cuttlefish, is one of the largest cuttlefish to " &
			"inhabit the oceans. Their mantles are are oval shaped, with thin, frill-like fins " &
			"extending along the sides. Their eyes, with their distinctive w-shaped pupils, are " &
			"situated on the head just below where the mantle ends. Eight arms and two tentacles " &
			"extend out from around the mouth. Like other cephalopods, common cuttlefish are masters " &
			"at changing their color using chromatophores on their skin. They have been observed with " &
			"coloration ranging from mottled red and browns to black and white zebra-esque stripes.",
		"The large shell of the chambered nautilus dominates its appearance. This " &
			"spiral-shaped structure is colored a whiteish gray with dark brown stripes. It " &
			"also exhibits countershading, where the bottom is lighter in tone while the top " &
			"is darker. Emerging from the mouth of the shell is the head of the animal. Their " &
			"eyes appear to be quite large, which is only enhanced by their tiny pupils. Also " &
			"protruding from the shell are long thin arms known as cirri. These fleshy " &
			"protrusions bear no suckers like the limbs of other cephalopods, and are in fact " &
			"not truly tentacles at all despite being called such.",
		"Fuzzy nautiluses are easily recognizable due to the fuzzy, velvet-like coating that covers " &
			"their shell. This coating, called periostracum, is normally a yellow-brown color, and appears to " &
			"have a texture similar to wet moss. Also distinctive is the hollow cone structure in the middle of " &
			"the shell's spiral. It is quite deep, sometimes taking up to hald the diameter of the shell as a whole. " &
			"what little remains of the exposed shell is white and brown. Their eyes are large with a pinhole-sized " &
			"pupil. Short tentacle like structers extrude from the mouth of the shell.",
		"At a quick glance, Palau nautiluses appear to be quite similar to the chambered " &
			"nautilus. However, there are many minute differences that are used to distinguish the species. " &
			"Palau nautiluses have shells that are much larger on average, as well as heavier. Small ridges also " &
			"are present on the shell, something that their cousin does not possess. They are colored white on " &
			"the bottom of their shell, while the top features stripes of darkreddish-brown. Short arms protrude " &
			"from the shell's opening, along with the head of the animal. Their eyes appear to be quite large " &
			"due to the tiny pupils in the center of them.",
		"Although simmilar to the chambered nautilus at a glance, the white-" &
			"patched nautilus features several morphological difference to distinguish itself. " &
			"Large white patches are located on the shoulder and umbilical areas of the shell, " &
			"breaking up the pattern of dark brown and white stripes that dominate the top of " &
			"the shell. The edges of the sheath, or openings where the cirri emerge from the " &
			"shell, are scalloped instead of smooth. Their eyes, much like other nautiluses, " &
			"feature a very large white sclera with tiny dark pupils.",
		"California sea lions are sexually dimorphic, meaning that the males of this " &
			"species looks quite different from the females. Males range in color from light brown" &
			"to dark brown, with some being a near-black color. A large crest protrides from their " &
			"foreheads, giving it their distinctive high, domed appearance. Females, on the other " &
			"hand, are light brown in hue, and much smaller than the males. Both sexes have long " &
			"narrow muzzels and a slender build, allowing for them to slip through the water " &
			"with ease. Large foreflipers are present, which are used to generate forward momentum " &
			"on both land and sea.",
		"The pups of this animal are very dark in color, but their coats lighten as they " &
			"grow older. When fully mature their pelts are light tawny brown, ocassionally mixed with" &
			"a reddish or pale yellow tone. Both males and females grow at the same rate for several " &
			"years before the female's growth slows. This allows the male to eclipse the female in " &
			"length. Males also have a broad, high forehead, flatter snouts, and a thick mane of coarser " &
			"fur around their necks. These help to further distinguish them from the females.",
		 "The West Indian manatee is a chubby animal with a streamlined shape. The snout is thick and blunt, " &
			"curving slightly as it reaches the nose. The front flippers are shaped like broad panels and are used for " &
			"steering. They have no hind limbs, instead possessing a broad tail that's shaped like a spatula. The body is " &
			"a brownish grey in color, but this coloration can appear more green due to the presence of algae that live on " &
			"the manatee's skin. Short hairs sparsely cover the body, while thicker bristles surround the muzzle. Their eyes " &
			"are set moderately back on their heads, and they posesse no visible earflaps.",
		"Walruses are large animals characterized by their mustache of whiskers and " &
			"impressively long tusks. Their skin is quite thick, and has many deep folds around " &
			"their shoulder area. It is covered with hair that is reddish in tone. This, combined " &
			"with the gray undertones of the skin, gives them a cinnamon coloring. Walrus have rounded " &
			"heads and, like several of their relatives in the Phocidae family, have no discernable " &
			"external ears. The eyes of the animal are quite small, which is only made more apparent " &
			"due to their proximity to the tusks of the animal.",
		"These cute and chubby seals are often found " &
			"lounging on beaches in the Mediterranean. Their snout is " &
			"short and broad, and is pressed flat against their face. " &
			"This gives the nostrils an extremely large appearance. The " &
			"seal's body is covered in short hair, with the dorsal side " &
			"is black, brown, or gray in color. The underside is a pale " &
			"tan or white. Their flippers are short and unable to support " &
			"the seal's mass on land, but are powerful enough to propel " &
			"them through the water swiftly. The flippers also have slender " &
			"claws on the end.",
		"This lean and muscular seal is instantly recognizable " &
			"by its large head and massive set of jaws. Short whiskers line " &
			"their nose, allowing them to sense the surrounding environemtnt " &
			"underwater. The coat is countershaded, meaning that its dorsal " &
			" or upper side is darker in appearance than the ventral, or underside " &
			"is. The top is a mottled silver and dark gray, making the distinctive " &
			"spotted pattern that they are named after. The underside, on the other hand, " &
			"is light gray or white. This countershading helps camouflage the seal, " &
			"hiding it from both predators and prey.",
		"Pups have a fluffy white coat and pure black eyes. " &
			"As they mature, their fur turns silver-gray in color, while black " &
			"markings appear on its back. These markings appear in the shape of " &
			"a harp or a whisbone, which gives the seal its name. Due to the fact " &
			"that it belongs to the class of phocidae, it has no visible ears. They " &
			"are extremely chubby due to their thick coat of blubber, and can only " &
			"awkwardly flop or crawl on land, but in the water they are extremely " &
			"swift.",
		"The instantly recognizeable orca is " &
			"predominantly black or dary gray with a white underbelly and " &
			"eye patch. Calves are born with a yellow or orange tint that " &
			"gradually fades into pure white. males have a straight dorsal fin " &
			"while the dorsal fin of a female is more curved. Behind the dorsal " &
			"fin is a gray saddle patch, which helps scientists identify individuals. " &
			"There are distinctive variants in the patterns and coloration based on the location " &
			"the individual was born in",
		"These dolphins are medium sized, with the males being larger than the " &
			"females. Their dorsal side is either a dark gray or black, while their bellies " &
			"are white. There is an hourglass-shaped marking on both of their sides, which " &
			"is colored light gray, yellow, or gold. Short-beaked common dolphins, as the " &
			"name implies, have a shorter beak than the long-beaked common dolphins. They " &
			"also tend to be slightly smaller in size",
		"Gray in color, these large dolphins are common " &
			"sights in oceans worldwide. They are long and slender with " &
			"muscular bodies and smoot skin. The dolphin's beak, or snout, is short and well " &
			"definied, and is shaped like an old-fashioned gin bottle. Their " &
			"underbellies are a bit paler in color than their dorsal side. Populations that live on" &
			"the coast tend to have larger flippers and a smaller body. The dolphins that live " &
			"in deeper waters are larger in size and darker in color, with shorter" &
			"beaks and fins. ",
		"These dolphins have a stocky build with no discernable beak. This makes their" &
			"general silhouette appear closer to a porpoise rather than another dolphin. " &
			"Adolescents are a grey or dark brown color with a pale underbelly. As they grow " &
			"older, however, the accumulate battle scars from fights with prey and other " &
			"Risso's dolphins. This gives them the appearance of being partially or fully white.",
		"Like most other porpoises, the spectacles porpoise has no discernable beak. " &
			"Their body is streamlined in shape, bulging outwards slightly in the middle before " &
			"tapering off into a powerful tail. Their skin exhibits something known as " &
			"countershading with black and white markings. Chief among these markings is the white " &
			"white stripe on the tai, and then the dark and light rings surrounding the eyes. Their " &
			"dorsal fins are rounded rather than pointed at the top.",
		"These beautiful animals are medium sized when compared to other dolphins. Their bodies are " &
			"stout, and crowned by a disproportionately large dorsal fin. The snout that protrudes from their " &
			"heads is short, as opposed to the longer ones of their cousins. The back, tail, and snout are black " &
			"in color, while the belly is white. Both the dorsal fin and the pectoral flippers are a medium gray. " &
			"On each side is a pale grey or white stripe that extends the full length of the dolphin, and gives them " &
			"their common name.",
		"This large whale has dark skin with lighter gray patches and white scars, " &
			"creating a mottled appearance. Their mouths are full of baleen, which is visible when " &
			"the whale is feeding. There are two blowholes on the top of their head, creating a " &
			"distinctive heart shaped water spout. Newborns are a solid dark gray to black in color. " &
			"The whale has no dorsal fin, instead possessing six to twelve crenulations or knuckles " &
			"leading to their flukes. Their backs are often covered with parasites and barnacles, " &
			"which makes them look like a salt crusted ocean rock when at the surface of the water",
		"This whale is unique among others due to two key characteristics. " &
			"The first is its pure white coloring, while the second is the absense of a " &
			"dorsal fin. Both of these anatomical differences are the result of adapting to " &
			"life in the Arctic circle. Its body is extremely stocky, something that is only " &
			"accentuated due to the lack of a dorsal fin, but tapers off quite suddenly at the. " &
			"neck. This gives the whale the appearance of having shoulders. Their flippers are " &
			"short, broad, and almost square in shape. The tailfin, on the other hand, is extremely " &
			"curved. The curves become fancier and more ornate the older the whale becomes.",
		"As the largest animal alive on the planet, blue whales are truly enormous. " &
			"Pleats on their stomach and throat expand when it intakes water, " &
			"giving it a bulging appearance during feeding. These pleats are yellowish in color. The mottled " &
			"blue-gray body is stocky due to large amounts of blubber underneath the skin. Their head is " &
			"extremely broad and flat. The flippers and tail flukes are long and slender. The dorsal fin near " &
			"the tail appears small due to the sheer size of the whale. It is, however, quite large",
		"Both species of minke whales are a dark gray or black color on the dorsal side, while the belly " &
			"is colored white. Much like other baleen whales, their heads are broad and flat on top. Pleated skin " &
			"on their throats expands as water is brought in during feeding. The dorsal fin is small and located " &
			"near the tail. Their flippers and tail flukes are slender. On the northern minke whale, white bands go " &
			"across the flippers horizontally.",
		"These medium sized whales are a mottled grey and brown in color, with a noticable bulge in the forehead. Their snouts are short, further " &
			"enhancing this odd shape. Narwhals do not have a dorsal fin, instead possessing an extremely small dorsal ridge. " &
			"Their flippers and tail flukes are short. Their most stunning, feature, however, is the tusk that can extend " &
			"outwards several feet from the upper left lip. Both males and females can grow tusks, though a tusked female is " &
			"quite rare. The female's tusk is much smaller than the males, and lacks a noticable spiral shape",
		"The frilled shark is a long, eel-like fish that is colored a dark brown. Small fins " &
			"are located on the pelvis, back, and near the anus. They posess six pairs of gills " &
			"positioned on the throat. The frilly appearance of the gills is what gives the shark its " &
			"common name. Inside the mouth are several needle-shaped teeth, used to stop prey from escaping." &
			"In males the body is much longer than that of the females. The front fins are short, but " &
			"as they progress closer to the tail they grow longer and more ornate.",
		"Rivaling the size of a great white shark, the greenland shark is " &
			"a thick-set species. They have a short, rounded snout and small eyes. Their dorsal " &
			"and pectoral fins are extremely small. The sharks can range in color from pale " &
			"gray to black to dark brown, and are usually uniform in color. Whitish spots or " &
			"dark streaks can occasionally be seen on their backs. Surprisingly, their gills " &
			"are extremely small in proportion to their large body.",
		"A slender shark with a long tail, the pelagic thresher is the " &
			"smallest of all thresher sharks. They are wider on the middle than on the sides, " &
			"and are identifiable by small lobe-shaped protrusions near the base of their " &
			"tails. The pectoral fins are long and straight with broad tips, while two dorsal " &
			"fins jut out from the middle of their back. The pelagic thresher's head is narrow, " &
			"and their snout is short and cone-shaped. The body is an intense dark blue color " &
			"on the dorsal side, while the underbelly is white. The darker pigment on its pectoral " &
			"fins helps to distinguish this species from a common thresher.",
		"Young nurse sharks are spotted, but as the grow older the spots fade and " &
			"they turn pure brown. Their tail and pelvic fins are extremely long, a sharp contrast " &
			"the smaller front fins. The main body is broad and flat, allowing it to easily move " &
			"along the bottom of the sea. Just over halfway down the body a large caudal fin juts out " &
			"from the animal's back. This particular fin is much larger the second caudal fin directly " &
			"behind it, and can reach a height that is equivalent to a quarter of their total body length.",
		"A large and imposing looking animal, the great hammerhead is easily recognizable" &
			"at a distance. The shape of the hammer, called a cephalofoil in scientific writing, is " &
			"straight along the front. The dorsal fin is curved, almost in a sickle shape. The other " &
			"fins, although smaller, mimic this shape as well. The shark is gray-brown in color, dark on top " &
			"while much paler on the belly. This countershading helps hide it from both prey and predators.",
		"As one of the most commonly known sharks to the general public, the great white " &
			"has the classic shark silhouette. Their bodies are a dark grey on top while a pale white " &
			"or light grey on the bottom. The fins are large, especially that of the tail and frontal " &
			"fins. The snout is large and pointed, something that is accentuated by the smaller eyes. " &
			"The shark's mouth is large, and the inside is lined by several rows of serrated teeth. The " &
			"gills are long and located on the sides of the neck",
		"Juvenile sharks have dark vertical stripes, the source of their name. As they grow older " &
			"these stripes fade, leaving them with a blue-gray coat on the dorsal side. Like other " &
			"oceanic creatures, their bellies are light in color. Females of this species are much larger than " &
			"the males, and can balloon in size and weight when carrying young. Their dorsal fin is set far back " &
			"in comparison to other species. Five gills line the side of their necks, ending close to the frontal " &
			"fins. The shark's snout is blunt rather than conical and pointed like that of other sharks. ",
		"Manta rays are large and flat with a kite shaped body referred to as a disc. The large wing-like " &
			"shapes on the side of the disc are actually large pectoral fins. The mouth and gills are located on the " &
			"bottom of the body. Their tails are long, but do not possess any sort of spines like other rays. A manta's " &
			"body is colored a dark grey or black on top, and white on the bottom. White patches on the top are unique to " &
			"each individual. These animals are sometimes grouped under the name chevron color type. However, all black " &
			"manta rays have been sighted many times.",
		"A smooth stingray's body is vaguely shaped like a diamond, with the length being " &
			"slightly less than the width. Their eyes are extremely small, and are overshadowed by the " &
			"nostrils located directly next to them. Smooth skin covers the body, and is usually colored " &
			"dark gray or brown on top. The belly is pale, providing countershading. Arguably the most " &
			"notable feature is the short, somewhat thick tail. The surface is covered with thorn-like " &
			"protrusions. Located about halfway back are one or two spines that are the main source of " &
			"venom for the sting.",
		 "The body of this animal is smooth and colored a murky yellow-brown. Patches of dark " &
			"spots sometimes dot the disc, and can be used to identify individuals. The snout of the animal is " &
			"blunt and slopes immediately up to a high forehead. This, combined with the large eyes and the shape " &
			"of the nostrils gives them the appearance of a young calf. Their tail is quite long, something that " &
			"is accentuated by the long stinging spines located along the length of it.",
		"These animals, befitting of their name, looks like they're covered in polkadots. " &
			"A base of black or dark blue skin is speckled with hundresds of white spots on top, whereas " &
			"on the underneath side they are pure white or light grey. The shape of the body is that of " &
			"a kite. A long tail emerges from the base of the body between two small pelvic fins. Several " &
			"stinging spines dot the tail, and are used for defense.",
		 "Green sea turtles posses the typical featuers one would expect from any other " &
			"turtle. The body is flat and hidden mostly inside a hard shell. This shell is a dark " &
			"brown in color on top, while the lower portion - called a plastron - is colored a " &
			"light yellow. As they grow older, the upper carapce of the shell can become spotted " &
			"or marbled. They have a short snout and an unhooked beak. The skin of the animal is " &
			"brown and white in a pattern reminiscent of cracked leather. Long flippers extend " &
			"outwards from the shell, and are used to propel the sea turtle through the water.",
		"These turtles posses a dark colored body that is shaped like a teardrop. Large, " &
			"powerful flippers extend outwards, sometimes reaching a span of 2.7 m (8.9 ft) in the " &
			"largest of these reptiles. Their snouts are short and blunt. The skin feels and looks " &
			"like a rubbery leather. Unlike other turtles, the leatherback lacks a hard shell. " &
			"Instead, their shells are covered with thicker skin and flesh. This makes them quite soft" &
			"The belly is black or dark grey with white splotches.",
		"Although known as blue tang, these fish actually start out their lives " &
			"as yellow fish. Upon hatching juveniles are yellow, but as they grow older " &
			"their bodies darken to a uniform blue color. The body itself is flat and oval " &
			"shaped. Spines and soft rays line the upper and lower bodies. Their tails start " &
			"as a flat triangular shape, but as the fish matures the edges become more curved. " &
			"their eyes are placed high on the body, directly behind the pointed snout",
		"Yellow tang possess a body not unlike other species of tang. They are a " &
			"thin, oval-shaped fish with a pointed snout and eyes that are located high up " &
			"on the body. Soft rays, interspersed with sharper spines, line the dorsal and " &
			"pelvic areas. They are a uniform yellow color during the day. At night, however, " &
			"the yellow darkens and a patch of brown becomes visible in the center of the body.",
		"These beautiful fish have a deep blue body with black markings. The tail fin is a " &
			"bright yellow bordering on neon, matched by a small yellow dot on the tip of each of the " &
			"pectoral fins. Their bodies are vaguely oval shaped and extremely flat. The eyes of the " &
			"fish are relatively in proportion to their body size, and sit a bit far back from the " &
			"pointed snout. Long, sharp caudal spines and soft rays emerge from the body from the dorsal " &
			"and pelvic areas",
		 "These beautiful fish are a black and steel blue color, with scales on the body " &
			"being edged with yellow. This same yellow surrounds the iris, dorsal filaments, and a " &
			"broad band across the pectoral fins. Their face is a paler blue-grey color, while the " &
			"chin and area around the mouth ranges from light grey to white. As a juvenile, the fish is " &
			"entirely black with yellow bands running the length of their bodies. French angelfish are " &
			" quite flat, but can grow to a surprisngly large size.",
		"Its body is somewhat elongated and compressed, " &
			"with small eyes and a slightly pointed mouth. A prminent spine protrudes " &
			"from the body near their eyes. their fins are covered in soft rays and small " &
			"spines, giving it a slightly whispy appearance. Coloration of the fish varies " &
			"from region to region. Commonly, however, they have a body covered in narrow " &
			"blue, white, and orange stripes. Their underbelly, face, pectoral fins, and tail  " &
			"are yellow, while the fins by the tail are either black or blue. Juveniles have a " &
			"large spot on their dorsal fin that fades as they mature.",
		"Blueface angelfish are long and flat, almost like a pancake. Their fins are rounded, while " &
			"the tail is fan shapped. The front of their bodies gradually turns to a rounded off snout. As " &
			"juveniles, they are covered in vertical black and white bars. The fins and tail are edged with " &
			"electric and dark blues. As they grow older, this coloration gradually fades into pale blue scales " &
			"lined with yellow. The fins, as well as the tail, and scales around the eyes are bright yellow; " &
			"while the lower part of the face is a brilliant royal blue " &
			"color. At the base of the dorsal fin is a black eyespot, which is used to ward off predators",
		"This beautiful fish is colored a brilliant red-orange. The dorsal and anal fins " &
			"are edged with indigo and black bands. More black bands adorn the sides of the fish. " &
			"These may or may not also be accompanied by black spots. The eyes are small, while " &
			"the snout is pointed. Males of this species are usually larger and more brightly colored than the females",
		"This regal looking fish has scales that range with blue to blue-green, and are edged " &
			"with yellow. The tail and chest fins are bright yellow. A queen angelfish's snout and the edges " &
			"of their dorsal and anal fins, however, are dark blue. As a juvenile, they have a dark blue body, " &
			"yellow fins, a yellow tail, and a yellow snout. The vertical bars on their body are either a pale " &
			"blue or white. Regardless of age, the fish has a flat, pancake-like body that tapers to a rounded " &
			"off point in the front. The dorsal and anal fins curve back sharply, while the tail is small and " &
			"fan shaped.",
		"Among the largest of the fish belonging to the genus Chaetodon, the lined butterfly fish can " &
			"grow to be the size of a small platter. The main body of the fish is white, with thin black vertical " &
			"lines spanning their entire length. The face and a small cresenct patch on their sides are black. This " &
			"creates a striking contrast with the brilliant yellow fins and tail. While the anal and dorsal fins are " &
			"quite large, the pectoral fins in comparison are almost comically small",
		"This flat-bodied fish has medium sized fins and a small tail. The dorsal fin starts out as " &
			"several spine like protrusions before morphing into a smooth fin. Their body is a silvery white " &
			"color. Three thick bands that are either black or a dark gray in color are positioned vertically " &
			"along the length of the body. One of these bands runs through the eye, helping to conceal it from " &
			"predators. The pelvic and dorsal fins are black with a white edge. This is mimicked on the tail, " &
			"which features a thin band edged on both sides with white.",
		"The fish is slender and colorful, with a swath of purple on the head, " &
			"whitish-yellow body, and dark gray tail. Their fins have horizontal bands colored " &
			"purple, red, black, and orange. They are quite tiny, with the largest among them measuring " &
			"in at less then half a foot. Soft rays emerge from the fins, which are elongated compared to " &
			"to the rest of their bodies",
		"The mandarinfish has a thin, rounded body with slightly protruding eyes. Their dorsal " &
			"and pelvic fins. The pectoral fins, in comparison, are small and transparent. Mandarinfish are " &
			"best known for the bright, striking colorations that pepper their bodies. The body is orange " &
			"with abstract neon blue stripes swirling across the entirety of the fish. The heads are much " &
			"paler in comparison, usually being a light blue or green color. Mandarinfish usually have red " &
			"eyes with black pupils, causing them to stand out against the paleness of the head.",
		"This long and slender fish is silvery blue in color darker on top" &
			"than on the bottom, with a large dark blue dorsal fin that gives it its name. " &
			"The fin can be raised and lowered at will, providing stability in the raised " &
			"position and reducing drag during short sprints. Their other fins are very " &
			"slender, with the pectoral fins being pointed and the caudal fins (located near " &
			"the tail) form a crescent shape. The fish’s jaws extend into a slender bill, " &
			"the uppermost portion protruding dramatically",
		"They are large fish with a slight underbite, colored " &
			"black to olive brown. They are sometimes lighter on the" &
			"underside. Its skin is mottled on the body and fins. The head is " &
			"broad, and the body is quite elongated. Its fins are quite large," &
			"and the caudal fin near the tail looks similar to a rudder.",
		"Long considered to be one of the ugliest fish alive, the John Dory is not a pretty " &
			"sight. Their bodies are shaped like a flattened disk, with long spines emerging from the " &
			"dorsal fin. The rest of their upper fins and tail are primarily clear with thin strips of " &
			"brown. Large eyes protrude from the front of the head, set just above the pointed mouth. " &
			"The majority of the body is a mottled mix of brown and murky yellow. A large dark spot " &
			"is located on their sides. The lower fins are a solid brown, and are quire large compared to " &
			"the body.",
		"This bizzare looking fish has a multitude of unique features.  The body of a coelacanth " &
			"is steely blue flecked with white in life, though this can quickly fade to a dull brown or grey " &
			"after death. The body is long and tube-shaped with only a subtle narrowing at the transition from " &
			"body to tail. the pectoral fins are attached to lobe-like protrusions on the body, almost like tiny " &
			"limbs. Their scales are thick, almost like plated armor. The jaw is quite large, and has the ability " &
			"to hinge outwards and drastically increase in size.",
		"The common clownfish is perhaps the most recognizable of the thirty odd " &
			"species of clownfish in the wild. The body is shaped like an oval, and is quite thick. " &
			"They are primarily orange in color, with white bands separating sections of the body. " &
			"These bands are located behind the head, in the center of the body, and the base of the " &
			"tail. Black outlines further delineate the boundaries between the white and orange " &
			"areas. The fins and tail are edged with black, but also have a whispy layer of soft rays " &
			"that extend out past the blackened areas.",
		 "The most remarkable feature of the red lionfish is the 'mane' of venemous spines " &
			"that surround their body. Their fins and tail mimic these spines by having thing bands of " &
			"colored flesh interspersed among transparent membranes. The banding patterns continue " &
			"onto the compact body of the fish. The entire animal's coloration is made up of white stripes " &
			"that alternate with reddish-brown ones. ",
		"Mahi Mahi have a very broad head and body that tapers to almost a point at the " &
			"junciton where the body meets the tail. A sail-like dorsalfin stretches the entire length " &
			"of the fish. The smaller anal fins curl inwards, and the tail is shaped like a crescent. " &
			"On top they range in color from teal to turquoise and every shade of blue-green in between. " &
			"This fades into a golden-yellow color " &
			"on the belly and sides. Dark spots dot the fish from head to tail. Their jaws are relatively " &
			"small and is located relatively low on the fish. This gives them the appearacne of a " &
			"rather high forehead",
		"Like the name implies, humphead wrasses have a large hump on their forehead.  This, " &
			"comnined with the large lips and small eyes, gives it a rather comical appearance. It also " &
			"helps to distinguish it from other species of wrasse. Two small black lines, located behind the " &
			"eyes, also help with identification. They usually are a dull blue or green color, however some " &
			"individuals that are a more vibrant green or purple-blue have been observed.",
		"The sheepshead wrasse has a large, bulging jaw and forehead. The lower lip of the fish is " &
			"similarly enlarged, while the upper lip is much smaller. This gives it the appearance of having a " &
			"swollen lower lip. The eyes are small and set far back on the head. Their dorsal fin is very short, " &
			"only growing in size close to the base of the tail. The pelvic fin mirrors the end of the dorsal fin." &
			"Their tails are quite broad, starting out as a dark color near the base before lightening to an almost " &
			"transparent color at the tips. Sheepshead wrasse tend to be a blue-grey or grey-brown in color.",
		"When viewed from the front, an ocean sunfish may appear as nothing more than a thin line. " &
			"When viewed from the side, however, the unusual appearance of the fish becomes apparent. The body is " &
			"compressed laterally, and is shaped like a massive oval. The eyes and mouth, in comparisson, look to " &
			"be quite small. The caudal fin, located at the base of the tail, is rounded and appears to merge into the " &
			"tail. The most distinctive features are the extremely tall dorsal and ventral fins jutting " &
			"away from the body like large spires. Ocean sunfish are grey in color, and appear to have a rough, " &
			"rock-like texture on their skin.",
		"A small fish, the striped goby is streamline in shape, almost like a torpedo. " &
			"The fins and tail are almost clear, making them very difficult to see in water. " &
			"Their bodies are silvery or light brown in color. Two dark stripes, which give " &
			"the goby its common name, run horizontally along the length of the body. ",
		"Fire gobies are a small fish with an almost comically long dorsal fin. " &
			"The fin juts up above the body in a long, thin spire that the fire goby uses to " &
			"other species. The tip of the head is yellow, bleeding into a pale white color " &
			"along the front half of the body. The back half and tail is colored in a gradient " &
			"ranging from pale orange to a deep red. The rear fins are edged in black",
		"The body of an Atlantic bluefin tuna is shaped similarly to that of a stereotypical " &
			"fish - broadening until the base of the dorsal fin before tapering off into the tail. " &
			"They are colored a dark blue on top, while the sides and belly are silver. Instead of " &
			"possessing caudual fins, they have small yellow finlets. The dorsal fin is shaped like a " &
			"sail and is also colored yellow, albeit in a duller tone than the finlets. The adipose fin, " &
			"located directly behind the dorsal fin, is hook shaped. This shape is also shared by the anal " &
			"fin on the belly of the fish.",
		"The most striking feature of this fish are the long second dorsal and anal fins. In older " &
			"yellowfin tunas, the sickle-shaped fins can reach back as far as the base of the tail. They, along " &
			"with the other fins and finlets, are bright yellow in hue. This yellow is continued in a streak " &
			"on the sides of the fish. The dorsal side is a dark blue, while the belly is a silvery-white tone." &
			"Thin vertical lines are located along the length of the fish, and are most noticable on the belly.",
		"These animals normally hold their bodies in a position reminiscent of a capital S. " &
			"The bodies are usually orange or brown in color, but specimens that are purple or black " &
			"have been observed. Bony protrusions give them a sharp and angular appearance. The fins are " &
			"small and mainly used to steer the seahorse as it drifts in the current. A short snout extends " &
			"from the head. When viewed from the side, this causes the animal's head to appear similar to " &
			"that of a horse.",
		"At first glance, it is hard to distinguish a leafy seadragon from the surrounding kelp beds " &
			"they call home. Their long, skinny bodies are usually brown in color, though during mating seasons " &
			"this can brighten into a beautiful yellow. The most distinguishing feature, however, are the many " &
			"leaf-shaped appendages that sprout from various points of the body. The green and brown coloration " &
			"of these protrusions, combined with the shape, help to disguise the animal as a floating piece of " &
			"of kelp",
		"The pistol shrimp's dominant, most eye catching feature, is their enlarged front " &
			"claw. The almost comically large appendage has a unique 'hammer and socket' mechanism that " &
			"is only visible when the claw is open, and is the source of the characteristic snapping sound " &
			"that is emitted by the animal. The other claw is much smaller, and lacks the socket mechanism " &
			"the other one possesses. Pistol shrimps habe small bodies that are usually colored red on top, " &
			"with the belly being a pale yellow or cream color. Long antenna jut out from the face, and " &
			"are used by the shrimp to detect prey.",
		 "the peacock mantis shrimp has a hard shell with multiple legs poking " &
			"out from beneath the body. Large eyes, which are usually blue in color, sit above the head,. " &
			"The largest forelimbs appear similar to those of a praying mantis. The front section of the shell and limbs " &
			"are covered in irregular leopard-like spots. Females tend to have mostly red bodies, while the males " &
			"are adorned with bright colors. Specimens have been seen sporting everything from neon pinks and oranges " &
			"to acid greens and electric blues. ",
		"This long creature may look similar to a snake, but the giant moray bears no relation " &
			"to the scaly reptile. Their heads are short with a blunt snout and large nostrils. The skin " &
			"on their throat is wrinkled, and gill slits are located behind the base of the jaw. Their " &
			"eyes are of a moderate size with a brown iris and blue-tinted sclera. A large dorsal ridge runs " &
			"down the length of the animal's back. As juveniles they are a tan in color with large, well-defined " &
			"black spots. As they mature into adults, the color of their skin darkens into a rusty brown. " &
			"The black spots become less defined and intersperesd with smaller black specks, creating the " &
			"appearnce or leopard-like spots",
		"Ribbon eels are some of the most mesmerising creatures in the world. The jaw is " &
			"moderately sized and sits underneath a pair of elongated nostrils. Their bodies are long " &
			"and thin with a high dorsal fin that gives it the characteristic ribbon-like appearance when " &
			"swimming. As juveniles, the eels are black with a yellow dorsal fin. The black gradually turns " &
			"into a bright electric blue as they mature into adult males. Upon completing their transition to " &
			"females late in their life, they turn completely yellow.",
		 "The most noticable feature of this deep-sea fish are the comically large jaws. " &
			"The lower one dangles from a loose hinge joint, and is attached to an enourmous pouch " &
			"that is capable of being inflated. The jaws together appear much like a pelican's beak, " &
			"giving rise to the animals'c ommon name. Their eyes are small and located towards the " &
			"tip of the upper jaw. Tiny pectoral fins and pore-like " &
			"gills are found further back from the animal on the rather small body. The rest of the " &
			"pelican eel's body consists of the long, whip-like tail. At the tip is a bioluminescent organ." &
			"Their skin is either black or a dark olive color. ",
		"Much like the stereotypical crab, the red king crab posseses a flattened body " &
			"inside of a flat, hard exoskeleton. Four legs are located on each side. These, paired " &
			"with the two large claws, make up the ten legs characteristic of a member of the order " &
			"Decapoda. The total leg span can be many times the size of the crab's body. Their " &
			"exoskeletons are covered in small spines, which provides them protection against " &
			"predators. The belly and underside of the legs are pale in color, usually white. " &
			"The top of the shell and legs are burgandy, but take on a more characteristic red hue " &
			"when cooked.",
		"Yeti crabs posses a teardroped shaped body covered by a hard exoskeleton. " &
			"Their colorations range from an extremely pale tan to pure white. Most of their " &
			"limbs are relatively proportionate to their body, but the large front claws " &
			"dwarf the crab completely. In some specimens, the front claws are longer than " &
			"main body. Each limb is covered with fine hair-like structures that are the " &
			"origin of the crab's common name.",
		"The American lobster is easily recognizable by the general public due to their " &
			"impressive front claws and long attena. The body is shaped similarly to a tube and " &
			"consists of three main parts - the head, the thorax, and the abdomen. A smooth, hard " &
			"outer shell protects the crustacean from enemies. Beneath the body are eight legs, as " &
			"the front pair have evolved into the massive claws they wield. They normally are colored " &
			"brown with hints of blue-green, however other colors have been seen in the wild",
		"This bizzare looking animal at first glance appears similar to a jellyfish. A " &
			"bulbous, air-filled pouch called a pneumatophore floats above the water. This part " &
			"is normally tinted a translucent blue, however specimes that are purple, pink, or " &
			"mauve have been observed. The top of the pneumataphore is pinched into a sail-like fan. " &
			"Beneath the water are two groupings of tentcles - the shorter, slightly thicker ones that " &
			"and the longer, thinner tentacles that extend up to a whopping 558.9 times their body length. " &
			"The tentacles are darker than the pheumataphor, with some of the darkest appearing midnight " &
			"blue or even black.",
		"These delicate creatures are tiny, with the largest being no more than half a foot long. " &
			"The dome part of the animal, known as the bell, is clear with thin opaque stripes flowing down it " &
			"luminous tentacles in a variety of shades hang off the edge of the bell. Some remain coiled close " &
			"to the bell's rim, while others trail further down to drift behind the jelly as they swim. The tips of " &
			"these tentacles appear fluorescent under black lights.",
		"Crystal jellyfish are transparent and colorless, making them extremely difficult to " &
			"see when not viewed under black light. The bell is of a moderate size and has up to one " &
			"hundred radial canals extend from its center. In larger, more mature specimens these canals " &
			"can thicken and become white as gonads grow in. Their tentacles are uneven and, like the rest of " &
			"the animal, clear. Crystal jellies are bioluminescent and glow in either a blue or green color.",
		"These massive jellyfish are unique among jellies due to their opaque bell. " &
			"They are colored a dark purple or black, with the rims being a lighter brown. The bell " &
			"appears wrinkled and bunched up along the edge, almost like a large cloth cap. Thin " &
			"fillaments extend downwards on the outer rim, while thicker tentacles emerge from the " &
			"inner rims. These tentacles match the lighter colorations of the bell. They appear frilly " &
			"when billowing out behind the animal as it swims.",
		"Immortal jellyfish are tiny, with the largest specimens not even reaching half a " &
			"centimeter in length. Everything, from the tentacles to the bell, of this animal is clear. " &
			"The one exception to this is their stomachs, which are bright red. The smaller specimens " &
			"have eight, evenly-spaced tentacles. Larger, fully developed adult ones have anywhere from " &
			"eighty to ninety.",
		"Japanese common starfish, in many ways, does not depart from the traditional depiction " &
			"of a starfish. They have five arms that radiate out from a central disc. On the underside, they " &
			"are a yellowish orange color. On the dorsal side, they exhibit a range of colors. Some are red or " &
			"purple, while others are orange or match the yellow of the underside. The edges of the arms are " &
			"outlined in irregularly shaped spines. White specks and stripes decorate the creature all over the " &
			"dorsal side.",
		"Common brittle stars have a small central disc that is covered with heavily calcified scales. " &
			"Five segmented arms spread out from this disc, dwarfing it in size. Each segment has seven of the glassy " &
			"spines that help give the creature its name. They are normally monochrome in color, being white, grey, or " &
			"in rare cases black. The underside is paler than the dorsal side. Due to both the coloration and the spines " &
			"on the arms, they are well camoflauged in the rocky corals they call home.",
		"Arguably one of the more bizzare-looking species of starfish, the reef starfish " &
			"possesses eleven arms that radiate outwards from a central disc. They are usually pink " &
			"or purple in coloration on the dorsal side. Ones that are orange, however, have also been " &
			"observed. Regardless of their coloration, all of them are adorned with dark red splotches. " &
			"The ventral side of the animal is a pale yellow.",
		"Common sea urchins are sphearoid in shape, slightly flatter at the poles than " &
			"in the center. Their shells are hard and covered short knobby protrusions - called " &
			"tubercules - and longer spines. The animal is reddish-purple in color, with the " &
			"tips of the spines and tubercles being white. Without close examination it is " &
			"difficult to see the bumpiness of the shell, instead having the appearance of " &
			"a spiky ball."
	}

	'***********************************************************************************************************************************************'


	Public animalSize() As String = {
		"Length: 30 cm (12 in)",                                                'Vampire Squid
		"Estimated Length: 12-24 m (39-46 ft)" & ControlChars.CrLf &
			"Estimated Weight: 750 kg (1,650 lbs)" & ControlChars.CrLf &
			"Confirmed Lenght: 4.5 m (15 ft)" & ControlChars.CrLf &
			"Confirmed Weight: 495 kg (10,91 lbs)" & ControlChars.CrLf &
			" " & ControlChars.CrLf &
			"Confirmed measurements are from a juvenile squid" & ControlChars.CrLf &
			"Estimated measurements have been provided for an adult",           'Colossal Squid 
		"Mantle Length: 2.25 m (7.4 ft)" & ControlChars.CrLf &
			"Tentacular Length: 12 m (43 ft)" & ControlChars.CrLf &
			"Weight: 907.2 kg (1 ton)",                                     'Giant Squid
		"Length: 7.6 cm (3 in)" & ControlChars.CrLf &
			"Weight: 9 grams (.31 oz)",                                         'Firefly Squid
		"Length: 29-50 cm (11.4-19.7 in)" & ControlChars.CrLf &
			"Weight: 5.3 kg (11.7 lbs)",                                        'Neon Flying Squid
		"Average Length: 1.5 m (4.9 ft)" & ControlChars.CrLf &
			"Max Length: 2.5 m (8.2 ft)" & ControlChars.CrLf &
			"Weight: 50 kg (110 lbs)",                                          'Humboldt Squid
		"Mantle Length: 12-19 cm (4.7-7.5 in)" & ControlChars.CrLf &
			"Tentacular Length: 28 cm (11 in)",                                 'Market Squid
		"Length: 1 m (3.3 ft)",                                                 'Grimaldi Squid
		"Female Mantle Length: 33 cm (12.9 in)" & ControlChars.CrLf &
			"Male Mantle Length: .5-3.3 cm (1.9-12.9 in)" & ControlChars.CrLf &
			"Total Length: 119 cm (46.9 in)",                                   'Umbrella Squid
		"Length: 12-30 cm (5-8 in)",                                            'Blue-Ringed Octopus
		"Average Length: 4.3 m (14 ft)" & ControlChars.CrLf &
			"Average Weight: 15 kg (33 lbs)" & ControlChars.CrLf &
			"Maximum Length: 6 m (20 ft)" & ControlChars.CrLf &
			"Maximum Weight: 71 kg (156 lbs)",                                  'North Pacific Giant Octopus
		"Female Length: 2 m (6.6 ft)" & ControlChars.CrLf &
			"Male Length: 2.4 cm (1 in)" & ControlChars.CrLf &
			"Female to Male Weight Ratio: 10,000:1, possibly up to 40,000:1",   'Common Blanket Octopus
		"Average Length: 20-30 cm (7.8-12 in)" & ControlChars.CrLf &
			"Maximum Length: 1.8 m (5.9 ft)" & ControlChars.CrLf &
			"Maximum Weight: 5.9 kg (13 lbs)",                                  'Dumbo Octopus
		"Mantle Length: 5-10 cm (2-4 in)" & ControlChars.CrLf &
			"Tentacular Length: 35 cm (14 in)",                                 'Bioluminescent Octopus
		"Length: 60 cm (2 ft)" & ControlChars.CrLf &
			"Weight: .5 kg (1.1 lbs)",                                          'Mimic Octopus
		"Male Length: 2 cm (.8 in)" & ControlChars.CrLf &
			"Female Length: 10 cm (3.9 in)" & ControlChars.CrLf &
			"Female to Male Weight Ratio: 600:1",                               'Greater Argonaut
		"Length: 5-7 cm (2-3 in)",                                                      'Striped Pyjama Squid
		"Length: 6-8 cm (2.4-3.1 in)",                                          'Flamboyant Cuttlefish
		"Length: 50 cm (20 in)" & ControlChars.CrLf &
			"Weight: 10.5 kg (23 lbs)",                                         'Giant Cuttlefish
		"Length: 49 cm (19.3 in)" & ControlChars.CrLf &
			"Weight: 4 kg (8.8 in)",                                            'Common Cuttlefish
		"Length: 20-25.4 cm (8-10 in)",                                         'Chambered Nautilus
		"Average Length: 18 cm (7.1 in)" & ControlChars.CrLf &
			"Largest on Record: 21.5 cm (8.5 in)",                              'Fuzzy Nautilus
		"Length: 18-23.9 cm (7.1-9.5 in)",                                      'Palau Nautilus
		"Average Length: 18 cm (7.1 in)" & ControlChars.CrLf &
			"Largest on Record: 20.1 cm (7.9 in)",                              'White-Patched Nautilus
		"Male Length: 2.4 m (7.9 ft)" & ControlChars.CrLf &
			"Male Weight: 350 kg (770 lbs)" & ControlChars.CrLf &
			"Female Length: 1.8 m (5.9 ft)" & ControlChars.CrLf &
			"Female Weight: 100 kg (220 lbs)",                                  'California Sea Lion
		"Male Length: 2.82-3.25 m (9.3-10.7 ft)" & ControlChars.CrLf &
			"Male Weight: 450-1,120 kg (990-2,470 lbs)" & ControlChars.CrLf &
			"Female Length: 2.3-2.9 m (7.5-9.5 ft)" & ControlChars.CrLf &
			"Female Weight: 240-350 kg (530-770 lbs)",                          'Stellar Sea Lion
		"Average Length: 2.7-3.5 m (8.9-11.5 ft)" & ControlChars.CrLf &
			"Average Weight: 200-600 kg (440-1,320 lbs)" & ControlChars.CrLf &
			"Largest Recorded Length: 4.6 m (15 ft)" & ControlChars.CrLf &
			"Largest Recorded Weight: 1,655 kg (2649 lbs)",                     'West Indian Manatee
		"Length: 2.2-3.6 m (7.2-11.5 ft)" & ControlChars.CrLf &
			"Weight: 400-1,800 kg (881.9-3,968.3 lbs)",                         'Walrus
		"Average Length: 2.4 m (7.9 ft)" & ControlChars.CrLf &
			"Average Weight: 310 kg (685 lbs)",                                 'Monk Seal
		"Length: 2.4-3.5 m (7.9-11.5 ft)" & ControlChars.CrLf &
			"Weight: 200-600 kg (440-1,320 lbs)",                               'Leopard Seal
		"Length: 1.7-2 m (5.5-6 ft)" & ControlChars.CrLf &
			"Weight: 140-155 kg (308.6-341.2 lbs)",                             'Harp Seal
		"Length: 7.0-9.8 m (23-32 ft)" & ControlChars.CrLf &
			"Weight: 5433.1 kg (6 tons)",
		"Length: 1.9-2.5 m (6.2-8.2 ft)" & ControlChars.CrLf &          'common dolphin
			"Weight: 80-235 kg (176-518 lbs)",
		"Length: 2-4 m (6.6-13.1 ft)" & ControlChars.CrLf &             'bottlenose dolphin
			"Weight: 150-650 kg (330-1430 lbs)",
		"Length: up to 4 m (13.12 ft)" & ControlChars.CrLf &            'risso's dolphin
			"Weight: up to 500 kg (1102.31 lbs)",
		"Length: up to 2.2 m (7.2 ft)" & ControlChars.CrLf &            'spectacled porpoise
			"weight: 60-84 kg (130-185 lbs)",
		"Length: 1.7-2.4  m (5.5 - 8 ft)" & ControlChars.CrLf &         'pacific white-sided dolphin
			"Weight: 136.1 - 181.4 kg (300 - 400lbs)",
		"Length: 13.1-14.9 m (43-39 ft)" & ControlChars.CrLf &          'gray whale
			"Weight: 36,287.4 kg (40 tons)",
		"Length: 5.5 m (18 ft)" & ControlChars.CrLf &                   'beluga whale
			"Weight: 1600 kg (3500 lbs)",                               'blue whale
			"Length: up to 30 m (98.4 ft)" & ControlChars.CrLf &
			"Weight: up to 118 metric tons (130 tons)",
		"Length: 9.9-8 m (23-26 ft)" & ControlChars.CrLf &
			"Weight: 3,628.8-4,356 kg (8,000-10,000 lbs or 4-5 tons)",      'minke whale
		"Length (excluding tusk): 9.95-5.5 m (13-18 ft)" & ControlChars.CrLf &
			"Length (with tusk): 8.6 m (28.2 ft)" & ControlChars.CrLf &
			"Weight: 800-1,600 kg (1,760-3,530 lbs)",                       'narwhal
		"Length: 2 m (6.6 ft)",                                             'frilled shark
		"Confirmed length: 6.4 m (21 ft)" & ControlChars.CrLf &             'greenland shark
			"Confirmed Weight: 1000 kgs (2220 lbs)" & ControlChars.CrLf &
			"Estimated Length: up to 7.3 m (24 ft)" & ControlChars.CrLf &
			"Estimated Weight: 1408 kgs (3100 lbs)",
		"Length: 3.3 m (10.8 ft)" & ControlChars.CrLf &
			"weight: 88.4 kg (1,914.9 lbs)",
		"Length: 3.1-4.5 m (10.1-15 ft)" & ControlChars.CrLf &
			"Weight: 330 kg (730 lbs)",                                     'nurse shark
		"Length: 3.5-6.1 m (11-20 ft)," & ControlChars.CrLf &
			"Weight: 230-580 kg (510-1,280 lbs)",                           'greater hammerhead shark
		"Average length: 3.4-4.9 m (11-16 ft)" & ControlChars.CrLf &        'great white shark
			"Average Aeight: 1814.4 kg (4,000 lbs)" & ControlChars.CrLf &
			"Maximum Length: 6.1 m (20 ft)" & ControlChars.CrLf &
			"Maximum Weight: 2,268 kg (5,000 lbs)",
		"Length: 3.25-4.25 m (10.7-13.9 ft)" & ControlChars.CrLf &          'tiger shark
			"Weight: 385-635 kg (849-1,400 lbs)",
		"Length: 4.5-7 m (15-23 ft)" & ControlChars.CrLf &
			"Weight: 3,000 kg (6,600 lbs)",
		"Length: 2.1 m (6.9 ft)" & ControlChars.CrLf &                  'smooth stingray
			"Width: 4.3 m (14 ft) " & ControlChars.CrLf &
			"Weight: 350 kg (770 lbs)",
		"Length: 1.5 m (4.9 ft)" & ControlChars.CrLf &                  'japanese eagle ray
			"Width: 1.14 m (3.7 ft)",
		"Length: 5 m (16 ft)" & ControlChars.CrLf &                     'spotted ray
			"Width: 3 m (10 ft)" & ControlChars.CrLf &
			"Weight: 230 kg (507 lbs)",
		"Length: .78 - 1.5 m (3-5 ft)" & ControlChars.CrLf &            'green sea turtle	
			"Weight: 68 - 315 kg (150 - lbs)",
		"Length: 1.83-2.13 m (3.3-7 ft) " & ControlChars.CrLf &         'leatherback sea turtle
			"Weight: 250-907.2 kg (249.5-2,000 lbs)",
		"Length: 25-39 cm ( 9.8-15.4 in)",                             'blue tang
		"Length: 20 cm (7.9 in)",                                      'yellow tang
		"Length: 12 - 38 cm (4.7 to 15 in) " & ControlChars.CrLf &     'regal tang
			"Weight: 600 g (21.15 oz)",
		"Length: up to 41 cm (16.14 in)",                               'french angelfish
		"Max Length: 25 cm (9.8 in)",                                   'royal angelfish
		"Max Length: 38 cm (15 in)",                                    'blueface angelfish
		"Length: 10cm (4 in)",                                          'flame angelfish
		"Length: 45 cm (17 in)" & ControlChars.CrLf &                   'queen angelfish
			"Weight: 1.6 kg (3.5 lbs)",
		"Length: 30 cm (12 in)",                                        'lined butterflyfish
		"Length: 16 cm (6.3 in)",                                       'banded butterflyfish	
		"Length: 9 cm (3.5 in)",                                        'elegant firefish
		"Length: 6 cm (4.3 in)",                                        'mandarinfish
		"Length: 3 m (9.8 ft)" & ControlChars.CrLf &                    'indo-pacific sailfish
			"Weight: 90 kg (200 lbs)",
		"Length: 1.7 m (5.6 ft)" & ControlChars.CrLf &                  'antarctic toothfish
			"weight: 135 kg (297.6 lbs)",
		"Length: 65 cm (2.1 ft)" & ControlChars.CrLf &                  'john dory
			"Weight: 5 kg (12 lbs)",
		"Length: 2 m (6.5 ft)" & ControlChars.CrLf &                    'coelacanth
			"Weight: 80 kg (176 lbs)",
		"Length: 11 cm (4.3 in)",                                       'common clownfish
		"Length: 47 cm (18.5 in)",                                      'red lionfish
		"Length: 2 m (6.5 ft)" & ControlChars.CrLf &                    'mahi mahi
			"Weight: 40 kg (88 lbs)",
		"Length: 2 m (6.6 ft)" & ControlChars.CrLf &                    'humphead wrasse
			"Weight: 180 kg (396.8 lbs)",
		"Length: 1 m  (3.3 ft)" & ControlChars.CrLf &                   'sheepshead wrasse
			"Weight: 14.7 kg (32 lbs)",
		"Length: 1.8 - 3.2 m (5.9 - 10.5 ft" & ControlChars.CrLf &      'ocean sunfish
			"Weight: 247-1000 kg (545-2205 lbs)",
		"Length: 5.8 cm (2.3 in)",                                      'striped goby
		"Length: 9 cm (3 in)",                                          'fire goby
		"Length: 2 - 2.5 m (6.6 - 8.2 ft)" & ControlChars.CrLf &        'atlantic bluefin tuna
			"Weight: 225 - 250 kg (496 - 551 lbs)",
		"Length: 2.4 m (7.9 ft)" & ControlChars.CrLf &                  'yellowfin tuna
			"Weight: 180 - 400 kg (400 - 440 lbs)",
		"Length: 15 cm (5.9 in)",                                       'short-snouted sea horse
		"Length: 30 cm (12 in)",                                        'leafy sea dragon
		"Length: 3-5 cm (1.2-2 in)",                                    'pistol shrimp
		"Length: 5.1-17.8 cm (2-7 in)",                                 'peacock mantis shrimp
		"Lenght: up to 3 m (9.8 ft)" & ControlChars.CrLf &              'giant moray eels
			"Weight: 30 kg (66 lbs)",
		"Length: 1 m (3.3 ft)",                                         'ribbon moray
		"Length: 80 cm (31.5 in)",                                      'pelican eel
		"Shell Length: 17-28 cm (7-11 in)" & ControlChars.CrLf &        'red king crab
			"Leg Span: up to 1.8 m (5.9 ft)" & ControlChars.CrLf &
			"Weight: 2.9-12.7 kg (6.4-28 lbs)",
		"Length: .5-15 cm (1-6 in)",                                   'yeti crab
		"Length: 20.3-80 cm (8-31.5 in)" & ControlChars.CrLf &         'american lobster
			"Weight: 18-20 kg (39.6-44.1 lbs)",
		"Average Length: 9.1 m (30 ft)",                                'portuguese man 'o war
		"Length: 15 cm (6 in)",                                         'flower hat jelly
		"Length: up to 25 cm (10 in)",                                  'crystal jellyfish
		"Bell Diameter: up to 1 m (3.3 ft)" & ControlChars.CrLf &       'black sea nettle
			"Tentacle Length: 5-6 m (16.4-19.7 ft)",
		"Length: 4.5 mm (.18 in)",                                      'immortal jellyfish
		"Length: 16.1 - 50 cm (6.4 - 19.7 in)",                         'japanese common starfish
		"Length: 5-10 cm (2-4 in)",                                     'common brittle star
		"Length: 8-10 cm (3.15-3.94 in)",                               'reef starfish
		"Length: 9-16 cm (3.5-6.3 in)"                                  'common sea urchin
	}

	'***********************************************************************************************************************************************'

	Public diet() As String = {
		"Detritus known as marine snow, which is composed of fragments of " &
				"organic matter.",                                                                      'Vampire Squid			
		"Deep sea fish and other squid species",                                                        'Giant Squid
		"Unknown, but they are believed to prey on marine worms, " &
			"smaller squids, and large fish such as the Patagonian toothfish",                          'Colossal Squid
		"Shrimp, smaller fish and crabs, and planktonic crustaceans",                                   'Firefly Squid
		"Small oceanic fishes, other squid species and, at times, smaller neon flying squids",          'Neon Flying Squid
		"Other Humboldt squids, smaller squid species, and small fish",                                 'Humboldt Squid 
		"Small fish, crabs, shrimps,  mollusks, other juvenile market squids",                          'Market Squids
		"Unknown, but most likely small fish, smaller species of squids, and crustaceans",              'Grimaldi Squid					
		"Fish, crabs, lobsters, and other molluscs",                                                    'Umbrella Squid
		"Crabs, hermit crabs, shrimp, and other small crustaceans",                                     'Blue Ringed Octopus                                     '
		"Shrimp, crabs, scallops, abalone, cockles, snails, clams, lobsters, fish, " &
			"smaller octopode species, and small sharks",                                               'Giant Pacific Octopus
		"Small fish",                                                                                   'Common Blanket Octopus
		"Tuna, sharks, dolphins",                                                                       'Dumbo Octopus
		"Planktonic crustaceans",                                                                       'Bioluminescent Octopus
		"Unknown, but most likely small crustaceans and fish",                                          'Mimic Octopus	
		"Crustaceans, sea slugs, and open sea mollusks",                                                'Greater Argonaut
		"Small shrimp and fish",                                                                        'Striped Pyjama Squid
		"Small fish and crustaceans",                                                                   'Flamboyant Cuttlefish
		"Crustaceans and fish",                                                                         'Giant Cuttlefish
		"Small shrimp, crabs, clams, snails, fish, and other cuttlefish",                               'Common Cuttlefish
		"Live shellfish and crabs, as well as scavenging for carrion and detritus",                     'Chambered Nautilus
		"Live shellfish and crabs, carrion of fish and shellfish",                                      'Fuzzy Nautilus
		"Small living shellfish and crabs, various plants, carrion that has sunk to the ocean floor",   'Palau Nautilus
		"Small crustaceans, carrion and detritus found on the ocean floor",                             'White-Patched Nautilus
		"Numerous species of squid and fish, sometimes clams",                                          'California Sea Lion
		"Fatty fish suchs has herring and capelin, squids, octopodes, sturgeon",                        'Steller Sea Lion
		"Sea grass",                                                                                    'Manatee	
		"A wide range of marine animals including clams, shrimp, crabs, coral, " &
			"various mollusks like squids and octopodes, and sea cucumbers",                            'Walrus
		"fish, eels, squids, octopodes",                                                                'Monk Seal
		"Krill, squid, fish, penguins, other small seals",                                              'Leopard Seal
		"Several dozen types of fish and invertebrates such as krill, capelin " &
			"herring, flatfish, polar cod, and gadiform fish",                                          'Harp Seal
		"Seals, fish, dolphins, other orcas, baleen whale calves, squid, " &
			"sea birds, and sea turtles",                                                               'Orca
		"fish, squid",                                                                                  'Common Dolphin
		"eels, shrimp, squid, and a wide variety of fish",                                              'Bottlenose Dolphin
		"Large squids including the Humboldt squid, cuttlefish, prawn, and shrimp",                     'Risso's Dolphin
		"Squids and fish primarily, though they also eat octopodes, shrimp, molluscs, " &
			"and other crustaceans",                                                                    'Spectacled Porpoise
		"Squid, small fish",                                                                            'Pacific Wihte-Sided Dolphin 
		"Small crustaceans, krill, and plankton",                                                       'Gray Whale	
		"Fish such as cod, herring, and salmon, as well as squid, shrimp, and crabs",                   'Beluga Whale
		"Krill",
		"Krill, capelin, cod, herring, pollock",                                                        '
		"Fish such as arctic and polar cod, Greenland halibut, and flatfish, shrimp, armhook squid",
		"Cephalopods, bony fish, and smaller sharks",
		"Primarily smaller sharks, fish, seals, and polar bears. " &
			"Occasionally, they will also eat horse, moose, and reindeer",
		"Small midwater fishes, primarily barracudinas, lightfishes, escolars, and sardines",
		"Small fish and stingrays, crustaceans, molluscs, and tunicates",
		"Crustaceans, cephalopods, bony fish, and smaller sharks, stingrays",
		"Fish, large seals, dolphins, small whales, seabirds",
		"Various fish, crustaceans, squid, sea turtles, dolphins, and seabirds. They also occasionally " &
			"eat sea snakes, seals, and smaller sharks",
		"Zooplankton and krill",
		"Bony fish, molluscs, and crustaceans",
		"Crustaceans, fish, mollusks, and occasionally plants",
		"Crabs, whelks, hermit crabs, shrimp, octopodes, and some small fish",
		"Various species of seagrass, algae",
		"Jellyfish, salps, marine plant matter",
		"Algea, phytoplankton, zooplankton",
		"Algae and marine plant life",
		"Algea",
		"Algea, soft coral, tunicates",
		"Sponges and tunicates",
		"Encrusting species such as tunicates, sponges, and algae",
		"Algea as juveniles, crustaceans and shrimp as adults",
		"Sponges, tunicates, jellyfish, plankton, coral, algae, parasites",
		"Corals, anemones, algea, and small invertebrates",
		"Small invertebrates and crustaceans, coral polyps, bristle worms, and various " &
				"types of fish eggs",
		"Zooplankton",
		"Small worms, gastropods, fish eggs, and other small crustaceans and invertebrates",
		"Pelagic forage fish, squid",
		"Shrimp, smaller fish",
		"Small schooling fish, such as sardines, squids, and cuttlefish",
		"Cuttlefish, squid, octopodes, and small fishes",
		"Algae, zooplankton, marine worms, and small crustaceans",
		"Smaller crustaceans and fish",
		"Flying fish, crabs, squid, mackerel, billfish, zooplankton",
		"Mollusks, crustaceans, and fish",
		"Small fish and molluscs",
		"Small fish, fish larvae, squid, crustaceans, sea jellies, salps",
		"Small crustaceans, plankton, and algae",
		"Small shrimp and zooplankton",
		"Schooling fish such as herring and mackerel, eels",
		"Schooling fish, squid, crustaceans",
		"Small shrimp",
		"Plankton, mysids, and small crustaceans",
		"Small fish, crabs, other shrimp, and marine worms",
		"Snails, crabs, shrimp, other crustaceans, small fish",
		"Fish and crustaceans, lionfish",
		"Small fish",
		"Shrimp and other small crustaceans, squid, small invertebrates",
		"Invertebrates, dead/decaying plant or animal matter",
		"Bacteria, mussels",
		"Mussels, mollusks, other crustaceans, brittle stars, some algae, " &
			"herring (used as bait in traps)",
		"Small fish, shrimp, and other crustaceans",
		"Small species of fish",
		"Plankton, comb jellies,",
		"Small fish and shrimp, moon jellyfish, comb jelyfish, zooplankton",
		"Plankton",
		"Primarily bivalve molluscs such as mussels, oysters, and scallops, but also on crabs, " &
			"barnacles, sea squirts, and dead fish",
		"Red algea as juveniles, mussels as adults",
		"Phytoplankton, dead marine detritus",
		"Seaweed, barnacles, marine worms, algae, and detritus"
	}

	'***********************************************************************************************************************************************'

	Public predators() As String = {
		"Unknown",              'Vampire Squid
		"Sperm whales, pilot whales, and deep sea sharks. Juveniles may " &
			"also be eaten by large fish",
		"Sperm whales",
		"Sperm whales, sharks, larger fish, larger squids, and crabs",
		"Large fish such as swordfish, marlins, and tunas, as well as" &
			"sharks and marine mamamls",
		"Billfishes and sperm whales",
		"Large fish, common seal, California sea lion, blue shark, Chinook salmon, " &
			"black-throated diver, Brandts cormorant",
		"Sperm whales",
		"Northern bottlenose whale, sperm whale, blue shark, swordfish, and Curvier's beaked whale",
		"Sea birds and eels",
		"Pacific sleeper sharks, sea otters, sperm whales, and harbor seals",
		"Mediterranean spearfish, swordfish, other large fish",
		"Tuna, sharks, dolphins",
		"Unobserved, but most likely large fish and sharks",        'Bioluminescent Octopus
		"Damselfish",
		"Lancent fish, jellyfish (parasitic relationship)",
		"Sea birds, large fish",
		"Dolphins, sharks, fish, seals, seabirds, other cuttlefish",
		"Indo-Pacific bottlenose dolphins and New Zealand fur seals",
		"Sharks, dolphins, seals, fish, other cuttlefish and cephalopods",
		"Large fish, octopodes",
		"Octopodes, large fish",
		"Large fish, octopodes",
		"Octopodes, large fish",
		"Orcas, great white sharks",
		"Orcas, sharks",
		"No natural predators, but vulnerable to human actions",    'Manatee
		"Orcas and polar bears",
		"None, but they are extremely threatened by humans",        'Mediterranean Monk Seal
		"Orcas, large sharks",
		"Polar bears, orcas, and sharks. Walruses will also eat harp seal pups",
		"None - apex predator",             'Orca
		"Orcas, large species of sharks",
		"Orcas, tiger sharks, dusky sharks, bullsharks",
		"Unknown",      'Risso's Dolphin
		"Unknown",      'Spectacled Porpoise
		"Orcas",
		"Large species of sharks, orcas, humans via whaling",
		"Humans via whaling, polar bears, killer whales",
		"Humans via whaling, orcas",
		"Orcas, large sharks",
		"Orcas, polar bears, greenland sharks, walruses, humans",
		"Unknown, but most likely larger sharks",       'Frilled Shark
		"Unknown",      'Greenland Shark
		"Toothed whales, tapeworms (parasites), copepods (parasites)",
		"American alligators",
		"Humans, larger sharks (juveniles), orcas",
		"Orcas (rarely)",
		"Humans, orcas, large sharks (juveniles)",
		"Large sharks and orcas, humans via fisheries",
		"Copper shark, smooth hammerhead, great white shark, and orcas",
		"Unknown, but probably large sharks",   'Japanese Eagle Ray			
		"Tiger sharks, lemon sharks, bull sharks, silver tip sharks, and the greater hammerhead shark",
		"Tiger sharks and other large sharks, humans, " & ControlChars.CrLf &
			"crabs, small marine mammals, shorebirds",
		"Orcas, great white sharks, tiger sharks, " & ControlChars.CrLf &
			"cephalopods, requiem sharks, large fish",
		"Reef sharks, fish such as tunas, snappers, jacks, groupers, and barracudas",
		"Reef sharks, large fish",              'Angelfish
		"Larger species of fish, sharks",
		"Larger species of fish, reef sharks",
		"Seabirds, sharks, larger fish",
		"Larger species of fish, reef sharks",
		"Larger species of fish, reef sharks",
		"Larger species of fish, reef sharks",
		"Sharks, eels, and snapper fish",       'Butterflyfish
		"Large fish, including sturgeon fishes and parrot fishes",
		"Large fish",                   'Elegant Firefish
		"Large reef-dwelling fish",     'Mandarinfish
		"Mahi mahi",                    'Indo-Pacific Sailfish
		"Colossal squid, seals, sperm whales, orcas",   'Antarctic toothfish
		"Dusky sharks, large bony fish",    'John Dory
		"Unknown, but probably larger fish",    'Coelacanth
		"Larger fish",                  'Common Clownfish
		"Moray eels, bobbit worms",     'Red lionfish
		"Large sharks, humans via commercial fishing", 'Mahi Mahi
		"Large sharks",                 'Humphead Wrasse
		"Large sharks",                 'Sheepshead Wrasse
		"Sea lions, killer wails, sharks",  'Ocean Sunfish
		"Larger fish",                  'Stribed Goby
		"Larger fish, reef sharks",     'Fire Goby
		"Humans via commercial fisheries, orcas, several species of sharks and large fish",
		"Other tuna species, sharks, billfish, toothed whales, " &
			"marlins, humans (via commercial fisheries)",
		"Rays, crabs, and large fish",
		"Large fish, crustaceans, sea anemones (juvelines only)",
		"Large fish",
		"Large fish",
		"Large reef sharks",
		"Moray eels, barracudas, large groupers",
		"Lancetfish, large deep-water sharks",
		"Marine mamals, octopodes, large fish, humans via commercial fishing",
		"Unknown, but most likely large deep sea fish",     'Yeti Crab
		"Large fish, octopodes, humans via commercial fishing",
		"Loggerhead sea turtles, ocean sunfish, blue dragon sea slugs",
		"Various species of sea turtles",
		"Other crystal jelllies, ",
		"Unknown",          'Black Sea Nettle
		"A wide variety of fish species",
		"Other species of starfish such as the sunstar and spiny sand seastar, king crabs",
		"Sea snails, large fish such as cod or bass, crabs, starfish",
		"Large fish, reef sharks",
		"Crabs, large fish"
	}

	'***********************************************************************************************************************************************'

	Public habitat() As String = {
		"Temperate and tropical oceans in extreme deep sea conditions," &
			" 600-900 m (2,000 - 3,000 ft) below the surface of the water " &
			"in the mesopelagic zone.",
		"Deep oceans worldwide, particularly in oceanic trenches",
		"The deep Antarctic Ocean at a range of depths up to 2.2 km (7,200 ft) below " &
			"the surface.",
		"The western Pacific Ocean at depths of about 600-1200 m (1968.5-3937 ft)",
		"Subtropical and temperate oceanic waters around the world",
		"The waters of the Humboldt Current and the western coasts of North and South America",
		"Costal waters along the western coast of North America",
		"Tropical and subtropical waters of the Atlantic, Pacific, and southern Indian Oceans",
		"The Atlantic Ocean, mainly off of the coast of Argentina and South Africa." & ControlChars.CrLf &
			"Umbrella squids can also be found in the Tasmania Sea.",
		"Tidal pools and shallow rocky reefs throughout the Indian and western " &
			"Pacific oceans.",                                                                                  'End Squids
		"The costal areas and intertidal zone of the northern Pacific ocean, " &
			"at depths of up to 2000 m (6600 ft)",
		"Tropical and subtropical oceans worldwide in the upper areas of the water column",
		"Tropical and temperate deep oceans worldwide",
		"The Northern Atlantic Ocean at depths between 500 and 4,000 m (1,600 to 13,000 ft)",
		"Western and central Indo-Pacific costal waters, particularly by muddy river mouths, Lizard Island",
		"Tropical and subtropical waters worldwide",                                                            'End Octopodes
		"The Indo-Pacific Ocean around the coast of Australia",
		"Tropical Indo-Pacific waters surrounding Australia, " &
			"New Guinea, the Philippines, Indonesia, and Malaysia.",
		"The southern coast of Australia",
		"The Mediterranean, North, and Baltic Seas",
		"Costal seabeds and coral reefs in the southern Pacific Ocean, primarily around " &
			"Australia, Japan, and Micronesia",
		"The waters around the Solomon Islands, as well as the island of New Guinea at " &
			"depths between 91.4 to 304.8 meters (300 - 1000 feet) below the surface",
		"Reefs in the waters around Palau in the Western Carolines Islands at depths " &
			"between 150 - 300 m (492.1 - 984.3 ft)",
		"The waters of the Great Barrier Reef in Australia",                                                    'End Misc Cephalopods
		"The western coasts of North America, particularly along the coast of California",
		"The northern reaches of the Pacific Ocean",
		"The Carribean Sea along the coasts of Florida, the Greater Antilles, " &
			"Mexico, Central America, and the north-norhteastern South American coast.",
		"Arctic waters, including the Bering Strait and Sea, costal Alaskan and Siberian waters, " &
			"the Northeastern Canadian coast, waters around Greenland, and the western part of the Russian Arctic",
		"Mediterranean sea with pocket populations in the Atlantic ocean.",
		"The Southern, or Antarctic, ocean. Its potential range, " &
			"however, extends up to the lower coasts of New Zealand, Australia, " &
			"South America, and South Africa",
		"The Arctic sea and northern Atlantic oceans, particularly " &
			"near Greenland, Scandinavia, and a small part of Newfoundland",                                    'End Mammals
		"All oceans and seas worldwide, minus the Baltic Sea, " &
			"the Black Sea, and a few select areas of the Arctic Ocean",
		"Warm temperate and tropical waters worldwide, ranging from 40-60 " &
			"degrees North and up to 50 degrees south. Short-beaked dolphins " &
			"tend to favor open seas more than the long beaked ones",
		"Warm temperate oceans and tropical seas worldwide aside from the " &
			"Arctic and Antarctic regions",
		"The edges of continental shelves and the open ocean in temperate and tropical " &
			"waters across the globe.",
		"Believed to live around the glob in sub-Antaractic and low Antarctic waters",
		"Open ocean and nearshore waters in the northern Pacific Ocean",
		"Costal waters of the Pacific ocean, primarily in the northern hemisphere",
		"Arctic and sub-Arctic waters along the northern coasts of Canada, Greenland, " &
			"and Russia",
		"All waters worldwide aside from slight areas around the Arctic. ",
		"Northern Minke Whale: Arctic Ocean, Nothern Pacific, Northern Atlantic" & ControlChars.CrLf &
			"Southern Minke Whale: Antarctic waters",
		"Arctic waters around Greenland, Canada, and Russia",                                                   'End Cetaceans
		"Small patches in the Atlantic and Pacific Ocean, primarily in waters " &
			"around the continental shelves",
		"Deep Arctic waters, primarily around Greenland",
		"Subtropical open waters of the Indian and Pacific Oceans",
		"The northeastern coast of Africa, and costal waters of Latin America and the Carribean. " &
			"They primarily live in and around coral reefs",
		"Tropical and temperate waters along the coast and continental shelves",
		"Costal waters in oceans worldwide",
		"Costal subtropical and tropical waters throughout the oceans around the equator.",
		"The tropical and temperate waters around the equator",
		"The coasts of South Africa, southern Australia, and New Zealand",
		"The waters of East Asia, especially around Japan, Korea, and China",
		"Tropical costal waters around the Equator",                                                            'End Sharks
		"The tropical and subtropical waters of the Atlantic and Pacific Oceans, " &
			"with a sub-population in the Indian Ocean",
		"Oceans worldwide, primarily in the tropical and subtropical waters of the " &
			"Atlantic and Pacific Oceans",                                                                      'End Sea Turtles				
		 "Tropical waters in the Caribbean Sea and the Gulf of Mexicon but " &
			"they can also be found as far north as New York and as far south as Brazil",
		"Coral reefs in the Pacific Ocean, particularly around Hawaii and Japan",
		"Coral reefs in the Pacific and Indian Oceans",
		"Coral reefs in the Caribbean Sea and Atlantic Ocean",
		"Tropical regions of the Indo-Pacific ocean",
		"Coral reefs in the eastern tropical waters of the Indo-Pacific Oceans",
		"Coral reefs and lagoons of Oceania and the Hawaiian Islands",
		"Coral Reefs in the western Atlantic Ocean",
		"The Indo-Pacific Ocean ranging from the western coasts of Africa to Japan and Hawaii",'				
		"Coral reefs in the tropical and subtropical waters of the western Atlantic Ocean",                     'End Tang/Angelfish/Butterflyfish
		"Tropical waters in the Indian and Western Pacific oceans, in coral " &
			"reefs and reef drop offs",
		"The warm waters of the Pacific Ocean, particularly on coral reefs",
		"The warm waters of the Pacific Ocean, particularly on coral reefs",
		"Subzero waters below the Antarctic circle",
		"The coastal waters of Africa, New Zealand, Australia, Japan, South East Asia, and Japan",
		"Sparse pockets of populations in the deep waters of the western Indian Ocean" &
			"along the coast of Africa",
		"Coral reefs off the coasts of Australia, Southeast Asia, and Japan",
		"Native Habitat: the Indo-Pacific Ocean" & ControlChars.CrLf &
			"Invaded Habitats: Carribean Sea, the East Coast of the United States, " &
			"the East Mediterranean",
		"Tropical waters worldwide, but most commonly in the Gulf of Mexico, Costa Rica, " &
			"and Hawaii",
		"The Red Sea, Indian Ocean, and Pacific Ocean",
		"The western Pacific Ocean around the Korean Peninsula, China, Japan, and the " &
			"Ogasawara Islands",
		"Temperate and tropical waters worldwide",
		"The coastal waters of the Mediterranean Sea",
		"Warm waters of the Indo-Pacific ocean, mainly on coral reefs",
		"The waters of the Atlantic Ocean and the Mediterranean Sea. In the past they also " &
			"lived in the Black Sea, but have since gone extinct there",
		"The warm waters of the Indo-Pacific Ocean",                                                            'End Fish
		"The Mediterranean Sea and parts of the northern Atlantic Ocean in shallow " &
			"waters and seagrass beds",
		"The sourthern and eastern coastal waters of Australia",
		"The Indo-Pacific oceans in tropical and subtropical waters",
		"Coral reefs in the warm waters of the Indo-Pacific Ocean",                                             'End Seahorse/Seadragon
		"Lagoons and coral reefs in the Indo-Pacific Ocean",
		"Lagoons and reefs in the Indo-Pacific ocean",
		"Deep waters of the Indo-Pacific and Atlantic oceans, primarily in the temperate " &
			"and tropical areas",                                                                               'End Eels
		"The cold polar and subpolar waters of the north Pacific, specifically in " &
			"the Bering Sea, the Barents Sea, and the Gulf of Alaska",
		"Deep waters of the Pacific-Antarctic Ridge around hydrothermal vents",
		"The east coast of northern North America, with heavy populations around " &
			"the state of Maine and the province of Labrador",                                                  'End Crustaceans
		"Temperate and tropical waters in oceans across the world with large populations in the Atlantic",
		"Coastal waters off of central and southern Japan, as well as South Korea's Jeju Island",
		"The waters of the eastern Pacific Ocean along the western coast of North America",
		"The eastern Pacific from Monterey Bay, Canada, to southern Baja California and Mexico",
		"Tempearte and tropical waters worldwide",                                                              'End Jellyfish
		"The coastal waters of the norther Pacific",
		"Coastal waters of the North Sea, West Africa to South Africa, and the Azores Islands",
		"The waters around New Zealand",
		"The waters of the North Sea, particularly along the coastlines"
	}

	'***********************************************************************************************************************************************'

	Public taxonomy() As String = {
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Vampyromorphida" & ControlChars.CrLf &
			"Family: Vampyroteuthidae" & ControlChars.CrLf &
			"Genus: Vampyroteuthis" & ControlChars.CrLf &
			"Species: V. indernalis",           'Vampire Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Architeuthidae" & ControlChars.CrLf &
			"Genus: Architeuthis" & ControlChars.CrLf &
			"Species: A. dux",                  'Giant Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Cranchiidae" & ControlChars.CrLf &
			"Subfamily: Taoniinae" & ControlChars.CrLf &
			"Genus: Mesonychoteuthis" & ControlChars.CrLf &
			"Species: M. hamiltoni",            'Colossal Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Enoploteuthidae" & ControlChars.CrLf &
			"Genus: Watasenia" & ControlChars.CrLf &
			"Species: W. scintillans",          'Firefly Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Ommastrephidae" & ControlChars.CrLf &
			"Subfamily: Ommastrephinae" & ControlChars.CrLf &
 			"Genus: Ommastrephes" & ControlChars.CrLf &
			"Species: O. bartramii",            'Neon Flying Squid
		"Kingdom: Animalia " & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Ommastrephidae" & ControlChars.CrLf &
			"Subfamily: Ommastrephinae" & ControlChars.CrLf &
			"Genus: Dosidicus" & ControlChars.CrLf &
			"Species: D. gigas",                'Humboldt Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Myopsida" & ControlChars.CrLf &
			"Family: Loliginidae" & ControlChars.CrLf &
			"Genus: Foryteuthis" & ControlChars.CrLf &
			"Subgenus: Amerigo" & ControlChars.CrLf &
			"Species: D. opalescens",           'Market Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Lepidoteuthidae" & ControlChars.CrLf &
			"Genus: Lepidoteuthis" & ControlChars.CrLf &
			"Species: L. grimaldii",            'Grimaldi Scaled Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Oegopsida" & ControlChars.CrLf &
			"Family: Histioteuthidae" & ControlChars.CrLf &
			"Genus: Histioteuthis" & ControlChars.CrLf &
			"Species: H. bonnellii",            'Umbrella Squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Octopodidae" & ControlChars.CrLf &
			"Genus: Hapalochlaena" & ControlChars.CrLf &    'Blue Ringed Octopus
			"Species: H. lunulata, H. maculosa, H. fasciata, H nierstraszi",
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Enteroctopodidae" & ControlChars.CrLf &
			"Genus: Entroctopus" & ControlChars.CrLf &
			"Species: E. dofleini",             'North Pacific Giant Octopus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Tremoctopodidae" & ControlChars.CrLf &
			"Genus: Tremoctopus" & ControlChars.CrLf &
			"Species: T. violaceus",            'Common Blanket Octopus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Opisthoteuthidae" & ControlChars.CrLf &
			"Genus: Grimpoteuthis" & ControlChars.CrLf &
			"Species: G. umbellata",            'Dumbo Octopus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Molussca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Stauroteuthidae" & ControlChars.CrLf &
			"Genus: Stauroteuthis" & ControlChars.CrLf &
			"Species: S. syrtensis",            'Bioluminescent Octopus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Octopodidae" & ControlChars.CrLf &
			"Genus: Thaumoctopus" & ControlChars.CrLf &
			"Species: T. Thaumoctopus mimicus", 'Mimic Octopus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Octopoda" & ControlChars.CrLf &
			"Family: Argonautidae" & ControlChars.CrLf &
			"Genus: Argonauta" & ControlChars.CrLf &
			"Species: A. argo",                 'Argonaut
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Sepiida" & ControlChars.CrLf &
			"Family: Sepiadariidae" & ControlChars.CrLf &
			"Genus: Sepioloidea" & ControlChars.CrLf &
			"Species: S. lineolata",            'Striped pyjama squid
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Sepiida" & ControlChars.CrLf &
			"Family: Sepiidae" & ControlChars.CrLf &
			"Genus: Metasepia",                 'Flamboyant Cuttlefish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Sepiida" & ControlChars.CrLf &
			"Family: Sepiidae" & ControlChars.CrLf &
			"Genus: Sepia" & ControlChars.CrLf &
			"Species: S. apama",                'Giant Cuttlefish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Order: Sepiida" & ControlChars.CrLf &
			"Family: Sepiidae" & ControlChars.CrLf &
			"Genus: Sepia" & ControlChars.CrLf &
			"Subgenus: Sepia" & ControlChars.CrLf &
			"Species: S. officinalis",          'Common Cuttlefish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Subclass: Nautiloidea" & ControlChars.CrLf &
			"Order: Nautilida" & ControlChars.CrLf &
			"Family: Nautilidae" & ControlChars.CrLf &
			"Genus: Nautilus" & ControlChars.CrLf &
			"Species: N. pompilius" & ControlChars.CrLf &
			"Subspecies: N. p. pompilius, N. p. suluensis", 'Chambered Nautilus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Subclass: Nautiloidea" & ControlChars.CrLf &
			"Order: Nautilida" & ControlChars.CrLf &
			"Family: Nautilidea" & ControlChars.CrLf &
			"Genus: Allonautilus" & ControlChars.CrLf &
			"Species: A. scrobiculatus",       'Fuzzy Nautilus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Subclass: Nautiloidea" & ControlChars.CrLf &
			"Order: Nautilida" & ControlChars.CrLf &
			"Family: Nautilidae" & ControlChars.CrLf &
			"Genus: Nautilus" & ControlChars.CrLf &
			"Species: N. belauensis",           'Palau Nautilus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Mollusca" & ControlChars.CrLf &
			"Class: Cephalopoda" & ControlChars.CrLf &
			"Subclass: Nautiloidea" & ControlChars.CrLf &
			"Order: Nautilida" & ControlChars.CrLf &
			"Family: Nautilidae" & ControlChars.CrLf &
			"Genus: Nautlius" & ControlChars.CrLf &
			"Species: N. stenomphalus",         'White-Patched Nautilus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Carnivora" & ControlChars.CrLf &
			"Clade: Pinnipedia" & ControlChars.CrLf &
			"Family: Otariidae" & ControlChars.CrLf &
			"Genus: Zalophus" & ControlChars.CrLf &
			"Species: Z. californianus",        'California Sea Lion
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Carnivora" & ControlChars.CrLf &
			"Clade: Pinnipedia" & ControlChars.CrLf &
			"Family: Otariidae" & ControlChars.CrLf &
			"Genus: Eumetopias" & ControlChars.CrLf &
			"Species: E. jubatus",              'California Sea Lion
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Sirenia" & ControlChars.CrLf &
			"Family: Trichechidae" & ControlChars.CrLf &
			"Genus: Trichechus" & ControlChars.CrLf &
			"Species: T. manatus" & ControlChars.CrLf &
			"Subspecies: T. m. latirostris, T. m. manatus", 'Manatee
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Carnivora" & ControlChars.CrLf &
			"Clade: Pinnipedia" & ControlChars.CrLf &
			"Genus: Odobenus" & ControlChars.CrLf &
			"Species: O. rosmarus" & ControlChars.CrLf &
			"Subspecies: O. rosmarus rosmarus, " &
				"O. rosmarus divergens, " &
				"O. rosmarus laptevi (debated)",            'Walrus
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Carnivora" & ControlChars.CrLf &
			"Family: Pinnipedia" & ControlChars.CrLf &
			"Genus: Monachus" & ControlChars.CrLf &
			"Species: M. monachus",             'Mediterranean Monk Seal
		"Kingdom: Animalia " & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Carnivora" & ControlChars.CrLf &
			"Family: Phocidae" & ControlChars.CrLf &
			"Subfamily: Monachinae" & ControlChars.CrLf &
			"Tribe: Lobodontini" & ControlChars.CrLf &
			"Genus: Hydrurga" & ControlChars.CrLf &
			"Species: H. leptonyx",             'Leopard Seal
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Carnivora" & ControlChars.CrLf &
			"Class: Pinnipedia" & ControlChars.CrLf &
			"Family: Phocidae" & ControlChars.CrLf &
			"Genus: Pagophilus" & ControlChars.CrLf &
			"Species: P. groenlandcus",         'Harp Seal
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Delphinidae" & ControlChars.CrLf &
			"Genus: Orcinus" & ControlChars.CrLf &
			"Species: O. orca",                 'Orca
		"Kingdom: Animalia " & ControlChars.CrLf &
			"Phylum: Chordata " & ControlChars.CrLf &
			"Class: Mammalia " & ControlChars.CrLf &
			"Order: Artiodactyla " & ControlChars.CrLf &
			"Infraorder: Cetacea " & ControlChars.CrLf &
			"Family: Delphinidae " & ControlChars.CrLf &
			"Genus: Delphinus " & ControlChars.CrLf &
			"Species: D. capensis and D. delphis" & ControlChars.CrLf &
			"Subspecies: D.c. capensis, D.c. tropicalis, D.d. delphis, D.d. ponticus",  'Common Dolphin
		"Kingdom: Animalia " & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Delphinidae" & ControlChars.CrLf &
			"Genus: Tursiops" & ControlChars.CrLf &
			"Species: Tursiops truncatus" & ControlChars.CrLf &
			"Subspecies: T.t. ponticus, T.t gilli, T.t. truncatus",     'Bottlenose Dolphin
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Delphinidae" & ControlChars.CrLf &
			"Genus: Grampus" & ControlChars.CrLf &
			"Species: G. griseus",              'Risso's Dolphin
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Phocoenidae" & ControlChars.CrLf &
			"Genus: Phocoena" & ControlChars.CrLf &
			"Species: P. dioptrica",            'Spectacled Porpoise
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Delphinidae" & ControlChars.CrLf &
			"Genus: Lagenorhynchus" & ControlChars.CrLf &
			"Species: L. obliquidens",          'Pacific White-Sided Dolphin
		"Kindgom: Animalia " & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Eschrichtiidae" & ControlChars.CrLf &
			"Genus: Eschrichtius" & ControlChars.CrLf &
			"Species: E. robustus",             'Gray Whale
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Monodontidae" & ControlChars.CrLf &
			"Genus: Delphinapterus" & ControlChars.CrLf &
			"Species: D. leucas",               'Beluga Whale
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Balenopteridae" & ControlChars.CrLf &
			"Genus: Balaenoptera" & ControlChars.CrLf &
			"Species: B. musculus" & ControlChars.CrLf &
			"Subspecies: B. m. musculus, B. m. intermedia, " &
				"B. m. brevicauda, B. m. indica, B. m. unnamed subspecies", 'Blue Whale
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Balaenopteridae" & ControlChars.CrLf &
			"Genus: Balaenoptera" & ControlChars.CrLf &
			"Species Complex: B. acutorostrata, B. bonaerensis",    'Minke Whale
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Mammalia" & ControlChars.CrLf &
			"Order: Artiodactyla" & ControlChars.CrLf &
			"Infraorder: Cetacea" & ControlChars.CrLf &
			"Family: Monodontidae" & ControlChars.CrLf &
			"Genus: Monodon" & ControlChars.CrLf &
			"Species: M. monoceros",                'Narwhal
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chrondrichthyes" & ControlChars.CrLf &
			"Order: Hexanchiformes" & ControlChars.CrLf &
			"Family: Chlamydoselachidae" & ControlChars.CrLf &
			"Genus: Chlamydoselachus" & ControlChars.CrLf &
			"Species: C. anguineus",                'Frilled Shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chrondrichthyes" & ControlChars.CrLf &
			"Order: Squaliformes" & ControlChars.CrLf &
			"Family: Somniosidae" & ControlChars.CrLf &
			"Genus: Somniosus" & ControlChars.CrLf &
			"Species: S. microcephalus",            'Greenland Shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondrichthyes" & ControlChars.CrLf &
			"Order: Lamniformes" & ControlChars.CrLf &
			"Family: Alopiidae" & ControlChars.CrLf &
			"Genus: Alopias" & ControlChars.CrLf &
			"Species: A. pelagicus",                'Pelagic Thresher Shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondricthyes" & ControlChars.CrLf &
			"Order: Orectolobiformes" & ControlChars.CrLf &
			"Family: Ginglymostomatidae" & ControlChars.CrLf &
			"Genus: Ginglymostoma" & ControlChars.CrLf &
			"Species: G. cirratum",                 'Nurse Shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondrichthyes" & ControlChars.CrLf &
			"Order: Carcharhiniformes" & ControlChars.CrLf &
			"Family: Sphyrnidae" & ControlChars.CrLf &
			"Genus: Sphyrna" & ControlChars.CrLf &
			"Species: S. mokarran",                 'Greater Hammerhead shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondrichtyes" & ControlChars.CrLf &
			"Order: Lamniformes" & ControlChars.CrLf &
			"Family: Lamnidae" & ControlChars.CrLf &
			"Genus: Carcharodon" & ControlChars.CrLf &
			"Species: C. carcharias",               'Great White Shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondrichtyes" & ControlChars.CrLf &
			"Order: Carcharhiniformes" & ControlChars.CrLf &
			"Family: Carcharhinidae" & ControlChars.CrLf &
			"Genus: Galeocerdo" & ControlChars.CrLf &
			"Species: G. cuvier",                   'Tiger Shark
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondrichthyes" & ControlChars.CrLf &
			"Order: Myliobatiformes" & ControlChars.CrLf &
			"Family: Mobulidae" & ControlChars.CrLf &
			"Genus: Mobula" & ControlChars.CrLf &
			"Species: M. birostris",                'Giant Oceanic Manta Ray
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondichtyes" & ControlChars.CrLf &
			"Subclass: Elasmobranchii" & ControlChars.CrLf &
			"Order: Myliobatiformes" & ControlChars.CrLf &
			"Family: Dasyatidae" & ControlChars.CrLf &
			"Genus: Bathytoshia" & ControlChars.CrLf &
			"Species: B. brevicaudata",             'Smooth Stingray
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondrichthyes" & ControlChars.CrLf &
			"Subclass: Elasmobranchii" & ControlChars.CrLf &
			"Order: Myliobatiformes" & ControlChars.CrLf &
			"Family: Myliobatidae" & ControlChars.CrLf &
			"Genus: Myliobatis" & ControlChars.CrLf &
			"Species: M. tobijei",                  'Japanese Eagle Ray
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Chondichthyes" & ControlChars.CrLf &
			"Superorder: Batoidea" & ControlChars.CrLf &
			"Order: Myliobatiformes" & ControlChars.CrLf &
			"Family: Myliobatidae" & ControlChars.CrLf &
			"Genus: Aetobatus" & ControlChars.CrLf &
			"Species: A. narinari",                 'Spotted Ray
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Reptilia" & ControlChars.CrLf &
			"Order: Testudines" & ControlChars.CrLf &
			"Suborder: Cryptodira" & ControlChars.CrLf &
			"Superfamily: Chelonioidea" & ControlChars.CrLf &
			"Family: Cheloniidae" & ControlChars.CrLf &
			"Subfamily: Cheloniinae" & ControlChars.CrLf &
			"Genus: Chelonia" & ControlChars.CrLf &
			"Species: C. mydas",                    'Green Sea Turtle
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Reptilia" & ControlChars.CrLf &
			"Order: Testudines" & ControlChars.CrLf &
			"Suborder: Cryptodira" & ControlChars.CrLf &
			"Superfamily: Chelonioidea" & ControlChars.CrLf &
			"Family: Dermochelyidae" & ControlChars.CrLf &
			"Subfamily: Dermochelyinae" & ControlChars.CrLf &
			"Genus: Dermochelys" & ControlChars.CrLf &
			"Species: D. coriacea",                 'Leatherback Sea Turtle
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Acanthuridae" & ControlChars.CrLf &
			"Genus: Acanthurus" & ControlChars.CrLf &
			"Species: A. coeruleus",                'Blue Tang
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Acanthuridae" & ControlChars.CrLf &
			"Genus: Zebrasoma" & ControlChars.CrLf &
			"Species: Z. flavescens",               'Yellow Tang
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perficormes" & ControlChars.CrLf &
			"Family: Acanthuridae" & ControlChars.CrLf &
			"Subfamily: Acanthurinae" & ControlChars.CrLf &
			"Genus: Paracanthurus" & ControlChars.CrLf &
			"Species: P. hepatus",                  'Regal Tang
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Pomacanthidae" & ControlChars.CrLf &
			"Genus: Pomacanthus" & ControlChars.CrLf &
			"Species: P. paru",                     'French Angelfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Pomacanthidae" & ControlChars.CrLf &
			"Genus: Pygoplites" & ControlChars.CrLf &
			"Species: P. diacanthus",               'Royal Angelfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Pomacanthidae" & ControlChars.CrLf &
			"Genus: Pomacanthus" & ControlChars.CrLf &
			"Species: P. xanthometopon",            'Blueface Angelfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Pomacanthidae" & ControlChars.CrLf &
			"Genus: Centropyge" & ControlChars.CrLf &
			"Species: C. loriculus",                'Flame Angelfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Pomacanthidae" & ControlChars.CrLf &
			"Genus: Holacanthus" & ControlChars.CrLf &
			"Species: H. cilaris",                  'Queen Angelfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Chaetodontidae" & ControlChars.CrLf &
			"Genus: Chaetodon" & ControlChars.CrLf &
			"Subgenus: Rabdophorus" & ControlChars.CrLf &
			"Species: C. lineolatus",               'Lined Butterflyfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perciformes" & ControlChars.CrLf &
			"Family: Chaetodontidae" & ControlChars.CrLf &
			"Genus: Chaetodon" & ControlChars.CrLf &
			"Species: C. striatus",                 'Banded Butterflyfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Gobiiformes" & ControlChars.CrLf &
			"Family: Gobiidae" & ControlChars.CrLf &
			"Genus: Nemateleotris" & ControlChars.CrLf &
			"Species: N. decora, N. exquisita",     'Elegant Firefish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinoptyerygii" & ControlChars.CrLf &
			"Order: Callionymiformes" & ControlChars.CrLf &
			"Family: Callionymidae" & ControlChars.CrLf &
			"Genus: Synchiropus" & ControlChars.CrLf &
			"Species: S. splendidus",               'Mandarinfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Istiophoriformes" & ControlChars.CrLf &
			"Family: Istiophoridae" & ControlChars.CrLf &
			"Genus: Istiophorus" & ControlChars.CrLf &
			"Species: I. platypterus, I. albicans (formerly)",  'Indo-Pacific Sailfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Perfiformes" & ControlChars.CrLf &
			"Family: Nototheniiddae" & ControlChars.CrLf &
			"Genus: Dissostichus",                  'Antarctic Toothfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actiopterygii" & ControlChars.CrLf &
			"Order: Zeiformes" & ControlChars.CrLf &
			"Family: Zeidae" & ControlChars.CrLf &
			"Genus: Zeus" & ControlChars.CrLf &
			"Species: Z. faber",                    'John Dory
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Sarcoptrygii" & ControlChars.CrLf &
			"Subclass: Actinistia" & ControlChars.CrLf &
			"Order: Coelacanthiformes" & ControlChars.CrLf &
			"Family: Latimeriidae" & ControlChars.CrLf &
			"Genus: Latimeria" & ControlChars.CrLf &
			"Species: L. chalumnnae",               'Coelacanth
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Clade: Percomorpha" & ControlChars.CrLf &
			"Subgroup: Ovalentaria" & ControlChars.CrLf &
			"Family: Pomacentridae" & ControlChars.CrLf &
			"Subfamily: Amphiprioninae" & ControlChars.CrLf &
			"Genus: Amphiprion" & ControlChars.CrLf &
			"Species: A. ocellaris",                'Common Clownfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Scorpaeniformes" & ControlChars.CrLf &
			"Family: Scorpaenidae" & ControlChars.CrLf &
			"Genus: Pterois" & ControlChars.CrLf &
			"Species: P. volitans",                 'Red Lionfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Carangiformes" & ControlChars.CrLf &
			"Family: Coryphaenidae" & ControlChars.CrLf &
			"Genus: Coryphaena" & ControlChars.CrLf &
			"Species: C. hippurus",                 'Mahi Mahi
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Labriformes" & ControlChars.CrLf &
			"Family: Labridae" & ControlChars.CrLf &
			"Genus: Cheilinus" & ControlChars.CrLf &
			"Species: C. undulatus",                'Humphead Wrasse
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Labriformes" & ControlChars.CrLf &
			"Family: Labridae" & ControlChars.CrLf &
			"Genus: Semicossyphus" & ControlChars.CrLf &
			"Species: S. reticulatus",              'Sheepshead Wrasse
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Tetraodontiformes" & ControlChars.CrLf &
			"Family: Molidae" & ControlChars.CrLf &
			"Genus: Mola" & ControlChars.CrLf &
			"Species: M. mola",                     'Ocean SUnfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Gobiiformes" & ControlChars.CrLf &
			"Family: Gobiidae" & ControlChars.CrLf &
			"Genus: Gobius" & ControlChars.CrLf &
			"Species: G. vottatis",                 'Striped Goby
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Gobiiformes" & ControlChars.CrLf &
			"Family: Gobiidae" & ControlChars.CrLf &
			"Genus: Nemateleotris" & ControlChars.CrLf &
			"Species: N. magnifica",                'Fire Goby
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Scombriformes" & ControlChars.CrLf &
			"Family: Thunnus" & ControlChars.CrLf &
			"Genus: Thunnus" & ControlChars.CrLf &
			"Species: T. thynnus",                  'Atlantic Bluefin Tuna
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Scombriformes" & ControlChars.CrLf &
			"Family: Scombridae" & ControlChars.CrLf &
			"Genus: Thunnus" & ControlChars.CrLf &
			"Subgenus: Neothunnus" & ControlChars.CrLf &
			"Species: T. albacares",                'Yellowfin Tuna
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Syngnathiformes" & ControlChars.CrLf &
			"Family: Syngnathidae" & ControlChars.CrLf &
			"Genus: Hippocampus" & ControlChars.CrLf &
			"Species: H. hippocampus",              'Short-Snouted Seahorse
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinotherygii" & ControlChars.CrLf &
			"Order: Ayngnathiformes" & ControlChars.CrLf &
			"Family: Syngnathidae" & ControlChars.CrLf &
			"Subfamily: Syngnathinae" & ControlChars.CrLf &
			"Genus: Phycodurus" & ControlChars.CrLf &
			"Species: P. eques",                    'Leafy Seadragon
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Antrhopoda" & ControlChars.CrLf &
			"Subphylum: Crustacea" & ControlChars.CrLf &
			"Class: Malacostraca" & ControlChars.CrLf &
			"Order: Decapoda" & ControlChars.CrLf &
			"Family: Alpheidae" & ControlChars.CrLf &
			"Genus: Alpheus" & ControlChars.CrLf &
			"Species: A. digitalis",                'Pistol Shrimp
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Arthropoda" & ControlChars.CrLf &
			"Subphylum: Crustacea" & ControlChars.CrLf &
			"Class: Malacostraca" & ControlChars.CrLf &
			"Order: Stomatopoda" & ControlChars.CrLf &
			"Family: Odontacatylidae" & ControlChars.CrLf &
			"Genus: Odontodactylus" & ControlChars.CrLf &
			"Species: O. scyllarus",                'Peacock Mantis Shrimp
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Anguilliformes" & ControlChars.CrLf &
			"Family: Muraenidae" & ControlChars.CrLf &
			"Genus: Gymnothorax" & ControlChars.CrLf &
			"Species: G. javanicus",                'Giant Moray Eel
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Anguilliformes" & ControlChars.CrLf &
			"Family: Muraenidae" & ControlChars.CrLf &
			"Genus: Rhinomuraena" & ControlChars.CrLf &
			"Species: R. quaesita",                 'Ribbon Eel
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Chordata" & ControlChars.CrLf &
			"Class: Actinopterygii" & ControlChars.CrLf &
			"Order: Anguilliformes" & ControlChars.CrLf &
			"Family: Eurypharyngidae" & ControlChars.CrLf &
			"Genus: Eurypharynx" & ControlChars.CrLf &
			"Species: E. pelecanoides",             'Pelican Eel
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Arthropoda" & ControlChars.CrLf &
			"Subphylum: Crustacea " & ControlChars.CrLf &
			"Class: Malacostraca" & ControlChars.CrLf &
			"Order: Decapoda" & ControlChars.CrLf &
			"Infraorder: Anomura" & ControlChars.CrLf &
			"Family: Litodidae" & ControlChars.CrLf &
			"Genus: Paralithodes" & ControlChars.CrLf &
			"Species: P. camtschaticus",            'Alaskan King Crab
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Arthropoda" & ControlChars.CrLf &
			"Subphylum: Crustacea" & ControlChars.CrLf &
			"Class: Malacostraca" & ControlChars.CrLf &
			"Order: Decapoda" & ControlChars.CrLf &
			"Infraorder: Anomura" & ControlChars.CrLf &
			"Family: Kiwaidea" & ControlChars.CrLf &
			"Genus: Kiwa" & ControlChars.CrLf &
			"Species: K. hirsuta",                  'Yeti Crab
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Anthropoda" & ControlChars.CrLf &
			"Subphylum: Crustacea" & ControlChars.CrLf &
			"Class: Malacostraca" & ControlChars.CrLf &
			"Order: Decapoda" & ControlChars.CrLf &
			"Superfamily: Nephropoidae" & ControlChars.CrLf &
			"Family: Naphropidae" & ControlChars.CrLf &
			"Genus: Homarus" & ControlChars.CrLf &
			"Species: H. americanus",               'American Lobster
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Cnidaria" & ControlChars.CrLf &
			"Class: Hydrozoa" & ControlChars.CrLf &
			"Order: Siphonophorae" & ControlChars.CrLf &
			"Suborder: Cystonectae" & ControlChars.CrLf &
			"Family: Physaliidae" & ControlChars.CrLf &
			"Genus: Physalia" & ControlChars.CrLf &
			"Species: P. physalis",                 'Portuguese Man O' War
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Cnidaria" & ControlChars.CrLf &
			"Class: Hydrozoa" & ControlChars.CrLf &
			"Order: Limnomedusae" & ControlChars.CrLf &
			"Family: Olindiidae" & ControlChars.CrLf &
			"Genus: Olindias" & ControlChars.CrLf &
			"Species: O. formosus",                 'Flower Hat Jellyfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Cnidaria" & ControlChars.CrLf &
			"Class: Hydrozoa" & ControlChars.CrLf &
			"Order: Leptothecata" & ControlChars.CrLf &
			"Family: Aequoreidae" & ControlChars.CrLf &
			"Genus: Aequorea" & ControlChars.CrLf &
			"Species: A. victoria",                 'Crystal Jellyfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Cnidaria" & ControlChars.CrLf &
			"Class: Scyphozoa" & ControlChars.CrLf &
			"Order: Semaeostomeae" & ControlChars.CrLf &
			"Family: Pelagiidae" & ControlChars.CrLf &
			"Genus: Chrysaora" & ControlChars.CrLf &
			"Species: C. achlyos",                  'Black Sea Nettle
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Cnidaria" & ControlChars.CrLf &
			"Class: Hydrozoa" & ControlChars.CrLf &
			"Order: Anthoathecata" & ControlChars.CrLf &
			"Family: Oceaniidae" & ControlChars.CrLf &
			"Genus: Turritopsis" & ControlChars.CrLf &
			"Species: T. dohrnii",                  'Immortal Jellyfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Echinodermata" & ControlChars.CrLf &
			"Class: Asteroidea" & ControlChars.CrLf &
			"Order: Forcipulatida" & ControlChars.CrLf &
			"Suborder: Asteriadina" & ControlChars.CrLf &
			"Family: Asteriidae" & ControlChars.CrLf &
			"Genus: Asterias" & ControlChars.CrLf &
			"Species: A. amurensis" & ControlChars.CrLf &
			"Subspecies: A. a. amurensis, A. a. robusta",   'Japanese Common Starfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Echinodermata" & ControlChars.CrLf &
			"Class: Ophiuroidea" & ControlChars.CrLf &
			"Order: Ophiurida" & ControlChars.CrLf &
			"Family: Ophiothricidae" & ControlChars.CrLf &
			"Genus: Ophiothrix" & ControlChars.CrLf &
			"Species: O. fragilis",                 'Common Brittle Star
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Echinodermata" & ControlChars.CrLf &
			"Class: Asteroidea" & ControlChars.CrLf &
			"Order: Forcipulatida" & ControlChars.CrLf &
			"Family: Stichasteridae" & ControlChars.CrLf &
			"Genus: Stichaster" & ControlChars.CrLf &
			"Species: S. australis",                'Reef Starfish
		"Kingdom: Animalia" & ControlChars.CrLf &
			"Phylum: Echinodermata" & ControlChars.CrLf &
			"Class: Echinoidea" & ControlChars.CrLf &
			"Order: Camarodonta" & ControlChars.CrLf &
			"Family: Echinidae" & ControlChars.CrLf &
			"Genus: Echinus" & ControlChars.CrLf &
			"Species: E. esculentus"                'Common Sea Urchin
	}

	'***********************************************************************************************************************************************'

	Public funFacts() As String = {
	"  - Despite being called Vampire squids, they are not actually squids, instead " &
			"belonging to their own order, Vampyromorphida, " & ControlChars.CrLf &
			"  - Vampyroteuthis infernalis is the only living species in its taxon. " & ControlChars.CrLf &
			"  - The first living specimens were collected during the Valdivia Expedition, " &
				"and were originally described as a type of octopus" & ControlChars.CrLf &
			"  - The animal's name was inspired by its dark coloring and the cloak-like webbing" & ControlChars.CrLf &
			"  - They have the largest eyes in the animal kingdom proportionate to its body size. " & ControlChars.CrLf &                                                                'End Vampire Squid
			"  - They can live and breathe normally in zones of the ocean where the saturation of " &
				" oxygen is as low as 3%" & ControlChars.CrLf &
			"  - Instead of ink, they eject clouds of bioluminescent mucous to escape from predators",
		" - Unlike other large squids, a colossal squid's suckers are lined with hooks " &
				"instead of small teeth " & ControlChars.CrLf &
			" - The species exhibits abyssal gigantism, a trait in which invertebrates that live " &
					"in deep water are much larger than their shallow water dwelling relatives" & ControlChars.CrLf &
			" - Colossal squids have the largest known beak of any discovered cephalopod species" & ControlChars.CrLf &
			" - The first evidence of the species was discovered in 1925, when whalers recovered " &
				"two tentacles belonging to one from the stomach of a sperm whale" & ControlChars.CrLf &
				" - A colossal squid's eyes are the largest document in the animal kingdom at 27 cm " &
				"(11 in) in diameter with a 9 cm (4.5 in) pupil. The eye was estimated to be 30-40 " &
				"cm (12-16 in) when the squid was alive" & ControlChars.CrLf &
			" - The largest recorded specimen of the species, known as the Ross specimen, was " &
				"captured in 2007 by New Zealand fishermen. It was an immature female measuring " &
				"5.6 m (115 ft) in length", '------------------------------------------------------------------------>End Colossal Squid				
		" - Since it is difficult to find giant squids both alive and dead, the " &
				"exact number of species in the genus is unclear. Estimates of a number range " &
				"from as little as one to as many as eight" & ControlChars.CrLf &
			" - A giant squid's brain is shaped like a donut, with a hole in the center. Their " &
				"esophagus passes through this hole to get to the stomach" & ControlChars.CrLf &
			" - Some scientists estimate that giant squids can grow to be 20 m (66 ft) based on the size of their beak" & ControlChars.CrLf &
			" - The first video record of a giant squid was made in 2006, when fishermen used " &
				"a baited hook to pull one to the ocean's surface." & ControlChars.CrLf &
			" - In the past, these creatures have been mistaken for monsters, sirens, and even" &
				"mermen. They also may have partially inspired the myth of the kraken" & ControlChars.CrLf &
			" - The first photograph of a giant squid was taken in 1874, and featured a speciman " &
				"belonging to Reverend Moses Harvey of NewFoundland",   '--------------------------------------------->End Giant Squid
		" - The firefly squid is the only member of the squid family to see in color vision" & ControlChars.CrLf &
			" - The squid's bioluminescence is used to communicate with other firefly squids, attract mates, scare off rivals, " &
				"and lure prey in" & ControlChars.CrLf &
			" - Events called 'squid drownings' sometimes occur in Japan. Large numbers of the " &
				"squid wash up on the shore for miles, causing the beach to glow blue" & ControlChars.CrLf &
			" - While other swuids use their color changing abilities as camouflage, the " &
				"firefly squid uses counter-illumination camouflage to match the color and " &
				"brightness of the light filtering down from below" & ControlChars.CrLf &
			" - Tourists oftentimes go along with fishermen on their boats when they are catching " &
				"this squid. As the nets are hauled in, the sea glows a brilliant blue color", '--------------------------------------------------------------->End Firefly Squid
		" - The largest member of this species that has been recorded was " &
				"an adult female with a mantle length of 60 cm (2 ft)" & ControlChars.CrLf &
			" - They are often mistakn for the orangeback flying squid " &
				"(sthenoteuthis pteropus), since at a quick glance the two look " &
				"extremely similiar" & ControlChars.CrLf &
			" - Scientists are unsure as to how the squids are able to make" &
				"themselves airborne, and believe it is done instinctively " &
				"in response to threats" & ControlChars.CrLf &
			" - Their common name comes from the the cephalopod's tendancy to" &
				"shoot out of the water like flying fish", '--------------------------------------------------------->End Neon Flying Squid
		" - They have a reputation for being aggressive towards humans. However, " &
				"this seems to mostly be the case while they are feeding" & ControlChars.CrLf &
			" - As a type of flying squid, the Humboldt squid can use their powerful bodies and " &
				"streamlined shape to launch themselves high into the air" & ControlChars.CrLf &
			"- The squids communicate by flashtalking, in which they rapidly cycle through " &
				"various colors" & ControlChars.CrLf &
			" - Females can lay as many as twenty million eggs during their two year lifespan" & ControlChars.CrLf &
			" - They exhibit some cannibalistic behavior and will attack and consume injured " &
				"or smaller members of their own shoal" & ControlChars.CrLf &
			" - Humboldt squids undergo daily vertical migrations, moving deeper into the ocean " &
				"during the day and heading towards the surface to hunt at night", '------------------------------->End Humboldt Squid
		"- Market squids are the largest fishery in California, and has been since 1993" & ControlChars.CrLf &
			" - They are often misidentified as Doryteuthis pealeii, which lives on the northern Atlantic " &
				"coasts of North America, and Loligo gahi whifh lives on the coast of Chile" & ControlChars.CrLf &
			" - Large scale fishing of the animal was started by the Chinese in Monterey Bay, California" & ControlChars.CrLf &
			" - El Ninos can cause massive fluxations within the local populations, and even cause landings to " &
				"disappear entirely in some areas" & ControlChars.CrLf &
			" - Their lifespans are extremely short, with most specimens only living an average of 188 days. " &
				"The oldest specimen on record lived for 300 days", '--------------------------------------------->End Market Squid
		" - The squids is named after the reigning family of Monaco, the Grimaldi family" & ControlChars.CrLf &
			" - It has been theorized that the ancestors of this squid had highly specialized " &
				"tentacles. This in turn made it too difficult for the tentacles to keep up with " &
				"quick changes in evolutionary pressures, and thus they were lost" & ControlChars.CrLf &
			" - Grimaldi squids are rarely captured, and as a result little is known about it" & ControlChars.CrLf &
			" - The first species were described as a similar species known as enoptroteuthis spinicauda. " &
				"It would take over seventy years for them to be properly identified" & ControlChars.CrLf &
			" - The first specimen of a Grimaldi scaled squid were collected from the stomach contents " &
				"of a sperm whale", '----------------------------------------------------------------------------->End Grimaldi Scaled Squid
		" - Umbrella squids inhabit different dephts of water according to their age. " &
				"Juveniles live at depths around 100 to 200 meters (328 to 656 feet), while " &
				"older squids live in depths between 1000 and 2200 meters (3280 to 7217 feet)" &
				"below the surface" & ControlChars.CrLf &
			" - Curiously, an umbrella squid's eyes are not positioned symetrically on either side " &
				"of their mantle " & ControlChars.CrLf &
			" - Although this is unconfirmed, it is theorized that several undiscovered subspecies " & ControlChars.CrLf &
				"of umbrella squid live in the Atlantic Ocean" & ControlChars.CrLf &
			" - They are among the largest species in the genus Histioteuthis" & ControlChars.CrLf &
			" - Jeweled umbrella squids are cock-eyed squids, meaning that one of their eyes is much larger" &
				"than the other one.", '-------------------------------------------------------------------------->End Umbrella Squid
		" - Despite being small, this octopodes venom is strong enough to kill a " &
				"man. At this time there are no known antivenoms for it" & ControlChars.CrLf &
			" - Blue-ringed octopodes release their venom via direct injection through a " &
				"bite, or by letting it flow into the water so it can enter prey through their " &
				"gills" & ControlChars.CrLf &
			" - There are seven other species that may be part of the genus Hapalochlaena. Of those species, " &
				"however, only one - Hapalochlaena nierstraszi - has been given a potential scientific name" & ControlChars.CrLf &
			" - The octopodes venom includes tetrodoxin, histamine, tryptamine, octopamine, " &
				"taurine, acetycholine, and dopamine. The major neurotoxin component, tetrodoxin, " &
				"is 1,200 times more toxic than cyanide" & ControlChars.CrLf &
			" - the octopodes' rings become more vivid if they are threatened or agitated", '---------------------------------------------------->End Blue-Ringed Octopus
		" - It is the largest octopus species, thanks to a recorded specimen that weighed " &
				"71 kg (156lb)." & ControlChars.CrLf &
			" - Although they normally crawl around the ocean floor, the octopus can reach speeds " &
				"of up to 50 km/h (25 mph) for short sprints." & ControlChars.CrLf &
			" - The octopus has three hearts and copper based blood, which makes it blue rather  " &
				"than red." & ControlChars.CrLf &
			" - Compared to other octopodes, the giant pacific octopus has an unusually " &
				"long lifespan. Most octopodes live for just a year, but the giant octopus can " &
				"live for up to 3-5 years in the wild." & ControlChars.CrLf &
			"- They are among the smartest invertebrates in the world, with over 300 million " &
				"neurons in its brain. " & ControlChars.CrLf &
			" -Their entire body, save for the beak, is compressible. This means that the octopus " &
				"can fit istelf through a hole of almost any size, provided that the hole is at " &
				"least as large as its beak.", '---------------------------------------------------------------->End North Pacific Giant Octopus
		" - Blanket octopodes are immune to the poison of a Pourutguese Man o'War" &
				"Males and smaller females will use broken off tentacles of the animal for " &
				"defensive purposes" & "\n" &
			" - The blanket that the octopus posesses is able to be detatched and used as a " &
				"distraction to escape from predators" & ControlChars.CrLf &
			" - Unlike other octopodes, the blanket octopus does not utilize ink as a defense" &
				"mechanism" & ControlChars.CrLf &
			" - While females of this sepcies were easy to find, the first live male specimen " &
				"was not seen until 2002, and was discovered off of the Great Barrier Reef" & ControlChars.CrLf &
			" - Blanket octopodes are the only species of octopus to not spend time on the ocean floor", '------>End Blanket Octopus
		" - Their name comes from the fact that they have a striking resemblence to " &
				"the titular character Dumbo from the 1941 Disney film" & ControlChars.CrLf &
			" - Despite being the type species of all dumbo octopodes, G. umbellata is relatively " &
				"unknown, with a total of two specimens discovered" & ControlChars.CrLf &
			" - The largest dumbo octopus ever found was located off of the Azores" & ControlChars.CrLf &
			" - It is possible that G. Umellata is a senior synonym of two other types of dumbo " &
				"octopodes, G. wuelkeri or G. discoveryi. A senior synonym in taxonomy is an older " &
				"scientific name that is no longer used, but refers to the same species. In other " &
				"words, it is wholly possible that G. umbellata is not a unique species at all" & ControlChars.CrLf &
			" - Due to the fact that they live at least 4000 m (13,100 ft) below the surface, " &
				"dumbo octopes hold the distinction of being the deepest living octopus in the world" & ControlChars.CrLf &
			" - Unlike most octopodes, the dumbo octopodus does not posesse an ink sac", '---------------------->End Dumbo Octopus
		" - They are one of only two species of octopodes that exhibits bioluminescence" & ControlChars.CrLf &
			" - There is widespread scientific debate regarding if it should be placed in the family " &
				"of Stauroteuthidae or Cirroteuthidae" & ControlChars.CrLf &
			" - Bioluminescent octopodes are a type of cirrate octopus, which means that they have an " &
				"internal shell-like cartilidge structure and a pair of fins on their head" & ControlChars.CrLf &
			" - The bioluminescent octopus does not emit light continously, instead typically flashing " &
				"their lights to create a twinkling effect. However, they are able to emit a constant " &
				"glow for up to five minutes if  necessary" & ControlChars.CrLf &
			" - Due to the extreme depths that this animal lives in, it is understudied and not much is " &
				"known about it", '---------------------------------------------------------------------------------->End Bioluminescnet Octopus
		" - Mimic octopodes have been confirmed to mimic the following animals: sole (a poisonous " &
				"flatfish), lionfish, flounder, tube worms, colonial tunicates, sea sponges, and various sea " &
				"snakes" & ControlChars.CrLf &
			" - It is theorized that they also can mimic other fauna local to their home as well" & ControlChars.CrLf &
			" - Amazingly, the mimic octopus is able to determine which animal will have the best chance at " &
				"scaring away a particular predator." & ControlChars.CrLf &
			" - Mimic octopodes are able to alter the pattern and texture of their " &
				"skin as well as their coloration" & ControlChars.CrLf &
			" - Due to the fact that mimic octopodes will impersonate local fauna that changes from region to " &
				"region, it is wholly possible that the octopodus hones its mimicry through passive observation " &
				"of the world around it", '------------------------------------------------------------------------->End Mimic Octopus
		" - The greater arognaut is type species of the genus Argonauta" & ControlChars.CrLf &
			" -  Despite being referred to as a paper nautilus, the greater argonaut does not" &
				"belong to the subclass Nautiloidea. This means that it is not, in fact, a " &
				"nautilus" & ControlChars.CrLf &
			" - The greater argonaut's name comes from the Ancient Greek Myth of Jason, who " &
				"sailed a ship named the Argo to find the golden fleece. Argonaut, quite " &
				"literally, means sailor of the Argo" & ControlChars.CrLf &
			" - A subspecies that exhibited dwarfism can be found in the Mediterranean Sea" & ControlChars.CrLf &
			" - The argonaut uses a toxin to immobilize and kill prey. It is not yet known what this " &
				"toxin is composed of", '--------------------------------------------------------------------------->End Argonaut
		" - Despite being called a squid, the striped pyjama squid is a member of the bobtail " &
				"squids, which are actually cuttlefish" & ControlChars.CrLf &
			" - It is one of the few venemous molluscs to exist. When threatened, it releases " &
				"venomous slime." & ControlChars.CrLf &
			" - Their stripesare actually made out of tiny dots containing chromatophores." & ControlChars.CrLf &
			" - The babies are born with their body patterns full formed. This differs from " &
				"other venomous animals whos colors and/or patterns do not appear until they mature.", '----------->End Striped Pyjama Squid
		" - Their flesh contains unique acids, making it unsuitable for human consumption." & ControlChars.CrLf &
			" - Its toxin is as lethal as the blue-ringed octopus. Scientists still do not " &
				"understand this toxin completely, or have a name for it." & ControlChars.CrLf &
			" - The flamboyant cuttlefish's arms are broad and blade=like, rather than the " &
				"long and thin arms of other cephalopods." & ControlChars.CrLf &
			" - Due to the fact that their internal cuttlebone is quite small, which hinders its " &
				"ability to float. Thus, the flamboyant cuttlefish is the only one to walk along " &
				"the seafloor." & ControlChars.CrLf &
			" - Their name comes from its bright, flamboyant display of colors." & ControlChars.CrLf &
			" - Unlike most cuttlefish, who are shy, flamboyant cuttlefish are courageous." &
				"They have been known to stand their ground when confronted rather than jetting " &
				"off to hide.", '----------------------------------------------------------------------------------->End Flamboyant Cuttlefish
			" - Unlike other species of cephalopods, female giant cuttlefish will " &
				"take several mates at once" & ControlChars.CrLf &
			" - These animals do not tend to make large spawning groups. The one exception " &
				"to this is an aggregation of hundreds of thousands of animals that arrive " &
				"at the reefs in the Upper Spencer Gulf each year" & ControlChars.CrLf &
			" - Scientists have yet to discover how the cephalopods live as juveniles" & ControlChars.CrLf &
			" - The various populations do not interbreed with each other, meaning that little " &
				"genetic divergence occurs" & ControlChars.CrLf &
			" - It's possible that the population that lives in the Upper " &
				"Spencer Gulf is actually either a new subspecies or species of giant cuttlefish" & ControlChars.CrLf &
			" - Like other cuttlefish, giant cuttlefish are colorblind", '------------------------------------------>End Giant Cuttlefish
		" - A possible subspecies of this cuttlefish, Sepia vermiculata, lives in the waters " &
				"around South Africa, though at this point in time it is debatable whether or not " &
				"such a classification is correct or not" & ControlChars.CrLf &
			" - Their lifespan is short, lasting only one to two years" & ControlChars.CrLf &
			" - Unlike other animals, the common cuttlefish's lifespan does not increase in " &
				"captivity" & ControlChars.CrLf &
			" - A 2008 study discovered that if the cuttlefish are exposed to certain species of prey" &
				"as an embryo, they will choose to hunt for that prey whenever possible after hatching" & ControlChars.CrLf &
			" - When mating, the males of this species will change their coloring to a black and white " &
				"zebra pattern", '--------------------------------------------------------------------------------->End Common Cuttlefish
		" - The logrithmic spiral, similar to the golden spiral, is one of the most " &
				"perfect occurances of a spiral in nature" & ControlChars.CrLf &
			" - Their eyes are very primitave and have no lens, making the structure very similar " &
				"to that of a pinhole camera" & ControlChars.CrLf &
			" - The species has existed for an extremely long time, with the oldest fossils being " &
				"dated to the Early Pleistocene subepoch, which spanned between 2.588 and .0.781 million " &
				"years ago" & ControlChars.CrLf &
			" - Since they have poor eyesight, they hunt primarily by smell. Scientists have described them " &
				"as eating anything that smells", '--------------------------------------------------------------->End Chambered Nautilus	
		" - Fuzzy nautiluses are rarely seen, and were thought to have gone extinct sometime " &
				"in 1986. However, they were rediscovered in July of 2015 to much fanfare in the " &
				"scientific world" & ControlChars.CrLf &
			" - This species was originally placed with many other nautiluses in the genus Nautilus. " &
				"However, due to several morphological differences they were reclassified and given " &
				"a unique genus" & "\n " &
			" - The fuzzy nautilus has a unique defense mechanism to prevent predators from eating them. " &
				"The fluffy coating on the outside of their shell is extremely slippery, allowing them to " &
				"slide out of the predator's grip" & ControlChars.CrLf &
			" - Fuzzy nautiluses are solitary animals, and only interact with their fellow nautiluses to " &
				"mate and compete for food" & ControlChars.CrLf &
			" - This animal enjoys a long lifespan, with some living to be up to 100 years old", '---------------->End Fuzzy Nautilus
		" - Unlike most nautiluses, the Palau nautilus can be dinural or nocturnal" & ControlChars.CrLf &
			" - A mature Palau nautilus can live for 5 to ten years after reaching maturity" & ControlChars.CrLf &
			" - They prefer water that has a temperature range of 9.4 - 16.6 C (48.9 - 61.9 F). " &
				"However, they can survive in water that is up to 30 C (86 F) if necessary" & ControlChars.CrLf &
			" - This species has been commonly misidentified as a chambered nautilus due to " &
				"their similar appearance", '--------------------------------------------------------------------->End Pallau Nautilus
		 " - This particular species of nautilus is named after the " &
				"white patches that form on the shoulder region of the shell" & ControlChars.CrLf &
			" - It is possible that the white-patched nautilus is in fact not a unique " &
				"species, but instead a subspecies of the chambered nautilus" & ControlChars.CrLf &
			" - Like other species of nautilus, the shells were harvested to make " &
				"items such as jewelry and ornamental cups. This practice is less " &
				"common now due to conservation efforts", '------------------------------------------------------->End White-Patched Nautilus
		" - Due to their high intelligence, the United States Navy trains sea lions to do " &
				"military tasks and operations" & ControlChars.CrLf &
			" - California sea lions are among the most popular animals to train for public shows at " &
				"zoos, oceanariums, and circuises " & ControlChars.CrLf &
			" - The states of Oregon and Washington each have an annual kill quota for sea lions to " &
				"protect endangered species of fish that the animals hunt" & ControlChars.CrLf &
			" - A popular place to see the California sea lion in their natural habitat is Pier 39 in " &
				"San Francisco, California" & ControlChars.CrLf &
			" - The California Sea Lion's spine is so flexible that it can bend backwards far enough " &
				"to reach their hindflippers with ease", '-------------------------------------------------------->End California Sea Lion
		" - The species is named after George Wilhelm  Steller, a naturalist who " &
				"first described the species in 1741" & ControlChars.CrLf &
			" - Steller sea lions have mysteriously experienced a significant population decline " &
				"along the shores of Alaska, which has attracted an extensive amount of attention" & ControlChars.CrLf &
			" - Among all of the eared seals, the Steller sea lion is the largest" & ControlChars.CrLf &
			" - Unlike other Pinnipedias, males do not force females into harems. Instead they control " &
				"territories that the females are free to enter and leave as they please", '---------------------->End Stellar Sea Lion
		" - Manatees are slow swimmers and vulnerable to boat collisions, which pose a " &
				"significant threat to them" & ControlChars.CrLf &
			" - On average these mammals spend anywhere from ten to twelve hours of their day asleep" & ControlChars.CrLf &
			" - The amount of food they eat is massive, with some consuming over 68 kg (150 lbs) of food " &
				"each day" & ControlChars.CrLf &
			" - West Indian manatees have the capability to hold their breath for twenty minutes" & ControlChars.CrLf &
			" - In the wild these animals can live for over fifty years" & ControlChars.CrLf &
			" - Arguably the most well known manatee was Snooty, a hand reared manatee that lived at " &
				"Parker Manatee Aquarium, which was run by the South Florida Museum", '--------------------------->End Manatee
		" - The walrus is the only living species left of the family Odobenidae, " &
				"which once contained almost twenty different species" & ControlChars.CrLf &
			" - Walruses are keystone species, meaning that they play a critical role in " &
				"maintaining the status quo of their ecosystem" & ControlChars.CrLf &
			" - They are among the largest pinnipeds, being dwarfed only by elephant seals" & ControlChars.CrLf &
			" - Larger male walruses can weigh as much as one and a half tons (1800 kgs)" & ControlChars.CrLf &
			" - Walruses are quite social and live in herds, the largest of which can have populations " &
				"numbering well over one hundred members" & ControlChars.CrLf &
			" - According to an Inuit legend, the rays of aurora borealis represent the souls of " &
				"the departed playing ball with a walrus head", '------------------------------------------------->End Walrus
		" - The Mediterranean monk seal is believed to be the rarest " &
				"living pinniped species in the world" & ControlChars.CrLf &
			" - It's estimated that the wild population consists of only 700 individuals" & ControlChars.CrLf &
			" - In Ancient Greece, monk seals were placed under the " &
				"protection of Poseidon and Apollo due to their love of the " &
				"sea and sun." & ControlChars.CrLf &
			" - Archeologists have unearthed Ancient Greek coins with " &
				"images of seals minted on them" & ControlChars.CrLf &
			" - Extreme hunting of the seals did not take place until the " &
				"Roman Empire and the Middle Ages" & ControlChars.CrLf &
			" - There are two coloniesof seals living outside the Mediterranean -  " &
				"one off the coast of eastern Africa and one around the Azores,", '------------------------------>End Monk Seal
		" - Leopard seals are extremely vocal, and sing under the water during " &
				"the summer season." & ControlChars.CrLf &
			" - They rarely attack humans, but have been known to aggressively stalk " &
				"them at times." & ControlChars.CrLf &
			" - Only one confirmed death by leopard seal has occured, when biologist " &
				"Kirsty Brown was dragged 200 ft (60.96 m) underwater to her death." & ControlChars.CrLf &
			" - Despite their aggressive behavior, leopard seals don't have completely " &
				"negative interactions with humans. National Geographic photographer Paul Nicklen " &
				"had an encounter where a female leopard seal brought him penguins in various " &
				"stages of life and death. It is believed that she had mistaken him for a pup and " &
				"was trying to teach him how to hunt for food" & ControlChars.CrLf &
			" - Sometimes the seals will play games of cat and mouse with penguins that " &
				"they don't intend to eat." & ControlChars.CrLf &
			" - The corners of their mouths are permanently turned upwards, making them " &
				"appear as if they are always smiling.", '-------------------------------------------------------->End Leopard Seal
		 " - This seal can live for over thirty years in the wild" & ControlChars.CrLf &
			" - Most harp seals bear one pup at a time, although rarely some cases " &
				"of twin births have occured" & ControlChars.CrLf &
			" - They spend the first year of their life on land" & ControlChars.CrLf &
			" - Harp seals can hold their breath for up to fifteen minutes" & ControlChars.CrLf &
			" - A mother harp seal can identify their own young in the thousands of a " &
				"colony purely by their scent" & ControlChars.CrLf &
			" - When diving these seals can reach depths of 270 m (885.83 ft)", '----------------------------------------------------------------->End Harp Seal
		" - Despite being called a killer whale, the orca actually belongs " &
				"to a family of oceanic dolphins" & ControlChars.CrLf &
			" - Orcinus orca is the only living species of the genus orcinus." & ControlChars.CrLf &
			" - There is a possibility that what we know as an orca is actually two or more " &
				"species that have mistakenly lumped together" & ControlChars.CrLf &
			" - Albino orcas have been observed. One of the most popular ones is nicknamed Iceberg" & ControlChars.CrLf &
			" - Orcas have the most complex societies out of all marine animals" & ControlChars.CrLf &
			" - Some orcas helped whalers hunt with their hunts. One such orca, known as Old Tom, " &
				"lead a pod that helped whalers herd baleen whales into Twofold Bay, Australia.", '--------------->End Orca
		" - Common dolphins were the most frequently represented dolphin species in the art and " &
					"literature of ancient Greece and Rome" & ControlChars.CrLf &
				" - These dolphins tend to hang out with other dolphin species, as well as " &
					"baleen whales" & ControlChars.CrLf &
				" - They are very kind and supportive of injured members of their pod" & ControlChars.CrLf &
				" - In captivity, the common dolphin has successfully been hybridized with the " &
					"bottlenose dolphin. Unlike other hybrid species such as mules, " &
					"these hybrids are fertile" & ControlChars.CrLf &
				" - Common dolphins are very playful, and have been observed somersaulting, pith piling" &
					"breaching, and bow riding among other activities", '---------------------------------------->End Common Dolphin
		" - The public are most familiar with these dolphins thanks to their exposure " &
					"in marine parks, dolphinaria, movies, and tv programs" & ControlChars.CrLf &
				" - Out of all the species of beaked dolphins, bottlenose dolphins are the largest" & ControlChars.CrLf &
				" - Their necks are more flexible than other dolphins. This is because five of " &
					"the seven vertebrae in their necks are not fused together" & ControlChars.CrLf &
				" - Instead of chewing their food, these dolphins swallow it whole" & ControlChars.CrLf &
				" - These dolphins can recognize their own reflection in a " &
					"mirror, learn some basic math propertiesm mimicry, use artificial languages, and and can catagorize objects" & ControlChars.CrLf &
				" - Dolphins can be trained for military uses such as detecting undersea mines or " &
					"enemy divers. They also can help fishermen without training by " &
					"driving fish towards their nets and eating the ones that escape.", '------------------------>End Bottlenose Dolphin
		" - Despite being classified as toothed whales, Risso's dolphins possess no" &
				" teeth in their upper jaw" & ControlChars.CrLf &
			" - One Risso's dolphin, named Pelorus Jack, was famous for escorting ships through " &
				"the French Pass, which is located between D'Urville Island and South Island, " &
				"New Zealand " & ControlChars.CrLf &
			" - It is theorized that the dolphin's scientific name of grampus comes from an " &
				"amalagation of the words 'grand poisson' or 'grandis piscis' - French and Latin " &
				"for 'big fish' respectively" & ControlChars.CrLf &
			" - The dolphins are highly social and have been observed interacting with other " &
				"species of cetaceans, including gray whales, pilot whales, and bottlenose dolphins", '---------->End Risso's Dolphin
		" -  Due to a combination of being rarely spotted and most of the information" &
				"coming from stranded individuals and skeletons, little is known about this animal" & ControlChars.CrLf &
			"- They actively avoid boats and other human crafts" & ControlChars.CrLf &
			" - A large population appears to live near the archipelago of Tierra del Fuego, due " &
				"to the high concentration of skeletons that has been found there" & ControlChars.CrLf &
			" - Although they are rarely spotted at the open sea, they are the second most commonly " &
				"stranded cetacean in Tierra del Fuego", '------------------------------------------------------>End Spectacled Porpoise
		" - In the wild, these animals can live for 36 to 40 years " & ControlChars.CrLf &
			" - On average the Pacific white-sided dolphins travel in schools that number between " &
				"ten and one hundred individuals. However, groups that number in the thousands have " &
				"also been observed" & ControlChars.CrLf &
			" - Pacific white-sided dolphins can hold their breath for up to six minutes " & ControlChars.CrLf &
			" - These dolphins can swim at speeds of up to 55 km/h (34.2 mph)" & ControlChars.CrLf &
			" - It has been proposed to reclassify them into a new genus, which has tenitavely been named Sagmatias" & ControlChars.CrLf &
			" - Each individual of this species has around sixty teeth" & ControlChars.CrLf &
			" - The stripe on the sides of the Pacific white-sided dolphin is sometimes referred to as " &
				"suspenders", '--------------------------------------------------------------------------------->End Pacific White-Sided Dolphin
		" - The first confirmed gray whale in the southern hemisphere was sighted off " &
				"the coast of Nambia in May and June of 2013" & ControlChars.CrLf &
			" - A gray whale holds the record for the longest round trip migration of any " &
				"mammal, covering a distance of over 22,000 km in the Pacific Ocean" & ControlChars.CrLf &
			"It's estimated that the habitat range of this animal will expand as " &
				"more migrations take place" & ControlChars.CrLf &
			" - Because of their size, gray whales are rarely held in captivity" & ControlChars.CrLf &
			" - The largest animal ever held in captivity was a gray whale named JJ. " &
				"She grew to be 9.4 m (31 ft) and weighed 8,700 kg (19,200 lb) before being" &
				"released back into the wild", '---------------------------------------------------------------->End Gray Whale
		" - Their calls are very high-pitched and easy to hear" & ControlChars.CrLf &
			" - The protruding lump at the forefront of their head houses an " &
					"organ used for echolocation known as the melon" & ControlChars.CrLf &
			" - Belugas are highly social. In the winter time they live in groups " &
					"of ten. However in the summer, hundreds of thousands gather " &
					"in groups in shallow costal areas" & ControlChars.CrLf &
			" - Belugas are excellent divers, and can reach depths of up to 1000 m (3280 ft) below the surface" & ControlChars.CrLf &
			" - Due to their unique coloring and expressiveness, these whales are " &
					"common sights at aquariums, wild life parks, and dolphinariums" &
			" - The English name, beluga, comes from the Russian word belukha, " &
					"which in and of itself is derived from the word belyj, meaning white." & ControlChars.CrLf &
			" - Unlike other cetaceans, belugas shed their skin each summer" & ControlChars.CrLf &
			" - Despite having teeth, belugas swallow their food whole rather than chewing it", '--------------->End Beluga Whale
		" - This whale holds the distinction of being the largest living species on the planet" & ControlChars.CrLf &
			" - Only one subspecies has a second name; B. m. brevicauda, otherwise known as the pygmy blue whale" & ControlChars.CrLf &
			" - Blue whales were almost wiped out due to whaling. The International Whaling Commission " &
					"estimates that around 382,595 whales were caught between 1868 and 1978 " & ControlChars.CrLf &
			" - The largest heart from a blue whale weight 108kg (397 lbs), and was the size of a small car" & ControlChars.CrLf &
			" - Their toungue can weigh as much as an elephant" & ControlChars.CrLf &
			" - Orcas are the only animal recorded attacking a pod of blue whales" & ControlChars.CrLf &
			" - The spray from the blowholes can reach heights of up to 9-12 m (30-40 ft)" & ControlChars.CrLf &
			" - Scientists use earwax plugs to determine how old blue whales are." & ControlChars.CrLf &
			" - The oldest blue whale on record was an incredible 110 years old. On average, however " &
				"the whales live for about 80 to 90 years", '--------------------------------------------------->End Blue Whale
		" - The first description of a minke whale was by the Danish naturalist Otto " &
				"Fabricus in 1780. He misclassified it as Balaena rostrata, or the northern " &
				"bottlenose whale" & ControlChars.CrLf &
			" - The minke whale's name possibly comes from a partial translation of the Norwegian word minkehval." & ControlChars.CrLf &
			" - Of the two species of minke whales, the common mike whale is further divided into three subspecies: " &
				"the North Atlantic minke whale, the North Pacific minke whale, and the dwarf minke whale" & ControlChars.CrLf &
			" - It has been confirmed that southern minke whales sometimes migrate to Arctic waters" & ControlChars.CrLf &
			" - Both species of minke whales are capable of breeding with each other. At least two hybrid minke whales " &
				"have been discovered in the wild" & ControlChars.CrLf &
			" - Minke whales are the second smallest baleen whales in the world" & ControlChars.CrLf &
			" - The average lifespan of the animal is anywhere from 30 to 50 years" & ControlChars.CrLf &
			" - A minke whale's brain has 12.8 billion neocortical neurons and 98.2 billion neocortical gila", '->End Minke Whale
		" - In olden days sailors would mistake narwhals for a variety of creatures, including mermaids" & ControlChars.CrLf &
			" - Unlike other cetaceans, the neck vertebrae of narwhals is jointed rather than fused together" & ControlChars.CrLf &
			" - Their tusk is not a tusk like that of an elephant. Instead, it is an elongated canine tooth" & ControlChars.CrLf &
			" - The name narwhal comes from the Old Norse word nar, meaning corpse." & ControlChars.CrLf &
			" - Narwhals are closely related to belugas, and are able to interbreed. At least one hybrid's skeleton has " &
				"been discovered, and many more could exist in the wild" & ControlChars.CrLf &
			" - Males can sometimes grow two tusks. Even rare is a two tusked female " &
				"of which only one specimen has ever been discovered",'----------------------------------------->End Narwhal
		" - Much like coalecanths, this shark has several primitive features and is " &
				"called a living fossil" & ControlChars.CrLf &
			" - When hunting, the shark moves similarly to a snake, including the characteristic " &
				"lunging motion they make when striking" & ControlChars.CrLf &
			" - Frilled sharks are ovioparious, meaning that the eggs are hatched inside the mother " &
				"before the animal gives birth to the young" & ControlChars.CrLf &
			" - These sharks have the longest known gestation period of any vertebrate, clocking in at " &
				"three and a half years" & ControlChars.CrLf &
			" - Due to its unusual body shaped and many fins, the frilled shark has been compared by " &
				"some to a sea serpent" & ControlChars.CrLf &
			" - The sharks are not an economical catch, and thus are not fished for commercially. " &
				"Nonetheless, they sometimes are caught by fisheries trying to catch fish such as sea bream " &
				"or gnomefish", '------------------------------------------------------------------------------->End Frilled Shark
		" - The shark has the longest lifespan of any invertebrate. The oldest one " &
				"found was 392 years old, plus or minus 120 years. It's estimated that they can " &
				"live up to 500 years of age, however." & ControlChars.CrLf &
			" - The flesh of this shark contains high amounts of trimethylamine n-oxide, " &
				"which makes the meat toxic. Despite this, it is served as a delicacy in Iceland " &
				"known as kaestur hakarl" & ControlChars.CrLf &
			" - The greenland shark is heavily featured in Inuit legends and cosmologies. " & ControlChars.CrLf &
			" - Despite favoring cold waters, scientists documented the first wild greenland " &
				"shark in the Gulf of Mexico in 2013" & ControlChars.CrLf &
			" - They have an extremely slow swim speed, moving at around 1.22 km/h (.76 mph) on average" & ControlChars.CrLf &
			" - They has never been observed hunting, so it is uncertain how they capture their " &
				"faster prey such as seals. Scientists theorize that they may be ambush predators", '----------->End Greenland Shark
		" - They are commonly mistaken for their relative the common thresher, even in " &
				"scientific papers" & ControlChars.CrLf &
			" - Out of all three thresher species, the pelagic thresher is the smallest" & ControlChars.CrLf &
			" - They stun their prey by thrashing them with their tail, usually with whip-like strikes" & ControlChars.CrLf &
			" - The shark pups are extremely large, being up to almost 45% of the " &
				"length of the mother shark" & ControlChars.CrLf &
			" - Even though sharks lay eggs, female pelagic threshers display ovoviviparity. " &
				"This means that the eggs hatch inside the mother, and then she gives birth to" &
				"live young" & ControlChars.CrLf &
			" - Pelagic threshers like being clean. Despite eating small fish, they have a " &
				"mutualistic relationship with cleaner wrasses, and will visit them often to " &
				"rid themselves of dead skin and parasites", '-------------------------------------------------->End Pelagic Thresher Shark
		" - Nurse sharks have a slow and sedentary disposition. Despite this, they " &
				"they are the 4th most common shark to bite humans" & ControlChars.CrLf &
			" - They are able to tolerate scientific processes such as tagging, as well as capture " &
				"and life in captivity. This makes them a favorable candidate for research" & ControlChars.CrLf &
			" - The species' name is believed to be either a derivative of the Old English word hurse, " &
				"meaning sea-floor shark. However it could also come from the archaic word nusse, " &
				"meaning cat shark" & ControlChars.CrLf &
			" - Nurse sharks hunt by sucking in water and prey while traversing the bottom. " & ControlChars.CrLf &
			" - As a nocturnal animal, they hunt during the night. However, during the day these sharks " &
				"sometimes form large groups" & ControlChars.CrLf &
			" - Nurse sharks are one of the few species of sharks that can remain perfectly still", '------------>End Nurse Shark
		" - Of the ten extant species of hammerhead sharks, the great hammerhead " &
				"is the largest" & ControlChars.CrLf &
			" - It is inquisitive when encountering divers, but rarely attacks them" & ControlChars.CrLf &
			" - Hammerhead shark fisheries harvest this animal in great numbers due to netting " &
				"a large profit in Asian markets" & ControlChars.CrLf &
			" - The fin of the greater hammerhead is the main ingredient of shark fin soup" & ControlChars.CrLf &
			" - Hammerheads breed every two years. The litter of pups can be as large as " &
				"fifty-five individuals" & ControlChars.CrLf &
			" - Despite being an apex predator, yellow jack fish and pilot fish sometimes accompany " &
				"greater hammerheads. The shark does not eat them, and will even allow them to rub " &
				"against its skin to scrape off parasites", '---------------------------------------------------->End Greater Hammerhead Shark
		 " - Despite having up to half of shark attacks being attributed to it, " &
				"great whites are more curious of humans than afraid. Scientists belive that the bites " &
				"are done to see what a human is before releasing them" & ControlChars.CrLf &
			" - Great whites have over 300 teeth, but do not use them to chew their food. Instead, " &
				"they rip their prey into small pieces and swallow it whole" & ControlChars.CrLf &
			" - These animals are powerful swimmers, capable of reaching top speeds of 56 km/h (35 mph)" &
				"and depths of up to 1,200 m (3,900 ft)" & ControlChars.CrLf &
			" - Movies and novels, most famously Jaws, have created the public image of great whites " &
				"being ferocious man eaters. In reality, humans are not prey of the great white" & ControlChars.CrLf &
			" - The animal's bite can have a force of up to 18,218 newtons (4,095 lbf). That's enough force " &
				"to break a femur almost five times over", '----------------------------------------------------->End Great White Shark
		" - The species has a reputation as a garbage eater, due to the fact that several dead ones " &
				" - have been found with inedible man-made objects in their stomachs" & ControlChars.CrLf &
			" - Much like great white sharks, tiger sharks also have a reputation for attacking humans. Unlike " &
				" - their cousins, they tend to go in for multiple bites instead of taking one bite and then " &
				"swimming away" & ControlChars.CrLf &
			" - Humans harvest these sharks for their fins, skin, flesh, and livers. The fins are used for shark " &
				"fin soup, the flesh is eaten, and the livers - which contain high quantities of vitamin A - are " &
				"processed into vitamin oil" & ControlChars.CrLf &
			" - Tiger sharks have a big part in Hawaiian mythology, being known as a sacred na 'aumakua (ancestor " &
				"spirit). Several religious practices involve them", '------------------------------------------->End Tiger Shark
		" - The name of the animal comes from the Portugeuse and Spanish word for blanket or cloak" & ControlChars.CrLf &
			" - Manta rays have an average lifespan of 50 years " & ControlChars.CrLf &
			" - A group of mantas is called a squadron" & ControlChars.CrLf &
			" - Much like whales and dolphins, manta rays engage in breaching - the act of jumping out of the water. " & ControlChars.CrLf &
			" - When feeding, these fish are known to team up to create a cyclone-like trap for prey. " & ControlChars.CrLf &
			" - Manta rays have the largest brain to size ratio of all cold-blooded fish" & ControlChars.CrLf &
			" - Much like dolphins, primates, elephants, and humans; manta rays can recognize themselves in mirrors", '--------------------------------->End Giant Oceanic Manta Ray
		" - The smooth stingray is the largest of all stingrays" & ControlChars.CrLf &
			" - Although venemous, they do not do out of their way to attack humans unless " &
				"startled. The most famous, or infamous, incident of this type was the death " &
				"of Steve Irwin in 2006" & ControlChars.CrLf &
			" - Smooth stingrays are normally slow moving, but are capable of dashing forward " &
				"suddenly by flapping their pectoral fins" & ControlChars.CrLf &
			" - When threatened the stingray reacts by raising its tail in an arc over the back in " &
				"a manner similar to a scorpion" & ControlChars.CrLf &
			" - These rays are oftentimes captured accidentally by fisheries. They are usually " &
				"released after their tails are removed", '----------------------------------------------------->End Smooth Stingray
		 " - This type of ray serves as a host to several parasitic species" & ControlChars.CrLf &
			" - Due to being understudied, not much is known about the life of " &
					"this animal" & ControlChars.CrLf &
			" - Japanese eagle rays have seven rows of teeth in their mouths" & ControlChars.CrLf &
			" - Although only having moderate financial value, they are sometimes caught " &
				"for their meat and cartilage", '--------------------------------------------------------------->End Japanese Eagle Ray
		" - Although traditionally grouped as one species, there has been recent discussion to " &
				"split off the non-Atlantic populations into the ocellated eagle ray (A. ocellatus) and the " &
				"Pacific white-spotted eagle ray (A. laticeps)" & ControlChars.CrLf &
			" - Unlike other rays, spotted rays are usually seen alone rather than in groups" & ControlChars.CrLf &
			" - Like other rays, spotted rays engage in breaching. On at least two occasions, they have " &
				"accidentally jumped into boats" & ControlChars.CrLf &
			" - These rays are known to dig into the sand with their snouts, kicking up large clouds of " &
				"of dust and sand in the process" & ControlChars.CrLf &
			" - Due to their appearance, they are popular exhibits at aquariums", '----------------------------->End Spotted Ray
		" - Instead of eating the seagrass down to the roots, the green sea turtles only eat " &
				"the tips of the grass. This ensures the grass remains able to grow" & ControlChars.CrLf &
			" - The oldest green sea turtles can live up to 80 years in the wild" & ControlChars.CrLf &
			" - These animals can hold their breath for about five minutes during deep dives" & ControlChars.CrLf &
			" - Female green sea turtles lay about 100 eggs at a time" & ControlChars.CrLf &
			" - Green sea turtles are the largest species of hard-shelled turtles. They are also " &
				"the second largest of all sea turtles, dwarfed only by the leatherback sea turtle" & ControlChars.CrLf &
			" - No matter how far away they are, green sea turtles always return to the beach that they " &
				"hatched on" & ControlChars.CrLf &
			" - Despite being called the green sea turtle, nothing external on this animal is green. " &
				"Instead the name comes from the fact that their internal fat is green in color" & ControlChars.CrLf &
			" - A group of green sea turtles is called a bale", '----------------------------------------------->End Green Sea Turtle
		" - Leatherback sea turtles are larger than any other living species of turtle" & ControlChars.CrLf &
			" - They are the only modern sea turte to not have a hard shell, instead " &
				"possesing one that is covered by skin and oily flesh" & ControlChars.CrLf &
			" - Although primarily found in the warmer waters, leatherback sea turtles have been spotted " &
				"as far north as Alaska and Norway" & ControlChars.CrLf &
			" - Leatherback sea turtles are the fastest reptiles in the world, with a top speed of 35.28 km/h " &
				"(21.92 mph) according to the Guinness Book of World Records" & ControlChars.CrLf &
			" - Upon entering the water after hatching, males never leave the water again" & ControlChars.CrLf &
			" - These reptiles use a specialized blood vessel structure - called a countercurrent exchanger " &
				"- to maintain warm body temperatures, allowing them to survive in cold water " & ControlChars.CrLf &
			" - Leatherbacks can stay underwater for up to 85 minutes at a time, and can dive to depths " &
				"of 1,200 m (4,000 ft)", '---------------------------------------------------------------------->End Leatherback Sea Turtle
		" - Despite being known as the blue tang, these fish do not turn blue " &
				"until they are adults" & ControlChars.CrLf &
			" - When viewed under ultraviolet light, the fish appear green" & ControlChars.CrLf &
			" - Blue tangs can live for about 12 to 15 years in the wild " & ControlChars.CrLf &
			" - They are difficult for predators to swallow due to the flat shape of " &
				"the body and the sharp caudal spines" & ControlChars.CrLf &
			" - Blue tangs oftentimes congregate in cleaning stations, where they eat " &
				"algae off the skin from larger animals such as green turtles", '------------------------------->End Blue Tang
		" - Much like other tangs, yellow tangs are cleaner fish and will clean algae off " &
				"of other animals' bodies" & ControlChars.CrLf &
			" - In the wild these animals can live to be up to 30 years of age" & ControlChars.CrLf &
			" - Due to their bright colors, they are popular exhibits at aquariums" & ControlChars.CrLf &
			" - The Hawaiian name for the yellow tang, lau'ipala, means yellow ti leaf", '---------------------->End Yellow Tang
		" - This fish is an extremely popular exhibit in aquariums" & ControlChars.CrLf &
			" - After the release of the 2016 Disney/Pixar film Finding Dory, the sales of " &
				"regal tangs increased due to children wanting a pet that looked like Dory " & ControlChars.CrLf &
			" - Regal tangs are social creatures, and have been seen swimming with other species of " &
				"surgeonfish and tang" & ControlChars.CrLf &
			" - Males have been seen having sword fights with their caudaul spines to assert " &
				"dominance over one another " & ControlChars.CrLf &
			" - These fish have unusually long lifespans in the wild, with some living to be  " &
				"over thirty years " & ControlChars.CrLf &
			" - During spawning seasons, breeding groups can release up to 40,000 eggs at a time", '------------>End Regal Tang
		" - Juveniles of this species commonly staff cleaning stations and tend to many types of animals, " &
				"including predatory fish such as surgeonfishes and moray eels" & ControlChars.CrLf &
			" - Unlike other species of fish, French angelfish only take one mate" & ControlChars.CrLf &
			" - In some places, the fish are caught and eaten. However, their primary commercial value " &
				"is for the aquarium market" & ControlChars.CrLf &
			" - They tend to not form large schools, and instead stay in pairs with their mate", '-------------->End French Angelfish
		" - They were first described in 1772 by Dutch naturalist Pieter Boddaert" & ControlChars.CrLf &
			" - The royal angelfish was a major subject in zoological art during the " &
				"18th and 19th centuries" & ControlChars.CrLf &
			" - There are two morphs, or variants, of the fish, each occupying a different " &
				"part of the overall habitat. It is possible that they mate together and produce " &
				"hybrids of these variants along the border of their territories" & ControlChars.CrLf &
			" - They have been reported to live for up to 15 years" & ControlChars.CrLf &
			" - Royal angelfish are a popular addition to aquariums due to their bright colors " &
				"and the fact that they are a reef safe angelfish, meaning they don't eat coral", '------------->End Royal Angelfish
		 " - The species' common name comes from their bright facial colorations" & ControlChars.CrLf &
			" - Blueface angelfish are commonly mistaken with the queen angelfish and blue " &
				"angelfish due to their similar colorations" & ControlChars.CrLf &
			" - Much like other species of angelfish, the juvenile blueface angelfish appear to " &
				"belong to other species due to their drastically different colorations from that of " &
				"the adults", '--------------------------------------------------------------------------------->End Blueface Angelfish		
		" - The average lifespan of the flame angelfish is between 5 and 7 years" & ControlChars.CrLf &
			" - Populations that live around the Marquesas Islands do not have the black bars " &
				"on their sides" & ControlChars.CrLf &
			" - Most flame angelfish die without an apparent reason when they are older. Although " &
				"scientists are unsure why this occurs, they theorize that it is due to the fact that " &
				"these fish switch from eating algea to crustaceans and shrimp when transitioning from " &
				"the juvenile stage to the adult stage" & ControlChars.CrLf &
			" - Flame angelfish are very hardy in captivity, able to survive and breed with little trouble" & ControlChars.CrLf &
			" - All flame angelfish hatch as females. As they mature, the more successful and dominant " &
				"fish undergo a hormonal conversion that turns them into males ", '----------------------------->End Flame Angelfish
		" - Due to their similar appearances, as well as both being known as blue angelfish, " &
				"the queen angelfish (Holacanthus ciliaris) is oftentimes confused with the Bermuda blue " &
				"angelfish (Holocanthus bermudensis)" & ControlChars.CrLf &
			" - The bright colors of the fish, especially as a juvenile, help camoflauge them from predators" &
				"that lurk on the reef" & "\n" &
			" - As the species are normally found in pairs, it is believed that the queen angelfish are " &
				"monogamous and only take one mate" & ControlChars.CrLf &
			" - As juveniles, they staff cleaner stations and eat dead skin and parasites off of larger fish" & ControlChars.CrLf &
			" - During their spawning season, a female queen angelfish can release up to ten million eggs", '--->End Queen Angelfish
		" - In captivity they can live up to ten years" & ControlChars.CrLf &
			" - Visually, these fish are quite similar to the spot-naped butterflyfish, the black-wedged " &
				"butterflyfish, and the Pacific double-saddle butterflyfish. Because of this, they " &
				"sometimes are mistaken for one another" & ControlChars.CrLf &
			" - Although currently considered a subgenus, scientists have suggested that Rabdophorus should be " &
				"reclassified as a genus. This would make the lined butterflyfish's new scientific name " &
				"Rabdophorus lineolatus" & ControlChars.CrLf &
			" - Lined butterflyfish are highly territorial, and are usually found alone or in a pair" & ControlChars.CrLf &
			" - These fish spawn during the new moon" & ControlChars.CrLf &
			" - Lined butterflyfish mate for life", '----------------------------------------------------------->End Lined Butterflyfish
		" - Although not a common sight at cleaning stations, banded butterflyfish " &
				"sometimes act as cleaner fish for various types of sturgeon, grunt, and parrot " &
				"fishes" & ControlChars.CrLf &
			" - Banded butterflyfish usually live alone or in a pair. Sometimes, however, " &
				"individuals form shoals of up to twenty members" & ControlChars.CrLf &
			" - Like other types of butterflyfish, the banded butterflyfish mates for life", '------------------>End Banded Butterflyfish
		" - Due to its bright colors, docile nature, and disease resistance, it is " &
			"a popular addition to aquariums" & ControlChars.CrLf &
			" - Some populations in the western Indian ocean have been hypothesized to be " &
				"a different species tentatively named nemateleotris exquisita." &
				" However, more research is needed to prove or disprove this" & ControlChars.CrLf &
			" - They prolifically leap out of the water if frightened, as well as hide " &
				"in rocks and small bits of coral rubble" & ControlChars.CrLf &
			" - They are solitary creatures that don’t get along with members of their own " &
				"species. Generally a male and a female will get along better" &
				"than two male fish or two female fish will" & ControlChars.CrLf &
			" - Thanks to the ornamental fish trade, they are highly threatened by humans", '------------------->End Elegant Firefish
		" - It is one of only two species of vertebrates that gains their bright blue " &
				"coloring at the celular level - the other being the picturesque dragonet" & ControlChars.CrLf &
			" - The common name of the fish refers to their bright colors that appear similar " &
				"to the robes of Imperial Chinese buearucrats" & ControlChars.CrLf &
			" - Although sometimes called the psychidelic mandarin, this name also refers to another " &
				"species of mandarinfish, Synchiropus picturatus" & ControlChars.CrLf &
			" - The most common variety of mandarinfish, the green mandarin, is described above. " &
				"However, other varieties exist that are red and black, or grey with colored spots" & ControlChars.CrLf &
			" - Despite their popularity in aquariums due to their colors, mandarinfish are difficult to " &
				"care for and oftentimes are not included in displays" & ControlChars.CrLf &
			" - Instead of being covered in scales, mandarinfish instead is covered in a thick coating of " &
				"toxic mucus to protect themselves from the elements and predators. This mucus is reportedly " &
				"extremely smelly", '--------------------------------------------------------------------------->End Mandarinfish	
		" - Although not naturally a resident of the Mediterranean, the Indo-Pacific " &
				"sailfish ventured into those waters starting in 1869, due to the opening " &
				"of the Suez Canal" & ControlChars.CrLf &
			" - In the past two sailfish species - the Indo-Pacific sailfish and the Atlantic " &
				"saifish - have been recognized. However, scientists have found no notable differences " &
				"between the two, and most only recognize a single species" & ControlChars.CrLf &
			" - They have a top sprint speed of 10-15 meters per second" & ControlChars.CrLf &
			" - Sailfish use their long bill-shaped mout during hunts. They either tap schooling " &
				"fish or attack them with large slashing motions" & ControlChars.CrLf &
			" - They hunt in groups, of up to 70 individuals, but each fish attacks on their own", '-------------------------------------------------------->End Indo-Pacific Sailfish
		"  - They are the largest fish in the southern ocean, and plays the same " &
				"ecological role that sharks play in other ecosystems" & ControlChars.CrLf &
			"  - Antarctic toothfish are one of five nototheniod species that are neutrally buoyant, " &
				"allowing them to spend time above the bottom without expending " &
				" extra energy" & ControlChars.CrLf &
			"  - The oldest recorded specimen of this species was 48 years old" & ControlChars.CrLf &
			"  - Like other Antarctic fish, their body produces antifreeze " &
				"glycoproteins which inhibits the growth of ice crystals. This " &
				"allows the fish to survive in subzero water" & ControlChars.CrLf &
			"  - The toothfish lacks a swim bladder, and instead controls its " &
				"buoyancy with lipids or fats" & ControlChars.CrLf &
			"  - Despite being caught commonly for food, little is known about " &
				"the fish. Toothfish eggs or larvae have never been found. " & ControlChars.CrLf &
				"Small juveniles have been found in other regions but never in " &
				"the Ross Sea, where most toothfish fishing takes place", '------------------------------------->End Antarctic Toothfish
		" - The origins of the name are unknown, but it is possibly named after the hero of " &
				"one of the many James Child ballads that were popular England and Scotland" & ControlChars.CrLf &
			" - According to legend, the dark spot on the side of the fish is the thumbprint of St. Peter" & ControlChars.CrLf &
			" - John Dory's are oftentimes considered to be one of the ugliest fish in the world" & ControlChars.CrLf &
			" - On average, they live for about 12 years in the wild" & ControlChars.CrLf &
			" - Despite being ugly, John Dory's are quite tasty, and considered by many to be a very " &
				"delicious fish", '----------------------------------------------------------------------------->End John Dory
		" - These fish are critically endangered to the point where in 1998, it was estimated " &
				"that only 500 survived in the wild" & ControlChars.CrLf &
			" - The first fish of this kind was discovered in December of 1938 by Hendrik Goosenm, " &
				"the captain of a fishing trawler in South Africa" & ControlChars.CrLf &
			" - The coelacanth's scientific genus, Latimeria, is named after Marjorie Courtenay-Latimer. " &
				"She was a curator at the East London Museum in South Africa, and was responsible for " &
				"helping bring attention to the discovery of the coelacanth" & ControlChars.CrLf &
			" - Despite the appearance of its name, the word coelacanth is actually " &
				"pronounced 'SEEL-uh-kanth' rather than 'COAL-uh-kanth'" & ControlChars.CrLf &
			" - Before its rediscover in 1938, it was assumed that the coelacanth went " &
				"extinct some 65 million years ago" & ControlChars.CrLf &
			" - Coelacanths have extremely small brains - only 1.5% of the cranial cavity " &
				"is taken up by the organ. The rest is filled with fat" & ControlChars.CrLf &
			" - Due to many bizzare characteristics, such as lobed fins that move in " &
				"alternating patterns, a hinged jaw, an electrosensory organ in its snout, and " &
				"an oil-filled tube called a notochord - which serves as the coelacanth's " &
				"backbone - it is unknown where exactly this fish fits into " &
				"the evolutionary record", '-------------------------------------------------------------------->End Coelacanth
			" - Despite being most commonly depicted as orange, white, and black the " &
				"common clownfish can come in other colors such as black with white bands, " &
				"and reddish brown with white bands. The coloration depends on where they " &
				"are found" & ControlChars.CrLf &
			" - Clownfish form symbiotic relationships with anemones, and are immune to " &
				"their toxins" & ControlChars.CrLf &
			" - All clownfish are born male, but can undergo hormonal changes to become female" & ControlChars.CrLf &
			" - After the premire of Finding Nemo, the sales of clownfish tripled, leading to the " &
				"coining of the term the Nemo Effect" & ControlChars.CrLf &
			" - Due to their similar colorations, the common clownfish is oftentimes confused with the " &
				"orange clownfish (Amphiprion percula)", '------------------------------------------------------>End Common Clownfish
		" - Red lionfish eggs hatch in 36 hours " & ControlChars.CrLf &
			" - Like other lionfish, red lionfish posses venomous spines that is uses for defense" & ControlChars.CrLf &
			" - Red lionfish, along with their cousin the common lionfish, are a highly invasive species in the " &
				"eastern United States and in the Carribean. Of the two, the red lionfish makes up the majority of " &
				"the population" & ControlChars.CrLf &
			" - Despite there being an abundance of large fish and sharks that should be able to eat them in their " &
				"invaded habitat, the red lionfish is virtually unpreyed upon in the eastern hemisphere" & ControlChars.CrLf &
			" - These fish live solitary lives, and only form groups during mating season" & ControlChars.CrLf &
			" - Although they are venemous, red lionfish can safely be eaten", '-------------------------------->End Red Lionfish
		" - The name mahi mahi means 'very strong' in Hawai'ian" & ControlChars.CrLf &
			" - They are a popular fish both for sport fishing and for cooking" & ControlChars.CrLf &
			" - Despite being called a dolphinfish,  mahi mahi are not related to " &
				"the marine mammal" & ControlChars.CrLf &
			" - Mahi mahi can swim at speeds of up to 92 km/h (57.5 mph)" & ControlChars.CrLf &
			" - Although colorful under water, mahi mahi appear silvery after they are " &
				"removed from the ocean", '--------------------------------------------------------------------->End Mahi Mahi
		" - All humphead wrasses are born as females, with some members of the population transitioning " &
				"into a male at the age of 9 " & ControlChars.CrLf &
			" - Females live slightly longer than males, with average lifespans ranging from 50 to 45 " &
				"years respectively " & ControlChars.CrLf &
			" - Humphead wrasses have been observed cooperating with other species to hunt, including " &
				"coral groupers and stingrays " & ControlChars.CrLf &
			" - These fish are usually seen in pairs, but sometimes are seen in groups of up to " &
				"seven individuals" & ControlChars.CrLf &
			" - Humphead wrasses are immune to the poisonous crown-of-thorns starfish", '----------------------->End Humphead Wrasse
		" - Sheepshead wrasse are hermaphrodites, with some individuals transitioning from " &
				"female to male later in life" & ControlChars.CrLf &
			" - The first recorded footage of a sheepshead wrasse undergoing the sexual transition was " &
				"captured in 2017 by a crew from BBC Earth" & ControlChars.CrLf &
			" - A Japanese diver and caretaker of an underwater Shinot Shrine, Hiroyuki Arakawa, has " &
				"developed a thirty year long relationship with a sheepshead wrasse named Yoriko. " &
				"Yoriko lives near the shrine and comes swimming when Arakawa rings a bell located on " &
				"the shrine" & ControlChars.CrLf &
			" - Sheepshead wrasse are one of the largest species of wrasse in the world", '--------------------->End SHeepshead Wrasse
		" - The ocean sunfish are one of the heaviest bony fishes in the world" & ControlChars.CrLf &
			" - When their dorsal and ventral fins are fully extended, ocean sunfish can be as tall " &
				"as they are long" & ControlChars.CrLf &
			" - Females of this species can produce up to three-hundred million eggs at a time" & ControlChars.CrLf &
			" - Although not frequently eaten as food, the ocean sunfish is considered a delicacy in some " &
				"parts of Asia" & ControlChars.CrLf &
			" - The genus and species of this fish, mola, comes from the Latin word for millstone. This " &
				"alludes to the round, grey body and stone-like texture that the animal appears to have" & ControlChars.CrLf &
			" - Ocean sunfish like to sunbathe at the surface of the sea", '------------------------------------>End Ocean Sunfish
		" - These fish lives for about 4 years in the wild" & ControlChars.CrLf &
			" - Although sometimes captured for the aquarium trade, the " &
				"hold little economic value and is usually left in the wild" & ControlChars.CrLf &
			" - It is one of the three most abundant fish species in the northern reaches" &
				"of the Adriatic Sea", '------------------------------------------------------------------------>End Striped Goby
		" - Fire gobies are monogamous" & ControlChars.CrLf &
			" - While adults live alone or with their mates, juveniles live in small groups" & ControlChars.CrLf &
			" - Although normally a calm fish when kept in captivity, fire gobies have been " &
				"known to jump out of their aquarium homes if they are stress" & ControlChars.CrLf &
			" - Due to having a swim bladder, fire gobies can float in one location for long periods " &
				"of time without expending lots of energy" & ControlChars.CrLf &
			" - These fish are quite popular in aquariums", '--------------------------------------------------->End Fire Goby
		" - In the past, this fish and another species of fish, the Pacific Bluefin Tuna, " &
				"were considered to be one species known as the northern bluefin tuna" & ControlChars.CrLf &
			" - Bluefin tuna are prized ingrediants for sushi and sashimi" & ControlChars.CrLf &
			" - Due to its popularity as a food item, the Atlantic bluefin tuna is severely overfished " &
				"to the point where in some areas it has been threatened with extinction" & ControlChars.CrLf &
			" - Bluefin tuna can live up to 40 years in the wild" & ControlChars.CrLf &
			" - Out of all the species of bony fish, the Atlantic bluefin tuna has the sharpest vision" & ControlChars.CrLf &
			" - The largest specimen ever captured was 3.7 m (12 ft) long and weighed a whopping " &
				"679 kg (1497 lbs)", '-------------------------------------------------------------------------->End Atlantic Bluefin Tuna
		" - Due to the species name albacares, the yellowfin tuna is sometimes confused with " &
				"the related albacore tuna" & ControlChars.CrLf &
			" - Yellowfin tuna has a top speed of 80.5 km/h (50 mph)" & ControlChars.CrLf &
			" - Unlike most fish, yellowfin tunas are warm-blooded" & ControlChars.CrLf &
			" - This fish is oftentimes used for sashimi and other raw fish dishes" & ControlChars.CrLf &
			" - Despite having many predators, the biggest threat to the yellowfin tuna " &
				"is overfishing by humans" & ControlChars.CrLf &
			" - Aside from forming large schools of their own species, this fish will oftentimes" &
				"form schools with other tuna species", '------------------------------------------------------->>End Yellowfin Tuna		
		" - The names of both the genus and the species is shared with an Ancient Greek " &
				"mythological creatue with the head of a horse and the body of a fish" & ControlChars.CrLf &
			" - Despite generally being a saltwater fish, colonies of this animal have been discovered " &
				"in the River Thames" & ControlChars.CrLf &
			" - Although not fished for commercially, the short-snouoted seahorse is often caught " &
				"accidentally" & ControlChars.CrLf &
			" - Seahorse tails are prehensile, and are used to anchor the animal to plants" & ControlChars.CrLf &
			" - Curiously, although the species displays ovoviviparity, it is the males who go through " &
				"pregnancy and birth rather than the female" & ControlChars.CrLf &
			" - Short-snouted seahorses do not possess teeth or stomachs", '------------------------------------>End Short-Snouted Seahorse
		" - The state of South Australia uses it as a symbol of their focus on local marine " &
				"conservation efforts" & ControlChars.CrLf &
			" - Leafy sea dragons disguise themselves as floating pieces of seaweed. Their camoflauge is " & ControlChars.CrLf &
				"so realistic that neither prey nor predators recognize them as a living animal" & ControlChars.CrLf &
			" - Unlike their cousins the sea horses, the males do not carry the eggs in a pouch. " &
				"Instead they are affixed to the underside of their tails" & ControlChars.CrLf &
			" - Leafy seadragon eggs are bright pink" & ControlChars.CrLf &
			" - Surprisingly, this animal appears to enjoy having their picture taken" & ControlChars.CrLf &
			" - Leafy seadragons are not good swimmers, and rely on their camoflauge for protection", '--------->End Leafy Seadragon
		" - This species of shrimp forms a symbiotic relationship with gobies - the " &
				"shrimp create the burrows while the goby watches for predators" & ControlChars.CrLf &
			" - The larger claw functions as a sonic stun gun - when snapped shut it generates " &
				"an air bubble with a sound pressure of 80 kPa that can reach speeds of 100 km/h " &
				"(62 mph) and a sound reaching 218 decibels. " & ControlChars.CrLf &
			" - The pressure generated from their natural stun gun can kill small fish" & ControlChars.CrLf &
			" - Pistol shrimps don't just use their acoustic abilities for hunting, they also use " &
				"it to commmunicate with other shrimp" & ControlChars.CrLf &
			" - These animals were the first discovered to produce light via sonoluminescence - " &
				"the emission of light via bubbles collapsing in liquid" & ControlChars.CrLf &
			" - The loud snapping noises produced by these shrimp can interfere with sonars. The " &
				"US used this to their advantage during World War Two by having submarines stay " &
				"within colonies of the animal to hide from the Japanese", '------------------------------------>End Pistol Shrimp
		" - Peacock mantis shrimp have incredible eyesight. With 16 cones in each eye, " &
				"the shrimp can see ten times more colors than a human, as well as ultraviolet and polarized " &
				"light " & ControlChars.CrLf &
			" - This species of shrimp has the fastest punch in the animal kingdom. It reaches speeds " &
				"equivalent to that of a .22 caliber bullet that has been fired from a gun, " & ControlChars.CrLf &
			" - Despite being popular in aquariums due to their bright coloring, some consider them " &
				"pests due to their tendancy to feed on other tank occupants, damaging the rocks and " &
				"coral, and even breaking the glass aquarium they are housed in" & ControlChars.CrLf &
			" - The shrimp's name comes from the bright colors present on the male's color and the fact " &
				"that they hold their front arms bent underneath the body like a praying mantis" & ControlChars.CrLf &
			" - Peacock mantis shrimp use a latch and spring mechanism to create the extreme speed of their " &
				"punch. A latch holds the arm in place while a muscle slowly contracts and compresses a saddle " &
				"shaped surface. Upon reaching full contraction/compression, the latch unhooks. The power of " &
				"muscle is released and bolstered by the natural spring formed by the u-shaped membrane, " &
				"causing the limb to fly forward at speeds of up to 23 m/s (45 mph in water)" & ControlChars.CrLf &
			" - Despite being called shrimp, peacock mantis shrimp aren't shrimp at all - the words " &
				"'mantis shrimp' describes an animal belonging to the order Stomatopoda, while the word " &
				"'shrimp' typically refers to an animal belonging to the order Decapoda", '--------------------->End Peacock Mantis Shrimp
		" - Due to the high presence of ciguatoxins in the flesh and liver, moray eels " &
				"are not safe for humans to consume" & ControlChars.CrLf &
			" - Depending on the standard measurement used, the giant moray is either the largest or " &
				"second-largest moray eel. If using body mass as the measurement, they are the largest. " &
				"When looking at largest by body length, however, they are dwarfed by their cousin the " &
				"slender giant moray" & ControlChars.CrLf &
			" - Giant morays sometimes engage in cooperative hunting with roving coral groupers. The eel hunting " &
				"causes prey to flee the reef where they are summarily eaten by the groupers, while the " &
				"grouper hunting above the same reef causes the prey to seek out hiding spots among the coral, " &
				"where they are met with the jaws of the moray" & ControlChars.CrLf &
			" - Despite eating fish, giant morays are frequent visitors to cleaner stations where small species of " &
				"wrasse clean out the inside of their mouth" & ControlChars.CrLf &
			" - Morays have been known to bite humans, but this is usually due to them feeling threatened, being " &
				"cornered, or simply being in the presence of food. Generally, they are not aggressive fish" & ControlChars.CrLf &
			" - Like all other moray eels, the giant moray has a second set of jaws in their throat that they use to " &
				"help drag prey into their gullets", '---------------------------------------------------------->End Giant Moray Eel
		" - Ribbon eels get their name for the long undulations of the body that form as they swim, " &
				"which is reminiscent of a rhythmic gymnasts' ribbon aparatus" & ControlChars.CrLf &
			" - All ribbon eels are born male, before transitioning to female later in life" &
			" - Unlike other species of eels, ribbon eels survive best in the wild. When living in " &
				"professionally maintained aquarium they only live for a few years. Those in the pet " &
				"trade fare worse, survivng only for a month or two. In the wild, by contrast, they can " &
				"live for an average of twenty years" & ControlChars.CrLf &
			" - Typically males of any species are territorial about their homes. Ribbon eel males, however " &
				"are happy to share their lairs with others of their species if necessary " &
			" - They act like hermits and rarely leave their homes. Some stay in the same burrow for months, " &
				"or even years before leaving " & ControlChars.CrLf &
			" - Once a female mates and lays eggs, they die within a month. This makes female ribbon eels a " &
				"rare sight" & ControlChars.CrLf &
			" - The ribbon eel is the only protandric moray eel" & ControlChars.CrLf &
			" - Currently , ribbon eels are classified in the family 'Muraenidae', the family of moray eels. " &
				"However, due to the distinctive features that are not shared with other morays, some have proposed " &
				"to reclassify them in their own family, tenatively called Rhinomuraenidae", '------------------>End Ribbon Eel
		" - The species name, pelecanoides, means 'pelican-like'" & ControlChars.CrLf &
			" - Although they primarily eat smaller animals, the stomach of pelican eels possess " &
				"elasticity to allow it to expand and hold much larger meals" & ControlChars.CrLf &
			" - Six different binomial names have been used to descripe the pelican eel. Despite " &
				"this, it's unknown if these names represent a single species or more than one " &
				"species of eel" & ControlChars.CrLf &
			" - Most pelican eel specimens are bycatches from deep sea fishing nets" & ControlChars.CrLf &
			" - The tail of pelican eels is so long that some specimens caught as bycatches " &
				"have literally had their tails tied into knots" & ControlChars.CrLf &
			" - Pelican eels do not have swim bladders or scales, both common characteristics of " &
				"most fish" & ControlChars.CrLf &
			" - The eyes of the pelican eel do not form images, instead they detect " &
				"faint traces of light ", '--------------------------------------------------------------------->End Pelican Eel
		" - Although normally not seen preying upon one another, red king crabs have " &
				"been known to turn cannibalistic on ocassion" & ControlChars.CrLf &
			" - Out of all the species of king crabs caught for their meat, the red king crab is " &
				"the most popular species to catch due to their size and delicious taste" & ControlChars.CrLf &
			" - Females may carry their fertilized eggs under their abdomen for up to a year before " &
				"they hatch" & ControlChars.CrLf &
			" - Despite being one of the most valuable crab species, commercial fisheries are well regulated " &
				"and do not pose a significant threat to the crustacean's population" & ControlChars.CrLf &
			" - Red king crabs are considered an invasive species in the Barents Sea. They were introduced " &
				"there for the purpose of setting up a fishery, but the lack of natural predators have " &
				"caused them to grow in size and habitated area each year", '----------------------------------->End Alaskan King Crab
		" -  Despite being called a 'yeti crab', these animals are actually a type of animal " &
				"known as a squat lobster" & ControlChars.CrLf &
			" - Yeti crabs were discovered in 2005 during a research dive in the South Pacific" & ControlChars.CrLf &
			" - The 'fur' covering these animal's claws are called setae" & ControlChars.CrLf &
			" - The yeti crab's genus, kiwa, is named after a shellfish goddess from Polynesian mythology." &
				"Their species name, hirsuta, is the Latin word for hairy" & ControlChars.CrLf &
			" - A yeti crab's hair contains supercolonies of filamentous bacteria. Scientists belive that " &
				"the crabs grow these before eating them as food" & ControlChars.CrLf &
			" - Yeti crabs do not have eyes, and instead use the hairs on their limbs to " &
				"sense their surroundings", '------------------------------------------------------------------->End Yeti Crab
		" - This species of lobster holds the title of being both the heaviest crustacean " &
				"and  the heaviest anthropod in the world" & ControlChars.CrLf &
			" - Although normally a blue-green to brown in color, mutations can cause them to have " &
				"different colors in life. Among these are: " & ControlChars.CrLf &
				"      > Blue, approximately one in two million " & ControlChars.CrLf &
				"      > Live red ones, approximately one in ten million" & ControlChars.CrLf &
				"      > Yellow, approximately one in thirty million " & ControlChars.CrLf &
				"      > Orange, approximately one in thirty million" & ControlChars.CrLf &
				"      > Split where the left and right sides are different colors, " &
						"one in fifty million" & ControlChars.CrLf &
				"      > Iridescent or white, approximately one in one hundred million" & ControlChars.CrLf &
			" - American lobsters have teeth in their stomach that chew the food" & ControlChars.CrLf &
			" - In the 17th and 18th centuries, lobster was considered a poor man's food. It was " &
				"used to feed prisoners and indentured servents, and was also used as lawn fertilizer" & ControlChars.CrLf &
			" - The lobster's claws are designed for different purposes. The larger one is stronger " &
				"and is used for crushing, while the smaller one is sharper and used for cutting " & ControlChars.CrLf &
			" - It is estimated that the populations of lobsters around Maine get anywhere from 35-55% " &
				"of their calories from herring and other bait from lobster traps" & ControlChars.CrLf &
			" - Surprisingly, the number of lobsters caught in traps make up a small percentage - " &
				"about 6% - of those that enter the traps to feast on the bait inside", '----------------------->End American Lobster
		" - Although it may look like one, Portuguese man o' wars are not jellyfish. " &
				"They are actually siphonophores - an organism made of colonies that contain hundreds " &
				"upon hundreds of genetically identical miniature creatures" & ControlChars.CrLf &
			" - The name of the animal is a reference to the Portuguese man o' war ships" & ControlChars.CrLf &
			" - Most man o' wars are of a decent size, with the tentacles averaging around 9.1 m (30 ft). " &
				"The largest one found, however, had tentacles that measured in at a whopping 50.3 m (165 ft)" & ControlChars.CrLf &
			" - A group of Portuguese man o' wars is called a legion" & ControlChars.CrLf &
			" - Although fatalities are rare, the venom from the Portuguese man o' war " & ControlChars.CrLf &
			" - Most of these sinophores have a fish known as the Portuguese man o' war fish living " &
				"between their tentacles as a way to stay safe from predators", '------>End Portuguese Man O' War
		" - Due to the fact that they are not in the class Scyphozoa, flower hat jellies are " &
				"not actually 'true' jellyfish" & ControlChars.CrLf &
			" - A flower hat jellies' venom is usually not fatal, there has only been a single fatality " &
				"ever recorded" & ControlChars.CrLf &
			" - Until 2014, scientists were unable to locate any juvenile flower hat jellies in the wild " &
				"or raise them in captivity" & ControlChars.CrLf &
			" - A group of flower hat jellies is called a bloom" & ControlChars.CrLf &
			" - Flower hat jellies have an average lifespan of four to six months", '--------------------------->End Flower Hat Jelly
		" - Crystal jellyfish can expand their mouths to eat prey up to half their size" & ControlChars.CrLf &
			" - The jellyfish contains two proteins - aequorin and green fluoresent protein (GFP) - that " &
				"were first isolated and studied by Osamu Shimomura who, along with his collegues, won the " &
				"Nobel Prize in Chemistry for their work" & ControlChars.CrLf &
			" - The aequorin and GFP this animl produces is used in laboratory, clinical, and " &
				"molecular research" & ControlChars.CrLf &
			" - In captivity these jellyfish lives on average for about two years" & ControlChars.CrLf &
			" - Although native to the Pacific, a single specimen was found in the Moray Firth, an inlet of the " &
				"North Sea that is near Inverness, Scotland", '------------------------------------------------->End Crystal Jellyfish
		" - The black sea nettle is the largest invertebrate to be described in the 20th " &
				"century" & ControlChars.CrLf &
			" - Black sea nettles are rarely sighted in the wild. However, when they do appear it is " &
				"often in large swarms" & ControlChars.CrLf &
			" - The stinging sensation caused by this animal's venom can last for upwards of forty " &
				"minutes" & ControlChars.CrLf &
			" - Black sea nettles are named after the stinging nettle - a plant covered with fine " &
				"stinging hair-like filaments and a mixture of chemicals that cause contact dermatitis" & ControlChars.CrLf &
			" - Little is known about this animal due to the fact that they are rarely observed in the wild, and " &
				"difficult to raise in captivity", '------------------------------------------------------------>End Black Sea Nettle
		" - This animal is capable of reverting to a sexually immature polyp after having " &
				"reached sexual maturity, making it biologically immortal" & ControlChars.CrLf &
			" - Although unable to die due to old age, these jellyfish aren't completely immortal. " &
				"The vast majority of them are killed by other animals for food or fall to diseases " &
				"in the medusa stage of their life cycle" & ControlChars.CrLf &
			" - Up until recently, this animal and another related jellyfish - turritosis rubra - were " &
				"believed to be the same species" & ControlChars.CrLf &
			" - The only scientist that has been able to keep a group of these jellyfish in captivity for " &
				"any great length of time is Shin Kubota from Kyoto University", '------------------------------>End Immortal Jellyfish
		" - This species of starfish have been introduced to the oceans around Tasmania, " &
				"where it has quickly become an invasive species" & "\n" &
			" - Despite usually not being a natural predator, lap experiments in Korea revealed that triton " &
				"snails prefer the taste of the Japanese common starfish to that of other seastars, " &
				"sea cucumbers, and sea urchins" & ControlChars.CrLf &
			" - Japanese common starfish is used in traditional Chinese medicine" & ControlChars.CrLf &
			" - Tasmania hosts sea star hunting days where people flock to the water to remove these " &
				"animals by hand - an effective method that is safe and more environmentally friendly then " &
				"the use of chemical agents", '----------------------------------------------------------------->End Japanese Common Starfish	
		" - Commom brittle stars use their spines and heavy calcification of the outer body " &
				"to prevent predators from eating them" & ControlChars.CrLf &
			" - These animals are slow moving, and thus tend to hide out in rocky crevices as protection" & ControlChars.CrLf &
			" - Although normally a white or grey color, common brittle stars have been seen sporting colors " &
				"ranging from green and yellow to orange, red, or purple" & ControlChars.CrLf &
			" - Although they naturally have five arms, these limbs are so fragile that they are often seen with " &
				"several broken off" & ControlChars.CrLf &
			" - In some cases, the population density of groups can be so high that over 2000 individuals occupy " &
				"a single square meter" & ControlChars.CrLf &
			" - Unlike other starfish, common brittle stars are extremely inflexible" & ControlChars.CrLf &
			" - These animals cna live for up to ten years in the wild", '-------------------------------------->End Common Brittle Star				
		" - On average this species of starfish have eleven arms, but sometimes will " &
				"naturally have either ten or twelve" & ControlChars.CrLf &
			" - In order to feed on mussels, the starfish will literally insert its own stomach into " &
				"the shell and digest the prey.. Upon finishing its meal, the starfish reswallows their " &
				"stomach and goes on their way " & ControlChars.CrLf &
			" - The reef starfish is a keystone species in their particular ecosystem by helping check the " &
				"population of mussels which would otherwise outgrow and outcompete other species" & ControlChars.CrLf &
			" - As juveniles they feed exclusively on a species of red algea called P. canaliculus" & ControlChars.CrLf &
			" - A group of reef starfish is called a constellation", '--------------------------------------------------->End Reef Starfish
		" - The name of the species, esculentus, means edible" & ControlChars.CrLf &
			" - Common sea urchins are the largest urchin to live in Norway" & ControlChars.CrLf &
			" - Despite being called the European edible sea urchin, this particular " &
				"species is not a favored choice for eating " & ControlChars.CrLf &
			" - The shell of these urchins is called a test" & ControlChars.CrLf &
			" - Common starfish are able to mate with a related species, the white sea urchin, " &
				"and form hybrids" '--------------------------------------------------------------------------->End Sea Urchin	
	}

	'***********************************************************************************************************************************************'

End Module
