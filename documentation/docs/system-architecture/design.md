---
sidebar_position: 1
---

# Database Table
![Database Table](/img/DbTable.png)

Sokrobans reliance on a database is very minimal, though crucial. The DB will only need to store the players Username(varchar,NOT NUll), Password(varchar,NOT NULL), HighScore(int), best time(time), and level(int).UserName and Password are the only two fields in the DB that are marked as NOT NULL, due to the simple fact that a user must have an account in order to "save" any data. One table is all that will need to be created in order to store the inforamtion and be utilized to pass data back and forth between the API.


# API Diagram
![API Diagram](/img/API.png)

Sokroban will utilize an RESTful API hosted via Azure to pass player data back and forth between the game and the database. A player's high score, best time and level will all be saved.The best time, high score, and level will be updated after every "run" the game will check with the DB to see if any of the fields have been topped and replace update the data in the table. There will also be a leaderboard that will display the table in the database (minus the user password of course) filtered by top score overall.