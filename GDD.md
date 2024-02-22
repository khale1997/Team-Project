Name: CODENAME- GalagaSurfers
Stakeholders:  
* Thavindu
* John McGuff
* Long Nguyen
* Kha Le
Overview
Concept: A hybrid 2d galaga clone and an autorunner in the same vein as some mobile games like Subway Surfers on the windows platform.
Story: TBD
Setting: TBD
Structure: The game takes place on a 2D plane with players avoiding enemies and moving forward for as long as they can until something destroys them. The game continues to increase in difficulty
by spawning more and different kinds of enemies until the game ends with the player's death. As the game continues, the player gains score based on time survived and enemies destroyed. The goal of 
the game is to simply get as high of a score as you can before you inevitably lose.

Playermovement 
|   |
      |
  |
Player moves left to right at the bottom of the screen
<--<^>-->
Player shoots automatically
Shots go in a straight line up accompanied by a sound effect

Player has MAXIMUM 5 hits  + + + + +

Enemies can come in from the top
Enemies have different spawn rates which increase as time goes on, except for the B0ss
Enemies can drop powerups
'[E]' - What do they do?
        


Collider = ;[C];
    HP = 1
    Moves in a set path
    Damages in

Rock = [[[Dwayne]]]
        Hp = 5
        Moves down (slowly)
        Gets in the way by being BIG
        Destructible?

Audio: Flying, shooting, explosion, collision, enemy noises?, warning sound for boss, menu music, game music, menu select noises

User Interface: Main menu, health indicator, timer, score, game over screen

Features if time permits...     
         
Shooter = |[s]|
            HP = 2
            Stay on top of the screen
            Moves side to side, like the player
            Shoots at the player intermittently (slower version of the player's projectile?)
        
B0ss = {  []B[]   }
        Hp = 20 * boss spawn
        Every five? minutes (set amount of time) one spawns
        BIG boi sits at the top-middle of the screen (moves slowly?)
        LOTS of gun
        Shaped like the state of Ohio
        Blow him up for BIG score points

POWER UPS (needs accompanying audio and user interface!)-

    Shield (p) = Takes ONE hit for the player
    Armor (a) = Repairs the player's hit points (Kill John Cena to get it)
    Weapon upgrades? (w+) = Modifies the player's weapon with new effects
