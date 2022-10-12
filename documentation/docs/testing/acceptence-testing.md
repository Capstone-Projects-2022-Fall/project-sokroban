---
sidebar_position: 3
---
# Acceptance test

1. Sokroban Home Screen Page

Open Sokroban and enter a username and password and hit either “Login” or “Sign Up”, whichever is appropriate to the situation.

- Expected Result: If the credentials entered match an existing account and the “Login” is pressed the user will be logged in but if “Sign Up” is clicked an error will tell the user the account already exists. On the other hand, if the account does not exist and “Login” is pressed, the user will be told to create an account, so when they click “Sign Up” the account will be made with the entered credentials and the user will be taken to the Main Menu Screen

<!--![Home Screen Page](/documentation/static/img/Homescreen.jpg)-->



2. Playing Singleplayer 

Press the single-player button on the main menu screen. On the lobby screen, choose the number of crates that will be present on the map and press start. The user will be moved to the game scene.

- Expected outcome: Player is able to enter a single-player lobby where they can enter the number of crates(boxes) they want. Based on this number the level size will be scaled and generated on the Game Screen.

<!--![Main Menu Screen](/documentation/static/img/singleplayer1.jpg)

![Single Player Lobby](/documentation/static/img/singleplayer2.jpg)

![Game Screen](/documentation/static/img/singleplayer3.jpg) -->


3. Playing Multiplayer (Co-op)

Press the multiplayer button and wait for the loading to finish. Once connected to the server and the Multiplayer Lobby screen either enter a valid room name to join or create a new room by entering a name and selecting a game mode.If you creating a room, there will be an option to select the number of crates(boxes). The Player will then get sent to the game screen. When creating the room choose Coop in order to play with another player

Expected outcome: Multiple players are able to play co-op by landing in the same generated map.


<!--![Main Menu Screen](/documentation/static/img/Multiplayer1.jpg)

![Loading Screen](/documentation/static/img/Multiplayer2.jpg)

![Multiplayer Lobby Screen](/documentation/static/img/Multiplayer3.jpg)

![Multiplayer Lobby Screen](/documentation/static/img/Multiplayer4.jpg)

![Game Screen](/documentation/static/img/Multiplayer5.jpg)

![Game Screen](/documentation/static/img/Multiplayer6.jpg) -->

4. Playing Multiplayer (VS)

Press the multiplayer button and wait for the loading to finish. Once connected to the server and the Multiplayer Lobby screen either enter a valid room name to join or create a new room by entering a name and selecting a game mode.If you creating a room, there will be an option to select the number of crates(boxes). The Player will then get sent to the game screen. When creating the room choose Versus in order to play against another player

Expected outcome: Two players are able to compete head to head by landing in two instances of the same generated map in the form of splitscreen.







