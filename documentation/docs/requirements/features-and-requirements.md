---
sidebar_position: 4
---

# Features and Requirements

1) Functional Requirements: 

- Single-player
    - The player will be able to play a chosen level of Sokroban in a single-player experience by choosing the single-player mode.
    - There the player can move the boxes in the warehouse to the glowing points in order to win.

- Multiplayer 
    - The player will be able to play a chosen level of Sokroban in a multiplayer experience.
    - The players will be put in a lobby after they enter the codes needed to join each other's game then they can find the level that both the players have unlocked.
    - The players will be able to see each other playing in their own space/version of the warehouse.
    - Players will be competing for who gets the higher score.

- Story mode
    - In the single-player version of the game, the player will experience a story mode.
    - The player will learn about the warehouse and how the worker got stuck, trying to make their way out.
- High score 
    - A high score is a feature that will keep the game engaging, and have a sense of competitiveness.
    - The high score feature will take the number of moves, amount of retries, and time that is taken to finish the level to calculate an appropriate score for the player.
- Automatic save 
    - After each completed level the account the player is currently using will be updated on the database. 
    - There the level they have reached will be stored, so if the player comes back they can start where they left off.
- Username/password
    - The player will choose to either start their game using an account they have made, or they will be prompted to make one. If they do not want to deal with an account they could just start the game as a guest, but their progress will not be saved.
    - The saved levels and high score of the user will be useful in order to retrieve the level for the player to start where they left off, and the high score will be when someone presses the “high score” button and the high score of all players that have played will be shown.


2) Nonfunctional Requirements:

 - Level generator
    - The levels will be procedurally generated, giving a unique experience each time the game is played.

 - Different characters 
    - The players will have the choice to choose different skins of characters to play as.
    - This will be done at the start of a game, and two players cant choose the same skin to use.

 - Hard mode 
    - This mode will consist of more constraints for the player, such as a timer, and limited retries on a level before a complete restart is necessary.
    
 - Puzzle complexity 
    - A box will be added that is made specifically for multiplayer, this box is linked to the same colored box on the other player's screen and will move in unison with it. If only one player moves it, the box on the other screen will move as well. This gives some interesting opportunities in terms of complexity.
    - Holes will provide the player with another level of puzzle complexity, by making them have to put a box inside the whole in order to traverse the character around certain parts of the map.
