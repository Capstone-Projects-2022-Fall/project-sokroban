---
sidebar_position: 1
---

# Database Table
![Database Table](/img/ERD.png)

Sokrobans reliance on a database is very minimal, though crucial. The DB will only need to store the players Username(varchar,NOT NUll), Password(varchar,NOT NULL), HighScore(int), best time(time), and level(int).UserName and Password are the only two fields in the DB that are marked as NOT NULL, due to the simple fact that a user must have an account in order to "save" any data. One table is all that will need to be created in order to store the inforamtion and be utilized to pass data back and forth between the API.


# API Diagram
![API Diagram](/img/API.png)


Sokroban will utilize an RESTful API hosted via Azure to pass player data back and forth between the game and the database. A player's high score, best time and level will all be saved.The best time, high score, and level will be updated after every "run" the game will check with the DB to see if any of the fields have been topped and replace update the data in the table. There will also be a leaderboard that will display the table in the database (minus the user password of course) filtered by top score overall.



A description the different components and their interfaces. For example: client, server, database.

For each component provide class diagrams showing the classes to be developed (or used) and their relationship.

Sequence diagrams showing the data flow for _all_ use cases. One sequence diagram corresponds to one use case and different use cases should have different corresponding sequence diagrams.

Describe algorithms employed in your project, e.g. neural network paradigm, training and training data set, etc.

If there is a database:

Entity-relation diagram.

Table design.

A check list for architecture design is attached here [architecture\_design\_checklist.pdf](https://templeu.instructure.com/courses/106563/files/16928870/download?wrap=1 "architecture_design_checklist.pdf")  and should be used as a guidance.




# UML Diagram

![UML Diagram](/img/UML_SOK.png)

At the top of this diagram we explore how classes interact with the UI. Firstly we have different components of the Game UI like Timer, Level Count etc. all interacting with the Game UI interface. We also show how scene managers like MainMenuManager interact with each other and the UI and with the Canvas. The Canvas is where all UI components are displayed.

In the center we focus on the multiplayer and API aspects of our game. The CreateAndJoinRoom and the ConnectionToServer classes handle the connection to Photon and the connection between the players. The leaderboard and AccountHandler, take care of the sign in/login and the leaderboard functions.

At the bottom our classes represent the level generation and how each class works with one another. A lot of the classes derive from another like, Templates deriving from Template, deriving from Cell each class taking care of a smaller part of the larger generation. Then when we reach the Level class we sum up all the calculations of the previous classes and produce a level which the LevelTranslator turn into a playable Unity level

To the right we have the Unity objects. This mainly consists of prefabs like Player, Box, Wall, Ground, and Target. These are what the player will be using to interact and each of these prefabs is very important as they are using by the LevelGenerator to specify where to spawn each prefab. Each prefab also has connected components like Transform (showing position and size), Sprite Renderer (showing what the object will look like), and other classes that might give the object function, like movement and so on.

# Sequence Diagrams 


### Use Case 1: Player wants to successfully register their account and then exit the game

<details>
<summary>
Use Case 1 Description
</summary>

1)	Player upon opening the application is prompted to create an account or to sign in.<br/>
2)	Player selects the option to create a new account.<br/>
3)	Player inputs a username and a password.<br/>
4)  Upon completion, player logs into account with their credentials.<br/>
5)	Player enters to the main Menu.<br/>
6)	Player exits the game by pressing the “X” button.<br/>

<UseCase1 />
</details>

![Figure ](/img/UseCase1pic.png)

### Use Case 2: Player wants to play Normal Mode (Single Player)

<details>
<summary>
Use Case 2 Description
</summary>

1) Player selects the Single Player Mode option.<br/>
2) Player is viewing the three choices of Single Player.<br/>
3) Player selects Normal Mode.<br/>
4) A level is generated for the player.<br/>
5) Player is now playing the game.<br/>

<UseCase2 />
</details>

![Figure2](/img/UseCase2pic.png)


### Use Case 3: Player wants to play Challenge Mode

<details>
<summary>
Use Case 3 Description
</summary>

1) Player selects the Single Player Mode option.<br/>
2) Player is viewing the three choices of Single Player.<br/>
3) A level is generated for the player. <br/>
4) Player is now playing the game without the reset or undo buttons available.<br/>

<UseCase3 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase3pic.png)


### Use Case 4: Player wants to play a game with a friend

<details>
<summary>
Use Case 4 Description
</summary>

1)  Player selects the Multiplayer Mode option. <br/>
2)  Player selects the Co-op option. <br/>
3)  Player sets up a lobby by creating a room and tells their friend the name of the room to join.<br/>
4)  Both players are on the same map.<br/>
5)  Players are helping each other in order to win the level.<br/>

<UseCase4 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase4pic.png)


### Use Case 5: Player wants to play a game against a friend

<details>
<summary>
Use Case 5 Description
</summary>

1)  Player selects the Multiplayer Mode option.<br/>
2)  Player selects the VS option.<br/>
3)  Player sets up a lobby by creating a room and tells their friend the name of the room to join.<br/>
4)  Players are competing on the same level in a split-screen.<br/>
5)	Player gets the boxes into the end point faster than their friend.<br/>
6)  Player won the game.<br/>

<UseCase5 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase5pic.png)


### Use Case 6: Player wants to check high scores

<details>
<summary>
Use Case 6 Description
</summary>

1)	Player selects the High Scores option.<br/>
2)	Player views high scores.<br/>

<UseCase6 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase6pic.png)


### Use Case 7: Player wins level

<details>
<summary>
Use Case 7 Description
</summary>

1)	Player selects Normal Mode option.<br/>
2)  A level is generated for the player.<br/>
3)  Player starts to move the character and push the box by using the arrows on the keyboard.<br/>
4)	Player places the box onto the target.<br/>
5)	Player wins the level.<br/>

<UseCase7 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase7pic.png)

### Use Case 8: Player gets stuck and resets the level

<details>
<summary>
Use Case 8 Description
</summary>

1)	Player selects Normal Mode option.<br/>
2)	Player moves the character and pushes the box(es) trying to win the level.<br/>
3)	Player realizes that got stuck by pushing a box onto the wall and won’t be able to place the box onto the target.<br/>
4)	Player resets the level by pressing the reset button.<br/>
5)	The level resets with the character and the box(es) back to their starting positions.<br/>

<UseCase8 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase8pic.png)


### Use Case 9: Player wants to play with a different character

<details>
<summary>
Use Case 9 Description
</summary>

1)  Player selects Single Player option.<br/>
2)  Player selects their favorite character from a variety of characters.<br/>
3)  Player starts playing with the chosen character.<br/>

<UseCase9 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase9pic.png)


### Use Case 10: Player wants to challenge themselves onto a map with complex design

<details>
<summary>
Use Case 10 Description
</summary>

1)  Player selects Single Player option.<br/>
2)  Player selects from a variety of maps with complex deisgn.<br/>
3)  Player plays the game with a more complex designed map.<br/>

<UseCase10 />
</details>

![Use Case 1 Sequence Diagram](/img/UseCase10pic.png)



