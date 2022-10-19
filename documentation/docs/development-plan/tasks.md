---
sidebar_position: 2
---

# Tasks

1. Level Generation
    - Procedurly generate Map and opsticles
    - Have number of boxes increment per set of levels (Increase Difficulty) (I.E. Level 1-4 3 boxes, 5-10 5 boxes)
    - Allow player to select how many boxes they want (Challenge Mode)
    - Make procedural generation work for multiplayer 

1. Create login
    - Create Login Screen (~1 point)
    - Create Sign up screen (~1 point)
    - connect with API to allow users to create accounts and sign in with exsisting ones.
    - Add all buttons/scripts related (~2 points)

2. Database
    - Create local SQL server
    - Create Sokroban Database
    - Create Tables for PlayerInfo,LevelStats, and PlayerStats

3. Menu Interfaces
    - Main Menu
        - Desgin Main Menu screen
        - Create navigation buttons to take players to SinglePlayer/Multiplayer/Leaderboard
    - SinglePlayer
        - Design Single Player Screen
        - Create button/and logic for  starting challenge mode
    - Multiplayer Screen 
        - Design Multiplayer screen
        - Create buttons/and logic for Joining lobby
        - Create buttons/and logic for Hosting lobby
        - Create Input field for room name 

4. Create levels for single-player (Story mode/Challenge Mode)
    - Incorporate procedural level generation (mentioned above)
    - Create undo button
    - Create Timer 
    - Create Point system algo (Decriments by number of moves)
    - Setup grid movement system (~5 points)

5. Challenge Mode
    - Everything from Single Player 
    - No undo button
    - can choose number of boxes they want to deal with (Levels will scale accordingly)

6. Create/Implement Photon multiplater server
    - Create a live Multiplater photon server 
    - Implement code to allow multiplayer functinoallity (~3 points)

7. Multiplayer
    - Allows 2-20 player to join a game for co-op 
    - 2 player competitive mode 
    - For competitive has oppentents ghost visible on screen
    - After connection make sure each player is controlling only one sprite (~ 2 points)
    - CO-OP: Make sure buddies sprite is interactible(Not ghost)
    - 2 player competitive mode 
    - For competitive has oppentents ghost visible on screen
    - Make sure level and number of boxes scales for number of players in lobby

8. API
    - Host API in the cloud via Azure
    - Create Model
    - Create Controller to handle login/Save/ and Leaderboard functionallity
    - Create Swagger UI
    - Connect API to DB
    - Connect API to Sokroban

9. Save Function
    - Add script/function to send the level number to the database (~2 points)
    - Add script/function to send the current player score/time to the database (~2 points)
    - Add script to obtain level from DB when  loading save
    
10. Leaderboards Tab
    - Add script to pull the top scores/ names from the database (~2 points)
    - Display the scores/names (~1 point)
    - Have current users Name/Score/level/time displayed at the top of the screen above leaderboard
