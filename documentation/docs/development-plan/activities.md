---
sidebar_position: 1
---

# Activities

# Requirements Gathering
During the requirements gathering every member of our team researched a different version of the original game "Sokoban". Our group decided to add different features that were missing from the original game. Our goal was to make the game more competitive, by adding a multiplayer option along with highscores, and finally, more interesting by adding a story mode.<br/>   
Our team will also conduct User Acceptance Testing by providing different prototypes to users and ask them to perform different Use Cases. Based on the user's feedback and overall experience we will be updating our requirements accordingly in the future as the development goes on.


# Top Level Design 
1. Create a welcome screen that will allow the user to log into their  existing account or create a new account or as a guest.
2. Create Main Menu that will allow the user to navigate through the 3 main options of the game (Single player, Multiplayer, and Leaderboard).
3. Establish Database.
4. Create Single Player option that will allow the user to play locally on generated level.
5. Create cloud hosting server that will hold DB and API (utilizing Azure).
6. Establish multiplayer server utilizing Unity's Photon networking service.
7. Create Multiplayer (Co-op) option that will allow users to solve a generated level together.
8. Create Multiplayer (VS) option that will allow users to compete against each other on two instances of the same generated map (split screen).
9. Incorporate existing algorithm into our game that will procedurally generate maps in every playable mode of the game. 
10. Establish an API that wil connect to our database and take user login and allow them to retrieve previous scores and upload new ones.
11. Build leaderboard page that will show users who hold the top scores.


# Detailed Design: 
1. Icorporate level generator algorithm into our game:
    - This algorithm will be used in every playable mode of the game.
    - The user will be asked to input a number of boxes they wish to have onto the map.
    - The generator will generate a map with the inputted amount of boxes from the user.

2. Create a Single Player mode:
    - The user will be asked for the requested amount of boxes they wish to have on the generated map.
    - The user will be shown the generated map.
    - The user will have an Undo option to undo the previous move (all the way up to the beginning of the level).
    - The user will have a reset button to reset the generated level.
    - The user will have a leave game button to exit the game and go back to main menu.
    - The user will be shown the time they spent while playing.

3. Create a connection with the server:
    - There will be a dedicated PhotonEngine server for the game.
    - When two players try to connect to each other they will be connecting to the server.

4. Create multiplayer (Co-op) :
    - There will be a choice whether to create or join a lobby and a text box that allows a name to be entered.
    - One player will create a lobby with a title. Then the same player will input the amount of boxes they wish to have onto the map.
    - The other player will insert the name and select the join room option.
    - Both players will be on the same generated map.

5. Create multiplayer (VS) :
    - There will be a choice whether to create or join a lobby and a text box that allows a name to be entered.
    - One player will create a lobby with a title. Then the same player will input the amount of boxes they wish to have onto the map.
    - The other player will insert the name and select the join room option.
    - Both players will be shown the same generated map but in a split screen.
    - The player that completes the level first will win the game.
    - An option to play again will be shown to both players after the completion of the level.

6. Create Database:
    - Using SSMS.
    - Will hold Usernames and Passwords.
    - Will keep record of a players high score.

7. Create API:
    - Create using .NET.
    - Host on Azure.
    - Will be used to pass data between Game and DB.

8. Create login:
    - The login page will be the first screen the player sees.
    - There will be two input fields for the username and password.
    - There will be a “login” button.
    - There will be a “sign up” button.
    - There will be a "Guest" button. 

9. Main Menu Interface:
    - The interface will include:
        - Single Player option.
        - Multiplayer option.
        - Leaderboard button that shows the player what the leaderboard currently is.
        - An exit button for leaving the game.

10. Leaderboards Tab:
    - There will be a button on the menu that leads to the leaderboards.
    - The score will be calculated based on the complexity of the level finished by the user(number of boxes they selected).
    - The score will consider the number of player's moves, the time it took to complete the level, the number of undos and the number of resets.
    - The score will reset when the game is exited, meaning, that when a player starts a level their score will be counting up until they exit to the menu or desktop.
    - Therefore in order to earn the most score possible, the player will need to keep playing until they reach the highest score.
    - The high scores of everyone that has played the game will be posted on the leaderboards menu.
    - The high score will be performance playing the single player and multiplayer. 


# Test
1. Unit Testing:
    - Play Mode tests: Our team will create unit tests that will test the execution of scripts required in a running scene.
    - Edit Mode tests: Our team will create unit tests that will test the scripts required for basic functionalities(s.a. direction class etc).
2. Functional Testing:
    - Our team and others(we will select different people and ask them to try and complete our use cases) will test the functionality of our game and will try to look for any possible problems within our game or the user interface and the graphics, such as game mechanic issues, stability issues and game asset integrity.
3. Integration Testing:
    -  Our team will be testing using with unity test framework to ensure of our each use case(user stories). It should provide mock objects and results For this testing accomplishment. 
4. Acceptance Testing:
    - Our team will create all tasks of testing for functional and non-functional requirements for our Sokroban game. We will make sure our game is compatible across every machine it is supposed to run on.
