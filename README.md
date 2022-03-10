# Mncrft
slightly Minecraft-themed turn-based strategy game-thing about gathering materials, making houses and defending said houses from zombies.

**This readme is subject to change, being incorrect, or containing unimplemented features. this is what I used to think up the game before putting it to code.
Once I finish the actual game part of Mncrft, I'll probably come back to this and remake it from the ground up, or turn on a wiki.**

```
Stat names, what they do,
            and how to increase them.
		
Energy      Allows you to make actions each day, most actions require energy.
            Increased by passing the day, daily energy can be increased by building Beds or Houses.

Defense     Defense is how many nightly zombies you can endure, endured zombies disappear in the day.
            Increased by Hiring Guards and Building Houses, Towers, and Guard Towers.
			
PerDef      Personal Defense (or PerDef if you don't have much time) is Defense that's added to your base 
	    depending on the kinds of weapons you happen to have in storage, I'm on the fence if I want to 
	    count all weapons in storage to PerDef, or only the best one.
			
Offense     Offense is how many nightly zombies you can kill, dead zombies won't count against Defense.
            Increased by making swords, hiring guards, and building Guard Towers


If Defense is lower than the amount of zombies, the zombies will break any remaining buildings, if there 
are no buildings and more than 10 zombies you will die, a good offense is not always the best defense.

I've decided to make it so zombies that make it past your defense and offense take away from your energy 
instead, if they make it go down to 0, it's game over, man.

you can take 10 hits from individual zombies, after that it's game over.
you can continue from a game over, unless you've selected hardcore, in that case you're done.

in hardcore, zombies come twice as fast.

at night 1 or 2 zombies will be spawned at first, but nights after that 1 or 2 zombies will be added to 
the night after the last. in hardcore, at first there will be 1 or 2 zombies but each night will add 
2 - 4 zombies.

If you have Energy when you pass the night your daily Energy will be added to it instead of replaced.

The player alone has 5 Offense, but no defense.


Material names, what they are, and how to obtain them/what they do

Wood            Material       Gathered from felling trees (4 - 20 per tree)

Stone           Material       From mining in caves (10 - 25 per mining trip) (at least wood pickaxe)
Coal            Material       From mining in caves (4 - 16 per mining trip) (at least wood pickaxe)
Iron Ore        Material       From mining in caves (6 - 20 per mining trip) (at least Stone pickaxe)
Gold Ore        Material       From mining in caves (4 - 10 per mining trip) (at least Stone pickaxe)
Diamond         Material       From mining in caves (0 - 2 per mining trip) (at least Iron pickaxe)

Wool            Material       From looking for sheep (1 - 2 per sheep) (0 - 4 sheep each search)

Crafting Table  Item           Made from 4 Wood, should be made after at least one house is up. 
                               (no, sorry crafting table.)

Villagers       Villager       Gathered from looking for Villages (1 - 4 per village, Villagers require 
			       beds), each villager needs a bed, you must evict a villager from it's bed 
			       before said bed can be dismantled, if Villager has a job, said villager 
			       must be fired before being evicted(if Villager is in a tower, the tower 
			       must be dismantled first before you can evict Villager). every villager 
			       (including hired villagers) gives 1 more daily energy.
							
Guard			Villager Job   Villagers with this job require a sword, there are 
							   Wood Guards(1 Offense, 2 Defense),
							   Stone Guards(2 Offense, 4 Defense), 
							   Iron Guards(6 Offense, 10 Defense), 
							   Gold Guards(7 Offense, 5 Defense), and 
							   Diamond guards(10 Offense, 20 Defense), 
							   each Guard requires it's respective sword.
							   
Lumberjack      Villager Job   Not only do axes decrease how much energy you need to cut wood, but these 
							   guys require axes too. 
							   Wood(2 Wood per day), 
							   Stone(4 Wood per day), 
							   Iron(8 Wood per day), 
							   Gold(6 Wood per day) and 
							   Diamond(16 Wood per day)
							  
Miner			Villager Job   These guys need pickaxes too! 
                                                           Wood(8 Stone, 2 Coal per day), 
							   Stone(12 Stone, 6 Coal, 1 Iron Ore per day),
							   Iron(16 Stone, 10 Coal, 4 Iron Ore, 
							   2 Gold Ore per day), 
							   Gold(14 Stone, 8 Coal, 2 Iron Ore, 
							   6 Gold Ore per day) and 
							   Diamond(20 Stone, 14 Coal, 6 Iron Ore, 
							   2 Gold Ore per day, 1 Diamond per day) 
							   pickaxes will do just fine!
							   
Smelter         Villager Job   Give these guys a Furnace, Coal and Ore, and they're goin'! smelts your 
			       mined ore (one type a day) each day using Coal. Requires a Furnace and 
			       Villager to hire, requires Coal and Ore to work.
						
Shepherd        Villager Job   These guys don't need any tools, just give him a stick and he's ready to 
			       go! Generates 1 wool each day.

Bed             Building       Requires a Crafting Table. Made with 3 Wood and 3 Wool, provides 5 more 
			       daily energy per bed.
							   
Houses          Building       Made with 10 Wood and 10 Stone, provides 4 to Defense stat and 2 more 
			       daily energy per House.

Tower           Building       Made with 30 Stone, provides 6 to Defense stat.

Guard Tower     Building       Made with 80 Stone, 1 Villager, and 1 Iron Sword, provides 10 to Defense 
			       stat and 5 to Offense stat.

Stick           Item           Made with 2 wood, crafts 4, crafting material.

Torch           Item           Makes 4 with 1 Coal and 1 Stick, used to reduce nightly zombie count by 5.


Buildings and Tools can be dismantled and Villagers can be fired to give 100% of their materials back, 
items cannot be dismantled.

what the Action is called, what they do or give, what they require (if anything), and Energy requirement

Collect Wood               Gives Wood                                             no axe = 10, 
										  Wood = 8, 
										  Iron = 5, 
										  Gold = 4, 
										  Diamond = 2

Mine in a cave             Stone and other ores  at least a Wood Pickaxe          Wood = 20, 
										  Stone = 18, 
										  Iron = 15, 
										  Gold = 14, 
										  Diamond = 10

Look for sheep             Gives Wool (1 - 2 per sheep) (0 - 6 sheep each search) 20

Look for a village         Gives Villagers       Open bed                         40

Craft                      Whatever you choose                                    0

Smelt                      Smelt ore             Furnace                          0

Place Torches              stop some(5) spawns   4 torches                        5


Tools, Weapons, Items and their attributes:

no sword      - 1 PerDef.
wooden sword  - 5 PerDef.
stone sword   - 8 PerDef.
iron sword    - 10 PerDef.
golden sword  - 12 PerDef.
diamond Sword - 15 PerDef.

no axe      - chopping wood takes 15E
wooden axe  - chopping wood takes 10E
stone axe   - chopping wood takes 8E
iron axe    - chopping wood takes 5E
golden axe  - chopping wood takes 4E
diamond axe - chopping wood takes 2E

no Pickaxe      - mining takes 0E as you can't mine without a pick.
wooden Pickaxe  - mining takes 20E
stone Pickaxe   - mining takes 18E
iron pickaxe    - mining takes 15E
golden pickaxe  - mining takes 14E
diamond pickaxe - mining takes 10E

MINECRAFT WIKI SAYS GOLD IS SLIGHTLY BETTER THAN WOOD?????
WHAT??????
OK, time to redo energy usage sheet then.
Don't want to nerf gold to the grave so i'll make it a slightly better stone.

no sword      - 1 PerDef.
wooden sword  - 5 PerDef.
stone sword   - 8 PerDef.
golden sword  - 10 PerDef.
iron sword    - 12 PerDef.
diamond Sword - 15 PerDef.

no axe      - chopping wood takes 15E
wooden axe  - chopping wood takes 10E
stone axe   - chopping wood takes 8E
golden axe  - chopping wood takes 6E
iron axe    - chopping wood takes 4E
diamond axe - chopping wood takes 2E

no Pickaxe      - mining takes 0E as you can't mine without a pick.
wooden Pickaxe  - mining takes 20E
stone Pickaxe   - mining takes 18E
golden pickaxe  - mining takes 16E
iron pickaxe    - mining takes 14E
diamond pickaxe - mining takes 10E
```
