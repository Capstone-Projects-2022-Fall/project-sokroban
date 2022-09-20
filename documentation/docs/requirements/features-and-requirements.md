---
sidebar_position: 4
---

# Features and Requirements

1) Functional Requirements: 

- Single-player
    - Players will be tasked with solving increasingly difficult procedurally generated levels.
    - Players will "SOLVE" a level by moving a varying number of crates around obsticles to marked squares on the map. 

- Multiplayer 
    - Players will be able to complete levels of Sokroban with a friend.
    - The players will be put in a lobby where they can choose to host a game or join a friends, once in a game they choose where theyd like to begin from the levels they've completed.
    - While in a game, players will be able to see a "ghost" of the other player as they maneuver around the warehouse.
    - High scores will be calculated at the end of each level so players can see who the most effective player is.

- Story mode
    - In the single-player version of the game, the player will experience a story mode.
    - The player will learn about the warehouse and how the worker got stuck, trying to make their way out.

- High score 
    - A high score is a feature that will keep the game engaging, and have a sense of competitiveness.
    - The high score feature will take the number of moves, amount of retries, and time that is taken to finish the level to calculate an appropriate score for the player.

- Automatic save 
    - After each completed level the users Level counter will be updated in the database signifying which level the player is currently on. If a player loose and gets sent back to the beginning of the game, the counter will be reset.
    - This will allow the game to have a sense of progretion, as opposed to just replaying an endless loop. 

- Database Data
    - Username and Password: The player will choose to either login with an account they have already created; Create and account if they are a first time user or, if they wish to simply play as a guest they can do that as well. Playing as a guest however will not allow a player to save their scores,times,or level progress.
    - HighScores: The game will feature a leaderboard that will allow players to view the high scores and fastest times of other players. 


2) Nonfunctional Requirements:

 - Level generator
    - The levels will be procedurally generated, giving a unique experience each time the game is played.

 - Skins
    - The players will have the choice to choose different skins for their character.
    - This will be an additional menu option, that the player can access on the main menu.

 - Hard mode 
    - This mode will consist of more constraints, such as a timelimit, set number of retries, and additional obstacle.
    
 - Puzzle complexity 
    - A box will be added that is made specifically for multiplayer, this box is linked to the same colored box on the other player's screen and will move in unison with it. If only one player moves it, the box on the other screen will move as well. This gives some interesting opportunities in terms of complexity.
    - Holes will provide the player with another level of puzzle complexity, by making them have to put a box inside the whole in order to traverse the character around certain parts of the map.
