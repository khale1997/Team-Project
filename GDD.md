Name: TEMP NAME- GalagaSurfers
Stakeholders:  
* Thavindu
* John McGuff
* Long Nguyen
* Kha Le
Overview
Concept: A hybrid 2d galaga clone/autorunner
Story: TBD
Setting: TBD
Audio: Flying, shooting, explosion, collision, enemy noises?, warning sound for boss, menu music, game music, menu select noises
Structure: 2D shoot game, increasing difficulty over time, power ups, timer, score, big flashy pew pew game
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
'[P]' - What do they do?
        

         
Shooter = |[s]|
            HP = 2
            Stay on top of the screen
            Moves side to side, like the player
            Shoots at the player intermittently (slower version of the player's projectile?)

Collider = ;[C];
    HP = 1
    Moves in a set path
    Damages in

Rock = [[[Dwayne]]]
        Hp = 5
        Moves down (slowly)
        Gets in the way by being BIG
        Destructible?
        
B0ss = {  []Thanatos[]   }
        Hp = 20 * boss spawn
        Every five? minutes (set amount of time) one spawns
        BIG boi sits at the top-middle of the screen (moves slowly?)
        LOTS of gun
        Shaped like the state of Ohio
        Blow him up for BIG score points

POWER UPS-

    Shield (p) = Takes ONE hit for the player
    Armor (a) = Repairs the player's hit points (Kill John Cena to get it)
    Weapon upgrades? (w+) = Modifies the player's weapon with new effects
