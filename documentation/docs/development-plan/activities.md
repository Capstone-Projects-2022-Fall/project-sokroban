---
sidebar_position: 1
---

# Activities

# Requirements Gathering
During the requirements gathering every member of our team researched a different version of the original game "Sokoban". Our group decided to add different features that were missing from the original game. Our goal was to make the game more competitive, by adding a multiplayer option along with highscores, and finally, more interesting by adding a story mode.<br/>   
Our team will also conduct User Acceptance Testing by providing different prototypes to users and ask them to perform different Use Cases. Based on the user's feedback and overall experience we will be updating our requirements accordingly in the future as the development goes on.

# Top Level Design 
1. Create a welcome screen that will allow the user to log into their  existing account or create a new account.
2. Create cloud hosting server that will hold DB and API (utilizing Azure).
3. Establish Database.
4. Establish an API that wil connect to our database and take user login and allow them to retrieve previous scores and upload new ones.
5. Create Main Menu that will allow the user to navigate to the 3 main areas of the game (Single player, Multiplayer, and Leaderboard).
6. Incorporate existing algorithm into our game that will procedurally generate maps in every playable mode of the game.
7. Establish multiplayer server utilizing Unity's Photon networking service.
8. Create Multiplayer (Co-op) option that will allow users to solve a generated level together.
9. Create Multiplayer (VS) option that will allow users to compete against each other on two instances of the same generated map (split screen). 
9. Create Single Player option that will allow the user to play locally on generated level.
10. Build leaderboard page that will show users who hold the top scores/times.


# Detailed Design: 
1. Create login:
    - The login page will be the first screen the player sees.
    - There will be a “login” button.
    - There will be a “sign up” button.
    - There will be a “play as guest” button.
2. Create cloud hosting:
    - Acquire a cloud server through AWS or Azure.
    - Hosts DB.
    - Hosts API.
3. Create Database:
    - Using SSMS.
    - Will hold Usernames and Passwords.
    - Will keep record of a players high score and fastest time.
4. Create API:
    - Create using .NET.
    - Host on AWS or Azure.
    - Will be used to pass data between Game and DB.
5. Main Menu Interface:
    - The interface will include:
        - Play button that further asks the player whether they want to play single-player or multiplayer.
        - Leaderboard button that shows the player what the leaderboard currently is.
        - An exit button for leaving the game.
6. Create levels for single-player/Story mode:
    - There will be text bubbles that pop up during each level telling the story of the worker at the warehouse.
    - These text bubbles will also include a tutorial on what the controls are.
    - There will be a beginning few levels in single-player.
7. Create a connection with the server:
    - There will be a dedicated PhotonEngine server for the game.
    - When two players try to connect to each other they will be connecting to the server.
8. Create multiplayer levels:
    - There will be a choice whether to create or join a lobby and a text box that allows a name to be entered.
    - One player will create a lobby with a title.
    - The other player will put in the name and join the lobby.
9. Save function:
    - At the completion of every level, this will occur:
        - The game will send the database the current level number as the furthest completed level.
        - The game will also send the high score of the player at the time that they beat the level.
        - This will make it so that when the player returns to the game their level progress will be saved.
10. Leaderboards Tab:
    - There will be a button on the menu that leads to the leaderboards.
    - The score will be calculated based on the completion of each level, a score will be calculated based on moves and retries.
    - The score will reset when the game is exited, meaning, that when a player starts a level their score will be counting up until they exit to the menu or desktop.
    - Therefore in order to earn the most score possible, the player will need to start at level 1 and go all the way to the finish.
    - The high scores of everyone that has played the game will be posted on the leaderboards menu.


# Test
1. Unit Testing:
    - Play Mode tests: Our team will create unit tests that will test the execution of scripts required in a running scene.
    - Edit Mode tests: Our team will create unit tests that will test the scripts required for basic functionalities(s.a. direction class etc).
2. Functional Testing:
    - Our team and others(we will select different people and ask them to try and complete our use cases) will test the functionality of our game and will try to look for any possible problems within our game or the user interface and the graphics, such as game mechanic issues, stability issues and game asset integrity.
3. Compatibility Testing: 
    - Our team will make sure our game is compatible across every machine it is supposed to run on.
