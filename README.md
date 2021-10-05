# Game Basic Information #
## Summary ##

Life is tough for a Deep Space Delivery Man. Try to reach your destination as your ship gets bombarded by asteroids, your computer is flooded with viruses, and worst of all, you are running low on soda. This is a two player co-op game where cooperation is essential for dealing with all of the emergencies that come your way.

Start the game from the main menu scene.


## Press Kit and Trailer
[Press Kit](https://github.com/aakim-git/PDFs/blob/master/Press%20Kit.pdf)<br/>
[Trailer](https://youtu.be/24c4bITD9aY)

Our Press Kit and Trailer highlights exciting gameplay, and iconic moments, like different minigames and even starting the game and viewing the main menu.


## Gameplay explanation ##
#### Basic controls:
Player 1 moves with the WASD keys, and uses the F button for commands. <br/>
Player 2 moves with the IJKL keys, and uses the H button for commands. <br/>
Minigames are activated and played using only your Command button. <br/>
Pause the game using the ESC button <br/>

The amount of minigames and what they do might be a little overwhelming at first, but hopefully this explanation will make everything a little bit more intuitive.

#### Minigame 1: Refueling Game
This minigame is found at the leftmost part of the map. The goal of this minigame is to refuel your ship. There are three engines and thus three fuel gauges. If you let some run out, your ship speed (as shown in the upper left corner), will decrease. Refueling your ship will keep the ship going.

The three bars represent your ships three fuel tanks. If some are empty your ship will move slower. Hold down the Command button to refuel and watch your fuel gauge increase. Let go of the command button to change which fuel gauge you are targeting. The main engine is more powerful than the auxilary ones.

#### Minigame 2: Missile Game
This minigame is found in the left-bottom corner of the map. Occasionally, an asteroid will appear, indicated by the message, "Asteroid approaching. Use missiles to shoot it down!". The goal of this minigame is to destroy the asteroids and keep your ship healthy.

Keep the yellow cursor on top of the red target. Once the bar to the right fills up, the asteroid will be destroyed. Be mindful of your Missile Count, which is shown on the bottom-left UI panel. This Missile Count will regenerate over time, and you will not be able to shoot asteroids if the count is 0.

#### Minigame 3: Shields Game
This minigame is found in the middle-bottom corner of the map. The goal of this minigame is to replenish your Shields meter, which is shown on the bottom-left UI panel. Over time, this meter will decrease gradually, making your ship take more damage from asteroids if it is empty.

Hold the Command Button to fill the middle bar. The more full the middle bar is before you release it the more your Shields will be replenished. If you time your release correctly and align the moving red bar with the green diamond when you release, you will gain 5 times the amount of Shields.

#### Minigame 4: Laser Game
This minigame is found in the middle-top corner of the map. The goal of this minigame is to relieve boredom, which occasionally appears as an emergency.

Press the Command Button to shoot lasers, and try to shoot down the asteroids on the screen. You cannot continue firing if the red bar on the bottom fills up, indicating that your lasers are currently overheated.

#### Minigame 5: Virus Game
This minigame is found in the rightmost side of the map. Occasionally, the ship will be infested with viruses, which will slow the ship down. The goal of this minigame is to take care of this emergency.

Press the Command Button to delete a pop-up window. Mash until all the windows are closed. Windows will gradually reappear over time.

#### Minigame 6: Refueling Oil Barrel Count
This action can be done in front of the two green barrels on the map. In order the refuel your ship, you must bring oil barrels to the Refueling game.

Press the Command Button to let your player carry an oil barrel. Now, navigate your character to the Refueling game. Hold the command button to tilt the barrel upwards. If you hold the command button after it has reached the top it will instead push it down, so you should release the button when you get the barrel upright. Be careful, as if the black barrel reaches 90 degrees, the barrel will spill, and you will have to start all over again.

#### Minigame 7: Soda
This minigame is found in the upper-right corner of the map. Soda increases your players speed, which can be extremely valuable.
To play, wait for the bar in the middle to fill up. The more it is filled up, the more speed boost your player will get. Drink the can by pressing the command button again

#### Minigame 8: Radar
This minigame is found at the top of the ship. Every 10 seconds a new scan will require review. Unreviewed scans will slow down your ship. At the station you have to count the number of blips there are in the scan by pressing the command button the right amount of times before the time bar on top of it finishes. If you are correct it will reduce the number of scans required to review by 1. Else you will have to try again.


# Main Roles #
## User Interface
The UI in this game gives the user a clear overview of the status of the ship. We have a Time panel which displays the ship's progress towards its destination, an Alerts panel that displays any incoming emergencies, and more.

*Observer Pattern* - Most of the UI in this game plays off of an observer pattern. For example, the Shields minigame publishes data to   the ShieldBarManager. The ShieldBarManager is watched by the UI, and updates to the Shield meter in this way. You can see how the ShieldBarManager informs the UI here: [ShieldBarManager](https://github.com/glaive345/162FinalProject/blob/7aedb5356aa1619ed8ca9e6dd5ec28e5be099e25/Deep%20Space%20Delivery/Assets/Scripts/UI%20Scripts/ShieldBarManager.cs#L7) (shieldBar is the UI element displaying the shield meter). The Shields minigame publishes information through the changeBar() function.



## Movement/Physics
There are number of different movement and physics systems in this game, implemented in the different minigames and the players.

*Lerp* - A number of objects make use of lerp. For example, the asteroid uses lerp to head towards the ship. Or the barrel in Minigame 6 uses lerp to accelerate to 90 degrees, as to imitate real life and gravity. [Lerp](https://github.com/glaive345/162FinalProject/blob/b9bdf6aef0ac79e108247b580c18e960e27de9d4/Deep%20Space%20Delivery/Assets/Scripts/Interactable%20Objects/MissileZone.cs#L112).

Some minigames use eccentric movement systems, like in the Shields game. There is a red bar which must move around a circular meter. We do this using the function RotateAround(). [Circular Motion](https://github.com/glaive345/162FinalProject/blob/b9bdf6aef0ac79e108247b580c18e960e27de9d4/Deep%20Space%20Delivery/Assets/Scripts/Interactable%20Objects/ShieldZone.cs#L55).

Then, with the players, we implement a Command pattern closely resembling the work we did for Assignment 1 with the Pirates. Some of that code can be seen [here](https://github.com/glaive345/162FinalProject/blob/8e63e2ceea99e9f5bc50cf1020c0efb3efe36329/Deep%20Space%20Delivery/Assets/Scripts/Movement/IPlayerCommand.cs#L7) and [here](https://github.com/glaive345/162FinalProject/blob/8e63e2ceea99e9f5bc50cf1020c0efb3efe36329/Deep%20Space%20Delivery/Assets/Scripts/Movement/P1Controller.cs#L24).

## Animation and Visuals

Visuals<br/>
https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-116333
https://assetstore.unity.com/packages/3d/environments/sci-fi/space-shooter-asteroids-96444
https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-battery-pack-free-19738
https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-barrels-40-sample-92986
https://assetstore.unity.com/packages/3d/props/pbr-sci-fi-exterior-props-console-120601
https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-door-21813
https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-anti-air-rocket-tower-8-variants-91367
https://assetstore.unity.com/packages/3d/environments/sci-fi/simple-sci-fi-turret-25015
https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913
https://assetstore.unity.com/packages/3d/characters/humanoids/scifi-robots-113422
https://assetstore.unity.com/packages/3d/environments/industrial/equipment-for-industrial-or-sci-fi-building-82846
https://assetstore.unity.com/packages/3d/environments/sci-fi/msfmc-radar-dish-52701
https://assetstore.unity.com/packages/3d/environments/3d-scifi-kit-starter-kit-92152


<br/>
The purpose of the visuals was to make sure that everything was noticeable and easily figured out as we didn't want things to be too confusing as there would be a lot of things happening at a time. The assets tried to keep to a sci-fi theme to help keep the player immersed.

We tried our best to choose visuals that enhance game feel. In particular, we think that the player movement animations feel really good, and really enhance the experience of the speed boost you get from the SodaMinigame. Also, there are some particle systems thrown around to give a sense of realism, like in [here](https://github.com/glaive345/162FinalProject/blob/6fd59f3d99de645c58e781ad4befbf9814dfdb72/Deep%20Space%20Delivery/Assets/Scripts/Interactable%20Objects/MissileZone.cs#L327).

## Input
Player1 uses  WASD to navigate and F to interact with stations. Player 2 uses IJKL to navigate and H to interact with stations.<br/>

*Command Pattern* - The players' movement scripts are encapsulated using the command pattern interface. During update of the PlayerController script, the binded key strokes would invoke the execute function in the movement script and trigger the players' gameobjects to move accordingly. Using the Command Pattern makes it easier to call the desired function without needing the information of exact class names. It also makes it so that the controller script doesn't have to fix the specific keys, and that the players of the game can select their own key bindings. [The command interface](https://github.com/glaive345/162FinalProject/blob/master/Deep%20Space%20Delivery/Assets/Scripts/Movement/IPlayerCommand.cs).

## Game Logic
*Observer Pattern* - The game is centered around a Observer / Watcher design pattern. The UI watches and receives updates from the minigames. And in turn, the minigames watch the EventManager, who keeps track of which minigames are active and their states (such as GameActive, which indicates if a player is currently playing a minigame and EventActive, which indicates if an emergency has been initiated), and generates events accordingly.

More specifically, in EventManager, we have a list of tuples containing the name of a minigame and how long they have been active. Then, it generates a random minigame that is not active. Minigames signal when they are complete through the function ReturnFunction(stringMinigameName), which tells the manager to pop it out of the list. [This](https://github.com/glaive345/162FinalProject/blob/b9bdf6aef0ac79e108247b580c18e960e27de9d4/Deep%20Space%20Delivery/Assets/Scripts/EventManager.cs#L32) is a link to the EventManager's eventList, a list of 'tuples', which the EventManager frequency modifies.


# Sub-Roles
## Audio
SFX<br/>
https://freesound.org/people/Taira%20Komori/sounds/212071/
https://freesound.org/people/Galbenshire/sounds/464577/
https://freesound.org/people/jjhouse4/sounds/203038/
https://freesound.org/people/Masgame/sounds/347544/
https://freesound.org/people/Robotter112/sounds/418988/
https://freesound.org/people/cmusounddesign/sounds/84710/
https://assetstore.unity.com/packages/audio/sound-fx/weapons/ultra-sci-fi-game-audio-weapons-pack-vol-1-113047
https://assetstore.unity.com/packages/audio/sound-fx/sci-fi-sfx-32830
<br/>
Music<br/>
https://www.newgrounds.com/audio/listen/464352
https://assetstore.unity.com/packages/audio/music/electronic/sci-fi-music-loops-pack-120186
<br/>
The audio was implemented through a single audio source as the main camera was held still. The different minigames would play certain sounds when they got to certain parts of the script. The background music was chosen to try to keep a high intensity and frentic feel to the game.

## Gameplay Testing

Full result is included in the git repository under UserTesting.csv.<br/>


Some key findings are as follows<br/>
-Too much elements are going at the same time without any prior notice/instructions on how to deal with them.<br/>
-Objective of the game is unclear and some users thought the objective of the games were based on the minigames, not reachign the destination<br/>
-There are lack of instructions in the beginning and too much minigames to keep track of <br/>
-not enough visual indicators that actually tell what needs to be done and what has happened so far.<br/>


## Narrative Design
The story is that these guys are lowly space delivery men. They are not paid well, and so have to do with this bumbling, disorganized ship. We try to instill this narrative throughout the game. For example, you can see that the popups in the minigame are from Windows XP, the oil barrels are behind doors, and the door can only be opened with the help of another person. We are hoping it implies that this is a poorly managed and cheap ship.



## Game Feel
We chose assets carefully to give a certain flavor to the gameplay. For example, at first for the virus minigame, we had gray squares. But adding the Windows XP Warning window triggers much more emotion and nostalgia. Or just for the ship, the assets were chosen carefully to make the world feel real.

Various particle systems are put in place to enhance realism and give a sense of completion to events. For example, particles when an asteroid is destroyed, or particle systems in the background to imitate a spaceship engine running.

Sounds were carefully chosen for each minigame to give affirmation and a sense of progress.
